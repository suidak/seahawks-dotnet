using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServicePattern;
using Seahawks.Domain.Entities;
using Seahawks.Data.Infrastructure;

namespace Seahawks.Service
{
    public class VetService : Service<user>, IVetService
    {
        private static IDatabaseFactory dbf = new DatabaseFactory();
        private static IUnitOfWork utwk = new UnitOfWork(dbf);
        public VetService() : base(utwk)
        {
        }
    }
}
