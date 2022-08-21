using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TSS.DataLayer.Abstracts;
using System.Linq.Expressions;
using System.Data.Common;
using TSS.Entities.Concretes;

namespace TSS.DataLayer.Concretes.Adonet
{
    public class ProductDAL : IProductServices
    {

        string tableName = "Ürün", dataBaseTableName = "Products";
        TSS.DataLayer.Concretes.AdonetManagerObj.SQLiteObj sqliteobj = new TSS.DataLayer.Concretes.AdonetManagerObj.SQLiteObj();
        public ProductDAL()
        {

        }

        public void connection()
        {
            if (sqliteobj.Connection.State == System.Data.ConnectionState.Closed)
                sqliteobj.Connection.Open();
        }

        public void AddEntities(Products Tentities)
        {

            TSS.Tools.TryManager.Run(() =>
            {


                connection();
                sqliteobj.Command.CommandText = "INSERT INTO " + dataBaseTableName + "(Name,Brand,Model,HardwareTypeID,CategoryID)VALUES(@name,@brand,@model,@htID,@category)";
                sqliteobj.Command.Connection = sqliteobj.Connection;

                DbParameter nameParametre = sqliteobj.Command.CreateParameter();
                nameParametre.ParameterName = "@name";
                nameParametre.Value = Tentities.Name;
                sqliteobj.Command.Parameters.Add(nameParametre);

                DbParameter brandParametre = sqliteobj.Command.CreateParameter();
                brandParametre.ParameterName = "@brand";
                brandParametre.Value = Tentities.Brand;
                sqliteobj.Command.Parameters.Add(brandParametre);

                DbParameter modelParametre = sqliteobj.Command.CreateParameter();
                modelParametre.ParameterName = "@model";
                modelParametre.Value = Tentities.Model;
                sqliteobj.Command.Parameters.Add(modelParametre);

                DbParameter htIDParametre = sqliteobj.Command.CreateParameter();
                htIDParametre.ParameterName = "@htID";
                htIDParametre.Value = Tentities.HardwareTypeID;
                sqliteobj.Command.Parameters.Add(htIDParametre);

                DbParameter categoryParametre = sqliteobj.Command.CreateParameter();
                categoryParametre.ParameterName = "@category";
                categoryParametre.Value = Tentities.CategoryID;
                sqliteobj.Command.Parameters.Add(categoryParametre);

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

        public List<Products> GetAllEntities()
        {
            List<Products> returnedList = new List<Products>();
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
                            Products product = new Products();
                            product.ID = Reader.GetInt32(0);
                            product.Name = Reader.GetString(1);
                            product.Brand = Reader.GetString(2);
                            product.Model = Reader.GetString(3);
                            product.HardwareTypeID = new Hardwares_Type() { ID = Reader.GetInt32(4) };
                            product.CategoryID = new Products_Category() { ID = Reader.GetInt32(5) };
                            returnedList.Add(product);
                        }
                    }
                    Reader.Close();
                }
                sqliteobj.Connection.Close();
            });
            return returnedList;
        }

        public Products getEntitie(string id)
        {
            Products returnData = new Products();
            TSS.Tools.TryManager.Run(() =>
            {
                connection();
                sqliteobj.Command.CommandText = "SELECT * FROM " + dataBaseTableName + " WHERE Name LIKE @aranan";

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
                            Products product = new Products();
                            product.ID = Reader.GetInt32(0);
                            product.Name = Reader.GetString(1);
                            product.Brand = Reader.GetString(2);
                            product.Model = Reader.GetString(3);
                            product.HardwareTypeID = new Hardwares_Type() { ID = Reader.GetInt32(4) };
                            product.CategoryID = new Products_Category() { ID = Reader.GetInt32(5) };
                            returnData = product;
                        }
                    }
                    Reader.Close();
                }
                sqliteobj.Connection.Close();
            });
            return returnData;
        }

        public Products getEntitie(int id)
        {
            Products returnData = new Products();
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
                            Products product = new Products();
                            product.ID = Reader.GetInt32(0);
                            product.Name = Reader.GetString(1);
                            product.Brand = Reader.GetString(2);
                            product.Model = Reader.GetString(3);
                            product.HardwareTypeID = new Hardwares_Type() { ID = Reader.GetInt32(4) };
                            product.CategoryID = new Products_Category() { ID = Reader.GetInt32(5) };
                            returnData = product;
                        }
                    }
                    Reader.Close();
                }
                sqliteobj.Connection.Close();
            });
            return returnData;
        }

        public List<Products> getEntities(string id)
        {
            List<Products> returnData = new List<Products>();
            TSS.Tools.TryManager.Run(() =>
            {

                connection();
                sqliteobj.Command.CommandText = "SELECT * FROM " + dataBaseTableName + " WHERE Name LIKE @aranan OR Model LIKE @aranan OR Brand LIKE @aranan";
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
                            Products product = new Products();
                            product.ID = Reader.GetInt32(0);
                            product.Name = Reader.GetString(1);
                            product.Brand = Reader.GetString(2);
                            product.Model = Reader.GetString(3);
                            product.HardwareTypeID = new Hardwares_Type() { ID = Reader.GetInt32(4) };
                            product.CategoryID = new Products_Category() { ID = Reader.GetInt32(5) };
                            returnData.Add(product);
                        }
                    }
                    Reader.Close();
                }
                sqliteobj.Connection.Close();
            });
            return returnData;
        }

        public void UpdateEntities(int id, Products TEntities)
        {
            TSS.Tools.TryManager.Run(() =>
            {
                connection();
                sqliteobj.Command.CommandText = "UPDATE " + dataBaseTableName + " SET Name=@name,Brand=@brand,Model=@model,HardwareTypeID=@htID,CategoryID=@category WHERE ID=@id";
                sqliteobj.Command.Connection = sqliteobj.Connection;

                DbParameter idParametre = sqliteobj.Command.CreateParameter();
                idParametre.ParameterName = "@id";
                idParametre.Value = id;
                sqliteobj.Command.Parameters.Add(idParametre);

                DbParameter nameParametre = sqliteobj.Command.CreateParameter();
                nameParametre.ParameterName = "@name";
                nameParametre.Value = TEntities.Name;
                sqliteobj.Command.Parameters.Add(nameParametre);

                DbParameter brandParametre = sqliteobj.Command.CreateParameter();
                brandParametre.ParameterName = "@brand";
                brandParametre.Value = TEntities.Brand;
                sqliteobj.Command.Parameters.Add(brandParametre);

                DbParameter modelParametre = sqliteobj.Command.CreateParameter();
                modelParametre.ParameterName = "@model";
                modelParametre.Value = TEntities.Model;
                sqliteobj.Command.Parameters.Add(modelParametre);

                DbParameter htIDParametre = sqliteobj.Command.CreateParameter();
                htIDParametre.ParameterName = "@htID";
                htIDParametre.Value = TEntities.HardwareTypeID.ID;
                sqliteobj.Command.Parameters.Add(htIDParametre);

                DbParameter categoryParametre = sqliteobj.Command.CreateParameter();
                categoryParametre.ParameterName = "@category";
                categoryParametre.Value = TEntities.CategoryID.ID;
                sqliteobj.Command.Parameters.Add(categoryParametre);

                sqliteobj.Command.ExecuteNonQuery();
                sqliteobj.Connection.Close();
            });
        }

        public List<Products> notSaleProduct()
        {
            List<Products> returnedList = new List<Products>();
            TSS.Tools.TryManager.Run(() =>
            {
                connection();
                sqliteobj.Command.CommandText = "SELECT Product.* FROM Product LEFT JOIN ProductPrice ON ProductPrice.ProductID = Product.ID WHERE  ProductPrice.ProductID IS NULL";
                sqliteobj.Command.Connection = sqliteobj.Connection;

                using (var Reader = sqliteobj.Command.ExecuteReader())
                {
                    if (Reader.HasRows)
                    {
                        while (Reader.Read())
                        {
                            Products product = new Products();
                            product.ID = Reader.GetInt32(0);
                            product.Name = Reader.GetString(1);
                            product.Brand = Reader.GetString(2);
                            product.Model = Reader.GetString(3);
                            product.HardwareTypeID = new Hardwares_Type() { ID = Reader.GetInt32(4) };
                            product.CategoryID = new Products_Category() { ID = Reader.GetInt32(5) };
                            returnedList.Add(product);
                        }
                    }
                    Reader.Close();
                }
                sqliteobj.Connection.Close();
            });
            return returnedList;
        }
    }
}
