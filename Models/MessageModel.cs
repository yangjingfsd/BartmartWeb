namespace BartmartWeb.Models
{
    public class MessageModel
    {
        public string MessageID { get; set; }
        public string SenderID { get; set; }
        public string ReceiverID { get; set; }
        public string Content { get; set; }
        public DateTime TimeStamp { get; set; }
    }
}
