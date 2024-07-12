using DataAccess.Services.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Services.Concrete
{
    public class RoleService : IRoleSevice
    {
        private readonly RoleManager<IdentityRole> _roleManager;

        public RoleService(RoleManager<IdentityRole> roleManager)
        {
            _roleManager = roleManager;
        }
        public async Task<IdentityResult> AddRoleAsync(IdentityRole role)
        => await _roleManager.CreateAsync(role);

        public async Task<IdentityResult> UpdateRoleAsync(IdentityRole role)
        => await _roleManager.UpdateAsync(role);
        public async Task<IdentityResult> DeleteRoleAsync(IdentityRole role)
        => await _roleManager.DeleteAsync(role);
        public async Task<IdentityRole> FindRoleAsync(Guid id)
        => await _roleManager.FindByIdAsync(id.ToString());

        public async Task<ICollection<IdentityRole>> GetRolesAsync()
        => await _roleManager.Roles.ToListAsync();
        public async Task<bool> CheckRoleNameAsync(string roleName, Guid? id)
        {
            if (id != null)
                return await _roleManager.Roles.AnyAsync(x => x.Name == roleName && x.Id == id.ToString());

            return await _roleManager.Roles.AnyAsync(x=> x.Name == roleName);
        }

        

        

        
    }
}
