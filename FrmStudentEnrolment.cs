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
    public partial class FrmStudentEnrolment : Form
    {
        DataAccessLayer DAL = new DataAccessLayer();
        DataProcessLayer DPL = new DataProcessLayer();
        public FrmStudentEnrolment()
        {
            InitializeComponent();
            CMBFILL();
            cmbStudentID.Focus();
            cmbStudentID.Select();
        }
        private void CMBFILL()
        {
            sql = @"SELECT     StudentEnrolmentID, StudentId
FROM         dbo.Tbl_StudentEnrolment";
            dt = DAL.GetData(sql);
            comSearchStudentID.DataSource = dt;
            comSearchStudentID.DisplayMember = "StudentId";
            comSearchStudentID.ValueMember = "StudentEnrolmentID";
            comSearchStudentID.SelectedIndex = -1;

            sql = @"SELECT     StudentAdmissionID, Semister, StudentId, StudentName, Department, Program
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
            cmbDepartment.DataSource = dt;
            cmbDepartment.DisplayMember = "Department";
            cmbDepartment.ValueMember = "StudentAdmissionID";
            cmbProgram.DataSource = dt;
            cmbProgram.DisplayMember = "Program";
            cmbProgram.ValueMember = "StudentAdmissionID";

            sql = @"SELECT     StudentRegistrationID, StudentId, Program, Batch, RegNo, Campus
FROM         dbo.Tbl_StudentRegistration";
            dt = DAL.GetData(sql);
            cmbStudentID.DataSource = dt;
            cmbStudentID.DisplayMember = "StudentId";
            cmbStudentID.ValueMember = "StudentRegistrationID";
            cmbStudentID.SelectedIndex = -1;
            cmbProgram.DataSource = dt;
            cmbProgram.DisplayMember = "Program";
            cmbProgram.ValueMember = "StudentRegistrationID";
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
        int StudentEnrolmentID = 0;
        DataTable dt = null;
        # endregion
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void txtCourseCode1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Return")
            {
                if (txtCourseCode1.Text.Trim().ToString() != "")
                {
                    txtCourseTitle1.Focus();
                    txtCourseTitle1.Select();
                }
                else
                {
                    MessageBox.Show("Select course code");
                    txtCourseCode1.Focus();
                    txtCourseCode1.Select();
                }
            }
        }

        private void txtCourseCode1_Enter(object sender, EventArgs e)
        {
            txtCourseCode1.ForeColor = Color.White;
            txtCourseCode1.BackColor = Color.CadetBlue;
        }

        private void txtCourseCode1_Leave(object sender, EventArgs e)
        {
            txtCourseCode1.ForeColor = Color.Black;
            txtCourseCode1.BackColor = Color.White;
        }

        private void txtCourseTitle1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Return")
            {
                if (txtCourseTitle1.Text.Trim().ToString() != "")
                {
                    txtCredit1.Focus();
                    txtCredit1.Select();
                }
                else
                {
                    MessageBox.Show("Select course title");
                    txtCourseTitle1.Focus();
                    txtCourseTitle1.Select();
                }
            }
        }

        private void txtCourseTitle1_Enter(object sender, EventArgs e)
        {
            txtCourseTitle1.ForeColor = Color.White;
            txtCourseTitle1.BackColor = Color.CadetBlue;
        }

        private void txtCourseTitle1_Leave(object sender, EventArgs e)
        {
            txtCourseTitle1.ForeColor = Color.Black;
            txtCourseTitle1.BackColor = Color.White;
        }

        private void txtCredit1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Return")
            {
                if (txtCredit1.Text.Trim().ToString() != "")
                {
                    txtCourseCode2.Focus();
                    txtCourseCode2.Select();
                }
                else
                {
                    MessageBox.Show("Select credit");
                    txtCredit1.Focus();
                    txtCredit1.Select();
                }
            }
        }

        private void txtCredit1_Enter(object sender, EventArgs e)
        {
            txtCredit1.ForeColor = Color.White;
            txtCredit1.BackColor = Color.CadetBlue;
        }

        private void txtCredit1_Leave(object sender, EventArgs e)
        {
            txtCredit1.ForeColor = Color.Black;
            txtCredit1.BackColor = Color.White;
        }

        private void txtCourseCode2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Return")
            {
                if (txtCourseCode2.Text.Trim().ToString() != "")
                {
                    txtCourseTitle2.Focus();
                    txtCourseTitle2.Select();
                }
                else
                {
                    MessageBox.Show("Select course code");
                    txtCourseCode2.Focus();
                    txtCourseCode2.Select();
                }
            }
        }

        private void txtCourseCode2_Enter(object sender, EventArgs e)
        {
            txtCourseCode2.ForeColor = Color.White;
            txtCourseCode2.BackColor = Color.CadetBlue;
        }

        private void txtCourseCode2_Leave(object sender, EventArgs e)
        {
            txtCourseCode2.ForeColor = Color.Black;
            txtCourseCode2.BackColor = Color.White;
        }

        private void txtCourseTitle2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Return")
            {
                if (txtCourseTitle2.Text.Trim().ToString() != "")
                {
                    txtCredit2.Focus();
                    txtCredit2.Select();
                }
                else
                {
                    MessageBox.Show("Select course title");
                    txtCourseTitle2.Focus();
                    txtCourseTitle2.Select();
                }
            }
        }

        private void txtCourseTitle2_Enter(object sender, EventArgs e)
        {
            txtCourseTitle2.ForeColor = Color.White;
            txtCourseTitle2.BackColor = Color.CadetBlue;
        }

        private void txtCourseTitle2_Leave(object sender, EventArgs e)
        {
            txtCourseTitle2.ForeColor = Color.Black;
            txtCourseTitle2.BackColor = Color.White;
        }

        private void txtCredit2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Return")
            {
                if (txtCredit2.Text.Trim().ToString() != "")
                {
                    txtCourseCode3.Focus();
                    txtCourseCode3.Select();
                }
                else
                {
                    MessageBox.Show("Select credit");
                    txtCredit2.Focus();
                    txtCredit2.Select();
                }
            }
        }

        private void txtCredit2_Enter(object sender, EventArgs e)
        {
            txtCredit2.ForeColor = Color.White;
            txtCredit2.BackColor = Color.CadetBlue;
        }

        private void txtCredit2_Leave(object sender, EventArgs e)
        {
            txtCredit2.ForeColor = Color.Black;
            txtCredit2.BackColor = Color.White;
        }

        private void txtCourseCode3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Return")
            {
                if (txtCourseCode3.Text.Trim().ToString() != "")
                {
                    txtCourseTitle3.Focus();
                    txtCourseTitle3.Select();
                }
                else
                {
                    MessageBox.Show("Select course code");
                    txtCourseCode3.Focus();
                    txtCourseCode3.Select();
                }
            }
        }

        private void txtCourseCode3_Enter(object sender, EventArgs e)
        {
            txtCourseCode3.ForeColor = Color.White;
            txtCourseCode3.BackColor = Color.CadetBlue;
        }

        private void txtCourseCode3_Leave(object sender, EventArgs e)
        {
            txtCourseCode3.ForeColor = Color.Black;
            txtCourseCode3.BackColor = Color.White;
        }

        private void txtCourseTitle3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Return")
            {
                if (txtCourseTitle3.Text.Trim().ToString() != "")
                {
                    txtCredit3.Focus();
                    txtCredit3.Select();
                }
                else
                {
                    MessageBox.Show("Select course title");
                    txtCourseTitle3.Focus();
                    txtCourseTitle3.Select();
                }
            }
        }

        private void txtCourseTitle3_Enter(object sender, EventArgs e)
        {
            txtCourseTitle3.ForeColor = Color.White;
            txtCourseTitle3.BackColor = Color.CadetBlue;
        }

        private void txtCourseTitle3_Leave(object sender, EventArgs e)
        {
            txtCourseTitle3.ForeColor = Color.Black;
            txtCourseTitle3.BackColor = Color.White;
        }

        private void txtCredit3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Return")
            {
                if (txtCredit3.Text.Trim().ToString() != "")
                {
                    txtCourseCode4.Focus();
                    txtCourseCode4.Select();
                }
                else
                {
                    MessageBox.Show("Select credit");
                    txtCredit3.Focus();
                    txtCredit3.Select();
                }
            }
        }

        private void txtCredit3_Enter(object sender, EventArgs e)
        {
            txtCredit3.ForeColor = Color.White;
            txtCredit3.BackColor = Color.CadetBlue;
        }

        private void txtCredit3_Leave(object sender, EventArgs e)
        {
            txtCredit3.ForeColor = Color.Black;
            txtCredit3.BackColor = Color.White;
        }

        private void txtCourseCode4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Return")
            {
                if (txtCourseCode4.Text.Trim().ToString() != "")
                {
                    txtCourseTitle4.Focus();
                    txtCourseTitle4.Select();
                }
                else
                {
                    MessageBox.Show("Select course code");
                    txtCourseCode4.Focus();
                    txtCourseCode4.Select();
                }
            }
        }

        private void txtCourseCode4_Enter(object sender, EventArgs e)
        {
            txtCourseCode4.ForeColor = Color.White;
            txtCourseCode4.BackColor = Color.CadetBlue;
        }

        private void txtCourseCode4_Leave(object sender, EventArgs e)
        {
            txtCourseCode4.ForeColor = Color.Black;
            txtCourseCode4.BackColor = Color.White;
        }

        private void txtCourseTitle4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Return")
            {
                if (txtCourseTitle4.Text.Trim().ToString() != "")
                {
                    txtCredit4.Focus();
                    txtCredit4.Select();
                }
                else
                {
                    MessageBox.Show("Select course title");
                    txtCourseTitle4.Focus();
                    txtCourseTitle4.Select();
                }
            }
        }

        private void txtCourseTitle4_Enter(object sender, EventArgs e)
        {
            txtCourseTitle4.ForeColor = Color.White;
            txtCourseTitle4.BackColor = Color.CadetBlue;
        }

        private void txtCourseTitle4_Leave(object sender, EventArgs e)
        {
            txtCourseTitle4.ForeColor = Color.Black;
            txtCourseTitle4.BackColor = Color.White;
        }

        private void txtCredit4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Return")
            {
                if (txtCredit4.Text.Trim().ToString() != "")
                {
                    txtCourseCode5.Focus();
                    txtCourseCode5.Select();
                }
                else
                {
                    MessageBox.Show("Select credit");
                    txtCredit4.Focus();
                    txtCredit4.Select();
                }
            }
        }

        private void txtCredit4_Enter(object sender, EventArgs e)
        {
            txtCredit4.ForeColor = Color.White;
            txtCredit4.BackColor = Color.CadetBlue;
        }

        private void txtCredit4_Leave(object sender, EventArgs e)
        {
            txtCredit4.ForeColor = Color.Black;
            txtCredit4.BackColor = Color.White;
        }

        private void txtCourseCode5_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Return")
            {
                if (txtCourseCode5.Text.Trim().ToString() != "")
                {
                    txtCourseTitle5.Focus();
                    txtCourseTitle5.Select();
                }
                else
                {
                    MessageBox.Show("Select course code");
                    txtCourseCode5.Focus();
                    txtCourseCode5.Select();
                }
            }
        }

        private void txtCourseCode5_Enter(object sender, EventArgs e)
        {
            txtCourseCode5.ForeColor = Color.White;
            txtCourseCode5.BackColor = Color.CadetBlue;
        }

        private void txtCourseCode5_Leave(object sender, EventArgs e)
        {
            txtCourseCode5.ForeColor = Color.Black;
            txtCourseCode5.BackColor = Color.White;
        }

        private void txtCourseTitle5_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Return")
            {
                if (txtCourseTitle5.Text.Trim().ToString() != "")
                {
                    txtCredit5.Focus();
                    txtCredit5.Select();
                }
                else
                {
                    MessageBox.Show("Select course titile");
                    txtCourseTitle5.Focus();
                    txtCourseTitle5.Select();
                }
            }
        }

        private void txtCourseTitle5_Enter(object sender, EventArgs e)
        {
            txtCourseTitle5.ForeColor = Color.White;
            txtCourseTitle5.BackColor = Color.CadetBlue;
        }

        private void txtCourseTitle5_Leave(object sender, EventArgs e)
        {
            txtCourseTitle5.ForeColor = Color.Black;
            txtCourseTitle5.BackColor = Color.White;
        }

        private void txtCredit5_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Return")
            {
                if (txtCredit5.Text.Trim().ToString() != "")
                {
                    txtCourseCode6.Focus();
                    txtCourseCode6.Select();
                }
                else
                {
                    MessageBox.Show("Select credit");
                    txtCredit5.Focus();
                    txtCredit5.Select();
                }
            }
        }

        private void txtCredit5_Enter(object sender, EventArgs e)
        {
            txtCredit5.ForeColor = Color.White;
            txtCredit5.BackColor = Color.CadetBlue;
        }

        private void txtCredit5_Leave(object sender, EventArgs e)
        {
            txtCredit5.ForeColor = Color.Black;
            txtCredit5.BackColor = Color.White;
        }

        private void txtCourseCode6_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Return")
            {
                if (txtCourseCode6.Text.Trim().ToString() != "")
                {
                    txtCourseTitle6.Focus();
                    txtCourseTitle6.Select();
                }
                else
                {
                    MessageBox.Show("Select course code");
                    txtCourseCode6.Focus();
                    txtCourseCode6.Select();
                }
            }
        }

        private void txtCourseCode6_Enter(object sender, EventArgs e)
        {
            txtCourseCode6.ForeColor = Color.White;
            txtCourseCode6.BackColor = Color.CadetBlue;
        }

        private void txtCourseCode6_Leave(object sender, EventArgs e)
        {
            txtCourseCode6.ForeColor = Color.Black;
            txtCourseCode6.BackColor = Color.White;
        }

        private void txtCourseTitle6_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Return")
            {
                if (txtCourseTitle6.Text.Trim().ToString() != "")
                {
                    txtCredit6.Focus();
                    txtCredit6.Select();
                }
                else
                {
                    MessageBox.Show("Select course title");
                    txtCourseTitle6.Focus();
                    txtCourseTitle6.Select();
                }
            }
        }

        private void txtCourseTitle6_Enter(object sender, EventArgs e)
        {
            txtCourseTitle6.ForeColor = Color.White;
            txtCourseTitle6.BackColor = Color.CadetBlue;
        }

        private void txtCourseTitle6_Leave(object sender, EventArgs e)
        {
            txtCourseTitle6.ForeColor = Color.Black;
            txtCourseTitle6.BackColor = Color.White;
        }

        private void txtCredit6_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Return")
            {
                if (txtCredit6.Text.Trim().ToString() != "")
                {
                    txtCourseCodeRetake1.Focus();
                    txtCourseCodeRetake1.Select();
                }
                else
                {
                    MessageBox.Show("Select credit");
                    txtCredit6.Focus();
                    txtCredit6.Select();
                }
            }
        }

        private void txtCredit6_Enter(object sender, EventArgs e)
        {
            txtCredit6.ForeColor = Color.White;
            txtCredit6.BackColor = Color.CadetBlue;
        }

        private void txtCredit6_Leave(object sender, EventArgs e)
        {
            txtCredit6.ForeColor = Color.Black;
            txtCredit6.BackColor = Color.White;
        }

        private void txtCourseCodeRetake1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Return")
            {
                if (txtCourseCodeRetake1.Text.Trim().ToString() != "")
                {
                    txtCourseTitleRetake1.Focus();
                    txtCourseTitleRetake1.Select();
                }
                else
                {
                    MessageBox.Show("Select retake course code");
                    txtCourseCodeRetake1.Focus();
                    txtCourseCodeRetake1.Select();
                }
            }
        }

        private void txtCourseCodeRetake1_Enter(object sender, EventArgs e)
        {
            txtCourseCodeRetake1.ForeColor = Color.White;
            txtCourseCodeRetake1.BackColor = Color.CadetBlue;
        }

        private void txtCourseCodeRetake1_Leave(object sender, EventArgs e)
        {
            txtCourseCodeRetake1.ForeColor = Color.Black;
            txtCourseCodeRetake1.BackColor = Color.White;
        }

        private void txtCourseTitleRetake1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Return")
            {
                if (txtCourseTitleRetake1.Text.Trim().ToString() != "")
                {
                    txtCreditRetake1.Focus();
                    txtCreditRetake1.Select();
                }
                else
                {
                    MessageBox.Show("Select retake course title");
                    txtCourseTitleRetake1.Focus();
                    txtCourseTitleRetake1.Select();
                }
            }
        }

        private void txtCourseTitleRetake1_Enter(object sender, EventArgs e)
        {
            txtCourseTitleRetake1.ForeColor = Color.White;
            txtCourseTitleRetake1.BackColor = Color.CadetBlue;
        }

        private void txtCourseTitleRetake1_Leave(object sender, EventArgs e)
        {
            txtCourseTitleRetake1.ForeColor = Color.Black;
            txtCourseTitleRetake1.BackColor = Color.White;
        }

        private void txtCreditRetake1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Return")
            {
                if (txtCreditRetake1.Text.Trim().ToString() != "")
                {
                    txtCourseCodeRetake2.Focus();
                    txtCourseCodeRetake2.Select();
                }
                else
                {
                    MessageBox.Show("Select retake credit");
                    txtCreditRetake1.Focus();
                    txtCreditRetake1.Select();
                }
            }
        }

        private void txtCreditRetake1_Enter(object sender, EventArgs e)
        {
            txtCreditRetake1.ForeColor = Color.White;
            txtCreditRetake1.BackColor = Color.CadetBlue;
        }

        private void txtCreditRetake1_Leave(object sender, EventArgs e)
        {
            txtCreditRetake1.ForeColor = Color.Black;
            txtCreditRetake1.BackColor = Color.White;
        }

        private void txtCourseCodeRetake2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Return")
            {
                if (txtCourseCodeRetake2.Text.Trim().ToString() != "")
                {
                    txtCourseTitleRetake2.Focus();
                    txtCourseTitleRetake2.Select();
                }
                else
                {
                    MessageBox.Show("Select retake course code");
                    txtCourseCodeRetake2.Focus();
                    txtCourseCodeRetake2.Select();
                }
            }
        }

        private void txtCourseCodeRetake2_Enter(object sender, EventArgs e)
        {
            txtCourseCodeRetake2.ForeColor = Color.White;
            txtCourseCodeRetake2.BackColor = Color.CadetBlue;
        }

        private void txtCourseCodeRetake2_Leave(object sender, EventArgs e)
        {
            txtCourseCodeRetake2.ForeColor = Color.Black;
            txtCourseCodeRetake2.BackColor = Color.White;
        }

        private void txtCourseTitleRetake2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Return")
            {
                if (txtCourseTitleRetake2.Text.Trim().ToString() != "")
                {
                    txtCreditRetake2.Focus();
                    txtCreditRetake2.Select();
                }
                else
                {
                    MessageBox.Show("Select retake course title");
                    txtCourseTitleRetake2.Focus();
                    txtCourseTitleRetake2.Select();
                }
            }
        }

        private void txtCourseTitleRetake2_Enter(object sender, EventArgs e)
        {
            txtCourseTitleRetake2.ForeColor = Color.White;
            txtCourseTitleRetake2.BackColor = Color.CadetBlue;
        }

        private void txtCourseTitleRetake2_Leave(object sender, EventArgs e)
        {
            txtCourseTitleRetake2.ForeColor = Color.Black;
            txtCourseTitleRetake2.BackColor = Color.White;
        }

        private void txtCreditRetake2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Return")
            {
                if (txtCreditRetake2.Text.Trim().ToString() != "")
                {
                    txtRegisterSign.Focus();
                    txtRegisterSign.Select();
                }
                else
                {
                    MessageBox.Show("Select credit");
                    txtCreditRetake2.Focus();
                    txtCreditRetake2.Select();
                }
            }
        }

        private void txtCreditRetake2_Enter(object sender, EventArgs e)
        {
            txtCreditRetake2.ForeColor = Color.White;
            txtCreditRetake2.BackColor = Color.CadetBlue;
        }

        private void txtCreditRetake2_Leave(object sender, EventArgs e)
        {
            txtCreditRetake2.ForeColor = Color.Black;
            txtCreditRetake2.BackColor = Color.White;
        }

        private void txtRegisterSign_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Return")
            {
                if (txtRegisterSign.Text.Trim().ToString() != "")
                {
                    txtChairmanSign.Focus();
                    txtChairmanSign.Select();
                }
                else
                {
                    MessageBox.Show("Select credit");
                    txtRegisterSign.Focus();
                    txtRegisterSign.Select();
                }
            }
        }

        private void txtRegisterSign_Enter(object sender, EventArgs e)
        {
            txtRegisterSign.ForeColor = Color.White;
            txtRegisterSign.BackColor = Color.CadetBlue;
        }

        private void txtRegisterSign_Leave(object sender, EventArgs e)
        {
            txtRegisterSign.ForeColor = Color.Black;
            txtRegisterSign.BackColor = Color.White;
        }

        private void txtChairmanSign_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Return")
            {
                if (txtChairmanSign.Text.Trim().ToString() != "")
                {
                    btnSave.Focus();
                    btnSave.Select();
                }
                else
                {
                    MessageBox.Show("Select chairman sign");
                    txtChairmanSign.Focus();
                    txtChairmanSign.Select();
                }
            }
        }

        private void txtChairmanSign_Enter(object sender, EventArgs e)
        {
            txtChairmanSign.ForeColor = Color.White;
            txtChairmanSign.BackColor = Color.CadetBlue;
        }

        private void txtChairmanSign_Leave(object sender, EventArgs e)
        {
            txtChairmanSign.ForeColor = Color.Black;
            txtChairmanSign.BackColor = Color.White;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string Semister = cmbSemister.Text.Trim().ToString();
            string StudentId = cmbStudentID.Text.Trim().ToString();
            string StudentName = cmbStudentName.Text.Trim().ToString();
            string Department = cmbDepartment.Text.Trim().ToString();
            string Program = cmbProgram.Text.Trim().ToString();
            string Batch = cmbBatch.Text.Trim().ToString();
            string RegNo = cmbRegNo.Text.Trim().ToString();
            string Campus = cmbCampus.Text.Trim().ToString();
            string Code1 = txtCourseCode1.Text.Trim().ToString();
            string Title1 = txtCourseTitle1.Text.Trim().ToString();
            string Credit1 = txtCredit1.Text.Trim().ToString();
            string Code2 = txtCourseCode2.Text.Trim().ToString();
            string Title2 = txtCourseTitle2.Text.Trim().ToString();
            string Credit2 = txtCredit2.Text.Trim().ToString();
            string Code3 = txtCourseCode3.Text.Trim().ToString();
            string Title3 = txtCourseTitle3.Text.Trim().ToString();
            string Credit3 = txtCredit3.Text.Trim().ToString();
            string Code4 = txtCourseCode4.Text.Trim().ToString();
            string Title4 = txtCourseTitle4.Text.Trim().ToString();
            string Credit4 = txtCredit4.Text.Trim().ToString();
            string Code5 = txtCourseCode5.Text.Trim().ToString();
            string Title5 = txtCourseTitle5.Text.Trim().ToString();
            string Credit5 = txtCredit5.Text.Trim().ToString();
            string Code6 = txtCourseCode6.Text.Trim().ToString();
            string Title6 = txtCourseTitle6.Text.Trim().ToString();
            string Credit6 = txtCredit6.Text.Trim().ToString();
            string RetakeCode1 = txtCourseCodeRetake1.Text.Trim().ToString();
            string RetakeTitle1 = txtCourseTitleRetake1.Text.Trim().ToString();
            string RetakeCredit1 = txtCreditRetake1.Text.Trim().ToString();
            string RetakeCode2 = txtCourseCodeRetake2.Text.Trim().ToString();
            string RetakeTitle2 = txtCourseTitleRetake2.Text.Trim().ToString();
            string RetakeCredit2 = txtCreditRetake2.Text.Trim().ToString();
            string RegisterSign = txtRegisterSign.Text.Trim().ToString();
            string ChairpersonSign = txtChairmanSign.Text.Trim().ToString();
            //save = DPL.Save_Table_StudentEnrolment(AdmissionSemester, StudentId, StudentName, Department, Program, Batch, RegNo, Campus, CourseCode1, CourseTitle1, Credit1, CourseCode2, CourseTitle2, Credit2, CourseCode3, CourseTitle3, Credit3, CourseCode4, CourseTitle4, Credit4, CourseCode5, CourseTitle5, Credit5, CourseCode6, CourseTitle6, Credit6, RetakeCourseCode1, RetakeCourseTitle1, RetakeCredit1, RetakeCourseCode2, RetakeCourseTitle2, RetakeCredit2, RegisterSign, ChairpersonSign);
            save = DPL.Save_Tbl_StudentEnrolment(Semister, StudentId, StudentName, Department, Program, Batch, RegNo, Campus, Code1, Title1, Credit1, Code2, Title2, Credit2, Code3, Title3, Credit3, Code4, Title4, Credit4, Code5, Title5, Credit5, Code6, Title6, Credit6, RetakeCode1, RetakeTitle1, RetakeCredit1, RetakeCode2, RetakeTitle2, RetakeCredit2, RegisterSign, ChairpersonSign);
            if (save == "Succeded")
            {
                sql = @"SELECT     StudentEnrolmentID, Semister, StudentId, StudentName, Department, Program, Batch, RegNo, Campus, Code1, Title1, Credit1, Code2, Title2, Credit2, Code3, Title3, 
                      Credit3, Code4, Title4, Credit4, Code5, Title5, Credit5, Code6, Title6, Credit6, RetakeCode1, RetakeTitle1, RetakeCredit1, RetakeCode2, RetakeTitle2, RetakeCredit2, 
                      RegisterSign, ChairpersonSign
FROM         dbo.Tbl_StudentEnrolment
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
            cmbDepartment.Text = "";
            cmbProgram.Text = "";
            cmbBatch.Text = "";
            cmbRegNo.Text = "";
            cmbCampus.Text = "";
            txtCourseCode1.Text = "";
            txtCourseTitle1.Text = "";
            txtCredit1.Text = "";
            txtCourseCode2.Text = "";
            txtCourseTitle2.Text = "";
            txtCredit2.Text = "";
            txtCourseCode3.Text = "";
            txtCourseTitle3.Text = "";
            txtCredit3.Text = "";
            txtCourseCode4.Text = "";
            txtCourseTitle4.Text = "";
            txtCredit4.Text = "";
            txtCourseCode5.Text = "";
            txtCourseTitle5.Text = "";
            txtCredit5.Text = "";
            txtCourseCode6.Text = "";
            txtCourseTitle6.Text = "";
            txtCredit6.Text = "";
            txtCourseCodeRetake1.Text = "";
            txtCourseTitleRetake1.Text = "";
            txtCreditRetake1.Text = "";
            txtCourseCodeRetake2.Text = "";
            txtCourseTitleRetake2.Text = "";
            txtCreditRetake2.Text = "";
            txtRegisterSign.Text = "";
            txtChairmanSign.Text = "";
            dataGridView1.DataSource = null;
        }

        private void comSearchStudentID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Return")
            {
                if (comSearchStudentID.Text.Trim().ToString() != "")
                {
                    string StudentId = comSearchStudentID.Text.Trim().ToString();
                    sql = @"SELECT     StudentEnrolmentID, Semister, StudentId, StudentName, Department, Program, Batch, RegNo, Campus, Code1, Title1, Credit1, Code2, Title2, Credit2, Code3, Title3, 
                      Credit3, Code4, Title4, Credit4, Code5, Title5, Credit5, Code6, Title6, Credit6, RetakeCode1, RetakeTitle1, RetakeCredit1, RetakeCode2, RetakeTitle2, RetakeCredit2, 
                      RegisterSign, ChairpersonSign
FROM         dbo.Tbl_StudentEnrolment
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
                string Department = dataGridView1.Rows[rowindex].Cells["Department"].Value.ToString();
                string Program = dataGridView1.Rows[rowindex].Cells["Program"].Value.ToString();
                string Batch = dataGridView1.Rows[rowindex].Cells["Batch"].Value.ToString();
                string RegNo = dataGridView1.Rows[rowindex].Cells["RegNo"].Value.ToString();
                string Campus = dataGridView1.Rows[rowindex].Cells["Campus"].Value.ToString();
                string Code1 = dataGridView1.Rows[rowindex].Cells["Code1"].Value.ToString();
                string Title1 = dataGridView1.Rows[rowindex].Cells["Title1"].Value.ToString();
                string Credit1 = dataGridView1.Rows[rowindex].Cells["Credit1"].Value.ToString();
                string Code2 = dataGridView1.Rows[rowindex].Cells["Code2"].Value.ToString();
                string Title2 = dataGridView1.Rows[rowindex].Cells["Title2"].Value.ToString();
                string Credit2 = dataGridView1.Rows[rowindex].Cells["Credit2"].Value.ToString();
                string Code3 = dataGridView1.Rows[rowindex].Cells["Code3"].Value.ToString();
                string Title3 = dataGridView1.Rows[rowindex].Cells["Title3"].Value.ToString();
                string Credit3 = dataGridView1.Rows[rowindex].Cells["Credit3"].Value.ToString();
                string Code4 = dataGridView1.Rows[rowindex].Cells["Code4"].Value.ToString();
                string Title4 = dataGridView1.Rows[rowindex].Cells["Title4"].Value.ToString();
                string Credit4 = dataGridView1.Rows[rowindex].Cells["Credit4"].Value.ToString();
                string Code5 = dataGridView1.Rows[rowindex].Cells["Code5"].Value.ToString();
                string Title5 = dataGridView1.Rows[rowindex].Cells["Title5"].Value.ToString();
                string Credit5 = dataGridView1.Rows[rowindex].Cells["Credit5"].Value.ToString();
                string Code6 = dataGridView1.Rows[rowindex].Cells["Code6"].Value.ToString();
                string Title6 = dataGridView1.Rows[rowindex].Cells["Title6"].Value.ToString();
                string Credit6 = dataGridView1.Rows[rowindex].Cells["Credit6"].Value.ToString();
                string RetakeCode1 = dataGridView1.Rows[rowindex].Cells["RetakeCode1"].Value.ToString();
                string RetakeTitle1 = dataGridView1.Rows[rowindex].Cells["RetakeTitle1"].Value.ToString();
                string RetakeCredit1 = dataGridView1.Rows[rowindex].Cells["RetakeCredit1"].Value.ToString();
                string RetakeCode2 = dataGridView1.Rows[rowindex].Cells["RetakeCode2"].Value.ToString();
                string RetakeTitle2 = dataGridView1.Rows[rowindex].Cells["RetakeTitle2"].Value.ToString();
                string RetakeCredit2 = dataGridView1.Rows[rowindex].Cells["RetakeCredit2"].Value.ToString();
                string RegisterSign = dataGridView1.Rows[rowindex].Cells["RegisterSign"].Value.ToString();
                string ChairpersonSign = dataGridView1.Rows[rowindex].Cells["ChairpersonSign"].Value.ToString();
                StudentEnrolmentID = Convert.ToInt32(dataGridView1.Rows[rowindex].Cells["StudentEnrolmentID"].Value.ToString());

                cmbSemister.Text = Semister;
                cmbStudentID.Text = StudentId;
                cmbStudentName.Text = StudentName;
                cmbDepartment.Text = Department;
                cmbProgram.Text = Program;
                cmbBatch.Text = Batch;
                cmbRegNo.Text = RegNo;
                cmbCampus.Text = Campus;
                txtCourseCode1.Text = Code1;
                txtCourseTitle1.Text = Title1;
                txtCredit1.Text = Credit1;
                txtCourseCode2.Text = Code2;
                txtCourseTitle2.Text = Title2;
                txtCredit2.Text = Credit2;
                txtCourseCode3.Text = Code3;
                txtCourseTitle3.Text = Title3;
                txtCredit3.Text = Credit3;
                txtCourseCode4.Text = Code4;
                txtCourseTitle4.Text = Title4;
                txtCredit4.Text = Credit4;
                txtCourseCode5.Text = Code5;
                txtCourseTitle5.Text = Title5;
                txtCredit5.Text = Credit5;
                txtCourseCode6.Text = Code6;
                txtCourseTitle6.Text = Title6;
                txtCredit6.Text = Credit6;
                txtCourseCodeRetake1.Text = RetakeCode1;
                txtCourseTitleRetake1.Text = RetakeTitle1;
                txtCreditRetake1.Text = RetakeCredit1;
                txtCourseCodeRetake2.Text = RetakeTitle2;
                txtCourseTitleRetake2.Text = RetakeTitle2;
                txtCreditRetake2.Text = RetakeCredit2;
                txtRegisterSign.Text = RegisterSign;
                txtChairmanSign.Text = ChairpersonSign;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string update = "";
            string Semister = cmbSemister.Text.Trim().ToString();
            string StudentId = cmbStudentID.Text.Trim().ToString();
            string StudentName = cmbStudentName.Text.Trim().ToString();
            string Department = cmbDepartment.Text.Trim().ToString();
            string Program = cmbProgram.Text.Trim().ToString();
            string Batch = cmbBatch.Text.Trim().ToString();
            string RegNo = cmbRegNo.Text.Trim().ToString();
            string Campus = cmbCampus.Text.Trim().ToString();
            string Code1 = txtCourseCode1.Text.Trim().ToString();
            string Title1 = txtCourseTitle1.Text.Trim().ToString();
            string Credit1 = txtCredit1.Text.Trim().ToString();
            string Code2 = txtCourseCode2.Text.Trim().ToString();
            string Title2 = txtCourseTitle2.Text.Trim().ToString();
            string Credit2 = txtCredit2.Text.Trim().ToString();
            string Code3 = txtCourseCode3.Text.Trim().ToString();
            string Title3 = txtCourseTitle3.Text.Trim().ToString();
            string Credit3 = txtCredit3.Text.Trim().ToString();
            string Code4 = txtCourseCode4.Text.Trim().ToString();
            string Title4 = txtCourseTitle4.Text.Trim().ToString();
            string Credit4 = txtCredit4.Text.Trim().ToString();
            string Code5 = txtCourseCode5.Text.Trim().ToString();
            string Title5 = txtCourseTitle5.Text.Trim().ToString();
            string Credit5 = txtCredit5.Text.Trim().ToString();
            string Code6 = txtCourseCode6.Text.Trim().ToString();
            string Title6 = txtCourseTitle6.Text.Trim().ToString();
            string Credit6 = txtCredit6.Text.Trim().ToString();
            string RetakeCode1 = txtCourseCodeRetake1.Text.Trim().ToString();
            string RetakeTitle1 = txtCourseTitleRetake1.Text.Trim().ToString();
            string RetakeCredit1 = txtCreditRetake1.Text.Trim().ToString();
            string RetakeCode2 = txtCourseCodeRetake2.Text.Trim().ToString();
            string RetakeTitle2 = txtCourseTitleRetake2.Text.Trim().ToString();
            string RetakeCredit2 = txtCreditRetake2.Text.Trim().ToString();
            string RegisterSign = txtRegisterSign.Text.Trim().ToString();
            string ChairpersonSign = txtChairmanSign.Text.Trim().ToString();
            update = DPL.Update_Tbl_StudentEnrolment(StudentEnrolmentID, Semister, StudentId, StudentName, Department, Program, Batch, RegNo, Campus, Code1, Title1, Credit1, Code2, Title2, Credit2, Code3, Title3, Credit3, Code4, Title4, Credit4, Code5, Title5, Credit5, Code6, Title6, Credit6, RetakeCode1, RetakeTitle1, RetakeCredit1, RetakeCode2, RetakeTitle2, RetakeCredit2, RegisterSign, ChairpersonSign);
            if (update == "Succeded")
            {
                sql = @"SELECT     StudentEnrolmentID, Semister, StudentId, StudentName, Department, Program, Batch, RegNo, Campus, Code1, Title1, Credit1, Code2, Title2, Credit2, Code3, Title3, 
                      Credit3, Code4, Title4, Credit4, Code5, Title5, Credit5, Code6, Title6, Credit6, RetakeCode1, RetakeTitle1, RetakeCredit1, RetakeCode2, RetakeTitle2, RetakeCredit2, 
                      RegisterSign, ChairpersonSign
FROM         dbo.Tbl_StudentEnrolment
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
                    DetailsDelete = DPL.Delete_tbl_Value("Tbl_StudentEnrolment", "StudentEnrolmentID", StudentEnrolmentID);
                    if (DetailsDelete == "Succeded")
                    {
                        MessageBox.Show("Succeded");
                        sql = @"SELECT     StudentEnrolmentID, Semister, StudentId, StudentName, Department, Program, Batch, RegNo, Campus, Code1, Title1, Credit1, Code2, Title2, Credit2, Code3, Title3, 
                      Credit3, Code4, Title4, Credit4, Code5, Title5, Credit5, Code6, Title6, Credit6, RetakeCode1, RetakeTitle1, RetakeCredit1, RetakeCode2, RetakeTitle2, RetakeCredit2, 
                      RegisterSign, ChairpersonSign
FROM         dbo.Tbl_StudentEnrolment
WHERE     (StudentId = '" + StudentId + "')";

                        dt = DAL.GetData(sql);
                        dataGridView1.DataSource = dt;
                        StudentEnrolmentID = 0;
                    }
                }
            }
        }
    }
}
