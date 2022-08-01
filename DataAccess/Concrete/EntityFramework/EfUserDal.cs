
using Core.DataAccess.EntityFramework;
using Core.Entities.Concrete;
using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfUserDal : EfEntityRepositoryBase<User, ReCapProjectDbContext>, IUserDal
    {
        public List<OperationClaim> GetClaims(User user)
        {
            using (var context = new ReCapProjectDbContext())
            {
                var result = from oc in context.OperationClaims
                             join uoc in context.UserOperationClaims
                             on oc.OperationClaimId equals uoc.OperationClaimId
                             where uoc.UserId == user.UserId
                             select new OperationClaim
                             {
                                 OperationClaimId = oc.OperationClaimId,
                                 OperationClaimName = oc.OperationClaimName
                             };
                return result.ToList(); 

            }
        }
    }
}
