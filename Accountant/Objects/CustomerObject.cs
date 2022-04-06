using static Accountant.Util.Util;

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
        public BusinessRelation Relation;

        public CustomerObject()
        {
            CompanyName = null;
            FirstName = null;  
            LastName = null;
            Street = null;
            HouseNumber = null;
            PostalCode = null;
            City = null;
            Relation = BusinessRelation.B2C;
        }
    }
}
