using System;
using System.Collections.Generic;

namespace Seahawks.Domain.Entities
{
    public partial class donation
    {
        public int id { get; set; }
        public double amount { get; set; }
        public string description { get; set; }
        public Nullable<System.DateTime> donationDate { get; set; }
        public double tips { get; set; }
        public Nullable<int> donator_id { get; set; }
        public Nullable<int> organisation_id { get; set; }
        public virtual user user { get; set; }
        public virtual user user1 { get; set; }
    }
}
