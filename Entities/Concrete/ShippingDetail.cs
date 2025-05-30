using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities.Abstract;

namespace Entities.Concrete
{
    public  class ShippingDetail:IEntity
    {
        [Key]
        public int ShippingNumber { get; set; }

        [Required(ErrorMessage = "İsim alanının girilmesi zorunludur. ")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Soy İsim alanının girilmesi zorunludur. ")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Adres alanının girilmesi zorunludur.")]
        [StringLength(100, MinimumLength = 10, ErrorMessage = "Adres en az 10 karakter uzunluğunda olmalıdır.")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Email alanının girilmesi zorunludur.")]
        [EmailAddress(ErrorMessage = "Geçerli bir email adresi giriniz.")]
        [RegularExpression(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$", ErrorMessage = "Geçerli bir email adresi giriniz.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "yaş alanının girilmesi zorunludur. ")]
        [Range(18, 100, ErrorMessage = "Yaşınız 18 ile 100 arasında olmalıdır.")]
        public int Age { get; set; }
    }
}
