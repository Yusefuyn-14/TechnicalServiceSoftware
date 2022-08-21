using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TSS.DataLayer.Abstracts;
using TSS.Entities.Concretes;

namespace TSS.DataLayer.Concretes.Dapper
{
    class CurrencyDAL : ICurrencyServices
    {
        public IDbConnection GetConnection()
        {
            return new SQLiteConnection("datasource=" + Application.StartupPath + "\\DataBase\\TechnicalService.db");
        }
        public void AddEntities(Currency Tentities)
        {
            GetConnection().Execute("INSERT INTO Currency(Name,Symbol,GetLink)VALUES(@name,@symbol,@getlink)", Tentities);
        }

        public void DeleteEntities(int id)
        {
            GetConnection().Execute("DELETE FROM Currency WHERE ID=@id", new { id });
        }

        public List<Currency> GetAllEntities()
        {
            return GetConnection().Query<TSS.Entities.Concretes.Currency>("SELECT * FROM Currency").ToList();
        }

        public void UpdateEntities(int id, Currency Tentities)
        {
            GetConnection().Execute("UPDATE Currency SET Name=@name,Symbol=@Symbol,GetLink=@GetLink WHERE ID=@id;",Tentities);
        }
    }
}
