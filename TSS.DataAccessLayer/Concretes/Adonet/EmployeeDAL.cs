using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TSS.DataLayer.Abstracts;
using System.Data.Common;
using TSS.Entities.Concretes;

namespace TSS.DataLayer.Concretes.Adonet
{
    public class EmployeeDAL : IEmployeeServices
    {
        string tableName = "Çalışan", dataBaseTableName = "Employees";
        TSS.DataLayer.Concretes.AdonetManagerObj.SQLiteObj sqliteobj = new TSS.DataLayer.Concretes.AdonetManagerObj.SQLiteObj();
        public EmployeeDAL()
        {
            
        }
        public void connection()
        {
            if (sqliteobj.Connection.State == System.Data.ConnectionState.Closed)
                sqliteobj.Connection.Open();
        }
        public void AddEntities(Employees Tentities)
        {
            TSS.Tools.TryManager.Run(() =>
            {

                connection();
                sqliteobj.Command.CommandText = "INSERT INTO " + dataBaseTableName + "(FirstName,LastName,Address,BirthOfDate,BirthOfPlace,PhoneNumber,HomeNumber,Mail)VALUES(@name,@lname,@address,@bdate,@bPlace,@pnumber,@hnumber,@mail)";
                sqliteobj.Command.Connection = sqliteobj.Connection;

                DbParameter nameParametre = sqliteobj.Command.CreateParameter();
                nameParametre.ParameterName = "@name";
                nameParametre.Value = Tentities.FirstName;
                sqliteobj.Command.Parameters.Add(nameParametre);

                DbParameter lnameParametre = sqliteobj.Command.CreateParameter();
                lnameParametre.ParameterName = "@lname";
                lnameParametre.Value = Tentities.LastName;
                sqliteobj.Command.Parameters.Add(lnameParametre);

                DbParameter addressParametre = sqliteobj.Command.CreateParameter();
                addressParametre.ParameterName = "@address";
                addressParametre.Value = Tentities.Address;
                sqliteobj.Command.Parameters.Add(addressParametre);

                DbParameter bdateParametre = sqliteobj.Command.CreateParameter();
                bdateParametre.ParameterName = "@bdate";
                bdateParametre.Value = Tentities.BirthOfDate.ToString();
                sqliteobj.Command.Parameters.Add(bdateParametre);

                DbParameter bPlaceParametre = sqliteobj.Command.CreateParameter();
                bPlaceParametre.ParameterName = "@bPlace";
                bPlaceParametre.Value = Tentities.BirthOfPlace;
                sqliteobj.Command.Parameters.Add(bPlaceParametre);

                DbParameter pnumberParametre = sqliteobj.Command.CreateParameter();
                pnumberParametre.ParameterName = "@pnumber";
                pnumberParametre.Value = Tentities.PhoneNumber;
                sqliteobj.Command.Parameters.Add(pnumberParametre);

                DbParameter hnumberParametre = sqliteobj.Command.CreateParameter();
                hnumberParametre.ParameterName = "@hnumber";
                hnumberParametre.Value = Tentities.HomeNumber;
                sqliteobj.Command.Parameters.Add(hnumberParametre);

                DbParameter mailParametre = sqliteobj.Command.CreateParameter();
                mailParametre.ParameterName = "@mail";
                mailParametre.Value = Tentities.Mail;
                sqliteobj.Command.Parameters.Add(mailParametre);

                sqliteobj.Command.ExecuteNonQuery();
                sqliteobj.Connection.Close();
            });
        }

        public void DeleteEntities(int id)
        {
            TSS.Tools.TryManager.Run(() =>
            {
                connection();
                string mySelectQuery = "DELETE FROM " + dataBaseTableName + " WHERE ID=@id";
                sqliteobj.Command.CommandText = mySelectQuery;
                sqliteobj.Command.Connection = sqliteobj.Connection;

                DbParameter idParametre = sqliteobj.Command.CreateParameter();
                idParametre.ParameterName = "@id";
                idParametre.Value = id;
                sqliteobj.Command.Parameters.Add(idParametre);

                sqliteobj.Command.ExecuteNonQuery();
                sqliteobj.Connection.Close();
            });
        }

        public List<Employees> GetAllEntities()
        {
            List<Employees> returnedList = new List<Employees>();
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
                            Employees employee = new Employees();
                            employee.ID = Reader.GetInt32(0);
                            employee.FirstName = Reader.GetString(1);
                            employee.LastName = Reader.GetString(2);
                            employee.Address = Reader.GetString(3);
                            employee.BirthOfDate = Reader.GetString(4);
                            employee.BirthOfPlace = Reader.GetString(5);
                            employee.PhoneNumber = Reader.GetString(6);
                            employee.HomeNumber = Reader.GetString(7);
                            employee.Mail = Reader.GetString(8);
                            returnedList.Add(employee);
                        }
                    }
                    Reader.Close();

                }
                sqliteobj.Connection.Close();
            });
            return returnedList;
        }

        public Employees getEntitie(string id)
        {
            Employees returnData = new Employees();
            TSS.Tools.TryManager.Run(() =>
            {

                connection();
                sqliteobj.Command.CommandText = "SELECT * FROM " + dataBaseTableName + " WHERE FirstName LIKE @aranan OR LastName LIKE @aranan OR Mail LIKE @aranan";
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
                            Employees employee = new Employees();
                            employee.ID = Reader.GetInt32(0);
                            employee.FirstName = Reader.GetString(1);
                            employee.LastName = Reader.GetString(2);
                            employee.Address = Reader.GetString(3);
                            employee.BirthOfDate = Reader.GetString(4);
                            employee.BirthOfPlace = Reader.GetString(5);
                            employee.PhoneNumber = Reader.GetString(6);
                            employee.HomeNumber = Reader.GetString(7);
                            employee.Mail = Reader.GetString(8);
                            returnData = employee;
                        }
                    }
                    Reader.Close();

                }
                sqliteobj.Connection.Close();
            });

            return returnData;
        }

        public Employees getEntities(int id)
        {
            Employees returnData = new Employees();
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
                            Employees employee = new Employees();
                            employee.ID = Reader.GetInt32(0);
                            employee.FirstName = Reader.GetString(1);
                            employee.LastName = Reader.GetString(2);
                            employee.Address = Reader.GetString(3);
                            employee.BirthOfDate = Reader.GetString(4);
                            employee.BirthOfPlace = Reader.GetString(5);
                            employee.PhoneNumber = Reader.GetString(6);
                            employee.HomeNumber = Reader.GetString(7);
                            employee.Mail = Reader.GetString(8);
                            returnData = employee;
                        }

                    }
                    Reader.Close();

                }
                sqliteobj.Connection.Close();

            });

            return returnData;
        }
        public List<Employees> getEntities(string id)
        {
            List<Employees> returnData = new List<Employees>();
            TSS.Tools.TryManager.Run(() =>
            {

                connection();
                sqliteobj.Command.CommandText = "SELECT * FROM " + dataBaseTableName + " WHERE FirstName LIKE @aranan OR LastName LIKE @aranan OR Mail LIKE @aranan";
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
                            Employees employee = new Employees();
                            employee.ID = Reader.GetInt32(0);
                            employee.FirstName = Reader.GetString(1);
                            employee.LastName = Reader.GetString(2);
                            employee.Address = Reader.GetString(3);
                            employee.BirthOfDate = Reader.GetString(4);
                            employee.BirthOfPlace = Reader.GetString(5);
                            employee.PhoneNumber = Reader.GetString(6);
                            employee.HomeNumber = Reader.GetString(7);
                            employee.Mail = Reader.GetString(8);
                            returnData.Add(employee);
                        }
                    }
                    Reader.Close();

                }


                sqliteobj.Connection.Close();
            });

            return returnData;
        }
        public void UpdateEntities(int id, Employees TEntities)
        {
            TSS.Tools.TryManager.Run(() =>
            {

                connection();
                sqliteobj.Command.CommandText = "UPDATE " + dataBaseTableName + " SET FirstName=@name,LastName=@lname,Address=@address,BirthOfDate=@date,BirthOfPlace=@place,PhoneNumber=@number,HomeNumber=@hnumber,Mail=@mail WHERE ID=@id";
                sqliteobj.Command.Connection = sqliteobj.Connection;

                DbParameter idParametre = sqliteobj.Command.CreateParameter();
                idParametre.ParameterName = "@id";
                idParametre.Value = id;
                sqliteobj.Command.Parameters.Add(idParametre);

                DbParameter nameParametre = sqliteobj.Command.CreateParameter();
                nameParametre.ParameterName = "@name";
                nameParametre.Value = TEntities.FirstName;
                sqliteobj.Command.Parameters.Add(nameParametre);

                DbParameter lnameParametre = sqliteobj.Command.CreateParameter();
                lnameParametre.ParameterName = "@lname";
                lnameParametre.Value = TEntities.LastName;
                sqliteobj.Command.Parameters.Add(lnameParametre);

                DbParameter addressParametre = sqliteobj.Command.CreateParameter();
                addressParametre.ParameterName = "@address";
                addressParametre.Value = TEntities.Address;
                sqliteobj.Command.Parameters.Add(addressParametre);

                DbParameter bdateParametre = sqliteobj.Command.CreateParameter();
                bdateParametre.ParameterName = "@date";
                bdateParametre.Value = TEntities.BirthOfDate.ToString();
                sqliteobj.Command.Parameters.Add(bdateParametre);

                DbParameter bPlaceParametre = sqliteobj.Command.CreateParameter();
                bPlaceParametre.ParameterName = "@place";
                bPlaceParametre.Value = TEntities.BirthOfPlace;
                sqliteobj.Command.Parameters.Add(bPlaceParametre);

                DbParameter pnumberParametre = sqliteobj.Command.CreateParameter();
                pnumberParametre.ParameterName = "@number";
                pnumberParametre.Value = TEntities.PhoneNumber;
                sqliteobj.Command.Parameters.Add(pnumberParametre);

                DbParameter hnumberParametre = sqliteobj.Command.CreateParameter();
                hnumberParametre.ParameterName = "@hnumber";
                hnumberParametre.Value = TEntities.HomeNumber;
                sqliteobj.Command.Parameters.Add(hnumberParametre);

                DbParameter mailParametre = sqliteobj.Command.CreateParameter();
                mailParametre.ParameterName = "@mail";
                mailParametre.Value = TEntities.Mail;
                sqliteobj.Command.Parameters.Add(mailParametre);

                sqliteobj.Command.ExecuteNonQuery();
                sqliteobj.Connection.Close();
            });
        }

        public Employees getEntitie(int id)
        {
            Employees returnData = new Employees();
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
                            Employees employee = new Employees();
                            employee.ID = Reader.GetInt32(0);
                            employee.FirstName = Reader.GetString(1);
                            employee.LastName = Reader.GetString(2);
                            employee.Address = Reader.GetString(3);
                            employee.BirthOfDate = Reader.GetString(4);
                            employee.BirthOfPlace = Reader.GetString(5);
                            employee.PhoneNumber = Reader.GetString(6);
                            employee.HomeNumber = Reader.GetString(7);
                            employee.Mail = Reader.GetString(8);
                            returnData = employee;
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
