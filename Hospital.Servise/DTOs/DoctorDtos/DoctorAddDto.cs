using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Servise.DTOs.DoctorDtos
{
    public class DoctorAddDto
    {
        public string First_name { get; set; }
        public string Last_name { get; set; }
        public int? price { get; set; }
        public string Worklocation { get; set; }
        public string Direction { get; set; }
    }
}
