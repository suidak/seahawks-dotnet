using System;
using System.Collections.Generic;

namespace Seahawks.Domain.Entities
{
    public partial class fundraiser
    {
        public fundraiser()
        {
            this.fundonations = new List<fundonation>();
        }

        public int id { get; set; }
        public double collectedDonations { get; set; }
        public string description { get; set; }
        public Nullable<System.DateTime> endDate { get; set; }
        public double goal { get; set; }
        public Nullable<System.DateTime> startDate { get; set; }
        public bool state { get; set; }
        public string title { get; set; }
        public Nullable<int> launcher_id { get; set; }
        public string location { get; set; }
        public virtual ICollection<fundonation> fundonations { get; set; }
        public virtual user user { get; set; }
    }
}
