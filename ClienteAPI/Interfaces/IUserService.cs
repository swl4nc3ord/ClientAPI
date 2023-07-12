using ClienteAPI.Entity;
using ClienteAPI.Models;

namespace ClienteAPI.Interfaces
{
    public interface IUserService
    {
        public void CreateUser(CreationUserRequest creationUserRequest);
        public void EditUser(UpdateUserRequest updateUserRequest);
        public User GetUser(long id);
        public void DeleteUser(long id);
    }
}
