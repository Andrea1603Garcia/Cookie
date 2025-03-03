using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Asp_E1_4955454
{
    public partial class Cookie2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ddlCategory.SelectedValue = Request.Cookies["ddlCategory"].Value;
            ddlSupplier.SelectedValue = Request.Cookies["ddlSupplier"].Value;
            txtProduct.Text = Request.Cookies["txtProduct"].Value;
            txtDescripcion.Text = Request.Cookies["txtDescripcion"].Value;
            txtImagen.Text = Request.Cookies["txtImagen"].Value;
            Decimal decprice = Convert.ToDecimal(Request.Cookies["txtprice"].Value);
            txtPrice.Text = decprice.ToString("C");
            txtNumberInStock.Text = Request.Cookies["txtNumberInStock"].Value;
            txtNumberOnOrder.Text = Request.Cookies["txtNumberOnOrder"].Value;
            txtReorderLevel.Text = Request.Cookies["txtReorderLevel"].Value;
            Byte byNumberInStock = Convert.ToByte(Request.Cookies["txtNumberInStock"].Value);
            Byte byNumberOnOrder = Convert.ToByte(Request.Cookies["txtNumberOnOrder"].Value);
            Decimal decValueInStock = decprice * byNumberInStock;
            Decimal decValueOnOrder = decprice * byNumberOnOrder;
            txtValueInStock.Text = decValueInStock.ToString("c");
            txtValueOnOrder.Text = decValueOnOrder.ToString("c");
        }
    }
}