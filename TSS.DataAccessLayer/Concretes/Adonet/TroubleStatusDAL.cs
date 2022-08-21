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
    public class TroubleStatusDAL : Abstracts.ITroubleStatusServices
    {
        string tableName = "Arıza Statü", dataBaseTableName = "Troubles_Status";

        TSS.DataLayer.Concretes.AdonetManagerObj.SQLiteObj sqliteobj = new TSS.DataLayer.Concretes.AdonetManagerObj.SQLiteObj();

        public TroubleStatusDAL()
        {

        }

        public void connection()
        {
            if (sqliteobj.Connection.State == System.Data.ConnectionState.Closed)
            {
                sqliteobj.Connection.Open();
            }
        }

        public void AddEntities(Troubles_Status Tentities)
        {
            TSS.Tools.TryManager.Run(() =>
            {
                connection();
                string mySelectQuery = "insert into "+dataBaseTableName+"(StatusComment,Statu)values(@scom,@stat)";
                sqliteobj.Command.CommandText = mySelectQuery;
                sqliteobj.Command.Connection = sqliteobj.Connection;


                DbParameter scomParametre = sqliteobj.Command.CreateParameter();
                scomParametre.ParameterName = "@scom";
                scomParametre.Value = Tentities.StatusComment ;
                sqliteobj.Command.Parameters.Add(scomParametre);

                DbParameter statParametre = sqliteobj.Command.CreateParameter();
                statParametre.ParameterName = "@stat";
                statParametre.Value = Tentities.Statu;
                sqliteobj.Command.Parameters.Add(statParametre);

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

        public List<Troubles_Status> GetAllEntities()
        {
            List<Troubles_Status> returnedList = new List<Troubles_Status>();
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
                        Troubles_Status troubleStatus = new Troubles_Status();
                        troubleStatus.ID = Reader.GetInt32(0);
                        troubleStatus.StatusComment = Reader.GetString(1);
                        troubleStatus.Statu = Reader.GetInt32(2);
                        returnedList.Add(troubleStatus);
                    }
                }
                Reader.Close();
            });
            return returnedList;
        }

        public Troubles_Status getEntitie(string data)
        {
            Troubles_Status returnData = new Troubles_Status();
            TSS.Tools.TryManager.Run(() =>
            {
                connection();
                sqliteobj.Command.CommandText = "SELECT * FROM " + dataBaseTableName + " WHERE StatusComment LIKE @aranan OR Statu LIKE @aranan";
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
                        Troubles_Status troubleStatus = new Troubles_Status();
                        troubleStatus.ID = Reader.GetInt32(0);
                        troubleStatus.StatusComment = Reader.GetString(1);
                        troubleStatus.Statu = Reader.GetInt32(2);
                        returnData = troubleStatus;
                    }
                }
                sqliteobj.Connection.Close();
                Reader.Close();
            });
            return returnData;
        }

        public Troubles_Status getEntitie(int id)
        {
            Troubles_Status returnData = new Troubles_Status();
            TSS.Tools.TryManager.Run(() =>
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
                        Troubles_Status troubleStatus = new Troubles_Status();
                        troubleStatus.ID = Reader.GetInt32(0);
                        troubleStatus.StatusComment = Reader.GetString(1);
                        troubleStatus.Statu = Reader.GetInt32(2);
                        returnData = troubleStatus;
                    }
                }
                Reader.Close();
            });
            return returnData;
        }

        public List<Troubles_Status> getEntities(string data)
        {
            List<Troubles_Status> returnData = new List<Troubles_Status>();
            TSS.Tools.TryManager.Run(() =>
            {
                connection();
                sqliteobj.Command.CommandText = "SELECT * FROM " + dataBaseTableName + " WHERE StatusComment LIKE @aranan OR Statu LIKE @aranan";
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
                        Troubles_Status troubleStatus = new Troubles_Status();
                        troubleStatus.ID = Reader.GetInt32(0);
                        troubleStatus.StatusComment = Reader.GetString(1);
                        troubleStatus.Statu = Reader.GetInt32(2);
                        returnData.Add(troubleStatus);
                    }
                }
                Reader.Close();
            });
            return returnData;
        }

        public void UpdateEntities(int id, Troubles_Status TEntities)
        {
            TSS.Tools.TryManager.Run(() =>
            {
                connection();
                sqliteobj.Command.CommandText = "UPDATE " + dataBaseTableName + " SET StatusComment=@scom,Statu=@stat WHERE ID=@id; ";
                sqliteobj.Command.Connection = sqliteobj.Connection;

                DbParameter idParametre = sqliteobj.Command.CreateParameter();
                idParametre.ParameterName = "@id";
                idParametre.Value = id;
                sqliteobj.Command.Parameters.Add(idParametre);

                DbParameter scomParametre = sqliteobj.Command.CreateParameter();
                scomParametre.ParameterName = "@scom";
                scomParametre.Value = TEntities.StatusComment;
                sqliteobj.Command.Parameters.Add(scomParametre);

                DbParameter statParametre = sqliteobj.Command.CreateParameter();
                statParametre.ParameterName = "@stat";
                statParametre.Value = TEntities.Statu;
                sqliteobj.Command.Parameters.Add(statParametre);

                sqliteobj.Command.ExecuteNonQuery();
                sqliteobj.Connection.Close();
            });
        }
    }
}
