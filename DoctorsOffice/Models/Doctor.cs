using System.Collections.Generic;

namespace DoctorsOffice.Models
{
  public class Doctor
  {
    public Doctor() 
    {
      this.JoinEntities = new HashSet<PatientDoctor>();
    }
    public int DoctorId { get; set; }
    public string DoctorName { get; set; }
    public string Speciality { get; set; }
    public virtual ICollection<PatientDoctor> JoinEntities { get; }
  }
}