using TSS.DataLayer.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Windows.Forms;
using System.Data.Common;
using TSS.Entities.Concretes;

namespace TSS.DataLayer.Concretes.Adonet
{
    public class ProductPriceDAL : IProductPriceService
    {

        string tableName = "Ürün Fiyat", dataBaseTableName = "Products_Price";
        TSS.DataLayer.Concretes.AdonetManagerObj.SQLiteObj sqliteobj = new TSS.DataLayer.Concretes.AdonetManagerObj.SQLiteObj();
        public ProductPriceDAL()
        {

        }
        public void connection()
        {
            if (sqliteobj.Connection.State == System.Data.ConnectionState.Closed)
            {
                sqliteobj.Connection.Open();
            }
        }

        public void AddEntities(Products_Price Tentities)
        {
            TSS.Tools.TryManager.Run(() =>
            {

                connection();
                sqliteobj.Command.CommandText = "INSERT INTO " + dataBaseTableName + "(ProductID,CurrencyID,SalePrice,PurchasePrice)VALUES(@pid,@cid,@sp,@pp)";
                sqliteobj.Command.Connection = sqliteobj.Connection;

                DbParameter pidParametre = sqliteobj.Command.CreateParameter();
                pidParametre.ParameterName = "@pid";
                pidParametre.Value = Tentities.ProductID.ID;
                sqliteobj.Command.Parameters.Add(pidParametre);

                DbParameter cidParametre = sqliteobj.Command.CreateParameter();
                cidParametre.ParameterName = "@cid";
                cidParametre.Value = Tentities.CurrencyID.ID;
                sqliteobj.Command.Parameters.Add(cidParametre);

                DbParameter spParametre = sqliteobj.Command.CreateParameter();
                spParametre.ParameterName = "@sp";
                spParametre.Value = Tentities.SalePrice;
                sqliteobj.Command.Parameters.Add(spParametre);

                DbParameter ppParametre = sqliteobj.Command.CreateParameter();
                ppParametre.ParameterName = "@pp";
                ppParametre.Value = Tentities.PurchasePrice;
                sqliteobj.Command.Parameters.Add(ppParametre);

                sqliteobj.Command.ExecuteNonQuery();
                sqliteobj.Connection.Close();
            });
        }

        public void DeleteEntities(int id)
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
        }

        public List<Products_Price> GetAllEntities()
        {
            List<Products_Price> returnedList = new List<Products_Price>();
            TSS.Tools.TryManager.Run(() =>
            {
                connection();
                sqliteobj.Command.CommandText = "SELECT * FROM " + dataBaseTableName + " ORDER BY ID ASC";
                sqliteobj.Command.Connection = sqliteobj.Connection;
                DbDataReader Reader = sqliteobj.Command.ExecuteReader();

                if (Reader.HasRows)
                {
                    while (Reader.Read())
                    {
                        Products_Price productPrice = new Products_Price();
                        productPrice.ID = Reader.GetInt32(0);
                        productPrice.ProductID = new Products() { ID = Reader.GetInt32(1) };
                        productPrice.CurrencyID = new Currency() { ID = Reader.GetInt32(2) };
                        productPrice.SalePrice = Reader.GetInt32(3);
                        productPrice.PurchasePrice = Reader.GetInt32(4);
                        returnedList.Add(productPrice);
                    }
                }
                Reader.Close();
                sqliteobj.Connection.Close();
            });
            return returnedList;
        }

        public Products_Price getEntitie(string data)
        {
            Products_Price returnData = new Products_Price();
            TSS.Tools.TryManager.Run((() =>
            {

                connection();
                sqliteobj.Command.CommandText = "SELECT * FROM " + dataBaseTableName + " WHERE Name LIKE @aranan";
                sqliteobj.Command.Connection = sqliteobj.Connection;

                DbParameter parametre = sqliteobj.Command.CreateParameter();
                parametre.ParameterName = "@aranan";
                parametre.Value = '%' + data + '%';
                sqliteobj.Command.Parameters.Add(parametre);

                DbDataReader Reader = sqliteobj.Command.ExecuteReader();

                if (Reader.HasRows)
                {
                    while (Reader.Read())
                    {
                        Products_Price productPrice = new Products_Price();
                        productPrice.ID = Reader.GetInt32(0);
                        productPrice.ProductID = new Products() { ID = Reader.GetInt32(1) };
                        productPrice.CurrencyID = new Currency() { ID = Reader.GetInt32(2) };
                        productPrice.SalePrice = Reader.GetInt32(3);
                        productPrice.PurchasePrice = Reader.GetInt32(4);
                        returnData = productPrice;
                    }
                }
                Reader.Close();
                sqliteobj.Connection.Close();
            }));
            return returnData;
        }

        public Products_Price getEntitie(int id)
        {
            Products_Price returnData = new Products_Price();
            TSS.Tools.TryManager.Run((() =>
            {
                connection();
                sqliteobj.Command.CommandText = "SELECT * FROM " + dataBaseTableName + " WHERE ID=@id";
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
                        Products_Price productPrice = new Products_Price();
                        productPrice.ID = Reader.GetInt32(0);
                        productPrice.ProductID = new Products() { ID = Reader.GetInt32(1) };
                        productPrice.CurrencyID = new Currency() { ID = Reader.GetInt32(2) };
                        productPrice.SalePrice = Reader.GetInt32(3);
                        productPrice.PurchasePrice = Reader.GetInt32(4);
                        returnData = productPrice;
                    }
                }
                Reader.Close();
                sqliteobj.Connection.Close();
            }));
            return returnData;
        }

        public List<Products_Price> getEntities(string data)
        {
            List<Products_Price> returnedList = new List<Products_Price>();
            TSS.Tools.TryManager.Run(() =>
            {
                connection();
                sqliteobj.Command.CommandText = "SELECT * FROM " + dataBaseTableName + " ORDER BY id ASC";
                sqliteobj.Command.Connection = sqliteobj.Connection;
                DbDataReader Reader = sqliteobj.Command.ExecuteReader();

                if (Reader.HasRows)
                {
                    while (Reader.Read())
                    {
                        Products_Price productPrice = new Products_Price();
                        productPrice.ID = Reader.GetInt32(0);
                        productPrice.ProductID = new Products() { ID = Reader.GetInt32(1) };
                        productPrice.CurrencyID = new Currency() { ID = Reader.GetInt32(2) };
                        productPrice.SalePrice = Reader.GetInt32(3);
                        productPrice.PurchasePrice = Reader.GetInt32(4);
                        returnedList.Add(productPrice);
                    }
                }
                Reader.Close();
                sqliteobj.Connection.Close();
            });
            return returnedList;
        }

        public void UpdateEntities(int id, Products_Price TEntities)
        {
            TSS.Tools.TryManager.Run(() =>
            {
                connection();
                sqliteobj.Command.CommandText = "UPDATE " + dataBaseTableName + " SET ProductID=@pid,CurrencyID=@cid,SalePrice=@sp,PurchasePrice=@pp WHERE ID=@id";
                sqliteobj.Command.Connection = sqliteobj.Connection;

                DbParameter tidParametre = sqliteobj.Command.CreateParameter();
                tidParametre.ParameterName = "@id";
                tidParametre.Value = id;
                sqliteobj.Command.Parameters.Add(tidParametre);


                DbParameter pidParametre = sqliteobj.Command.CreateParameter();
                pidParametre.ParameterName = "@pid";
                pidParametre.Value = TEntities.ProductID.ID;
                sqliteobj.Command.Parameters.Add(pidParametre);

                DbParameter cidParametre = sqliteobj.Command.CreateParameter();
                cidParametre.ParameterName = "@cid";
                cidParametre.Value = TEntities.CurrencyID.ID;
                sqliteobj.Command.Parameters.Add(cidParametre);

                DbParameter spParametre = sqliteobj.Command.CreateParameter();
                spParametre.ParameterName = "@sp";
                spParametre.Value = TEntities.SalePrice;
                sqliteobj.Command.Parameters.Add(spParametre);

                DbParameter ppParametre = sqliteobj.Command.CreateParameter();
                ppParametre.ParameterName = "@pp";
                ppParametre.Value = TEntities.PurchasePrice;
                sqliteobj.Command.Parameters.Add(ppParametre);

                sqliteobj.Command.ExecuteNonQuery();
                sqliteobj.Connection.Close();
            });
        }
    }
}
