namespace BartmartWeb.Models
{
    public class ConversationModel
    {
        public string ConversationID { get; set; }
        public string UserID { get; set; }
        public string ListingID { get; set; }
        public string OtherUserID { get; set; }
        public List<MessageModel> Messages { get; set; }
    }
}
