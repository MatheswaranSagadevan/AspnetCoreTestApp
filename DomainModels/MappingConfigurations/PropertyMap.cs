using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Test_DataAccess
{
    public class PropertyMap
{
        public PropertyMap(EntityTypeBuilder<Property> entityBuilder)
        {

            entityBuilder.HasKey(p => p.Id);
            //entityBuilder.HasOne(p => p.Address).WithOne(p => p.Product).HasForeignKey<Address>(x => x.Id);
        }
    }
}
