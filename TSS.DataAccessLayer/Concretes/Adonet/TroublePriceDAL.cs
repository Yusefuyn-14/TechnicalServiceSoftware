using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.Common;
using TSS.Entities.Concretes;
using TSS.DataLayer.Abstracts;

namespace TSS.DataLayer.Concretes.Adonet
{
    public class TroublePriceDAL : ITroublePriceServices
    {
        string tableName = "Arıza Fiyatlandırılması", dataBaseTableName = "Troubles_Price";
        TSS.DataLayer.Concretes.AdonetManagerObj.SQLiteObj sqliteobj = new TSS.DataLayer.Concretes.AdonetManagerObj.SQLiteObj();

        public TroublePriceDAL()
        {
        }
        public void connection()
        {
            if (sqliteobj.Connection.State == System.Data.ConnectionState.Closed)
                sqliteobj.Connection.Open();
        }
        public void AddEntities(Troubles_Price Tentities)
        {
            TSS.Tools.TryManager.Run(() =>
            {
                connection();
                sqliteobj.Command.CommandText = "INSERT INTO " + dataBaseTableName + "(TroubleID,ProductPriceID,Date)VALUES(@tid,@pid,@date)";
                sqliteobj.Command.Connection = sqliteobj.Connection;

                DbParameter tidParametre = sqliteobj.Command.CreateParameter();
                tidParametre.ParameterName = "@tid";
                tidParametre.Value = Tentities.TroubleID.ID;
                sqliteobj.Command.Parameters.Add(tidParametre);

                DbParameter pidParametre = sqliteobj.Command.CreateParameter();
                pidParametre.ParameterName = "@pid";
                pidParametre.Value = Tentities.Product_PriceID.ProductID.ID;
                sqliteobj.Command.Parameters.Add(pidParametre);

                DbParameter dateParametre = sqliteobj.Command.CreateParameter();
                dateParametre.ParameterName = "@date";
                dateParametre.Value = DateTime.Now.ToString();
                sqliteobj.Command.Parameters.Add(dateParametre);

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

        public List<Troubles_Price> GetAllEntities()
        {
            List<Troubles_Price> returnedList = new List<Troubles_Price>();
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
                            Troubles_Price trouble = new Troubles_Price();
                            trouble.ID = Reader.GetInt32(0);
                            trouble.TroubleID = new Troubles() { ID = Reader.GetInt32(1) };
                            trouble.Product_PriceID = new Products_Price() { ID = Reader.GetInt32(2) };
                            trouble.Date = DateTime.Parse(Reader.GetString(3));
                            returnedList.Add(trouble);
                        }
                    }
                    Reader.Close();
                }
                sqliteobj.Connection.Close();
            }));
            return returnedList;
        }

        public Troubles_Price getEntitie(string id)
        {
            Troubles_Price returnData = new Troubles_Price();
            TSS.Tools.TryManager.Run((() =>
            {

                connection();
                sqliteobj.Command.CommandText = "SELECT * FROM " + dataBaseTableName + " WHERE Description LIKE @aranan";
                sqliteobj.Command.Connection = sqliteobj.Connection;

                DbParameter parametre = sqliteobj.Command.CreateParameter();
                parametre.ParameterName = "@aranan";
                parametre.Value = '%' + id + '%';
                sqliteobj.Command.Parameters.Add(parametre);

                DbDataReader Reader = sqliteobj.Command.ExecuteReader();


                if (Reader.HasRows)
                {
                    while (Reader.Read())
                    {
                        Troubles_Price trouble = new Troubles_Price();
                        trouble.ID = Reader.GetInt32(0);
                        trouble.TroubleID = new Troubles() { ID = Reader.GetInt32(1) };
                        trouble.Product_PriceID = new Products_Price() { ID = Reader.GetInt32(2) };
                        trouble.Date = DateTime.Parse(Reader.GetString(3));
                        returnData = trouble;
                    }
                }
                sqliteobj.Connection.Close();
                Reader.Close();
            }));
            return returnData;
        }

        public void UpdateEntities(int id, Troubles_Price TEntities)
        {
            TSS.Tools.TryManager.Run(() =>
            {
                connection();
                sqliteobj.Command.CommandText = "UPDATE " + dataBaseTableName + " SET TroubleID=@tid,ProductID=@pid,Date=@date WHERE ID=@id";
                sqliteobj.Command.Connection = sqliteobj.Connection;

                DbParameter tidParametre = sqliteobj.Command.CreateParameter();
                tidParametre.ParameterName = "@tid";
                tidParametre.Value = TEntities.TroubleID.ID;
                sqliteobj.Command.Parameters.Add(tidParametre);

                DbParameter pidParametre = sqliteobj.Command.CreateParameter();
                pidParametre.ParameterName = "@pid";
                pidParametre.Value = TEntities.Product_PriceID.ProductID;
                sqliteobj.Command.Parameters.Add(pidParametre);

                DbParameter dateParametre = sqliteobj.Command.CreateParameter();
                dateParametre.ParameterName = "@date";
                dateParametre.Value = DateTime.Now.ToString();
                sqliteobj.Command.Parameters.Add(dateParametre);

                sqliteobj.Command.ExecuteNonQuery();
                sqliteobj.Connection.Close();
            });
        }
        public List<Troubles_Price> getEntities(string id) {
            List<Troubles_Price> returnData = new List<Troubles_Price>();
            TSS.Tools.TryManager.Run((() =>
            {
                connection();
                sqliteobj.Command.CommandText = "SELECT * FROM " + dataBaseTableName + " WHERE TroubleID=@id";
                sqliteobj.Command.Connection = sqliteobj.Connection;

                DbParameter parametre = sqliteobj.Command.CreateParameter();
                parametre.ParameterName = "@id";
                parametre.Value =id;
                sqliteobj.Command.Parameters.Add(parametre);

                DbDataReader Reader = sqliteobj.Command.ExecuteReader();

                if (Reader.HasRows)
                {
                    while (Reader.Read())
                    {
                        Troubles_Price trouble = new Troubles_Price();
                        trouble.ID = Reader.GetInt32(0);
                        trouble.TroubleID = new Troubles() { ID = Reader.GetInt32(1) };
                        trouble.Product_PriceID = new Products_Price() { ID = Reader.GetInt32(2) };
                        trouble.Date = DateTime.Parse(Reader.GetString(3));
                        returnData.Add(trouble);
                    }
                }
                sqliteobj.Connection.Close();
                Reader.Close();
            }));

            return returnData;
        }

        public Troubles_Price getEntitie(int id)
        {
            Troubles_Price returnData = new Troubles_Price();
            TSS.Tools.TryManager.Run(() =>
            {


                connection();
                sqliteobj.Command.CommandText = "SELECT * FROM " + dataBaseTableName + " WHERE TroubleID=@id";
                sqliteobj.Command.Connection = sqliteobj.Connection;

                DbParameter parametre = sqliteobj.Command.CreateParameter();
                parametre.ParameterName = "@id";
                parametre.Value = id;

                sqliteobj.Command.Parameters.Add(parametre);
                DbDataReader Reader = sqliteobj.Command.ExecuteReader();

                if (Reader.HasRows)
                {
                    while (Reader.Read())
                    {
                        Troubles_Price trouble = new Troubles_Price();
                        trouble.ID = Reader.GetInt32(0);
                        trouble.TroubleID = new Troubles() { ID = Reader.GetInt32(1) };
                        trouble.Product_PriceID = new Products_Price() { ID = Reader.GetInt32(2) };
                        trouble.Date = DateTime.Parse(Reader.GetString(3));
                        returnData = trouble;
                    }
                }
                sqliteobj.Connection.Close();
                Reader.Close();
            });
            return returnData;
        }

        public DataTable JoinTroubleProductTable(int troubleID)
        {
            connection();
            sqliteobj.Command.CommandText = "SELECT Troubles_Price.ID,Products.Name,Products_Price.SalePrice,Troubles_Price.Date FROM Troubles_Price LEFT JOIN Products ON Troubles_Price.ProductPriceID = Products.ID LEFT JOIN Products_Price ON Products.ID=Products_Price.ProductID WHERE TroubleID=@id";
            sqliteobj.Command.Connection = sqliteobj.Connection;

            DbParameter parametre = sqliteobj.Command.CreateParameter();
            parametre.ParameterName = "@id";
            parametre.Value = troubleID;
            sqliteobj.Command.Parameters.Add(parametre);

            DbDataReader Reader = sqliteobj.Command.ExecuteReader();

            DataTable dataTable = new DataTable();
            dataTable.Load(Reader);

            sqliteobj.Connection.Close();
            Reader.Close();
            return dataTable;
        }
    }
}
