using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.Concrete
{
    public class CustomerManager :BasePerson
    {
        [Required]
        [DataType(DataType.Date)]
        public DateTime HireDate { get; set; }
    }
}
