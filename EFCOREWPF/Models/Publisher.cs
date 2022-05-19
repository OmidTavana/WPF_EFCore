using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCOREWPF.Models
{
    public class Publisher
    {
        [Required]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public virtual IEnumerable<RelBookPublisher> RelBookPublishers { get; set; }
    }
}
