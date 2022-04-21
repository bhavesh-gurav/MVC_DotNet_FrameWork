using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetCoreCarProject.WebApp._4.DataAccess.Repository
{
    public class BaseRepository
    {
        public Context context { get; set; }

        public BaseRepository(Context _context)
        {
            context = _context;
        }
    }
}
