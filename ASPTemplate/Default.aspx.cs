using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPTemplate
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void singleSelect_Click(object sender, EventArgs e)
        {

            MSDataAccess da = new MSDataAccess("Data Source=LAPTOP-77CJM0P7;Initial Catalog=AppFactory2020;Persist Security Info=True;User ID=sa;Password='admin'"); ; ;

            da.GetPersonName(1);
        }
    }
}