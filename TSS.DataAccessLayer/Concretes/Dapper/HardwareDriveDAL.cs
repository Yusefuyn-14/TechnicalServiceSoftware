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
    public class HardwareDriveDAL : IHardwareDriveServices
    {
        public IDbConnection GetConnection()
        {
            return new SQLiteConnection("datasource=" + Application.StartupPath + "\\DataBase\\TechnicalService.db");
        }
        public void AddEntities(Hardwares_Drive Tentities)
        {
            GetConnection().Execute("INSERT INTO Hardwares_Drive(Drive,Description)VALUES(@drive,@description)",Tentities);
        }

        public void DeleteEntities(int id)
        {
            GetConnection().Execute("DELETE FROM Hardwares_Drive WHERE ID=@id", id);
        }

        public List<Hardwares_Drive> GetAllEntities()
        {
            return GetConnection().Query<TSS.Entities.Concretes.Hardwares_Drive>("SELECT * FROM Hardwares_Drive ORDER BY ID ASC").ToList();
        }

        public void UpdateEntities(int id, Hardwares_Drive Tentities)
        {
            GetConnection().Execute("INSERT INTO Hardwares_Drive(Drive,Description)VALUES(@drive,@description)", Tentities);

        }
    }
}
