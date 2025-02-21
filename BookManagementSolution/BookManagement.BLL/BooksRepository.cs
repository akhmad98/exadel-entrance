using System;
using BookManagement.DAL.Data;
using BookManagement.DAL.Data.DTOs;
using BookManagement.BLL.Interfaces;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace BookManagement.BLL
{
    public class BooksRepository : Repository<Books>, IBRepository
    {
       public BooksRepository(ApplicationContext context) : base(context)
        {
        }
    }
}