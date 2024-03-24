

namespace ContactsApp.Models
{
    public class Contact
    {
        public int ContactId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public int PhoneNumber { get; set; }    
        public DateTime DateOfBirth { get; set; }

        public Category Category { get; set; }

        public Contact()
        {

        }
    }
    public enum Category
    {
        Private,
        Bussiness,
        Other
    }
}
