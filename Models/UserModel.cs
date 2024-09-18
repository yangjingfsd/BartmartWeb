namespace BartmartWeb.Models
{
    public class UserModel
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
        public List<ListingModel> Listings { get; set; }
        public List<string> Conversations { get; set; }
        public string MyWishlist { get; set; }
    }
}
