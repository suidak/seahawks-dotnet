using System;
using System.Collections.Generic;

namespace Seahawks.Domain.Entities
{
    public partial class lostreport
    {
        public lostreport()
        {
            this.foundreviews = new List<foundreview>();
            this.lostreviews = new List<lostreview>();
            this.reviews = new List<review>();
        }

        public byte[] animal { get; set; }
        public double reward { get; set; }
        public int id { get; set; }
        public Nullable<int> animal_id { get; set; }
        public virtual animal animal1 { get; set; }
        public virtual ICollection<foundreview> foundreviews { get; set; }
        public virtual ICollection<lostreview> lostreviews { get; set; }
        public virtual ICollection<review> reviews { get; set; }
        public virtual report report { get; set; }
    }
}
