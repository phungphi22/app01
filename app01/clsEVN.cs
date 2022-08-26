using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app01
{

    //============ abstract =============
    abstract class clsEVN
    {
        

        //1.Implement by more then one bank class
        public abstract List<clsPaidCustomer> excel_process_by_bank(string sBankName, string sPath);


        //2.Luu data from excel to db (have body)
        public bool fcnUpdateData(clsPaidCustomer objPaidCustomer)
        {
            try
            {
              //Update to database
                return true;
            }
            catch
            { return false; }
            finally
            { //clear resource such as: close connection }
            }
        }

        //3.Validate (have body)
        public string fcnValidateData(string MaKH, Int32 So_tien, Int32 iMonth, Int32 iYear)
        {
            try
            {
                app01.store.storeSoapClient obj = new store.storeSoapClient();

                Int32 irerult = obj.OKToPay(MaKH, So_tien, iMonth,iYear);
                if (irerult < 0)
                { return "Chưa đủ tiền thanh toán"; }

                string resultlenght = obj.InValid(MaKH);
                if (resultlenght.Length > 1)
                { return "resultlenght"; }

                return "";
            }
            catch
            { return ""; }
            finally
            { //clear resource such as: close connection }
            }
        }
    }

    //============ Derived =============
    class clsVCB : clsEVN
    {
        //Long NT edit: mã ngân hàng vcb
         public string MaKH { get; set; }
         
         
        public override List<clsPaidCustomer> excel_process_by_bank(string sBankName, string sPath)
        {
            //1. edit on local Dungnt branch
            clsPaidCustomer objCustomer_xls = new clsPaidCustomer();
            objCustomer_xls.MaKH = "PD12000025378";
            objCustomer_xls.TienDaNop = 111111;
            objCustomer_xls.iMonth = 9;

            List<clsPaidCustomer> lst = new List<clsPaidCustomer>();
            lst.Add(objCustomer_xls);

            return lst;

        }
    }

    class clsACB : clsEVN
    {
        public override List<clsPaidCustomer> excel_process_by_bank(string sBankName, string sPath)
        {
            //1. edit on local Dungnt branch
            clsPaidCustomer objCustomer_xls = new clsPaidCustomer();
            objCustomer_xls.MaKH = "PD12000025333";
            objCustomer_xls.TienDaNop = 150000;
            objCustomer_xls.iMonth = 9;

            List<clsPaidCustomer> lst = new List<clsPaidCustomer>();
            lst.Add(objCustomer_xls);

            return lst;
        }
    }

    //============ Object =============
    class clsPaidCustomer
    {
        public string MaKH { get; set; }
        public Int32 TienDaNop { get; set; }
        public Int32 iMonth { get; set; }
    }
}
