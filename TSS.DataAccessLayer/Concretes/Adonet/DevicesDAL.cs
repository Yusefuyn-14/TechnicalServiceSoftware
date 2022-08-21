using System;
using System.Collections.Generic;
using TSS.DataLayer.Abstracts;
using System.Data.Common;
using TSS.Entities.Concretes;

namespace TSS.DataLayer.Concretes.Adonet
{
    public class DevicesDAL : IDeviceServices
    {

        TSS.DataLayer.Concretes.AdonetManagerObj.SQLiteObj sqliteobj = new TSS.DataLayer.Concretes.AdonetManagerObj.SQLiteObj();
        string tableName = "Cihazlar", dataBaseTableName = "Devices";

        public DevicesDAL()
        {

        }
        public void connection()
        {
            if (sqliteobj.Connection.State == System.Data.ConnectionState.Closed)
            {
                sqliteobj.Connection.Open();
            }
        }
        public void AddEntities(Devices Tentities)
        {
            
            TSS.Tools.TryManager.Run(() =>
            {


                connection();
                sqliteobj.Command.CommandText = "INSERT INTO " + dataBaseTableName + "(Name,Producer,Model)VALUES(@name,@prod,@model)";
                sqliteobj.Command.Connection = sqliteobj.Connection;

                DbParameter nameParametre = sqliteobj.Command.CreateParameter();
                nameParametre.ParameterName = "@name";
                nameParametre.Value = Tentities.Name;
                sqliteobj.Command.Parameters.Add(nameParametre);

                DbParameter producerParametre = sqliteobj.Command.CreateParameter();
                producerParametre.ParameterName = "@prod";
                producerParametre.Value = Tentities.Producer;
                sqliteobj.Command.Parameters.Add(producerParametre);

                DbParameter modelrParametre = sqliteobj.Command.CreateParameter();
                modelrParametre.ParameterName = "@model";
                modelrParametre.Value = Tentities.Model;
                sqliteobj.Command.Parameters.Add(modelrParametre);

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

        public List<Devices> GetAllEntities()
        {
            List<Devices> returnedList = new List<Devices>();
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
                            Devices devices = new Devices();
                            devices.ID = Reader.GetInt32(0);
                            devices.Name = Reader.GetString(1);
                            devices.Producer = Reader.GetString(2);
                            devices.Model = Reader.GetString(3);

                            returnedList.Add(devices);
                        }
                    }
                    Reader.Close();
                }
                sqliteobj.Connection.Close();
            });
            return returnedList;
        }

        public Devices getEntitie(string data)
        {
            Devices returnData = new Devices();
            TSS.Tools.TryManager.Run(() =>
            {


                connection();
                sqliteobj.Command.CommandText = "SELECT * FROM " + dataBaseTableName + " WHERE Producer LIKE @aranan OR Name LIKE @aranan OR Model LIKE @aranan";

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
                            Devices devices = new Devices();
                            devices.ID = Reader.GetInt32(0);
                            devices.Name = Reader.GetString(1);
                            devices.Producer = Reader.GetString(2);
                            devices.Model = Reader.GetString(3);
                            returnData = devices;
                        }
                    }
                    Reader.Close();
                }
                sqliteobj.Connection.Close();
            });
            return returnData;
        }

        public Devices getEntitie(int id)
        {
            Devices returnData = new Devices();
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
                            Devices devices = new Devices(); //Description,Customer,Interested
                            devices.ID = Reader.GetInt32(0);
                            devices.Name = Reader.GetString(1);
                            devices.Producer = Reader.GetString(2);
                            devices.Model = Reader.GetString(3);
                            returnData = devices;
                        }
                    }
                    Reader.Close();
                }
                sqliteobj.Connection.Close();
            });
            return returnData;
        }

        public List<Devices> getEntities(string data)
        {
            List<Devices> returnData = new List<Devices>();
            TSS.Tools.TryManager.Run(() =>
            {
                connection();
                sqliteobj.Command.CommandText = "SELECT * FROM " + dataBaseTableName + " WHERE NMacame LIKE @aranan";
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
                            Devices devices = new Devices();
                            devices.ID = Reader.GetInt32(0);
                            devices.Name = Reader.GetString(1);
                            devices.Producer = Reader.GetString(2);
                            devices.Model = Reader.GetString(3);
                            returnData.Add(devices);
                        }
                    }
                    Reader.Close();
                }
                sqliteobj.Connection.Close();
            });
            return returnData;
        }

        public void UpdateEntities(int id, Devices TEntities)
        {
            TSS.Tools.TryManager.Run(() =>
            {



                connection();
                sqliteobj.Command.CommandText = "UPDATE " + dataBaseTableName + " SET Name=@name,Producer=@produc,Model=@model WHERE ID=@id";
                sqliteobj.Command.Connection = sqliteobj.Connection;

                DbParameter idParametre = sqliteobj.Command.CreateParameter();
                idParametre.ParameterName = "@id";
                idParametre.Value = id;
                sqliteobj.Command.Parameters.Add(idParametre);

                DbParameter nameParametre = sqliteobj.Command.CreateParameter();
                nameParametre.ParameterName = "@name";
                nameParametre.Value = TEntities.Name;
                sqliteobj.Command.Parameters.Add(nameParametre);

                DbParameter producParametre = sqliteobj.Command.CreateParameter();
                producParametre.ParameterName = "@produc";
                producParametre.Value = TEntities.Producer;
                sqliteobj.Command.Parameters.Add(producParametre);

                DbParameter modelParametre = sqliteobj.Command.CreateParameter();
                modelParametre.ParameterName = "@model";
                modelParametre.Value = TEntities.Model;
                sqliteobj.Command.Parameters.Add(modelParametre);

                sqliteobj.Command.ExecuteNonQuery();
                sqliteobj.Connection.Close();
            });
        }
    }
}
