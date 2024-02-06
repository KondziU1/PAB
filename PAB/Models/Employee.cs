namespace PAB.Models
{
    public class Employee
    {
        public Employee()
        { }

        public Employee(string fullName, int roomNumber)
        {
            FullName = fullName;
            RoomNumber = roomNumber;
        }

        public int Id { get; set; }
        public string FullName { get; set; }
        public int RoomNumber { get; set; }
    }
}