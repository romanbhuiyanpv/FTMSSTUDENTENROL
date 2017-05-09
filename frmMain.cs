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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public static bool bresult = true;
        public static FrmStudentResult studentresult = null;
        private void btnResult_Click(object sender, EventArgs e)
        {
            if (bresult)
            {
                studentresult = new FrmStudentResult();
                studentresult.Show();
                bresult = false;
            }
        }
        public static bool binfo = true;
        public static FrmStudentInformation info = null;
        private void btnStudentInformation_Click(object sender, EventArgs e)
        {
            if (binfo)
            {
                info = new FrmStudentInformation();
                info.Show();
                binfo = false;
            }
        }
        public static bool bwaver = true;
        public static FrmWaver waver = null;
        private void btnWaver_Click(object sender, EventArgs e)
        {
            if (bwaver)
            {
                waver = new FrmWaver();
                waver.Show();
                bwaver = false;
            }
        }
        public static bool bstdad = true;
        public static FrmStudentAdmission ad = null;
        private void btnStudintAdmission_Click(object sender, EventArgs e)
        {
            if (bstdad)
            {
                ad = new FrmStudentAdmission();
                ad.Show();
                bstdad = false;
            }
        }
        public static bool breg = true;
        public static FrmStudentRegistration reg = null;
        private void btnStudentRegistration_Click(object sender, EventArgs e)
        {
            if (breg)
            {
                reg = new FrmStudentRegistration();
                reg.Show();
                breg = false;
            }
        }
        public static bool benrol = true;
        public static FrmStudentEnrolment enrol = null;
        private void btnStudentEnrolment_Click(object sender, EventArgs e)
        {
            if (benrol)
            {
                enrol = new FrmStudentEnrolment();
                enrol.Show();
                benrol = false;
            }
        }
    }
}
