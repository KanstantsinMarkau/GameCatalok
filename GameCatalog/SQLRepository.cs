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

        //create a new Game Collection
        public SQLRepository()
        {
            catalog = new GameCollection();
        }

        //Add new game in collection
        public void CreateGame(Game item)
        {
            catalog.Games.Add(item);
        }

        //Delete game from DB
        public void DeleteGame(int id)
        {
            Game g = catalog.Games.Find(id);
            if (g != null)
            {
                catalog.Games.Remove(g);
            }
        }

        //Get game by id
        public Game GetGame(int id)
        {
            return catalog.Games.Find(id);
        }
        //returns Game list
        public IEnumerable<Game> GetGameList()
        {
            return catalog.Games;
        }

        //create dispose implementation
        public virtual void Dispose(bool disp)
        {
            if(!this.IsDisposed)
            {
                if (disp)
                {
                    catalog.Dispose();
                }
            }
        }

        //aproves finish of dispose
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        //saves changes to catalog
        public void Save()
        {
            catalog.SaveChanges();
        }

        //updates items in Game
        public void Update(Game item)
        {
            catalog.Entry(item).State = EntityState.Modified;
        }
    }
}
