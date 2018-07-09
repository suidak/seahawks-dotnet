using System;
using System.Collections.Generic;

namespace Seahawks.Domain.Entities
{
    public partial class review
    {
        public review()
        {
            this.signalreviews = new List<signalreview>();
        }

        public int id { get; set; }
        public string content { get; set; }
        public bool correctAnswer { get; set; }
        public Nullable<System.DateTime> reviewDate { get; set; }
        public Nullable<int> report_id { get; set; }
        public Nullable<int> reviewer_id { get; set; }
        public virtual foundreview foundreview { get; set; }
        public virtual lostreport lostreport { get; set; }
        public virtual lostreview lostreview { get; set; }
        public virtual ICollection<signalreview> signalreviews { get; set; }
        public virtual user user { get; set; }
    }
}
