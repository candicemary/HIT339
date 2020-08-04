using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCWebAPP._00data
{
    public class MovieDBcontext : DbContext

    {
        public MovieDBcontext(DbContextOptions<MovieDBcontext> options):base(options)
        {

        }
    }
}
