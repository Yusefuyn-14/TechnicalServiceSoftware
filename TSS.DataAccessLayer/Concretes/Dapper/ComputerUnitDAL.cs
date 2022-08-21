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
    class ComputerUnitDAL : IComputerUnitServices
    {
        public IDbConnection GetConnection() { return new SQLiteConnection("datasource=" + Application.StartupPath + "\\DataBase\\TechnicalService.db"); }
        public void AddEntities(Computer_Unit Tentities)
        {
            GetConnection().Execute("INSERT INTO Computer_Unit(Name,Abbreviation)VALUES(@name,@abbreviation)", Tentities);
        }

        public void DeleteEntities(int id)
        {
            GetConnection().Execute("DELETE FROM Computer_Unit WHERE ID=@id", new { id });
        }

        public List<Computer_Unit> GetAllEntities()
        {
            return GetConnection().Query<TSS.Entities.Concretes.Computer_Unit>("SELECT * FROM Computer_Unit").ToList();
        }

        public void UpdateEntities(int id, Computer_Unit Tentities)
        {
            GetConnection().Execute("UPDATE Computer_Unit SET Name=@name,Abbreviation=@Abbreviation WHERE ID=@id;", Tentities);
        }
    }

}

