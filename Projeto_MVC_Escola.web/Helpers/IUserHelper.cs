using Microsoft.AspNetCore.Identity;
using Projeto_MVC_Escola.web.Data.Entities;
using Projeto_MVC_Escola.web.Models;
using System.Threading.Tasks;

namespace Projeto_MVC_Escola.web.Helpers
{
    public interface IUserHelper
    {

        Task<User> GetUserByEmailAsync(string email);


        Task<IdentityResult> AddUserAsync(User user, string password);


        Task<SignInResult> LoginAsync(LoginViewModel model);



        Task LogoutAsync();


        Task<IdentityResult> UpdateUserAsync(User user);


        Task<IdentityResult> ChangePasswordAsync(User user, string oldPassword, string newPassword);


        Task CheckRoleAsync(string roleName);


        Task AddUserToRoleAsync(User user, string roleName);


        Task<bool> IsUserInRoleAsync(User user, string roleName);
    }
}
