using System;
using System.Collections.Generic;

namespace Seahawks.Domain.Entities
{
    public partial class reportlocalisation
    {
        public reportlocalisation()
        {
            this.reports = new List<report>();
        }

        public int id { get; set; }
        public string city { get; set; }
        public string country { get; set; }
        public string street { get; set; }
        public double x { get; set; }
        public double y { get; set; }
        public string zip { get; set; }
        public virtual ICollection<report> reports { get; set; }
    }
}
