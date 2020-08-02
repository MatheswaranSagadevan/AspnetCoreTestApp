using System;
using System.Collections.Generic;
using System.Text;

namespace Test_BusinessService.ServiceObjects
{
    public class PropertySO
    {
        public Guid Id { get; set; }
        public string Address { get; set; }
        public short YearBuild { get; set; }
        public double ListPrice { get; set; }
        public double MonthlyRent { get; set; }
        public float GrossYield { get; set; }
    }
}
