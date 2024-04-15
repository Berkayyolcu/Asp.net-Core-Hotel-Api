using System;
using System.ComponentModel.DataAnnotations;

namespace HotelProject.WebUI.Dtos.ServiceDto
{
    public class CreateServiceDto
    {
        [Required(ErrorMessage = "Hizmet ikon linki giriniz")]
        public String ServiceIcon { get; set; }

        [Required(ErrorMessage = "Hizmet başlığı giriniz")]
        [StringLength(100,ErrorMessage = "Hizmet başlığı en fazla 100 karakter olabilir")]
        public String Title { get; set; }
        public String Description { get; set; }
    }
}
