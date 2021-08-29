using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlphalyPersonalApi.Model
{
    public class UserModel
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
    public class UserReturnModel
    {
        public string Message { get; set; }
        public int Code { get; set; }
        public UserReturnData Data { get; set; }
    }
    public class UserReturnData
    {
        public string Token { get; set; }
    }
}
