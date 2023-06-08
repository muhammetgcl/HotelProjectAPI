using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelProject.WebUI.Models.Testimonial
{
    public class UpdateTestimonialModel
    {
        public int StaffID { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string StaffFace { get; set; }
        public string StaffTwitter { get; set; }
        public string StaffInstagram { get; set; }
    }
}
