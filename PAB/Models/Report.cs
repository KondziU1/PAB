namespace PAB.Models
{
    public class Report
    {
        public Report() { }
        public Report(int user_ID, string? description, int problemType_ID, int device_ID, int? manager_id, string status)
        {
            UserId = user_ID;
            Description = description;
            ProblemTypeId = problemType_ID;
            DeviceId = device_ID;
            ManagerId = manager_id;
            Status = status;
        }

        public int Id { get; set; }
        public int UserId { get; set; }
        public string? Description { get; set; }
        public int ProblemTypeId { get; set; }
        public int DeviceId { get; set; }
        public int? ManagerId { get; set; }
        public string Status { get; set; }

        public User User { get; set; }
        public ProblemType ProblemType { get; set; }
        public Device Device { get; set; }
    }
}