using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DatabaseTask.Repository.Models;

[Table("Person")]
public partial class Person
{
    [Key]
    public int Id { get; set; }

    [StringLength(20)]
    public string? FirstName { get; set; }

    [StringLength(20)]
    public string? LastName { get; set; }

    [StringLength(30)]
    public string? Email { get; set; }
}
