using System;
using System.Collections.Generic;

namespace Seahawks.Domain.Entities
{
    public partial class adoptionoffer
    {
        public adoptionoffer()
        {
            this.adoptionrequests = new List<adoptionrequest>();
        }

        public int id { get; set; }
        public Nullable<System.DateTime> offerDate { get; set; }
        public double price { get; set; }
        public Nullable<int> animal_id { get; set; }
        public virtual ICollection<adoptionrequest> adoptionrequests { get; set; }
        public virtual animal animal { get; set; }
    }
}
