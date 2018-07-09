using System;
using System.Collections.Generic;

namespace Seahawks.Domain.Entities
{
    public partial class address
    {
        public address()
        {
            this.users = new List<user>();
            this.breedingdetails = new List<breedingdetail>();
        }

        public int id { get; set; }
        public string city { get; set; }
        public string country { get; set; }
        public string street { get; set; }
        public double x { get; set; }
        public double y { get; set; }
        public string zip { get; set; }
        public string state { get; set; }
        public virtual ICollection<user> users { get; set; }
        public virtual ICollection<breedingdetail> breedingdetails { get; set; }
    }
}
