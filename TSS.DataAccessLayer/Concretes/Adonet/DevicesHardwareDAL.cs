using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using TSS.DataLayer.Abstracts;
using System.Windows.Forms;
using System.Data.Common;
using TSS.Entities.Concretes;

namespace TSS.DataLayer.Concretes.Adonet
{
    public class DevicesHardwareDAL : IDevicesHardwareServices
    {

        TSS.DataLayer.Concretes.AdonetManagerObj.SQLiteObj sqliteobj = new TSS.DataLayer.Concretes.AdonetManagerObj.SQLiteObj();
        string tableName = "Cihaz Donanımları", dataBaseTableName = "Devices_Hardware";
        public DevicesHardwareDAL()
        {
            
        }
        public void connection()
        {
            if (sqliteobj.Connection.State == System.Data.ConnectionState.Closed)
            {
                sqliteobj.Connection.Open();
            }
        }
        public void AddEntities(Devices_Hardware Tentities)
        {
            throw new NotImplementedException();
        }

        public void DeleteEntities(int id)
        {
            throw new NotImplementedException();
        }

        public List<Devices_Hardware> GetAllEntities()
        {
            throw new NotImplementedException();
        }

        public Devices_Hardware getEntitie(string data)
        {
            throw new NotImplementedException();
        }

        public Devices_Hardware getEntitie(int id)
        {
            throw new NotImplementedException();
        }

        public List<Devices_Hardware> getEntities(string data)
        {
            List<Devices_Hardware> returnData = new List<Devices_Hardware>();
            TSS.Tools.TryManager.Run(() =>
            {
                connection();
                sqliteobj.Command.CommandText = "SELECT * FROM " + dataBaseTableName + " WHERE DeviceID=@aranan";

                DbParameter parametre = sqliteobj.Command.CreateParameter();
                parametre.ParameterName = "@aranan";
                parametre.Value = data;
                sqliteobj.Command.Parameters.Add(parametre);

                sqliteobj.Command.Connection = sqliteobj.Connection;
                using (var Reader = sqliteobj.Command.ExecuteReader())
                {
                    if (Reader.HasRows)
                    {
                        while (Reader.Read())
                        {
                            Devices_Hardware devicesHardware = new Devices_Hardware();
                            devicesHardware.ID = Reader.GetInt32(0);
                            returnData.Add(devicesHardware);
                        }
                    }
                    Reader.Close();
                }
                sqliteobj.Connection.Close();
            });
            return returnData;
        }

        public void UpdateEntities(int id, Devices_Hardware TEntities)
        {
            throw new NotImplementedException();
        }
    }
}
