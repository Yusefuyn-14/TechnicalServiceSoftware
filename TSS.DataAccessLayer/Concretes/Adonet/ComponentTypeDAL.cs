using TSS.DataLayer.Abstracts;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Common;
using TSS.Entities.Concretes;

namespace TSS.DataLayer.Concretes.Adonet
{
    public class ComponentTypeDAL : IComponentTypeServices
    {
        TSS.DataLayer.Concretes.AdonetManagerObj.SQLiteObj sqliteobj = new TSS.DataLayer.Concretes.AdonetManagerObj.SQLiteObj();
        string tableName = "Eleman Tipleri", dataBaseTableName = "Components_Type";
        public ComponentTypeDAL()
        {
            
        }
        public void connection()
        {
            if (sqliteobj.Connection.State == System.Data.ConnectionState.Closed)
            {
                sqliteobj.Connection.Open();
            }
        }

        public List<Components_Type> GetAllEntities()
        {
            List<Components_Type> returnedList = new List<Components_Type>();
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
                            Components_Type componentType = new Components_Type();
                            componentType.ID = Reader.GetInt32(0);
                            componentType.Name = Reader.GetString(1);
                            componentType.Explanation = Reader.GetString(2);
                            returnedList.Add(componentType);
                        }
                    }
                    Reader.Close();
                }
                sqliteobj.Connection.Close();
            });
            return returnedList;
        }

        public List<Components_Type> getEntities(string data)
        {
            List<Components_Type> returnData = new List<Components_Type>();
            TSS.Tools.TryManager.Run(() =>
            {
                connection();
                sqliteobj.Command.CommandText = "SELECT * FROM " + dataBaseTableName + " WHERE Name LIKE @aranan OR Explanation LIKE @aranan";

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
                            Components_Type componentType = new Components_Type();
                            componentType.ID = Reader.GetInt32(0);
                            componentType.Name = Reader.GetString(1);
                            componentType.Explanation = Reader.GetString(2);
                            returnData.Add(componentType);
                        }
                    }
                    Reader.Close();
                }
                sqliteobj.Connection.Close();
            });
            return returnData;
        }


        public Components_Type getEntitie(int id)
        {
            Components_Type returnData = new Components_Type();
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
                            Components_Type componentType = new Components_Type(); //Description,Customer,Interested
                            componentType.ID = Reader.GetInt32(0);
                            componentType.Name = Reader.GetString(1);
                            componentType.Explanation = Reader.GetString(2);
                            returnData = componentType;
                        }
                    }
                    Reader.Close();
                }
                sqliteobj.Connection.Close();
            });
            return returnData;
        }

        public Components_Type getEntitie(string data)
        {
            Components_Type returnData = new Components_Type();
            TSS.Tools.TryManager.Run(() =>
            {
                connection();
                sqliteobj.Command.CommandText = "SELECT * FROM " + dataBaseTableName + " WHERE Name LIKE @aranan";
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
                            Components_Type componentType = new Components_Type(); //Description,Customer,Interested
                            componentType.ID = Reader.GetInt32(0);
                            componentType.Name = Reader.GetString(1);
                            componentType.Explanation = Reader.GetString(2);
                            returnData = componentType;
                        }
                    }
                    Reader.Close();
                }
                sqliteobj.Connection.Close();
            });
            return returnData;
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

        public void UpdateEntities(int id, Components_Type TEntities)
        {
            TSS.Tools.TryManager.Run(() =>
            {
                connection();
                sqliteobj.Command.CommandText = "UPDATE " + dataBaseTableName + " SET Name=@name,Explanation=@expl WHERE ID=@id";
                sqliteobj.Command.Connection = sqliteobj.Connection;

                DbParameter idParametre = sqliteobj.Command.CreateParameter();
                idParametre.ParameterName = "@id";
                idParametre.Value = id;
                sqliteobj.Command.Parameters.Add(idParametre);

                DbParameter nameParametre = sqliteobj.Command.CreateParameter();
                nameParametre.ParameterName = "@name";
                nameParametre.Value = TEntities.Name;
                sqliteobj.Command.Parameters.Add(nameParametre);

                DbParameter explParametre = sqliteobj.Command.CreateParameter();
                explParametre.ParameterName = "@expl";
                explParametre.Value = TEntities.Explanation;
                sqliteobj.Command.Parameters.Add(explParametre);

                sqliteobj.Command.ExecuteNonQuery();
                sqliteobj.Connection.Close();
            });
        }

        public void AddEntities(Components_Type Tentities)
        {
            TSS.Tools.TryManager.Run(() =>
            {
                connection();
                sqliteobj.Command.CommandText = "INSERT INTO " + dataBaseTableName + "(Name,Explanation)VALUES(@name,@expl)";
                sqliteobj.Command.Connection = sqliteobj.Connection;

                DbParameter nameParametre = sqliteobj.Command.CreateParameter();
                nameParametre.ParameterName = "@name";
                nameParametre.Value = Tentities.Name;
                sqliteobj.Command.Parameters.Add(nameParametre);

                DbParameter explParametre = sqliteobj.Command.CreateParameter();
                explParametre.ParameterName = "@expl";
                explParametre.Value = Tentities.Explanation;
                sqliteobj.Command.Parameters.Add(explParametre);

                sqliteobj.Command.ExecuteNonQuery();
                sqliteobj.Connection.Close();
            });
        }
    }
}
