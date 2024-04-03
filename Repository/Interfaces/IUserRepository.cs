using UserRegistration.Models;

namespace UserRegistration.Repository.Interfaces
{
    public interface IUserRepository
    {
        Task<UserModel> Create(UserModel user);

        Task<List<UserModel>> GetAllUsers (UserModel user);

        Task<UserModel> GetUserById(int id);

        Task<UserModel> Update(UserModel user, int id);

        Task<bool> Delete(int id);

    }
}
