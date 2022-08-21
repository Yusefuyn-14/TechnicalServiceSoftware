using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TSS.DataLayer.Concretes.AdonetManagerObj
{
    public class SQLiteObj
    {
        static public string MyConnectionString = "datasource=" + Application.StartupPath + "\\DataBase\\TechnicalService.db";
        public DbConnection Connection = new System.Data.SQLite.SQLiteConnection(MyConnectionString);
        public DbCommand Command = new System.Data.SQLite.SQLiteCommand();
        public DbDataAdapter Adaptor = new System.Data.SQLite.SQLiteDataAdapter();
    }
}
