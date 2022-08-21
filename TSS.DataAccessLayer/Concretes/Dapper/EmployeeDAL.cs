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
    public class EmployeeDAL : IEmployeeServices
    {
        public IDbConnection GetConnection()
        {
            return new SQLiteConnection("datasource=" + Application.StartupPath + "\\DataBase\\TechnicalService.db");
        }
        public void AddEntities(Employees Tentities)
        {
            GetConnection().Execute("INSERT INTO Employees(FirstName,LastName,Address,PhoneNumber,Mail,BirthOfDate,HomeNumber)VALUES(@name,@lname,@address,@number,@mail,@birthofdate,@birthofplace,@homenumber)", Tentities);
        }

        public void DeleteEntities(int id)
        {
            GetConnection().Execute("DELETE FROM Employees WHERE ID=@id", id);
        }

        public List<Employees> GetAllEntities()
        {
            return GetConnection().Query<TSS.Entities.Concretes.Employees>("SELECT * FROM Employees ORDER BY ID ASC").ToList();
        }

        public void UpdateEntities(int id, Employees Tentities)
        {
            GetConnection().Execute("UPDATE Employees SET FirstName=@firstname , LastName=@lastname , Address=@address , PhoneNumber=@PhoneNumber , Mail=@mail , BirthOfDate=@birthofdate , BirthOfPlace=@birthofplace , HomeNumber=@homenumber", Tentities);
        }
    }
}
