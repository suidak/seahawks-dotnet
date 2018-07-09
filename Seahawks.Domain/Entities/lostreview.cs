using System;
using System.Collections.Generic;

namespace Seahawks.Domain.Entities
{
    public partial class lostreview
    {
        public Nullable<int> status { get; set; }
        public int id { get; set; }
        public Nullable<int> reportLost_id { get; set; }
        public virtual lostreport lostreport { get; set; }
        public virtual review review { get; set; }
    }
}
