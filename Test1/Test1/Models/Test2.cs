﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Test1.Models
{
    [Table("test_2")]
    public partial class Test2
    {
        [Key]
        public long Id { get; set; }
        [StringLength(10)]
        public string Phone { get; set; }
        [StringLength(10)]
        public string Type { get; set; }
        [Column("testId")]
        public long? TestId { get; set; }

        [ForeignKey(nameof(TestId))]
        [InverseProperty("Test2")]
        public virtual Test Test { get; set; }
    }
}