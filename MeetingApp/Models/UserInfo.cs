using System.ComponentModel.DataAnnotations;

namespace MeetingApp.Models{

    public class UserInfo{
        public int Id { get; set; }

        [Required(ErrorMessage = "Ad Alanı Boş Bırakılmamalıdır")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Soyad Alanı Boş Bırakılmamalıdır")]
        public string? Surname { get; set; }

        [Required(ErrorMessage = "Telefon Numarası Alanı Boş Bırakılmamalıdır")]
        [RegularExpression(@"^\d{10}$", ErrorMessage ="Geçerli Telefon Numarası Giriniz")]
        public string? Phone { get; set; }

        [Required(ErrorMessage = "Email Alanı Boş Bırakılmamalıdır")]
        [EmailAddress(ErrorMessage = "Mailinizi ***@***.com formatında giriniz!")]
        public string? Email { get; set; }
        public bool? WillAttend { get; set; }
    }
}