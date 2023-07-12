using ClienteAPI.Entity;
using ClienteAPI.Interfaces;
using ClienteAPI.Models;

namespace ClienteAPI.Services
{
    public class UserService : IUserService
    {
        private readonly ApplicationDbContext _dbContext;

        public UserService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void CreateUser(CreationUserRequest creationUserRequest)
        {
            try
            {
                User user = new User()
                {
                    TaxNumber = creationUserRequest.TaxNumber,
                    FullName = creationUserRequest.FullName,
                    IncomeValue = creationUserRequest.IncomeValue,
                    BirthDate = creationUserRequest.BirthDate,
                    CreationDate = DateTime.Now,
                    DeletionDate = null,
                    UpdateDate = DateTime.Now
                };

                _dbContext.User.Add(user);
                _dbContext.SaveChanges();
            }
            catch
            {
                throw;
            }
        }

        public void DeleteUser(long id)
        {
            User user = _dbContext.User.Find(id);
            _dbContext.User.Remove(user);
            _dbContext.SaveChanges();
        }

        public void UpdateUser(UpdateUserRequest updateUserRequest)
        {
            User user = _dbContext.User.Find(updateUserRequest.Id);

            user.IncomeValue = updateUserRequest.IncomeValue;
            user.UpdateDate = DateTime.Now;

            _dbContext.User.Update(user);
            _dbContext.SaveChanges();
        }

        public User GetUser(long id)
        {
            User user;
            user = _dbContext.User.Find(id);

            return user;
        }
    }
}
