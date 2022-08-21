using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TSS.BusinessLayer.Concretes;

namespace TSS.UserInterface
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(TSS.Tools.Theme.FormReDesign(new HomeForm()));
        }




        static public List<TTS_Form> activatedForm = new List<TTS_Form>();
        static public void showForm(TTS_Form form)
        {
            form.windowsForm.Show();
            form.chillForm.Show();
            activatedForm.Add(form);
        }

        static public void closeForm(TTS_Form form)
        {
            activatedForm.Remove(form);
            form.chillForm.Close();
            form.windowsForm.Close();
        }


        static public int EmployeeID = 1;
        static public HardwareDriveDAL hardwareDriveManager = new HardwareDriveDAL(new TSS.DataLayer.Concretes.Dapper.HardwareDriveDAL());
        static public HardwareSizeDAL hardwareSizeManager = new HardwareSizeDAL(new TSS.DataLayer.Concretes.Adonet.HardwareSizeDAL());
        static public EmployeeLoginDAL employeeLoginManager = new EmployeeLoginDAL(new TSS.DataLayer.Concretes.Adonet.EmployeeLoginDAL());
        static public ComponentDAL componentManager = new ComponentDAL(new DataLayer.Concretes.Dapper.ComponentDAL());
        static public ComponentTypeDAL componentTypeManager = new ComponentTypeDAL(new DataLayer.Concretes.Dapper.ComponentTypeDAL());
        static public CurrencyDAL currencyManager = new CurrencyDAL(new DataLayer.Concretes.Adonet.CurrencyDAL());
        static public DeviceDAL deviceManager = new DeviceDAL(new DataLayer.Concretes.Adonet.DevicesDAL());
        static public DevicesHardwareDAL devicesHardwareManager = new DevicesHardwareDAL(new DataLayer.Concretes.Dapper.DevicesHardwareDAL());
        static public ComputerUnitDAL computerUnitManager = new ComputerUnitDAL(new DataLayer.Concretes.Adonet.ComputerUnitDAL());
        static public HardwaresDAL hardwareManager = new HardwaresDAL(new DataLayer.Concretes.Dapper.HardwaresDAL());
        static public MacListDAL macListManager = new MacListDAL(new DataLayer.Concretes.Adonet.MacListDAL());
        static public ProductDAL productManager = new ProductDAL(new DataLayer.Concretes.Adonet.ProductDAL());
        static public HardwareTypeDAL hardwareTypeManager = new HardwareTypeDAL(new DataLayer.Concretes.Adonet.HardwareTypeDAL());
        static public ProductCategoryDAL productCategoryManager = new ProductCategoryDAL(new DataLayer.Concretes.Adonet.ProductCategoryDAL());
        static public EmployeeDAL employeeManager = new EmployeeDAL(new DataLayer.Concretes.Dapper.EmployeeDAL());
        static public CustomerDAL customerManager = new CustomerDAL(new DataLayer.Concretes.Dapper.CustomerDAL());
        static public TroubleDAL troubleManager = new TroubleDAL(new DataLayer.Concretes.Adonet.TroubleDAL());
        static public TroubleStatusDAL troubleStatusManager = new TroubleStatusDAL(new DataLayer.Concretes.Adonet.TroubleStatusDAL());
        static public ProductPriceDAL productPriceManager = new ProductPriceDAL(new DataLayer.Concretes.Adonet.ProductPriceDAL());
        static public TroublePriceDAL troublePriceManager = new TroublePriceDAL(new DataLayer.Concretes.Adonet.TroublePriceDAL());
        static public TroubleCommentDAL troubleCommentManager = new TroubleCommentDAL(new DataLayer.Concretes.Adonet.TroubleCommentDAL());
        static public HardwaresComponentDAL hardwaresComponentManager = new HardwaresComponentDAL(new DataLayer.Concretes.Dapper.HardwaresComponentDAL());
        static public Hasher hasher = new Hasher();
    }

    public class TTS_Form
    {
        public Form windowsForm { get; set; }
        public Form chillForm { get; set; }
    }
}
