using Microsoft.EntityFrameworkCore;
using UserRegistration.Data;
using UserRegistration.Models;
using UserRegistration.Repository.Interfaces;

namespace UserRegistration.Repository
{

    public class UserRepository : IUserRepository
    {
        private readonly RegistrationContext _registrationContext;

        public UserRepository(RegistrationContext registrationContext)
        {
            _registrationContext = registrationContext;
        }

        public async Task<UserModel> GetUserById(int id)
        {
            if (id == 0)
            { throw new Exception($"O id {id} não foi encontrado no banco de dados, tente novamente"); }

            return await _registrationContext.Users.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<List<UserModel>> GetAllUsers(UserModel user)
        {
            return await _registrationContext.Users.ToListAsync();
        }
        public async Task<UserModel> Create(UserModel user)
        {
            await _registrationContext.Users.AddAsync(user);
            await _registrationContext.SaveChangesAsync();

            return user;
        }

        public async Task<UserModel> Update(UserModel user, int id)
        {
            UserModel userById = await GetUserById(id);

            if (userById == null)
            {
                throw new Exception($"Usuário para o id {id} não foi encontrado no sistema, tente novamente");
            }
            userById.Name = user.Name;
            userById.Email = user.Email;
            userById.Adress = user.Adress;

            _registrationContext.Users.Update(userById);
            await _registrationContext.SaveChangesAsync();

            return userById;

        }
        public async Task<bool> Delete(int id)
        {
            UserModel userByiD = await GetUserById(id);

            if (userByiD == null)
            {
                throw new Exception($"Usuário do ID {id} não foi encontrado, tente novamente");
            }
            _registrationContext.Users.Remove(userByiD);
            await _registrationContext.SaveChangesAsync();

            return true;
        }
    }
}
