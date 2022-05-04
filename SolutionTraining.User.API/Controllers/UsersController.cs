using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SolutionTraining.Domain.Entities.v1;
using SolutionTraining.Domain.Interfaces.v1.Services;
using SolutionTraining.Infrastructure.Service.v1;

namespace SolutionTraining.User.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost]
        public ActionResult<Domain.Entities.v1.User> Create(Domain.Entities.v1.User user)
        {
            user.Id = System.Guid.NewGuid();
            _userService.Insert(user);
            return user;
        }
    }
}
