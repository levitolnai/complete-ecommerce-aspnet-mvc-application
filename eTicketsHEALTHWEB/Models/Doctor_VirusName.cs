namespace eTicketsHEALTHWEB.Models
{
    public class Doctor_VirusName
    {
        public int VirusNameId { get; set; }

        public VirusName VirusName { get; set; }

        public int DoctorId { get; set; }
        public Doctor Doctor { get; set; }
    }
}
