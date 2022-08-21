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
    public class ComponentTypeDAL : IComponentTypeServices
    {

        public IDbConnection GetConnection()
        {
            return new SQLiteConnection("datasource=" + Application.StartupPath + "\\DataBase\\TechnicalService.db");
        }


        public void AddEntities(Components_Type Tentities)
        {
            GetConnection().Execute("INSERT INTO Components_Type(Name,Explanation)VALUES(@name,@explanation)", Tentities);
        }

        public void DeleteEntities(int id)
        {
            GetConnection().Execute("DELETE FROM Components_Type WHERE ID=@id", new { id });
        }

        public List<Components_Type> GetAllEntities()
        {
            return GetConnection().Query<TSS.Entities.Concretes.Components_Type>("SELECT * FROM Components_Type").ToList();
        }

        public void UpdateEntities(int id, Components_Type Tentities)
        {
            GetConnection().Execute("UPDATE Components SET Name=@name,Description=@Desc,ComponentTypeID=@ctid WHERE ID=@id;", Tentities);
        }
    }
}
