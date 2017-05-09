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
    public partial class FrmStudentAdmission : Form
    {
        DataAccessLayer DAL = new DataAccessLayer();
        DataProcessLayer DPL = new DataProcessLayer();
        public FrmStudentAdmission()
        {
            InitializeComponent();
            CMBFILL();
            cmbAdmissionSemester.Focus();
            cmbAdmissionSemester.Select();
        }
        private void CMBFILL()
        {
            sql = @"SELECT     StudentAdmissionID, StudentId
FROM         dbo.Tbl_StudentAdmission";
            dt = DAL.GetData(sql);
            cmbSearchStudentID.DataSource = dt;
            cmbSearchStudentID.DisplayMember = "StudentId";
            cmbSearchStudentID.ValueMember = "StudentAdmissionID";
            cmbSearchStudentID.SelectedIndex = -1;
        }
        # region Member Variable
        string sql = "";
        string save = "";
        int StudentAdmissionID = 0;
        string StudentId = "";
        DataTable dt = null;
        # endregion
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbAdmissionSemester_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Return")
            {
                if (cmbAdmissionSemester.Text.Trim().ToString() != "")
                {
                    txtProgram.Focus();
                    txtProgram.Select();
                }
                else
                {
                    MessageBox.Show("Select admission semister");
                    cmbAdmissionSemester.Focus();
                    cmbAdmissionSemester.Select();
                }
            }
        }

        private void cmbAdmissionSemester_Enter(object sender, EventArgs e)
        {
            cmbAdmissionSemester.ForeColor = Color.White;
            cmbAdmissionSemester.BackColor = Color.CadetBlue;
        }

        private void cmbAdmissionSemester_Leave(object sender, EventArgs e)
        {
            cmbAdmissionSemester.ForeColor = Color.Black;
            cmbAdmissionSemester.BackColor = Color.White;
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
                    MessageBox.Show("Selecct program");
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
                    txtStudentId.Focus();
                    txtStudentId.Select();
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

        private void txtStudentId_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Return")
            {
                if (txtStudentId.Text.Trim().ToString() != "")
                {
                    txtStudentName.Focus();
                    txtStudentName.Select();
                }
                else
                {
                    MessageBox.Show("Select student id");
                    txtStudentId.Focus();
                    txtStudentId.Select();
                }
            }
        }

        private void txtStudentId_Enter(object sender, EventArgs e)
        {
            txtStudentId.ForeColor = Color.White;
            txtStudentId.BackColor = Color.CadetBlue;
        }

        private void txtStudentId_Leave(object sender, EventArgs e)
        {
            txtStudentId.ForeColor = Color.Black;
            txtStudentId.BackColor = Color.White;
        }

        private void txtStudentName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Return")
            {
                if (txtStudentName.Text.Trim().ToString() != "")
                {
                    txtFatherName.Focus();
                    txtFatherName.Select();
                }
                else
                {
                    MessageBox.Show("Select student name");
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

        private void txtFatherName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Return")
            {
                if (txtFatherName.Text.Trim().ToString() != "")
                {
                    txtMotherName.Focus();
                    txtMotherName.Select();
                }
                else
                {
                    MessageBox.Show("Select father name");
                    txtFatherName.Focus();
                    txtFatherName.Select();
                }
            }
        }

        private void txtFatherName_Enter(object sender, EventArgs e)
        {
            txtFatherName.ForeColor = Color.White;
            txtFatherName.BackColor = Color.CadetBlue;
        }

        private void txtFatherName_Leave(object sender, EventArgs e)
        {
            txtFatherName.ForeColor = Color.Black;
            txtFatherName.BackColor = Color.White;
        }
        private void txtMotherName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Return")
            {
                if (txtMotherName.Text.Trim().ToString() != "")
                {
                    richPresentAddress.Focus();
                    richPresentAddress.Select();
                }
                else
                {
                    MessageBox.Show("Select mother nAME");
                    txtMotherName.Focus();
                    txtMotherName.Select();
                }
            }
        }

        private void txtMotherName_Enter(object sender, EventArgs e)
        {
            txtMotherName.ForeColor = Color.White;
            txtMotherName.BackColor = Color.CadetBlue;
        }

        private void txtMotherName_Leave(object sender, EventArgs e)
        {
            txtMotherName.ForeColor = Color.Black;
            txtMotherName.BackColor = Color.White;
        }
        private void richPresentAddress_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Return")
            {
                if (richPresentAddress.Text.Trim().ToString() != "")
                {
                    richParmanentAddress.Focus();
                    richParmanentAddress.Select();
                }
                else
                {
                    MessageBox.Show("Select present address");
                    richPresentAddress.Focus();
                    richPresentAddress.Select();
                }
            }
        }

        private void richPresentAddress_Enter(object sender, EventArgs e)
        {
            richPresentAddress.ForeColor = Color.White;
            richPresentAddress.BackColor = Color.CadetBlue;
        }

        private void richPresentAddress_Leave(object sender, EventArgs e)
        {
            richPresentAddress.ForeColor = Color.Black;
            richPresentAddress.BackColor = Color.White;
        }
        private void richParmanentAddress_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Return")
            {
                if (richParmanentAddress.Text.Trim().ToString() != "")
                {
                    txtAnnulIncome.Focus();
                    txtAnnulIncome.Select();
                }
                else
                {
                    MessageBox.Show("Select parmanent address");
                    richParmanentAddress.Focus();
                    richParmanentAddress.Select();
                }
            }
        }

        private void richParmanentAddress_Enter(object sender, EventArgs e)
        {
            richParmanentAddress.ForeColor = Color.White;
            richParmanentAddress.BackColor = Color.CadetBlue;
        }

        private void richParmanentAddress_Leave(object sender, EventArgs e)
        {
            richParmanentAddress.ForeColor = Color.Black;
            richParmanentAddress.BackColor = Color.White;
        }
        private void txtAnnulIncome_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Return")
            {
                if (txtAnnulIncome.Text.Trim().ToString() != "")
                {
                    txtNationality.Focus();
                    txtNationality.Select();
                }
                else
                {
                    MessageBox.Show("Select annual income");
                    txtAnnulIncome.Focus();
                    txtAnnulIncome.Select();
                }
            }
        }

        private void txtAnnulIncome_Enter(object sender, EventArgs e)
        {
            txtAnnulIncome.ForeColor = Color.White;
            txtAnnulIncome.BackColor = Color.CadetBlue;
        }

        private void txtAnnulIncome_Leave(object sender, EventArgs e)
        {
            txtAnnulIncome.ForeColor = Color.Black;
            txtAnnulIncome.BackColor = Color.White;
        }
        private void txtNationality_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Return")
            {
                if (txtNationality.Text.Trim().ToString() != "")
                {
                    txtBirthDate.Focus();
                    txtBirthDate.Select();
                }
                else
                {
                    MessageBox.Show("Select nationality");
                    txtNationality.Focus();
                    txtNationality.Select();
                }
            }
        }

        private void txtNationality_Enter(object sender, EventArgs e)
        {
            txtNationality.ForeColor = Color.White;
            txtNationality.BackColor = Color.CadetBlue;
        }

        private void txtNationality_Leave(object sender, EventArgs e)
        {
            txtNationality.ForeColor = Color.Black;
            txtNationality.BackColor = Color.White;
        }
        private void txtBirthDate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Return")
            {
                if (txtBirthDate.Text.Trim().ToString() != "")
                {
                    radoMale.Focus();
                    radoMale.Select();
                }
                else
                {
                    MessageBox.Show("Select birth date");
                    txtBirthDate.Focus();
                    txtBirthDate.Select();
                }
            }
        }

        private void txtBirthDate_Enter(object sender, EventArgs e)
        {
            txtBirthDate.ForeColor = Color.White;
            txtBirthDate.BackColor = Color.CadetBlue;
        }

        private void txtBirthDate_Leave(object sender, EventArgs e)
        {
            txtBirthDate.ForeColor = Color.Black;
            txtBirthDate.BackColor = Color.White;
        }
        private void cmbMaritalStatus_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Return")
            {
                if (cmbMaritalStatus.Text.Trim().ToString() != "")
                {
                    txtOccupation.Focus();
                    txtOccupation.Select();
                }
                else
                {
                    MessageBox.Show("Select marital status");
                    cmbMaritalStatus.Focus();
                    cmbMaritalStatus.Select();
                }
            }
        }

        private void cmbMaritalStatus_Enter(object sender, EventArgs e)
        {
            cmbMaritalStatus.ForeColor = Color.White;
            cmbMaritalStatus.BackColor = Color.CadetBlue;
        }

        private void cmbMaritalStatus_Leave(object sender, EventArgs e)
        {
            cmbMaritalStatus.ForeColor = Color.Black;
            cmbMaritalStatus.BackColor = Color.White;
        }
        private void txtOccupation_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Return")
            {
                if (txtOccupation.Text.Trim().ToString() != "")
                {
                    txtMobile.Focus();
                    txtMobile.Select();
                }
                else
                {
                    MessageBox.Show("Select occupation");
                    txtOccupation.Focus();
                    txtOccupation.Select();
                }
            }
        }

        private void txtOccupation_Enter(object sender, EventArgs e)
        {
            txtOccupation.ForeColor = Color.White;
            txtOccupation.BackColor = Color.CadetBlue;
        }

        private void txtOccupation_Leave(object sender, EventArgs e)
        {
            txtOccupation.ForeColor = Color.Black;
            txtOccupation.BackColor = Color.White;
        }
        private void txtMobile_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Return")
            {
                if (txtMobile.Text.Trim().ToString() != "")
                {
                    cmbSSCGroup.Focus();
                    cmbSSCGroup.Select();
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
        private void cmbSSCGroup_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Return")
            {
                if (cmbSSCGroup.Text.Trim().ToString() != "")
                {
                    txtSSCGrade.Focus();
                    txtSSCGrade.Select();
                }
                else
                {
                    MessageBox.Show("Select ssc group");
                    cmbSSCGroup.Focus();
                    cmbSSCGroup.Select();
                }
            }
        }

        private void cmbSSCGroup_Enter(object sender, EventArgs e)
        {
            cmbSSCGroup.ForeColor = Color.White;
            cmbSSCGroup.BackColor = Color.CadetBlue;
        }

        private void cmbSSCGroup_Leave(object sender, EventArgs e)
        {
            cmbSSCGroup.ForeColor = Color.Black;
            cmbSSCGroup.BackColor = Color.White;
        }
        private void txtSSCGrade_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Return")
            {
                if (txtSSCGrade.Text.Trim().ToString() != "")
                {
                    txtSSCBoard.Focus();
                    txtSSCBoard.Select();
                }
                else
                {
                    MessageBox.Show("Select ssc grade");
                    txtSSCGrade.Focus();
                    txtSSCGrade.Select();
                }
            }
        }

        private void txtSSCGrade_Enter(object sender, EventArgs e)
        {
            txtSSCGrade.ForeColor = Color.White;
            txtSSCGrade.BackColor = Color.CadetBlue;
        }

        private void txtSSCGrade_Leave(object sender, EventArgs e)
        {
            txtSSCGrade.ForeColor = Color.Black;
            txtSSCGrade.BackColor = Color.White;
        }
        private void txtSSCBoard_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Return")
            {
                if (txtSSCBoard.Text.Trim().ToString() != "")
                {
                    txtSSCYear.Focus();
                    txtSSCYear.Select();
                }
                else
                {
                    MessageBox.Show("Select ssc board");
                    txtSSCBoard.Focus();
                    txtSSCBoard.Select();
                }
            }
        }

        private void txtSSCBoard_Enter(object sender, EventArgs e)
        {
            txtSSCBoard.ForeColor = Color.White;
            txtSSCBoard.BackColor = Color.CadetBlue;
        }

        private void txtSSCBoard_Leave(object sender, EventArgs e)
        {
            txtSSCBoard.ForeColor = Color.Black;
            txtSSCBoard.BackColor = Color.White;
        }
        private void txtSSCYear_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Return")
            {
                if (txtSSCYear.Text.Trim().ToString() != "")
                {
                    cmbHSCGroup.Focus();
                    cmbHSCGroup.Select();
                }
                else
                {
                    MessageBox.Show("Select ssc year");
                    txtSSCYear.Focus();
                    txtSSCYear.Select();
                }
            }
        }

        private void txtSSCYear_Enter(object sender, EventArgs e)
        {
            txtSSCYear.ForeColor = Color.White;
            txtSSCYear.BackColor = Color.CadetBlue;
        }

        private void txtSSCYear_Leave(object sender, EventArgs e)
        {
            txtSSCYear.ForeColor = Color.Black;
            txtSSCYear.BackColor = Color.White;
        }
        private void cmbHSCGroup_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Return")
            {
                if (cmbHSCGroup.Text.Trim().ToString() != "")
                {
                    txtHSCGrade.Focus();
                    txtHSCGrade.Select();
                }
                else
                {
                    MessageBox.Show("Select HSC group");
                    cmbHSCGroup.Focus();
                    cmbHSCGroup.Select();
                }
            }
        }

        private void cmbHSCGroup_Enter(object sender, EventArgs e)
        {
            cmbHSCGroup.ForeColor = Color.White;
            cmbHSCGroup.BackColor = Color.CadetBlue;
        }

        private void cmbHSCGroup_Leave(object sender, EventArgs e)
        {
            cmbHSCGroup.ForeColor = Color.Black;
            cmbHSCGroup.BackColor = Color.White;

        }
        private void txtHSCGrade_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Return")
            {
                if (txtHSCGrade.Text.Trim().ToString() != "")
                {
                    txtHSCBoard.Focus();
                    txtHSCBoard.Select();
                }
                else
                {
                    MessageBox.Show("Select HSC grade");
                    txtHSCGrade.Focus();
                    txtHSCGrade.Select();
                }
            }
        }

        private void txtHSCGrade_Enter(object sender, EventArgs e)
        {
            txtHSCGrade.ForeColor = Color.White;
            txtHSCGrade.BackColor = Color.CadetBlue;
        }

        private void txtHSCGrade_Leave(object sender, EventArgs e)
        {
            txtHSCGrade.ForeColor = Color.Black;
            txtHSCGrade.BackColor = Color.White;
        }
        private void txtHSCBoard_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Return")
            {
                if (txtHSCBoard.Text.Trim().ToString() != "")
                {
                    txtHSCYear.Focus();
                    txtHSCYear.Select();
                }
                else
                {
                    MessageBox.Show("Select HSC board");
                    txtHSCBoard.Focus();
                    txtHSCBoard.Select();
                }
            }
        }

        private void txtHSCBoard_Enter(object sender, EventArgs e)
        {
            txtHSCBoard.ForeColor = Color.White;
            txtHSCBoard.BackColor = Color.CadetBlue;
        }

        private void txtHSCBoard_Leave(object sender, EventArgs e)
        {
            txtHSCBoard.ForeColor = Color.Black;
            txtHSCBoard.BackColor = Color.White;
        }
        private void txtHSCYear_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Return")
            {
                if (txtHSCYear.Text.Trim().ToString() != "")
                {
                    txtDiplomaGroup.Focus();
                    txtDiplomaGroup.Select();
                }
                else
                {
                    MessageBox.Show("Select HSC year");
                    txtHSCYear.Focus();
                    txtHSCYear.Select();
                }
            }
        }

        private void txtHSCYear_Enter(object sender, EventArgs e)
        {
            txtHSCYear.ForeColor = Color.White;
            txtHSCYear.BackColor = Color.CadetBlue;
        }

        private void txtHSCYear_Leave(object sender, EventArgs e)
        {
            txtHSCYear.ForeColor = Color.Black;
            txtHSCYear.BackColor = Color.White;
        }
        private void txtDiplomaGroup_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Return")
            {
                if (txtDiplomaGroup.Text.Trim().ToString() != "")
                {
                    txtDiplomaGrade.Focus();
                    txtDiplomaGrade.Select();
                }
                else
                {
                    MessageBox.Show("Select diploma group");
                    txtDiplomaGroup.Focus();
                    txtDiplomaGroup.Select();
                }
            }
        }

        private void txtDiplomaGroup_Enter(object sender, EventArgs e)
        {
            txtDiplomaGroup.ForeColor = Color.White;
            txtDiplomaGroup.BackColor = Color.CadetBlue;
        }

        private void txtDiplomaGroup_Leave(object sender, EventArgs e)
        {
            txtDiplomaGroup.ForeColor = Color.Black;
            txtDiplomaGroup.BackColor = Color.White;
        }

        private void txtDiplomaGrade_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Return")
            {
                if (txtDiplomaGrade.Text.Trim().ToString() != "")
                {
                    txtDiplomaUnivrct.Focus();
                    txtDiplomaUnivrct.Select();
                }
                else
                {
                    MessageBox.Show("Select diploma grade");
                    txtDiplomaGrade.Focus();
                    txtDiplomaGrade.Select();
                }
            }
        }

        private void txtDiplomaGrade_Enter(object sender, EventArgs e)
        {
            txtDiplomaGrade.ForeColor = Color.White;
            txtDiplomaGrade.BackColor = Color.CadetBlue;
        }

        private void txtDiplomaGrade_Leave(object sender, EventArgs e)
        {
            txtDiplomaGrade.ForeColor = Color.Black;
            txtDiplomaGrade.BackColor = Color.White;
        }

        private void txtDiplomaUnivrct_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Return")
            {
                if (txtDiplomaUnivrct.Text.Trim().ToString() != "")
                {
                    txtDiplomaYear.Focus();
                    txtDiplomaYear.Select();
                }
                else
                {
                    MessageBox.Show("Select diploma university");
                    txtDiplomaUnivrct.Focus();
                    txtDiplomaUnivrct.Select();
                }
            }
        }

        private void txtDiplomaUnivrct_Enter(object sender, EventArgs e)
        {
            txtDiplomaUnivrct.ForeColor = Color.White;
            txtDiplomaUnivrct.BackColor = Color.CadetBlue;
        }

        private void txtDiplomaUnivrct_Leave(object sender, EventArgs e)
        {
            txtDiplomaUnivrct.ForeColor = Color.Black;
            txtDiplomaUnivrct.BackColor = Color.White;
        }

        private void txtDiplomaYear_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Return")
            {
                if (txtDiplomaYear.Text.Trim().ToString() != "")
                {
                    txtBBAGroup.Focus();
                    txtBBAGroup.Select();
                }
                else
                {
                    MessageBox.Show("Select diploma year");
                    txtDiplomaYear.Focus();
                    txtDiplomaYear.Select();
                }
            }
        }

        private void txtDiplomaYear_Enter(object sender, EventArgs e)
        {
            txtDiplomaYear.ForeColor = Color.White;
            txtDiplomaYear.BackColor = Color.CadetBlue;
        }

        private void txtDiplomaYear_Leave(object sender, EventArgs e)
        {
            txtDiplomaYear.ForeColor = Color.Black;
            txtDiplomaYear.BackColor = Color.White;
        }
        private void txtBBAGroup_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Return")
            {
                if (txtBBAGroup.Text.Trim().ToString() != "")
                {
                    txtBBAGrade.Focus();
                    txtBBAGrade.Select();
                }
                else
                {
                    MessageBox.Show("Select BBA group");
                    txtBBAGroup.Focus();
                    txtBBAGroup.Select();
                }
            }
        }
        private void txtBBAGrade_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Return")
            {
                if (txtBBAGrade.Text.Trim().ToString() != "")
                {
                    txtBBAUnivrct.Focus();
                    txtBBAUnivrct.Select();
                }
                else
                {
                    MessageBox.Show("Select BBA grade");
                    txtBBAGrade.Focus();
                    txtBBAGrade.Select();
                }
            }
        }
        private void txtBBAUnivrct_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Return")
            {
                if (txtBBAUnivrct.Text.Trim().ToString() != "")
                {
                    txtBBAYear.Focus();
                    txtBBAYear.Select();
                }
                else
                {
                    MessageBox.Show("select BBA university");
                    txtBBAUnivrct.Focus();
                    txtBBAUnivrct.Select();
                }
            }
        }
        private void txtBBAYear_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Return")
            {
                if (txtBBAYear.Text.Trim().ToString() != "")
                {
                    txtMAPreliGroup.Focus();
                    txtMAPreliGroup.Select();
                }
                else
                {
                    MessageBox.Show("Select BBA year");
                    txtBBAYear.Focus();
                    txtBBAYear.Select();
                }
            }
        }
        private void txtMAPreliGroup_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Return")
            {
                if (txtMAPreliGroup.Text.Trim().ToString() != "")
                {
                    txtMAPreliGrade.Focus();
                    txtMAPreliGrade.Select();
                }
                else
                {
                    MessageBox.Show("Select preli MA group");
                    txtMAPreliGroup.Focus();
                    txtMAPreliGroup.Select();
                }
            }
        }
        private void txtMAPreliGrade_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Return")
            {
                if (txtMAPreliGrade.Text.Trim().ToString() != "")
                {
                    txtMAPreliUnivrct.Focus();
                    txtMAPreliUnivrct.Select();
                }
                else
                {
                    MessageBox.Show("Select preli MA grade");
                    txtMAPreliGrade.Focus();
                    txtMAPreliGrade.Select();
                }
            }
        }
        private void txtMAPreliUnivrct_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Return")
            {
                if (txtMAPreliUnivrct.Text.Trim().ToString() != "")
                {
                    txtMAPreliYear.Focus();
                    txtMAPreliYear.Select();
                }
                else
                {
                    MessageBox.Show("Select preli MA university");
                    txtMAPreliUnivrct.Focus();
                    txtMAPreliUnivrct.Select();
                }
            }
        }
        private void txtMAPreliYear_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Return")
            {
                if (txtMAPreliYear.Text.Trim().ToString() != "")
                {
                    txtMAFinalGroup.Focus();
                    txtMAFinalGroup.Select();
                }
                else
                {
                    MessageBox.Show("Select preli MA year");
                    txtMAPreliYear.Focus();
                    txtMAPreliYear.Select();
                }
            }
        }
        private void txtMAFinalGroup_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Return")
            {
                if (txtMAFinalGroup.Text.Trim().ToString() != "")
                {
                    txtMAFinalGrade.Focus();
                    txtMAFinalGrade.Select();
                }
                else
                {
                    MessageBox.Show("select final MA group");
                    txtMAFinalGroup.Focus();
                    txtMAFinalGroup.Select();
                }
            }
        }
        private void txtMAFinalGrade_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Return")
            {
                if (txtMAFinalGrade.Text.Trim().ToString() != "")
                {
                    txtMAFinalUnivrct.Focus();
                    txtMAFinalUnivrct.Select();
                }
                else
                {
                    MessageBox.Show("Select final MA grade");
                    txtMAFinalGrade.Focus();
                    txtMAFinalGrade.Select();
                }
            }
        }
        private void txtMAFinalUnivrct_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Return")
            {
                if (txtMAFinalUnivrct.Text.Trim().ToString() != "")
                {
                    txtMAFinalYear.Focus();
                    txtMAFinalYear.Select();
                }
                else
                {
                    MessageBox.Show("Select final MA university");
                    txtMAFinalUnivrct.Focus();
                    txtMAFinalUnivrct.Select();
                }
            }
        }
        private void txtMAFinalYear_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Return")
            {
                if (txtMAFinalYear.Text.Trim().ToString() != "")
                {
                    btnSave.Focus();
                    btnSave.Select();
                }
                else
                {
                    MessageBox.Show("Select final MA rear");
                    txtMAFinalYear.Focus();
                    txtMAFinalYear.Select();
                }
            }
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
                string Semister = cmbAdmissionSemester.Text.Trim().ToString();
                string Program = txtProgram.Text.Trim().ToString();
                string Department = txtDepartment.Text.Trim().ToString();
                string StudentId = txtStudentId.Text.Trim().ToString();
                string StudentName = txtStudentName.Text.Trim().ToString();
                string FatherName = txtFatherName.Text.Trim().ToString();
                string MotherName = txtMotherName.Text.Trim().ToString();
                string PresentAddress = richPresentAddress.Text.Trim().ToString();
                string PermanentAddress = richParmanentAddress.Text.Trim().ToString();
                string AnnualIncome = txtAnnulIncome.Text.Trim().ToString();
                string Nationality = txtNationality.Text.Trim().ToString();
                string BirthDate = txtBirthDate.Text.Trim().ToString();
                string MaritalStatus = cmbMaritalStatus.Text.Trim().ToString();
                string Occupation = txtOccupation.Text.Trim().ToString();
                string Mobile = txtMobile.Text.Trim().ToString();
                string SSCgroup = cmbSSCGroup.Text.Trim().ToString();
                string SSCgrade = txtSSCGrade.Text.Trim().ToString();
                string SSCboard = txtSSCBoard.Text.Trim().ToString();
                int SSCyear = Convert.ToInt32(txtSSCYear.Text.Trim().ToString());
                string HSCgroup = cmbHSCGroup.Text.Trim().ToString();
                string HSCgrade = txtHSCGrade.Text.Trim().ToString();
                string HSCboard = txtHSCBoard.Text.Trim().ToString();
                int HSCyear = Convert.ToInt32(txtHSCYear.Text.Trim().ToString());
                string DiplomaGroup = txtDiplomaGroup.Text.Trim().ToString();
                string DiplomaCGPA = txtDiplomaGrade.Text.Trim().ToString();
                string DiplomaUnivrct = txtDiplomaUnivrct.Text.Trim().ToString();
                string DiplomaYear = txtDiplomaYear.Text.Trim().ToString();
                string BBAgroup = txtBBAGroup.Text.Trim().ToString();
                string BBAcgpa = txtBBAGrade.Text.Trim().ToString();
                string BBAunivrct = txtBBAUnivrct.Text.Trim().ToString();
                string BBAyear = txtBBAYear.Text.Trim().ToString();
                string MApreliGroup = txtMAPreliGroup.Text.Trim().ToString();
                string MApreliCGPA = txtMAPreliGrade.Text.Trim().ToString();
                string MApreliUnivrct = txtMAPreliUnivrct.Text.Trim().ToString();
                string MApreliYear = txtMAPreliYear.Text.Trim().ToString();
                string MAfinalGroup = txtMAFinalGroup.Text.Trim().ToString();
                string MAfinalCGPA = txtMAFinalGrade.Text.Trim().ToString();
                string MAfinalUnivrct = txtMAFinalUnivrct.Text.Trim().ToString();
                string MAfinalYear = txtMAFinalYear.Text.Trim().ToString();
                save = DPL.Save_Tbl_StudentAdmission(Semister, Program, Department, StudentId, StudentName, FatherName, MotherName, PresentAddress, PermanentAddress, AnnualIncome, Nationality, BirthDate, Male_Female, MaritalStatus, Occupation, Mobile, SSCgroup, SSCgrade, SSCboard, SSCyear, HSCgroup, HSCgrade, HSCboard, HSCyear, DiplomaGroup, DiplomaCGPA, DiplomaUnivrct, DiplomaYear, BBAgroup, BBAcgpa, BBAunivrct, BBAyear, MApreliGroup, MApreliCGPA, MApreliUnivrct, MApreliYear, MAfinalGroup, MAfinalCGPA, MAfinalUnivrct, MAfinalYear);
                if (save == "Succeded")
                {
                    sql = @"SELECT     StudentAdmissionID, Semister, Program, Department, StudentId, StudentName, FatherName, MotherName, PresentAddress, PermanentAddress, AnnualIncome, 
                      Nationality, BirthDate, Gender, MaritalStatus, Occupation, Mobile, SSCgroup, SSCgrade, SSCboard, SSCyear, HSCgroup, HSCgrade, HSCboard, HSCyear, 
                      DiplomaGroup, DiplomaCGPA, DiplomaUnivrct, DiplomaYear, BBAgroup, BBAcgpa, BBAunivrct, BBAyear, MApreliGroup, MApreliCGPA, MApreliUnivrct, MApreliYear, 
                      MAfinalGroup, MAfinalCGPA, MAfinalUnivrct, MAfinalYear
FROM         dbo.Tbl_StudentAdmission
WHERE     (StudentId = '" + StudentId + "')";
                    dt = DAL.GetData(sql);
                    dataGridView1.DataSource = dt;
                    MessageBox.Show("Succeded");
                }
            }
        }

        private void btnAddnew_Click(object sender, EventArgs e)
        {
            cmbAdmissionSemester.Text = "";
            txtProgram.Text = "";
            txtDepartment.Text = "";
            txtStudentId.Text = "";
            txtStudentName.Text = "";
            txtFatherName.Text = "";
            txtMotherName.Text = "";
            richPresentAddress.Text = "";
            richParmanentAddress.Text = "";
            txtAnnulIncome.Text = "";
            txtNationality.Text = "";
            txtBirthDate.Text = "";
            cmbMaritalStatus.Text = "";
            txtOccupation.Text = "";
            txtMobile.Text = "";
            cmbSSCGroup.Text = "";
            txtSSCGrade.Text = "";
            txtSSCBoard.Text = "";
            txtSSCYear.Text = "";
            cmbHSCGroup.Text = "";
            txtHSCGrade.Text = "";
            txtHSCBoard.Text = "";
            txtHSCYear.Text = "";
            txtDiplomaGroup.Text = "";
            txtDiplomaGrade.Text = "";
            txtDiplomaUnivrct.Text = "";
            txtDiplomaYear.Text = "";
            txtBBAGroup.Text = "";
            txtBBAGrade.Text = "";
            txtBBAUnivrct.Text = "";
            txtBBAYear.Text = "";
            txtMAPreliGroup.Text = "";
            txtMAPreliGrade.Text = "";
            txtMAPreliUnivrct.Text = "";
            txtMAPreliYear.Text = "";
            txtMAFinalGroup.Text = "";
            txtMAFinalGrade.Text = "";
            txtMAFinalUnivrct.Text = "";
            txtMAFinalYear.Text = "";
            dataGridView1.DataSource = null;
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
                string Semister = dataGridView1.Rows[rowindex].Cells["Semister"].Value.ToString();
                string Program = dataGridView1.Rows[rowindex].Cells["Program"].Value.ToString();
                string Department = dataGridView1.Rows[rowindex].Cells["Department"].Value.ToString();
                string StudentId = dataGridView1.Rows[rowindex].Cells["StudentId"].Value.ToString();
                string StudentName = dataGridView1.Rows[rowindex].Cells["StudentName"].Value.ToString();
                string FatherName = dataGridView1.Rows[rowindex].Cells["FatherName"].Value.ToString();
                string MotherName = dataGridView1.Rows[rowindex].Cells["MotherName"].Value.ToString();
                string PresentAddress = dataGridView1.Rows[rowindex].Cells["PresentAddress"].Value.ToString();
                string PermanentAddress = dataGridView1.Rows[rowindex].Cells["PermanentAddress"].Value.ToString();
                string AnnualIncome = dataGridView1.Rows[rowindex].Cells["AnnualIncome"].Value.ToString();
                string Nationality = dataGridView1.Rows[rowindex].Cells["Nationality"].Value.ToString();
                string BirthDate = dataGridView1.Rows[rowindex].Cells["BirthDate"].Value.ToString();
                string MaritalStatus = dataGridView1.Rows[rowindex].Cells["MaritalStatus"].Value.ToString();
                string Occupation = dataGridView1.Rows[rowindex].Cells["Occupation"].Value.ToString();
                string Mobile = dataGridView1.Rows[rowindex].Cells["Mobile"].Value.ToString();
                string SSCgroup = dataGridView1.Rows[rowindex].Cells["SSCgroup"].Value.ToString();
                string SSCgrade = dataGridView1.Rows[rowindex].Cells["SSCgrade"].Value.ToString();
                string SSCboard = dataGridView1.Rows[rowindex].Cells["SSCboard"].Value.ToString();
                string SSCyear = dataGridView1.Rows[rowindex].Cells["SSCyear"].Value.ToString();
                string HSCgroup = dataGridView1.Rows[rowindex].Cells["HSCgroup"].Value.ToString();
                string HSCgrade = dataGridView1.Rows[rowindex].Cells["HSCgrade"].Value.ToString();
                string HSCboard = dataGridView1.Rows[rowindex].Cells["HSCboard"].Value.ToString();
                string HSCyear = dataGridView1.Rows[rowindex].Cells["HSCyear"].Value.ToString();
                string DiplomaGroup = dataGridView1.Rows[rowindex].Cells["DiplomaGroup"].Value.ToString();
                string DiplomaCGPA = dataGridView1.Rows[rowindex].Cells["DiplomaCGPA"].Value.ToString();
                string DiplomaUnivrct = dataGridView1.Rows[rowindex].Cells["DiplomaUnivrct"].Value.ToString();
                string DiplomaYear = dataGridView1.Rows[rowindex].Cells["DiplomaYear"].Value.ToString();
                string BBAgroup = dataGridView1.Rows[rowindex].Cells["BBAgroup"].Value.ToString();
                string BBAcgpa = dataGridView1.Rows[rowindex].Cells["BBAcgpa"].Value.ToString();
                string BBAunivrct = dataGridView1.Rows[rowindex].Cells["BBAunivrct"].Value.ToString();
                string BBAyear = dataGridView1.Rows[rowindex].Cells["BBAyear"].Value.ToString();
                string MApreliGroup = dataGridView1.Rows[rowindex].Cells["MApreliGroup"].Value.ToString();
                string MApreliCGPA = dataGridView1.Rows[rowindex].Cells["MApreliCGPA"].Value.ToString();
                string MApreliUnivrct = dataGridView1.Rows[rowindex].Cells["MApreliUnivrct"].Value.ToString();
                string MApreliYear = dataGridView1.Rows[rowindex].Cells["MApreliYear"].Value.ToString();
                string MAfinalGroup = dataGridView1.Rows[rowindex].Cells["MAfinalGroup"].Value.ToString();
                string MAfinalCGPA = dataGridView1.Rows[rowindex].Cells["MAfinalCGPA"].Value.ToString();
                string MAfinalUnivrct = dataGridView1.Rows[rowindex].Cells["MAfinalUnivrct"].Value.ToString();
                string MAfinalYear = dataGridView1.Rows[rowindex].Cells["MAfinalYear"].Value.ToString();
                StudentAdmissionID = Convert.ToInt32(dataGridView1.Rows[rowindex].Cells["StudentAdmissionID"].Value.ToString());

                cmbAdmissionSemester.Text = Semister;
                txtProgram.Text = Program;
                txtDepartment.Text = Department;
                txtStudentId.Text = StudentId;
                txtStudentName.Text = StudentName;
                txtFatherName.Text = FatherName;
                txtMotherName.Text = MotherName;
                richPresentAddress.Text = PresentAddress;
                richParmanentAddress.Text = PermanentAddress;
                txtAnnulIncome.Text = AnnualIncome;
                txtNationality.Text = Nationality;
                txtBirthDate.Text = BirthDate;
                cmbMaritalStatus.Text = MaritalStatus;
                txtOccupation.Text = Occupation;
                txtMobile.Text = Mobile;
                cmbSSCGroup.Text = SSCgroup;
                txtSSCGrade.Text = SSCgrade;
                txtSSCBoard.Text = SSCboard;
                txtSSCYear.Text = SSCyear;
                cmbHSCGroup.Text = HSCgroup;
                txtHSCGrade.Text = HSCgrade;
                txtHSCBoard.Text = HSCboard;
                txtHSCYear.Text = HSCyear;
                txtDiplomaGroup.Text = DiplomaGroup;
                txtDiplomaGrade.Text = DiplomaCGPA;
                txtDiplomaUnivrct.Text = DiplomaUnivrct;
                txtDiplomaYear.Text = DiplomaYear;
                txtBBAGroup.Text = BBAgroup;
                txtBBAGrade.Text = BBAcgpa;
                txtBBAUnivrct.Text = BBAunivrct;
                txtBBAYear.Text = BBAyear;
                txtMAPreliGroup.Text = MApreliGroup;
                txtMAPreliGrade.Text = MApreliCGPA;
                txtMAPreliUnivrct.Text = MApreliUnivrct;
                txtMAPreliYear.Text = MApreliYear;
                txtMAFinalGroup.Text = MAfinalGroup;
                txtMAFinalGrade.Text = MAfinalCGPA;
                txtMAFinalUnivrct.Text = MAfinalUnivrct;
                txtMAFinalYear.Text = MAfinalYear;
            }
        }

        private void cmbSearchStudentID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Return")
            {
                if (cmbSearchStudentID.Text.Trim().ToString() != "")
                {
                    string StudentId = cmbSearchStudentID.Text.Trim().ToString();
                    sql = @"SELECT     StudentAdmissionID, Semister, Program, Department, StudentId, StudentName, FatherName, MotherName, PresentAddress, PermanentAddress, AnnualIncome, 
                      Nationality, BirthDate, Gender, MaritalStatus, Occupation, Mobile, SSCgroup, SSCgrade, SSCboard, SSCyear, HSCgroup, HSCgrade, HSCboard, HSCyear, 
                      DiplomaGroup, DiplomaCGPA, DiplomaUnivrct, DiplomaYear, BBAgroup, BBAcgpa, BBAunivrct, BBAyear, MApreliGroup, MApreliCGPA, MApreliUnivrct, MApreliYear, 
                      MAfinalGroup, MAfinalCGPA, MAfinalUnivrct, MAfinalYear
FROM         dbo.Tbl_StudentAdmission
WHERE     (StudentId = '" + StudentId + "')";
                    dt = DAL.GetData(sql);
                    dataGridView1.DataSource = dt;
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string update = "";
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
                string Semister = cmbAdmissionSemester.Text.Trim().ToString();
                string Program = txtProgram.Text.Trim().ToString();
                string Department = txtDepartment.Text.Trim().ToString();
                string StudentId = txtStudentId.Text.Trim().ToString();
                string StudentName = txtStudentName.Text.Trim().ToString();
                string FatherName = txtFatherName.Text.Trim().ToString();
                string MotherName = txtMotherName.Text.Trim().ToString();
                string PresentAddress = richPresentAddress.Text.Trim().ToString();
                string PermanentAddress = richParmanentAddress.Text.Trim().ToString();
                string AnnualIncome = txtAnnulIncome.Text.Trim().ToString();
                string Nationality = txtNationality.Text.Trim().ToString();
                string BirthDate = txtBirthDate.Text.Trim().ToString();
                string MaritalStatus = cmbMaritalStatus.Text.Trim().ToString();
                string Occupation = txtOccupation.Text.Trim().ToString();
                string Mobile = txtMobile.Text.Trim().ToString();
                string SSCgroup = cmbSSCGroup.Text.Trim().ToString();
                string SSCgrade = txtSSCGrade.Text.Trim().ToString();
                string SSCboard = txtSSCBoard.Text.Trim().ToString();
                int SSCyear = Convert.ToInt32(txtSSCYear.Text.Trim().ToString());
                string HSCgroup = cmbHSCGroup.Text.Trim().ToString();
                string HSCgrade = txtHSCGrade.Text.Trim().ToString();
                string HSCboard = txtHSCBoard.Text.Trim().ToString();
                int HSCyear = Convert.ToInt32(txtHSCYear.Text.Trim().ToString());
                string DiplomaGroup = txtDiplomaGroup.Text.Trim().ToString();
                string DiplomaCGPA = txtDiplomaGrade.Text.Trim().ToString();
                string DiplomaUnivrct = txtDiplomaUnivrct.Text.Trim().ToString();
                string DiplomaYear = txtDiplomaYear.Text.Trim().ToString();
                string BBAgroup = txtBBAGroup.Text.Trim().ToString();
                string BBAcgpa = txtBBAGrade.Text.Trim().ToString();
                string BBAunivrct = txtBBAUnivrct.Text.Trim().ToString();
                string BBAyear = txtBBAYear.Text.Trim().ToString();
                string MApreliGroup = txtMAPreliGroup.Text.Trim().ToString();
                string MApreliCGPA = txtMAPreliGrade.Text.Trim().ToString();
                string MApreliUnivrct = txtMAPreliUnivrct.Text.Trim().ToString();
                string MApreliYear = txtMAPreliYear.Text.Trim().ToString();
                string MAfinalGroup = txtMAFinalGroup.Text.Trim().ToString();
                string MAfinalCGPA = txtMAFinalGrade.Text.Trim().ToString();
                string MAfinalUnivrct = txtMAFinalUnivrct.Text.Trim().ToString();
                string MAfinalYear = txtMAFinalYear.Text.Trim().ToString();
                update = DPL.Update_Tbl_StudentAdmission(StudentAdmissionID, Semister, Program, Department, StudentId, StudentName, FatherName, MotherName, PresentAddress, PermanentAddress, AnnualIncome, Nationality, BirthDate, Male_Female, MaritalStatus, Occupation, Mobile, SSCgroup, SSCgrade, SSCboard, SSCyear, HSCgroup, HSCgrade, HSCboard, HSCyear, DiplomaGroup, DiplomaCGPA, DiplomaUnivrct, DiplomaYear, BBAgroup, BBAcgpa, BBAunivrct, BBAyear, MApreliGroup, MApreliCGPA, MApreliUnivrct, MApreliYear, MAfinalGroup, MAfinalCGPA, MAfinalUnivrct, MAfinalYear);
                if (update == "Succeded")
                {
                    sql = @"SELECT     StudentAdmissionID, Semister, Program, Department, StudentId, StudentName, FatherName, MotherName, PresentAddress, PermanentAddress, AnnualIncome, 
                      Nationality, BirthDate, Gender, MaritalStatus, Occupation, Mobile, SSCgroup, SSCgrade, SSCboard, SSCyear, HSCgroup, HSCgrade, HSCboard, HSCyear, 
                      DiplomaGroup, DiplomaCGPA, DiplomaUnivrct, DiplomaYear, BBAgroup, BBAcgpa, BBAunivrct, BBAyear, MApreliGroup, MApreliCGPA, MApreliUnivrct, MApreliYear, 
                      MAfinalGroup, MAfinalCGPA, MAfinalUnivrct, MAfinalYear
FROM         dbo.Tbl_StudentAdmission
WHERE     (StudentId = '" + StudentId + "')";
                    dt = DAL.GetData(sql);
                    dataGridView1.DataSource = dt;
                    //dataGridView1.Columns["StudentAdmissionID"].Visible = false;
                    MessageBox.Show("Succeded");
                }
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
                    DetailsDelete = DPL.Delete_tbl_Value("Tbl_StudentAdmission", "StudentAdmissionID", StudentAdmissionID);
                    if (DetailsDelete == "Succeded")
                    {
                        MessageBox.Show("Succeded");
                        sql = @"SELECT     StudentAdmissionID, Semister, Program, Department, StudentId, StudentName, FatherName, MotherName, PresentAddress, PermanentAddress, AnnualIncome, 
                      Nationality, BirthDate, Gender, MaritalStatus, Occupation, Mobile, SSCgroup, SSCgrade, SSCboard, SSCyear, HSCgroup, HSCgrade, HSCboard, HSCyear, 
                      DiplomaGroup, DiplomaCGPA, DiplomaUnivrct, DiplomaYear, BBAgroup, BBAcgpa, BBAunivrct, BBAyear, MApreliGroup, MApreliCGPA, MApreliUnivrct, MApreliYear, 
                      MAfinalGroup, MAfinalCGPA, MAfinalUnivrct, MAfinalYear
FROM         dbo.Tbl_StudentAdmission
WHERE     (StudentId = '" + StudentId + "')";

                        dt = DAL.GetData(sql);
                        dataGridView1.DataSource = dt;
                        StudentAdmissionID = 0;
                    }
                }
            }
        }
    }
}
