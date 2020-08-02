using System;

namespace Test_DataAccess
{
    public class BaseEntity
    {
        public Guid Id { get; set; }
    }

    public class Property : BaseEntity
    {
        
        public string Address { get; set; }
        public short YearBuild { get; set; }
        public double ListPrice { get; set; }
        public double MonthlyRent { get; set; }
        public float GrossYield { get; set; }
    }
}
