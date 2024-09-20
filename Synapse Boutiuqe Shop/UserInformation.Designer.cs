namespace Synapse_Boutiuqe_Shop
{
    partial class UserInformation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserInformation));
            button1 = new Button();
            button2 = new Button();
            panel1 = new Panel();
            button3 = new Button();
            label2 = new Label();
            label1 = new Label();
            hScrollBar1 = new HScrollBar();
            tableLayoutPanel1 = new TableLayoutPanel();
            button9 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ActiveBorder;
            button1.Location = new Point(1340, 3);
            button1.Name = "button1";
            button1.Size = new Size(32, 38);
            button1.TabIndex = 0;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ActiveBorder;
            button2.Location = new Point(1310, -9);
            button2.Name = "button2";
            button2.Size = new Size(35, 59);
            button2.TabIndex = 1;
            button2.Text = "-";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.tableback;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(button3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(hScrollBar1);
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Location = new Point(249, 130);
            panel1.Name = "panel1";
            panel1.Size = new Size(907, 556);
            panel1.TabIndex = 2;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.Control;
            button3.BackgroundImage = Properties.Resources.Deletuser2;
            button3.BackgroundImageLayout = ImageLayout.Stretch;
            button3.Cursor = Cursors.Hand;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Location = new Point(439, 481);
            button3.Name = "button3";
            button3.Size = new Size(64, 62);
            button3.TabIndex = 4;
            button3.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(338, 9);
            label2.Name = "label2";
            label2.Size = new Size(279, 37);
            label2.TabIndex = 3;
            label2.Text = "\"All User Inforation\"";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(338, 20);
            label1.Name = "label1";
            label1.Size = new Size(270, 37);
            label1.TabIndex = 2;
            label1.Text = "_______________________";
            // 
            // hScrollBar1
            // 
            hScrollBar1.Cursor = Cursors.PanEast;
            hScrollBar1.Location = new Point(0, 442);
            hScrollBar1.Name = "hScrollBar1";
            hScrollBar1.Size = new Size(907, 36);
            hScrollBar1.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 6;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 49.55752F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.44248F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 149F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 200F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 170F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 161F));
            tableLayoutPanel1.Location = new Point(0, 85);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 7.62711859F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 92.37288F));
            tableLayoutPanel1.Size = new Size(907, 354);
            tableLayoutPanel1.TabIndex = 0;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
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
            button9.Location = new Point(12, 11);
            button9.Margin = new Padding(3, 2, 3, 2);
            button9.Name = "button9";
            button9.Size = new Size(24, 30);
            button9.TabIndex = 8;
            button9.UseVisualStyleBackColor = false;
            button9.Click += button9_Click;
            // 
            // UserInformation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.AdminBlur;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1384, 811);
            Controls.Add(button9);
            Controls.Add(panel1);
            Controls.Add(button2);
            Controls.Add(button1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "UserInformation";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "User Information";
            Load += UserInformation_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Panel panel1;
        private Button button9;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private HScrollBar hScrollBar1;
        private Label label2;
        private Button button3;
    }
}