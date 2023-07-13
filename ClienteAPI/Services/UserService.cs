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
                    UpdateDate = DateTime.Now
                };

                _dbContext.User.Add(user);
                _dbContext.SaveChanges();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public void DeleteUser(long id)
        {
            try
            {
                User user = _dbContext.User.Find(id);
                _dbContext.User.Remove(user);
                _dbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void UpdateUser(UpdateUserRequest updateUserRequest)
        {
            try
            {
                User user = _dbContext.User.Find(updateUserRequest.Id);

                user.IncomeValue = updateUserRequest.IncomeValue;
                user.UpdateDate = DateTime.Now;

                _dbContext.User.Update(user);
                _dbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public User GetUser(long id)
        {
            try
            {
                User user;
                user = _dbContext.User.Find(id);

                return user;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
