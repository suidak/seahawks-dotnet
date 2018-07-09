using System;
using System.Collections.Generic;

namespace Seahawks.Domain.Entities
{
    public partial class fundonation
    {
        public int id { get; set; }
        public double amount { get; set; }
        public Nullable<System.DateTime> donationDate { get; set; }
        public Nullable<int> donator_id { get; set; }
        public Nullable<int> fundraiser_id { get; set; }
        public virtual fundraiser fundraiser { get; set; }
        public virtual user user { get; set; }
    }
}
