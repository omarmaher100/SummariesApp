using System;

namespace Summaries.Data
{
    public class Book
    {
        public int Id { get; set; }
        public string Tiltle { get; set; }
        public string Author { get; set; }
        public string Description { get; set; }
        public double? Rate { get; set; }
        public DateTime? DateStart { get; set; }
        public DateTime? DateEnd { get; set; }
    }
}