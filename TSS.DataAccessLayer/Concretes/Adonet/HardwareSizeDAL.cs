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
    public class HardwareSizeDAL : IHardwareSizeServices
    {

        string tableName = "Donanımlar Boyut", dataBaseTableName = "Hardwares_Size";
        TSS.DataLayer.Concretes.AdonetManagerObj.SQLiteObj sqliteobj = new TSS.DataLayer.Concretes.AdonetManagerObj.SQLiteObj();
        public HardwareSizeDAL()
        {

        }

        public void connection()
        {
            if (sqliteobj.Connection.State == System.Data.ConnectionState.Closed)
            {
                sqliteobj.Connection.Open();
            }
        }
        public void AddEntities(Hardwares_Size Tentities)
        {
            TSS.Tools.TryManager.Run(() =>
            {

                connection();
                sqliteobj.Command.CommandText = "insert into " + dataBaseTableName + "(HardwareID,ComputerUnitID,Size,Description)values(@hid,@cuid,@size,@des)";
                sqliteobj.Command.Connection = sqliteobj.Connection;

                DbParameter hidParametre = sqliteobj.Command.CreateParameter();
                hidParametre.ParameterName = "@hid";
                hidParametre.Value = Tentities.HardwaresID.ID;
                sqliteobj.Command.Parameters.Add(hidParametre);

                DbParameter cUnIDParametre = sqliteobj.Command.CreateParameter();
                cUnIDParametre.ParameterName = "@cuid";
                cUnIDParametre.Value = Tentities.ComputerUnitID.ID;
                sqliteobj.Command.Parameters.Add(cUnIDParametre);

                DbParameter sizeParametre = sqliteobj.Command.CreateParameter();
                sizeParametre.ParameterName = "@size";
                sizeParametre.Value = Tentities.Size;
                sqliteobj.Command.Parameters.Add(sizeParametre);

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

        public List<Hardwares_Size> GetAllEntities()
        {
            List<Hardwares_Size> returnedList = new List<Hardwares_Size>();
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
                            Hardwares_Size hardware = new Hardwares_Size();
                            hardware.ID = Reader.GetInt32(0);
                            hardware.HardwaresID = new Hardwares() { ID = Reader.GetInt32(1) };
                            hardware.ComputerUnitID = new Computer_Unit() { ID = Reader.GetInt32(2) };
                            hardware.Size = Reader.GetInt32(3);
                            hardware.Description = Reader.GetString(4);

                            returnedList.Add(hardware);
                        }
                    }
                    Reader.Close();
                }
                sqliteobj.Connection.Close();
            });
            return returnedList;
        }

        public Hardwares_Size getEntitie(string data)
        {
            Hardwares_Size returnData = new Hardwares_Size();
            TSS.Tools.TryManager.Run(() =>
            {

                connection();
                sqliteobj.Command.CommandText = "SELECT * FROM " + dataBaseTableName + " WHERE HardwareID=@id";

                DbParameter parametre = sqliteobj.Command.CreateParameter();
                parametre.ParameterName = "@id";
                parametre.Value = Convert.ToInt32(data);
                sqliteobj.Command.Parameters.Add(parametre);

                sqliteobj.Command.Connection = sqliteobj.Connection;
                using (var Reader = sqliteobj.Command.ExecuteReader())
                {
                    if (Reader.HasRows)
                    {
                        while (Reader.Read())
                        {
                            Hardwares_Size hardware = new Hardwares_Size();
                            hardware.ID = Reader.GetInt32(0);
                            hardware.HardwaresID = new Hardwares() { ID = Reader.GetInt32(1) };
                            hardware.ComputerUnitID = new Computer_Unit() { ID = Reader.GetInt32(2) };
                            hardware.Size = Reader.GetInt32(3);
                            hardware.Description = Reader.GetString(4);

                            returnData = hardware;
                        }
                    }
                    Reader.Close();
                }
                sqliteobj.Connection.Close();
            });
            return returnData;
        }

        public Hardwares_Size getEntitie(int id)
        {
            Hardwares_Size returnData = new Hardwares_Size();
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
                            Hardwares_Size hardware = new Hardwares_Size();
                            hardware.ID = Reader.GetInt32(0);
                            hardware.HardwaresID = new Hardwares() { ID = Reader.GetInt32(1) };
                            hardware.ComputerUnitID = new Computer_Unit() { ID = Reader.GetInt32(2) };
                            hardware.Size = Reader.GetInt32(3);
                            hardware.Description = Reader.GetString(4);

                            returnData = hardware;
                        }
                    }
                    Reader.Close();
                }
                sqliteobj.Connection.Close();
            });
            return returnData;
        }

        public List<Hardwares_Size> getEntities(string data)
        {
            List<Hardwares_Size> returnData = new List<Hardwares_Size>();
            TSS.Tools.TryManager.Run(() =>
            {

                connection();
                sqliteobj.Command.CommandText = "SELECT * FROM " + dataBaseTableName + " WHERE HardwareID=@id";

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
                            Hardwares_Size hardware = new Hardwares_Size();
                            hardware.ID = Reader.GetInt32(0);
                            hardware.HardwaresID = new Hardwares() { ID = Reader.GetInt32(1) };
                            hardware.ComputerUnitID = new Computer_Unit() { ID = Reader.GetInt32(2) };
                            hardware.Size = Reader.GetInt32(3);
                            hardware.Description = Reader.GetString(4);
                            returnData.Add(hardware);
                        }
                    }
                    Reader.Close();
                }
                sqliteobj.Connection.Close();
            });
            return returnData;
        }

        public void UpdateEntities(int id, Hardwares_Size TEntities)
        {
            TSS.Tools.TryManager.Run(() =>
            {

                connection();
                sqliteobj.Command.CommandText = "UPDATE " + dataBaseTableName + " SET HardwareID=@hid,ComputerUnitID=@cuid,Size=@size,Description=@des WHERE ID=@id; ";
                sqliteobj.Command.Connection = sqliteobj.Connection;

                DbParameter idParametre = sqliteobj.Command.CreateParameter();
                idParametre.ParameterName = "@id";
                idParametre.Value = id;
                sqliteobj.Command.Parameters.Add(idParametre);

                DbParameter hidParametre = sqliteobj.Command.CreateParameter();
                hidParametre.ParameterName = "@hid";
                hidParametre.Value = TEntities.HardwaresID.ID;
                sqliteobj.Command.Parameters.Add(hidParametre);

                DbParameter cUnIDParametre = sqliteobj.Command.CreateParameter();
                cUnIDParametre.ParameterName = "@cuid";
                cUnIDParametre.Value = TEntities.ComputerUnitID.ID;
                sqliteobj.Command.Parameters.Add(cUnIDParametre);

                DbParameter sizeParametre = sqliteobj.Command.CreateParameter();
                sizeParametre.ParameterName = "@size";
                sizeParametre.Value = TEntities.Size;
                sqliteobj.Command.Parameters.Add(sizeParametre);

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
