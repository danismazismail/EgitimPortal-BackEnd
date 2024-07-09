using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.Concrete
{
    public class ClassRoom : BaseEntity
    {
        [Required]
        [MaxLength(150)]
        [MinLength(3)]
        public string ClassroomName { get; set; }
        [Required]
        [MaxLength(250)]
        [MinLength(3)]
        public string Description { get; set; }
        [Required]
        public string TeacherId { get; set; }
        public Teacher Teacher { get; set; }
        public ICollection<Student> Students { get; set; }
    }
}
