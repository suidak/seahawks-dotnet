using System;
using System.Collections.Generic;

namespace Seahawks.Domain.Entities
{
    public partial class animalphoto
    {
        public int id { get; set; }
        public string photo { get; set; }
        public Nullable<int> animal_id { get; set; }
        public virtual animal animal { get; set; }
    }
}
