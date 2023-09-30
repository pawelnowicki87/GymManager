using GymManager.Application.Roles.Queries.GetRoles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManager.Application.Common.Interfaces
{
    public interface IRoleManagerService
    {
        IEnumerable<RoleDto> GetRoles();
    }
}
