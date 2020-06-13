using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication4
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        private bool validacija(string BrojTxt)
        {
            int BrojInt;
            if (int.TryParse(BrojTxt, out BrojInt)){
                if (BrojInt > 0) return true;
                else return false;
            }
            else return false;
            
        }

        private int proizvodCifara(string BrojTxt){
            int suma = 1;
            foreach (var item in BrojTxt)
            {
                suma *= int.Parse(item.ToString());
             }

            return suma;
        }

        protected void btn_Submit_Click(object sender, EventArgs e)
        {
            try
            {
                if (validacija(txt_Broj.Text))
                {
                    lbl_result.Text = proizvodCifara(txt_Broj.Text).ToString();
                    
                }
                else throw new Exception("Broj nije validan!");
            }
            catch (Exception ex)
            {
                txt_Broj.CssClass += " bg-warning";
                Response.Write("<script>alert('" + ex.Message + "')</script>");

            }



        }
    }
}