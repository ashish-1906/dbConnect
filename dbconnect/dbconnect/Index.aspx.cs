using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Web.UI.HtmlControls;
namespace dbconnect
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(@"Data Source=192.168.0.61\newsql;Initial Catalog=AIETraining;User ID=AIETrainingAccount;Password=Training@1234");
            SqlCommand cmd = new SqlCommand("select * from EmployeeDetails order by Name asc", cn); 
            DataTable dt = new DataTable();
            dt.Columns.AddRange(new DataColumn[4] { new DataColumn("Name", typeof(string)),
                                                   new DataColumn("Email", typeof(string)),
                                                   new DataColumn("Salary",typeof(int)) ,
                                                    new DataColumn("Department", typeof(string))
            });
            cn.Open();
            using (cmd)
            {
                using (SqlDataAdapter sda = new SqlDataAdapter())
                {
                    cmd.Connection = cn;
                    sda.SelectCommand = cmd;
                    using (dt)
                    {
                        sda.Fill(dt);
                        GridView1.DataSource = dt;
                        GridView1.DataBind();
                    }
                }
            }
            cn.Close();
        }
        protected void Button_Insert(object sender, EventArgs e)
        {
         SqlConnection cnn1 = new SqlConnection(@"Data Source=192.168.0.61\newsql;Initial Catalog=AIETraining;User ID=AIETrainingAccount;Password=Training@1234");
         cnn1.Open();
         SqlParameter name = new SqlParameter();
         name.ParameterName = "@name";
         name.Value = Page.Request.Form["Name"];
         SqlParameter email = new SqlParameter();
         email.ParameterName = "@email";
         email.Value = Page.Request.Form["Email"];
         SqlParameter salary = new SqlParameter();
         salary.ParameterName = "@salary";
         salary.Value = Page.Request.Form["Salary"];
         SqlParameter department = new SqlParameter();
         department.ParameterName = "@dept";
         department.Value = Page.Request.Form["Department"];
           // Response.Write(a+b+c+d);
           
           SqlCommand cmd1 = new SqlCommand("INSERT INTO EmployeeDetails(Name, Email, Salary, Department)  VALUES (@name,@email,@salary,@dept);", cnn1);
           cmd1.Parameters.Add(name);
           cmd1.Parameters.Add(email);
           cmd1.Parameters.Add(salary);
           cmd1.Parameters.Add(department);
           cmd1.ExecuteNonQuery();
           Page_Load(this,null);
           cnn1.Close();
        }
        protected void Button_Update(object sender, EventArgs e)
        {
            SqlConnection cnn3 = new SqlConnection(@"Data Source=192.168.0.61\newsql;Initial Catalog=AIETraining;User ID=AIETrainingAccount;Password=Training@1234");
            cnn3.Open();
            SqlParameter name = new SqlParameter();
            name.ParameterName = "@name";
            name.Value = Page.Request.Form["Name"];
            SqlParameter email = new SqlParameter();
            email.ParameterName = "@email";
            email.Value = Page.Request.Form["Email"];
            SqlParameter salary = new SqlParameter();
            salary.ParameterName = "@salary";
            salary.Value = Page.Request.Form["Salary"];
            SqlParameter department = new SqlParameter();
            department.ParameterName = "@dept";
            department.Value = Page.Request.Form["Department"];
          //  Response.Write(a + b + c + d);

            SqlCommand cmd1 = new SqlCommand("Update EmployeeDetails set Name=@name, Email=@email, Salary=@salary, Department=@dept where Name=@name ;", cnn3);
            cmd1.Parameters.Add(name);
            cmd1.Parameters.Add(email);
            cmd1.Parameters.Add(salary);
            cmd1.Parameters.Add(department);
            cmd1.ExecuteNonQuery();
            Page_Load(this, null);
            cnn3.Close();
        }
        protected void Button_Delete(object sender, EventArgs e)
        {
            SqlConnection cnn2 = new SqlConnection(@"Data Source=192.168.0.61\newsql;Initial Catalog=AIETraining;User ID=AIETrainingAccount;Password=Training@1234");
            cnn2.Open();
            SqlParameter name = new SqlParameter();
            name.ParameterName = "@name";
            name.Value = Page.Request.Form["Name"];
            
         //   Response.Write(a + b + c + d);
            SqlCommand cmd3 = new SqlCommand("Delete from EmployeeDetails where Name=@name;", cnn2);
            cmd3.Parameters.Add(name);
            cmd3.ExecuteNonQuery();
            Page_Load(this, null);
            cnn2.Close();
        }
    }
}