namespace BartmartWeb.Models
{
    public class User
    {
        public string UserID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public DateTime RegisteredDate { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string ProfilePicture { get; set; }
        public List<Listing> Listings { get; set; }
        public List<ConversationModel> Conversations { get; set; }
        public WishlistModel Wishlist { get; set; }
    }
}
