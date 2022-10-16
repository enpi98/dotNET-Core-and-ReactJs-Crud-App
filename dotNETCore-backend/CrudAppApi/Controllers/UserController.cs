using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;
using Model.Concrete;


namespace CrudAppApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        
        private readonly IUserService userService;

        public UserController(IUserService userService)
        {
            this.userService = userService;
        }

        [HttpGet]
        [Route("getUsers")]
        public ActionResult<List<User>> getUsers()
        {
            return Ok(userService.getUsers());
        }
        [HttpPost]
        [Route("createUser")]
        public ActionResult<int> createUser(User user)
        {
            return Ok(userService.addUser(user));
        }

        [HttpPut]
        [Route("updateUser")]
        public ActionResult<int> updateUser(User user)
        {
            return Ok(userService.updateUser(user));
        }
        [HttpDelete]
        [Route("deleteUser/{id:int}")]
         public ActionResult<int> deleteUser(int id)
         {
             return Ok(userService.deleteUser(new User(id)));
         }

        [HttpGet]
        [Route("getUser/{id:int}")]
        public ActionResult<User> getUserById(int id)
        {
            return Ok(userService.getById(id));
        }

    }
}
