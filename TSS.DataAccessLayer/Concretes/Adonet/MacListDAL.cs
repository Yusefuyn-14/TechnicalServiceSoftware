using TSS.DataLayer.Abstracts;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TSS.Entities.Concretes;

namespace TSS.DataLayer.Concretes.Adonet
{
    public class MacListDAL : IMacAddressServices
    {

        string tableName = "Mac Adres", dataBaseTableName = "Mac_Address";
        TSS.DataLayer.Concretes.AdonetManagerObj.SQLiteObj sqliteobj = new TSS.DataLayer.Concretes.AdonetManagerObj.SQLiteObj();
        public MacListDAL()
        {

        }
        public void connection()
        {
            if (sqliteobj.Connection.State == System.Data.ConnectionState.Closed)
                sqliteobj.Connection.Open();
        }

        public void AddEntities(Mac_Address Tentities)
        {
            TSS.Tools.TryManager.Run(() =>
            {

                connection();
                sqliteobj.Command.CommandText = "INSERT INTO " + dataBaseTableName + "(Mac,HardwareID)VALUES(@mac,@hid)";
                sqliteobj.Command.Connection = sqliteobj.Connection;

                DbParameter macParametre = sqliteobj.Command.CreateParameter();
                macParametre.ParameterName = "@mac";
                macParametre.Value = Tentities.Mac;
                sqliteobj.Command.Parameters.Add(macParametre);

                DbParameter hidParametre = sqliteobj.Command.CreateParameter();
                hidParametre.ParameterName = "@hid";
                hidParametre.Value = Tentities.HardwaresID.ID;
                sqliteobj.Command.Parameters.Add(hidParametre);

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

        public List<Mac_Address> GetAllEntities()
        {
            List<Mac_Address> returnedList = new List<Mac_Address>();
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
                            Mac_Address macAddress = new Mac_Address(); //Description,Customer,Interested
                            macAddress.ID = Reader.GetInt32(0);
                            macAddress.Mac = Reader.GetString(1);
                            macAddress.HardwaresID = new Hardwares() { ID = Reader.GetInt32(2) };
                            returnedList.Add(macAddress);
                        }
                    }
                    Reader.Close();
                }
                sqliteobj.Connection.Close();
            });
            return returnedList;
        }

        public Mac_Address getEntitie(string data)
        {
            Mac_Address returnData = new Mac_Address();
            TSS.Tools.TryManager.Run(() =>
            {
                connection();
                sqliteobj.Command.CommandText = "SELECT * FROM " + dataBaseTableName + " WHERE Mac LIKE @aranan";

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
                            connection();
                            Mac_Address macAddress = new Mac_Address(); //Description,Customer,Interested
                            macAddress.ID = Reader.GetInt32(0);
                            macAddress.Mac = Reader.GetString(1);
                            macAddress.HardwaresID = new Hardwares() { ID = Reader.GetInt32(2) };
                            returnData = macAddress;
                        }
                    }
                    Reader.Close();
                }
                sqliteobj.Connection.Close();
            });
            return returnData;
        }

        public Mac_Address getEntitie(int id)
        {
            Mac_Address returnData = new Mac_Address();
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

                            Mac_Address macAddress = new Mac_Address(); //Description,Customer,Interested
                            macAddress.ID = Reader.GetInt32(0);
                            macAddress.Mac = Reader.GetString(1);
                            macAddress.HardwaresID = new Hardwares() { ID = Reader.GetInt32(2) };
                            returnData = macAddress;
                        }
                    }
                    Reader.Close();
                }
                sqliteobj.Connection.Close();
            });
            return returnData;
        }

        public List<Mac_Address> getEntities(string data)
        {
            List<Mac_Address> returnData = new List<Mac_Address>();
            TSS.Tools.TryManager.Run(() =>
            {


                connection();
                sqliteobj.Command.CommandText = "SELECT * FROM " + dataBaseTableName + " WHERE Mac LIKE @aranan";
                sqliteobj.Command.Connection = sqliteobj.Connection;

                DbParameter parametre = sqliteobj.Command.CreateParameter();
                parametre.ParameterName = "@aranan";
                parametre.Value = '%' + data + '%';
                sqliteobj.Command.Parameters.Add(parametre);

                using (var Reader = sqliteobj.Command.ExecuteReader())
                {
                    if (Reader.HasRows)
                    {
                        while (Reader.Read())
                        {
                            Mac_Address macAddress = new Mac_Address();
                            macAddress.ID = Reader.GetInt32(0);
                            macAddress.Mac = Reader.GetString(1);
                            macAddress.HardwaresID = new Hardwares() { ID = Reader.GetInt32(2) };
                            returnData.Add(macAddress);
                        }
                    }
                    Reader.Close();
                }
                sqliteobj.Connection.Close();
            });
            return returnData;
        }

        public void UpdateEntities(int id, Mac_Address TEntities)
        {
            TSS.Tools.TryManager.Run(() =>
            {
                connection();
                sqliteobj.Command.CommandText = "UPDATE " + dataBaseTableName + " SET Mac=@mac,HardwareID=@hid WHERE ID=@id";
                sqliteobj.Command.Connection = sqliteobj.Connection;

                DbParameter idParametre = sqliteobj.Command.CreateParameter();
                idParametre.ParameterName = "@id";
                idParametre.Value = id;
                sqliteobj.Command.Parameters.Add(idParametre);

                DbParameter macParametre = sqliteobj.Command.CreateParameter();
                macParametre.ParameterName = "@mac";
                macParametre.Value = TEntities.Mac;
                sqliteobj.Command.Parameters.Add(macParametre);

                DbParameter hidParametre = sqliteobj.Command.CreateParameter();
                hidParametre.ParameterName = "@hid";
                hidParametre.Value = TEntities.HardwaresID.ID;
                sqliteobj.Command.Parameters.Add(hidParametre);

                sqliteobj.Command.ExecuteNonQuery();
                sqliteobj.Connection.Close();
            });
        }
    }
}
