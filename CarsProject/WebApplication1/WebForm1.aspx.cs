using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary1;
namespace WebApplication1
{ 
    public partial class WebForm1 : System.Web.UI.Page
    {
        CarRepository cr = new CarRepository();
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                ddlOperations1.DataSource =cr.GetAllCarBrand();
                //ddlOperations1.DataTextField = "value";
                //ddlOperations1.DataValueField = "key";
                ddlOperations1.DataBind();
            }
        }

        protected void ddlOperations1_TextChanged(object sender, EventArgs e)
        {
            ddlOperations2.DataSource = cr.GetAllModel(ddlOperations1.SelectedItem.Text.ToString());
            ddlOperations2.DataTextField = "key";
            ddlOperations2.DataValueField = "value";
            ddlOperations2.DataBind();
        }

        protected void btnbill_Click(object sender, EventArgs e)
        {
            decimal price = cr.GetTotal(ddlOperations2.SelectedItem.Text.ToString(), Convert.ToInt32(txtQty.Text));
            txtTotal.Text = price.ToString();
        }

        protected void ddlOperations2_SelectedIndexChanged(object sender, EventArgs e)
        {

            txtPrice.Text = ddlOperations2.SelectedValue.ToString();
          
        }

      
    }
}