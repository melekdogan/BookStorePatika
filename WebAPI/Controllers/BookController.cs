using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models.Entities;
using System.Collections.Generic;
using System.Linq;

namespace WebAPI.Controllers
{
    [Route("api/[controller]s")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private static List<Book> BookList = new List<Book>()
        {
            new Book
            {
                Id=1,
                Title="Little Women",
                GenreId=1,
                PageCount=759,
                PublishDate= new System.DateTime(1868,5,30)
            },
            new Book
            {
                Id=2,
                Title="Frankenstein",
                GenreId=2,
                PageCount=280,
                PublishDate= new System.DateTime(1818,01,01)
            },
            new Book
            {
                Id=3,
                Title="Wuthering Heights",
                GenreId=3,
                PageCount=416,
                PublishDate=new System.DateTime(1897,12,01)
              
            }
        };

        [HttpGet]
        public List<Book> GetBooks()
        {
            var bookList = BookList.OrderBy(x => x.Id).ToList<Book>();
            return bookList;
        }

    }
}
