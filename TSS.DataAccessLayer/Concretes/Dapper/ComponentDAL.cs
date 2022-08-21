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
    public class ComponentDAL : IComponentServices
    {
        public IDbConnection GetConnection()
        {
            return new SQLiteConnection("datasource=" + Application.StartupPath + "\\DataBase\\TechnicalService.db");
        }

        public void AddEntities(Components Tentities)
        {
            GetConnection().Execute("INSERT INTO Components(Name,Description,CompTypeID)VALUES(@compname,@compdesc,@comptypeid)", Tentities);
        }

        public void DeleteEntities(int id)
        {
            GetConnection().Execute("DELETE FROM Components WHERE ID=@id", new { id });
        }

        public List<Components> GetAllEntities()
        {
            return GetConnection().Query<TSS.Entities.Concretes.Components>("SELECT Components.ID ID, Components.Name CompName, Components.Description CompDesc, Components_Type.ID CompTypeID, Components_Type.name CompTypeName, Components_Type.Explanation CompTypeExpl FROM Components INNER JOIN Components_Type ON Components.CompTypeID = Components_Type.ID").ToList();
        }

        public void UpdateEntities(int id, Components TEntities)
        {
            GetConnection().Execute("UPDATE Components SET Name=@name,Description=@Desc,ComponentTypeID=@ctid WHERE ID=@id;", TEntities);
        }
    }
}
