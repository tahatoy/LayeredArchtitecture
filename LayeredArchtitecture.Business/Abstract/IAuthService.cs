//using Core.Utilities.Security.JWT;
//using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Utilities.Results;
using LayeredArchtitecture.Entity.Concrete;

namespace Business.Abstract
{
    public interface IAuthService
    {
        //IDataResult<User> Register(User user, string password);
        //IDataResult<User> Login(string email,string password);
        IResult UserExists(string email);
    }
}
