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
    public partial class FRMLOGIN : Form
    {
        DataAccessLayer DAL = new DataAccessLayer();
        DataProcessLayer DPL = new DataProcessLayer();
        public FRMLOGIN()
        {
            InitializeComponent();
            txtUser.Text = "Enter your user name";
            txtUser.ForeColor = Color.DarkGray;
            txtUser.Focus();
            txtUser.Select(0, 0);

            txtPass.Text = "Enter your password";
            txtPass.ForeColor = Color.DarkGray;

            txtUser1.Text = "Enter your user name";
            txtUser1.ForeColor = Color.DarkGray;
            txtUser1.Focus();
            txtUser1.Select(0, 0);

            txtPassword1.Text = "Enter your password";
            txtPassword1.ForeColor = Color.DarkGray;

            txtOldUser.Text = "Enter your Olduser name";
            txtOldUser.ForeColor = Color.DarkGray;
            txtOldUser.Focus();
            txtOldUser.Select(0, 0);

            txtOldPassword.Text = "Enter your Old password";
            txtOldPassword.ForeColor = Color.DarkGray;

            txtNewUser.Text = "Enter your NewUser";
            txtNewUser.ForeColor = Color.DarkGray;
            txtNewUser.Focus();
            txtNewUser.Select(0, 0);

            txtPassword.Text = "Enter your New password";
            txtPassword.ForeColor = Color.DarkGray;
        }

        private void txtUser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Return")
            {
                if (txtUser.Text.Trim().ToString() != "")
                {
                    if (txtUser.Text == "Enter your user name")
                    {
                        MessageBox.Show("Please enter your user name");
                        txtUser.Focus();
                        txtUser.Select(0, 0);
                    }
                    else
                    {
                        txtPass.Focus();
                        txtPass.Select(0, 0);
                    }
                }
                else
                {
                    MessageBox.Show("Please select user name");
                    txtUser.Focus();
                    txtUser.Select(0, 0);
                }
            }
            else
            {
                if (txtUser.Text == "Enter your user name")
                {
                    txtUser.Text = "";
                    b = true;
                }
            }
        }
        bool b = false;
      private void txtUser_TextChanged(object sender, EventArgs e)
        {
            if (b)
            {
                if (txtUser.Text == "")
                {
                    txtUser.Text = "Enter your user name";
                    b = false;
                    //y = true;
                }
            }
        }

        private void txtPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Return")
            {
                if (txtPass.Text == "Enter your password")
                {
                    MessageBox.Show("Please enter your Password");
                    txtPass.Focus();
                    txtPass.Select(0, 0);
                }
                else
                {
                    cmbUsertype.Focus();
                    cmbUsertype.Select();
                }

            }
            else
            {
                if (txtPass.Text == "Enter your password")
                {
                    txtPass.Text = "";
                    a = true;
                }
            }
        }
        bool a = false;
        private void txtPass_TextChanged(object sender, EventArgs e)
        {
            if (a)
            {
                if (txtPass.Text == "")
                {
                    txtPass.Text = "Enter your password";
                    a = false;
                }
            }
        }

        private void cmbUsertype_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Return")
            {
                if (cmbUsertype.SelectedIndex != -1)
                {
                    btnLogin.Focus();
                }
                else
                {
                    MessageBox.Show("Please select user type");
                    cmbUsertype.Focus();
                    cmbUsertype.Select();
                }
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUser.Text.Trim().ToString() != "" && txtUser.Text.ToString() != "Enter your user name")
            {
                if (txtPass.Text.ToString() != "" && txtPass.Text.ToString() != "Enter your password")
                {
                    if (cmbUsertype.Text.ToString() != "")
                    {
                        //if (txtUser.Text == "roman" && txtPass.Text == "SU564ER" && cmbUsertype.Text == "Admin")
                        //{
                        //if (txtUser.Text == "h" && txtPass.Text == "h" && cmbUsertype.Text == "Super User")
                        //{
                        string user = txtUser.Text;
                        string password = txtPass.Text;
                        string usertype = cmbUsertype.Text;
                        string sql = @"SELECT     UserInformationID, UserName, Password, UserType
FROM         dbo.tbl_UserInformaton
WHERE     (UserName = '" + user + "') AND (Password = '" + password + "') AND (UserType = '" + usertype + "')";
                        DataTable ds = DAL.GetData(sql);
                        if (ds.Rows.Count > 0)
                        {
                            frmMain frms = new frmMain();
                            frms.Show();
                        }
                        else
                        {
                            MessageBox.Show("Incorrect your User Name or Password or User Type");
                        }

                        //}
                        //else
                        //{
                        //    MessageBox.Show("Incorrect your User Name or Password or User Type");
                        //}
                        //}
                        //else
                        //{
                        //    MessageBox.Show("Please select user type");
                        //    cmbUsertype.Focus();
                        //    cmbUsertype.Select();
                        //}
                    }
                    else
                    {
                        MessageBox.Show("Please enter your Password");
                        txtPass.Focus();
                        txtPass.Select(0, 0);
                    }
                }
                else
                {
                    MessageBox.Show("Please enter your user name");
                    txtUser.Focus();
                    txtUser.Select(0, 0);
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtUser.Text = "Enter your user name";
            txtUser.ForeColor = Color.DarkGray;

            txtPass.Text = "Enter your password";
            txtPass.ForeColor = Color.DarkGray;
            txtUser.Focus();
            txtUser.Select();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtUser1.Text.ToString() != "" && txtPassword1.Text.ToString() != "" && cambUserType1.Text.ToString() != "")
            {
                string inseart = "";
                string UserName = txtUser1.Text.Trim();
                string Password = txtPassword1.Text.Trim();
                string UserType = cambUserType1.Text;
                inseart = DPL.Save_tbl_UserInformaton(UserName, Password, UserType);
                if (inseart == "Succeded")
                {
                    string sql = "";
                    sql = @"SELECT     UserName, Password, UserType
                           FROM       dbo.tbl_UserInformaton";
                    DataTable dt = DAL.GetData(sql);
                    MessageBox.Show("Succeded");
                }
                else
                {
                    MessageBox.Show("not inseart");
                }
            }
            else
            {
                MessageBox.Show("Some essential value must be added");
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 1)
            {
                string sql = @"SELECT     UserName, Password, UserType
            FROM         dbo.tbl_UserInformaton
            WHERE     (UserName = '" + txtUser.Text + "') AND (Password = '" + txtPass.Text + "') AND (UserType = '" + cmbUsertype.Text + "') AND (UserInformationID = 1)";
                DataTable dt = DAL.GetData(sql);
                if (dt.Rows.Count > 0)
                {

                }
                else
                {
                    tabControl1.SelectedIndex = 0;
                    MessageBox.Show("You are not authorized person");
                }

            }
            else if (tabControl1.SelectedIndex == 2)
            {

            }
        }
        private void txtNewUser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Return")
            {
                string sql = @"SELECT     UserName
            FROM         dbo.tbl_UserInformaton
            WHERE     (UserName = '" + txtNewUser.Text + "')";
                DataTable dt = DAL.GetData(sql);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("This User Name is allredy exists");
                }
                else
                {
                    txtNewUser.Focus();
                    txtNewUser.Select();
                }
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Return")
            {
                string sql = @"SELECT     Password
                FROM         dbo.tbl_UserInformaton
                WHERE     (Password = '" + txtPassword.Text + "')";
                DataTable dt = DAL.GetData(sql);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("This password allredy exists");
                }
                else
                {
                    cmbUserChType.Focus();
                    cmbUserChType.Select();
                }
            }
        }

        private void cmbUserChType_Enter(object sender, EventArgs e)
        {
            cmbUserChType.BackColor = Color.Cyan;
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtUser1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Return")
            {
                if (txtUser1.Text.Trim().ToString() != "")
                {
                    if (txtUser1.Text == "Enter your user name")
                    {
                        MessageBox.Show("Please enter your user name");
                        txtUser1.Focus();
                        txtUser1.Select(0, 0);
                    }
                    else
                    {
                        txtPassword1.Focus();
                        txtPassword1.Select(0, 0);
                    }
                }
                else
                {
                    MessageBox.Show("Please select user name");
                    txtUser1.Focus();
                    txtUser1.Select(0, 0);
                }
            }
            else
            {
                if (txtUser1.Text == "Enter your user name")
                {
                    txtUser1.Text = "";
                    c = true;
                }
            }
        }
        bool c = false;
        //bool y = false;

        private void txtUser1_TextChanged(object sender, EventArgs e)
        {
            if (c)
            {
                if (txtUser1.Text == "")
                {
                    txtUser1.Text = "Enter your user name";
                    c = false;
                    //y = true;
                }
            }
        }

        private void txtPassword1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Return")
            {
                if (txtPassword1.Text == "Enter your password")
                {
                    MessageBox.Show("Please enter your Password");
                    txtPassword1.Focus();
                    txtPassword1.Select(0, 0);
                }
                else
                {
                    cambUserType1.Focus();
                    cambUserType1.Select();
                }

            }
            else
            {
                if (txtPassword1.Text == "Enter your password")
                {
                    txtPassword1.Text = "";
                    d = true;
                }
            }
        }
        bool d = false;

        private void txtPassword1_TextChanged(object sender, EventArgs e)
        {
            if (d)
            {
                if (txtPassword1.Text == "")
                {
                    txtPassword1.Text = "Enter your password";
                    d = false;
                }
            }
        }

        private void cambUserType1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Return")
            {
                if (cambUserType1.SelectedIndex != -1)
                {
                    btnSave.Focus();
                    btnSave.Select();
                }
                else
                {
                    MessageBox.Show("Please select user type");
                    cambUserType1.Focus();
                    cambUserType1.Select();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtUser1.Text = "Enter your user name";
            txtUser1.ForeColor = Color.DarkGray;

            txtPassword1.Text = "Enter your password";
            txtPassword1.ForeColor = Color.DarkGray;
            txtUser1.Focus();
            txtUser1.Select();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtOldUser.Text = "Enter your Old user name";
            txtOldUser.ForeColor = Color.DarkGray;

            txtOldPassword.Text = "Enter your Old password";
            txtOldPassword.ForeColor = Color.DarkGray;
            txtNewUser.Text = "Enter your NewUser";
            txtNewUser.ForeColor = Color.DarkGray;
            txtPassword.Text = "Enter your New password";
            txtPassword.ForeColor = Color.DarkGray;
            txtOldUser.Focus();
            txtOldUser.Select();
        }

        private void txtOldUser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Return")
            {
                string sql = @"SELECT     UserName
FROM         dbo.tbl_UserInformaton
WHERE     (UserName = '" + txtOldUser + "')";
                DataTable dt = DAL.GetData(sql);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("This User Name is allredy exists");
                }
                else
                {
                    txtOldUser.Focus();
                    txtOldUser.Select();
                }
            }
        }

        private void txtOldPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Return")
            {
                string sql = @"SELECT     Password
FROM         dbo.tbl_UserInformaton
WHERE     (Password = '" + txtOldPassword + "')";
                DataTable dt = DAL.GetData(sql);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("This User Name is allredy exists");
                }
                else
                {
                    txtOldPassword.Focus();
                    txtOldPassword.Select();
                }
            }
        }
    }
}
