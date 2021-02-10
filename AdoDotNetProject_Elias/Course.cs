using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;
using System.Configuration;
using System.IO;

namespace AdoDotNetProject_Elias
{
    public partial class Course : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["DbCon"].ConnectionString;
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataTable dt;

        public void RefreshData()
        {
            using (con = new SqlConnection(cs))
            {
                adapter = new SqlDataAdapter("SELECT * FROM Course", con);
                dt = new DataTable();
                adapter.Fill(dt);
                dgViewCourse.DataSource = dt;
            }
        }

        public void ClearAllData()
        {
            txtCourseName.Text = "";
            txtCourseDuration.Text = "";
            txtCoursePrice.Text = "";
            txtInstractorName.Text = "";

        }

        InsertCourse objCourseInsert = new InsertCourse();
        DeleteCourse objCourseDelete = new DeleteCourse();
        UpdateCourse objCourseUpdate = new UpdateCourse();


        public Course()
        {
            InitializeComponent();
            RefreshData();
        }

        private void lblLogOut_Click(object sender, EventArgs e)
        {
         
            Form1 fl = new Form1();
            this.Hide();
            fl.Show();
        }

        private void Course_Load(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            objCourseInsert.InsertData("Insert Into Course Values('"+ txtCourseName.Text + "','" + txtCourseDuration.Text + "','" + txtCoursePrice.Text + "','" + txtInstractorName.Text + "')");

                    
            MessageBox.Show("Data Inserted Successfully!!!");
            RefreshData();
            ClearAllData();
           
          

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            objCourseDelete.DeleteCourseData("Delete Course Where CourseID='" + lblCid.Text + "'");
            MessageBox.Show("Data Deleted Successfully");
            RefreshData();
            ClearAllData();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            objCourseUpdate.UpdateCourseData("Update Course Set CourseName= '" + txtCourseName.Text + "', CourseDuration= '" + txtCourseDuration.Text + "', CoursePrice= '" + txtCoursePrice.Text + "', InstractorName= '" + txtInstractorName.Text + "' Where CourseID='" + lblCid.Text + "'");

            MessageBox.Show("Data Updated SuccessFully");
            RefreshData();
            ClearAllData();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearAllData();
        }

        private void dgViewStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void txtCourseDuration_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgViewCourse_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCourseName.Text = this.dgViewCourse.CurrentRow.Cells["CourseName"].Value.ToString();
            txtCourseDuration.Text = this.dgViewCourse.CurrentRow.Cells["CourseDuration"].Value.ToString();
            txtCoursePrice.Text = this.dgViewCourse.CurrentRow.Cells["CoursePrice"].Value.ToString();
            txtInstractorName.Text = this.dgViewCourse.CurrentRow.Cells["InstractorName"].Value.ToString();

            lblCid.Text = this.dgViewCourse.CurrentRow.Cells["CourseID"].Value.ToString();
        }
    }
}
