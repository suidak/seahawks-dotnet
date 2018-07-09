using System;
using System.Collections.Generic;

namespace Seahawks.Domain.Entities
{
    public partial class breedingoffer
    {
        public breedingoffer()
        {
            this.breedingrequests = new List<breedingrequest>();
        }

        public int id { get; set; }
        public bool closed { get; set; }
        public string description { get; set; }
        public bool located { get; set; }
        public string titre { get; set; }
        public Nullable<int> animal_id { get; set; }
        public Nullable<System.DateTime> date { get; set; }
        public int idAnimal { get; set; }
        public virtual animal animal { get; set; }
        public virtual ICollection<breedingrequest> breedingrequests { get; set; }
    }
}
