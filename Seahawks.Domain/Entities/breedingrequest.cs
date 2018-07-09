using System;
using System.Collections.Generic;

namespace Seahawks.Domain.Entities
{
    public partial class breedingrequest
    {
        public breedingrequest()
        {
            this.breedingdetails = new List<breedingdetail>();
        }

        public int id { get; set; }
        public bool accepted { get; set; }
        public string status { get; set; }
        public Nullable<int> member_id { get; set; }
        public Nullable<int> offer_id { get; set; }
        public string description { get; set; }
        public Nullable<int> animal_id { get; set; }
        public virtual animal animal { get; set; }
        public virtual ICollection<breedingdetail> breedingdetails { get; set; }
        public virtual breedingoffer breedingoffer { get; set; }
        public virtual user user { get; set; }
    }
}
