using Hospital.Domain.Commons;
using Hospital.Domain.Entitys.Hospitals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Domain.Entitys
{
    public class Doctor : Auditble
    {
        public string First_name { get; set; }
        public string Last_name { get; set; }
        public int? price { get; set; }// Qobilyatini baholash
        public string Worklocation { get; set; }
        public string Direction { get; set; }// Qo'shimcha malumotlar
        public IList<Infirmary> infirmaries { get; set; }
        public Doctor()
        {
            infirmaries = new List<Infirmary>();
        }
    }
}
