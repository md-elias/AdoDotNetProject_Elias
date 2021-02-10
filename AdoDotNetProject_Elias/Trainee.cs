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
    public partial class Trainee : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["DbCon"].ConnectionString;
        SqlConnection con;
        //SqlCommand cmd;
        SqlDataAdapter adapter;
        DataTable dt;

        public void RefreshData()
        {
            using (con = new SqlConnection(cs))
            {
                adapter = new SqlDataAdapter("SELECT * FROM TraineeInfo", con);
                dt = new DataTable();
                adapter.Fill(dt);
                dgViewStudent.DataSource = dt;
            }
        }

        public void ClearAllData()
        {
            txtName.Text = "";
            txtFatherName.Text = "";
            txtMotherName.Text = "";
            txtCellPhone.Text = "";          
            txtCellPhone.Text = "";
            txtEmail.Text = "";
            txtReligon.Text = "";
            txtImageFile.Text = "";
            txtCourseID.Text = "";

        }

        InsertTrainee objTraineeInsert = new InsertTrainee();
        DeleteTrainee objTraineeDelete = new DeleteTrainee();
        UpdateTrainee objTraineeUpdate = new UpdateTrainee();
        public Trainee()
        {
            InitializeComponent();
            RefreshData();
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*jpg; *jpeg; *gif; *bmp;)|*jpg; *jpeg; *gif; *bmp;";
            if (open.ShowDialog() == DialogResult.OK)
            {
                txtImageFile.Text = open.FileName;
                pictureBox1.Image = new Bitmap(open.FileName);

            }
        }
        private void Trainee_Load(object sender, EventArgs e)
        {
            RefreshData();
        }

        //logout
        private void label1_Click(object sender, EventArgs e)
        {
            Form1 fl = new Form1();
            this.Hide();
            fl.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            File.Copy(txtImageFile.Text, Path.Combine(@"C:\ADO\AdoDotNetProject_Elias\AdoDotNetProject_Elias\Image", Path.GetFileName(txtImageFile.Text)), true);

            objTraineeInsert.InsertTraineeData("Insert Into TraineeInfo Values('" + txtName.Text + "','" + txtFatherName.Text + "','" + txtMotherName.Text + "','" + txtCellPhone.Text + "','" + txtEmail.Text + "','" + txtReligon.Text + "','" + txtImageFile.Text + "','" + txtCourseID.Text + "')");



            MessageBox.Show("Data Inserted Successfully!!!");
            RefreshData();
            ClearAllData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            objTraineeDelete.DeleteTraineetData("Delete TraineeInfo Where TraineeID='" + lblTid.Text + "'");
            MessageBox.Show("Data Deleted Successfully");
            RefreshData();
            ClearAllData();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            objTraineeUpdate.UpdateTraineetData("Update TraineeInfo Set TraineeName= '" + txtName.Text + "', FathersName= '" + txtFatherName.Text + "', MothersName= '" + txtMotherName.Text + "', CellPhone= '" + txtCellPhone.Text + "',EmailID= '" + txtEmail.Text + "',Religon= '" + txtReligon.Text + "',TraineeImage= '" + txtImageFile.Text + "',CourseID= '" + txtCourseID.Text + "' Where TraineeID='" + lblTid.Text + "'");

            MessageBox.Show("Data Updated Successfully");
            RefreshData();
            ClearAllData();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearAllData();
        }

        private void btnImgUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*jpg; *jpeg; *gif; *bmp;)|*jpg; *jpeg; *gif; *bmp;";
            if (open.ShowDialog() == DialogResult.OK)
            {
                txtImageFile.Text = open.FileName;
                pictureBox1.Image = new Bitmap(open.FileName);

            }
        }

        private void dgViewStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtName.Text = this.dgViewStudent.CurrentRow.Cells["TraineeName"].Value.ToString();
            txtFatherName.Text = this.dgViewStudent.CurrentRow.Cells["FathersName"].Value.ToString();
            txtMotherName.Text = this.dgViewStudent.CurrentRow.Cells["MothersName"].Value.ToString();
            txtCellPhone.Text = this.dgViewStudent.CurrentRow.Cells["CellPhone"].Value.ToString();
            txtEmail.Text = this.dgViewStudent.CurrentRow.Cells["EmailID"].Value.ToString();
            txtReligon.Text = this.dgViewStudent.CurrentRow.Cells["Religon"].Value.ToString();

            txtImageFile.Text = this.dgViewStudent.CurrentRow.Cells["TraineeImage"].Value.ToString();
            txtCourseID.Text = this.dgViewStudent.CurrentRow.Cells["CourseID"].Value.ToString();

            lblTid.Text = this.dgViewStudent.CurrentRow.Cells["TraineeID"].Value.ToString();
        }
    }
}
