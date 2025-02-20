using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManagement.DAL.Data.Maps
{
    public class BooksMap
    {
        public BooksMap(EntityTypeBuilder<Books> entityTypeBuilder)
        {
            entityTypeBuilder.HasKey(p => p.Id);
            entityTypeBuilder.Property(p => p.Title).IsRequired();
            entityTypeBuilder.Property(p => p.AuthorName).IsRequired();
            entityTypeBuilder.Property(p => p.PublicationYear).IsRequired();
            entityTypeBuilder.Property(p => p.ViewsCount).IsRequired();
        }
    }
}