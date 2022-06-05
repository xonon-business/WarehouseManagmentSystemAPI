using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseManagmentSystemAPI.Infrastructure.FluentApis
{
    public class CategoriesFluentApi : IEntityTypeConfiguration<CategoryEntity>
    {
        public void Configure(EntityTypeBuilder<CategoryEntity> builder)
        {
            //DataSeeding 
            //builder.HasData(new CategoryEntity { Id = new Guid(), CategoryName = "Meats" });
        }
    }
}
