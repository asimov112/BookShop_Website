﻿using System.ComponentModel.DataAnnotations;

namespace BookStore_Website.Models {
    public class Book {
        public int Id { get; set; }
        public string? Title { get; set; }
        [DataType(DataType.Date)]
        public DateTime PublishDate { get; set; }
        public string? Genre { get; set; }
        public decimal Price { get; set; }

    }
}
