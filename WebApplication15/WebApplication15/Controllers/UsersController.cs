using Microsoft.AspNetCore.Mvc;
using WebApplication15.Fake;
using WebApplication15.Models;

namespace WebApplication15.Controllers
{
    [Route("api/[controller]")]
    public class UsersController:ControllerBase
    {
        private List<User> _users = FakeData.GetUsers(200);
        public List<User> Get()
        {
            return _users;
        }
    }
}
