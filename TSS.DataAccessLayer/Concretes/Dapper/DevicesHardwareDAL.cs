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
    public class DevicesHardwareDAL : IDevicesHardwareServices
    {
        public IDbConnection GetConnection()
        {
            return new SQLiteConnection("datasource=" + Application.StartupPath + "\\DataBase\\TechnicalService.db");
        }

        public void AddEntities(Devices_Hardware Tentities)
        {
            using (IDbConnection connection = GetConnection())
            {
                connection.Execute("INSERT INTO Devices_Hardware(DeviceID,HardwareID)VALUES(@deviceid,@hardwareid)", Tentities);
            }
        }

        public void DeleteEntities(int id)
        {
            using (IDbConnection connection = GetConnection())
            {
                connection.Execute("DELETE FROM Devices_Hardware WHERE ID=@id", id);
            }
        }

        public List<Devices_Hardware> GetAllEntities()
        {
            using (IDbConnection connection = GetConnection())
            {
                string query = @"SELECT Devices_Hardware.ID ID, Devices.ID DevID, devices.Name DevName, Devices.Model DevModel, Devices.Producer DevProd,
Hardwares.ID HardID, Hardwares.name HardName, Hardwares.Producer HardProd, Hardwares.Model HardModel,
Hardwares_Type.ID HardwareTypeID, Hardwares_Type.name HardwareTypeName
FROM Devices_Hardware
INNER JOIN Devices ON Devices_Hardware.DeviceID = Devices.ID
INNER JOIN Hardwares ON Devices_Hardware.HardwareID = Hardwares.ID
INNER JOIN Hardwares_Type ON Hardwares.HardwareTypeID = Hardwares_Type.ID";
                return connection.Query<TSS.Entities.Concretes.Devices_Hardware>(query).ToList();
            }
        }


        public void UpdateEntities(int id, Devices_Hardware TEntities)
        {
            using (IDbConnection connection = GetConnection())
            {
                connection.Execute("INSERT INTO Devices_Hardware(DeviceID,HardwareID)VALUES(@deviceid,@hardwareid) where ID=@id", TEntities);
            }
        }
    }
}
