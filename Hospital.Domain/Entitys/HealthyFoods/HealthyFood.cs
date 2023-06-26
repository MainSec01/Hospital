using Hospital.Domain.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Domain.Entitys.HealthyFoods
{
    public class HealthyFood : Auditble
    {
        public string Name { get; set; }
    }
}
