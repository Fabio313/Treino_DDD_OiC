using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SolutionTraining.Domain.Entities.v1;
using SolutionTraining.Infrastructure.Service.v1;

namespace User.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController<TEntity> : ControllerBase where TEntity : EntityBase 
    {
        private readonly BaseService<TEntity> _userService;

        public UsersController(BaseService<TEntity> userService)
        {
            _userService = userService;
        }

        [HttpPost]
        public ActionResult<User> Create(User user)
        {

        }
    }
}
