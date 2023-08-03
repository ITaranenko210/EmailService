namespace LogisticService.Models
{
    public class Email
    {
        public int EmailId { get; set; }
        public string To { get; set; }
        public string From { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public string BodyHTML { get; set; }

    }
}
