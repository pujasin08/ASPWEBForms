using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPWEBForms
{
    public partial class Add : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                loadrecord();
            }
        }
/// <summary>
/// table created EmpInfo with param EmpId,EmpName,Gender

/// </summary>
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-PUJA;Initial Catalog=Demo;User ID=sa;Password=******passwordofserver");
        protected void BtnAdd_Click(object sender, EventArgs e)
        {
            
            con.Open();
            string cmm = "Insert into EmpTbl (EmpName,Gender,Email) values ('" + TxtName.Text + "','" + DpGend.SelectedValue + "','" + TBEmail.Text + "')";
            SqlCommand comm = new SqlCommand(cmm,con);
            comm.ExecuteNonQuery();
            con.Close();
            TxtName.Text = "";
            DpGend.SelectedValue = "Choose";
            TBEmail.Text = "";
            ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Successfully Inserted')", true);
            loadrecord();
        }
        void loadrecord()
        {
            SqlCommand comm = new SqlCommand("Select * from EmpTbl",con);
            SqlDataAdapter d = new SqlDataAdapter(comm);
            DataTable dt = new DataTable();
            d.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Clear();
            Response.Buffer = true;
            Response.ContentType = "application/ms-excel";
            Response.AddHeader("content-disposition", "attachment;filename=EmpInfo.xlsx");
            Response.Charset = "";
            StringWriter sw = new StringWriter();
            HtmlTextWriter htw = new HtmlTextWriter(sw);
            GridView1.RenderControl(htw);
            Response.Output.Write(sw.ToString());
            Response.End();
        }
        public override void VerifyRenderingInServerForm(Control control)
        {
            //base.VerifyRenderingInServerForm(control);
        }
    }
}