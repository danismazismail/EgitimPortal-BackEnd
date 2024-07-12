using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.Abstract
{
    public class BasePerson : BaseEntity
    {
        [Required]
        public Guid AppUserId { get; set; }
        [Required]
        [MaxLength(100)]
        [MinLength(2)]
        public string FirstName { get; set; }
        [Required]
        [MaxLength(200)]
        [MinLength(2)]
        public string LastName { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }
    }
}
