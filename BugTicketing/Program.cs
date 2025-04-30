using BugTicketing.Validators;
using BugTicketingBL;
using BugTicketingDAL;
using FluentValidation;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.


#region Default Services
builder.Services.AddControllers();
builder.Services.AddOpenApi();
#endregion

#region Add DAL & BL Services
var Services = builder.Services;
var Configuration = builder.Configuration;
Services.AddDALServices(Configuration);
Services.AddBLExtensions();
#endregion


Services.AddValidatorsFromAssembly(typeof(ValidatorCreateDtoProject).Assembly);
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();
app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
