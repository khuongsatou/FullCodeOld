using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

public partial class SurveyReceipts : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Page.PreviousPage != null)
        {
            HtmlInputText txtName = (HtmlInputText)PreviousPage.FindControl("txtName");
            HtmlInputCheckBox chkMBR = (HtmlInputCheckBox)PreviousPage.FindControl("chkMBR");
            HtmlInputCheckBox chkRR = (HtmlInputCheckBox)PreviousPage.FindControl("chkRR");
            HtmlTextArea txtTrails = (HtmlTextArea)PreviousPage.FindControl("txtTrails");
            Calendar calLast = (Calendar)PreviousPage.FindControl("calLast");
            Calendar calNext = (Calendar)PreviousPage.FindControl("calNext");
            DropDownList ddAbility = (DropDownList)PreviousPage.FindControl("ddAbility");
            ListBox lstExperience = (ListBox)PreviousPage.FindControl("lstExperience");
            CheckBoxList chkGoals = (CheckBoxList)PreviousPage.FindControl("chkGoals");
            RadioButtonList optMarketing = (RadioButtonList)PreviousPage.FindControl("optMarketing");
            HiddenField hdnRegion = (HiddenField)PreviousPage.FindControl("hdnRegion");

            string sName = txtName.Value.ToString();
            string sGender = Request.Form["optGender"];
            bool bMBR = chkMBR.Checked;
            bool bRR = chkRR.Checked;
            string sTrails = txtTrails.Value;
            string sLast = calLast.SelectedDate.ToLongDateString();
            string sNext = calNext.SelectedDate.ToLongDateString();
            string sAbility = ddAbility.SelectedValue.ToString();
            string sExperience = lstExperience.SelectedValue.ToString();
            string sGoals = "";
            foreach (ListItem goal in chkGoals.Items)
            {
                if (goal.Selected)
                {
                    sGoals += goal.Text + "<br />";
                }
            }
            string sMarketing = optMarketing.SelectedValue.ToString();
            string sRegion = hdnRegion.Value;
            Label1.Text = "Your Survey Details:<br />"
                + "Name: " + sName + "<br />"
                + "Gender: " + sGender + "<br />"
                + "Mountain Bike Rider: " + bMBR + "<br />"
                + "Road Rider: " + bRR + "<br />"
                + "Favourite Trails: " + sTrails + "<br />"
                + "Last Ride: " + sLast + "<br />"
                + "Next Ride: " + sNext + "<br />"
                + "Your Ability: " + sAbility + "<br />"
                + "Your Experience: " + sExperience + "<br />"
                + "Your Goals: " + sGoals + "<br />"
                + "Marketing Info: " + sMarketing + "<br />"
                + "Your Region: " + sRegion + "<br />";
        }
        else
        {
            Label1.Text = "Welcome Guest";
        }
    }
}
