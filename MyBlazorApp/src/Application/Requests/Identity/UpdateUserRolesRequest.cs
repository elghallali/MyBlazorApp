using MyBlazorApp.Application.Responses.Identity;
using System.Collections.Generic;

namespace MyBlazorApp.Application.Requests.Identity
{
    public class UpdateUserRolesRequest
    {
        public string UserId { get; set; }
        public IList<UserRoleModel> UserRoles { get; set; }
    }
}