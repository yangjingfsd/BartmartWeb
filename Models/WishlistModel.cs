namespace BartmartWeb.Models
{
    public class WishlistModel
    {
        public string WishlistID { get; set; }
        public string UserID { get; set; }
        public List<string> Listings { get; set; }
    }
}
