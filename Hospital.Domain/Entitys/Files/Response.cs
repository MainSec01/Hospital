using Hospital.Domain.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Domain.Entitys
{
    public class Response
    {
        public int StatusCode { get; set; }
        public string ErrorMessage { get; set; }
    }
}
