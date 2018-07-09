using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using Seahawks.Data.Models.Mapping;
using Seahawks.Domain.Entities;

namespace Seahawks.Data.Models
{
    [DbConfigurationType(typeof(MySql.Data.Entity.MySqlEFConfiguration))]
    public partial class seahawksContext : DbContext
    {
        static seahawksContext()
        {
            //Database.SetInitializer<seahawksContext>(null);
        }

        public seahawksContext()
            : base("Name=seahawksContext")
        {
        }

        public DbSet<address> addresses { get; set; }
        public DbSet<adoptionoffer> adoptionoffers { get; set; }
        public DbSet<adoptionrequest> adoptionrequests { get; set; }
        public DbSet<animal> animals { get; set; }
        public DbSet<animalphoto> animalphotoes { get; set; }
        public DbSet<breedingdetail> breedingdetails { get; set; }
        public DbSet<breedingoffer> breedingoffers { get; set; }
        public DbSet<breedingrequest> breedingrequests { get; set; }
        public DbSet<donation> donations { get; set; }
        public DbSet<fosteringoffer> fosteringoffers { get; set; }
        public DbSet<fosteringrequest> fosteringrequests { get; set; }
        public DbSet<foundreport> foundreports { get; set; }
        public DbSet<foundreview> foundreviews { get; set; }
        public DbSet<fundonation> fundonations { get; set; }
        public DbSet<fundraiser> fundraisers { get; set; }
        public DbSet<lostreport> lostreports { get; set; }
        public DbSet<lostreview> lostreviews { get; set; }
        public DbSet<report> reports { get; set; }
        public DbSet<reportlocalisation> reportlocalisations { get; set; }
        public DbSet<requestownership> requestownerships { get; set; }
        public DbSet<review> reviews { get; set; }
        public DbSet<signalreview> signalreviews { get; set; }
        public DbSet<signaluser> signalusers { get; set; }
        public DbSet<user> users { get; set; }
        public DbSet<Appointment> Appointments { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new addressMap());
            modelBuilder.Configurations.Add(new adoptionofferMap());
            modelBuilder.Configurations.Add(new adoptionrequestMap());
            modelBuilder.Configurations.Add(new animalMap());
            modelBuilder.Configurations.Add(new animalphotoMap());
            modelBuilder.Configurations.Add(new breedingdetailMap());
            modelBuilder.Configurations.Add(new breedingofferMap());
            modelBuilder.Configurations.Add(new breedingrequestMap());
            modelBuilder.Configurations.Add(new donationMap());
            modelBuilder.Configurations.Add(new fosteringofferMap());
            modelBuilder.Configurations.Add(new fosteringrequestMap());
            modelBuilder.Configurations.Add(new foundreportMap());
            modelBuilder.Configurations.Add(new foundreviewMap());
            modelBuilder.Configurations.Add(new fundonationMap());
            modelBuilder.Configurations.Add(new fundraiserMap());
            modelBuilder.Configurations.Add(new lostreportMap());
            modelBuilder.Configurations.Add(new lostreviewMap());
            modelBuilder.Configurations.Add(new reportMap());
            modelBuilder.Configurations.Add(new reportlocalisationMap());
            modelBuilder.Configurations.Add(new requestownershipMap());
            modelBuilder.Configurations.Add(new reviewMap());
            modelBuilder.Configurations.Add(new signalreviewMap());
            modelBuilder.Configurations.Add(new signaluserMap());
            modelBuilder.Configurations.Add(new userMap());
        }
    }
}
