using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend_Softito_01.Entity
{
    public class Jobber:BaseModel
    {
        public Guid UserId { get; set; }
        public string Plate { get; set; }
        public string WorkArea { get; set; }
        public virtual User User { get; set; }
    }
}
