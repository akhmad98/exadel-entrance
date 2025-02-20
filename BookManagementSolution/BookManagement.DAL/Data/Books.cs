using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookManagement.DAL.Data
{
    [Table("Books")]
    public class Books : BaseEntity
    {
        [Required, Display(Name = "Title")]
        public string Title { get; set; }

        [Required, Display(Name = "Author Name")]
        public string AuthorName { get; set; }

        [Required, Display(Name = "Publication Year")]
        public DateTime PublicationYear { get; set; }

        [Required, Display(Name = "Views Count")]
        public int ViewsCount { get; set; }
    }
}