using System;
using System.Collections.Generic;

namespace Seahawks.Domain.Entities
{
    public partial class foundreport
    {
        public foundreport()
        {
            this.foundreviews = new List<foundreview>();
            this.requestownerships = new List<requestownership>();
        }

        public string status { get; set; }
        public int id { get; set; }
        public Nullable<int> careTaker_id { get; set; }
        public virtual ICollection<foundreview> foundreviews { get; set; }
        public virtual report report { get; set; }
        public virtual ICollection<requestownership> requestownerships { get; set; }
        public virtual user user { get; set; }
    }
}
