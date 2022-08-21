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
    public class CurrencyDAL : ICurrencyServices
    {
        
        string tableName = "Para Birimi", dataBaseTableName = "Currency";
        TSS.DataLayer.Concretes.AdonetManagerObj.SQLiteObj sqliteobj = new TSS.DataLayer.Concretes.AdonetManagerObj.SQLiteObj();
        public CurrencyDAL()
        {
            
        }

        public void connection()
        {
            if (sqliteobj.Connection.State == System.Data.ConnectionState.Closed)
            {
                sqliteobj.Connection.Open();
            }
        }

        public void AddEntities(Currency Tentities)
        {
            TSS.Tools.TryManager.Run(() =>
            {


                connection();
                sqliteobj.Command.CommandText = "INSERT INTO " + dataBaseTableName + "(Name)VALUES(@name)";
                sqliteobj.Command.Connection = sqliteobj.Connection;

                DbParameter nameParametre = sqliteobj.Command.CreateParameter();
                nameParametre.ParameterName = "@name";
                nameParametre.Value = Tentities.Name;
                sqliteobj.Command.Parameters.Add(nameParametre);

                DbParameter symbParametre = sqliteobj.Command.CreateParameter();
                symbParametre.ParameterName = "@symb";
                symbParametre.Value = Tentities.Symbol;
                sqliteobj.Command.Parameters.Add(symbParametre);

                DbParameter getlParametre = sqliteobj.Command.CreateParameter();
                getlParametre.ParameterName = "@getl";
                getlParametre.Value = Tentities.GetLink;
                sqliteobj.Command.Parameters.Add(getlParametre);

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

        public List<Currency> GetAllEntities()
        {
            List<Currency> returnedList = new List<Currency>();
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
                            Currency currency = new Currency();
                            currency.ID = Reader.GetInt32(0);
                            currency.Name = Reader.GetString(1);
                            currency.Symbol = Reader.GetString(2);
                            currency.GetLink = Reader.GetString(3);
                            returnedList.Add(currency);
                        }
                    }
                    Reader.Close();
                }
                sqliteobj.Connection.Close();
            });
            return returnedList;
        }

        public Currency getEntitie(string data)
        {
            Currency returnData = new Currency();
            TSS.Tools.TryManager.Run(() =>
            {


                connection();
                sqliteobj.Command.CommandText = "SELECT * FROM " + dataBaseTableName + " WHERE StatusComment LIKE @aranan OR Statu LIKE @aranan";

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
                            Currency currency = new Currency();
                            currency.ID = Reader.GetInt32(0);
                            currency.Name = Reader.GetString(1);
                            currency.Symbol = Reader.GetString(2);
                            currency.GetLink = Reader.GetString(3);
                            returnData = currency;
                        }
                    }
                    Reader.Close();
                }
                sqliteobj.Connection.Close();
            });
            return returnData;
        }

        public Currency getEntitie(int id)
        {
            Currency returnData = new Currency();
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
                            Currency currency = new Currency();
                            currency.ID = Reader.GetInt32(0);
                            currency.Name = Reader.GetString(1);
                            currency.Symbol = Reader.GetString(2);
                            currency.GetLink = Reader.GetString(3);
                            returnData = currency;
                        }
                    }
                    Reader.Close();
                }
                sqliteobj.Connection.Close();
            });
            return returnData;
        }

        public List<Currency> getEntities(string data)
        {
            List<Currency> returnData = new List<Currency>();
            TSS.Tools.TryManager.Run(() =>
            {


                connection();
                sqliteobj.Command.CommandText = "SELECT * FROM " + dataBaseTableName + " WHERE StatusComment LIKE @aranan OR Statu LIKE @aranan";
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
                            Currency currency = new Currency();
                            currency.ID = Reader.GetInt32(0);
                            currency.Name = Reader.GetString(1);
                            currency.Symbol = Reader.GetString(2);
                            currency.GetLink = Reader.GetString(3);
                            returnData.Add(currency);
                        }
                    }
                    Reader.Close();
                }
                sqliteobj.Connection.Close();
            });
            return returnData;
        }

        public void UpdateEntities(int id, Currency TEntities)
        {
            TSS.Tools.TryManager.Run(() =>
            {
                connection();
                sqliteobj.Command.CommandText = "UPDATE " + dataBaseTableName + " SET Name=@name WHERE ID=@id; ";
                sqliteobj.Command.Connection = sqliteobj.Connection;

                DbParameter idParametre = sqliteobj.Command.CreateParameter();
                idParametre.ParameterName = "@id";
                idParametre.Value = id;
                sqliteobj.Command.Parameters.Add(idParametre);

                DbParameter nameParametre = sqliteobj.Command.CreateParameter();
                nameParametre.ParameterName = "@name";
                nameParametre.Value = TEntities.Name;
                sqliteobj.Command.Parameters.Add(nameParametre);

                DbParameter symbParametre = sqliteobj.Command.CreateParameter();
                symbParametre.ParameterName = "@symb";
                symbParametre.Value = TEntities.Symbol;
                sqliteobj.Command.Parameters.Add(symbParametre);

                DbParameter getlParametre = sqliteobj.Command.CreateParameter();
                getlParametre.ParameterName = "@getl";
                getlParametre.Value = TEntities.GetLink;
                sqliteobj.Command.Parameters.Add(getlParametre);

                sqliteobj.Command.ExecuteNonQuery();
                sqliteobj.Connection.Close();
            });
        }
    }
}
