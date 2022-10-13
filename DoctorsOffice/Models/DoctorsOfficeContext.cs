using Microsoft.EntityFrameworkCore;

namespace DoctorsOffice.Models
{
  public class DoctorsOfficeContext : DbContext
  {
    public DbSet<Patient> Patients { get; set; }
    public DbSet<Doctor> Doctors { get; set; }

    public DbSet<PatientDoctor> PatientDoctor { get; set; }

    public DoctorsOfficeContext(DbContextOptions options) : base(options) { }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseLazyLoadingProxies();
    }
  }
}