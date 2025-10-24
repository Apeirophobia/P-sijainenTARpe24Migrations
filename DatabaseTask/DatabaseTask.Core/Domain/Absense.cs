using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class Absense
    {
        [Key]
        public int AbsenseId { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string? Reason { get; set; }
        [ForeignKey("GroupId")]
        public ICollection<Group> Groups { get; set; }
        [ForeignKey("ChildId")]
        public ICollection<Child> Children { get; set; }
    }
}
