using System.ComponentModel.DataAnnotations;

namespace HotelProject.WebUI.Dtos.ServiceDto
{
    public class UpdateServiceDto
    {
        public int ServiceID { get; set; }
        [Required(ErrorMessage = "Hizmet icon linki giriniz")]
        public string ServiceIcon { get; set; }
        [Required(ErrorMessage = "Hizmet başlığı giriniz")]
        [StringLength(100, ErrorMessage = "Hizmet başlığı en fazla 100 karakter olablir")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Hizmet açıkalması giriniz")]
        [StringLength(500, ErrorMessage = "Hizmet açıklaması en fazla 100 karakter olablir")]
        public string Description { get; set; }
    }
}
