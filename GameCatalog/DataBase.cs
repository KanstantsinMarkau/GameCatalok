/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace GameCatalog
{
    class DataBase
    {
        public void createDB()
        {
            //name - gamecatalog

        }
        public void createTable()
        {
            //name - games

        }
        public void addGame(string request)
        {
            string ConnString ="Database=gamecatalog;Server=localhost;Uid=root;Pwd=3128314";
            MySqlConnection SqlConn;
            string req = "insert into games values " + request;
            try
            {
                SqlConn = new MySqlConnection(ConnString);
                SqlConn.Open();
                MySqlCommand myCom = new MySqlCommand();
                myCom.CommandText = req;
                myCom.Connection = SqlConn;

                myCom.ExecuteNonQuery();
                SqlConn.Close();
            }
            catch (Exception ex)
            {
                
            }
        }
        public void deleteGame(string request)
        {
            string query = "delete from games where id='" + request +"';";
            string ConnString ="Database=gamecatalog;Server=localhost;Uid=root;Pwd=3128314";
            MySqlConnection SqlConn;
            try
            {
                SqlConn = new MySqlConnection(ConnString);
                SqlConn.Open();
                MySqlCommand myCom = new MySqlCommand();
                myCom.CommandText = query;
                myCom.Connection = SqlConn;
                myCom.ExecuteNonQuery();
                SqlConn.Close();
            }
            catch (Exception ex)
            {
                
            }
        }
        public List<Game> showGames()
        {

        }
        public Game findGame()
        {

        }

    }

   
}
*/