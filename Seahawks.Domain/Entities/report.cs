using System;
using System.Collections.Generic;

namespace Seahawks.Domain.Entities
{
    public partial class report
    {
        public int id { get; set; }
        public bool closed { get; set; }
        public Nullable<System.DateTime> date { get; set; }
        public byte[] localisation { get; set; }
        public string reportCategory { get; set; }
        public string title { get; set; }
        public Nullable<int> reporterUser_id { get; set; }
        public string description { get; set; }
        public Nullable<bool> isClosed { get; set; }
        public Nullable<int> localisation_id { get; set; }
        public virtual foundreport foundreport { get; set; }
        public virtual lostreport lostreport { get; set; }
        public virtual reportlocalisation reportlocalisation { get; set; }
        public virtual user user { get; set; }
    }
}
