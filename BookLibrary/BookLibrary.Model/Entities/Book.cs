using BookLibrary.Model.Entities.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary.Model.Entities
{
    public class Book : BaseEntity
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string Title { get; set; }
        public string ISBN { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public DateTime PublishedDate { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public List<BookCategory> BookCategories { get; set; }
    }
}
