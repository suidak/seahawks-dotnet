using System;
using System.Collections.Generic;

namespace Seahawks.Domain.Entities
{
    public partial class fosteringoffer
    {
        public fosteringoffer()
        {
            this.fosteringrequests = new List<fosteringrequest>();
        }

        public int id { get; set; }
        public string description { get; set; }
        public Nullable<System.DateTime> endDate { get; set; }
        public Nullable<System.DateTime> startDate { get; set; }
        public Nullable<int> animal_id { get; set; }
        public virtual animal animal { get; set; }
        public virtual ICollection<fosteringrequest> fosteringrequests { get; set; }
    }
}
