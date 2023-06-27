using Hospital.Domain.Commons;
using Hospital.Domain.Entitys.DiseaseCauses;
using Hospital.Domain.Entitys.HealthyFoods;
using Hospital.Domain.Entitys.TreatmentMethods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Domain.Entitys
{
    public class Sickness : Auditble
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public IList<TreatmentMethod> TreatmentMethod { get; set; }
        public IList<DiseaseCause> DiseaseCause { get; set; }
        public IList<HealthyFood> HealthyFood { get; set; }
        public IList<Symptom> Symptom { get; set; }

        public Sickness()
        {
            TreatmentMethod = new List<TreatmentMethod>();
            DiseaseCause = new List<DiseaseCause>();
            HealthyFood = new List<HealthyFood>();
            Symptom = new List<Symptom>();
        }
    }
}
