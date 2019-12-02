using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }


    //using System.Web.Services;


    //==== Method to save data into database.
    [WebMethod]
    public static int saveData(string name, string email, string age)
    {
        try
        {
            int status = 0;
            using (JsonDatEntities context = new JsonDatEntities())
            {
                Student obj = new Student();
                obj.Name = name;
                obj.Email = email;
                obj.Age = age;
                context.Students.Add(obj);
                context.SaveChanges();
                status = obj.Id;
            }
            return status;
        }
        catch
        {
            return -1;
        }
    }

    //==== Method to update data.
    [WebMethod]
    public static int updateData(string name, string email, string age, int id)
    {
        try
        {
            int status = 0;
            using (JsonDatEntities context = new JsonDatEntities())
            {
                Student obj = context.Students.FirstOrDefault(r => r.Id == id);
                obj.Name = name;
                obj.Email = email;
                obj.Age = age;
                context.SaveChanges();
                status = obj.Id;
            }
            return status;
        }
        catch
        {
            return -1;
        }
    }


    //==== Method to fetch data from database.
    //using System.Web.Script.Serialization;
    [WebMethod]
    public static string getData()
    {
        string data = string.Empty;
        try
        {
            using (JsonDatEntities context = new JsonDatEntities())
            {
                var obj = (from r in context.Students select r).ToList();

                JavaScriptSerializer serializer = new JavaScriptSerializer();
                data = serializer.Serialize(obj);
            }
            return data;
        }
        catch
        {
            return data;

        }
    }


    //==== Method to Delete a record.
    [WebMethod]
    public static void deleteRecord(int id)
    {
        try
        {
            using (JsonDatEntities context = new JsonDatEntities())
            {
                var obj = context.Students.FirstOrDefault(r => r.Id == id);
                context.Students.Remove(obj);
                context.SaveChanges();
            }
        }
        catch
        {
        }
    }

    //==== Method to get values of selected record and bind in input controls for update.
    [WebMethod]
    public static string bindRecordToEdit(int id)
    {
        string data = string.Empty;
        try
        {

            using (JsonDatEntities context = new JsonDatEntities())
            {
                var obj = context.Students.FirstOrDefault(r => r.Id == id);
                JavaScriptSerializer serializer = new JavaScriptSerializer();
                data = serializer.Serialize(obj);
            }
            return data;
        }
        catch
        {
            return data;
        }
    }
}