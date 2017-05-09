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
    public partial class FrmWaver : Form
    {
        DataAccessLayer DAL = new DataAccessLayer();
        DataProcessLayer DPL = new DataProcessLayer();
        public FrmWaver()
        {
            InitializeComponent();
            CMBFILL();
        }
        private void CMBFILL()
        {
            sql = @"SELECT     WaverID, StudentId
FROM         dbo.Tbl_Waver";
            dt = DAL.GetData(sql);
            comSearchStudentID.DataSource = dt;
            comSearchStudentID.DisplayMember = "StudentId";
            comSearchStudentID.ValueMember = "WaverID";
            comSearchStudentID.SelectedIndex = -1;

            sql = @"SELECT     StudentAdmissionID, StudentId, StudentName, Program, Department
FROM         dbo.Tbl_StudentAdmission";
            dt = DAL.GetData(sql);
            cmbStudentID.DataSource = dt;
            cmbStudentID.DisplayMember = "StudentId";
            cmbStudentID.ValueMember = "StudentAdmissionID";
            cmbStudentID.SelectedIndex = -1;
            cmbStudentName.DataSource = dt;
            cmbStudentName.DisplayMember = "StudentName";
            cmbStudentName.ValueMember = "StudentAdmissionID";
            cmbProgram.DataSource = dt;
            cmbProgram.DisplayMember = "Program";
            cmbProgram.ValueMember = "StudentAdmissionID";
            cmbDepartment.DataSource = dt;
            cmbDepartment.DisplayMember = "Department";
            cmbDepartment.ValueMember = "StudentAdmissionID";


            sql = @"SELECT     StudentRegistrationID, StudentId, Batch, RegNo, Campus
FROM         dbo.Tbl_StudentRegistration";
            dt = DAL.GetData(sql);
            cmbStudentID.DataSource = dt;
            cmbStudentID.DisplayMember = "StudentId";
            cmbStudentID.ValueMember = "StudentRegistrationID";
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
        int WaverID = 0;
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
                    cmbStudentName.Focus();
                    cmbStudentName.Select();
                }
                else
                {
                    MessageBox.Show("Select student id");
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

        private void cmbStudentName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Return")
            {
                if (cmbStudentID.Text.Trim().ToString() != "")
                {
                    cmbProgram.Focus();
                    cmbProgram.Select();
                }
                else
                {
                    MessageBox.Show("Select student name");
                    cmbStudentName.Focus();
                    cmbStudentName.Select();
                }
            }
        }

        private void cmbStudentName_Enter(object sender, EventArgs e)
        {
            cmbStudentName.ForeColor = Color.White;
            cmbStudentName.BackColor = Color.CadetBlue;
        }

        private void cmbStudentName_Leave(object sender, EventArgs e)
        {
            cmbStudentName.ForeColor = Color.Black;
            cmbStudentName.BackColor = Color.White;
        }

        private void cmbProgram_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Return")
            {
                if (cmbProgram.Text.Trim().ToString() != "")
                {
                    cmbBatch.Focus();
                    cmbBatch.Select();
                }
                else
                {
                    MessageBox.Show("Select program");
                    cmbProgram.Focus();
                    cmbProgram.Select();
                }
            }
        }

        private void cmbProgram_Enter(object sender, EventArgs e)
        {
            cmbProgram.ForeColor = Color.White;
            cmbProgram.BackColor = Color.CadetBlue;
        }

        private void cmbProgram_Leave(object sender, EventArgs e)
        {
            cmbProgram.ForeColor = Color.Black;
            cmbProgram.BackColor = Color.White;
        }

        private void cmbBatch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Return")
            {
                if (cmbBatch.Text.Trim().ToString() != "")
                {
                    cmbRegNo.Focus();
                    cmbRegNo.Select();
                }
                else
                {
                    MessageBox.Show("Select batch");
                    cmbBatch.Focus();
                    cmbBatch.Select();
                }
            }
        }

        private void cmbBatch_Enter(object sender, EventArgs e)
        {
            cmbBatch.ForeColor = Color.White;
            cmbBatch.BackColor = Color.CadetBlue;
        }

        private void cmbBatch_Leave(object sender, EventArgs e)
        {
            cmbBatch.ForeColor = Color.Black;
            cmbBatch.BackColor = Color.White;
        }

        private void cmbRegNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Return")
            {
                if (cmbRegNo.Text.Trim().ToString() != "")
                {
                    cmbDepartment.Focus();
                    cmbDepartment.Select();
                }
                else
                {
                    MessageBox.Show("Select Semister");
                    cmbRegNo.Focus();
                    cmbRegNo.Select();
                }
            }
        }

        private void cmbRegNo_Enter(object sender, EventArgs e)
        {
            cmbRegNo.ForeColor = Color.White;
            cmbRegNo.BackColor = Color.CadetBlue;
        }

        private void cmbRegNo_Leave(object sender, EventArgs e)
        {
            cmbRegNo.ForeColor = Color.Black;
            cmbRegNo.BackColor = Color.White;
        }

        private void cmbDepartment_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Return")
            {
                if (cmbDepartment.Text.Trim().ToString() != "")
                {
                    cmbCampus.Focus();
                    cmbCampus.Select();
                }
                else
                {
                    MessageBox.Show("Select campus");
                    cmbDepartment.Focus();
                    cmbDepartment.Select();
                }
            }
        }

        private void cmbDepartment_Enter(object sender, EventArgs e)
        {
            cmbDepartment.ForeColor = Color.White;
            cmbDepartment.BackColor = Color.CadetBlue;
        }

        private void cmbDepartment_Leave(object sender, EventArgs e)
        {
            cmbDepartment.ForeColor = Color.Black;
            cmbDepartment.BackColor = Color.White;
        }

        private void cmbCampus_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Return")
            {
                if (cmbCampus.Text.Trim().ToString() != "")
                {
                    numTuitionFee.Focus();
                    numTuitionFee.Select();
                }
                else
                {
                    MessageBox.Show("Select campus");
                    cmbCampus.Focus();
                    cmbCampus.Select();
                }
            }
        }

        private void cmbCampus_Enter(object sender, EventArgs e)
        {
            cmbCampus.ForeColor = Color.White;
            cmbCampus.BackColor = Color.CadetBlue;
        }

        private void cmbCampus_Leave(object sender, EventArgs e)
        {
            cmbCampus.ForeColor = Color.Black;
            cmbCampus.BackColor = Color.White;
        }

        private void numTuitionFee_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Return")
            {
                if (Convert.ToDecimal(numTuitionFee.Value) != 0)
                {
                    txtSSCresult.Focus();
                    txtSSCresult.Select();
                }
                else
                {
                    MessageBox.Show("Select campus");
                    numTuitionFee.Focus();
                    numTuitionFee.Select();
                }
            }
        }

        private void numTuitionFee_Enter(object sender, EventArgs e)
        {
            numTuitionFee.ForeColor = Color.White;
            numTuitionFee.BackColor = Color.CadetBlue;
        }

        private void numTuitionFee_Leave(object sender, EventArgs e)
        {
            numTuitionFee.ForeColor = Color.Black;
            numTuitionFee.BackColor = Color.White;
        }

        private void txtSSCresult_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Return")
            {
                if (txtSSCresult.Text.Trim().ToString() != "")
                {
                    txtHSCresult.Focus();
                    txtHSCresult.Select();
                }
                else
                {
                    MessageBox.Show("Select campus");
                    txtSSCresult.Focus();
                    txtSSCresult.Select();
                }
            }
        }

        private void txtSSCresult_Enter(object sender, EventArgs e)
        {
            txtSSCresult.ForeColor = Color.White;
            txtSSCresult.BackColor = Color.CadetBlue;
        }

        private void txtSSCresult_Leave(object sender, EventArgs e)
        {
            txtSSCresult.ForeColor = Color.Black;
            txtSSCresult.BackColor = Color.White;
        }

        private void txtHSCresult_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Return")
            {
                if (cmbCampus.Text.Trim().ToString() != "")
                {
                    numWaver.Focus();
                    numWaver.Select();
                }
                else
                {
                    MessageBox.Show("Select campus");
                    txtHSCresult.Focus();
                    txtHSCresult.Select();
                }
            }
        }

        private void txtHSCresult_Enter(object sender, EventArgs e)
        {
            txtHSCresult.ForeColor = Color.White;
            txtHSCresult.BackColor = Color.CadetBlue;
        }

        private void txtHSCresult_Leave(object sender, EventArgs e)
        {
            txtHSCresult.ForeColor = Color.Black;
            txtHSCresult.BackColor = Color.White;
        }

        private void numWaver_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Return")
            {
                decimal tuition = Convert.ToDecimal(numTuitionFee.Value);
                decimal waver = Convert.ToDecimal(numWaver.Value);
                decimal total = (tuition - ((tuition * waver) / 100));
                txtObtainedFee.Text = total.ToString();
                txtObtainedFee.Focus();
                txtObtainedFee.Select();
            }
        }

        private void numWaver_Enter(object sender, EventArgs e)
        {
            numWaver.ForeColor = Color.White;
            numWaver.BackColor = Color.CadetBlue;
        }

        private void numWaver_Leave(object sender, EventArgs e)
        {
            numWaver.ForeColor = Color.Black;
            numWaver.BackColor = Color.White;
        }

        private void txtObtainedFee_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Return")
            {
                if (txtObtainedFee.Text.Trim().ToString() != "")
                {
                    btnSave.Focus();
                    btnSave.Select();
                }
                else
                {
                    MessageBox.Show("Select campus");
                    txtObtainedFee.Focus();
                    txtObtainedFee.Select();
                }
            }
        }

        private void txtObtainedFee_Enter(object sender, EventArgs e)
        {
            txtObtainedFee.ForeColor = Color.White;
            txtObtainedFee.BackColor = Color.CadetBlue;
        }

        private void txtObtainedFee_Leave(object sender, EventArgs e)
        {
            txtObtainedFee.ForeColor = Color.Black;
            txtObtainedFee.BackColor = Color.White;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string StudentName = cmbStudentName.Text.Trim().ToString();
            string StudentId = cmbStudentID.Text.Trim().ToString();
            string Program = cmbProgram.Text.Trim().ToString();
            string Batch = cmbBatch.Text.Trim().ToString();
            string RegNo = cmbRegNo.Text.Trim().ToString();
            string Department = cmbDepartment.Text.Trim().ToString();
            string Campus = cmbCampus.Text.Trim().ToString();
            decimal TuitionFee = Convert.ToDecimal(numTuitionFee.Value);
            string SSCresult = txtSSCresult.Text.Trim().ToString();
            string HSCresult = txtHSCresult.Text.Trim().ToString();
            decimal Waver = Convert.ToInt32(numWaver.Value);
            string ObtainedFee = txtObtainedFee.Text;
            save = DPL.Save_Tbl_Waver(StudentName, StudentId, Program, Batch, RegNo, Department, Campus, TuitionFee, SSCresult, HSCresult, Waver, ObtainedFee);
            //save = DPL.Save_Tbl_Waver(StudentName,StudentId,Program,Batch,RegNo,Department,Campus,TuitionFee,SSCresult,HSCresult,Waver,ObtainedFee);
            //            save = DPL.Save_Table_StudentInfo(Male_Female, Date, StudentName, Address, Program, Department, Batch, StudentId, RegNo, Mobile);
            if (save == "Succeded")
            {
                sql = @"SELECT     WaverID, StudentName, StudentId, Program, Batch, RegNo, Department, Campus, TuitionFee, SSCresult, HSCresult, Waver, 
                      ObtainedFee AS [(tuition - ((tuition * waver)/100))]
FROM         dbo.Tbl_Waver
WHERE     (StudentId = '" + StudentId + "')";
                dt = DAL.GetData(sql);
                dataGridView1.DataSource = dt;
                MessageBox.Show("Succeded");
            }
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            cmbStudentName.Text = "";
            cmbStudentID.Text = "";
            cmbProgram.Text = "";
            cmbBatch.Text = "";
            cmbRegNo.Text = "";
            cmbDepartment.Text = "";
            cmbCampus.Text = "";
            numTuitionFee.Text = "";
            txtSSCresult.Text = "";
            txtHSCresult.Text = "";
            numWaver.Text = "";
            txtObtainedFee.Text = "";
            dataGridView1.DataSource = null;
        }

        private void comSearchStudentID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Return")
            {
                if (comSearchStudentID.Text.Trim().ToString() != "")
                {
                    string StudentId = comSearchStudentID.Text.Trim().ToString();
                    sql = @"SELECT     WaverID, StudentName, StudentId, Program, Batch, RegNo, Department, Campus, TuitionFee, SSCresult, HSCresult, Waver, 
                      ObtainedFee AS [(tuition - ((tuition * waver)/100))]
FROM         dbo.Tbl_Waver
WHERE     (StudentId = '" + StudentId + "')";
                    dt = DAL.GetData(sql);
                    dataGridView1.DataSource = dt;
                }
            }
        }
    }
}
