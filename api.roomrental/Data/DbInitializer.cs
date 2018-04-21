using api.roomrental.Entities;
using api.roomrental.models;
using api.roomrental.Models;
using Microsoft.AspNetCore.Identity;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace api.roomrental.Data
{
    public class DbInitializer
    {

        private readonly RoomrentalDbContext _context;
        private readonly UserManager<AppUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public DbInitializer(RoomrentalDbContext context, UserManager<AppUser> userManager,
            RoleManager<IdentityRole> roleManager)
        {
            _context = context;
            _userManager = userManager;
            _roleManager = roleManager;
        }
        public async Task Seed()
        {
            _context.Database.Migrate();
            //if (_context.Roles.Any() && _context.ApplicationUsers.Any())
            //{
            //    return; //DB already seeded
            //}

            // Check if Role is seeded

            if (!_context.Roles.Any())
            {
                string filePath = @"Data" + Path.DirectorySeparatorChar + "RoleSeedData.json";
                var roles = JsonConvert.DeserializeObject<List<IdentityRole>>(File.ReadAllText(filePath));
                foreach (var role in roles)
                {
                    var result = await _roleManager.CreateAsync(role);

                }

            }

            if (!_context.ApplicationUsers.Any())
            {
                string filePath = @"Data" + Path.DirectorySeparatorChar + "UserSeedData.json";
                var users = JsonConvert.DeserializeObject<List<UserRegistrationDAO>>(File.ReadAllText(filePath));

                foreach (var user in users)
                {
                    var u
                        = new AppUser
                        {
                            UserName = user.UserName,
                            Email = user.UserName,
                            EmailConfirmed = true,
                            FirstName = user.FirstName,
                            LastName = user.LastName
                        };
                    var result = await _userManager.CreateAsync(u, user.Password);
                    if (result.Succeeded)
                    {


                        var random = new Random();
                        var role = _roleManager.Roles.OrderBy(r => random.Next()).Take(1).First();
                        await _userManager.AddToRoleAsync(u, role.Name);
                    }
                }
            }


            if (!_context.AdTypes.Any())
            {
                string filePath = @"Data" + Path.DirectorySeparatorChar + "AdTypeSeedData.json";
                var adTypes = JsonConvert.DeserializeObject<List<AdType>>(File.ReadAllText(filePath));
                _context.AdTypes.AddRange(adTypes);

            }


            if (!_context.AdCategories.Any())
            {
                string filePath = @"Data" + Path.DirectorySeparatorChar + "CategorySeedData.json";
                var categories = JsonConvert.DeserializeObject<List<AdCategory>>(File.ReadAllText(filePath));
                _context.AdCategories.AddRange(categories);

            }

            _context.SaveChanges();
        }

    }
}
