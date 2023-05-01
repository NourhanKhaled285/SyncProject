﻿using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace SyncFProject.Models
{
    public class CategoryViewModel
    {
        [Key]
        public int CategoryId { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string Title { get; set; }
        [Column(TypeName = "nvarchar(5)")]
        public string Icon { get; set; }

        [Column(TypeName = "nvarchar(10)")]
        public string Type { get; set; }    
    }
}
