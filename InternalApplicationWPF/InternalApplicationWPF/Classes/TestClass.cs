using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternalApplicationWPF.Classes
{
    public class TestClass
    {
        //public static bool AddIAProduct(int IAProdict_ID, string IA_ID, string Product_ID, string IAP_Amount)
        //{
        //    try
        //    {
        //        IAProduct i = new IAProduct();
        //        i. = user_id;
        //        user.Login = login;
        //        user.Password = password;
        //        return true;
        //    }
        //    catch
        //    {

        //    }
        //    return false;

        //}



        public static bool AddProduct(int Product_ID, string Product_Name, string Shelf_Life, string Unit_Id)
        {
            try
            {
                Product prod = new Product();
                prod.Product_ID = Product_ID;
                prod.Product_Name = Product_Name;
                prod.Shelf_Life = Shelf_Life;
                prod.Unit_ID = Convert.ToInt32(Unit_Id);
                return true;
            }
            catch
            {
            }
            return false;
        }

        public static bool AddInternalAplication(int IA_ID, string Date_Start, string Date_End, string Worker_ID, string Status_ID)
        {
            try
            {
                InternalApplication ia = new InternalApplication();
                ia.IA_ID = IA_ID;
                ia.Date_Start = Convert.ToDateTime(Date_Start);
                ia.Date_End = Convert.ToDateTime(Date_End);
                ia.Worker_ID = Convert.ToInt32(Worker_ID);
                ia.Status_ID = Convert.ToInt32(Status_ID);
                return true;
            }
            catch (Exception)
            {
            }
            return false;
        }
    }
}
