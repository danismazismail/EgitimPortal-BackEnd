using Core.Entities.Concrete;
using DataAccess.Context.ApplicationContext;
using DataAccess.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Services.Concrete
{
    public class ClassRoomService : BaseRepository<ClassRoom>, IClassRoomSevice
    {
        public ClassRoomService(AppDbContext context) : base(context)
        {
        }
    }
}
