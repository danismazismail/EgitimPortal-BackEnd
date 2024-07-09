using Core.Entities.UserEntities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.UserEntities.Concrete
{
    public class AppUser : BaseIdentity
    {
        [Required]
        [MaxLength(150)]
        [MinLength(2)]
        public string FirstName { get; set; }
        [Required]
        [MaxLength(200)]
        [MinLength(2)]
        public string LastName { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }
        public int LoginCount { get; set; }
    }
}
