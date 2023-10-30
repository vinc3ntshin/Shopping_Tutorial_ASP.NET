﻿using Shopping_Tutor.Repository.Validation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shopping_Tutor.Models
{
    public class ProductModel
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Yêu cầu nhập Tên sản phẩm")]
        public string Name { get; set; }
        public string Slug { get; set; }
        [Required (ErrorMessage = "Yêu cầu nhập mô tả sản phẩm")]
        public string Description { get; set; }
        [Required(ErrorMessage = "Yêu cầu nhập giá sản phẩm")]
        [Range(0.01, double.MaxValue)]
        [Column(TypeName ="decimal(8, 2)")]
        public decimal Price { get; set; }
        [Required, Range(1, int.MaxValue, ErrorMessage = "Chọn một thuowng hiệu")]
        public int BrandId { get; set; }
        [Required, Range(1, int.MaxValue, ErrorMessage = "Chọn một danh mục")]
        public int CategoryId { get; set; }
        public CategoryModel Category { get; set; }
        public BrandModel Brand { get; set; }
        public string Image { get; set; } = "noimage.jpg";
        [NotMapped]
        [FileExtension]
        public IFormFile ImageUpload { get; set; }

    }
}
