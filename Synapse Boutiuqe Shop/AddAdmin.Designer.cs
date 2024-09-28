namespace Synapse_Boutiuqe_Shop
{
    partial class AddAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddAdmin));
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            button3 = new Button();
            panel1 = new Panel();
            password = new TextBox();
            username = new TextBox();
            showbtn2 = new Button();
            label1 = new Label();
            label2 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            button9 = new Button();
            button2 = new Button();
            button1 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // button3
            // 
            button3.BackgroundImage = Properties.Resources.Add_Admin;
            button3.BackgroundImageLayout = ImageLayout.Stretch;
            button3.Cursor = Cursors.Hand;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.Transparent;
            button3.Location = new Point(191, 409);
            button3.Name = "button3";
            button3.Size = new Size(64, 68);
            button3.TabIndex = 29;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(password);
            panel1.Controls.Add(username);
            panel1.Controls.Add(showbtn2);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.ForeColor = SystemColors.ButtonHighlight;
            panel1.Location = new Point(438, 53);
            panel1.Name = "panel1";
            panel1.Size = new Size(470, 551);
            panel1.TabIndex = 16;
            panel1.Paint += panel1_Paint;
            // 
            // password
            // 
            password.BackColor = Color.FromArgb(16, 26, 43);
            password.BorderStyle = BorderStyle.None;
            password.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            password.ForeColor = SystemColors.ButtonHighlight;
            password.Location = new Point(79, 315);
            password.Margin = new Padding(3, 2, 3, 2);
            password.Multiline = true;
            password.Name = "password";
            password.Size = new Size(323, 24);
            password.TabIndex = 56;
            // 
            // username
            // 
            username.BackColor = Color.FromArgb(16, 26, 43);
            username.BorderStyle = BorderStyle.None;
            username.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            username.ForeColor = SystemColors.ButtonHighlight;
            username.Location = new Point(78, 201);
            username.Margin = new Padding(3, 2, 3, 2);
            username.Multiline = true;
            username.Name = "username";
            username.Size = new Size(323, 24);
            username.TabIndex = 55;
            // 
            // showbtn2
            // 
            showbtn2.Cursor = Cursors.Hand;
            showbtn2.FlatAppearance.BorderSize = 0;
            showbtn2.FlatStyle = FlatStyle.Flat;
            showbtn2.Font = new Font("Lucida Handwriting", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            showbtn2.ForeColor = SystemColors.ControlLight;
            showbtn2.Location = new Point(151, 473);
            showbtn2.Name = "showbtn2";
            showbtn2.Size = new Size(154, 34);
            showbtn2.TabIndex = 30;
            showbtn2.Text = "Add Admin";
            showbtn2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(110, 36);
            label1.Name = "label1";
            label1.Size = new Size(252, 37);
            label1.TabIndex = 12;
            label1.Text = "\"Add New Admin\"";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(110, 52);
            label2.Name = "label2";
            label2.Size = new Size(248, 37);
            label2.TabIndex = 11;
            label2.Text = "_____________________";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI Semilight", 13F);
            label6.Location = new Point(76, 285);
            label6.Name = "label6";
            label6.Size = new Size(147, 25);
            label6.TabIndex = 6;
            label6.Text = "Admin Password :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(76, 319);
            label5.Name = "label5";
            label5.Size = new Size(332, 25);
            label5.TabIndex = 7;
            label5.Text = "________________________________________";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Semilight", 13F);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(74, 171);
            label4.Name = "label4";
            label4.Size = new Size(161, 25);
            label4.TabIndex = 6;
            label4.Text = "Admin User Name :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(74, 207);
            label3.Name = "label3";
            label3.Size = new Size(332, 25);
            label3.TabIndex = 7;
            label3.Text = "________________________________________";
            // 
            // button9
            // 
            button9.BackColor = Color.Transparent;
            button9.BackgroundImage = Properties.Resources.Back2;
            button9.BackgroundImageLayout = ImageLayout.Stretch;
            button9.Cursor = Cursors.Hand;
            button9.FlatAppearance.BorderSize = 0;
            button9.FlatStyle = FlatStyle.Flat;
            button9.ForeColor = Color.Transparent;
            button9.Location = new Point(2, 8);
            button9.Margin = new Padding(3, 2, 3, 2);
            button9.Name = "button9";
            button9.Size = new Size(24, 30);
            button9.TabIndex = 15;
            button9.UseVisualStyleBackColor = false;
            button9.Click += button9_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ActiveBorder;
            button2.Location = new Point(1151, -12);
            button2.Name = "button2";
            button2.Size = new Size(35, 59);
            button2.TabIndex = 14;
            button2.Text = "-";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ActiveBorder;
            button1.Location = new Point(1181, 0);
            button1.Name = "button1";
            button1.Size = new Size(32, 38);
            button1.TabIndex = 13;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // AddAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.AdminBlur;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1225, 638);
            Controls.Add(panel1);
            Controls.Add(button9);
            Controls.Add(button2);
            Controls.Add(button1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AddAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddAdmin";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button button3;
        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Button button9;
        private Button button2;
        private Button button1;
        private Button showbtn2;
        private TextBox password;
        private TextBox username;
    }
}