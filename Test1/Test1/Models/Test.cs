﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Test1.Models
{
    [Table("test")]
    public partial class Test
    {
        public Test()
        {
            Test2 = new HashSet<Test2>();
        }

        [Key]
        public long Id { get; set; }
        [StringLength(50)]
        public string FirstName { get; set; }
        [StringLength(50)]
        public string LastName { get; set; }
        public short? Age { get; set; }
        [Column(TypeName = "date")]
        public DateTime? Date { get; set; }

        [InverseProperty("Test")]
        public virtual ICollection<Test2> Test2 { get; set; }
    }
}