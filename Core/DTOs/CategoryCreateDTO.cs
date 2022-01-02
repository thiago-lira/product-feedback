using System;
using System.ComponentModel.DataAnnotations;
using Core.Models;

namespace Core.DTOs
{
    public class CategoryCreateDTO
    {
        [Required]
        public string Title { get; set; }

        public Category ToModel()
        {
            return new Category()
            {
                Title = this.Title
            };
        }
    }
}
