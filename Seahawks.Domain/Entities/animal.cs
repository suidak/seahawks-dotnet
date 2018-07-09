using System;
using System.Collections.Generic;

namespace Seahawks.Domain.Entities
{
    public partial class animal
    {
        public animal()
        {
            this.adoptionoffers = new List<adoptionoffer>();
            this.breedingrequests = new List<breedingrequest>();
            this.fosteringoffers = new List<fosteringoffer>();
            this.breedingoffers = new List<breedingoffer>();
            this.animalphotoes = new List<animalphoto>();
            this.lostreports = new List<lostreport>();
        }

        public int id { get; set; }
        public int age { get; set; }
        public string breed { get; set; }
        public bool castrated { get; set; }
        public bool fostered { get; set; }
        public double height { get; set; }
        public bool lost { get; set; }
        public string sex { get; set; }
        public string specie { get; set; }
        public string status { get; set; }
        public double weight { get; set; }
        public Nullable<int> owner_id { get; set; }
        public virtual ICollection<adoptionoffer> adoptionoffers { get; set; }
        public virtual ICollection<breedingrequest> breedingrequests { get; set; }
        public virtual ICollection<fosteringoffer> fosteringoffers { get; set; }
        public virtual user user { get; set; }
        public virtual ICollection<breedingoffer> breedingoffers { get; set; }
        public virtual ICollection<animalphoto> animalphotoes { get; set; }
        public virtual ICollection<lostreport> lostreports { get; set; }
    }
}
