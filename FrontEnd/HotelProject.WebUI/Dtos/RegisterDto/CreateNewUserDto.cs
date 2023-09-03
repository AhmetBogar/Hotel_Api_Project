using System.ComponentModel.DataAnnotations;

namespace HotelProject.WebUI.Dtos.RegisterDto
{
    public class CreateNewUserDto
    {
        [Required(ErrorMessage ="Ad Giriniz")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Soyad Giriniz")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "Kullanıcı Adı Giriniz")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Mail Giriniz")]
        public string Mail { get; set; }

        [Required(ErrorMessage = "Şifre Giriniz")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Şifrenizi Tekrar Giriniz")]
        [Compare("Password",ErrorMessage ="Şifreler Uyuşmuyor")]
        public string ConfirmPassword { get; set; }
    }
}
