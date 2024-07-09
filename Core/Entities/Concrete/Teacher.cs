using Core.Consts;
using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.Concrete
{
    public class Teacher : BasePerson
    {
        public Course Course { get; set; }
    }
}
