using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using Test_BusinessService.Interface;
using Test_BusinessService.ServiceObjects;
using Test_DataAccess;
using Test_DataAccessRepository;

namespace Test_BusinessService.Implementation
{
    public class PropertyService : IPropertyService
    {
        private readonly IRepository<Property> propertyRepository;
        private readonly IMapper mapper;

        public PropertyService(IRepository<Property> propertyRepository, IMapper mapper)
        {
            this.propertyRepository = propertyRepository;
            this.mapper = mapper;
        }

        public void SavePropertyInfo(PropertySO propertySO)
        {
            try
            {


                if (propertySO == null)
                    throw new Exception("Null or Invalid Property ");

                if (propertySO.Id != null && propertySO.Id != Guid.Empty)
                {
                    //var property= mapper.Map<Property>(propertySO);
                    var property = propertyRepository.Get(propertySO.Id);
                    if (property == null)
                        throw new Exception("Property does not exist");

                    var propertyToBeUpdated = mapper.Map<Property>(propertySO);
                    property = propertyToBeUpdated;
                    propertyRepository.Update(property);
                }
                else
                {
                    var propertyToBeUpdated = mapper.Map<Property>(propertySO);
                    propertyRepository.Insert(propertyToBeUpdated);

                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
