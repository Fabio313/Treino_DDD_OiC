using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SolutionTraining.Domain.Entities.v1;

namespace SolutionTraining.Domain.Interfaces.v1.Repositories
{
    public interface IUserRepository
    {
        void Insert(User user);
        void Update(User user);
        void Delete(Guid user);
        List<User> Select();
        User Select(Guid id);
    }
}
