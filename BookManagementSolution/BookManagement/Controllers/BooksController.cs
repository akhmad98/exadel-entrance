using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System;
using System.Threading.Tasks;
using BookManagement.DAL.Data;
using BookManagement.DAL.Data.DTOs;
using BookManagement.BLL;
using BookManagement.BLL.Interfaces;

namespace BookManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private UnitOfWork _unitOfWork;
        public BooksController(UnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        [HttpGet("/details/books/{id:int}")]
        public async Task<ActionResult<BooksDTO>> BooksDTO GetById(int id)
        {
            try
            {
                Books book = await _unitOfWork.Books.GetById(id);
                var bookWithDto = new BooksDTO
                {
                    Title = book.Title,
                    AuthorName = book.AuthorName,
                    ViewsCount = book.ViewsCount,
                    PublicationYear = book.PublicationYear.Year,
                };

                return Ok(book);
            }
            catch (System.Exception ex)
            { 
                throw new ArgumentException("Exception thrown");
            }
        }

        [HttpPut("{id:int}")]
        public async Task<ActionResult<BooksDTO>> UpdateBook(int id, [FromBody] ICreateBooks value)
        {
            try
            {
                var bookToUpdate = await _unitOfWork.Books.GetById(id);
                
                if (bookToUpdate == null) {
                    return NotFound($"Book with this Id not ofund");
                }
                const dateConvertedValue = new Books
                {
                    Id = bookToUpdate.Id,
                    Title = value.Title,
                    AuthorName = value.AuthorName,
                    PublicationYear = new DateTime(Convert.ToInt32(values.PublicationYear), 1, 1)
                }

                var updatedBook = await _unitOfWork.Books.Update(dateConvertedValue);
                var bookWithDto = new BooksDTO
                {
                    Title = updatedBook.Title,
                    AuthorName = updatedBook.AuthorName,
                    ViewsCount = updatedBook.ViewsCount,
                };
                return bookWithDto;

            }
            catch (System.Exception)
            {
                
                throw "error";
            }
        }

        [HttpPost("{id:int}")]
        public async Task<ActionResult<BooksDTO>> Create(ICreateBooks values)
        {
            try
            {
                if (values == null) {
                    return BadRequest();
                }
                if (values.PublicationYear.Length != 4) {
                    throw new ArgumentException("Invalid Publication Year format provided!");
                }
                const BooksDTO convertedValue = new BooksDTO {
                    Title = values.Title,
                    AuthorName = values.AuthorName,
                    ViewsCount = values.ViewsCount,
                    PublicationYear = new DateTime(Convert.ToInt32(values.PublicationYear), 1, 1)
                }
                
                var createdBook = await _unitOfWork.Books.Create(convertedValue);

                return CreatedAtAction(nameof(GetById), new { id = createdBook.Id } , createdBook); 
            }
            catch (System.Exception)
            {
                
                throw "error";
            }
        }
    }
}