using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TSS.DataLayer.Abstracts;
using System.Data.SQLite;
using System.Windows.Forms;
using System.Data.Common;
using TSS.Entities.Concretes;

namespace TSS.DataLayer.Concretes.Adonet
{
    public class HardwareDriveDAL : IHardwareDriveServices
    {

        string tableName = "Donanımlar Sürücüleri", dataBaseTableName = "Hardwares_Drive";
        TSS.DataLayer.Concretes.AdonetManagerObj.SQLiteObj sqliteobj = new TSS.DataLayer.Concretes.AdonetManagerObj.SQLiteObj();
        public HardwareDriveDAL()
        {

        }

        public void connection()
        {
            if (sqliteobj.Connection.State == System.Data.ConnectionState.Closed)
            {
                sqliteobj.Connection.Open();
            }
        }
        public void AddEntities(Hardwares_Drive Tentities)
        {
            TSS.Tools.TryManager.Run(() =>
            {

                connection();
                sqliteobj.Command.CommandText = "insert into " + dataBaseTableName + "(HardwareID,Drive,Description)values(@hid,@dr,@des)";
                sqliteobj.Command.Connection = sqliteobj.Connection;

                DbParameter cUnIDParametre = sqliteobj.Command.CreateParameter();
                cUnIDParametre.ParameterName = "@hid";
                cUnIDParametre.Value = Tentities.Hardware.ID;
                sqliteobj.Command.Parameters.Add(cUnIDParametre);

                DbParameter nameParametre = sqliteobj.Command.CreateParameter();
                nameParametre.ParameterName = "@dr";
                nameParametre.Value = Tentities.Drive;
                sqliteobj.Command.Parameters.Add(nameParametre);

                DbParameter desParametre = sqliteobj.Command.CreateParameter();
                desParametre.ParameterName = "@des";
                desParametre.Value = Tentities.Description;
                sqliteobj.Command.Parameters.Add(desParametre);

                sqliteobj.Command.ExecuteNonQuery();
                sqliteobj.Connection.Close();
            });

        }

        public void DeleteEntities(int id)
        {
            TSS.Tools.TryManager.Run(() =>
            {
                connection();
                sqliteobj.Command.CommandText = "DELETE FROM " + dataBaseTableName + " WHERE ID=@id";
                sqliteobj.Command.Connection = sqliteobj.Connection;

                DbParameter idParametre = sqliteobj.Command.CreateParameter();
                idParametre.ParameterName = "@id";
                idParametre.Value = id;
                sqliteobj.Command.Parameters.Add(idParametre);

                sqliteobj.Command.ExecuteNonQuery();
                sqliteobj.Connection.Close();
            });
        }

        public List<Hardwares_Drive> GetAllEntities()
        {
            List<Hardwares_Drive> returnedList = new List<Hardwares_Drive>();
            TSS.Tools.TryManager.Run(() =>
            {
                connection();
                sqliteobj.Command.CommandText = "SELECT * FROM " + dataBaseTableName + " ORDER BY ID ASC";
                sqliteobj.Command.Connection = sqliteobj.Connection;
                using (var Reader = sqliteobj.Command.ExecuteReader())
                {
                    if (Reader.HasRows)
                    {
                        while (Reader.Read())
                        {
                            Hardwares_Drive hardware = new Hardwares_Drive();
                            hardware.ID = Reader.GetInt32(0);
                            hardware.Hardware = new Hardwares() { ID = Reader.GetInt32(1) };
                            hardware.Drive = Reader.GetString(2);
                            hardware.Description = Reader.GetString(3);
                            returnedList.Add(hardware);
                        }
                    }
                    Reader.Close();
                }
                sqliteobj.Connection.Close();
            });
            return returnedList;
        }

        public Hardwares_Drive getEntitie(string data)
        {
            Hardwares_Drive returnData = new Hardwares_Drive();
            TSS.Tools.TryManager.Run(() =>
            {

                connection();
                sqliteobj.Command.CommandText = "SELECT * FROM " + dataBaseTableName + " WHERE Drive LIKE @aranan OR Description LIKE @aranan";

                DbParameter parametre = sqliteobj.Command.CreateParameter();
                parametre.ParameterName = "@aranan";
                parametre.Value = '%' + data + '%';
                sqliteobj.Command.Parameters.Add(parametre);

                sqliteobj.Command.Connection = sqliteobj.Connection;
                using (var Reader = sqliteobj.Command.ExecuteReader())
                {
                    if (Reader.HasRows)
                    {
                        while (Reader.Read())
                        {
                            Hardwares_Drive hardware = new Hardwares_Drive();
                            hardware.ID = Reader.GetInt32(0);
                            hardware.Hardware  = new Hardwares() { ID = Reader.GetInt32(1) };
                            hardware.Drive = Reader.GetString(2);
                            hardware.Description = Reader.GetString(3);
                            returnData = hardware;
                        }
                    }
                    Reader.Close();
                }
                sqliteobj.Connection.Close();
            });
            return returnData;
        }

        public Hardwares_Drive getEntitie(int id)
        {
            Hardwares_Drive returnData = new Hardwares_Drive();
            TSS.Tools.TryManager.Run(() =>
            {
                connection();
                sqliteobj.Command.CommandText = "SELECT * FROM " + dataBaseTableName + " WHERE ID=@id";
                sqliteobj.Command.Connection = sqliteobj.Connection;

                DbParameter parametre = sqliteobj.Command.CreateParameter();
                parametre.ParameterName = "@id";
                parametre.Value = id;
                sqliteobj.Command.Parameters.Add(parametre);

                using (var Reader = sqliteobj.Command.ExecuteReader())
                {
                    if (Reader.HasRows)
                    {
                        while (Reader.Read())
                        {
                            Hardwares_Drive hardware = new Hardwares_Drive();
                            hardware.ID = Reader.GetInt32(0);
                            hardware.Hardware = new Hardwares() { ID = Reader.GetInt32(1) };
                            hardware.Drive = Reader.GetString(2);
                            hardware.Description = Reader.GetString(3);
                            returnData = hardware;
                        }
                    }
                    Reader.Close();
                }
                sqliteobj.Connection.Close();
            });
            return returnData;
        }

        public List<Hardwares_Drive> getEntities(string data)
        {
            List<Hardwares_Drive> returnData = new List<Hardwares_Drive>();
            TSS.Tools.TryManager.Run(() =>
            {

                connection();
                sqliteobj.Command.CommandText = "SELECT * FROM " + dataBaseTableName + " WHERE HardwareID=@id";
                sqliteobj.Command.Connection = sqliteobj.Connection;

                DbParameter parametre = sqliteobj.Command.CreateParameter();
                parametre.ParameterName = "@id";
                parametre.Value = Convert.ToInt32(data);
                sqliteobj.Command.Parameters.Add(parametre);

                using (var Reader = sqliteobj.Command.ExecuteReader())
                {
                    if (Reader.HasRows)
                    {
                        while (Reader.Read())
                        {
                            Hardwares_Drive hardware = new Hardwares_Drive();
                            hardware.ID = Reader.GetInt32(0);
                            hardware.Hardware  = new Hardwares() { ID = Reader.GetInt32(1) };
                            hardware.Drive = Reader.GetString(2);
                            hardware.Description = Reader.GetString(3);
                            returnData.Add(hardware);
                        }
                    }
                    Reader.Close();
                }
                sqliteobj.Connection.Close();
            });
            return returnData;
        }

        public void UpdateEntities(int id, Hardwares_Drive TEntities)
        {
            TSS.Tools.TryManager.Run(() =>
            {

                connection();
                sqliteobj.Command.CommandText = "UPDATE " + dataBaseTableName + " SET HardwareID=@hid,Drive=@dr,Description=@des WHERE ID=@id; ";
                sqliteobj.Command.Connection = sqliteobj.Connection;

                DbParameter idParametre = sqliteobj.Command.CreateParameter();
                idParametre.ParameterName = "@id";
                idParametre.Value = id;
                sqliteobj.Command.Parameters.Add(idParametre);

                DbParameter cUnIDParametre = sqliteobj.Command.CreateParameter();
                cUnIDParametre.ParameterName = "@hid";
                cUnIDParametre.Value = TEntities.Hardware.ID;
                sqliteobj.Command.Parameters.Add(cUnIDParametre);

                DbParameter nameParametre = sqliteobj.Command.CreateParameter();
                nameParametre.ParameterName = "@dr";
                nameParametre.Value = TEntities.Drive;
                sqliteobj.Command.Parameters.Add(nameParametre);

                DbParameter desParametre = sqliteobj.Command.CreateParameter();
                desParametre.ParameterName = "@des";
                desParametre.Value = TEntities.Description;
                sqliteobj.Command.Parameters.Add(desParametre);

                sqliteobj.Command.ExecuteNonQuery();
                sqliteobj.Connection.Close();
            });
        }
    }
}
