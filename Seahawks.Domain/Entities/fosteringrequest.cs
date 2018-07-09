using System;
using System.Collections.Generic;

namespace Seahawks.Domain.Entities
{
    public partial class fosteringrequest
    {
        public int id { get; set; }
        public bool accepted { get; set; }
        public Nullable<int> offer_id { get; set; }
        public virtual fosteringoffer fosteringoffer { get; set; }
    }
}
