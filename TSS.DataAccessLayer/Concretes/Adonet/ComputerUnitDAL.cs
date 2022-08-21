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
    public class ComputerUnitDAL : IComputerUnitServices
    {

        TSS.DataLayer.Concretes.AdonetManagerObj.SQLiteObj sqliteobj = new TSS.DataLayer.Concretes.AdonetManagerObj.SQLiteObj();
        string tableName = "Bilgisayar Birim", dataBaseTableName = "Computer_Unit";
        public ComputerUnitDAL()
        {
         
        }
        public void connection()
        {
            if (sqliteobj.Connection.State == System.Data.ConnectionState.Closed)
                sqliteobj.Connection.Open();
        }

        public void AddEntities(Computer_Unit Tentities)
        {
            TSS.Tools.TryManager.Run(() =>
            {

                connection();
                sqliteobj.Command.CommandText = "INSERT INTO " + dataBaseTableName + "(Name,Abbreviation)VALUES(@name,@abbr)";
                sqliteobj.Command.Connection = sqliteobj.Connection;

                DbParameter nameParametre = sqliteobj.Command.CreateParameter();
                nameParametre.ParameterName = "@name";
                nameParametre.Value = Tentities.Name;
                sqliteobj.Command.Parameters.Add(nameParametre);

                DbParameter abbrParametre = sqliteobj.Command.CreateParameter();
                abbrParametre.ParameterName = "@abbr";
                abbrParametre.Value = Tentities.Abbreviation;
                sqliteobj.Command.Parameters.Add(abbrParametre);

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

        public List<Computer_Unit> GetAllEntities()
        {
            List<Computer_Unit> returnedList = new List<Computer_Unit>();
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
                            Computer_Unit computerUnit = new Computer_Unit();
                            computerUnit.ID = Reader.GetInt32(0);
                            computerUnit.Name = Reader.GetString(1);
                            computerUnit.Abbreviation = Reader.GetString(2);
                            returnedList.Add(computerUnit);
                        }
                    }
                    Reader.Close();
                }
                sqliteobj.Connection.Close();
            });
            return returnedList;
        }

        public Computer_Unit getEntitie(string data)
        {
            Computer_Unit returnData = new Computer_Unit();
            TSS.Tools.TryManager.Run(() =>
            {
                connection();
                sqliteobj.Command.CommandText = "SELECT * FROM " + dataBaseTableName + " WHERE Name LIKE @aranan OR Abbreviation LIKE @aranan";

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
                            Computer_Unit computerUnit = new Computer_Unit();
                            computerUnit.ID = Reader.GetInt32(0);
                            computerUnit.Name = Reader.GetString(1);
                            computerUnit.Abbreviation = Reader.GetString(2);
                            returnData = computerUnit;
                        }
                    }
                    Reader.Close();
                }
                sqliteobj.Connection.Close();
            });
            return returnData;
        }

        public Computer_Unit getEntitie(int id)
        {
            Computer_Unit returnData = new Computer_Unit();
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

                            Computer_Unit computerUnit = new Computer_Unit();
                            computerUnit.ID = Reader.GetInt32(0);
                            computerUnit.Name = Reader.GetString(1);
                            computerUnit.Abbreviation = Reader.GetString(2);
                            returnData = computerUnit;
                        }
                    }
                    Reader.Close();
                }
                sqliteobj.Connection.Close();
            });
            return returnData;
        }

        public List<Computer_Unit> getEntities(string data)
        {
            List<Computer_Unit> returnData = new List<Computer_Unit>();
            TSS.Tools.TryManager.Run(() =>
            {

            connection();
            sqliteobj.Command.CommandText = "SELECT * FROM " + dataBaseTableName + " WHERE Name LIKE @aranan OR Abbreviation LIKE @aranan";
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
                        Computer_Unit computerUnit = new Computer_Unit();
                        computerUnit.ID = Reader.GetInt32(0);
                        computerUnit.Name = Reader.GetString(1);
                        computerUnit.Abbreviation = Reader.GetString(2);
                        returnData.Add(computerUnit);
                        }
                    }
                    Reader.Close();
                }
                sqliteobj.Connection.Close();
            });
            return returnData;
        }

        public void UpdateEntities(int id, Computer_Unit TEntities)
        {
            TSS.Tools.TryManager.Run(() =>
            {
                connection();
                sqliteobj.Command.CommandText = "UPDATE " + dataBaseTableName + " SET Name=@name,Abbreviation=@abbr WHERE ID=@id";
                sqliteobj.Command.Connection = sqliteobj.Connection;

                DbParameter idParametre = sqliteobj.Command.CreateParameter();
                idParametre.ParameterName = "@id";
                idParametre.Value = id;
                sqliteobj.Command.Parameters.Add(idParametre);

                DbParameter nameParametre = sqliteobj.Command.CreateParameter();
                nameParametre.ParameterName = "@name";
                nameParametre.Value = TEntities.Name;
                sqliteobj.Command.Parameters.Add(nameParametre);

                DbParameter abbrParametre = sqliteobj.Command.CreateParameter();
                abbrParametre.ParameterName = "@abbr";
                abbrParametre.Value = TEntities.Abbreviation;
                sqliteobj.Command.Parameters.Add(abbrParametre);

                sqliteobj.Command.ExecuteNonQuery();
                sqliteobj.Connection.Close();
            });
        }
    }
}
