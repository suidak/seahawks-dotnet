using System;
using System.Collections.Generic;

namespace Seahawks.Domain.Entities
{
    public partial class signalreview
    {
        public int id { get; set; }
        public string category { get; set; }
        public byte[] flagger { get; set; }
        public string otherContent { get; set; }
        public Nullable<System.DateTime> signalDate { get; set; }
        public Nullable<int> flagged_id { get; set; }
        public Nullable<int> review_id { get; set; }
        public virtual review review { get; set; }
        public virtual user user { get; set; }
    }
}
