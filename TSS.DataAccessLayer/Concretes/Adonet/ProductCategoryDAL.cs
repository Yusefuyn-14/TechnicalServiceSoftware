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
    public class ProductCategoryDAL : IProductCategoryServices
    {
        string dbName = "";
        string tableName = "Ürün Kategori", dataBaseTableName = "Products_Category";
        TSS.DataLayer.Concretes.AdonetManagerObj.SQLiteObj sqliteobj = new TSS.DataLayer.Concretes.AdonetManagerObj.SQLiteObj();
        public ProductCategoryDAL()
        {
     
        }

        public void connection()
        {
            if (sqliteobj.Connection.State == System.Data.ConnectionState.Closed)
                sqliteobj.Connection.Open();
        }

        public void AddEntities(Products_Category Tentities)
        {
            TSS.Tools.TryManager.Run(() =>
            {
                connection();
                sqliteobj.Command.CommandText = "INSERT INTO " + dataBaseTableName + "(Name,Tax)VALUES(@name,@tax)";
                sqliteobj.Command.Connection = sqliteobj.Connection;

                DbParameter nameParametre = sqliteobj.Command.CreateParameter();
                nameParametre.ParameterName = "@name";
                nameParametre.Value = Tentities.Name;
                sqliteobj.Command.Parameters.Add(nameParametre);

                DbParameter taxParametre = sqliteobj.Command.CreateParameter();
                taxParametre.ParameterName = "@tax";
                taxParametre.Value = Tentities.Tax;
                sqliteobj.Command.Parameters.Add(taxParametre);

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

        public List<Products_Category> GetAllEntities()
        {
            List<Products_Category> returnedList = new List<Products_Category>();
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
                            Products_Category category = new Products_Category();
                            category.ID = Reader.GetInt32(0);
                            category.Name = Reader.GetString(1);
                            category.Tax = Reader.GetInt32(2);
                            returnedList.Add(category);
                        }
                    }
                    Reader.Close();
                }
                sqliteobj.Connection.Close();
            });
            return returnedList;
        }

        public Products_Category getEntitie(string id)
        {
            Products_Category returnData = new Products_Category();
            TSS.Tools.TryManager.Run(() =>
            {
                connection();
                sqliteobj.Command.CommandText = "SELECT * FROM " + dataBaseTableName + " WHERE Name LIKE @aranan OR Tax LIKE @aranan";

                DbParameter parametre = sqliteobj.Command.CreateParameter();
                parametre.ParameterName = "@aranan";
                parametre.Value = '%' + id + '%';
                sqliteobj.Command.Parameters.Add(parametre);

                sqliteobj.Command.Connection = sqliteobj.Connection;
                using (var Reader = sqliteobj.Command.ExecuteReader())
                {
                    if (Reader.HasRows)
                    {
                        while (Reader.Read())
                        {
                            Products_Category category = new Products_Category();
                            category.ID = Reader.GetInt32(0);
                            category.Name = Reader.GetString(1);
                            category.Tax = Reader.GetInt32(2);
                            returnData = category;
                        }
                    }
                    Reader.Close();
                }
                sqliteobj.Connection.Close();

            });
            return returnData;
        }

        public void UpdateEntities(int id, Products_Category TEntities)
        {
            TSS.Tools.TryManager.Run(() =>
            {
                connection();
                sqliteobj.Command.CommandText = "UPDATE " + dataBaseTableName + " SET Name=@name,Tax=@tax WHERE ID=@id";
                sqliteobj.Command.Connection = sqliteobj.Connection;

                DbParameter idParametre = sqliteobj.Command.CreateParameter();
                idParametre.ParameterName = "@id";
                idParametre.Value = id;
                sqliteobj.Command.Parameters.Add(idParametre);

                DbParameter nameParametre = sqliteobj.Command.CreateParameter();
                nameParametre.ParameterName = "@name";
                nameParametre.Value = TEntities.Name;
                sqliteobj.Command.Parameters.Add(nameParametre);

                DbParameter taxParametre = sqliteobj.Command.CreateParameter();
                taxParametre.ParameterName = "@tax";
                taxParametre.Value = TEntities.Tax;
                sqliteobj.Command.Parameters.Add(taxParametre);

                sqliteobj.Command.ExecuteNonQuery();
                sqliteobj.Connection.Close();
            });
        }

        public List<Products_Category> getEntities(string data)
        {
            List<Products_Category> returnData = new List<Products_Category>();
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
                            Products_Category productCategory = new Products_Category();
                            productCategory.ID = Reader.GetInt32(0);
                            productCategory.Name = Reader.GetString(1);
                            productCategory.Tax = Reader.GetInt32(2);
                            returnData.Add(productCategory);
                        }
                    }
                    Reader.Close();
                }
                sqliteobj.Connection.Close();
            });
            return returnData;
        }

        public Products_Category getEntitie(int id)
        {
            Products_Category returnData = new Products_Category();
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

                            Products_Category productCategory = new Products_Category();
                            productCategory.ID = Reader.GetInt32(0);
                            productCategory.Name = Reader.GetString(1);
                            productCategory.Tax = Reader.GetInt32(2);
                            returnData = productCategory;
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
