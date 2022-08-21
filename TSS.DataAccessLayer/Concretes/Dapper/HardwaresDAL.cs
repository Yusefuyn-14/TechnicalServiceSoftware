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
    public class HardwaresDAL : IHardwareServices
    {
        public IDbConnection GetConnection()
        {
            return new SQLiteConnection("datasource=" + Application.StartupPath + "\\DataBase\\TechnicalService.db");
        }
        public void AddEntities(Hardwares Tentities)
        {
            GetConnection().Execute("INSERT INTO Hardwares(Name,Description,CompTypeID)VALUES(@compname,@compdesc,@comptypeid)", Tentities);
        }

        public void DeleteEntities(int id)
        {
            GetConnection().Execute("DELETE FROM Hardwares WHERE ID=@id", new { id });
        }

        public List<Hardwares> GetAllEntities()
        {
            string query = @"SELECT Hardwares.ID ID, Hardwares.Name, Hardwares.Producer, Hardwares.Model,Hardwares_Type.ID HID, Hardwares_Type.name HardwaresTypeName
FROM Hardwares
INNER JOIN Hardwares_Type ON Hardwares.HardwareTypeID = Hardwares_Type.ID
ORDER BY Hardwares.ID ASC";
            //var listHardwares = GetConnection().Query<Hardwares, Hardwares_Type, Hardwares>(query,
            //   (Hardwares, Hardwares_Type) => { Hardwares.HardwareType = Hardwares_Type; return Hardwares; },
            //   splitOn: "HID").ToList();
            return GetConnection().Query<Hardwares>(query).ToList();

        }

        public Hardwares GetLastAddedHardware()
        {
            string query = @"SELECT Hardwares.ID ID, Hardwares.Name, Hardwares.Producer, Hardwares.Model, Hardwares_Type.ID HardwaresTypeID, Hardwares_Type.name HardwaresTypeName
FROM Hardwares
INNER JOIN Hardwares_Type ON Hardwares.HardwareTypeID = Hardwares_Type.ID
ORDER BY Hardwares.ID DESC LIMIT 1";
            return GetConnection().QueryFirst<Hardwares>(query);
        }

        public void UpdateEntities(int id, Hardwares Tentities)
        {
            GetConnection().Execute("UPDATE Components SET Name=@name,Producer=@Desc,ComponentTypeID=@ctid WHERE ID=@id;", Tentities);
        }
    }
}
