﻿using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryManagementSystem.Models
{
    public class BorrowingRecord
    {
        public int Id { get; set; }
        [ForeignKey("Book")]
        public int BookId { get; set; } // Foreign key to Book
        [ForeignKey("Patron")]
        public int PatronId { get; set; } // Foreign key to Patron
        public Book Book { get; set; }
        public Patron Patron { get; set; }
        public DateTime BorrowDate { get; set; }
        public DateTime ReturnDate { get; set; }
    }
}
