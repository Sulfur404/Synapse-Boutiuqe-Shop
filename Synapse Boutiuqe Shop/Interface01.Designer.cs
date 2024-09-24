namespace Synapse_Boutiuqe_Shop
{
    partial class Interface01
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Interface01));
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            pictureBox1 = new PictureBox();
            optionBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button3
            // 
            button3.BackColor = Color.Transparent;
            button3.BackgroundImage = Properties.Resources.Back;
            button3.BackgroundImageLayout = ImageLayout.Stretch;
            button3.Cursor = Cursors.Hand;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Location = new Point(2, 1);
            button3.Name = "button3";
            button3.Size = new Size(41, 49);
            button3.TabIndex = 20;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Transparent;
            button4.Cursor = Cursors.Hand;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.DimGray;
            button4.Location = new Point(1302, -15);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(40, 79);
            button4.TabIndex = 23;
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
            button5.Location = new Point(1336, 1);
            button5.Margin = new Padding(3, 4, 3, 4);
            button5.Name = "button5";
            button5.Size = new Size(37, 51);
            button5.TabIndex = 22;
            button5.Text = "X";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources.Welcome__3_;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(63, 19);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(304, 116);
            pictureBox1.TabIndex = 24;
            pictureBox1.TabStop = false;
            // 
            // optionBtn
            // 
            optionBtn.BackColor = Color.Transparent;
            optionBtn.BackgroundImage = Properties.Resources.hamburger1;
            optionBtn.BackgroundImageLayout = ImageLayout.Stretch;
            optionBtn.FlatAppearance.BorderSize = 0;
            optionBtn.FlatStyle = FlatStyle.Flat;
            optionBtn.Location = new Point(10, 56);
            optionBtn.Name = "optionBtn";
            optionBtn.Size = new Size(47, 36);
            optionBtn.TabIndex = 25;
            optionBtn.UseVisualStyleBackColor = false;
            // 
            // Interface01
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Brown_and_White_Aesthetic_Thank_You_Poster_Landscape__1_2;
            ClientSize = new Size(1382, 803);
            Controls.Add(optionBtn);
            Controls.Add(pictureBox1);
            Controls.Add(button4);
            Controls.Add(button5);
            Controls.Add(button3);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Interface01";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Interface01";
            Load += Interface01_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button3;
        private Button button4;
        private Button button5;
        private PictureBox pictureBox1;
        private Button optionBtn;
    }
}