using ServicePattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Seahawks.Data.Infrastructure;
using Seahawks.Domain.Entities;

namespace Seahawks.Service
{
    public class UserService : Service<user>, IUserService
    {
        private static IDatabaseFactory dbf = new DatabaseFactory();
        private static IUnitOfWork utwk = new UnitOfWork(dbf);
        public UserService() : base(utwk)
        {
        }
    }
}
