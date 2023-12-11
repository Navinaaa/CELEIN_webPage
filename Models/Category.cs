using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CELEIN_webPage.Models
{
    public class Category
    {
        [Key]
        public int ID { get; set; }
        [Required(ErrorMessage ="The catogry cannot be blank")]
        [StringLength(50,MinimumLength =3, ErrorMessage ="Catogory name must be more than 3 letters")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z''-/'\s]*$", ErrorMessage ="Please enter a name starts with capital letter"+
            "and only having letters and spaces")]
        [Display(Name="Category Name")]
        public string Name { get; set; }
        public virtual ICollection<Product>Products { get; set; }
    }
}