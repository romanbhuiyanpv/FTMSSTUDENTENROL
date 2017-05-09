using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FTMS_STUDENT_ENROLL_SYSTEM
{
    class DataProcessLayer : DataAccessLayer
    {
        #region Save
        public string Save_tbl_UserInformaton(string UserName, string Password, string UserType)
        {
            string rtt = "";
            try
            {
                string sql = "insert into tbl_UserInformaton( UserName, Password,UserType) values('" + UserName + "','" + Password + "','" + UserType + "')";
                rtt = Executable(sql);
                return rtt;
            }
            catch
            {

            }
            return rtt;
        }
        #endregion
        #region Save
        public string Save_Tbl_StudentAdmission(string Semister, string Program, string Department, string StudentId, string StudentName, string FatherName, string MotherName, string PresentAddress, string PermanentAddress, string AnnualIncome, string Nationality, string BirthDate, int Gender, string MaritalStatus, string Occupation, string Mobile, string SSCgroup, string SSCgrade, string SSCboard, int SSCyear, string HSCgroup, string HSCgrade, string HSCboard, int HSCyear, string DiplomaGroup, string DiplomaCGPA, string DiplomaUnivrct, string DiplomaYear, string BBAgroup, string BBAcgpa, string BBAunivrct, string BBAyear, string MApreliGroup, string MApreliCGPA, string MApreliUnivrct, string MApreliYear, string MAfinalGroup, string MAfinalCGPA, string MAfinalUnivrct, string MAfinalYear)
        {
            string rtt = "";
            try
            {
                string sql = "insert into Tbl_StudentAdmission(Semister,Program,Department,StudentId,StudentName,FatherName,MotherName,PresentAddress,PermanentAddress,AnnualIncome,Nationality,BirthDate,Gender,MaritalStatus,Occupation,Mobile,SSCgroup,SSCgrade,SSCboard,SSCyear,HSCgroup,HSCgrade,HSCboard,HSCyear,DiplomaGroup,DiplomaCGPA,DiplomaUnivrct,DiplomaYear,BBAgroup,BBAcgpa,BBAunivrct,BBAyear,MApreliGroup,MApreliCGPA,MApreliUnivrct,MApreliYear,MAfinalGroup,MAfinalCGPA,MAfinalUnivrct,MAfinalYear)values('" + Semister + "','" + Program + "','" + Department + "','" + StudentId + "','" + StudentName + "','" + FatherName + "','" + MotherName + "','" + PresentAddress + "','" + PermanentAddress + "','" + AnnualIncome + "','" + Nationality + "','" + BirthDate + "'," + Gender + ",'" + MaritalStatus + "','" + Occupation + "','" + Mobile + "','" + SSCgroup + "','" + SSCgrade + "','" + SSCboard + "'," + SSCyear + ",'" + HSCgroup + "','" + HSCgrade + "','" + HSCboard + "'," + HSCyear + ",'" + DiplomaGroup + "','" + DiplomaCGPA + "','" + DiplomaUnivrct + "'," + DiplomaYear + ",'" + BBAgroup + "','" + BBAcgpa + "','" + BBAunivrct + "','" + BBAyear + "','" + MApreliGroup + "','" + MApreliCGPA + "','" + MApreliUnivrct + "','" + MApreliYear + "','" + MAfinalGroup + "','" + MAfinalCGPA + "','" + MAfinalUnivrct + "','" + MAfinalYear + "')";
                rtt = Executable(sql);
                return rtt;
            }
            catch
            {

            }
            return rtt;
        }
        #endregion
        #region Update
        public string Update_Tbl_StudentAdmission(int StudentAdmissionID, string Semister, string Program, string Department, string StudentId, string StudentName, string FatherName, string MotherName, string PresentAddress, string PermanentAddress, string AnnualIncome, string Nationality, string BirthDate, int Gender, string MaritalStatus, string Occupation, string Mobile, string SSCgroup, string SSCgrade, string SSCboard, int SSCyear, string HSCgroup, string HSCgrade, string HSCboard, int HSCyear, string DiplomaGroup, string DiplomaCGPA, string DiplomaUnivrct, string DiplomaYear, string BBAgroup, string BBAcgpa, string BBAunivrct, string BBAyear, string MApreliGroup, string MApreliCGPA, string MApreliUnivrct, string MApreliYear, string MAfinalGroup, string MAfinalCGPA, string MAfinalUnivrct, string MAfinalYear)
        {
            string rtt = "";
            try
            {
                string sql = "update Tbl_StudentAdmission set Semister='" + Semister + "',Program='" + Program + "',Department='" + Department + "',StudentId='" + StudentId + "',StudentName='" + StudentName + "',FatherName='" + FatherName + "',MotherName='" + MotherName + "',PresentAddress='" + PresentAddress + "',PermanentAddress='" + PermanentAddress + "',AnnualIncome='" + AnnualIncome + "',Nationality='" + Nationality + "',BirthDate='" + BirthDate + "',Gender=" + Gender + ",MaritalStatus='" + MaritalStatus + "',Occupation='" + Occupation + "',Mobile='" + Mobile + "',SSCgroup='" + SSCgroup + "',SSCgrade='" + SSCgrade + "',SSCboard='" + SSCboard + "',SSCyear=" + SSCyear + ",HSCgroup='" + HSCgroup + "',HSCgrade='" + HSCgrade + "',HSCboard='" + HSCboard + "',HSCyear=" + HSCyear + ",DiplomaGroup='" + DiplomaGroup + "',DiplomaCGPA='" + DiplomaCGPA + "',DiplomaUnivrct='" + DiplomaUnivrct + "',DiplomaYear='" + DiplomaYear + "',BBAgroup='" + BBAgroup + "',BBAcgpa='" + BBAcgpa + "',BBAunivrct='" + BBAunivrct + "',BBAyear='" + BBAyear + "',MApreliGroup='" + MApreliGroup + "',MApreliCGPA='" + MApreliCGPA + "',MApreliUnivrct='" + MApreliUnivrct + "',MApreliYear='" + MApreliYear + "',MAfinalGroup='" + MAfinalGroup + "',MAfinalCGPA='" + MAfinalCGPA + "',MAfinalUnivrct='" + MAfinalUnivrct + "',MAfinalYear='" + MAfinalYear + "'where StudentAdmissionID=" + StudentAdmissionID + "";
                rtt = Executable(sql);
                return rtt;
            }
            catch
            {

            }
            return rtt;

        }
        #endregion
        #region Delete
        public string Delete_tbl_Value(string TableName, string ColumnsName, int ColumnsValue)
        {
            string rtt = "";
            try
            {
                string sql = "delete  from " + TableName + " Where " + ColumnsName + "=" + ColumnsValue + "";
                rtt = Executable(sql);
                return rtt;
            }
            catch
            {

            }
            return rtt;
        }
        #endregion
        #region Save
        public string Save_Tbl_Waver(string StudentName, string StudentId, string Program, string Batch, string RegNo, string Department, string Campus, decimal TuitionFee, string SSCresult, string HSCresult, decimal Waver, string ObtainedFee)
        {
            string rtt = "";
            try
            {
                string sql = "insert into Tbl_Waver(StudentName,StudentId,Program,Batch,RegNo,Department,Campus,TuitionFee,SSCresult,HSCresult,Waver,ObtainedFee)values('" + StudentName + "','" + StudentId + "','" + Program + "','" + Batch + "','" + RegNo + "','" + Department + "','" + Campus + "'," + TuitionFee + ",'" + SSCresult + "','" + HSCresult + "'," + Waver + ",'" + ObtainedFee + "')";
                rtt = Executable(sql);
                return rtt;
            }
            catch
            {

            }
            return rtt;
        }
        #endregion
        #region Update
        public string Update_Tbl_Waver(int WaverID, string StudentName, string StudentId, string Program, string Batch, string RegNo, string Department, string Campus, string TuitionFee, string SSCresult, string HSCresult, string Waver, string ObtainedFee)
        {
            string rtt = "";
            try
            {
                string sql = "update Tbl_Waver set StudentName='" + StudentName + "',StudentId='" + StudentId + "',Program='" + Program + "', Batch='" + Batch + "',RegNo='" + RegNo + "',Department='" + Department + "', Campus='" + Campus + "',TuitionFee='" + TuitionFee + "',SSCresult='" + SSCresult + "',HSCresult='" + HSCresult + "',Waver='" + Waver + "',ObtainedFee='" + ObtainedFee + "'where WaverID=" + WaverID + "";
                rtt = Executable(sql);
                return rtt;
            }
            catch
            {

            }
            return rtt;

        }
        #endregion
        #region Save
        public string Save_Tbl_StudentInfo(int Gender, string Date, string StudentName, string Address, string Program, string Department, string Batch, string StudentId, string RegNo, string Mobile)
        {
            string rtt = "";
            try
            {
                string sql = "insert into Tbl_StudentInfo(Gender,Date,StudentName,Address,Program,Department,Batch,StudentId,RegNo,Mobile)values(" + Gender + ",'" + Date + "','" + StudentName + "','" + Address + "','" + Program + "','" + Department + "','" + Batch + "','" + StudentId + "','" + RegNo + "','" + Mobile + "')";
                rtt = Executable(sql);
                return rtt;
            }
            catch
            {

            }
            return rtt;
        }
        #endregion
        #region Update
        public string Update_Tbl_StudentInfo(int StudentInfoID, int Gender, string Date, string StudentName, string Address, string Program, string Department, string Batch, string StudentId, string RegNo, string Mobile)
        {
            string rtt = "";
            try
            {
                string sql = "update Tbl_StudentInfo set Gender=" + Gender + ",Date='" + Date + "',StudentName='" + StudentName + "',Address='" + Address + "',Program='" + Program + "', Department='" + Department + "',Batch='" + Batch + "',StudentId='" + StudentId + "', RegNo='" + RegNo + "',Mobile=" + Mobile + "where StudentInfoID=" + StudentInfoID + "";
                rtt = Executable(sql);
                return rtt;
            }
            catch
            {

            }
            return rtt;

        }
        #endregion
        #region Save
        public string Save_Tbl_StudentResult(string Semister, string StudentId, string StudentName, string Program, string Batch, string RegNo, string Campus, string Code1, decimal GPA1, decimal ObtainedGPA1, string Code2, decimal GPA2, decimal ObtainedGPA2, string Code3, decimal GPA3, decimal ObtainedGPA3, string Code4, decimal GPA4, decimal ObtainedGPA4, string Code5, decimal GPA5, decimal ObtainedGPA5, string Code6, decimal GPA6, decimal ObtainedGPA6, string Code7, decimal GPA7, decimal ObtainedGPA7, string Code8, decimal GPA8, decimal ObtainedGPA8, string SGPA)
        {
            string rtt = "";
            try
            {
                string sql = "insert into Tbl_StudentResult(Semister,StudentId,StudentName,Program,Batch,RegNo,Campus,Code1,GPA1,ObtainedGPA1,Code2,GPA2,ObtainedGPA2,Code3,GPA3,ObtainedGPA3,Code4,GPA4,ObtainedGPA4,Code5,GPA5,ObtainedGPA5,Code6,GPA6,ObtainedGPA6,Code7,GPA7,ObtainedGPA7,Code8,GPA8,ObtainedGPA8,SGPA)values('" + Semister + "','" + StudentId + "','" + StudentName + "','" + Program + "','" + Batch + "','" + RegNo + "','" + Campus + "','" + Code1 + "'," + GPA1 + "," + ObtainedGPA1 + ",'" + Code2 + "'," + GPA2 + "," + ObtainedGPA2 + ",'" + Code3 + "'," + GPA3 + "," + ObtainedGPA3 + ",'" + Code4 + "'," + GPA4 + "," + ObtainedGPA4 + ",'" + Code5 + "'," + GPA5 + "," + ObtainedGPA5 + ",'" + Code6 + "'," + GPA6 + "," + ObtainedGPA6 + ",'" + Code7 + "'," + GPA7 + "," + ObtainedGPA7 + ",'" + Code8 + "'," + GPA8 + "," + ObtainedGPA8 + ",'" + SGPA + "')";
                rtt = Executable(sql);
                return rtt;
            }
            catch
            {

            }
            return rtt;
        }
        #endregion
        #region Update
        public string Update_Tbl_StudentResult(int StudentResultID, string Semister, string StudentId, string StudentName, string Program, string Batch, string RegNo, string Campus, string Code1, decimal GPA1, decimal ObtainedGPA1, string Code2, decimal GPA2, decimal ObtainedGPA2, string Code3, decimal GPA3, decimal ObtainedGPA3, string Code4, decimal GPA4, decimal ObtainedGPA4, string Code5, decimal GPA5, decimal ObtainedGPA5, string Code6, decimal GPA6, decimal ObtainedGPA6, string Code7, decimal GPA7, decimal ObtainedGPA7, string Code8, decimal GPA8, decimal ObtainedGPA8, string SGPA)
        {
            string rtt = "";
            try
            {
                string sql = "update Tbl_StudentResult set Semister='" + Semister + "',StudentId='" + StudentId + "',StudentName='" + StudentName + "',Program='" + Program + "',Batch='" + Batch + "',RegNo='" + RegNo + "',Campus='" + Campus + "',Code1='" + Code1 + "',GPA1=" + GPA1 + ",ObtainedGPA1=" + ObtainedGPA1 + ",Code2='" + Code2 + "',GPA2=" + GPA2 + ",ObtainedGPA2=" + ObtainedGPA2 + ",Code3='" + Code3 + "',GPA3=" + GPA3 + ",ObtainedGPA3=" + ObtainedGPA3 + ",Code4='" + Code4 + "',GPA4=" + GPA4 + ",ObtainedGPA4=" + ObtainedGPA4 + ",Code5='" + Code5 + "',GPA5=" + GPA5 + ",ObtainedGPA5=" + ObtainedGPA5 + " ,Code6='" + Code6 + "',GPA6=" + GPA6 + ", ObtainedGPA6=" + ObtainedGPA6 + ",Code7='" + Code7 + "',GPA7=" + GPA7 + ",ObtainedGPA7=" + ObtainedGPA7 + ",Code8='" + Code8 + "',GPA8=" + GPA8 + ",ObtainedGPA8=" + ObtainedGPA8 + ",SGPA='" + SGPA + "'where StudentResultID=" + StudentResultID + "";
                rtt = Executable(sql);
                return rtt;
            }
            catch
            {

            }
            return rtt;
        }
        #endregion
        #region Save
        public string Save_Tbl_StudentEnrolment(string Semister, string StudentId, string StudentName, string Department, string Program, string Batch, string RegNo, string Campus, string Code1, string Title1, string Credit1, string Code2, string Title2, string Credit2, string Code3, string Title3, string Credit3, string Code4, string Title4, string Credit4, string Code5, string Title5, string Credit5, string Code6, string Title6, string Credit6, string RetakeCode1, string RetakeTitle1, string RetakeCredit1, string RetakeCode2, string RetakeTitle2, string RetakeCredit2, string RegisterSign, string ChairpersonSign)
        {
            string rtt = "";
            try
            {
                string sql = "insert into Tbl_StudentEnrolment(Semister,StudentId,StudentName,Department,Program,Batch,RegNo,Campus,Code1,Title1,Credit1,Code2,Title2,Credit2,Code3,Title3,Credit3,Code4,Title4,Credit4,Code5,Title5,Credit5,Code6,Title6,Credit6,RetakeCode1,RetakeTitle1,RetakeCredit1,RetakeCode2,RetakeTitle2,RetakeCredit2,RegisterSign,ChairpersonSign)values('" + Semister + "','" + StudentId + "','" + StudentName + "','" + Department + "','" + Program + "','" + Batch + "','" + RegNo + "','" + Campus + "','" + Code1 + "','" + Title1 + "','" + Credit1 + "','" + Code2 + "','" + Title2 + "','" + Credit2 + "','" + Code3 + "','" + Title3 + "','" + Credit3 + "','" + Code4 + "','" + Title4 + "','" + Credit4 + "','" + Code5 + "','" + Title5 + "','" + Credit5 + "','" + Code6 + "','" + Title6 + "','" + Credit6 + "','" + RetakeCode1 + "','" + RetakeTitle1 + "','" + RetakeCredit1 + "','" + RetakeCode2 + "','" + RetakeTitle2 + "','" + RetakeCredit2 + "','" + RegisterSign + "','" + ChairpersonSign + "')";
                rtt = Executable(sql);
                return rtt;
            }
            catch
            {

            }
            return rtt;
        }
        #endregion   
        #region Update
        public string Update_Tbl_StudentEnrolment(int StudentEnrolmentID, string Semister, string StudentId, string StudentName, string Department, string Program, string Batch, string RegNo, string Campus, string Code1, string Title1, string Credit1, string Code2, string Title2, string Credit2, string Code3, string Title3, string Credit3, string Code4, string Title4, string Credit4, string Code5, string Title5, string Credit5, string Code6, string Title6, string Credit6, string RetakeCode1, string RetakeTitle1, string RetakeCredit1, string RetakeCode2, string RetakeTitle2, string RetakeCredit2, string RegisterSign, string ChairpersonSign)
        {
            string rtt = "";
            try
            {
                string sql = "update Tbl_StudentEnrolment set Semister='" + Semister + "',StudentId='" + StudentId + "',StudentName='" + StudentName + "',Department='" + Department + "',Program='" + Program + "',Batch='" + Batch + "',RegNo='" + RegNo + "',Campus='" + Campus + "',Code1='" + Code1 + "',Title1='" + Title1 + "',Credit1='" + Credit1 + "',Code2='" + Code2 + "',Title2='" + Title2 + "',Credit2='" + Credit2 + "',Code3='" + Code3 + "',Title3='" + Title3 + "',Credit3='" + Credit3 + "',Code4='" + Code4 + "',Title4='" + Title4 + "',Credit4='" + Credit4 + "',Code5='" + Code5 + "',Title5='" + Title5 + "',Credit5='" + Credit5 + "',Code6='" + Code6 + "',Title6='" + Title6 + "',Credit6='" + Credit6 + "',RetakeCode1='" + RetakeCode1 + "',RetakeTitle1='" + RetakeTitle1 + "',RetakeCredit1='" + RetakeCredit1 + "',RetakeCode2='" + RetakeCode2 + "',RetakeTitle2='" + RetakeTitle2 + "',RetakeCredit2='" + RetakeCredit2 + "',RegisterSign='" + RegisterSign + "',ChairpersonSign='" + ChairpersonSign + "'where StudentEnrolmentID=" + StudentEnrolmentID + "";
                rtt = Executable(sql);
                return rtt;
            }
            catch
            {

            }
            return rtt;

        }
        #endregion   
        #region Update
        public string Update_Tbl_StudentRegistration(int StudentRegistrationID, int SerialNo, string StudentId, string RegNo, string StudentName, string FatherName, string MotherName, string Date, string Department, string Program, string Batch, string Campus, string AdmissionSemester, string SSCgroup, string SSCgpa, string SSCboard, string SSCsubject, string SSCschool, string SSCyear, string HSCgroup, string HSCgpa, string HSCboard, string HSCsubject, string HSCcollege, string HSCyear, string DiplomaGroup, string DiplomaCgpa, string DiplomaUnivrct, string DiplomaSubject, string DiplomaCollege, string DiplomaYear, string BBAgroup, string BBAcgpa, string BBAunivrct, string BBAsubject, string BBAcollege, string BBAyear, string MApreliGroup, string MApreliCGPA, string MApreliUnivrct, string MApreliSubject, string MApreliCollege, string MApreliYear, string MAfinalGroup, string MAfinalCGPA, string MAfinalUnivrct, string MAfinalSubject, string MAfinalCollege, string MAfinalYear, string RegisterSign, string ChairmanSign)
        {
            string rtt = "";
            try
            {
                string sql = "update Tbl_StudentRegistration set SerialNo=" + SerialNo + ",StudentId='" + StudentId + "',RegNo='" + RegNo + "',StudentName='" + StudentName + "',FatherName='" + FatherName + "',MotherName='" + MotherName + "',Date='" + Date + "',Department='" + Department + "',Program='" + Program + "',Batch='" + Batch + "',Campus='" + Campus + "',AdmissionSemester='" + AdmissionSemester + "',SSCgroup='" + SSCgroup + "',SSCgpa='" + SSCgpa + "',SSCboard='" + SSCboard + "',SSCsubject='" + SSCsubject + "',SSCschool='" + SSCschool + "',SSCyear='" + SSCyear + "',HSCgroup='" + HSCgroup + "',HSCgpa='" + HSCgpa + "',HSCboard='" + HSCboard + "',HSCsubject='" + HSCsubject + "',HSCcollege='" + HSCcollege + "',HSCyear='" + HSCyear + "',DiplomaGroup='" + DiplomaGroup + "',DiplomaCgpa='" + DiplomaCgpa + "',DiplomaUnivrct='" + DiplomaUnivrct + "',DiplomaSubject='" + DiplomaSubject + "',DiplomaCollege='" + DiplomaCollege + "',DiplomaYear='" + DiplomaYear + "',BBAgroup='" + BBAgroup + "',BBAcgpa='" + BBAcgpa + "',BBAunivrct='" + BBAunivrct + "',BBAsubject='" + BBAsubject + "',BBAcollege='" + BBAcollege + "',BBAyear='" + BBAyear + "',MApreliGroup='" + MApreliGroup + "',MApreliCGPA='" + MApreliCGPA + "',MApreliUnivrct='" + MApreliUnivrct + "',MApreliSubject='" + MApreliSubject + "',MApreliCollege='" + MApreliCollege + "',MApreliYear='" + MApreliYear + "',MAfinalGroup='" + MAfinalGroup + "',MAfinalCGPA='" + MAfinalCGPA + "',MAfinalUnivrct='" + MAfinalUnivrct + "',MAfinalSubject='" + MAfinalSubject + "',MAfinalCollege='" + MAfinalCollege + "',MAfinalYear='" + MAfinalYear + "',RegisterSign='" + RegisterSign + "',ChairmanSign='" + ChairmanSign + "'where StudentRegistrationID=" + StudentRegistrationID + "";
                rtt = Executable(sql);
                return rtt;
            }
            catch
            {

            }
            return rtt;

        }
        #endregion   
        #region Save
        public string Save_Tbl_StudentRegistration(int SerialNo, string StudentId, string RegNo, string StudentName, string FatherName, string MotherName, string Date, string Department, string Program, string Batch, string Campus, string AdmissionSemester, string SSCgroup, string SSCgpa, string SSCboard, string SSCsubject, string SSCschool, string SSCyear, string HSCgroup, string HSCgpa, string HSCboard, string HSCsubject, string HSCcollege, string HSCyear, string DiplomaGroup, string DiplomaCgpa, string DiplomaUnivrct, string DiplomaSubject, string DiplomaCollege, string DiplomaYear, string BBAgroup, string BBAcgpa, string BBAunivrct, string BBAsubject, string BBAcollege, string BBAyear, string MApreliGroup, string MApreliCGPA, string MApreliUnivrct, string MApreliSubject, string MApreliCollege, string MApreliYear, string MAfinalGroup, string MAfinalCGPA, string MAfinalUnivrct, string MAfinalSubject, string MAfinalCollege, string MAfinalYear, string RegisterSign, string ChairmanSign)
        {
            string rtt = "";
            try
            {
                string sql = "insert into Tbl_StudentRegistration(SerialNo,StudentId,RegNo,StudentName,FatherName,MotherName,Date,Department,Program,Batch,Campus,AdmissionSemester,SSCgroup,SSCgpa,SSCboard,SSCsubject,SSCschool,SSCyear,HSCgroup,HSCgpa,HSCboard,HSCsubject,HSCcollege,HSCyear,DiplomaGroup,DiplomaCgpa,DiplomaUnivrct,DiplomaSubject,DiplomaCollege,DiplomaYear,BBAgroup,BBAcgpa,BBAunivrct,BBAsubject,BBAcollege,BBAyear,MApreliGroup,MApreliCGPA,MApreliUnivrct,MApreliSubject,MApreliCollege,MApreliYear,MAfinalGroup,MAfinalCGPA,MAfinalUnivrct,MAfinalSubject,MAfinalCollege,MAfinalYear,RegisterSign,ChairmanSign)values(" + SerialNo + ",'" + StudentId + "','" + RegNo + "','" + StudentName + "','" + FatherName + "','" + MotherName + "','" + Date + "','" + Department + "','" + Program + "','" + Batch + "','" + Campus + "','" + AdmissionSemester + "','" + SSCgroup + "','" + SSCgpa + "','" + SSCboard + "','" + SSCsubject + "','" + SSCschool + "','" + SSCyear + "','" + HSCgroup + "','" + HSCgpa + "','" + HSCboard + "','" + HSCsubject + "','" + HSCcollege + "','" + HSCyear + "','" + DiplomaGroup + "','" + DiplomaCgpa + "','" + DiplomaUnivrct + "','" + DiplomaSubject + "','" + DiplomaCollege + "','" + DiplomaYear + "','" + BBAgroup + "','" + BBAcgpa + "','" + BBAunivrct + "','" + BBAsubject + "','" + BBAcollege + "','" + BBAyear + "','" + MApreliGroup + "','" + MApreliCGPA + "','" + MApreliUnivrct + "','" + MApreliSubject + "','" + MApreliCollege + "','" + MApreliYear + "','" + MAfinalGroup + "','" + MAfinalCGPA + "','" + MAfinalUnivrct + "','" + MAfinalSubject + "','" + MAfinalCollege + "','" + MAfinalYear + "','" + RegisterSign + "','" + ChairmanSign + "')";
                rtt = Executable(sql);
                return rtt;
            }
            catch
            {

            }
            return rtt;
        }
        #endregion
    }
}
