using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data.Entity;

namespace GameCatalog
{
    public class SQLRepository: IRepository<Game>
    {
        private GameCollection catalog;
        private bool IsDisposed = false;

        public SQLRepository()
        {
            catalog = new GameCollection();
        }

        public void CreateGame(Game item)
        {
            catalog.Games.Add(item);
        }

        public void DeleteGame(int id)
        {
            Game g = catalog.Games.Find(id);
            if (g != null)
            {
                catalog.Games.Remove(g);
            }
        }

        public Game GetGame(int id)
        {
            return catalog.Games.Find(id);
        }

        public void Save()
        {
            catalog.SaveChanges();
        }

        public void Update(Game item)
        {
            catalog.Entry(item).State = EntityState.Modified;
        }
    }
}
