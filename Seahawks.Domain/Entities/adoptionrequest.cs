using System;
using System.Collections.Generic;

namespace Seahawks.Domain.Entities
{
    public partial class adoptionrequest
    {
        public int id { get; set; }
        public bool accepted { get; set; }
        public string description { get; set; }
        public Nullable<int> adopter_id { get; set; }
        public Nullable<int> offer_id { get; set; }
        public Nullable<int> status { get; set; }
        public virtual adoptionoffer adoptionoffer { get; set; }
        public virtual user user { get; set; }
    }
}
