namespace Synapse_Boutiuqe_Shop
{
    partial class RecoveryCode
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecoveryCode));
            LoginForm = new Panel();
            code = new TextBox();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            label5 = new Label();
            label3 = new Label();
            button3 = new Button();
            button2 = new Button();
            button4 = new Button();
            button5 = new Button();
            button1 = new Button();
            LoginForm.SuspendLayout();
            SuspendLayout();
            // 
            // LoginForm
            // 
            LoginForm.BackColor = Color.Transparent;
            LoginForm.Controls.Add(code);
            LoginForm.Controls.Add(label4);
            LoginForm.Controls.Add(label2);
            LoginForm.Controls.Add(label1);
            LoginForm.Controls.Add(label5);
            LoginForm.Controls.Add(label3);
            LoginForm.Controls.Add(button3);
            LoginForm.Controls.Add(button2);
            LoginForm.Cursor = Cursors.Hand;
            LoginForm.ForeColor = SystemColors.ButtonHighlight;
            LoginForm.Location = new Point(386, 15);
            LoginForm.Name = "LoginForm";
            LoginForm.Size = new Size(627, 821);
            LoginForm.TabIndex = 25;
            // 
            // code
            // 
            code.BackColor = Color.FromArgb(146, 147, 140);
            code.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            code.ForeColor = SystemColors.ButtonHighlight;
            code.Location = new Point(58, 367);
            code.Multiline = true;
            code.Name = "code";
            code.Size = new Size(210, 37);
            code.TabIndex = 14;
            code.TextChanged += firstname_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(57, 423);
            label4.Name = "label4";
            label4.Size = new Size(194, 28);
            label4.TabIndex = 7;
            label4.Text = "Didn't recieve code ?";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(57, 315);
            label2.Name = "label2";
            label2.Size = new Size(142, 28);
            label2.TabIndex = 7;
            label2.Text = "password reset";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(57, 287);
            label1.Name = "label1";
            label1.Size = new Size(524, 28);
            label1.TabIndex = 7;
            label1.Text = "Check Your Email, You must recieve Email with recovery for ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(57, 204);
            label5.Name = "label5";
            label5.Size = new Size(291, 37);
            label5.TabIndex = 7;
            label5.Text = "Enter Recovery Code";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(58, 213);
            label3.Name = "label3";
            label3.Size = new Size(270, 37);
            label3.TabIndex = 7;
            label3.Text = "_______________________";
            // 
            // button3
            // 
            button3.FlatAppearance.BorderColor = Color.FromArgb(255, 224, 192);
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatAppearance.MouseOverBackColor = Color.Gray;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.Transparent;
            button3.Location = new Point(57, 475);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(90, 39);
            button3.TabIndex = 15;
            button3.Text = "Submit";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(146, 147, 140);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.Transparent;
            button2.Location = new Point(244, 425);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(54, 31);
            button2.TabIndex = 15;
            button2.Text = "Send again";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Transparent;
            button4.Cursor = Cursors.Hand;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.DimGray;
            button4.Location = new Point(1314, -15);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(40, 79);
            button4.TabIndex = 28;
            button4.Text = "-";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.Transparent;
            button5.Cursor = Cursors.Hand;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.ForeColor = Color.DimGray;
            button5.Location = new Point(1347, 1);
            button5.Margin = new Padding(3, 4, 3, 4);
            button5.Name = "button5";
            button5.Size = new Size(37, 51);
            button5.TabIndex = 27;
            button5.Text = "X";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.BackgroundImage = Properties.Resources.Back;
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(0, 1);
            button1.Name = "button1";
            button1.Size = new Size(41, 49);
            button1.TabIndex = 26;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // RecoveryCode
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.SignupBackground;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1400, 851);
            Controls.Add(button4);
            Controls.Add(button5);
            Controls.Add(button1);
            Controls.Add(LoginForm);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "RecoveryCode";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RecoveryCode";
            Load += RecoveryCode_Load;
            LoginForm.ResumeLayout(false);
            LoginForm.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel LoginForm;
        private Button button4;
        private Button button5;
        private Button button1;
        private Label label2;
        private Label label1;
        private TextBox code;
        private Label label5;
        private Label label3;
        private Label label4;
        private Button button3;
        private Button button2;
    }
}