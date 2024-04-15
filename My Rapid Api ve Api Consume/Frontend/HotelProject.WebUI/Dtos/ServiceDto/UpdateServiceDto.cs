using System.ComponentModel.DataAnnotations;
using System;

namespace HotelProject.WebUI.Dtos.ServiceDto
{
    public class UpdateServiceDto
    {
        public int ServiceID { get; set; }

        [Required(ErrorMessage = "Hizmet ikon linki giriniz")]
        public String ServiceIcon { get; set; }

        [Required(ErrorMessage = "Hizmet başlığı giriniz")]
        [StringLength(100, ErrorMessage = "Hizmet başlığı en fazla 100 karakter olabilir")]
        public String Title { get; set; }

        [Required(ErrorMessage = "Hizmet açıklaması giriniz")]
        [StringLength(100, ErrorMessage = "Hizmet açıklaması en fazla 500 karakter olabilir")]
        public String Description { get; set; }
    }
}
