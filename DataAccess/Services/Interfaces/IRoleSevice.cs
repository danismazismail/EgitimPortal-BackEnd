using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Services.Interfaces
{
    public interface IRoleSevice
    {
        Task<ICollection<IdentityRole>> GetRolesAsync();

        Task<IdentityRole> FindRoleAsync(Guid id);

        Task<bool> CheckRoleNameAsync(string roleName, Guid? id);

        Task<IdentityResult> AddRoleAsync(IdentityRole role);

        Task<IdentityResult> UpdateRoleAsync(IdentityRole role);

        Task<IdentityResult> DeleteRoleAsync(IdentityRole role);
    }
}