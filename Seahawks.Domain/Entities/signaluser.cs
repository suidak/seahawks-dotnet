using System;
using System.Collections.Generic;

namespace Seahawks.Domain.Entities
{
    public partial class signaluser
    {
        public int id { get; set; }
        public string motive { get; set; }
        public string otherContent { get; set; }
        public Nullable<System.DateTime> signalDate { get; set; }
        public Nullable<int> doer_id { get; set; }
        public Nullable<int> signaled_id { get; set; }
        public virtual user user { get; set; }
        public virtual user user1 { get; set; }
    }
}
