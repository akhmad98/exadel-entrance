using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookManagement.DAL.Data.DTOs;

namespace BookManagement.BLL.Interfaces
{
    public interface ICreateBooks
    {
        public string Title { get; set; }
        public string AuthorName { get; set; }
        // public int Year { get; set; }
        public int ViewsCount { get; set; }
        public string PublicationYear { get; set; }
    }
}