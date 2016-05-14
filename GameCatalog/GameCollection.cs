using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data.Entity;

namespace GameCatalog
{
    public class GameCollection : DbContext
    {
        public DbSet<Game> Games { get; set; }
    }
}
