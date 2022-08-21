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
    public class HardwaresDAL : IHardwareServices
    {

        string tableName = "Donanımlar", dataBaseTableName = "Hardwares";
        TSS.DataLayer.Concretes.AdonetManagerObj.SQLiteObj sqliteobj = new TSS.DataLayer.Concretes.AdonetManagerObj.SQLiteObj();
        public HardwaresDAL()
        {

        }

        public void connection()
        {
            if (sqliteobj.Connection.State == System.Data.ConnectionState.Closed)
            {
                sqliteobj.Connection.Open();
            }
        }
        public void AddEntities(Hardwares Tentities)
        {
            TSS.Tools.TryManager.Run(() =>
            {

                connection();
                sqliteobj.Command.CommandText = "insert into " + dataBaseTableName + "(HardwareTypeID,Name,Producer,Model)values(@cUnID,@name,@produc,@model)";
                sqliteobj.Command.Connection = sqliteobj.Connection;

                DbParameter cUnIDParametre = sqliteobj.Command.CreateParameter();
                cUnIDParametre.ParameterName = "@cUnID";
                //cUnIDParametre.Value = Tentities.Unit.ID;
                sqliteobj.Command.Parameters.Add(cUnIDParametre);

                DbParameter nameParametre = sqliteobj.Command.CreateParameter();
                nameParametre.ParameterName = "@name";
                nameParametre.Value = Tentities.Name;
                sqliteobj.Command.Parameters.Add(nameParametre);

                DbParameter producParametre = sqliteobj.Command.CreateParameter();
                producParametre.ParameterName = "@produc";
                producParametre.Value = Tentities.Producer;
                sqliteobj.Command.Parameters.Add(producParametre);

                DbParameter modelParametre = sqliteobj.Command.CreateParameter();
                modelParametre.ParameterName = "@model";
                modelParametre.Value = Tentities.Model;
                sqliteobj.Command.Parameters.Add(modelParametre);

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

        public List<Hardwares> GetAllEntities()
        {
            List<Hardwares> returnedList = new List<Hardwares>();
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
                            Hardwares hardware = new Hardwares();
                            hardware.ID = Reader.GetInt32(0);
                            hardware.Name = Reader.GetString(1);
                            hardware.Producer = Reader.GetString(2);
                            hardware.Model = Reader.GetString(3);
                            //hardware.Unit = new Hardwares_Type() { ID = Reader.GetInt32(4) };
                            returnedList.Add(hardware);
                        }
                    }
                    Reader.Close();
                }
                sqliteobj.Connection.Close();
            });
            return returnedList;
        }

        public Hardwares getEntitie(string data)
        {
            Hardwares returnData = new Hardwares();
            TSS.Tools.TryManager.Run(() =>
            {

                connection();
                sqliteobj.Command.CommandText = "SELECT * FROM " + dataBaseTableName + " WHERE Name LIKE @aranan OR Producer LIKE @aranan OR Model LIKE @aranan";

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
                            Hardwares hardware = new Hardwares();
                            hardware.ID = Reader.GetInt32(0);
                            hardware.Name = Reader.GetString(1);
                            hardware.Producer = Reader.GetString(2);
                            hardware.Model = Reader.GetString(3);
                            //hardware.Unit = new Hardwares_Type() { ID = Reader.GetInt32(4) };
                            returnData = hardware;
                        }
                    }
                    Reader.Close();
                }
                sqliteobj.Connection.Close();
            });
            return returnData;
        }

        public Hardwares getEntitie(int id)
        {
            Hardwares returnData = new Hardwares();
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
                            Hardwares hardware = new Hardwares();
                            hardware.ID = Reader.GetInt32(0);
                            hardware.Name = Reader.GetString(1);
                            hardware.Producer = Reader.GetString(2);
                            hardware.Model = Reader.GetString(3);
                            //hardware.Unit = new Hardwares_Type() { ID = Reader.GetInt32(4) };
                            returnData = hardware;
                        }
                    }
                    Reader.Close();
                }
                sqliteobj.Connection.Close();
            });
            return returnData;
        }

        public List<Hardwares> getEntities(string data)
        {
            List<Hardwares> returnData = new List<Hardwares>();
            TSS.Tools.TryManager.Run(() =>
            {

                connection();
                sqliteobj.Command.CommandText = "SELECT * FROM " + dataBaseTableName + " WHERE Name LIKE @aranan OR Producer LIKE @aranan OR Model LIKE @aranan";
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
                            Hardwares hardware = new Hardwares();
                            hardware.ID = Reader.GetInt32(0);
                            hardware.Name = Reader.GetString(1);
                            hardware.Producer = Reader.GetString(2);
                            hardware.Model = Reader.GetString(3);
                            //hardware.Unit = new Hardwares_Type() { ID = Reader.GetInt32(4) };
                            returnData.Add(hardware);
                        }
                    }
                    Reader.Close();
                }
                sqliteobj.Connection.Close();
            });
            return returnData;
        }

        public void UpdateEntities(int id, Hardwares TEntities)
        {
            TSS.Tools.TryManager.Run(() =>
            {

                connection();
                sqliteobj.Command.CommandText = "UPDATE " + dataBaseTableName + " SET HardwareTypeID=@cUnID,Name=@name,Producer=@producer,Model=@model WHERE ID=@id; ";
                sqliteobj.Command.Connection = sqliteobj.Connection;

                DbParameter idParametre = sqliteobj.Command.CreateParameter();
                idParametre.ParameterName = "@id";
                idParametre.Value = id;
                sqliteobj.Command.Parameters.Add(idParametre);

                DbParameter cUnIDParametre = sqliteobj.Command.CreateParameter();
                cUnIDParametre.ParameterName = "@cUnID";
                //cUnIDParametre.Value = TEntities.Unit.ID;
                sqliteobj.Command.Parameters.Add(cUnIDParametre);

                DbParameter nameParametre = sqliteobj.Command.CreateParameter();
                nameParametre.ParameterName = "@name";
                nameParametre.Value = TEntities.Name;
                sqliteobj.Command.Parameters.Add(nameParametre);

                DbParameter producerParametre = sqliteobj.Command.CreateParameter();
                producerParametre.ParameterName = "@producer";
                producerParametre.Value = TEntities.Producer;
                sqliteobj.Command.Parameters.Add(producerParametre);

                DbParameter modelParametre = sqliteobj.Command.CreateParameter();
                modelParametre.ParameterName = "@model";
                modelParametre.Value = TEntities.Model;
                sqliteobj.Command.Parameters.Add(modelParametre);

                sqliteobj.Command.ExecuteNonQuery();
                sqliteobj.Connection.Close();
            });
        }

        public Hardwares GetLastAddedHardware()
        {
            Hardwares returnData = new Hardwares();
            TSS.Tools.TryManager.Run(() =>
            {
                connection();
                sqliteobj.Command.CommandText = "SELECT * FROM " + dataBaseTableName + " ORDER BY id DESC LIMIT 1";
                sqliteobj.Command.Connection = sqliteobj.Connection;
                using (var Reader = sqliteobj.Command.ExecuteReader())
                {
                    if (Reader.HasRows)
                    {
                        while (Reader.Read())
                        {
                            Hardwares hardware = new Hardwares();
                            hardware.ID = Reader.GetInt32(0);
                            hardware.Name = Reader.GetString(1);
                            hardware.Producer = Reader.GetString(2);
                            hardware.Model = Reader.GetString(3);
                            //hardware.Unit = new Hardwares_Type() { ID = Reader.GetInt32(4) };
                            returnData = hardware;
                        }
                    }
                    Reader.Close();
                }
                sqliteobj.Connection.Close();
            });
            return returnData;
        }
    }
}
