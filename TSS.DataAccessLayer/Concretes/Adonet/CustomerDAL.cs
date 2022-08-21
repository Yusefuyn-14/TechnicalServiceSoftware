using System.Collections.Generic;
using TSS.DataLayer.Abstracts;
using System.Data.Common;
using TSS.Entities.Concretes;

namespace TSS.DataLayer.Concretes.Adonet
{
    public  class CustomerDAL : ICustomerServices
    {
        string tableName = "Müşteri", dataBaseTableName = "Customers";
        TSS.DataLayer.Concretes.AdonetManagerObj.SQLiteObj sqliteobj = new TSS.DataLayer.Concretes.AdonetManagerObj.SQLiteObj();

        public CustomerDAL()
        {
           
        }

        public void connection()
        {
            if (sqliteobj.Connection.State == System.Data.ConnectionState.Closed)
            {
                sqliteobj.Connection.Open();
            }
        }

        public void AddEntities(Customers Tentities)
        {

            TSS.Tools.TryManager.Run(() =>
            {

                connection();
                sqliteobj.Command.CommandText = "INSERT INTO " + dataBaseTableName + "(FirstName,LastName,Address,PhoneNumber,Mail)VALUES(@name,@lname,@address,@number,@mail)";
                sqliteobj.Command.Connection = sqliteobj.Connection;

                DbParameter nameParametre = sqliteobj.Command.CreateParameter();
                nameParametre.ParameterName = "@name";
                nameParametre.Value = Tentities.Name;
                sqliteobj.Command.Parameters.Add(nameParametre);

                DbParameter lnameParametre = sqliteobj.Command.CreateParameter();
                lnameParametre.ParameterName = "@lname";
                lnameParametre.Value = Tentities.LastName;
                sqliteobj.Command.Parameters.Add(lnameParametre);

                DbParameter addressParametre = sqliteobj.Command.CreateParameter();
                addressParametre.ParameterName = "@address";
                addressParametre.Value = Tentities.Address;
                sqliteobj.Command.Parameters.Add(addressParametre);

                DbParameter numberParametre = sqliteobj.Command.CreateParameter();
                numberParametre.ParameterName = "@number";
                numberParametre.Value = Tentities.PhoneNumber;
                sqliteobj.Command.Parameters.Add(numberParametre);

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

        public List<Customers> GetAllEntities()
        {
            List<Customers> returnedList = new List<Customers>();
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
                            Customers user = new Customers();
                            user.ID = Reader.GetInt32(0);
                            user.Name = Reader.GetString(1);
                            user.LastName = Reader.GetString(2);
                            user.Address = Reader.GetString(3);
                            user.PhoneNumber = Reader.GetString(4);
                            user.Mail = Reader.GetString(5);
                            returnedList.Add(user);
                        }
                    }
                    Reader.Close();
                }
                sqliteobj.Connection.Close();
            });
            return returnedList;
        }

        public Customers getEntitie(string data)
        {
            Customers returnData = new Customers();
            TSS.Tools.TryManager.Run(() =>
            {
                connection();

                sqliteobj.Command.CommandText = "SELECT * FROM " + dataBaseTableName + " WHERE FirstName LIKE @aranan OR LastName LIKE @aranan OR Mail LIKE @aranan";
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
                            Customers user = new Customers();
                            user.ID = Reader.GetInt32(0);
                            user.Name = Reader.GetString(1);
                            user.LastName = Reader.GetString(2);
                            user.Address = Reader.GetString(3);
                            user.PhoneNumber = Reader.GetString(4);
                            user.Mail = Reader.GetString(5);
                            returnData = user;
                        }
                    }
                    Reader.Close();
                }
                sqliteobj.Connection.Close();
            });
            return returnData;
        }

        

        public List<Customers> getEntities(string data)
        {
            List<Customers> returnData = new List<Customers>();
            TSS.Tools.TryManager.Run(() =>
            {

                connection();

                sqliteobj.Command.CommandText = "SELECT * FROM " + dataBaseTableName + " WHERE FirstName LIKE @aranan OR LastName LIKE @aranan OR Mail LIKE @aranan";
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
                            Customers user = new Customers();
                            user.ID = Reader.GetInt32(0);
                            user.Name = Reader.GetString(1);
                            user.LastName = Reader.GetString(2);
                            user.Address = Reader.GetString(3);
                            user.PhoneNumber = Reader.GetString(4);
                            user.Mail = Reader.GetString(5);
                            returnData.Add(user);
                        }
                    }
                    Reader.Close();
                }

                sqliteobj.Connection.Close();
               
            });
            return returnData;
        }
        public Customers getEntitie(int id)
        {
            Customers returnData = new Customers();
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
                            Customers user = new Customers();
                            user.ID = Reader.GetInt32(0);
                            user.Name = Reader.GetString(1);
                            user.LastName = Reader.GetString(2);
                            user.Address = Reader.GetString(3);
                            user.PhoneNumber = Reader.GetString(4);
                            user.Mail = Reader.GetString(5);
                            returnData = user;
                        }
                    }
                    Reader.Close();
                }

                sqliteobj.Connection.Close();
            });
            return returnData;
        }
        public void UpdateEntities(int id, Customers TEntities)
        {
            TSS.Tools.TryManager.Run(() =>
            {


                connection();
                sqliteobj.Command.CommandText = "UPDATE " + dataBaseTableName + " SET FirstName=@name,LastName=@lname,Address=@address,PhoneNumber=@number,Mail=@mail WHERE ID=@id; ";
                sqliteobj.Command.Connection = sqliteobj.Connection;

                DbParameter idParametre = sqliteobj.Command.CreateParameter();
                idParametre.ParameterName = "@id";
                idParametre.Value = id;
                sqliteobj.Command.Parameters.Add(idParametre);


                DbParameter nameParametre = sqliteobj.Command.CreateParameter();
                nameParametre.ParameterName = "@name";
                nameParametre.Value = TEntities.Name;
                sqliteobj.Command.Parameters.Add(nameParametre);

                DbParameter lnameParametre = sqliteobj.Command.CreateParameter();
                lnameParametre.ParameterName = "@lname";
                lnameParametre.Value = TEntities.LastName;
                sqliteobj.Command.Parameters.Add(lnameParametre);

                DbParameter addressParametre = sqliteobj.Command.CreateParameter();
                addressParametre.ParameterName = "@address";
                addressParametre.Value = TEntities.Address;
                sqliteobj.Command.Parameters.Add(addressParametre);

                DbParameter numberParametre = sqliteobj.Command.CreateParameter();
                numberParametre.ParameterName = "@number";
                numberParametre.Value = TEntities.PhoneNumber;
                sqliteobj.Command.Parameters.Add(numberParametre);

                DbParameter mailParametre = sqliteobj.Command.CreateParameter();
                mailParametre.ParameterName = "@mail";
                mailParametre.Value = TEntities.Mail;
                sqliteobj.Command.Parameters.Add(mailParametre);

                sqliteobj.Command.ExecuteNonQuery();
                sqliteobj.Connection.Close();
            });
        }
    }
}
