using LibraryManagementSystem.Controllers;
using LibraryManagementSystem.Models;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;

namespace LibraryManagementSystem.Tests
{
    public class BooksControllerTests
    {
        private IEnumerable<Book> GetTestBooks()
        {
            return new List<Book>
            {
                new Book { Id = 1, Title = "Book 1" },
                new Book { Id = 2, Title = "Book 2" },
                new Book { Id = 3, Title = "Book 3" }
            };
        }
        [Fact]
        public async Task GetBooks_ReturnsAllBooks()
        {
            // Arrange
            var Dbcontext = new Dbcontext();
            var mockRepository = new Mock<BookController>();
            mockRepository.Setup(repo => repo.GetBooks());
                          
            var controller = new BookController(Dbcontext);

            // Act
            var result = await controller.GetBooks();

            // Assert
            var actionResult = Assert.IsType<ActionResult<IEnumerable<Book>>>(result);
            var model = Assert.IsAssignableFrom<IEnumerable<Book>>(actionResult.Value);
            Assert.Equal(3, model.Count());
        }

        
    }
}