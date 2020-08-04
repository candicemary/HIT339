using Microsoft.EntityFrameworkCore;

namespace MVCWebAPP._00data
{
    public class DBContext
    {
        private DbContextOptions<MovieDBcontext> options;

        public DBContext(DbContextOptions<MovieDBcontext> options)
        {
            this.options = options;
        }
    }
}