using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Seahawks.Web.Models
{
    public class FundraiserModel
    {
        public int id { get; set; }
        public double collectedDonations { get; set; }
        public string description { get; set; }
        [DataType(DataType.DateTime)]
        public System.DateTime endDate { get; set; }
        public double goal { get; set; }
        [DataType(DataType.DateTime)]
        public System.DateTime startDate { get; set; }
        public bool state { get; set; }
        public string title { get; set; }
        //public Nullable<int> launcher_id { get; set; }
        public string location { get; set; }
        //public virtual ICollection<fundonation> fundonations { get; set; }
        //public virtual user user { get; set; }
    }
}