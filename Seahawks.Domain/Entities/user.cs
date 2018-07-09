using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Seahawks.Domain.Entities
{
    public partial class user
    {
        public user()
        {
            this.adoptionrequests = new List<adoptionrequest>();
            this.animals = new List<animal>();
            this.breedingrequests = new List<breedingrequest>();
            this.donations = new List<donation>();
            this.donations1 = new List<donation>();
            this.foundreports = new List<foundreport>();
            this.fundonations = new List<fundonation>();
            this.fundraisers = new List<fundraiser>();
            this.reports = new List<report>();
            this.requestownerships = new List<requestownership>();
            this.reviews = new List<review>();
            this.signalreviews = new List<signalreview>();
            this.signalusers = new List<signaluser>();
            this.signalusers1 = new List<signaluser>();
        }

        public string DTYPE { get; set; }
        [Key]
        public int id { get; set; }
        public string email { get; set; }
        public Nullable<System.DateTime> lastLogin { get; set; }
        public string login { get; set; }
        public string password { get; set; }
        public string photo { get; set; }
        public string status { get; set; }
        public string token { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public Nullable<System.DateTime> foundDate { get; set; }
        public string orgName { get; set; }
        public Nullable<int> address_id { get; set; }
        public string phoneNumber { get; set; }
        public string role { get; set; }
        public bool vet { get; set; }
        public virtual address address { get; set; }
        public virtual ICollection<adoptionrequest> adoptionrequests { get; set; }
        public virtual ICollection<animal> animals { get; set; }
        public virtual ICollection<breedingrequest> breedingrequests { get; set; }
        public virtual ICollection<donation> donations { get; set; }
        public virtual ICollection<donation> donations1 { get; set; }
        public virtual ICollection<foundreport> foundreports { get; set; }
        public virtual ICollection<fundonation> fundonations { get; set; }
        public virtual ICollection<fundraiser> fundraisers { get; set; }
        public virtual ICollection<report> reports { get; set; }
        public virtual ICollection<requestownership> requestownerships { get; set; }
        public virtual ICollection<review> reviews { get; set; }
        public virtual ICollection<signalreview> signalreviews { get; set; }
        public virtual ICollection<signaluser> signalusers { get; set; }
        public virtual ICollection<signaluser> signalusers1 { get; set; }
    }
}
