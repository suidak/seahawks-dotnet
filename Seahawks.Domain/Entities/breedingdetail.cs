using System;
using System.Collections.Generic;

namespace Seahawks.Domain.Entities
{
    public partial class breedingdetail
    {
        public int id { get; set; }
        public int babiesNumber { get; set; }
        public Nullable<System.DateTime> dateAction { get; set; }
        public Nullable<System.DateTime> dateBreeding { get; set; }
        public Nullable<System.DateTime> dateConfirmed { get; set; }
        public string statut { get; set; }
        public Nullable<int> addressBreeding_id { get; set; }
        public Nullable<int> breedingRequest_id { get; set; }
        public virtual address address { get; set; }
        public virtual breedingrequest breedingrequest { get; set; }
    }
}
