using System.ComponentModel.DataAnnotations;

namespace HotelProject.WebUI.Dtos.RegisterDto
{
    public class CreateNewUserDto
    {
        [Required(ErrorMessage ="Ad alanı gereklidir")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Soyad alanı gereklidir")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "Kullanıcı Adı alanı gereklidir")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Mail alanı gereklidir")]
        public string Mail { get; set; }

        [Required(ErrorMessage = "Şifre gereklidir VE En az 6 karakter olmalı en az 1 büyük harf,1 küçük harf ve 1 de sembol barındırmalı ")]
        [Compare("Password",ErrorMessage ="Şifreler Uyuşmuyor")]
        public string Password { get; set; }

        public string ConfirmPassword { get; set; }
    }
}
