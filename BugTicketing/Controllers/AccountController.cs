using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using BugTicketingBL.Dtos.Authentication;
using BugTicketingDAL;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;

namespace BugTicketing.Controllers
{
    [Route("api/user")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly UserManager<User> _userManager;
        private readonly IConfiguration _configuration;

        public AccountController(UserManager<User> userManager, IConfiguration configuration)
        {
            _userManager = userManager;
            _configuration = configuration;
        }

        [HttpPost("login")]
        public async Task<Results<Ok<DtoToken>, UnauthorizedHttpResult>> Login(DtoLogin loginData)
        {
            #region Check Email
            var user = await _userManager.FindByEmailAsync(loginData.Email);
            if (user is null) return TypedResults.Unauthorized();
            #endregion
            #region Check Password
            var validPassword = await _userManager.CheckPasswordAsync(user, loginData.Password);
            if (!validPassword) return TypedResults.Unauthorized();
            #endregion
            #region Generate Token
            var claims = await _userManager.GetClaimsAsync(user);
            var secretKey = _configuration.GetValue<string>("JWT:SecretKey");
            var secretKeyInBytes = Encoding.UTF8.GetBytes(secretKey);
            var key = new SymmetricSecurityKey(secretKeyInBytes);
            var token = new JwtSecurityToken(
                expires: DateTime.Now.AddHours(2),
                claims: claims,
                signingCredentials: new SigningCredentials(key, SecurityAlgorithms.HmacSha256)
                );
            var dtoToken = new DtoToken();
            dtoToken.ExpireDate = token.ValidTo;
            dtoToken.Token = new JwtSecurityTokenHandler().WriteToken(token);
            #endregion
            return TypedResults.Ok(dtoToken);
        }
        [HttpPost("register")]
        public async Task<Results<Ok<string>, BadRequest<string>, BadRequest<List<string>>>> Register(DtoRegister registerData)
        {
            #region Check Role
            if (registerData.Roles.Count == 0)
                return TypedResults.BadRequest("Invalid role. it must be at least one of (Manager, Developer, Tester).");
            var Roles = new List<string>() { "Manager", "Tester", "Developer" };
            for (var i = 0; i < registerData.Roles.Count; i++)
            {
                if (!Roles.Contains(registerData.Roles[i]))
                    return TypedResults.BadRequest("Invalid role. it must be at least one of (Manager, Developer, Tester).");
            }
            #endregion
            #region Create User
            var newUser = new User()
            {
                Email = registerData.Email,
                UserName = registerData.UserName,

            };
            var creationResult = await _userManager.CreateAsync(newUser, registerData.Password);
            #endregion
            if (creationResult.Succeeded)
            {
                var addRoleResult = await _userManager.AddToRolesAsync(newUser, registerData.Roles);

                if (addRoleResult.Succeeded)
                {
                    #region Add Claims
                    var claims = new List<Claim> {
                        new (ClaimTypes.NameIdentifier,newUser.Id),
                    };
                    for (var i = 0; i < registerData.Roles.Count; i++)
                        claims.Add(new(ClaimTypes.Role, registerData.Roles[i]));
                    await _userManager.AddClaimsAsync(newUser, claims);
                    #endregion
                    return TypedResults.Ok("Success");
                }
                return TypedResults.BadRequest(creationResult.Errors.Select(e => e.Description).ToList());
            }
            else
                return TypedResults.BadRequest(creationResult.Errors.Select(e => e.Description).ToList());
        }
        [Authorize(AuthenticationSchemes=JwtBearerDefaults.AuthenticationScheme)]
        [HttpGet]
        //[Authorize(Policy = Constant.Policy.TesterOnly)]
        public Ok<String> test() { return TypedResults.Ok("Test"); }
    }
}
