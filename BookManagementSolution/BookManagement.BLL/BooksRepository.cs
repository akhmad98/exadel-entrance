using System;
using System.Web.Mvc;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
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

        private async Task<ActionResult<Books>> GetByTitle(string title)
        {
            var foundBook = await _entities.SingleOrDefault(el => el.Title == title);

            if (foundBook == null) {
                throw new ArgumentException("book not found");
            }
            return foundBook;
        }

        public async Task<ActionResult<Books>> GetById(int id)
        {
            var book = await _entities.SingleOrDefault(el => el.Id == id);

            if (book == null) {
                throw new ArgumentException("book not found");
            }
            return book;
        }

        public async Task<ActionResult> Update(Books bookBody)
        {
            if (bookBody == null)
            {
                throw new ArgumentException("not details provided");
            }

            _context.ChangeTracker.Clear();
            _entities.Attach(booBody);
            _context.Entry(bookBody).State = EntityState.Added;
            _context.SaveChanges();
        }

        public async Task<ActionResult> Create(Books bookBody)
        {
            var book = this.GetByTitle(bookBody.Title);

            if (book != null) {
                throw new ArgumentException("Book exists");
            }

            if (ModelState.IsValid)
            {
                var newBook = new BooksDTO
                {
                    Title = bookBody.Title,
                    AuthorName = bookBody.AuthorName,
                    PublicationYear =  new DateTime(Convert.ToInt32(values.PublicationYear), 1, 1)
                };

                _unitOfWork.Books.Add(newBook);
            }
        }
    }
}