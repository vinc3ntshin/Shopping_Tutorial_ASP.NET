using System.ComponentModel.DataAnnotations;

namespace Shopping_Tutor.Models
{
    public class BrandModel
    {
        [Key]
        public int Id { get; set; }
        [Required, MaxLength(10, ErrorMessage = "Yêu cầu nhập tên thương hiệu")]
		public string? Name { get; set; }
        [Required, MaxLength(50, ErrorMessage = "Yêu cầu nhập mô tả thương hiệu")]
        public string? Description { get; set; }
        [Required]
        public string? Slug { get; set; }
        public int Status { get; set; }
    }
}
