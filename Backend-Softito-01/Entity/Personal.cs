using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend_Softito_01.Entity
{
    public class Personal:BaseModel
    {
        public Guid UserId { get; set; }
        public decimal Salary { get; set; }
        public string SSN { get; set; }
        public virtual User User { get; set; }
    }
}
