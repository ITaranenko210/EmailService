namespace LogisticService.Models
{
    public class WorkCase
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public DateTime DateOfCreation { get; set; }
        public DateTime Deadline { get; set; }
    }
}
