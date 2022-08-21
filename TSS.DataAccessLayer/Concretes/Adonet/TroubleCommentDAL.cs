using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using TSS.DataLayer.Abstracts;
using System.Windows.Forms;
using System.Data.Common;
using TSS.Entities.Concretes;

namespace TSS.DataLayer.Concretes.Adonet
{
    public class TroubleCommentDAL : ITroubleCommentServices
    {
        private readonly string tableName = "Arıza Yorum";
        private string dataBaseTableName = "Troubles_Comment";
        TSS.DataLayer.Concretes.AdonetManagerObj.SQLiteObj sqliteobj = new TSS.DataLayer.Concretes.AdonetManagerObj.SQLiteObj();

        public TroubleCommentDAL()
        {

        }

        public void connection()
        {
            if (sqliteobj.Connection.State == System.Data.ConnectionState.Closed)
            {
                sqliteobj.Connection.Open();
            }
        }

        public void AddEntities(Troubles_Comment Tentities)
        {
            TSS.Tools.TryManager.Run(() =>
            {
                connection();
                sqliteobj.Command.CommandText = "insert into " + dataBaseTableName + "(TroubleID,CommenterID,Comment,Date)values(@tid,@cid,@com,@dat)";
                sqliteobj.Connection = sqliteobj.Connection;

                DbParameter nameParametre = sqliteobj.Command.CreateParameter();
                nameParametre.ParameterName = "@tid";
                nameParametre.Value = Tentities.TroubleID.ID;
                sqliteobj.Command.Parameters.Add(nameParametre);

                DbParameter CommenterIDParametre = sqliteobj.Command.CreateParameter();
                CommenterIDParametre.ParameterName = "@cid";
                CommenterIDParametre.Value = Tentities.CommenterID.ID;
                sqliteobj.Command.Parameters.Add(CommenterIDParametre);

                DbParameter comParametre = sqliteobj.Command.CreateParameter();
                comParametre.ParameterName = "@com";
                comParametre.Value = Tentities.Comment;
                sqliteobj.Command.Parameters.Add(comParametre);

                DbParameter datParametre = sqliteobj.Command.CreateParameter();
                datParametre.ParameterName = "@dat";
                datParametre.Value = Tentities.Date;
                sqliteobj.Command.Parameters.Add(datParametre);

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

        public List<Troubles_Comment> GetAllEntities()
        {
            List<Troubles_Comment> returnedList = new List<Troubles_Comment>();
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
                            Troubles_Comment troubleComment = new Troubles_Comment();
                            troubleComment.ID = Reader.GetInt32(0);
                            troubleComment.TroubleID = new Troubles() {ID =Reader.GetInt32(1) };
                            troubleComment.CommenterID = new Employees() { ID=Reader.GetInt32(2) };
                            troubleComment.Comment = Reader.GetString(3);
                            troubleComment.Date = DateTime.Parse(Reader.GetString(4));
                            returnedList.Add(troubleComment);
                        }
                    }
                    Reader.Close();
                }
                sqliteobj.Connection.Close();
            });
            return returnedList;
        }

        public Troubles_Comment getEntitie(string data)
        {
            Troubles_Comment returnData = new Troubles_Comment();
            TSS.Tools.TryManager.Run(() =>
            {

                connection();
                sqliteobj.Command.CommandText = "SELECT * FROM " + dataBaseTableName + " WHERE Comment LIKE @aranan";

                DbParameter arananParametre = sqliteobj.Command.CreateParameter();
                arananParametre.ParameterName = "@aranan";
                arananParametre.Value = '%' + data + '%';
                sqliteobj.Command.Parameters.Add(arananParametre);

                sqliteobj.Command.Connection = sqliteobj.Connection;
                using (var Reader = sqliteobj.Command.ExecuteReader())
                {
                    if (Reader.HasRows)
                    {
                        while (Reader.Read())
                        {
                            Troubles_Comment troubleComment = new Troubles_Comment();
                            troubleComment.ID = Reader.GetInt32(0);
                            troubleComment.TroubleID = new Troubles() { ID = Reader.GetInt32(1) };
                            troubleComment.CommenterID = new Employees() { ID = Reader.GetInt32(2) };
                            troubleComment.Comment = Reader.GetString(3);
                            troubleComment.Date = DateTime.Parse(Reader.GetString(4));
                            returnData = troubleComment;
                        }
                    }
                    Reader.Close();
                }
                sqliteobj.Connection.Close();
            });
            return returnData;
        }

        public Troubles_Comment getEntitie(int id)
        {

            Troubles_Comment returnData = new Troubles_Comment();
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
                            Troubles_Comment troubleComment = new Troubles_Comment();
                            troubleComment.ID = Reader.GetInt32(0);
                            troubleComment.TroubleID = new Troubles() { ID = Reader.GetInt32(1) };
                            troubleComment.CommenterID = new Employees() { ID = Reader.GetInt32(2) };
                            troubleComment.Comment = Reader.GetString(3);
                            troubleComment.Date = DateTime.Parse(Reader.GetString(4));
                            returnData = troubleComment;
                        }
                    }
                    Reader.Close();
                }
                sqliteobj.Connection.Close();
            });
            return returnData;
        }

        public List<Troubles_Comment> getEntities(string data)
        {
            List<Troubles_Comment> returnData = new List<Troubles_Comment>();
            TSS.Tools.TryManager.Run(() =>
            {


                connection();
                sqliteobj.Command.CommandText = "SELECT * FROM " + dataBaseTableName + " WHERE TroubleID=@aranan";

                DbParameter arananParametre = sqliteobj.Command.CreateParameter();
                arananParametre.ParameterName = "@aranan";
                arananParametre.Value = data;
                sqliteobj.Command.Parameters.Add(arananParametre);

                sqliteobj.Command.Connection = sqliteobj.Connection;
                using (var Reader = sqliteobj.Command.ExecuteReader())
                {
                    if (Reader.HasRows)
                    {
                        while (Reader.Read())
                        {
                            Troubles_Comment troubleComment = new Troubles_Comment();
                            troubleComment.ID = Reader.GetInt32(0);
                            troubleComment.TroubleID = new Troubles() { ID = Reader.GetInt32(1) };
                            troubleComment.CommenterID = new Employees() { ID = Reader.GetInt32(2) };
                            troubleComment.Comment = Reader.GetString(3);
                            troubleComment.Date = DateTime.Parse(Reader.GetString(4));
                            returnData.Add(troubleComment);

                        }
                    }
                    Reader.Close();
                }
                sqliteobj.Connection.Close();
            });
            return returnData;
        }

        public void UpdateEntities(int id, Troubles_Comment TEntities)
        {
            TSS.Tools.TryManager.Run(() =>
            {

                connection();
                sqliteobj.Command.CommandText = "UPDATE " + dataBaseTableName + " SET TroubleID=@tid,CommenterID=@cid,Comment=@com,Date=@dat WHERE ID=@id; ";

                DbParameter idParametre = sqliteobj.Command.CreateParameter();
                idParametre.ParameterName = "@id";
                idParametre.Value = id;
                sqliteobj.Command.Parameters.Add(idParametre);

                DbParameter nameParametre = sqliteobj.Command.CreateParameter();
                nameParametre.ParameterName = "@tid";
                nameParametre.Value = TEntities.TroubleID.ID;
                sqliteobj.Command.Parameters.Add(nameParametre);

                DbParameter CommenterIDParametre = sqliteobj.Command.CreateParameter();
                CommenterIDParametre.ParameterName = "@cid";
                CommenterIDParametre.Value = TEntities.CommenterID.ID;
                sqliteobj.Command.Parameters.Add(CommenterIDParametre);

                DbParameter comParametre = sqliteobj.Command.CreateParameter();
                comParametre.ParameterName = "@com";
                comParametre.Value = TEntities.Comment;
                sqliteobj.Command.Parameters.Add(comParametre);

                DbParameter datParametre = sqliteobj.Command.CreateParameter();
                datParametre.ParameterName = "@dat";
                datParametre.Value = TEntities.Date;
                sqliteobj.Command.Parameters.Add(datParametre);

                sqliteobj.Command.ExecuteNonQuery();
                sqliteobj.Connection.Close();
            });
        }
    }
}
