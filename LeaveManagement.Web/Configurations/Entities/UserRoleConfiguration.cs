using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagement.Web.Data
{
    internal class UserRoleConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "8d17e4d8-e409-4dcb-964e-0bc47dd03830",
                    UserId = "8d17e2d8-e406-4dcb-964e-0bc47c803830"
                },
                new IdentityUserRole<string>
                {
                    RoleId = "5d17e2d8-e406-4dcc-964e-0bc47c803830",
                    UserId = "8d17e2d8-e406-4dcb-caac-0bc47c803830"
                }
            );
        }
    }
}