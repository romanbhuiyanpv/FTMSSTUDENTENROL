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
    public partial class FrmStudentResult : Form
    {
        DataAccessLayer DAL = new DataAccessLayer();
        DataProcessLayer DPL = new DataProcessLayer();
        public FrmStudentResult()
        {
            InitializeComponent();
            CMBFILL();
            cmbStudentID.Focus();
            cmbStudentID.Select();
        }
        private void CMBFILL()
        {
           
            sql = @"SELECT     StudentResultID, StudentId
            FROM         dbo.Tbl_StudentResult";
            dt = DAL.GetData(sql);
            comSearchStudentID.DataSource = dt;
            comSearchStudentID.DisplayMember = "StudentId";
            comSearchStudentID.ValueMember = "StudentResultID";
            comSearchStudentID.SelectedIndex = -1;

            sql = @"SELECT     StudentAdmissionID, Semister, StudentId, StudentName, Program
            FROM         dbo.Tbl_StudentAdmission";
            dt = DAL.GetData(sql);
            cmbStudentID.DataSource = dt;
            cmbStudentID.DisplayMember = "StudentId";
            cmbStudentID.ValueMember = "StudentAdmissionID";
            cmbStudentID.SelectedIndex = -1;
            cmbSemister.DataSource = dt;
            cmbSemister.DisplayMember = "Semister";
            cmbSemister.ValueMember = "StudentAdmissionID";
            cmbStudentName.DataSource = dt;
            cmbStudentName.DisplayMember = "StudentName";
            cmbStudentName.ValueMember = "StudentAdmissionID";
            cmbProgram.DataSource = dt;
            cmbProgram.DisplayMember = "Program";
            cmbProgram.ValueMember = "StudentAdmissionID";

            sql = @"SELECT     StudentRegistrationID, StudentId, Batch, RegNo, Campus
FROM         dbo.Tbl_StudentRegistration";
            dt = DAL.GetData(sql);
            cmbStudentID.DataSource = dt;
            cmbStudentID.DisplayMember = "StudentId";
            cmbStudentID.ValueMember = "StudentRegistrationID";
            cmbStudentID.SelectedIndex = -1;
            cmbBatch.DataSource = dt;
            cmbBatch.DisplayMember = "Batch";
            cmbBatch.ValueMember = "StudentRegistrationID";
            cmbRegNo.DataSource = dt;
            cmbRegNo.DisplayMember = "RegNo";
            cmbRegNo.ValueMember = "StudentRegistrationID";
            cmbCampus.DataSource = dt;
            cmbCampus.DisplayMember = "Campus";
            cmbCampus.ValueMember = "StudentRegistrationID";
        }

        # region Member Variable
        string sql = "";
        string save = "";
        string StudentId = "";
        int StudentResultID = 0;
        DataTable dt = null;
        # endregion
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void cmbStudentID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Return")
            {
                if (cmbStudentID.Text.Trim().ToString() != "")
                {
                    txtCode1.Focus();
                    txtCode1.Select();
                }
                else
                {
                    MessageBox.Show("Select campus");
                    cmbStudentID.Focus();
                    cmbStudentID.Select();
                }
            }
        }

        private void cmbStudentID_Enter(object sender, EventArgs e)
        {
            cmbStudentID.ForeColor = Color.White;
            cmbStudentID.BackColor = Color.CadetBlue;
        }

        private void cmbStudentID_Leave(object sender, EventArgs e)
        {
            cmbStudentID.ForeColor = Color.Black;
            cmbStudentID.BackColor = Color.White;
        }
  
        private void btnSave_Click(object sender, EventArgs e)
        {
            string Semister = cmbSemister.Text.Trim().ToString();
            string StudentId = cmbStudentID.Text.Trim().ToString();
            string StudentName = cmbStudentName.Text.Trim().ToString();
            string Program = cmbProgram.Text.Trim().ToString();
            string Batch = cmbBatch.Text.Trim().ToString();
            string RegNo = cmbRegNo.Text.Trim().ToString();
            string Campus = cmbCampus.Text.Trim().ToString();
            string Code1 = txtCode1.Text.Trim().ToString();
            decimal GPA1 = Convert.ToDecimal(numCredit1.Value);
            decimal ObtainedGPA1 = Convert.ToDecimal(numObtainedGPA1.Value);
            string Code2 = txtCode2.Text.Trim().ToString();
            decimal GPA2 = Convert.ToDecimal(numCredit2.Value);
            decimal ObtainedGPA2 = Convert.ToDecimal(numObtainedGPA2.Value);
            string Code3 = txtCode3.Text.Trim().ToString();
            decimal GPA3 = Convert.ToDecimal(numCredit3.Value);
            decimal ObtainedGPA3 = Convert.ToDecimal(numObtainedGPA3.Value);
            string Code4 = txtCode4.Text.Trim().ToString();
            decimal GPA4 = Convert.ToDecimal(numCredit4.Value);
            decimal ObtainedGPA4 = Convert.ToDecimal(numObtainedGPA4.Value);
            string Code5 = txtCode5.Text.Trim().ToString();
            decimal GPA5 = Convert.ToDecimal(numCredit5.Value);
            decimal ObtainedGPA5 = Convert.ToDecimal(numObtainedGPA5.Value);
            string Code6 = txtCode6.Text.Trim().ToString();
            decimal GPA6 = Convert.ToDecimal(numCredit6.Value);
            decimal ObtainedGPA6 = Convert.ToDecimal(numObtainedGPA6.Value);
            string Code7 = txtCode7.Text.Trim().ToString();
            decimal GPA7 = Convert.ToDecimal(numCredit7.Value);
            decimal ObtainedGPA7 = Convert.ToDecimal(numObtainedGPA7.Value);
            string Code8 = txtCode8.Text.Trim().ToString();
            decimal GPA8 = Convert.ToDecimal(numCredit8.Value);
            decimal ObtainedGPA8 = Convert.ToDecimal(numObtainGPA8.Value);
            string SGPA = txtSGPA.Text.Trim().ToString();
            save = DPL.Save_Tbl_StudentResult(Semister, StudentId, StudentName, Program, Batch, RegNo, Campus, Code1, GPA1, ObtainedGPA1, Code2, GPA2, ObtainedGPA2, Code3, GPA3, ObtainedGPA3, Code4, GPA4, ObtainedGPA4, Code5, GPA5, ObtainedGPA5, Code6, GPA6, ObtainedGPA6, Code7, GPA7, ObtainedGPA7, Code8, GPA8, ObtainedGPA8, SGPA);
            if (save == "Succeded")
            {
                sql = @"SELECT     StudentResultID, Semister, StudentId, StudentName, Program, Batch, RegNo, Campus, Code1, GPA1, ObtainedGPA1, Code2, GPA2, ObtainedGPA2, Code3, GPA3, 
                      ObtainedGPA3, Code4, GPA4, ObtainedGPA4, Code5, GPA5, ObtainedGPA5, Code6, GPA6, ObtainedGPA6, Code7, GPA7, ObtainedGPA7, Code8, GPA8, ObtainedGPA8, 
                      SGPA
FROM         dbo.Tbl_StudentResult
WHERE     (StudentId = '" + StudentId + "')";
                dt = DAL.GetData(sql);
                dataGridView1.DataSource = dt;
                MessageBox.Show("Succeded");
            }
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            cmbSemister.Text = "";
            cmbStudentID.Text = "";
            cmbStudentName.Text = "";
            cmbProgram.Text = "";
            cmbBatch.Text = "";
            cmbRegNo.Text = "";
            cmbCampus.Text = "";
            txtCode1.Text = "";
            numCredit1.Text = "";
            numObtainedGPA1.Text = "";
            txtCode2.Text = "";
            numCredit2.Text = "";
            numObtainedGPA2.Text = "";
            txtCode3.Text = "";
            numCredit3.Text = "";
            numObtainedGPA3.Text = "";
            txtCode4.Text = "";
            numCredit4.Text = "";
            numObtainedGPA4.Text = "";
            txtCode5.Text = "";
            numCredit5.Text = "";
            numObtainedGPA5.Text = "";
            txtCode6.Text = "";
            numCredit6.Text = "";
            numObtainedGPA6.Text = "";
            txtCode7.Text = "";
            numCredit7.Text = "";
            numObtainedGPA7.Text = "";
            txtCode8.Text = "";
            numCredit8.Text = "";
            numObtainGPA8.Text = "";
            txtSGPA.Text = "";
            dataGridView1.DataSource = null;
        }

        private void comSearchStudentID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Return")
            {
                if (comSearchStudentID.Text.Trim().ToString() != "")
                {
                    string StudentId = comSearchStudentID.Text.Trim().ToString();
                    sql = @"SELECT     StudentResultID, Semister, StudentId, StudentName, Program, Batch, RegNo, Campus, Code1, GPA1, ObtainedGPA1, Code2, GPA2, ObtainedGPA2, Code3, GPA3, 
                      ObtainedGPA3, Code4, GPA4, ObtainedGPA4, Code5, GPA5, ObtainedGPA5, Code6, GPA6, ObtainedGPA6, Code7, GPA7, ObtainedGPA7, Code8, GPA8, ObtainedGPA8, 
                      SGPA
FROM         dbo.Tbl_StudentResult
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
                string Semister = dataGridView1.Rows[rowindex].Cells["Semister"].Value.ToString();
                string StudentId = dataGridView1.Rows[rowindex].Cells["StudentId"].Value.ToString();
                string StudentName = dataGridView1.Rows[rowindex].Cells["StudentName"].Value.ToString();
                string Program = dataGridView1.Rows[rowindex].Cells["Program"].Value.ToString();
                string Batch = dataGridView1.Rows[rowindex].Cells["Batch"].Value.ToString();
                string RegNo = dataGridView1.Rows[rowindex].Cells["RegNo"].Value.ToString();
                string Campus = dataGridView1.Rows[rowindex].Cells["Campus"].Value.ToString();
                string Code1 = dataGridView1.Rows[rowindex].Cells["Code1"].Value.ToString();
                decimal GPA1 = Convert.ToDecimal(dataGridView1.Rows[rowindex].Cells["GPA1"].Value.ToString());
                decimal ObtainedGPA1 = Convert.ToDecimal(dataGridView1.Rows[rowindex].Cells["ObtainedGPA1"].Value.ToString());
                string Code2 = dataGridView1.Rows[rowindex].Cells["Code2"].Value.ToString();
                decimal GPA2 = Convert.ToDecimal(dataGridView1.Rows[rowindex].Cells["GPA2"].Value.ToString());
                decimal ObtainedGPA2 = Convert.ToDecimal(dataGridView1.Rows[rowindex].Cells["ObtainedGPA2"].Value.ToString());
                string Code3 = dataGridView1.Rows[rowindex].Cells["Code3"].Value.ToString();
                decimal GPA3 = Convert.ToDecimal(dataGridView1.Rows[rowindex].Cells["GPA3"].Value.ToString());
                decimal ObtainedGPA3 = Convert.ToDecimal(dataGridView1.Rows[rowindex].Cells["ObtainedGPA3"].Value.ToString());
                string Code4 = dataGridView1.Rows[rowindex].Cells["Code4"].Value.ToString();
                decimal GPA4 = Convert.ToDecimal(dataGridView1.Rows[rowindex].Cells["GPA4"].Value.ToString());
                decimal ObtainedGPA4 = Convert.ToDecimal(dataGridView1.Rows[rowindex].Cells["ObtainedGPA4"].Value.ToString());
                string Code5 = dataGridView1.Rows[rowindex].Cells["Code5"].Value.ToString();
                decimal GPA5 = Convert.ToDecimal(dataGridView1.Rows[rowindex].Cells["GPA5"].Value.ToString());
                decimal ObtainedGPA5 = Convert.ToDecimal(dataGridView1.Rows[rowindex].Cells["ObtainedGPA5"].Value.ToString());
                string Code6 = dataGridView1.Rows[rowindex].Cells["Code6"].Value.ToString();
                decimal GPA6 = Convert.ToDecimal(dataGridView1.Rows[rowindex].Cells["GPA6"].Value.ToString());
                decimal ObtainedGPA6 = Convert.ToDecimal(dataGridView1.Rows[rowindex].Cells["ObtainedGPA6"].Value.ToString());
                string Code7 = dataGridView1.Rows[rowindex].Cells["Code7"].Value.ToString();
                decimal GPA7 = Convert.ToDecimal(dataGridView1.Rows[rowindex].Cells["GPA7"].Value.ToString());
                decimal ObtainedGPA7 = Convert.ToDecimal(dataGridView1.Rows[rowindex].Cells["ObtainedGPA7"].Value.ToString());
                string Code8 = dataGridView1.Rows[rowindex].Cells["Code8"].Value.ToString();
                decimal GPA8 = Convert.ToDecimal(dataGridView1.Rows[rowindex].Cells["GPA8"].Value.ToString());
                decimal ObtainedGPA8 = Convert.ToDecimal(dataGridView1.Rows[rowindex].Cells["ObtainedGPA8"].Value.ToString());
                string SGPA = dataGridView1.Rows[rowindex].Cells["SGPA"].Value.ToString();
                StudentResultID = Convert.ToInt32(dataGridView1.Rows[rowindex].Cells["StudentResultID"].Value.ToString());

                cmbSemister.Text = Semister;
                cmbStudentID.Text = StudentId;
                cmbStudentName.Text = StudentName;
                cmbProgram.Text = Program;
                cmbBatch.Text = Batch;
                cmbRegNo.Text = RegNo;
                cmbCampus.Text = Campus;
                txtCode1.Text = Code1;
                numCredit1.Value = GPA1;
                numObtainedGPA1.Value = ObtainedGPA1;
                txtCode2.Text = Code2;
                numCredit2.Value = GPA2;
                numObtainedGPA2.Value = ObtainedGPA2;
                txtCode3.Text = Code3;
                numCredit3.Value = GPA3;
                numObtainedGPA3.Value = ObtainedGPA3;
                txtCode4.Text = Code4;
                numCredit4.Value = GPA4;
                numObtainedGPA4.Value = ObtainedGPA4;
                txtCode5.Text = Code5;
                numCredit5.Value = GPA5;
                numObtainedGPA5.Value = ObtainedGPA5;
                txtCode6.Text = Code6;
                numCredit6.Value = GPA6;
                numObtainedGPA6.Value = ObtainedGPA6;
                txtCode7.Text = Code7;
                numCredit7.Value = GPA7;
                numObtainedGPA7.Value = ObtainedGPA7;
                txtCode8.Text = Code8;
                numCredit8.Value = GPA8;
                numObtainGPA8.Value = ObtainedGPA8;
                txtSGPA.Text = SGPA;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string update = "";
            string Semister = cmbSemister.Text.Trim().ToString();
            string StudentId = cmbStudentID.Text.Trim().ToString();
            string StudentName = cmbStudentName.Text.Trim().ToString();
            string Program = cmbProgram.Text.Trim().ToString();
            string Batch = cmbBatch.Text.Trim().ToString();
            string RegNo = cmbRegNo.Text.Trim().ToString();
            string Campus = cmbCampus.Text.Trim().ToString();
            string Code1 = txtCode1.Text.Trim().ToString();
            decimal GPA1 = numCredit1.Value;
            decimal ObtainedGPA1 = numObtainedGPA1.Value;
            string Code2 = txtCode2.Text.Trim().ToString();
            decimal GPA2 = numCredit2.Value;
            decimal ObtainedGPA2 = numObtainedGPA2.Value;
            string Code3 = txtCode3.Text.Trim().ToString();
            decimal GPA3 = numCredit3.Value;
            decimal ObtainedGPA3 = numObtainedGPA3.Value;
            string Code4 = txtCode4.Text.Trim().ToString();
            decimal GPA4 = numCredit4.Value;
            decimal ObtainedGPA4 = numObtainedGPA4.Value;
            string Code5 = txtCode5.Text.Trim().ToString();
            decimal GPA5 = numCredit5.Value;
            decimal ObtainedGPA5 = numObtainedGPA5.Value;
            string Code6 = txtCode6.Text.Trim().ToString();
            decimal GPA6 = numCredit6.Value;
            decimal ObtainedGPA6 = numObtainedGPA6.Value;
            string Code7 = txtCode7.Text.Trim().ToString();
            decimal GPA7 = numCredit7.Value;
            decimal ObtainedGPA7 = numObtainedGPA7.Value;
            string Code8 = txtCode8.Text.Trim().ToString();
            decimal GPA8 = numCredit8.Value;
            decimal ObtainedGPA8 = numObtainGPA8.Value;
            string SGPA = txtSGPA.Text.Trim().ToString();
            update = DPL.Update_Tbl_StudentResult(StudentResultID, Semister, StudentId, StudentName, Program, Batch, RegNo, Campus, Code1, GPA1, ObtainedGPA1, Code2, GPA2, ObtainedGPA2, Code3, GPA3, ObtainedGPA3, Code4, GPA4, ObtainedGPA4, Code5, GPA5, ObtainedGPA5, Code6, GPA6, ObtainedGPA6, Code7, GPA7, ObtainedGPA7, Code8, GPA8, ObtainedGPA8, SGPA);
            if (update == "Succeded")
            {
                sql = @"SELECT     StudentResultID, Semister, StudentId, StudentName, Program, Batch, RegNo, Campus, Code1, GPA1, ObtainedGPA1, Code2, GPA2, ObtainedGPA2, Code3, GPA3, 
                      ObtainedGPA3, Code4, GPA4, ObtainedGPA4, Code5, GPA5, ObtainedGPA5, Code6, GPA6, ObtainedGPA6, Code7, GPA7, ObtainedGPA7, Code8, GPA8, ObtainedGPA8, 
                      SGPA
FROM         dbo.Tbl_StudentResult
WHERE     (StudentId = '" + StudentId + "')";
                dt = DAL.GetData(sql);
                dataGridView1.DataSource = dt;
                MessageBox.Show("Succeded");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string DetailsDelete = "";
            if (dataGridView1.Rows.Count > 0)
            {
                DialogResult dr = MessageBox.Show("Do you want to Delete this row?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dr == DialogResult.Yes)
                {
                    string sql = "";
                    DetailsDelete = DPL.Delete_tbl_Value("Tbl_StudentResult", "StudentResultID", StudentResultID);
                    if (DetailsDelete == "Succeded")
                    {
                        MessageBox.Show("Succeded");
                        sql = @"SELECT     StudentResultID, Semister, StudentId, StudentName, Program, Batch, RegNo, Campus, Code1, GPA1, ObtainedGPA1, Code2, GPA2, ObtainedGPA2, Code3, GPA3, 
                      ObtainedGPA3, Code4, GPA4, ObtainedGPA4, Code5, GPA5, ObtainedGPA5, Code6, GPA6, ObtainedGPA6, Code7, GPA7, ObtainedGPA7, Code8, GPA8, ObtainedGPA8, 
                      SGPA
FROM         dbo.Tbl_StudentResult
WHERE     (StudentId = '" + StudentId + "')";

                        dt = DAL.GetData(sql);
                        dataGridView1.DataSource = dt;
                        StudentResultID = 0;
                    }

                }
            }
        }

        private void txtCode1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Return")
            {
                if (txtCode1.Text.Trim().ToString() != "")
                {
                    numCredit1.Focus();
                    numCredit1.Select();
                }
                else
                {
                    MessageBox.Show("Select course code1");
                    txtCode1.Focus();
                    txtCode1.Select();
                }
            }
        }

        private void txtCode1_Enter(object sender, EventArgs e)
        {
            txtCode1.ForeColor = Color.White;
            txtCode1.BackColor = Color.CadetBlue;
        }

        private void txtCode1_Leave(object sender, EventArgs e)
        {
            txtCode1.ForeColor = Color.Black;
            txtCode1.BackColor = Color.White;
        }

        private void numCredit1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Return")
            {
                if (Convert.ToDecimal(numCredit1.Value) != -1)
                {
                    numObtainedGPA1.Focus();
                    numObtainedGPA1.Select();
                }
                else
                {
                    MessageBox.Show("Select course credit1");
                    numCredit1.Focus();
                    numCredit1.Select();
                }
            }
        }

        private void numObtainedGPA1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Return")
            {
                if (Convert.ToDecimal(numObtainedGPA1.Value) != -1)
                {
                    txtCode2.Focus();
                    txtCode2.Select();
                }
                else
                {
                    MessageBox.Show("Select obtained gpa1");
                    numObtainedGPA1.Focus();
                    numObtainedGPA1.Select();
                }
            }
        }

        private void txtCode2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Return")
            {
                if (txtCode2.Text.Trim().ToString() != "")
                {
                    numCredit2.Focus();
                    numCredit2.Select();
                }
                else
                {
                    MessageBox.Show("Select course code2");
                    txtCode2.Focus();
                    txtCode2.Select();
                }
            }
        }

        private void numCredit2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Return")
            {
                if (Convert.ToDecimal(numCredit2.Value) != -1)
                {
                    numObtainedGPA2.Focus();
                    numObtainedGPA2.Select();
                }
                else
                {
                    MessageBox.Show("Select course credit2");
                    numCredit2.Focus();
                    numCredit2.Select();
                }
            }
        }

        private void numObtainedGPA2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Return")
            {
                if (Convert.ToDecimal(numObtainedGPA2.Value) != -1)
                {
                    txtCode3.Focus();
                    txtCode3.Select();
                }
                else
                {
                    MessageBox.Show("Select obtained gpa2");
                    numObtainedGPA2.Focus();
                    numObtainedGPA2.Select();
                }
            }
        }

        private void txtCode3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Return")
            {
                if (txtCode3.Text.Trim().ToString() != "")
                {
                    numCredit3.Focus();
                    numCredit3.Select();
                }
                else
                {
                    MessageBox.Show("Select course code3");
                    txtCode3.Focus();
                    txtCode3.Select();
                }
            }
        }

        private void numCredit3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Return")
            {
                if (Convert.ToDecimal(numCredit3.Value) != -1)
                {
                    numObtainedGPA3.Focus();
                    numObtainedGPA3.Select();
                }
                else
                {
                    MessageBox.Show("Select course credit3");
                    numCredit3.Focus();
                    numCredit3.Select();
                }
            }
        }

        private void numObtainedGPA3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Return")
            {
                if (Convert.ToDecimal(numObtainedGPA3.Value) != -1)
                {
                    txtCode4.Focus();
                    txtCode4.Select();
                }
                else
                {
                    MessageBox.Show("Select obtained gpa3");
                    numObtainedGPA3.Focus();
                    numObtainedGPA3.Select();
                }
            }
        }

        private void txtCode4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Return")
            {
                if (txtCode4.Text.Trim().ToString() != "")
                {
                    numCredit4.Focus();
                    numCredit4.Select();
                }
                else
                {
                    MessageBox.Show("Select course code4");
                    txtCode4.Focus();
                    txtCode4.Select();
                }
            }
        }

        private void numCredit4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Return")
            {
                if (Convert.ToDecimal(numCredit4.Value) != -1)
                {
                    numObtainedGPA4.Focus();
                    numObtainedGPA4.Select();
                }
                else
                {
                    MessageBox.Show("Select course credit4");
                    numCredit4.Focus();
                    numCredit4.Select();
                }
            }
        }

        private void numObtainedGPA4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Return")
            {
                if (Convert.ToDecimal(numObtainedGPA4.Value) != -1)
                {
                    txtCode5.Focus();
                    txtCode5.Select();
                }
                else
                {
                    MessageBox.Show("Select obtained gpa4");
                    numObtainedGPA4.Focus();
                    numObtainedGPA4.Select();
                }
            }
        }

        private void txtCode5_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Return")
            {
                if (txtCode5.Text.Trim().ToString() != "")
                {
                    numCredit5.Focus();
                    numCredit5.Select();
                }
                else
                {
                    MessageBox.Show("Select course code5");
                    txtCode5.Focus();
                    txtCode5.Select();
                }
            }
        }

        private void numCredit5_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Return")
            {
                if (Convert.ToDecimal(numCredit5.Value) != -1)
                {
                    numObtainedGPA5.Focus();
                    numObtainedGPA5.Select();
                }
                else
                {
                    MessageBox.Show("Select course credit5");
                    numCredit5.Focus();
                    numCredit5.Select();
                }
            }
        }

        private void numObtainedGPA5_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Return")
            {
                if (Convert.ToDecimal(numObtainedGPA5.Value) != -1)
                {
                    txtCode6.Focus();
                    txtCode6.Select();
                }
                else
                {
                    MessageBox.Show("Select obtained gpa5");
                    numObtainedGPA5.Focus();
                    numObtainedGPA5.Select();
                }
            }
        }

        private void txtCode6_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Return")
            {
                if (txtCode6.Text.Trim().ToString() != "")
                {
                    numCredit6.Focus();
                    numCredit6.Select();
                }
                else
                {
                    MessageBox.Show("Select course code6");
                    txtCode6.Focus();
                    txtCode6.Select();
                }
            }
        }

        private void numCredit6_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Return")
            {
                if (Convert.ToDecimal(numCredit6.Value) != -1)
                {
                    numObtainedGPA6.Focus();
                    numObtainedGPA6.Select();
                }
                else
                {
                    MessageBox.Show("Select course credit6");
                    numCredit6.Focus();
                    numCredit6.Select();
                }
            }
        }

        private void numObtainedGPA6_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Return")
            {
                if (Convert.ToDecimal(numObtainedGPA6.Value) != -1)
                {
                    txtCode7.Focus();
                    txtCode7.Select();
                }
                else
                {
                    MessageBox.Show("Select obtained gpa6");
                    numObtainedGPA6.Focus();
                    numObtainedGPA6.Select();
                }
            }
        }

        private void txtCode7_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Return")
            {
                if (txtCode7.Text.Trim().ToString() != "")
                {
                    numCredit7.Focus();
                    numCredit7.Select();
                }
                else
                {
                    MessageBox.Show("Select course code7");
                    txtCode7.Focus();
                    txtCode7.Select();
                }
            }
        }

        private void numCredit7_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Return")
            {
                if (Convert.ToDecimal(numCredit7.Value) != -1)
                {
                    numObtainedGPA7.Focus();
                    numObtainedGPA7.Select();
                }
                else
                {
                    MessageBox.Show("Select course credit7");
                    numCredit7.Focus();
                    numCredit7.Select();
                }
            }
        }

        private void numObtainedGPA7_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Return")
            {
                if (Convert.ToDecimal(numObtainedGPA7.Value) != -1)
                {
                    txtCode8.Focus();
                    txtCode8.Select();
                }
                else
                {
                    MessageBox.Show("Select obtained gpa7");
                    numObtainedGPA7.Focus();
                    numObtainedGPA7.Select();
                }
            }
        }

        private void txtCode8_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Return")
            {
                if (txtCode8.Text.Trim().ToString() != "")
                {
                    numCredit8.Focus();
                    numCredit8.Select();
                }
                else
                {
                    MessageBox.Show("Select course code8");
                    txtCode8.Focus();
                    txtCode8.Select();
                }
            }
        }

        private void numCredit8_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Return")
            {
                decimal credit1 = Convert.ToDecimal(numCredit1.Value);
                decimal credit2 = Convert.ToDecimal(numCredit2.Value);
                decimal credit3 = Convert.ToDecimal(numCredit3.Value);
                decimal credit4 = Convert.ToDecimal(numCredit4.Value);
                decimal credit5 = Convert.ToDecimal(numCredit5.Value);
                decimal credit6 = Convert.ToDecimal(numCredit6.Value);
                decimal credit7 = Convert.ToDecimal(numCredit7.Value);
                decimal credit8 = Convert.ToDecimal(numCredit8.Value);
                decimal obtainGPA1 = Convert.ToDecimal(numObtainedGPA1.Value);
                decimal obtainGPA2 = Convert.ToDecimal(numObtainedGPA2.Value);
                decimal obtainGPA3 = Convert.ToDecimal(numObtainedGPA3.Value);
                decimal obtainGPA4 = Convert.ToDecimal(numObtainedGPA4.Value);
                decimal obtainGPA5 = Convert.ToDecimal(numObtainedGPA5.Value);
                decimal obtainGPA6 = Convert.ToDecimal(numObtainedGPA6.Value);
                decimal obtainGPA7 = Convert.ToDecimal(numObtainedGPA7.Value);
                decimal obtainGPA8 = Convert.ToDecimal(numObtainGPA8.Value);
                decimal SGPA = (((credit1 * obtainGPA1) + (credit2 * obtainGPA2) + (credit3 * obtainGPA3) + (credit4 * obtainGPA4) + (credit5 * obtainGPA5) + (credit6 * obtainGPA6) + (credit7 * obtainGPA7) + (credit8 * obtainGPA8)) / (credit1 + credit2 + credit3 + credit4 + credit5 + credit6 + credit7 + credit8));
                txtSGPA.Text = SGPA.ToString();
                txtSGPA.Focus();
                txtSGPA.Select();
            }
        }

        private void txtSGPA_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Return")
            {
                if (txtSGPA.Text.Trim().ToString() != "")
                {
                    btnSave.Focus();
                    btnSave.Select();
                }
                else
                {
                    MessageBox.Show("Select course code8");
                    txtSGPA.Focus();
                    txtSGPA.Select();
                }
            }
        }

        private void comSearchStudentID_Click(object sender, EventArgs e)
        {

                    string StudentId = comSearchStudentID.Text.Trim().ToString();
                    sql = @"SELECT     StudentResultID, Semister, StudentId, StudentName, Program, Batch, RegNo, Campus, Code1, GPA1, ObtainedGPA1, Code2, GPA2, ObtainedGPA2, Code3, GPA3, 
                      ObtainedGPA3, Code4, GPA4, ObtainedGPA4, Code5, GPA5, ObtainedGPA5, Code6, GPA6, ObtainedGPA6, Code7, GPA7, ObtainedGPA7, Code8, GPA8, ObtainedGPA8, 
                      SGPA
FROM         dbo.Tbl_StudentResult
WHERE     (StudentId = '" + StudentId + "')";
                    dt = DAL.GetData(sql);
                    dataGridView1.DataSource = dt;
                
            
        }
    }
}
