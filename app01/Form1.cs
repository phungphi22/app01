using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           

            string BankNameSeleted = "ACB";//string BankNameSeleted = "VCB";
            string sPath = "C:\bankTransaction.xls";
            clsEVN oEVN=null;

            //this block edited by htkvca
            List<clsPaidCustomer> lst = new List<clsPaidCustomer>();
            if (BankNameSeleted == "ACB")
            { oEVN = new clsVCB(); }
            else if(BankNameSeleted == "ACB")
            { oEVN = new clsACB(); }
            else {oEVN = new clsACB();}

            lst= oEVN.excel_process_by_bank(BankNameSeleted, sPath);
            foreach (clsPaidCustomer objPaidCustomer in lst)
            {
                //1.Validate
                string errorResult = "";
                errorResult = oEVN.fcnValidateData(objPaidCustomer.MaKH, objPaidCustomer.TienDaNop, objPaidCustomer.iMonth, DateTime.Now.Year );

                //2.Update to database
                if (errorResult == "") oEVN.fcnUpdateData(objPaidCustomer);

            }
            
        }
    }
}
