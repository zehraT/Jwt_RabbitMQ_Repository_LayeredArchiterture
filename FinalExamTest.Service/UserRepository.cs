using FinalExamTest.Data.Context;
using FinalExamTest.Data.Interfaces;
using FinalExamTest.Data.Models;

namespace FinalExamTest.Service
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        private readonly DataContext _dataContext;
        public UserRepository(DataContext dataContext) : base(dataContext)
        {
            _dataContext = dataContext;
        }
    }
}
