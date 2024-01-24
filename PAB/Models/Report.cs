namespace PAB.Models
{
    public class Report
    {
        public Report(int user_ID, string? description, int problemType_ID, int device_ID, int? manager_id, string status)
        {
            User_ID = user_ID;
            Description = description;
            ProblemType_ID = problemType_ID;
            Device_ID = device_ID;
            Manager_id = manager_id;
            Status = status;
        }

        public int Id { get; set; }
        public int User_ID { get; set; }
        public string? Description { get; set; }
        public int ProblemType_ID { get; set; }
        public int Device_ID { get; set; }
        public int? Manager_id { get; set; }
        public string Status { get; set; }
    }
}