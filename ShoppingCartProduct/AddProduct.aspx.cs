using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AppProps;
using DataAccessLayer;

namespace ShoppingCartProduct
{
    public partial class AddProduct : System.Web.UI.Page
    {
        product p = new product();
        productDAL DAL = new productDAL();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            p.Name = txtName.Text;
            string location = @"C:\Users\Muneeb\source\repos\ShoppingCartProduct\ShoppingCartProduct\Images\";
            string pathstring = System.IO.Path.Combine(location, p.Name +".jpg");
            p.Image = (txtName.Text + ".jpg");
            FileUpload1.SaveAs(pathstring);
            p.Price = Convert.ToInt32(txtPrice.Text);
            p.Description = txtDes.Text;

            if (DAL.InsertProduct(p))
            {
                Response.Write("<script>alert('Added')</script>");
            }
            else
            {
                Response.Write("<script>alert('Error')</script>");
            }
        }
    }
}