using System.ComponentModel.DataAnnotations.Schema;

namespace LogisticService.Models
{
    public class WorkCaseLocation
    {
        public Guid Id { get; set; }
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }
        
        public WorkCase WorkCase { get; set; }
        public Guid WorkCaseId { get; set; }
    }
}
