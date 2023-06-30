using Hospital.Domain.Entitys.HealthyFoods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Data.IRepsitory
{
    public interface IHealthyFoodRepsitory
    {
        public Task Add(HealthyFood healthyFood);
        public Task<IEnumerable<HealthyFood>> GetAll();
        public Task Update(long id, HealthyFood healthyFood);
        public Task Delete(long id);
        public Task<HealthyFood> GetById(long id);
    }
}
