using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Common;
using TSS.Entities.Concretes;
using TSS.DataLayer.Abstracts;

namespace TSS.DataLayer.Concretes.Adonet
{
    public class TroubleDAL : ITroubleServices
    {
        string tableName = "Arıza", dataBaseTableName = "Troubles";
        TSS.DataLayer.Concretes.AdonetManagerObj.SQLiteObj sqliteobj = new TSS.DataLayer.Concretes.AdonetManagerObj.SQLiteObj();
        public TroubleDAL()
        {
        }
        public void connection()
        {
            if (sqliteobj.Connection.State == System.Data.ConnectionState.Closed)
                sqliteobj.Connection.Open();
        }
        public void AddEntities(Troubles Tentities)
        {
            TSS.Tools.TryManager.Run(() =>
            {
                connection();
                sqliteobj.Command.CommandText = "INSERT INTO " + dataBaseTableName + "(Description,CustomerID,EmployeeID,Title,Date,TroubleStatusID)VALUES(@descrption,@customer,@interested,@title,@date,@stat)";
                sqliteobj.Command.Connection = sqliteobj.Connection;

                DbParameter descrptionParametre = sqliteobj.Command.CreateParameter();
                descrptionParametre.ParameterName = "@descrption";
                descrptionParametre.Value = Tentities.Description;
                sqliteobj.Command.Parameters.Add(descrptionParametre);

                DbParameter customerParametre = sqliteobj.Command.CreateParameter();
                customerParametre.ParameterName = "@customer";
                customerParametre.Value = Tentities.Customer.ID;
                sqliteobj.Command.Parameters.Add(customerParametre);

                DbParameter interestedParametre = sqliteobj.Command.CreateParameter();
                interestedParametre.ParameterName = "@interested";
                interestedParametre.Value = Tentities.Interested.ID;
                sqliteobj.Command.Parameters.Add(interestedParametre);

                //DbParameter devidParametre = sqliteobj.Command.CreateParameter();
                //devidParametre.ParameterName = "@devid";
                //devidParametre.Value = Tentities.DevicesID.ID;
                //sqliteobj.Command.Parameters.Add(devidParametre);

                DbParameter titleParametre = sqliteobj.Command.CreateParameter();
                titleParametre.ParameterName = "@title";
                titleParametre.Value = Tentities.Title;
                sqliteobj.Command.Parameters.Add(titleParametre);

                DbParameter dateParametre = sqliteobj.Command.CreateParameter();
                dateParametre.ParameterName = "@date";
                dateParametre.Value = Tentities.Date;
                sqliteobj.Command.Parameters.Add(dateParametre);

                DbParameter statParametre = sqliteobj.Command.CreateParameter();
                statParametre.ParameterName = "@stat";
                statParametre.Value = Tentities.Status;
                sqliteobj.Command.Parameters.Add(statParametre);

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

        public List<Troubles> GetAllEntities()
        {
            List<Troubles> returnedList = new List<Troubles>();
            TSS.Tools.TryManager.Run((() =>
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
                            Troubles trouble = new Troubles(); //Description,Customer,Interested

                            trouble.ID = Reader.GetInt32(0);
                            trouble.Description = Reader.GetString(1);
                            trouble.Customer = new Customers() { ID = Reader.GetInt32(2) };
                            trouble.Interested = new Employees() { ID = Reader.GetInt32(3) };
                            trouble.Title = Reader.GetString(4);
                            trouble.Date = DateTime.Parse(Reader.GetString(5));
                            trouble.Status = Reader.GetInt32(6);
                            returnedList.Add(trouble);
                        }
                    }
                    Reader.Close();
                }
                sqliteobj.Connection.Close();
            }));
            return returnedList;
        }

        public Troubles getEntitie(string id)
        {
            Troubles returnData = new Troubles();
            TSS.Tools.TryManager.Run((() =>
            {

                connection();
                sqliteobj.Command.CommandText = "SELECT * FROM " + dataBaseTableName + " WHERE Description LIKE @aranan";
                sqliteobj.Command.Connection = sqliteobj.Connection;

                DbParameter parametre = sqliteobj.Command.CreateParameter();
                parametre.ParameterName = "@aranan";
                parametre.Value = '%' + id + '%';
                sqliteobj.Command.Parameters.Add(parametre);


                using (var Reader = sqliteobj.Command.ExecuteReader())
                {
                    if (Reader.HasRows)
                    {
                        while (Reader.Read())
                        {
                            Troubles trouble = new Troubles(); //Description,Customer,Interested
                            trouble.ID = Reader.GetInt32(0);
                            trouble.Description = Reader.GetString(1);
                            trouble.Customer = new Customers() { ID = Reader.GetInt32(2) };
                            trouble.Interested = new Employees() { ID = Reader.GetInt32(3) };
                            trouble.Title = Reader.GetString(5);
                            trouble.Date = DateTime.Parse(Reader.GetString(6));
                            trouble.Status = Reader.GetInt32(7);

                            returnData = trouble;
                        }
                    }
                    Reader.Close();
                }
                sqliteobj.Connection.Close();

            }));
            return returnData;
        }

        public void UpdateEntities(int id, Troubles TEntities)
        {
            TSS.Tools.TryManager.Run(() =>
            {

                connection();
                sqliteobj.Command.CommandText = "UPDATE " + dataBaseTableName + " SET Description=@des,CustomerID=@cus,EmployeeID=@eid,Title=@tit,Date=@dat,TroubleStatusID=@stat WHERE ID=@id";
                sqliteobj.Command.Connection = sqliteobj.Connection;

                DbParameter tidParametre = sqliteobj.Command.CreateParameter();
                tidParametre.ParameterName = "@id";
                tidParametre.Value = id;
                sqliteobj.Command.Parameters.Add(tidParametre);

                DbParameter descrptionParametre = sqliteobj.Command.CreateParameter();
                descrptionParametre.ParameterName = "@des";
                descrptionParametre.Value = TEntities.Description;
                sqliteobj.Command.Parameters.Add(descrptionParametre);

                DbParameter customerParametre = sqliteobj.Command.CreateParameter();
                customerParametre.ParameterName = "@cus";
                customerParametre.Value = TEntities.Customer.ID;
                sqliteobj.Command.Parameters.Add(customerParametre);

                DbParameter interestedParametre = sqliteobj.Command.CreateParameter();
                interestedParametre.ParameterName = "@eid";
                interestedParametre.Value = TEntities.Interested.ID;
                sqliteobj.Command.Parameters.Add(interestedParametre);

                //DbParameter devidParametre = sqliteobj.Command.CreateParameter();
                //devidParametre.ParameterName = "@devid";
                //devidParametre.Value = TEntities.DevicesID.ID;
                //sqliteobj.Command.Parameters.Add(devidParametre);

                DbParameter titleParametre = sqliteobj.Command.CreateParameter();
                titleParametre.ParameterName = "@tit";
                titleParametre.Value = TEntities.Title;
                sqliteobj.Command.Parameters.Add(titleParametre);

                DbParameter dateParametre = sqliteobj.Command.CreateParameter();
                dateParametre.ParameterName = "@dat";
                dateParametre.Value = TEntities.Date;
                sqliteobj.Command.Parameters.Add(dateParametre);

                DbParameter statParametre = sqliteobj.Command.CreateParameter();
                statParametre.ParameterName = "@stat";
                statParametre.Value = TEntities.Status;
                sqliteobj.Command.Parameters.Add(statParametre);

                sqliteobj.Command.ExecuteNonQuery();
                sqliteobj.Connection.Close();
            });
        }
        public List<Troubles> getEntities(string id)
        {
            List<Troubles> returnData = new List<Troubles>();
            TSS.Tools.TryManager.Run((() =>
            {

                connection();
                sqliteobj.Command.CommandText = "SELECT * FROM " + dataBaseTableName + " WHERE Description LIKE @aranan OR Title LIKE @aranan OR Date LIKE @aranan OR Status LIKE @aranan";
                sqliteobj.Command.Connection = sqliteobj.Connection;

                DbParameter parametre = sqliteobj.Command.CreateParameter();
                parametre.ParameterName = "@aranan";
                parametre.Value = '%' + id + '%';
                sqliteobj.Command.Parameters.Add(parametre);

                using (var Reader = sqliteobj.Command.ExecuteReader())
                {
                    if (Reader.HasRows)
                    {
                        while (Reader.Read())
                        {
                            Troubles trouble = new Troubles();
                            trouble.ID = Reader.GetInt32(0);
                            trouble.Description = Reader.GetString(1);
                            trouble.Customer = new Customers() { ID = Reader.GetInt32(2) };
                            trouble.Interested = new Employees() { ID = Reader.GetInt32(3) };
                            trouble.Title = Reader.GetString(5);
                            trouble.Date = DateTime.Parse(Reader.GetString(6));
                            trouble.Status = Reader.GetInt32(7);
                            returnData.Add(trouble);
                        }
                    }
                    Reader.Close();
                }
                sqliteobj.Connection.Close();

            }));

            return returnData;
        }

        public Troubles getEntitie(int id)
        {
            Troubles returnData = new Troubles();
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
                            Troubles trouble = new Troubles();
                            trouble.ID = Reader.GetInt32(0);
                            trouble.Description = Reader.GetString(1);
                            trouble.Customer = new Customers() { ID = Reader.GetInt32(2) };
                            trouble.Interested = new Employees() { ID = Reader.GetInt32(3) };
                            trouble.Title = Reader.GetString(5);
                            trouble.Date = DateTime.Parse(Reader.GetString(6));
                            trouble.Status = Reader.GetInt32(7);
                            returnData = trouble;
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
