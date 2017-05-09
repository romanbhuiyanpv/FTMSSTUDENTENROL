using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FTMS_STUDENT_ENROLL_SYSTEM
{
    public partial class FrmStudentInformation : Form
    {
        DataAccessLayer DAL = new DataAccessLayer();
        DataProcessLayer DPL = new DataProcessLayer();
        public FrmStudentInformation()
        {
            InitializeComponent();
            CMBFILL();
            radoMale.Focus();
            radoMale.Select();
        }
        private void CMBFILL()
        {
            sql = @"SELECT     StudentInfoID, StudentId
FROM         dbo.Tbl_StudentInfo";
            dt = DAL.GetData(sql);
            comSearchStudentID.DataSource = dt;
            comSearchStudentID.DisplayMember = "StudentId";
            comSearchStudentID.ValueMember = "StudentInfoID";
            comSearchStudentID.SelectedIndex = -1;
        }

        #region Member Variable
        string sql = "";
        string save = "";
        string StudentId = "";
        int StudentInfoID = 0;
        DataTable dt = null;
        # endregion
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void dateTimePicker1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Return")
            {
                if (dateTimePicker1.Text.Trim().ToString() != "")
                {
                    txtStudentName.Focus();
                    txtStudentName.Select();
                }
            }
        }

        private void txtStudentName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Return")
            {
                if (txtStudentName.Text.Trim().ToString() != "")
                {
                    richAddress.Focus();
                    richAddress.Select();
                }
                else
                {
                    MessageBox.Show("Select Student name");
                    txtStudentName.Focus();
                    txtStudentName.Select();
                }
            }
        }

        private void txtStudentName_Enter(object sender, EventArgs e)
        {
            txtStudentName.ForeColor = Color.White;
            txtStudentName.BackColor = Color.CadetBlue;
        }

        private void txtStudentName_Leave(object sender, EventArgs e)
        {
            txtStudentName.ForeColor = Color.Black;
            txtStudentName.BackColor = Color.White;
        }

        private void richAddress_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Return")
            {
                if (richAddress.Text.Trim().ToString() != "")
                {
                    txtProgram.Focus();
                    txtProgram.Select();
                }
                else
                {
                    MessageBox.Show("Select address");
                    richAddress.Focus();
                    richAddress.Select();
                }
            }
        }

        private void richAddress_Enter(object sender, EventArgs e)
        {
            richAddress.ForeColor = Color.White;
            richAddress.BackColor = Color.CadetBlue;
        }

        private void richAddress_Leave(object sender, EventArgs e)
        {
            richAddress.ForeColor = Color.Black;
            richAddress.BackColor = Color.White;
        }

        private void txtProgram_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Return")
            {
                if (txtProgram.Text.Trim().ToString() != "")
                {
                    txtDepartment.Focus();
                    txtDepartment.Select();
                }
                else
                {
                    MessageBox.Show("Select program");
                    txtProgram.Focus();
                    txtProgram.Select();
                }
            }
        }

        private void txtProgram_Enter(object sender, EventArgs e)
        {
            txtProgram.ForeColor = Color.White;
            txtProgram.BackColor = Color.CadetBlue;
        }

        private void txtProgram_Leave(object sender, EventArgs e)
        {
            txtProgram.ForeColor = Color.Black;
            txtProgram.BackColor = Color.White;
        }

        private void txtDepartment_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Return")
            {
                if (txtDepartment.Text.Trim().ToString() != "")
                {
                    txtBatch.Focus();
                    txtBatch.Select();
                }
                else
                {
                    MessageBox.Show("Select department");
                    txtDepartment.Focus();
                    txtDepartment.Select();
                }
            }
        }

        private void txtDepartment_Enter(object sender, EventArgs e)
        {
            txtDepartment.ForeColor = Color.White;
            txtDepartment.BackColor = Color.CadetBlue;
        }

        private void txtDepartment_Leave(object sender, EventArgs e)
        {
            txtDepartment.ForeColor = Color.Black;
            txtDepartment.BackColor = Color.White;
        }

        private void txtBatch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Return")
            {
                if (txtBatch.Text.Trim().ToString() != "")
                {
                    txtStudentID.Focus();
                    txtStudentID.Select();
                }
                else
                {
                    MessageBox.Show("Select batch");
                    txtBatch.Focus();
                    txtBatch.Select();
                }
            }
        }

        private void txtBatch_Enter(object sender, EventArgs e)
        {
            txtBatch.ForeColor = Color.White;
            txtBatch.BackColor = Color.CadetBlue;
        }

        private void txtBatch_Leave(object sender, EventArgs e)
        {
            txtBatch.ForeColor = Color.Black;
            txtBatch.BackColor = Color.White;
        }

        private void txtStudentID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Return")
            {
                if (txtStudentID.Text.Trim().ToString() != "")
                {
                    txtRegNo.Focus();
                    txtRegNo.Select();
                }
                else
                {
                    MessageBox.Show("Select student id");
                    txtStudentID.Focus();
                    txtStudentID.Select();
                }
            }
        }

        private void txtStudentID_Enter(object sender, EventArgs e)
        {
            txtStudentID.ForeColor = Color.White;
            txtStudentID.BackColor = Color.CadetBlue;
        }

        private void txtStudentID_Leave(object sender, EventArgs e)
        {
            txtStudentID.ForeColor = Color.Black;
            txtStudentID.BackColor = Color.White;
        }

        private void txtRegNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Return")
            {
                if (txtRegNo.Text.Trim().ToString() != "")
                {
                    txtMobile.Focus();
                    txtMobile.Select();
                }
                else
                {
                    MessageBox.Show("Select reg. no");
                    txtRegNo.Focus();
                    txtRegNo.Select();
                }
            }
        }

        private void txtRegNo_Enter(object sender, EventArgs e)
        {
            txtRegNo.ForeColor = Color.White;
            txtRegNo.BackColor = Color.CadetBlue;
        }

        private void txtRegNo_Leave(object sender, EventArgs e)
        {
            txtRegNo.ForeColor = Color.Black;
            txtRegNo.BackColor = Color.White;
        }

        private void txtMobile_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Return")
            {
                if (txtMobile.Text.Trim().ToString() != "")
                {
                    btnSave.Focus();
                    btnSave.Select();
                }
                else
                {
                    MessageBox.Show("Select mobile no");
                    txtMobile.Focus();
                    txtMobile.Select();
                }
            }
        }

        private void txtMobile_Enter(object sender, EventArgs e)
        {
            txtMobile.ForeColor = Color.White;
            txtMobile.BackColor = Color.CadetBlue;
        }

        private void txtMobile_Leave(object sender, EventArgs e)
        {
            txtMobile.ForeColor = Color.Black;
            txtMobile.BackColor = Color.White;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (radoMale.Checked || radoFemale.Checked)
            {
                int Male_Female = 0;
                if (radoMale.Checked)
                {
                    Male_Female = 0;
                }
                if (radoFemale.Checked)
                {
                    Male_Female = 1;
                }
                string Date = dateTimePicker1.Value.ToString("dd-MM-yyyy");
                string StudentName = txtStudentName.Text.Trim().ToString();
                string Address = richAddress.Text.Trim().ToString();
                string Program = txtProgram.Text.Trim().ToString();
                string Department = txtDepartment.Text.Trim().ToString();
                string Batch = txtBatch.Text.Trim().ToString();
                string StudentId = txtStudentID.Text.Trim().ToString();
                string RegNo = txtRegNo.Text.Trim().ToString();
                string Mobile = txtMobile.Text.Trim().ToString();
                save = DPL.Save_Tbl_StudentInfo(Male_Female, Date, StudentName, Address, Program, Department, Batch, StudentId, RegNo, Mobile);
                if (save == "Succeded")
                {
                    sql = @"SELECT     StudentInfoID, CASE WHEN Gender = 0 THEN 'Male' ELSE 'Female' END AS Gender, Date, StudentName, Address, Program, Department, Batch, StudentId, RegNo, 
                      Mobile
FROM         dbo.Tbl_StudentInfo
WHERE     (StudentId = '" + StudentId + "')";
                    dt = DAL.GetData(sql);
                    dataGridView1.DataSource = dt;
                    MessageBox.Show("Succeded");
                }
            }
        }

        private void comSearchStudentID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Return")
            {
                if (comSearchStudentID.Text.Trim().ToString() != "")
                {
                    string StudentId = comSearchStudentID.Text.Trim().ToString();
                    sql = @"SELECT     StudentInfoID, CASE WHEN Gender = 0 THEN 'Male' ELSE 'Female' END AS Gender, Date, StudentName, Address, Program, Department, Batch, StudentId, RegNo, 
                      Mobile
FROM         dbo.Tbl_StudentInfo
WHERE     (StudentId = '" + StudentId + "')";
                    dt = DAL.GetData(sql);
                    dataGridView1.DataSource = dt;
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                int rowindex = Convert.ToInt32(dataGridView1.SelectedRows[0].Index);
                int Male_Female = 0;
                if (radoMale.Checked)
                {
                    radoMale.Checked = true;
                }
                if (radoFemale.Checked)
                {
                    radoFemale.Checked = true;
                }
                string Gender = dataGridView1.Rows[rowindex].Cells["Gender"].Value.ToString();
                string Date = dataGridView1.Rows[rowindex].Cells["Date"].Value.ToString();
                string StudentName = dataGridView1.Rows[rowindex].Cells["StudentName"].Value.ToString();
                string Address = dataGridView1.Rows[rowindex].Cells["Address"].Value.ToString();
                string Program = dataGridView1.Rows[rowindex].Cells["Program"].Value.ToString();
                string Department = dataGridView1.Rows[rowindex].Cells["Department"].Value.ToString();
                string Batch = dataGridView1.Rows[rowindex].Cells["Batch"].Value.ToString();
                string StudentId = dataGridView1.Rows[rowindex].Cells["StudentId"].Value.ToString();
                string RegNo = dataGridView1.Rows[rowindex].Cells["RegNo"].Value.ToString();
                string Mobile = dataGridView1.Rows[rowindex].Cells["Mobile"].Value.ToString();
                StudentInfoID = Convert.ToInt32(dataGridView1.Rows[rowindex].Cells["StudentInfoID"].Value.ToString());

                txtStudentName.Text = StudentName;
                richAddress.Text = Address;
                txtProgram.Text = Program;
                txtDepartment.Text = Department;
                txtBatch.Text = Batch;
                txtStudentID.Text = StudentId;
                txtRegNo.Text = RegNo;
                txtMobile.Text = Mobile;
            }
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            dateTimePicker1.Text = "";
            txtStudentName.Text = "";
            richAddress.Text = "";
            txtProgram.Text = "";
            txtDepartment.Text = "";
            txtBatch.Text = "";
            txtStudentID.Text = "";
            txtRegNo.Text = "";
            txtMobile.Text = "";
            dataGridView1.DataSource = null;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string update = "";
            //            string update = "";
            if (radoMale.Checked || radoFemale.Checked)
            {
                int Male_Female = 0;
                if (radoMale.Checked)
                {
                    Male_Female = 0;
                }
                if (radoFemale.Checked)
                {
                    Male_Female = 1;
                }
                string Date = dateTimePicker1.Text.Trim().ToString();
                string StudentName = txtStudentName.Text.Trim().ToString();
                string Address = richAddress.Text.Trim().ToString();
                string Program = txtProgram.Text.Trim().ToString();
                string Department = txtDepartment.Text.Trim().ToString();
                string Batch = txtBatch.Text.Trim().ToString();
                string StudentId = txtStudentID.Text.Trim().ToString();
                string RegNo = txtRegNo.Text.Trim().ToString();
                string Mobile = txtMobile.Text.Trim().ToString();
                update = DPL.Update_Tbl_StudentInfo(StudentInfoID, Male_Female, Date, StudentName, Address, Program, Department, Batch, StudentId, RegNo, Mobile);
                if (update == "Succeded")
                {
                    sql = @"SELECT     StudentInfoID, CASE WHEN Gender = 0 THEN 'Male' ELSE 'Female' END AS Gender, Date, StudentName, Address, Program, Department, Batch, StudentId, RegNo, 
                      Mobile
FROM         dbo.Tbl_StudentInfo
WHERE     (StudentId = '" + StudentId + "')";
                    dt = DAL.GetData(sql);
                    dataGridView1.DataSource = dt;
                    MessageBox.Show("Succeded");
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string DetailsDelete = "";
            if (dataGridView1.Rows.Count > 0)
            {
                DialogResult dr = MessageBox.Show("Do you want to delete the row?", "confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dr == DialogResult.Yes)
                {
                    string sql = "";
                    DetailsDelete = DPL.Delete_tbl_Value("Tbl_StudentInfo", "StudentInfoID", StudentInfoID);
                    if (DetailsDelete == "Succeded")
                    {
                        MessageBox.Show("Succeded");
                        sql = @"SELECT     StudentInfoID, CASE WHEN Gender = 0 THEN 'Male' ELSE 'Female' END AS Gender, Date, StudentName, Address, Program, Department, Batch, StudentId, RegNo, 
                      Mobile
FROM         dbo.Tbl_StudentInfo
WHERE     (StudentId = '" + StudentId + "')";
                        dt = DAL.GetData(sql);
                        dataGridView1.DataSource = dt;
                        StudentInfoID = 0;
                    }
                }
            }
        }

    }
}
