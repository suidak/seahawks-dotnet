using ServicePattern;
using Seahawks.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seahawks.Service
{
    public interface IVetService : IService<user>
    {
    }
}
