using System;
using System.Collections.Generic;

namespace Seahawks.Domain.Entities
{
    public partial class foundreview
    {
        public Nullable<int> status { get; set; }
        public int id { get; set; }
        public Nullable<int> existingLostReportMatch_id { get; set; }
        public Nullable<int> foundReport_id { get; set; }
        public virtual foundreport foundreport { get; set; }
        public virtual lostreport lostreport { get; set; }
        public virtual review review { get; set; }
    }
}
