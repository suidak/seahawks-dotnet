using System;
using System.Collections.Generic;

namespace Seahawks.Domain.Entities
{
    public partial class requestownership
    {
        public int id { get; set; }
        public bool closed { get; set; }
        public string description { get; set; }
        public string image { get; set; }
        public bool knowOwner { get; set; }
        public bool mine { get; set; }
        public Nullable<int> member_id { get; set; }
        public Nullable<int> report_id { get; set; }
        public virtual foundreport foundreport { get; set; }
        public virtual user user { get; set; }
    }
}
