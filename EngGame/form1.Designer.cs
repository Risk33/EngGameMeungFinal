namespace EngGame
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();


            
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();

            questionButton2 = new Button();
            pictureBox2 = new PictureBox();
            questionButton1 = new Button();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            backPictureBox = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)backPictureBox).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AccessibleRole = AccessibleRole.None;
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel1.BackColor = SystemColors.ControlDarkDark;


            panel1.Controls.Add(pictureBox4);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(questionButton2);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(questionButton1);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(backPictureBox);
            panel1.Location = new Point(1, 1);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1262, 679);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.New_Title_name1;
            pictureBox4.Location = new Point(504, 145);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(230, 180);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 11;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.End;
            pictureBox3.Location = new Point(563, 604);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(102, 52);
            pictureBox3.TabIndex = 10;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // questionButton2
            // 
            questionButton2.BackColor = Color.DimGray;
            questionButton2.Font = new Font("맑은 고딕", 12F, FontStyle.Bold);
            questionButton2.ForeColor = SystemColors.ControlLightLight;
            questionButton2.Location = new Point(506, 509);
            questionButton2.Name = "questionButton2";
            questionButton2.Size = new Size(30, 30);
            questionButton2.TabIndex = 8;
            questionButton2.Text = "?";
            questionButton2.TextAlign = ContentAlignment.MiddleRight;
            questionButton2.UseVisualStyleBackColor = false;
            questionButton2.Click += questionButton2_Click_1;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.chap21;
            pictureBox2.Location = new Point(517, 526);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(200, 62);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // questionButton1
            // 
            questionButton1.BackColor = Color.DimGray;
            questionButton1.Font = new Font("맑은 고딕", 12F, FontStyle.Bold);
            questionButton1.ForeColor = SystemColors.ControlLightLight;
            questionButton1.Location = new Point(506, 421);
            questionButton1.Name = "questionButton1";
            questionButton1.Size = new Size(30, 30);
            questionButton1.TabIndex = 7;
            questionButton1.Text = "?";
            questionButton1.TextAlign = ContentAlignment.MiddleRight;
            questionButton1.UseVisualStyleBackColor = false;
            questionButton1.Click += questionbutton1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Chap1;
            pictureBox1.Location = new Point(517, 438);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(200, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click_1;
            // 
            // button1
            // 
            button1.Location = new Point(14, 21);
            button1.Name = "button1";
            button1.Size = new Size(105, 23);
            button1.TabIndex = 1;
            button1.Text = "배드엔딩테스트";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // backPictureBox
            // 
            backPictureBox.BackColor = Color.FromArgb(255, 192, 128);
            backPictureBox.Image = (Image)resources.GetObject("backPictureBox.Image");
            backPictureBox.Location = new Point(-1, -24);
            backPictureBox.Margin = new Padding(0);
            backPictureBox.Name = "backPictureBox";
            backPictureBox.Size = new Size(1262, 800);
            backPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            backPictureBox.TabIndex = 5;
            backPictureBox.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1264, 681);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            Padding = new Padding(1);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Word Escape: Vocabulary Mission";
            Load += From1_load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)backPictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        public Panel panel1;
        private PictureBox backPictureBox;
        private PictureBox titlePictureBox;
        private Button questionButton1;
        private Button questionButton2;

        private Button button1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
    }
}
