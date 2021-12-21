using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EKZ.Models
{
    public class Student
    {
        [Key]
        public long StudentId { get; set; }

        [Column(TypeName = "nvarchar(20)")]
        public string StudentName { get; set; }

        [Column(TypeName = "nvarchar(20)")]
        public string StudentSurname { get; set; }

        public DateTime StudentBirthday { get; set; }

        [Column(TypeName = "nvarchar(12)")]
        public string StudentPhone { get; set; }

        [Column(TypeName = "nvarchar(30)")]
        public string StudentMail { get; set; }

        [Column(TypeName = "nvarchar(10)")]
        public string StudentBookNumber { get; set; }

        public int GroupId { get; set; }
        public Group Group { get; set; }
    }
}
