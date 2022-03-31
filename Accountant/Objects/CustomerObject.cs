namespace Accountant.Objects
{
    public class CustomerObject
    {
        public string? CompanyName;
        public string? FirstName;
        public string? LastName;
        public string? Street;
        public string? HouseNumber;
        public string? PostalCode;
        public string? City;
        public string? Region;

        public CustomerObject()
        {
            CompanyName = null;
            FirstName = null;  
            LastName = null;
            Street = null;
            HouseNumber = null;
            PostalCode = null;
            City = null;
            Region = null;
        }
    }
}
