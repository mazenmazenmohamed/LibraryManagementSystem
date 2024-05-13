using LibraryManagementSystem.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LibraryManagementSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BorrowingRecordController : ControllerBase
    {
        private readonly Dbcontext _context;

        public BorrowingRecordController(Dbcontext context)
        {
            _context = context;
        }

        // POST: api/borrow/{bookId}/patron/{patronId}
        [HttpPost("{bookId}/patron/{patronId}")]
        public async Task<IActionResult> BorrowBook(int bookId, int patronId)
        {
            var book = await _context.Books.FindAsync(bookId);
            var patron = await _context.Patrons.FindAsync(patronId);

            if (book == null || patron == null)
            {
                return NotFound("Book or Patron not found.");
            }

            // Check if book is available to borrow
            if (!_context.BorrowingRecords.Any(br => br.BookId == bookId && br.ReturnDate == null))
            {
                var borrowingRecord = new BorrowingRecord
                {
                    BookId = bookId,
                    PatronId = patronId,
                    BorrowDate = DateTime.Now,
                    ReturnDate = DateTime.MinValue // Set to a default value
                };

                _context.BorrowingRecords.Add(borrowingRecord);
                await _context.SaveChangesAsync();

                return Ok("Book borrowed successfully.");
            }

            return BadRequest("Book is already borrowed.");
        }

        // PUT: api/return/{bookId}/patron/{patronId}
        [HttpPut("{bookId}/patron/{patronId}")]
        public async Task<IActionResult> ReturnBook(int bookId, int patronId)
        {
            var borrowingRecord = await _context.BorrowingRecords.FirstOrDefaultAsync(br => br.BookId == bookId && br.PatronId == patronId && br.ReturnDate == null);

            if (borrowingRecord == null)
            {
                return NotFound("Borrowing record not found.");
            }

            borrowingRecord.ReturnDate = DateTime.Now;
            await _context.SaveChangesAsync();

            return Ok("Book returned successfully.");
        }
    }
}
