using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCOREWPF.Models
{
    public class Category
    {
        public int ID { get; set; }
        [MaxLength(100)]
        public string Title { get; set; }
        public IEnumerable<Book> Books { get; set; }
    }
}
