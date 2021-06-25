using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Entities.Configuration
{
    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.HasData
            (
                new Employee
                {
                    Id = new System.Guid("80abbca8-664d-4b20-b5de-024705497d4a"),
                    Name = "Sam Raiden",
                    Age = 26,
                    Position = "Software Developer",
                    CompanyId = new System.Guid("c9d4c053-49b6-410c-bc78-2d54a9991870")
                },
                new Employee
                {
                    Id = new System.Guid("86dba8c0-d178-41e7-938c-ed49778fb52a"),
                    Name = "Janna McLeaf",
                    Age = 30,
                    Position = "Software Developer",
                    CompanyId = new System.Guid("c9d4c053-49b6-410c-bc78-2d54a9991870")
                },
                new Employee
                {
                    Id = new System.Guid("021ca3c1-0deb-4afd-ae94-2159a8479811"),
                    Name = "Kane Miller",
                    Age = 35,
                    Position = "Administrator",
                    CompanyId = new System.Guid("3d490a70-94ce-4d15-9494-5248280c2ce3")
                }
            );
        }
    }
}
