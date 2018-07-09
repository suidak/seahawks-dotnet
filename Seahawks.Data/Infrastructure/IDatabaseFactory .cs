using Seahawks.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seahawks.Data.Infrastructure
{
    public interface IDatabaseFactory : IDisposable
    {
        seahawksContext DataContext { get; }
    }

}
