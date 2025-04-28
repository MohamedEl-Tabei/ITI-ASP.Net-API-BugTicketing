using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace BugTicketingDAL
{
    public static class Constant
    {
        #region Role
        public static class Role
        {
            public const string Manager = "Manager";
            public const string Developer = "Developer";
            public const string Tester = "Tester";
            public static List<string> Roles = new()
            {
                Developer,
                Tester,
                Manager,
            };
        }
        #endregion
        #region Policy
        public static class Policy
        {
            public const string ManagerOnly = "ManagerOnly";
            public const string TesterOnly = "TesterOnly";
            public const string DevelopreOnly = "DevelopreOnly";
        }
        #endregion

        #region  Seed Data
        public static class SeedData
        {
            private static class UserIds
            {
                public const string MohamedEltabei = "711a4a71-6a79-4c67-a5ff-7d38d6254a90";
                public const string KarimHelmy = "7a8bf7b6-4979-4729-bd78-80c1f39aad34";
                public const string BasemAtia = "8f4b2288-bff8-4030-927e-e32bfdc9f90f";
                public const string OmerAraby = "981fec6c-2d2a-4843-99bf-a5f9d4baf85b";
                public const string HaniAbdo = "a23bb53a-7c52-4f13-8000-188ad242f04e";
                public const string AlaaEisa = "e6c01d4f-bc6a-4fc3-afe3-62de02997dcf";
            }
            private static class RoleIds
            {
                public const string Manager = "0b172061-cc4b-416d-8559-4dcb240cd012";
                public const string Developer = "4179d4b9-6aa8-4e27-8293-9fd69b331e8a";
                public const string Tester = "bcd832ec-cae3-4b7b-baa6-f9f02b9858c0";
            }


            #region Users
            public static List<User> GetUsers()
            {

                var users = new List<User>
                {
                    new User
                    {
                        Id = "711a4a71-6a79-4c67-a5ff-7d38d6254a90",
                        UserName = "MohamedEltabei",
                        Email = "MohamedEltabei@gmail.com",
                        NormalizedUserName = "MOHAMEDELTABEI",
                        NormalizedEmail = "MOHAMEDELTABEI@GMAIL.COM",
                        PasswordHash = "AQAAAAIAAYagAAAAEIbBRmKhMQgMjXnpWE7kV5XW1EJTM1VUyaPHN/83fTdH7FF0F4TPCfPO7LayX4VgiQ==",
                        SecurityStamp = "d66b27d9-be5e-4a6e-8d32-1ebbe1209c73",
                        ConcurrencyStamp = "20081146-a801-4276-a6de-90cfad6482cb",
                        AccessFailedCount = 0,
                        EmailConfirmed = false,
                        LockoutEnabled = false,
                        TwoFactorEnabled = false
                    },
                    new User
                    {
                        Id = "7a8bf7b6-4979-4729-bd78-80c1f39aad34",
                        UserName = "KarimHelmy",
                        Email = "KarimHelmy@gmail.com",
                        NormalizedUserName = "KARIMHELMY",
                        NormalizedEmail = "KARIMHELMY@GMAIL.COM",
                        PasswordHash = "AQAAAAIAAYagAAAAEIbBRmKhMQgMjXnpWE7kV5XW1EJTM1VUyaPHN/83fTdH7FF0F4TPCfPO7LayX4VgiQ==",
                        SecurityStamp = "b2e99ab2-b261-438a-b9bf-3428da1a1e9e",
                        ConcurrencyStamp = "15968bc9-945c-491b-8926-c33725488e4d",
                        AccessFailedCount = 0,
                        EmailConfirmed = false,
                        LockoutEnabled = false,
                        TwoFactorEnabled = false
                    },
                    new User
                    {
                        Id = "8f4b2288-bff8-4030-927e-e32bfdc9f90f",
                        UserName = "BasemAtia",
                        Email = "BasemAtia@gmail.com",
                        NormalizedUserName = "BASEMATIA",
                        NormalizedEmail = "BASEMATIA@GMAIL.COM",
                        PasswordHash = "AQAAAAIAAYagAAAAEIbBRmKhMQgMjXnpWE7kV5XW1EJTM1VUyaPHN/83fTdH7FF0F4TPCfPO7LayX4VgiQ==",
                        SecurityStamp = "f7833d18-b3a1-4ebf-b0ad-680f3dfb7be0",
                        ConcurrencyStamp = "9db81390-5c91-4ab8-ad53-c158cf5fb130",
                        AccessFailedCount = 0,
                        EmailConfirmed = false,
                        LockoutEnabled = false,
                        TwoFactorEnabled = false
                    },
                    new User
                    {
                        Id = "981fec6c-2d2a-4843-99bf-a5f9d4baf85b",
                        UserName = "OmerAraby",
                        Email = "OmerAraby@gmail.com",
                        NormalizedUserName = "OMERARABY",
                        NormalizedEmail = "OMERARABY@GMAIL.COM",
                        PasswordHash = "AQAAAAIAAYagAAAAEIbBRmKhMQgMjXnpWE7kV5XW1EJTM1VUyaPHN/83fTdH7FF0F4TPCfPO7LayX4VgiQ==",
                        SecurityStamp = "3a7d3936-5157-42ca-95fc-b85e03ede5a4",
                        ConcurrencyStamp = "21df4f63-ae4b-4de9-a2f1-7a4b2f028e87",
                        AccessFailedCount = 0,
                        EmailConfirmed = false,
                        LockoutEnabled = false,
                        TwoFactorEnabled = false
                    },
                    new User
                    {
                        Id = "a23bb53a-7c52-4f13-8000-188ad242f04e",
                        UserName = "HaniAbdo",
                        Email = "HaniAbdo@gmail.com",
                        NormalizedUserName = "HANIABDO",
                        NormalizedEmail = "HANIABDO@GMAIL.COM",
                        PasswordHash = "AQAAAAIAAYagAAAAEIbBRmKhMQgMjXnpWE7kV5XW1EJTM1VUyaPHN/83fTdH7FF0F4TPCfPO7LayX4VgiQ==",
                        SecurityStamp = "baea035c-8f2c-4d5c-9972-72092c40044b",
                        ConcurrencyStamp = "15ca0019-f57e-418d-a1ef-3b91ce1279ad",
                        AccessFailedCount = 0,
                        EmailConfirmed = false,
                        LockoutEnabled = false,
                        TwoFactorEnabled = false
                    },
                    new User
                    {
                        Id = "e6c01d4f-bc6a-4fc3-afe3-62de02997dcf",
                        UserName = "AlaaEisa",
                        Email = "AlaaEisa@gmail.com",
                        NormalizedUserName = "ALAAEISA",
                        NormalizedEmail = "ALAAEISA@GMAIL.COM",
                        PasswordHash = "AQAAAAIAAYagAAAAEIbBRmKhMQgMjXnpWE7kV5XW1EJTM1VUyaPHN/83fTdH7FF0F4TPCfPO7LayX4VgiQ==",
                        SecurityStamp = "332de8d3-301c-49dd-a11b-78ab7e8dd0d4",
                        ConcurrencyStamp = "f483a3ef-4d79-4b53-b0c9-34bc6fe74b31",
                        AccessFailedCount = 0,
                        EmailConfirmed = false,
                        LockoutEnabled = false,
                        TwoFactorEnabled = false
                    }
                };
                return users;
            }



            #endregion
            #region Roles
            public static List<IdentityRole> GetRoles() => new()
            {
                new IdentityRole(){Name=Role.Manager,NormalizedName="MANAGER",Id="0b172061-cc4b-416d-8559-4dcb240cd012"},
                new IdentityRole(){Name=Role.Developer,NormalizedName="DEVELOPER",Id="4179d4b9-6aa8-4e27-8293-9fd69b331e8a"},
                new IdentityRole(){Name=Role.Tester,NormalizedName="TESTER",Id="bcd832ec-cae3-4b7b-baa6-f9f02b9858c0"},
            };
            #endregion
            #region UserRoles
            public static List<IdentityUserRole<string>> GetUserRoles()
            {
                List<IdentityUserRole<string>> usersRoles = new()
                {
                    new(){UserId=UserIds.MohamedEltabei,RoleId=RoleIds.Developer},
                    new(){UserId=UserIds.HaniAbdo,RoleId=RoleIds.Developer},
                    new(){UserId=UserIds.KarimHelmy,RoleId=RoleIds.Developer},
                    new(){UserId=UserIds.KarimHelmy,RoleId=RoleIds.Tester},
                    new(){UserId=UserIds.OmerAraby,RoleId=RoleIds.Tester},
                    new(){UserId=UserIds.BasemAtia,RoleId=RoleIds.Manager},
                    new(){UserId=UserIds.AlaaEisa,RoleId=RoleIds.Manager},
                };
                return usersRoles;
            }
            #endregion
        }
        #endregion
    }
}
