using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using PraticandoCrud.Model;
using SQLite;

namespace PraticandoCrud.Data
{
   public  class DatabaseQuery
    {
        readonly SQLiteAsyncConnection _database;

    public DatabaseQuery(string dbPath)
    {
        _database = new SQLiteAsyncConnection(dbPath);

            _database.CreateTableAsync<User>().Wait();
    }


        #region Insertar y actualizar

        public async Task<int> SaveUserAsync(User user)
        {




            if (user.Id != 0)
            {



                return await _database.UpdateAsync(user);

            }
            else
            {

                return await _database.InsertAsync(user);



            }



        }


        #endregion

        public Task<List<User>> GetUsersValidate(string userName, string password)
        {

            return _database.QueryAsync<User>("SELECT * FROM User WHERE UserName = '" + userName + "' AND Password ='" + password + "'");
        }


    }

}