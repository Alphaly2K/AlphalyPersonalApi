using Microsoft.AspNetCore.Mvc;
using AlphalyPersonalApi.Model;
using AlphalyPersonalApi.User;

namespace AlphalyPersonalApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        [HttpGet]
        public ActionResult<UserReturnModel> Get([FromQuery]UserModel user)
        {
            if (UserLogin.Login(user))
                return Ok(new UserReturnModel() { Message = "Ok!", Code = 200, Data = new UserReturnData() { Token = "aa1a"} });
            return Unauthorized(new UserReturnModel() { Message = "Failed! Wrong email or password", Code = 401, Data = new UserReturnData() { Token = "null"} });
        }
    }
}
