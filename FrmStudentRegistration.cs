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
    public partial class FrmStudentRegistration : Form
    {
        DataAccessLayer DAL = new DataAccessLayer();
        DataProcessLayer DPL = new DataProcessLayer();
        public FrmStudentRegistration()
        {
            InitializeComponent();
            CMBFILL();

        }
        private void CMBFILL()
        {
            sql = @"SELECT     MAX(SerialNo) AS SerialNo
FROM         dbo.Tbl_StudentRegistration";
            dt = DAL.GetData(sql);
            string maxnumber = dt.Rows[0]["SerialNo"].ToString();
            if (maxnumber != "")
            {
                int maxSerialnumber = Convert.ToInt32(maxnumber) + 1;
                txtSerialNo.Text = maxSerialnumber.ToString();
            }
            else
            {
                txtSerialNo.Text = "1";
            }

            sql = @"SELECT     StudentAdmissionID, StudentId, StudentName, FatherName, MotherName, Department, Program, Semister, SSCgroup, SSCgrade, SSCboard, SSCyear, HSCgroup, HSCgrade, HSCboard, HSCyear, DiplomaGroup, DiplomaCGPA, 
                      DiplomaUnivrct, DiplomaYear, BBAgroup, BBAcgpa, BBAunivrct, BBAyear, MApreliGroup, MApreliCGPA, MApreliUnivrct, MApreliYear, MAfinalGroup, MAfinalCGPA, 
                      MAfinalUnivrct, MAfinalYear
FROM         dbo.Tbl_StudentAdmission";
            //            SELECT     StudentAdmissionID, SSCgroup, SSCgrade, SSCboard, SSCyear, HSCgroup, HSCgrade, HSCboard, HSCyear, DiplomaGroup, DiplomaCGPA, 
            //                      DiplomaUnivrct, DiplomaYear, BBAgroup, BBAcgpa, BBAunivrct, BBAyear, MApreliGroup, MApreliCGPA, MApreliUnivrct, MApreliYear, MAfinalGroup, MAfinalCGPA, 
            //                      MAfinalUnivrct, MAfinalYear
            //FROM         dbo.Tbl_StudentAdmission
            dt = DAL.GetData(sql);
            cmbStudentID.DataSource = dt;
            cmbStudentID.DisplayMember = "StudentId";
            cmbStudentID.ValueMember = "StudentAdmissionID";
            cmbStudentID.SelectedIndex = -1;
            cmbStudentName.DataSource = dt;
            cmbStudentName.DisplayMember = "StudentName";
            cmbStudentName.ValueMember = "StudentAdmissionID";
            cmbFatherName.DataSource = dt;
            cmbFatherName.DisplayMember = "FatherName";
            cmbFatherName.ValueMember = "StudentAdmissionID";
            cmbMotherName.DataSource = dt;
            cmbMotherName.DisplayMember = "MotherName";
            cmbMotherName.ValueMember = "StudentAdmissionID";
            cmbDepartment.DataSource = dt;
            cmbDepartment.DisplayMember = "Department";
            cmbDepartment.ValueMember = "StudentAdmissionID";
            cmbProgram.DataSource = dt;
            cmbProgram.DisplayMember = "Program";
            cmbProgram.ValueMember = "StudentAdmissionID";
            cmbSemister.DataSource = dt;
            cmbSemister.DisplayMember = "Semister";
            cmbSemister.ValueMember = "StudentAdmissionID";
            cmbSSCGroup.DataSource = dt;
            cmbSSCGroup.DisplayMember = "SSCgroup";
            cmbSSCGroup.ValueMember = "StudentAdmissionID";
            cmbSSCGrade.DataSource = dt;
            cmbSSCGrade.DisplayMember = "SSCgrade";
            cmbSSCGrade.ValueMember = "StudentAdmissionID";
            cmbSSCBoard.DataSource = dt;
            cmbSSCBoard.DisplayMember = "SSCboard";
            cmbSSCBoard.ValueMember = "StudentAdmissionID";
            cmbSSCYear.DataSource = dt;
            cmbSSCYear.DisplayMember = "SSCyear";
            cmbSSCYear.ValueMember = "StudentAdmissionID";
            cmbHSCGroup.DataSource = dt;
            cmbHSCGroup.DisplayMember = "HSCgroup";
            cmbHSCGroup.ValueMember = "StudentAdmissionID";
            cmbHSCGrade.DataSource = dt;
            cmbHSCGrade.DisplayMember = "HSCgrade";
            cmbHSCGrade.ValueMember = "StudentAdmissionID";
            cmbHSCBoard.DataSource = dt;
            cmbHSCBoard.DisplayMember = "HSCboard";
            cmbHSCBoard.ValueMember = "StudentAdmissionID";
            cmbHSCYear.DataSource = dt;
            cmbHSCYear.DisplayMember = "HSCyear";
            cmbHSCYear.ValueMember = "StudentAdmissionID";
            cmbDiplomaGroup.DataSource = dt;
            cmbDiplomaGroup.DisplayMember = "DiplomaGroup";
            cmbDiplomaGroup.ValueMember = "StudentAdmissionID";
            cmbDiplomaGrade.DataSource = dt;
            cmbDiplomaGrade.DisplayMember = "DiplomaCGPA";
            cmbDiplomaGrade.ValueMember = "StudentAdmissionID";
            cmbDiplomaUnivrct.DataSource = dt;
            cmbDiplomaUnivrct.DisplayMember = "DiplomaUnivrct";
            cmbDiplomaUnivrct.ValueMember = "StudentAdmissionID";
            cmbDiplomaYear.DataSource = dt;
            cmbDiplomaYear.DisplayMember = "DiplomaYear";
            cmbDiplomaYear.ValueMember = "StudentAdmissionID";
            cmbBBAGroup.DataSource = dt;
            cmbBBAGroup.DisplayMember = "BBAgroup";
            cmbBBAGroup.ValueMember = "StudentAdmissionID";
            cmbBBAcGPA.DataSource = dt;
            cmbBBAcGPA.DisplayMember = "BBAcgpa";
            cmbBBAcGPA.ValueMember = "StudentAdmissionID";
            cmbBBAUnivrct.DataSource = dt;
            cmbBBAUnivrct.DisplayMember = "BBAunivrct";
            cmbBBAUnivrct.ValueMember = "StudentAdmissionID";
            cmbBBAYear.DataSource = dt;
            cmbBBAYear.DisplayMember = "BBAyear";
            cmbBBAYear.ValueMember = "StudentAdmissionID";
            cmbMAPreliGroup.DataSource = dt;
            cmbMAPreliGroup.DisplayMember = "MApreliGroup";
            cmbMAPreliGroup.ValueMember = "StudentAdmissionID";
            cmbMAPrelicGPA.DataSource = dt;
            cmbMAPrelicGPA.DisplayMember = "MApreliCGPA";
            cmbMAPrelicGPA.ValueMember = "StudentAdmissionID";
            cmbMAPreliUnivrct.DataSource = dt;
            cmbMAPreliUnivrct.DisplayMember = "MApreliUnivrct";
            cmbMAPreliUnivrct.ValueMember = "StudentAdmissionID";
            cmbMAPreliYear.DataSource = dt;
            cmbMAPreliYear.DisplayMember = "MApreliYear";
            cmbMAPreliYear.ValueMember = "StudentAdmissionID";
            cmbMAFinalGroup.DataSource = dt;
            cmbMAFinalGroup.DisplayMember = "MAfinalGroup";
            cmbMAFinalGroup.ValueMember = "StudentAdmissionID";
            cmbMAFinalcGPA.DataSource = dt;
            cmbMAFinalcGPA.DisplayMember = "MAfinalCGPA";
            cmbMAFinalcGPA.ValueMember = "StudentAdmissionID";
            cmbMAFinalUnivrct.DataSource = dt;
            cmbMAFinalUnivrct.DisplayMember = "MAfinalUnivrct";
            cmbMAFinalUnivrct.ValueMember = "StudentAdmissionID";
            cmbMAFinalYear.DataSource = dt;
            cmbMAFinalYear.DisplayMember = "MAfinalYear";
            cmbMAFinalYear.ValueMember = "StudentAdmissionID";

            sql = @"SELECT     StudentRegistrationID, StudentId
FROM         dbo.Tbl_StudentRegistration";
            dt = DAL.GetData(sql);
            comSearchStudentID.DataSource = dt;
            comSearchStudentID.DisplayMember = "StudentId";
            comSearchStudentID.ValueMember = "StudentRegistrationID";
            comSearchStudentID.SelectedIndex = -1;
        }

        # region Member Variable
        string sql = "";
        string save = "";
        string StudentId = "";
        int StudentRegistrationID = 0;
        int SerialNo = 0;
        DataTable dt = null;
        # endregion        

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int SerialNo = Convert.ToInt32(txtSerialNo.Text.Trim().ToString());
            string StudentId = cmbStudentID.Text.Trim().ToString();
            string RegNo = txtRegNo.Text.Trim().ToString();
            string StudentName = cmbStudentName.Text.Trim().ToString();
            string FatherName = cmbFatherName.Text.Trim().ToString();
            string MotherName = cmbMotherName.Text.Trim().ToString();
            string Date = dateTimePicker1.Text.Trim().ToString();
            string Department = cmbDepartment.Text.Trim().ToString();
            string Program = cmbProgram.Text.Trim().ToString();
            string Batch = cmbBatch.Text.Trim().ToString();
            string Campus = cmbCampus.Text.Trim().ToString();
            string AdmissionSemester = cmbSemister.Text.Trim().ToString();
            string SSCgroup = cmbSSCGroup.Text.Trim().ToString();
            string SSCgpa = cmbSSCGrade.Text.Trim().ToString();
            string SSCboard = cmbSSCBoard.Text.Trim().ToString();
            string SSCsubject = txtSSCSubject.Text.Trim().ToString();
            string SSCschool = txtSSCSchool.Text.Trim().ToString();
            string SSCyear = cmbSSCYear.Text.Trim().ToString();
            string HSCgroup = cmbHSCGroup.Text.Trim().ToString();
            string HSCgpa = cmbHSCGrade.Text.Trim().ToString();
            string HSCboard = cmbHSCBoard.Text.Trim().ToString();
            string HSCsubject = txtHSCSubject.Text.Trim().ToString();
            string HSCcollege = txtHSCCollege.Text.Trim().ToString();
            string HSCyear = cmbHSCYear.Text.Trim().ToString();
            string DiplomaGroup = cmbDiplomaGroup.Text.Trim().ToString();
            string DiplomaCgpa = cmbDiplomaGrade.Text.Trim().ToString();
            string DiplomaUnivrct = cmbDiplomaUnivrct.Text.Trim().ToString();
            string DiplomaSubject = txtDiplomaSubject.Text.Trim().ToString();
            string DiplomaCollege = txtDiplomaCollege.Text.Trim().ToString();
            string DiplomaYear = cmbDiplomaYear.Text.Trim().ToString();
            string BBAgroup = cmbBBAGroup.Text.Trim().ToString();
            string BBAcgpa = cmbBBAcGPA.Text.Trim().ToString();
            string BBAunivrct = cmbBBAUnivrct.Text.Trim().ToString();
            string BBAsubject = txtBBASubject.Text.Trim().ToString();
            string BBAcollege = txtBBACollege.Text.Trim().ToString();
            string BBAyear = cmbBBAYear.Text.Trim().ToString();
            string MApreliGroup = cmbMAPreliGroup.Text.Trim().ToString();
            string MApreliCGPA = cmbMAPrelicGPA.Text.Trim().ToString();
            string MApreliUnivrct = cmbMAPreliUnivrct.Text.Trim().ToString();
            string MApreliSubject = txtMAPreliSubject.Text.Trim().ToString();
            string MApreliCollege = txtMAPreliCollege.Text.Trim().ToString();
            string MApreliYear = cmbMAPreliYear.Text.Trim().ToString();
            string MAfinalGroup = cmbMAFinalGroup.Text.Trim().ToString();
            string MAfinalCGPA = cmbMAFinalcGPA.Text.Trim().ToString();
            string MAfinalUnivrct = cmbMAFinalUnivrct.Text.Trim().ToString();
            string MAfinalSubject = txtMAFinalSubject.Text.Trim().ToString();
            string MAfinalCollege = txtMAFinalCollege.Text.Trim().ToString();
            string MAfinalYear = cmbMAFinalYear.Text.Trim().ToString();
            string RegisterSign = txtRegistarSign.Text.Trim().ToString();
            string ChairmanSign = txtChairpersonSign.Text.Trim().ToString();
            save = DPL.Save_Tbl_StudentRegistration(SerialNo, StudentId, RegNo, StudentName, FatherName, MotherName, Date, Department, Program, Batch, Campus, AdmissionSemester, SSCgroup, SSCgpa, SSCboard, SSCsubject, SSCschool, SSCyear, HSCgroup, HSCgpa, HSCboard, HSCsubject, HSCcollege, HSCyear, DiplomaGroup, DiplomaCgpa, DiplomaUnivrct, DiplomaSubject, DiplomaCollege, DiplomaYear, BBAgroup, BBAcgpa, BBAunivrct, BBAsubject, BBAcollege, BBAyear, MApreliGroup, MApreliCGPA, MApreliUnivrct, MApreliSubject, MApreliCollege, MApreliYear, MAfinalGroup, MAfinalCGPA, MAfinalUnivrct, MAfinalSubject, MAfinalCollege, MAfinalYear, RegisterSign, ChairmanSign);
            //save = DPL.Save_Table_StudentRegistration(SerialNo, StudentId, RegNo, StudentName, FatherName, MotherName, Date, Department, Program, Batch, Campus, AdmissionSemester, SSCgroup, SSCgpa, SSCboard, SSCsubject, SSCschool, SSCyear, HSCgroup, HSCgpa, HSCboard, HSCsubject, HSCcollege, HSCyear, DiplomaGroup, DiplomaCgpa, DiplomaUnivrct, DiplomaSubject, DiplomaCollege, DiplomaYear, BBAgroup, BBAcgpa, BBAunivrct, BBAsubject, BBAcollege, BBAyear, MApreliGroup, MApreliCGPA, MApreliUnivrct, MApreliSubject, MApreliCollege, MApreliYear, MAfinalGroup, MAfinalCGPA, MAfinalUnivrct, MApreliSubject, MApreliCollege, MAfinalYear, RegisterSign, ChairmanSign);
            if (save == "Succeded")
            {
                sql = @"SELECT     StudentRegistrationID, SerialNo, StudentId, RegNo, StudentName, FatherName, MotherName, Date, Department, Program, Batch, Campus, AdmissionSemester, 
                      SSCgroup, SSCgpa, SSCboard, SSCsubject, SSCschool, SSCyear, HSCgroup, HSCgpa, HSCboard, HSCsubject, HSCcollege, HSCyear, DiplomaGroup, DiplomaCgpa, 
                      DiplomaUnivrct, DiplomaSubject, DiplomaCollege, DiplomaYear, BBAgroup, BBAcgpa, BBAunivrct, BBAsubject, BBAcollege, BBAyear, MApreliGroup, MApreliCGPA, 
                      MApreliUnivrct, MApreliSubject, MApreliCollege, MApreliYear, MAfinalGroup, MAfinalCGPA, MAfinalUnivrct, MAfinalSubject, MAfinalCollege, MAfinalYear, RegisterSign, 
                      ChairmanSign
FROM         dbo.Tbl_StudentRegistration
WHERE     (StudentId = '" + StudentId + "')";
                dt = DAL.GetData(sql);
                dataGridView1.DataSource = dt;
                MessageBox.Show("Succeded");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string update = "";
            int SerialNo = Convert.ToInt32(txtSerialNo.Text.Trim().ToString());
            string StudentId = cmbStudentID.Text.Trim().ToString();
            string RegNo = txtRegNo.Text.Trim().ToString();
            string StudentName = cmbStudentName.Text.Trim().ToString();
            string FatherName = cmbFatherName.Text.Trim().ToString();
            string MotherName = cmbMotherName.Text.Trim().ToString();
            string Date = dateTimePicker1.Text.Trim().ToString();
            string Department = cmbDepartment.Text.Trim().ToString();
            string Program = cmbProgram.Text.Trim().ToString();
            string Batch = cmbBatch.Text.Trim().ToString();
            string Campus = cmbCampus.Text.Trim().ToString();
            string AdmissionSemester = cmbSemister.Text.Trim().ToString();
            string SSCgroup = cmbSSCGroup.Text.Trim().ToString();
            string SSCgpa = cmbSSCGrade.Text.Trim().ToString();
            string SSCboard = cmbSSCBoard.Text.Trim().ToString();
            string SSCsubject = txtSSCSubject.Text.Trim().ToString();
            string SSCschool = txtSSCSchool.Text.Trim().ToString();
            string SSCyear = cmbSSCYear.Text.Trim().ToString();
            string HSCgroup = cmbHSCGroup.Text.Trim().ToString();
            string HSCgpa = cmbHSCGrade.Text.Trim().ToString();
            string HSCboard = cmbHSCBoard.Text.Trim().ToString();
            string HSCsubject = txtHSCSubject.Text.Trim().ToString();
            string HSCcollege = txtHSCCollege.Text.Trim().ToString();
            string HSCyear = cmbHSCYear.Text.Trim().ToString();
            string DiplomaGroup = cmbDiplomaGroup.Text.Trim().ToString();
            string DiplomaCgpa = cmbDiplomaGrade.Text.Trim().ToString();
            string DiplomaUnivrct = cmbDiplomaUnivrct.Text.Trim().ToString();
            string DiplomaSubject = txtDiplomaSubject.Text.Trim().ToString();
            string DiplomaCollege = txtDiplomaCollege.Text.Trim().ToString();
            string DiplomaYear = cmbDiplomaYear.Text.Trim().ToString();
            string BBAgroup = cmbBBAGroup.Text.Trim().ToString();
            string BBAcgpa = cmbBBAcGPA.Text.Trim().ToString();
            string BBAunivrct = cmbBBAUnivrct.Text.Trim().ToString();
            string BBAsubject = txtBBASubject.Text.Trim().ToString();
            string BBAcollege = txtBBACollege.Text.Trim().ToString();
            string BBAyear = cmbBBAYear.Text.Trim().ToString();
            string MApreliGroup = cmbMAPreliGroup.Text.Trim().ToString();
            string MApreliCGPA = cmbMAPrelicGPA.Text.Trim().ToString();
            string MApreliUnivrct = cmbMAPreliUnivrct.Text.Trim().ToString();
            string MApreliSubject = txtMAPreliSubject.Text.Trim().ToString();
            string MApreliCollege = txtMAPreliCollege.Text.Trim().ToString();
            string MApreliYear = cmbMAPreliYear.Text.Trim().ToString();
            string MAfinalGroup = cmbMAFinalGroup.Text.Trim().ToString();
            string MAfinalCGPA = cmbMAFinalcGPA.Text.Trim().ToString();
            string MAfinalUnivrct = cmbMAFinalUnivrct.Text.Trim().ToString();
            string MAfinalSubject = txtMAFinalSubject.Text.Trim().ToString();
            string MAfinalCollege = txtMAFinalCollege.Text.Trim().ToString();
            string MAfinalYear = cmbMAFinalYear.Text.Trim().ToString();
            string RegisterSign = txtRegistarSign.Text.Trim().ToString();
            string ChairmanSign = txtChairpersonSign.Text.Trim().ToString();
            update = DPL.Update_Tbl_StudentRegistration(StudentRegistrationID, SerialNo, StudentId, RegNo, StudentName, FatherName, MotherName, Date, Department, Program, Batch, Campus, AdmissionSemester, SSCgroup, SSCgpa, SSCboard, SSCsubject, SSCschool, SSCyear, HSCgroup, HSCgpa, HSCboard, HSCsubject, HSCcollege, HSCyear, DiplomaGroup, DiplomaCgpa, DiplomaUnivrct, DiplomaSubject, DiplomaCollege, DiplomaYear, BBAgroup, BBAcgpa, BBAunivrct, BBAsubject, BBAcollege, BBAyear, MApreliGroup, MApreliCGPA, MApreliUnivrct, MApreliSubject, MApreliCollege, MApreliYear, MAfinalGroup, MAfinalCGPA, MAfinalUnivrct, MAfinalSubject, MAfinalCollege, MAfinalYear, RegisterSign, ChairmanSign);
            if (update == "Succeded")
            {
                sql = @"SELECT     StudentRegistrationID, SerialNo, StudentId, RegNo, StudentName, FatherName, MotherName, Date, Department, Program, Batch, Campus, AdmissionSemester, 
                      SSCgroup, SSCgpa, SSCboard, SSCsubject, SSCschool, SSCyear, HSCgroup, HSCgpa, HSCboard, HSCsubject, HSCcollege, HSCyear, DiplomaGroup, DiplomaCgpa, 
                      DiplomaUnivrct, DiplomaSubject, DiplomaCollege, DiplomaYear, BBAgroup, BBAcgpa, BBAunivrct, BBAsubject, BBAcollege, BBAyear, MApreliGroup, MApreliCGPA, 
                      MApreliUnivrct, MApreliSubject, MApreliCollege, MApreliYear, MAfinalGroup, MAfinalCGPA, MAfinalUnivrct, MAfinalSubject, MAfinalCollege, MAfinalYear, RegisterSign, 
                      ChairmanSign
FROM         dbo.Tbl_StudentRegistration
WHERE     (StudentId = '" + StudentId + "')";
                dt = DAL.GetData(sql);
                dataGridView1.DataSource = dt;
                MessageBox.Show("Succeded");
            }
        }

        private void btnAddnew_Click(object sender, EventArgs e)
        {
            txtSerialNo.Text = "";
            sql = @"SELECT     MAX(SerialNo) AS SerialNo
FROM         dbo.Tbl_StudentRegistration";
            dt = DAL.GetData(sql);
            string maxnumber = dt.Rows[0]["SerialNo"].ToString();
            if (maxnumber != "")
            {
                int maxSerialnumber = Convert.ToInt32(maxnumber) + 1;
                txtSerialNo.Text = maxSerialnumber.ToString();
            }
            cmbStudentID.Text = "";
            txtRegNo.Text = "";
            cmbStudentName.Text = "";
            cmbFatherName.Text = "";
            cmbMotherName.Text = "";
            dateTimePicker1.Text = "";
            cmbDepartment.Text = "";
            cmbProgram.Text = "";
            cmbBatch.Text = "";
            cmbCampus.Text = "";
            cmbSemister.Text = "";
            cmbSSCGroup.Text = "";
            cmbSSCGrade.Text = "";
            cmbSSCBoard.Text = "";
            txtSSCSubject.Text = "";
            txtSSCSchool.Text = "";
            cmbSSCYear.Text = "";
            cmbHSCGroup.Text = "";
            cmbHSCGrade.Text = "";
            cmbHSCBoard.Text = "";
            txtHSCSubject.Text = "";
            txtHSCCollege.Text = "";
            cmbHSCYear.Text = "";
            cmbDiplomaGroup.Text = "";
            cmbDiplomaGrade.Text = "";
            cmbDiplomaUnivrct.Text = "";
            txtDiplomaSubject.Text = "";
            txtDiplomaCollege.Text = "";
            cmbDiplomaYear.Text = "";
            cmbBBAGroup.Text = "";
            cmbBBAcGPA.Text = "";
            cmbBBAUnivrct.Text = "";
            txtBBASubject.Text = "";
            txtBBACollege.Text = "";
            cmbBBAYear.Text = "";
            cmbMAPreliGroup.Text = "";
            cmbMAPrelicGPA.Text = "";
            cmbMAPreliUnivrct.Text = "";
            txtMAPreliSubject.Text = "";
            txtMAPreliCollege.Text = "";
            cmbMAPreliYear.Text = "";
            cmbMAFinalGroup.Text = "";
            cmbMAFinalcGPA.Text = "";
            cmbMAFinalUnivrct.Text = "";
            txtMAFinalSubject.Text = "";
            txtMAFinalCollege.Text = "";
            cmbMAFinalYear.Text = "";
            txtRegistarSign.Text = "";
            txtChairpersonSign.Text = "";
            dataGridView1.DataSource = null;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                int rowindex = Convert.ToInt32(dataGridView1.SelectedRows[0].Index);
                int SerialNo = Convert.ToInt32(dataGridView1.Rows[rowindex].Cells["SerialNo"].Value.ToString());
                string StudentId = dataGridView1.Rows[rowindex].Cells["StudentId"].Value.ToString();
                string RegNo = dataGridView1.Rows[rowindex].Cells["RegNo"].Value.ToString();
                string StudentName = dataGridView1.Rows[rowindex].Cells["StudentName"].Value.ToString();
                string FatherName = dataGridView1.Rows[rowindex].Cells["FatherName"].Value.ToString();
                string MotherName = dataGridView1.Rows[rowindex].Cells["MotherName"].Value.ToString();
                string Date = dataGridView1.Rows[rowindex].Cells["Date"].Value.ToString();
                string Department = dataGridView1.Rows[rowindex].Cells["Department"].Value.ToString();
                string Program = dataGridView1.Rows[rowindex].Cells["Program"].Value.ToString();
                string Batch = dataGridView1.Rows[rowindex].Cells["Batch"].Value.ToString();
                string Campus = dataGridView1.Rows[rowindex].Cells["Campus"].Value.ToString();
                string AdmissionSemester = dataGridView1.Rows[rowindex].Cells["AdmissionSemester"].Value.ToString();
                string SSCgroup = dataGridView1.Rows[rowindex].Cells["SSCgroup"].Value.ToString();
                string SSCgpa = dataGridView1.Rows[rowindex].Cells["SSCgpa"].Value.ToString();
                string SSCboard = dataGridView1.Rows[rowindex].Cells["SSCboard"].Value.ToString();
                string SSCsubject = dataGridView1.Rows[rowindex].Cells["SSCsubject"].Value.ToString();
                string SSCschool = dataGridView1.Rows[rowindex].Cells["SSCschool"].Value.ToString();
                string SSCyear = dataGridView1.Rows[rowindex].Cells["SSCyear"].Value.ToString();
                string HSCgroup = dataGridView1.Rows[rowindex].Cells["HSCgroup"].Value.ToString();
                string HSCgpa = dataGridView1.Rows[rowindex].Cells["HSCgpa"].Value.ToString();
                string HSCboard = dataGridView1.Rows[rowindex].Cells["HSCboard"].Value.ToString();
                string HSCsubject = dataGridView1.Rows[rowindex].Cells["HSCsubject"].Value.ToString();
                string HSCcollege = dataGridView1.Rows[rowindex].Cells["HSCcollege"].Value.ToString();
                string HSCyear = dataGridView1.Rows[rowindex].Cells["HSCyear"].Value.ToString();
                string DiplomaGroup = dataGridView1.Rows[rowindex].Cells["DiplomaGroup"].Value.ToString();
                string DiplomaCgpa = dataGridView1.Rows[rowindex].Cells["DiplomaCgpa"].Value.ToString();
                string DiplomaUnivrct = dataGridView1.Rows[rowindex].Cells["DiplomaUnivrct"].Value.ToString();
                string DiplomaSubject = dataGridView1.Rows[rowindex].Cells["DiplomaSubject"].Value.ToString();
                string DiplomaCollege = dataGridView1.Rows[rowindex].Cells["DiplomaCollege"].Value.ToString();
                string DiplomaYear = dataGridView1.Rows[rowindex].Cells["DiplomaYear"].Value.ToString();
                string BBAgroup = dataGridView1.Rows[rowindex].Cells["BBAgroup"].Value.ToString();
                string BBAcgpa = dataGridView1.Rows[rowindex].Cells["BBAcgpa"].Value.ToString();
                string BBAunivrct = dataGridView1.Rows[rowindex].Cells["BBAunivrct"].Value.ToString();
                string BBAsubject = dataGridView1.Rows[rowindex].Cells["BBAsubject"].Value.ToString();
                string BBAcollege = dataGridView1.Rows[rowindex].Cells["BBAcollege"].Value.ToString();
                string BBAyear = dataGridView1.Rows[rowindex].Cells["BBAyear"].Value.ToString();
                string MApreliGroup = dataGridView1.Rows[rowindex].Cells["MApreliGroup"].Value.ToString();
                string MApreliCGPA = dataGridView1.Rows[rowindex].Cells["MApreliCGPA"].Value.ToString();
                string MApreliUnivrct = dataGridView1.Rows[rowindex].Cells["MApreliUnivrct"].Value.ToString();
                string MApreliSubject = dataGridView1.Rows[rowindex].Cells["MApreliSubject"].Value.ToString();
                string MApreliCollege = dataGridView1.Rows[rowindex].Cells["MApreliCollege"].Value.ToString();
                string MApreliYear = dataGridView1.Rows[rowindex].Cells["MApreliYear"].Value.ToString();
                string MAfinalGroup = dataGridView1.Rows[rowindex].Cells["MAfinalGroup"].Value.ToString();
                string MAfinalCGPA = dataGridView1.Rows[rowindex].Cells["MAfinalCGPA"].Value.ToString();
                string MAfinalUnivrct = dataGridView1.Rows[rowindex].Cells["MAfinalUnivrct"].Value.ToString();
                string MAfinalSubject = dataGridView1.Rows[rowindex].Cells["MAfinalSubject"].Value.ToString();
                string MAfinalCollege = dataGridView1.Rows[rowindex].Cells["MAfinalCollege"].Value.ToString();
                string MAfinalYear = dataGridView1.Rows[rowindex].Cells["MAfinalYear"].Value.ToString();
                string RegisterSign = dataGridView1.Rows[rowindex].Cells["RegisterSign"].Value.ToString();
                string ChairmanSign = dataGridView1.Rows[rowindex].Cells["ChairmanSign"].Value.ToString();
                StudentRegistrationID = Convert.ToInt32(dataGridView1.Rows[rowindex].Cells["StudentRegistrationID"].Value.ToString());

                txtSerialNo.Text = SerialNo.ToString();
                cmbStudentID.Text = StudentId;
                txtRegNo.Text = RegNo;
                cmbStudentName.Text = StudentName;
                cmbFatherName.Text = FatherName;
                cmbMotherName.Text = MotherName;
                dateTimePicker1.Text = Date;
                cmbDepartment.Text = Department;
                cmbProgram.Text = Program;
                cmbBatch.Text = Batch;
                cmbCampus.Text = Campus;
                cmbSemister.Text = AdmissionSemester;
                cmbSSCGroup.Text = SSCgroup;
                cmbSSCGrade.Text = SSCgpa;
                cmbSSCBoard.Text = SSCboard;
                txtSSCSubject.Text = SSCsubject;
                txtSSCSchool.Text = SSCschool;
                cmbSSCYear.Text = SSCyear;
                cmbHSCGroup.Text = HSCgroup;
                cmbHSCGrade.Text = HSCgpa;
                cmbHSCBoard.Text = HSCboard;
                txtHSCSubject.Text = HSCsubject;
                txtHSCCollege.Text = HSCcollege;
                cmbHSCYear.Text = HSCyear;
                cmbDiplomaGroup.Text = DiplomaGroup;
                cmbDiplomaGrade.Text = DiplomaCgpa;
                cmbDiplomaUnivrct.Text = DiplomaUnivrct;
                txtDiplomaSubject.Text = DiplomaSubject;
                txtDiplomaCollege.Text = DiplomaCollege;
                cmbDiplomaYear.Text = DiplomaYear;
                cmbBBAGroup.Text = BBAgroup;
                cmbBBAcGPA.Text = BBAcgpa;
                cmbBBAUnivrct.Text = BBAunivrct;
                txtBBASubject.Text = BBAsubject;
                txtBBACollege.Text = BBAcollege;
                cmbBBAYear.Text = BBAyear;
                cmbMAPreliGroup.Text = MApreliGroup;
                cmbMAPrelicGPA.Text = MApreliCGPA;
                cmbMAPreliUnivrct.Text = MApreliUnivrct;
                txtMAPreliSubject.Text = MApreliSubject;
                txtMAPreliCollege.Text = MApreliCollege;
                cmbMAPreliYear.Text = MApreliYear;
                cmbMAFinalGroup.Text = MAfinalGroup;
                cmbMAFinalcGPA.Text = MAfinalCGPA;
                cmbMAFinalUnivrct.Text = MAfinalUnivrct;
                txtMAFinalSubject.Text = MAfinalSubject;
                txtMAFinalCollege.Text = MAfinalCollege;
                cmbMAFinalYear.Text = MAfinalYear;
                txtRegistarSign.Text = RegisterSign;
                txtChairpersonSign.Text = ChairmanSign;
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
                    DetailsDelete = DPL.Delete_tbl_Value("Tbl_StudentRegistration", "StudentRegistrationID", StudentRegistrationID);
                    if (DetailsDelete == "Succeded")
                    {
                        MessageBox.Show("Succeded");
                        sql = @"SELECT     StudentRegistrationID, SerialNo, StudentId, RegNo, StudentName, FatherName, MotherName, Date, Department, Program, Batch, Campus, AdmissionSemester, 
                      SSCgroup, SSCgpa, SSCboard, SSCsubject, SSCschool, SSCyear, HSCgroup, HSCgpa, HSCboard, HSCsubject, HSCcollege, HSCyear, DiplomaGroup, DiplomaCgpa, 
                      DiplomaUnivrct, DiplomaSubject, DiplomaCollege, DiplomaYear, BBAgroup, BBAcgpa, BBAunivrct, BBAsubject, BBAcollege, BBAyear, MApreliGroup, MApreliCGPA, 
                      MApreliUnivrct, MApreliSubject, MApreliCollege, MApreliYear, MAfinalGroup, MAfinalCGPA, MAfinalUnivrct, MAfinalSubject, MAfinalCollege, MAfinalYear, RegisterSign, 
                      ChairmanSign
FROM         dbo.Tbl_StudentRegistration
WHERE     (StudentId = '" + StudentId + "')";

                        dt = DAL.GetData(sql);
                        dataGridView1.DataSource = dt;
                        StudentRegistrationID = 0;
                    }

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
                    sql = @"SELECT     StudentRegistrationID, SerialNo, StudentId, RegNo, StudentName, FatherName, MotherName, Date, Department, Program, Batch, Campus, AdmissionSemester, 
                      SSCgroup, SSCgpa, SSCboard, SSCsubject, SSCschool, SSCyear, HSCgroup, HSCgpa, HSCboard, HSCsubject, HSCcollege, HSCyear, DiplomaGroup, DiplomaCgpa, 
                      DiplomaUnivrct, DiplomaSubject, DiplomaCollege, DiplomaYear, BBAgroup, BBAcgpa, BBAunivrct, BBAsubject, BBAcollege, BBAyear, MApreliGroup, MApreliCGPA, 
                      MApreliUnivrct, MApreliSubject, MApreliCollege, MApreliYear, MAfinalGroup, MAfinalCGPA, MAfinalUnivrct, MAfinalSubject, MAfinalCollege, MAfinalYear, RegisterSign, 
                      ChairmanSign
FROM         dbo.Tbl_StudentRegistration
WHERE     (StudentId = '" + StudentId + "')";
                    dt = DAL.GetData(sql);
                    dataGridView1.DataSource = dt;
                }
            }
        }
        private void txtSerialNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Return")
            {
                if (txtSerialNo.Text.Trim().ToString() != "")
                {
                    cmbStudentID.Focus();
                    cmbStudentID.Select();
                }
                else
                {
                    MessageBox.Show("Select serial no");
                    txtSerialNo.Focus();
                    txtSerialNo.Select();
                }
            }
        }

        private void txtSerialNo_Enter(object sender, EventArgs e)
        {
            txtSerialNo.ForeColor = Color.White;
            txtSerialNo.BackColor = Color.CadetBlue;
        }

        private void txtSerialNo_Leave(object sender, EventArgs e)
        {
            txtSerialNo.ForeColor = Color.Black;
            txtSerialNo.BackColor = Color.White;
        }

        private void cmbStudentID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Return")
            {
                if (cmbStudentID.Text.Trim().ToString() != "")
                {
                    txtRegNo.Focus();
                    txtRegNo.Select();
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

        private void txtRegNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Return")
            {
                if (txtRegNo.Text.Trim().ToString() != "")
                {
                    cmbStudentName.Focus();
                    cmbStudentName.Select();
                }
                else
                {
                    MessageBox.Show("Select reg no");
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

        private void cmbStudentName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Return")
            {
                if (cmbStudentName.Text.Trim().ToString() != "")
                {
                    cmbFatherName.Focus();
                    cmbFatherName.Select();
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

        private void cmbFatherName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Return")
            {
                if (cmbFatherName.Text.Trim().ToString() != "")
                {
                    cmbMotherName.Focus();
                    cmbMotherName.Select();
                }
                else
                {
                    MessageBox.Show("Select father name");
                    cmbFatherName.Focus();
                    cmbFatherName.Select();
                }
            }
        }

        private void cmbFatherName_Enter(object sender, EventArgs e)
        {
            cmbFatherName.ForeColor = Color.White;
            cmbFatherName.BackColor = Color.CadetBlue;
        }

        private void cmbFatherName_Leave(object sender, EventArgs e)
        {
            cmbFatherName.ForeColor = Color.Black;
            cmbFatherName.BackColor = Color.White;
        }

        private void cmbMotherName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Return")
            {
                if (cmbMotherName.Text.Trim().ToString() != "")
                {
                    dateTimePicker1.Focus();
                    dateTimePicker1.Select();
                }
                else
                {
                    MessageBox.Show("Select mother name");
                    cmbMotherName.Focus();
                    cmbMotherName.Select();
                }
            }
        }

        private void cmbMotherName_Enter(object sender, EventArgs e)
        {
            cmbMotherName.ForeColor = Color.White;
            cmbMotherName.BackColor = Color.CadetBlue;
        }

        private void cmbMotherName_Leave(object sender, EventArgs e)
        {
            cmbMotherName.ForeColor = Color.Black;
            cmbMotherName.BackColor = Color.White;
        }

        private void dateTimePicker1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Return")
            {
                if (dateTimePicker1.Text.Trim().ToString() != "")
                {
                    cmbDepartment.Focus();
                    cmbDepartment.Select();
                }
            }
        }

        private void cmbDepartment_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Return")
            {
                if (cmbDepartment.Text.Trim().ToString() != "")
                {
                    cmbProgram.Focus();
                    cmbProgram.Select();
                }
                else
                {
                    MessageBox.Show("Select department");
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
                    cmbCampus.Focus();
                    cmbCampus.Select();
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

        private void cmbCampus_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Return")
            {
                if (cmbCampus.Text.Trim().ToString() != "")
                {
                    cmbSemister.Focus();
                    cmbSemister.Select();
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

        private void cmbSemister_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Return")
            {
                if (cmbSemister.Text.Trim().ToString() != "")
                {
                    txtSSCSubject.Focus();
                    txtSSCSubject.Select();
                }
                else
                {
                    MessageBox.Show("Select admission semister");
                    cmbSemister.Focus();
                    cmbSemister.Select();
                }
            }
        }

        private void cmbSemister_Enter(object sender, EventArgs e)
        {
            cmbSemister.ForeColor = Color.White;
            cmbSemister.BackColor = Color.CadetBlue;
        }

        private void cmbSemister_Leave(object sender, EventArgs e)
        {
            cmbSemister.ForeColor = Color.Black;
            cmbSemister.BackColor = Color.White;
        }
        private void txtSSCSubject_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Return")
            {
                if (txtSSCSubject.Text.Trim().ToString() != "")
                {
                    txtSSCSchool.Focus();
                    txtSSCSchool.Select();
                }
                else
                {
                    MessageBox.Show("Select SSC subject");
                    txtSSCSubject.Focus();
                    txtSSCSubject.Select();
                }
            }
        }

        private void txtSSCSubject_Enter(object sender, EventArgs e)
        {
            txtSSCSubject.ForeColor = Color.White;
            txtSSCSubject.BackColor = Color.CadetBlue;
        }

        private void txtSSCSubject_Leave(object sender, EventArgs e)
        {
            txtSSCSubject.ForeColor = Color.Black;
            txtSSCSubject.BackColor = Color.White;
        }

        private void txtSSCSchool_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Return")
            {
                if (txtSSCSchool.Text.Trim().ToString() != "")
                {
                    txtHSCSubject.Focus();
                    txtHSCSubject.Select();
                }
                else
                {
                    MessageBox.Show("Select SSC school");
                    txtSSCSchool.Focus();
                    txtSSCSchool.Select();
                }
            }
        }

        private void txtSSCSchool_Enter(object sender, EventArgs e)
        {
            txtSSCSchool.ForeColor = Color.White;
            txtSSCSchool.BackColor = Color.CadetBlue;
        }

        private void txtSSCSchool_Leave(object sender, EventArgs e)
        {
            txtSSCSchool.ForeColor = Color.Black;
            txtSSCSchool.BackColor = Color.White;
        }

        //private void cmbSSCYear_KeyDown(object sender, KeyEventArgs e)
        //{
        //    if (e.KeyCode.ToString() == "Return")
        //    {
        //        if (cmbSSCYear.Text.Trim().ToString() != "")
        //        {
        //            cmbHSCGroup.Focus();
        //            cmbHSCGroup.Select();
        //        }
        //        else
        //        {
        //            MessageBox.Show("Select SSC year");
        //            cmbSSCYear.Focus();
        //            cmbSSCYear.Select();
        //        }
        //    }
        //}

        //private void cmbSSCYear_Enter(object sender, EventArgs e)
        //{
        //    cmbSSCYear.ForeColor = Color.White;
        //    cmbSSCYear.BackColor = Color.CadetBlue;
        //}

        //private void cmbSSCYear_Leave(object sender, EventArgs e)
        //{
        //    cmbSSCYear.ForeColor = Color.Black;
        //    cmbSSCYear.BackColor = Color.White;
        //}

        //private void cmbHSCGroup_KeyDown(object sender, KeyEventArgs e)
        //{
        //    if (e.KeyCode.ToString() == "Return")
        //    {
        //        if (cmbHSCGroup.Text.Trim().ToString() != "")
        //        {
        //            cmbHSCGrade.Focus();
        //            cmbHSCGrade.Select();
        //        }
        //        else
        //        {
        //            MessageBox.Show("Select HSC group");
        //            cmbHSCGroup.Focus();
        //            cmbHSCGroup.Select();
        //        }
        //    }
        //}

        //private void cmbHSCGroup_Enter(object sender, EventArgs e)
        //{
        //    cmbHSCGroup.ForeColor = Color.White;
        //    cmbHSCGroup.BackColor = Color.CadetBlue;
        //}

        //private void cmbHSCGroup_Leave(object sender, EventArgs e)
        //{
        //    cmbHSCGroup.ForeColor = Color.Black;
        //    cmbHSCGroup.BackColor = Color.White;
        //}

        //private void cmbHSCGrade_KeyDown(object sender, KeyEventArgs e)
        //{
        //    if (e.KeyCode.ToString() == "Return")
        //    {
        //        if (cmbHSCGrade.Text.Trim().ToString() != "")
        //        {
        //            cmbHSCBoard.Focus();
        //            cmbHSCBoard.Select();
        //        }
        //        else
        //        {
        //            MessageBox.Show("Return");
        //            cmbHSCGrade.Focus();
        //            cmbHSCGrade.Select();
        //        }
        //    }
        //}

        //private void cmbHSCGrade_Enter(object sender, EventArgs e)
        //{
        //    cmbHSCGrade.ForeColor = Color.White;
        //    cmbHSCGrade.BackColor = Color.CadetBlue;
        //}

        //private void cmbHSCGrade_Leave(object sender, EventArgs e)
        //{
        //    cmbHSCGrade.ForeColor = Color.Black;
        //    cmbHSCGrade.BackColor = Color.White;
        //}

        //private void cmbHSCBoard_KeyDown(object sender, KeyEventArgs e)
        //{
        //    if (e.KeyCode.ToString() == "Return")
        //    {
        //        if (cmbHSCBoard.Text.Trim().ToString() != "")
        //        {
        //            txtHSCSubject.Focus();
        //            txtHSCSubject.Select();
        //        }
        //        else
        //        {
        //            MessageBox.Show("Select HSC board");
        //            cmbHSCBoard.Focus();
        //            cmbHSCBoard.Select();
        //        }
        //    }
        //}

        //private void cmbHSCBoard_Enter(object sender, EventArgs e)
        //{
        //    cmbHSCBoard.ForeColor = Color.White;
        //    cmbHSCBoard.BackColor = Color.CadetBlue;
        //}

        //private void cmbHSCBoard_Leave(object sender, EventArgs e)
        //{
        //    cmbHSCBoard.ForeColor = Color.Black;
        //    cmbHSCBoard.BackColor = Color.White;
        //}

        private void txtHSCSubject_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Return")
            {
                if (txtHSCSubject.Text.Trim().ToString() != "")
                {
                    txtHSCCollege.Focus();
                    txtHSCCollege.Select();
                }
                else
                {
                    MessageBox.Show("Select HSC subject");
                    txtHSCSubject.Focus();
                    txtHSCSubject.Select();
                }
            }
        }

        private void txtHSCSubject_Enter(object sender, EventArgs e)
        {
            txtHSCSubject.ForeColor = Color.White;
            txtHSCSubject.BackColor = Color.CadetBlue;
        }

        private void txtHSCSubject_Leave(object sender, EventArgs e)
        {
            txtHSCSubject.ForeColor = Color.Black;
            txtHSCSubject.BackColor = Color.White;
        }

        private void txtHSCCollege_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Return")
            {
                if (txtHSCCollege.Text.Trim().ToString() != "")
                {
                    txtDiplomaSubject.Focus();
                    txtDiplomaSubject.Select();
                }
                else
                {
                    MessageBox.Show("Select HSC college");
                    txtHSCCollege.Focus();
                    txtHSCCollege.Select();
                }
            }
        }

        private void txtHSCCollege_Enter(object sender, EventArgs e)
        {
            txtHSCCollege.ForeColor = Color.White;
            txtHSCCollege.BackColor = Color.CadetBlue;
        }

        private void txtHSCCollege_Leave(object sender, EventArgs e)
        {
            txtHSCCollege.ForeColor = Color.Black;
            txtHSCCollege.BackColor = Color.White;
        }

        //private void cmbHSCYear_KeyDown(object sender, KeyEventArgs e)
        //{
        //    if (e.KeyCode.ToString() == "Return")
        //    {
        //        if (cmbHSCYear.Text.Trim().ToString() != "")
        //        {
        //            txtDiplomaSubject.Focus();
        //            txtDiplomaSubject.Select();
        //        }
        //        else
        //        {
        //            MessageBox.Show("Select HSC year");
        //            cmbHSCYear.Focus();
        //            cmbHSCYear.Select();
        //        }
        //    }
        //}

        //private void cmbHSCYear_Enter(object sender, EventArgs e)
        //{
        //    cmbHSCYear.ForeColor = Color.White;
        //    cmbHSCYear.BackColor = Color.CadetBlue;
        //}

        //private void cmbHSCYear_Leave(object sender, EventArgs e)
        //{
        //    cmbHSCYear.ForeColor = Color.Black;
        //    cmbHSCYear.BackColor = Color.White;
        //}

        //private void cmbDiplomaGroup_KeyDown(object sender, KeyEventArgs e)
        //{
        //    if (e.KeyCode.ToString() == "Return")
        //    {
        //        if (cmbDiplomaGroup.Text.Trim().ToString() != "")
        //        {
        //            cmbDiplomaGrade.Focus();
        //            cmbDiplomaGrade.Select();
        //        }
        //        else
        //        {
        //            MessageBox.Show("Select diploma group");
        //            cmbDiplomaGroup.Focus();
        //            cmbDiplomaGroup.Select();
        //        }
        //    }
        //}

        //private void cmbDiplomaGroup_Enter(object sender, EventArgs e)
        //{
        //    cmbDiplomaGroup.ForeColor = Color.White;
        //    cmbDiplomaGroup.BackColor = Color.CadetBlue;
        //}

        //private void cmbDiplomaGroup_Leave(object sender, EventArgs e)
        //{
        //    cmbDiplomaGroup.ForeColor = Color.Black;
        //    cmbDiplomaGroup.BackColor = Color.White;
        //}

        //private void cmbDiplomaGrade_KeyDown(object sender, KeyEventArgs e)
        //{
        //    if (e.KeyCode.ToString() == "Return")
        //    {
        //        if (cmbDiplomaGrade.Text.Trim().ToString() != "")
        //        {
        //            cmbDiplomaUnivrct.Focus();
        //            cmbDiplomaUnivrct.Select();
        //        }
        //        else
        //        {
        //            MessageBox.Show("Select diploma CGPA");
        //            cmbDiplomaGrade.Focus();
        //            cmbDiplomaGrade.Select();
        //        }
        //    }
        //}

        //private void cmbDiplomaGrade_Enter(object sender, EventArgs e)
        //{
        //    cmbDiplomaGrade.ForeColor = Color.White;
        //    cmbDiplomaGrade.BackColor = Color.CadetBlue;
        //}

        //private void cmbDiplomaGrade_Leave(object sender, EventArgs e)
        //{
        //    cmbDiplomaGrade.ForeColor = Color.Black;
        //    cmbDiplomaGrade.BackColor = Color.White;
        //}

        //private void cmbDiplomaUnivrct_KeyDown(object sender, KeyEventArgs e)
        //{
        //    if (e.KeyCode.ToString() == "Return")
        //    {
        //        if (cmbDiplomaUnivrct.Text.Trim().ToString() != "")
        //        {
        //            txtDiplomaSubject.Focus();
        //            txtDiplomaSubject.Select();
        //        }
        //        else
        //        {
        //            MessageBox.Show("Select diploma university");
        //            cmbDiplomaUnivrct.Focus();
        //            cmbDiplomaUnivrct.Select();
        //        }
        //    }
        //}

        //private void cmbDiplomaUnivrct_Enter(object sender, EventArgs e)
        //{
        //    cmbDiplomaUnivrct.ForeColor = Color.White;
        //    cmbDiplomaUnivrct.BackColor = Color.CadetBlue;
        //}

        //private void cmbDiplomaUnivrct_Leave(object sender, EventArgs e)
        //{
        //    cmbDiplomaUnivrct.ForeColor = Color.Black;
        //    cmbDiplomaUnivrct.BackColor = Color.White;
        //}

        private void txtDiplomaSubject_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Return")
            {
                if (txtDiplomaSubject.Text.Trim().ToString() != "")
                {
                    txtDiplomaCollege.Focus();
                    txtDiplomaCollege.Select();
                }
                else
                {
                    MessageBox.Show("Select diploma subject");
                    txtDiplomaSubject.Focus();
                    txtDiplomaSubject.Select();
                }
            }
        }

        private void txtDiplomaSubject_Enter(object sender, EventArgs e)
        {
            txtDiplomaSubject.ForeColor = Color.White;
            txtDiplomaSubject.BackColor = Color.CadetBlue;
        }

        private void txtDiplomaSubject_Leave(object sender, EventArgs e)
        {
            txtDiplomaSubject.ForeColor = Color.Black;
            txtDiplomaSubject.BackColor = Color.White;
        }

        private void txtDiplomaCollege_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Return")
            {
                if (txtDiplomaCollege.Text.Trim().ToString() != "")
                {
                    txtBBASubject.Focus();
                    txtBBASubject.Select();
                }
                else
                {
                    MessageBox.Show("Select diploma college");
                    txtDiplomaCollege.Focus();
                    txtDiplomaCollege.Select();
                }
            }
        }

        private void txtDiplomaCollege_Enter(object sender, EventArgs e)
        {
            txtDiplomaCollege.ForeColor = Color.White;
            txtDiplomaCollege.BackColor = Color.CadetBlue;
        }

        private void txtDiplomaCollege_Leave(object sender, EventArgs e)
        {
            txtDiplomaCollege.ForeColor = Color.Black;
            txtDiplomaCollege.BackColor = Color.White;
        }

        //private void cmbDiplomaYear_KeyDown(object sender, KeyEventArgs e)
        //{
        //    if (e.KeyCode.ToString() == "Return")
        //    {
        //        if (cmbDiplomaYear.Text.Trim().ToString() != "")
        //        {
        //            cmbBBAGroup.Focus();
        //            cmbBBAGroup.Select();
        //        }
        //        else
        //        {
        //            MessageBox.Show("Select diploma year");
        //            cmbDiplomaYear.Focus();
        //            cmbDiplomaYear.Select();
        //        }
        //    }
        //}

        //private void cmbDiplomaYear_Enter(object sender, EventArgs e)
        //{
        //    cmbDiplomaYear.ForeColor = Color.White;
        //    cmbDiplomaYear.BackColor = Color.CadetBlue;
        //}

        //private void cmbDiplomaYear_Leave(object sender, EventArgs e)
        //{
        //    cmbDiplomaYear.ForeColor = Color.Black;
        //    cmbDiplomaYear.BackColor = Color.White;
        //}

        //private void cmbBBAGroup_KeyDown(object sender, KeyEventArgs e)
        //{
        //    if (e.KeyCode.ToString() == "Return")
        //    {
        //        if (cmbBBAGroup.Text.Trim().ToString() != "")
        //        {
        //            cmbBBAcGPA.Focus();
        //            cmbBBAcGPA.Select();
        //        }
        //        else
        //        {
        //            MessageBox.Show("Select BBA group");
        //            cmbBBAGroup.Focus();
        //            cmbBBAGroup.Select();
        //        }
        //    }
        //}

        //private void cmbBBAGroup_Enter(object sender, EventArgs e)
        //{
        //    cmbBBAGroup.ForeColor = Color.White;
        //    cmbBBAGroup.BackColor = Color.CadetBlue;
        //}

        //private void cmbBBAGroup_Leave(object sender, EventArgs e)
        //{
        //    cmbBBAGroup.ForeColor = Color.Black;
        //    cmbBBAGroup.BackColor = Color.White;
        //}

        //private void cmbBBAcGPA_KeyDown(object sender, KeyEventArgs e)
        //{
        //    if (e.KeyCode.ToString() == "Return")
        //    {
        //        if (cmbBBAcGPA.Text.Trim().ToString() != "")
        //        {
        //            cmbBBAUnivrct.Focus();
        //            cmbBBAUnivrct.Select();
        //        }
        //        else
        //        {
        //            MessageBox.Show("Select BBA CGPA");
        //            cmbBBAcGPA.Focus();
        //            cmbBBAcGPA.Select();
        //        }
        //    }
        //}

        //private void cmbBBAcGPA_Enter(object sender, EventArgs e)
        //{
        //    cmbBBAcGPA.ForeColor = Color.White;
        //    cmbBBAcGPA.BackColor = Color.CadetBlue;
        //}

        //private void cmbBBAcGPA_Leave(object sender, EventArgs e)
        //{
        //    cmbBBAcGPA.ForeColor = Color.Black;
        //    cmbBBAcGPA.BackColor = Color.White;
        //}

        //private void cmbBBAUnivrct_KeyDown(object sender, KeyEventArgs e)
        //{
        //    if (e.KeyCode.ToString() == "Return")
        //    {
        //        if (cmbBBAUnivrct.Text.Trim().ToString() != "")
        //        {
        //            txtBBASubject.Focus();
        //            txtBBASubject.Select();
        //        }
        //        else
        //        {
        //            MessageBox.Show("Select BBA university");
        //            cmbBBAUnivrct.Focus();
        //            cmbBBAUnivrct.Select();
        //        }
        //    }
        //}

        //private void cmbBBAUnivrct_Enter(object sender, EventArgs e)
        //{
        //    cmbBBAUnivrct.ForeColor = Color.White;
        //    cmbBBAUnivrct.BackColor = Color.CadetBlue;
        //}

        //private void cmbBBAUnivrct_Leave(object sender, EventArgs e)
        //{
        //    cmbBBAUnivrct.ForeColor = Color.Black;
        //    cmbBBAUnivrct.BackColor = Color.White;
        //}

        private void txtBBASubject_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Return")
            {
                if (txtBBASubject.Text.Trim().ToString() != "")
                {
                    txtBBACollege.Focus();
                    txtBBACollege.Select();
                }
                else
                {
                    MessageBox.Show("Select BBA subject");
                    txtBBASubject.Focus();
                    txtBBASubject.Select();
                }
            }
        }

        private void txtBBASubject_Enter(object sender, EventArgs e)
        {
            txtBBASubject.ForeColor = Color.White;
            txtBBASubject.BackColor = Color.CadetBlue;
        }

        private void txtBBASubject_Leave(object sender, EventArgs e)
        {
            txtBBASubject.ForeColor = Color.Black;
            txtBBASubject.BackColor = Color.White;
        }

        private void txtBBACollege_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Return")
            {
                if (txtBBACollege.Text.Trim().ToString() != "")
                {
                    txtMAPreliSubject.Focus();
                    txtMAPreliSubject.Select();
                }
                else
                {
                    MessageBox.Show("Select BBA college");
                    txtBBACollege.Focus();
                    txtBBACollege.Select();
                }
            }
        }

        private void txtBBACollege_Enter(object sender, EventArgs e)
        {
            txtBBACollege.ForeColor = Color.White;
            txtBBACollege.BackColor = Color.CadetBlue;
        }

        private void txtBBACollege_Leave(object sender, EventArgs e)
        {
            txtBBACollege.ForeColor = Color.Black;
            txtBBACollege.BackColor = Color.White;
        }

        //private void cmbBBAYear_KeyDown(object sender, KeyEventArgs e)
        //{
        //    if (e.KeyCode.ToString() == "Return")
        //    {
        //        if (cmbBBAYear.Text.Trim().ToString() != "")
        //        {
        //            cmbMAPreliGroup.Focus();
        //            cmbMAPreliGroup.Select();
        //        }
        //        else
        //        {
        //            MessageBox.Show("Select BBA year");
        //            cmbBBAYear.Focus();
        //            cmbBBAYear.Select();
        //        }
        //    }
        //}

        //private void cmbBBAYear_Enter(object sender, EventArgs e)
        //{
        //    cmbBBAYear.ForeColor = Color.White;
        //    cmbBBAYear.BackColor = Color.CadetBlue;
        //}

        //private void cmbBBAYear_Leave(object sender, EventArgs e)
        //{
        //    cmbBBAYear.ForeColor = Color.Black;
        //    cmbBBAYear.BackColor = Color.White;
        //}

        //private void cmbMAPreliGroup_KeyDown(object sender, KeyEventArgs e)
        //{
        //    if (e.KeyCode.ToString() == "Return")
        //    {
        //        if (cmbMAPreliGroup.Text.Trim().ToString() != "")
        //        {
        //            cmbMAPrelicGPA.Focus();
        //            cmbMAPrelicGPA.Select();
        //        }
        //        else
        //        {
        //            MessageBox.Show("Select MA preli group");
        //            cmbMAPreliGroup.Focus();
        //            cmbMAPreliGroup.Select();
        //        }
        //    }
        //}

        //private void cmbMAPreliGroup_Enter(object sender, EventArgs e)
        //{
        //    cmbMAPreliGroup.ForeColor = Color.White;
        //    cmbMAPreliGroup.BackColor = Color.CadetBlue;
        //}

        //private void cmbMAPreliGroup_Leave(object sender, EventArgs e)
        //{
        //    cmbMAPreliGroup.ForeColor = Color.Black;
        //    cmbMAPreliGroup.BackColor = Color.White;
        //}

        //private void cmbMAPrelicGPA_KeyDown(object sender, KeyEventArgs e)
        //{
        //    if (e.KeyCode.ToString() == "Return")
        //    {
        //        if (cmbMAPrelicGPA.Text.Trim().ToString() != "")
        //        {
        //            cmbMAPreliUnivrct.Focus();
        //            cmbMAPreliUnivrct.Select();
        //        }
        //        else
        //        {
        //            MessageBox.Show("Select MA preli cGPA");
        //            cmbMAPrelicGPA.Focus();
        //            cmbMAPrelicGPA.Select();
        //        }
        //    }
        //}

        //private void cmbMAPrelicGPA_Enter(object sender, EventArgs e)
        //{
        //    cmbMAPrelicGPA.ForeColor = Color.White;
        //    cmbMAPrelicGPA.BackColor = Color.CadetBlue;
        //}

        //private void cmbMAPrelicGPA_Leave(object sender, EventArgs e)
        //{

        //}

        //private void cmbMAPreliUnivrct_KeyDown(object sender, KeyEventArgs e)
        //{
        //    if (e.KeyCode.ToString() == "Return")
        //    {
        //        if (cmbMAPreliUnivrct.Text.Trim().ToString() != "")
        //        {
        //            txtMAPreliSubject.Focus();
        //            txtMAPreliSubject.Select();
        //        }
        //        else
        //        {
        //            MessageBox.Show("Select MA preli university");
        //            cmbMAPreliUnivrct.Focus();
        //            cmbMAPreliUnivrct.Select();
        //        }
        //    }
        //}

        //private void cmbMAPreliUnivrct_Enter(object sender, EventArgs e)
        //{
        //    cmbMAPreliUnivrct.ForeColor = Color.White;
        //    cmbMAPreliUnivrct.BackColor = Color.CadetBlue;
        //}

        //private void cmbMAPreliUnivrct_Leave(object sender, EventArgs e)
        //{
        //    cmbMAPreliUnivrct.ForeColor = Color.Black;
        //    cmbMAPreliUnivrct.BackColor = Color.White;
        //}

        private void txtMAPreliSubject_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Return")
            {
                if (txtMAPreliSubject.Text.Trim().ToString() != "")
                {
                    txtMAPreliCollege.Focus();
                    txtMAPreliCollege.Select();
                }
                else
                {
                    MessageBox.Show("Select MA preli subject");
                    txtMAPreliSubject.Focus();
                    txtMAPreliSubject.Select();

                }
            }
        }

        private void txtMAPreliSubject_Enter(object sender, EventArgs e)
        {
            txtMAPreliSubject.ForeColor = Color.White;
            txtMAPreliSubject.BackColor = Color.CadetBlue;
        }

        private void txtMAPreliSubject_Leave(object sender, EventArgs e)
        {
            txtMAPreliSubject.ForeColor = Color.Black;
            txtMAPreliSubject.BackColor = Color.White;
        }

        private void txtMAPreliCollege_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Return")
            {
                if (txtMAPreliCollege.Text.Trim().ToString() != "")
                {
                    txtMAFinalSubject.Focus();
                    txtMAFinalSubject.Select();
                }
                else
                {
                    MessageBox.Show("Select MA preli college");
                    txtMAPreliCollege.Focus();
                    txtMAPreliCollege.Select();
                }
            }
        }

        private void txtMAPreliCollege_Enter(object sender, EventArgs e)
        {
            txtMAPreliCollege.ForeColor = Color.White;
            txtMAPreliCollege.BackColor = Color.CadetBlue;
        }

        private void txtMAPreliCollege_Leave(object sender, EventArgs e)
        {
            txtMAPreliCollege.ForeColor = Color.Black;
            txtMAPreliCollege.BackColor = Color.White;
        }

        //private void cmbMAPreliYear_KeyDown(object sender, KeyEventArgs e)
        //{
        //    if (e.KeyCode.ToString() == "Return")
        //    {
        //        if (cmbMAPreliYear.Text.Trim().ToString() != "")
        //        {
        //            cmbMAFinalGroup.Focus();
        //            cmbMAFinalGroup.Select();
        //        }
        //        else
        //        {
        //            MessageBox.Show("Select MA preli year");
        //            cmbMAPreliYear.Focus();
        //            cmbMAPreliYear.Select();
        //        }
        //    }
        //}

        //private void cmbMAPreliYear_Enter(object sender, EventArgs e)
        //{
        //    cmbMAPreliYear.ForeColor = Color.White;
        //    cmbMAPreliYear.BackColor = Color.CadetBlue;
        //}

        //private void cmbMAPreliYear_Leave(object sender, EventArgs e)
        //{
        //    cmbMAPreliYear.ForeColor = Color.Black;
        //    cmbMAPreliYear.BackColor = Color.White;
        //}

        //private void cmbMAFinalGroup_KeyDown(object sender, KeyEventArgs e)
        //{
        //    if (e.KeyCode.ToString() == "Return")
        //    {
        //        if (cmbMAFinalGroup.Text.Trim().ToString() != "")
        //        {
        //            cmbMAFinalcGPA.Focus();
        //            cmbMAFinalcGPA.Select();
        //        }
        //        else
        //        {
        //            MessageBox.Show("Select MA final group");
        //            cmbMAFinalGroup.Focus();
        //            cmbMAFinalGroup.Select();
        //        }
        //    }
        //}

        //private void cmbMAFinalGroup_Enter(object sender, EventArgs e)
        //{
        //    cmbMAFinalGroup.ForeColor = Color.White;
        //    cmbMAFinalGroup.BackColor = Color.CadetBlue;
        //}

        //private void cmbMAFinalGroup_Leave(object sender, EventArgs e)
        //{
        //    cmbMAFinalGroup.ForeColor = Color.Black;
        //    cmbMAFinalGroup.BackColor = Color.White;
        //}

        //private void cmbMAFinalcGPA_KeyDown(object sender, KeyEventArgs e)
        //{
        //    if (e.KeyCode.ToString() == "Return")
        //    {
        //        if (cmbMAFinalcGPA.Text.Trim().ToString() != "")
        //        {
        //            cmbMAFinalUnivrct.Focus();
        //            cmbMAFinalUnivrct.Select();
        //        }
        //        else
        //        {
        //            MessageBox.Show("Select MA final cGPA");
        //            cmbMAFinalcGPA.Focus();
        //            cmbMAFinalcGPA.Select();
        //        }
        //    }
        //}

        //private void cmbMAFinalcGPA_Enter(object sender, EventArgs e)
        //{
        //    cmbMAFinalcGPA.ForeColor = Color.White;
        //    cmbMAFinalcGPA.BackColor = Color.CadetBlue;
        //}

        //private void cmbMAFinalcGPA_Leave(object sender, EventArgs e)
        //{
        //    cmbMAFinalcGPA.ForeColor = Color.Black;
        //    cmbMAFinalcGPA.BackColor = Color.White;
        //}

        //private void cmbMAFinalUnivrct_KeyDown(object sender, KeyEventArgs e)
        //{
        //    if (e.KeyCode.ToString() == "Return")
        //    {
        //        if (cmbMAFinalUnivrct.Text.Trim().ToString() != "")
        //        {
        //            txtMAFinalSubject.Focus();
        //            txtMAFinalSubject.Select();
        //        }
        //        else
        //        {
        //            MessageBox.Show("Select MA final university");
        //            cmbMAFinalUnivrct.Focus();
        //            cmbMAFinalUnivrct.Select();
        //        }
        //    }
        //}

        //private void cmbMAFinalUnivrct_Enter(object sender, EventArgs e)
        //{
        //    cmbMAFinalUnivrct.ForeColor = Color.White;
        //    cmbMAFinalUnivrct.BackColor = Color.CadetBlue;
        //}

        //private void cmbMAFinalUnivrct_Leave(object sender, EventArgs e)
        //{
        //    cmbMAFinalUnivrct.ForeColor = Color.Black;
        //    cmbMAFinalUnivrct.BackColor = Color.White;
        //}

        private void txtMAFinalSubject_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Return")
            {
                if (txtMAFinalSubject.Text.Trim().ToString() != "")
                {
                    txtMAFinalCollege.Focus();
                    txtMAFinalCollege.Select();
                }
                else
                {
                    MessageBox.Show("Select MA final college");
                    txtMAFinalSubject.Focus();
                    txtMAFinalSubject.Select();
                }
            }
        }

        private void txtMAFinalSubject_Enter(object sender, EventArgs e)
        {
            txtMAFinalSubject.ForeColor = Color.White;
            txtMAFinalSubject.BackColor = Color.CadetBlue;
        }

        private void txtMAFinalSubject_Leave(object sender, EventArgs e)
        {
            txtMAFinalSubject.ForeColor = Color.Black;
            txtMAFinalSubject.BackColor = Color.White;
        }

        private void txtMAFinalCollege_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Return")
            {
                if (txtMAFinalCollege.Text.Trim().ToString() != "")
                {
                    txtRegistarSign.Focus();
                    txtRegistarSign.Select();
                }
                else
                {
                    MessageBox.Show("Select MA final college");
                    txtMAFinalCollege.Focus();
                    txtMAFinalCollege.Select();
                }
            }
        }

        private void txtMAFinalCollege_Enter(object sender, EventArgs e)
        {
            txtMAFinalCollege.ForeColor = Color.White;
            txtMAFinalCollege.BackColor = Color.CadetBlue;
        }

        private void txtMAFinalCollege_Leave(object sender, EventArgs e)
        {
            txtMAFinalCollege.ForeColor = Color.Black;
            txtMAFinalCollege.BackColor = Color.White;
        }

        //private void cmbMAFinalYear_KeyDown(object sender, KeyEventArgs e)
        //{
        //    if (e.KeyCode.ToString() == "Return")
        //    {
        //        if (cmbMAFinalYear.Text.Trim().ToString() != "")
        //        {
        //            txtRegistarSign.Focus();
        //            txtRegistarSign.Select();
        //        }
        //        else
        //        {
        //            MessageBox.Show("Select MA final year");
        //            cmbMAFinalYear.Focus();
        //            cmbMAFinalYear.Select();
        //        }
        //    }
        //}

        //private void cmbMAFinalYear_Enter(object sender, EventArgs e)
        //{
        //    cmbMAFinalYear.ForeColor = Color.White;
        //    cmbMAFinalYear.BackColor = Color.CadetBlue;
        //}

        //private void cmbMAFinalYear_Leave(object sender, EventArgs e)
        //{
        //    cmbMAFinalYear.ForeColor = Color.Black;
        //    cmbMAFinalYear.BackColor = Color.White;
        //}

        private void txtRegistarSign_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Return")
            {
                if (txtRegistarSign.Text.Trim().ToString() != "")
                {
                    txtChairpersonSign.Focus();
                    txtChairpersonSign.Select();
                }
                else
                {
                    MessageBox.Show("Select registar sign");
                    txtRegistarSign.Focus();
                    txtRegistarSign.Select();
                }
            }
        }

        private void txtRegistarSign_Enter(object sender, EventArgs e)
        {
            txtRegistarSign.ForeColor = Color.White;
            txtRegistarSign.BackColor = Color.CadetBlue;
        }

        private void txtRegistarSign_Leave(object sender, EventArgs e)
        {
            txtRegistarSign.ForeColor = Color.Black;
            txtRegistarSign.BackColor = Color.White;
        }

        private void txtChairpersonSign_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Return")
            {
                if (txtChairpersonSign.Text.Trim().ToString() != "")
                {
                    btnSave.Focus();
                    btnSave.Select();
                }
                else
                {
                    MessageBox.Show("Select charperson sign");
                    txtChairpersonSign.Focus();
                    txtChairpersonSign.Select();
                }
            }
        }

        private void txtChairpersonSign_Enter(object sender, EventArgs e)
        {
            txtChairpersonSign.ForeColor = Color.White;
            txtChairpersonSign.BackColor = Color.CadetBlue;
        }

        private void txtChairpersonSign_Leave(object sender, EventArgs e)
        {
            txtChairpersonSign.ForeColor = Color.Black;
            txtChairpersonSign.BackColor = Color.White;
        }
    }
}
