using Core.Entities.Concrete;
using Core.Utilities.Results;
//using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using LayeredArchtitecture.Entity.Concrete;

namespace Business.Abstract
{
        public interface IUserService
        {
            IResult Add(User user);
            IResult Update(User user);
            IResult Delete(User user);
            IDataResult<List<User>> GetAll();
            IDataResult<User> Get(int userId);
            IDataResult<User> GetById(int userId);

            IDataResult<List<OperationClaim>> GetClaims(User user);
            IDataResult<User> GetByMail(string email);
        }
    
}
