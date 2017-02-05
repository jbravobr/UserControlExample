namespace ViewAsComponentExample.Models
{
    public class Person
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Location { get; set; }

        public string FullName => $"{FirstName} {LastName}";
    }
}