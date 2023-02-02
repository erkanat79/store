using Microsoft.AspNetCore.Mvc;
using System;

namespace Store.Web2.Controller
{
    public class SearchController : Controller
    {
        private readonly IBookRepository bookRepository;

        public SearchController(IBookRepository bookRepository)
        {
            this.bookRepository = bookRepository;
        }

        public IActionResult Index(string query)
        {   
            var books= bookRepository.GetAllByTitle(query);

            return View(books);
        }

        private IActionResult View(object books)
        {
            throw new NotImplementedException();
        }
    }
}
