using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Page.PreviousPage != null)
        {
            ContentPlaceHolder content = (ContentPlaceHolder)Page.PreviousPage.Form.FindControl("pageContent");
            string name = ((TextBox)content.FindControl("TextBox1")).Text;
            string add = ((TextBox)content.FindControl("TextBox2")).Text;
            string city = ((TextBox)content.FindControl("TextBox3")).Text;
            string state = ((TextBox)content.FindControl("TextBox4")).Text;
            Label1.Text = "Your Details are : <br/>Your Name : " + name + "<br/>Your Add : " + add + "<br/>Your City : " + city + "<br/>Your State : " + state;
        }
        else
            Label1.Text = "Welcome Guest";
    }
}
