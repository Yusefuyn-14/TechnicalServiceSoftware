using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TSS.Tools
{
    public static class TryManager
    {
        public static void Run(Action action) {
            try
            {
                action.Invoke();
            }
            catch (System.Data.SQLite.SQLiteException ex)
            {
                MessageBox.Show(ex.ToString(), "Hata ;((", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (System.InvalidCastException) {
                MessageBox.Show("Veri bağlamada bağıntısal sorun veri tabanındaki verileri veya aktarılan objeyi kontrol ediniz.\nTeknik servise veya yazılım desteğine durumu bildiriniz.", "Hata ;((", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            //action.Invoke();
        }
    }
}
