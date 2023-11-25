using System.ComponentModel.DataAnnotations;

namespace SignalR.WebUI.Dtos.IdentityDtos
{
    public class UserEditDto
    {
        

        [Display(Name = "Ad")]
        public string Name { get; set; }

        [Display(Name = "Soyad")]
        public string Surname { get; set; }

        [Display(Name = "Kullanıcı Adı")]
        public string Username { get; set; }

        [Display(Name = "Mail")]
        public string Mail { get; set; }


        [Display(Name ="Şifre")]
        public string Password { get; set; }

        [Display(Name = "Şifre Tekrar")]
        public string ConfirmPassword { get; set; }
    }
}
