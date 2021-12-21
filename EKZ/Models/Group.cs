using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EKZ.Models
{
    public class Group
    {
        [Key]
        public int GroupId { get; set; }

        [Column(TypeName = "nvarchar(10)")]
        public string GroupName { get; set; }
    }
}