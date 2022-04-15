using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCOREWPF.Models
{
    public class RelBookPublisher
    {
        [Required]
        public int ID { get; set; }
        public Book Book { get; set; }
        public Publisher Publisher { get; set; }
    }
}
