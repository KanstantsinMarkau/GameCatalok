using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameCatalog
{
    public interface IRepository<T> : IDisposable
        where T : class
    {

        //getting all games
        IEnumerable<T> GetGameList();
        //get one game by id
        T GetGame(int id);
        //create game
        void CreateGame(T item);
        //refresh games list
        void UpdateGame(T item);
        //delete game
        void DeleteGame(int id);
        //save changes
        void Save();


    }
}
