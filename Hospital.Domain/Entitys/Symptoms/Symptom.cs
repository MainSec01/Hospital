using Hospital.Domain.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Domain.Entitys
{
    public class Symptom : Auditble
    {
        public string Name { get; set; }
        public IList<Sickness> sickness { get; set; }

        public Symptom()
        {
            sickness = new List<Sickness>();
        }
    }
}
