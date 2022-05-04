using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using SolutionTraining.Domain.Entities.v1;
using SolutionTraining.Domain.Interfaces.v1.Connection;
using SolutionTraining.Domain.Interfaces.v1.Repositories;

namespace SolutionTraining.Infrastructure.Data.Sql.v1.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly string _conn;

        public UserRepository(IDataBaseConfiguration connectString)
        {
            _conn = connectString.Get();
        }

        public void Delete(Guid user)
        {
            throw new NotImplementedException();
        }

        public void Insert(User user)
        {
            using (var sql = new SqlConnection(_conn))
            {
                sql.Open();
                sql.Execute("Insert into User (Id, FullName, Email, Username, Password) values (@Id, @FullName, @Email, @Username, @Password)", user);
            }
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
