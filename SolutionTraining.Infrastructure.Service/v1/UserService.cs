using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SolutionTraining.CrossCutting.Configuration.Sql;
using SolutionTraining.Domain.Entities.v1;
using SolutionTraining.Domain.Interfaces.v1.Repositories;
using SolutionTraining.Domain.Interfaces.v1.Services;
using SolutionTraining.Infrastructure.Data.Sql.v1.Repositories;

namespace SolutionTraining.Infrastructure.Service.v1
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository repository)
        {
            //Necessita da inversão de dependencia porem esta sendo feito assim para facilitar os testes
            _userRepository = repository;
           // _userRepository = new UserRepository(new SqlDataBaseConfiguration());
        }

        public void Delete(Guid user)
        {
            throw new NotImplementedException();
        }

        public void Insert(User user)
        {
            _userRepository.Insert(user);
        }

        public List<User> Select()
        {
            throw new NotImplementedException();
        }

        public User Select(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Update(User user)
        {
            throw new NotImplementedException();
        }
    }
}
