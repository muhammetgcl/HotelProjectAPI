using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HotelProject.WebUI.Dtos.Service
{
    public class CreateServiceDto
    {
       [Required(ErrorMessage ="Hizmet Icon linki giriniz!")]
        public string ServiceIcon { get; set; }
        [Required(ErrorMessage ="Hizmet Başlığı Giriniz!")]
        [StringLength(100,ErrorMessage ="Hizmet Başlığı çok uzun!")]
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
