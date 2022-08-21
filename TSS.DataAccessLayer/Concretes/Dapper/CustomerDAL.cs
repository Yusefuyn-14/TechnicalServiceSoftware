using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TSS.DataLayer.Abstracts;
using TSS.Entities.Concretes;

namespace TSS.DataLayer.Concretes.Dapper
{
    public class CustomerDAL : ICustomerServices
    {
        public IDbConnection GetConnection()
        {
            return new SQLiteConnection("datasource=" + Application.StartupPath + "\\DataBase\\TechnicalService.db");
        }
        public void AddEntities(Customers Tentities)
        {
            using (IDbConnection connection = GetConnection())
            {
                connection.Execute("INSERT INTO Customers(FirstName,LastName,Address,PhoneNumber,Mail)VALUES(@name,@lname,@address,@number,@mail)", Tentities);
            }
        }

        public void DeleteEntities(int id)
        {
            using (IDbConnection connection = GetConnection())
            {
                connection.Execute("DELETE FROM Customers WHERE ID=@id", id);
            }
        }

        public List<Customers> GetAllEntities()
        {
            using (IDbConnection connection = GetConnection())
            {
                return connection.Query<TSS.Entities.Concretes.Customers>("SELECT * FROM Customers ORDER BY ID ASC").ToList();
            }
        }

        public void UpdateEntities(int id, Customers TEntities)
        {
            using (IDbConnection connection = GetConnection())
            {
                connection.Execute("UPDATE Customer SET FirstName=@name,LastName=@lname,Address=@address,PhoneNumber=@number,Mail=@mail WHERE ID=@id;", TEntities);
            }
        }
    }
}
