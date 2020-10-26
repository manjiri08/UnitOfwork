using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UnitofWorkPattern.Data
{
    public class Context :DbContext
    {
        public Context(DbContextOptions<Context> option): base(options)
        {

        }
        protected  override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
    }
}
