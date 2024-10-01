using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace Synapse_Boutiuqe_Shop
{
    public partial class RecoveryCode : Form
    {
        string username, email, verificationCode;
        public RecoveryCode(string username, string email)
        {
            InitializeComponent();
            this.username = username;
            this.email = email;

            SendVerificationCode();
        }

        private void RecoveryCode_Load(object sender, EventArgs e)
        {
            LoginForm.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ForgotPassword forgotPassword = new ForgotPassword();
            forgotPassword.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (code.Text == verificationCode)
            {
                NewPassword newPassword = new NewPassword(username);
                newPassword.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid verification code. Please try again.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        

        private void firstname_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SendVerificationCode();
        }

        private void SendVerificationCode()
        {
            Random random = new Random();
            verificationCode = random.Next(100000, 999999).ToString();

            try
            {
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress("foolman978@gmail.com");
                mail.To.Add(email);
                mail.Subject = "Your Password Recovery Code";
                mail.Body = $"Hello {username},\n\nYour password recovery code is: {verificationCode}\n\nRegards,\nSynapse Boutique Shop";

                SmtpClient smtpClient = new SmtpClient("smtp.gmail.com")
                {
                    Port = 587,
                    Credentials = new NetworkCredential("foolman978@gmail.com", "jbmk uvzm sude ixuj"),
                    EnableSsl = true,
                };

                smtpClient.Send(mail);
                MessageBox.Show("Verification code has been sent to your email.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to send email. Error: {ex.Message}");
            }
        }
    }
}
