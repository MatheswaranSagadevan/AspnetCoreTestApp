using System;
using System.Collections.Generic;
using System.Text;
using Test_BusinessService.ServiceObjects;

namespace Test_BusinessService.Interface
{
    public interface IPropertyService
{
        void SavePropertyInfo(PropertySO propertySO);
}
}
