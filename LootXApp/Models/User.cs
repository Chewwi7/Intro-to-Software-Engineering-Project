namespace LootXApp.Models
    //This model is yet to be used or will never be used as "ASPNetUsers" exists
{
    public class User
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int IsAdmin { get; set; }

        public User()
        {

        }
    }
}
