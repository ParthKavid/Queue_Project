namespace Queue_Project.Models
{
    public interface IPatient_Model
    {
        int PatientId { get; set; }
        string PatientName { get; set; }
        string Phone { get; set; }
    }
}