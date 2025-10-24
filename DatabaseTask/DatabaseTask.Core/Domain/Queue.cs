using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class Queue
    {
        [Key]
        public int Id { get; set; }
        public DateTime? RegDate { get; set; }
        [ForeignKey("ChildId")]
        public ICollection<Child> Children { get; set; }
        [ForeignKey("GroupId")]
        public ICollection<Group> Groups { get; set; }

    }
}
