namespace ContactManager
{
    public class Contact
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public bool IsFavorite { get; set; }

        public string FullName => $"{FirstName} {LastName} - {PhoneNumber} - {Email} {(IsFavorite ? "*" : "")}";
    }
}