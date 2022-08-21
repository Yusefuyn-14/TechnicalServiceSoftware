using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using TSS.DataLayer.Abstracts;
using System.Windows.Forms;
using TSS.Entities.Concretes;
using System.Data.Common;

namespace TSS.DataLayer.Concretes.Adonet
{
    public class EmployeeLoginDAL : IEmployeeLoginServices
    {
        string tableName = "Çalışan Hesapları", dataBaseTableName = "Employees_Account";
        TSS.DataLayer.Concretes.AdonetManagerObj.SQLiteObj sqliteobj = new TSS.DataLayer.Concretes.AdonetManagerObj.SQLiteObj();

        public EmployeeLoginDAL()
        {
            
        }
        public void connection()
        {
            if (sqliteobj.Connection.State == System.Data.ConnectionState.Closed)
            {
                sqliteobj.Connection.Open();
            }
        }
        public void AddEntities(Employees_Account Tentities)
        {
            TSS.Tools.TryManager.Run(() =>
            {


                connection();
                sqliteobj.Command.CommandText = "insert into " + dataBaseTableName + "(EmployeeID,UserName,Password,Activation)values(@id,@name,@pass,@ac)";
                sqliteobj.Command.Connection = sqliteobj.Connection;

                DbParameter eidParametre = sqliteobj.Command.CreateParameter();
                eidParametre.ParameterName = "@id";
                eidParametre.Value = Tentities.EmployeeID;
                sqliteobj.Command.Parameters.Add(eidParametre);

                DbParameter nameParametre = sqliteobj.Command.CreateParameter();
                nameParametre.ParameterName = "@name";
                nameParametre.Value = Tentities.UserName;
                sqliteobj.Command.Parameters.Add(nameParametre);

                DbParameter passParametre = sqliteobj.Command.CreateParameter();
                passParametre.ParameterName = "@pass";
                passParametre.Value = Tentities.Password;
                sqliteobj.Command.Parameters.Add(passParametre);

                DbParameter acParametre = sqliteobj.Command.CreateParameter();
                acParametre.ParameterName = "@ac";
                acParametre.Value = Tentities.Activated;
                sqliteobj.Command.Parameters.Add(acParametre);

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

        public List<Employees_Account> GetAllEntities()
        {
            List<Employees_Account> returnedList = new List<Employees_Account>();
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
                            Employees_Account employeeAccount = new Employees_Account();
                            employeeAccount.ID = Reader.GetInt32(0);
                            employeeAccount.EmployeeID = new Employees { ID = Reader.GetInt32(1) };
                            employeeAccount.UserName = Reader.GetString(2);
                            employeeAccount.Password = Reader.GetString(3);
                            employeeAccount.Activated = Reader.GetInt32(4);
                            returnedList.Add(employeeAccount);
                        }
                    }
                    Reader.Close();
                }
                sqliteobj.Connection.Close();
            });
            return returnedList;
        }

        public Employees_Account getEntitie(string data)
        {
            Employees_Account returnData = new Employees_Account();
            TSS.Tools.TryManager.Run(() =>
            {
                connection();
                sqliteobj.Command.CommandText = "SELECT * FROM " + dataBaseTableName + " WHERE ID LIKE @aranan OR UserName LIKE @aranan OR Password LIKE @aranan";
                sqliteobj.Command.Connection = sqliteobj.Connection;
                using (var Reader = sqliteobj.Command.ExecuteReader())
                {
                    if (Reader.HasRows)
                    {
                        while (Reader.Read())
                        {
                            Employees_Account employeeAccount = new Employees_Account();
                            employeeAccount.ID = Reader.GetInt32(0);
                            employeeAccount.EmployeeID = new Employees { ID = Reader.GetInt32(1) };

                            employeeAccount.UserName = Reader.GetString(2);
                            employeeAccount.Password = Reader.GetString(3);
                            employeeAccount.Activated = Reader.GetInt32(4);

                            returnData = employeeAccount;
                        }
                    }
                    Reader.Close();
                }
                sqliteobj.Connection.Close();
            });
            return returnData;
        }

        public Employees_Account getEntitie(int id)
        {
            Employees_Account returnData = new Employees_Account();
            TSS.Tools.TryManager.Run(() =>
            {
                connection();
                sqliteobj.Command.CommandText = "SELECT * FROM " + dataBaseTableName + " WHERE ID=@id";

                DbParameter idParametre = sqliteobj.Command.CreateParameter();
                idParametre.ParameterName = "@id";
                idParametre.Value = id;
                sqliteobj.Command.Parameters.Add(idParametre);

                sqliteobj.Command.Connection = sqliteobj.Connection;
                using (var Reader = sqliteobj.Command.ExecuteReader())
                {
                    if (Reader.HasRows)
                    {
                        while (Reader.Read())
                        {
                            Employees_Account employeeAccount = new Employees_Account();
                            employeeAccount.ID = Reader.GetInt32(0);
                            employeeAccount.EmployeeID = new Employees { ID = Reader.GetInt32(1) };

                            employeeAccount.UserName = Reader.GetString(2);
                            employeeAccount.Password = Reader.GetString(3);
                            employeeAccount.Activated = Reader.GetInt32(4);

                            returnData = employeeAccount;
                        }
                    }
                    Reader.Close();
                }
                sqliteobj.Connection.Close();
            });
            return returnData;
        }

        public List<Employees_Account> getEntities(string data)
        {
            List<Employees_Account> returnData = new List<Employees_Account>();
            TSS.Tools.TryManager.Run(() =>
            {
                connection();
                sqliteobj.Command.CommandText = "SELECT * FROM " + dataBaseTableName + " WHERE ID LIKE @aranan OR UserName LIKE @aranan OR Password LIKE @aranan";

                DbParameter idParametre = sqliteobj.Command.CreateParameter();
                idParametre.ParameterName = "@aranan";
                idParametre.Value = '%' + data + '%';
                sqliteobj.Command.Parameters.Add(idParametre);

                sqliteobj.Command.Connection = sqliteobj.Connection;
                using (var Reader = sqliteobj.Command.ExecuteReader())
                {
                    if (Reader.HasRows)
                    {
                        while (Reader.Read())
                        {
                            Employees_Account employeeAccount = new Employees_Account();
                            employeeAccount.ID = Reader.GetInt32(0);
                            employeeAccount.EmployeeID = new Employees { ID = Reader.GetInt32(1) };

                            employeeAccount.UserName = Reader.GetString(2);
                            employeeAccount.Password = Reader.GetString(3);
                            employeeAccount.Activated = Reader.GetInt32(4);

                            returnData.Add(employeeAccount);
                        }
                    }
                    Reader.Close();
                }
                sqliteobj.Connection.Close();
            });
            return returnData;
        }

        public void UpdateEntities(int id, Employees_Account TEntities)
        {
            TSS.Tools.TryManager.Run(() =>
            {
                connection();
                sqliteobj.Command.CommandText = "UPDATE " + dataBaseTableName + " SET EmployeeID=@eid,UserName=@name,Password=@pass,Activation=@act WHERE ID=@id; ";
                sqliteobj.Command.Connection = sqliteobj.Connection;

                DbParameter idParametre = sqliteobj.Command.CreateParameter();
                idParametre.ParameterName = "@id";
                idParametre.Value = id;
                sqliteobj.Command.Parameters.Add(idParametre);

                DbParameter eidParametre = sqliteobj.Command.CreateParameter();
                eidParametre.ParameterName = "@eid";
                eidParametre.Value = TEntities.EmployeeID.ID;
                sqliteobj.Command.Parameters.Add(eidParametre);

                DbParameter nameParametre = sqliteobj.Command.CreateParameter();
                nameParametre.ParameterName = "@name";
                nameParametre.Value = TEntities.UserName;
                sqliteobj.Command.Parameters.Add(nameParametre);

                DbParameter passParametre = sqliteobj.Command.CreateParameter();
                passParametre.ParameterName = "@pass";
                passParametre.Value = TEntities.Password;
                sqliteobj.Command.Parameters.Add(passParametre);

                DbParameter activatedParametre = sqliteobj.Command.CreateParameter();
                activatedParametre.ParameterName = "@act";
                activatedParametre.Value = TEntities.Activated;
                sqliteobj.Command.Parameters.Add(activatedParametre);

                sqliteobj.Command.ExecuteNonQuery();
                sqliteobj.Connection.Close();
            });

        }

        public bool Login(string Name, string Password)
        {
            return false;
        }
    }
}
