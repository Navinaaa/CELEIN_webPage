using System.ComponentModel.DataAnnotations;

namespace CELEIN_webPage.Models
{
    public class Product
    {
        [Key]
        public int ID { get; set; }
        [Required(ErrorMessage ="The product name cannot be blank")]
        [StringLength(50,MinimumLength =3,ErrorMessage ="Please enter more than 3 letters")]
        [RegularExpression(@"^[a-zA-Z0-9'-'\s-.&]*$",ErrorMessage ="Please enter a product name only using letters and numbers")]
        [Display(Name="Product Name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "The price cannot be blank")]
        [Range(0.10, 10000, ErrorMessage = "Please enter a proice between 0.10 and 10000.00")]
        [DataType(DataType.Currency)]
        [DisplayFormat(DataFormatString = "{0:c}")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "Description cannot be blank")]
        [StringLength(20000, MinimumLength = 10, ErrorMessage = "Please do not exceed 20000 characters")]
        [RegularExpression(@"^[,;a-zA-Z0-9'-'\s-.'s]*$", ErrorMessage = "Please enter a product description only using letters and numbers")]
        public string Description { get; set; }
        public int? CategoryID { get; set; }
        public virtual Category Category { get; set; }
    }
}