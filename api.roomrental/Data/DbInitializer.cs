using api.roomrental.Entities;
using api.roomrental.models;
using api.roomrental.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace api.roomrental.Data
{
    public class DbInitializer
    {

        private readonly RoomRentalDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly ILogger<DbInitializer> _logger;

        public DbInitializer(RoomRentalDbContext context, UserManager<ApplicationUser> userManager,
            RoleManager<IdentityRole> roleManager, ILogger<DbInitializer> logger)
        {
            _context = context;
            _userManager = userManager;
            _roleManager = roleManager;
            _logger = logger;

        }
        public async Task Seed()
        {
            _logger.LogInformation("Checking Database started..");
            _context.Database.EnsureCreated();

            if (_context.Roles.Any() && _context.ApplicationUsers.Any())
            {
                return; //DB already seeded
            }

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
                        = new ApplicationUser
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
        }
    }
}
