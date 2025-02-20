using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManagement.DAL.Data.DTOs
{
    public class BooksDTO
    {
        public string Title { get; set; }
        public string AuthorName { get; set; }
        // public int Year { get; set; }
        public int ViewsCount { get; set; }
    }
}