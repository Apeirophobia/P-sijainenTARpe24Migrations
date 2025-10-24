using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public enum GroupType
    {
        MangerGroup,
        RegularGroup
    }
    public class Group
    {
        [Key]
        public int GroupId { get; set; }
        public int? ChildCount { get; set; }
        public string? Name { get; set; }
        public GroupType? GroupType { get; set; }
        public int? RoomNumber { get; set; }
        // public int? EmployeeId { get; set; }
        // public int? ChildId { get; set; }


    }
}
