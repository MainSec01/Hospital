using Hospital.Domain.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Domain.Entitys.Files
{
    public class Picture : Auditble
    {
        public string FilePath { get; set; }
        public string FileName { get; set; }
    }
}
