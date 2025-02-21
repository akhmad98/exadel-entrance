using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManagement.DAL.Data.Maps
{
    public class UsersMap
    {
        public UsersMap(EntityTypeBuilder<Users> entityTypeBuilder)
        {
            entityTypeBuilder.HasKey(p => p.Id);
            entityTypeBuilder.Property(p => p.Username).IsRequired();
            entityTypeBuilder.Property(p => p.Password)
                .HasMaxLength(18)
                .IsRequired();
            entityTypeBuilder.Property(p => p.EmailAddress)
                .IsRequired();
            entityTypeBuilder.Property(p => p.DateOfJoinng).IsRequired();
        }
    }
}