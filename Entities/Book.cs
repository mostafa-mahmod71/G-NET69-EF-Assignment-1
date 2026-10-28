using System;
using System.Collections.Generic;
using System.Text;

namespace AssignmentEFC01.Entities
{
    internal class Book
    {
        public int Id { get; set; }
        public string ISBNNumber { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
        public int NumberOfPages { get; set; }
        public int YearOfPublished { get; set; }
        public bool InStock { get; set; }



    }
}
