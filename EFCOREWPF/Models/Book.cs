using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCOREWPF.Models
{
    public class Book
    {
        [Key]
        public int ID { get; set; }
        [Required]
        [MaxLength(100)]
        public string Title { get; set; }
        [MaxLength(10000)]
        public string Des { get; set; }
        public Category Category { get; set; }
        public IEnumerable<RelBookPublisher> RelBookPublishers { get; set; }
    }
}
