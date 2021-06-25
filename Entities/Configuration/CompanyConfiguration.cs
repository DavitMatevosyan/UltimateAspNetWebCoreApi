using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Entities.Configuration
{
    public class CompanyConfiguration : IEntityTypeConfiguration<Company>
    {
        public void Configure(EntityTypeBuilder<Company> builder)
        {
            builder.HasData
            (
                new Company
                {
                    Id = new System.Guid("c9d4c053-49b6-410c-bc78-2d54a9991870"),
                    Name = "IT Solutions LTD",
                    Address = "583 Wall Dr. Gwynn Oak, MD 21207",
                    Country = "USA"
                },

                new Company
                {
                    Id = new System.Guid("3d490a70-94ce-4d15-9494-5248280c2ce3"),
                    Name = "Admin Solutions LTD",
                    Address = "312 Forest avenue, BF 923",
                    Country = "USA"
                }
            );
        }
    }
}
