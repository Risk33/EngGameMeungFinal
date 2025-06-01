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
            panel1 = new Panel();
            questionButton2 = new Button();
            questionButton1 = new Button();
            buttonEnd = new Button();
            buttonChap2 = new Button();
            buttonChap1 = new Button();
            backPictureBox = new PictureBox();
            button1 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)backPictureBox).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AccessibleRole = AccessibleRole.None;
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel1.BackColor = SystemColors.ControlDarkDark;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(questionButton2);
            panel1.Controls.Add(questionButton1);
            panel1.Controls.Add(buttonEnd);
            panel1.Controls.Add(buttonChap2);
            panel1.Controls.Add(buttonChap1);
            panel1.Controls.Add(backPictureBox);
            panel1.Location = new Point(1, 1);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1262, 679);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // questionButton2
            // 
            questionButton2.BackColor = Color.FromArgb(255, 128, 0);
            questionButton2.Font = new Font("맑은 고딕", 12F, FontStyle.Bold);
            questionButton2.Location = new Point(518, 557);
            questionButton2.Name = "questionButton2";
            questionButton2.Size = new Size(30, 30);
            questionButton2.TabIndex = 8;
            questionButton2.Text = "?";
            questionButton2.TextAlign = ContentAlignment.MiddleRight;
            questionButton2.UseVisualStyleBackColor = false;
            questionButton2.Click += questionButton2_Click_1;
            // 
            // questionButton1
            // 
            questionButton1.BackColor = Color.FromArgb(255, 128, 0);
            questionButton1.Font = new Font("맑은 고딕", 12F, FontStyle.Bold);
            questionButton1.Location = new Point(519, 459);
            questionButton1.Name = "questionButton1";
            questionButton1.Size = new Size(30, 30);
            questionButton1.TabIndex = 7;
            questionButton1.Text = "?";
            questionButton1.TextAlign = ContentAlignment.MiddleRight;
            questionButton1.UseVisualStyleBackColor = false;
            questionButton1.Click += questionbutton1_Click;
            // 
            // buttonEnd
            // 
            buttonEnd.Font = new Font("맑은 고딕", 9F, FontStyle.Bold);
            buttonEnd.Location = new Point(1136, 606);
            buttonEnd.Name = "buttonEnd";
            buttonEnd.Size = new Size(102, 52);
            buttonEnd.TabIndex = 2;
            buttonEnd.Text = "게임 종료";
            buttonEnd.UseVisualStyleBackColor = true;
            buttonEnd.Click += buttonEnd_Click;
            // 
            // buttonChap2
            // 
            buttonChap2.Font = new Font("맑은 고딕", 12F, FontStyle.Bold);
            buttonChap2.Location = new Point(531, 563);
            buttonChap2.Name = "buttonChap2";
            buttonChap2.Size = new Size(200, 62);
            buttonChap2.TabIndex = 1;
            buttonChap2.Text = "챕터:2 병원";
            buttonChap2.UseVisualStyleBackColor = true;
            buttonChap2.Click += button2High_Click;
            // 
            // buttonChap1
            // 
            buttonChap1.Font = new Font("맑은 고딕", 12F, FontStyle.Bold);
            buttonChap1.Location = new Point(531, 466);
            buttonChap1.Name = "buttonChap1";
            buttonChap1.Size = new Size(200, 62);
            buttonChap1.TabIndex = 1;
            buttonChap1.Text = "챕터1: School";
            buttonChap1.UseVisualStyleBackColor = true;
            buttonChap1.Click += button1Mid_Click;
            // 
            // backPictureBox
            // 
            backPictureBox.BackColor = Color.FromArgb(255, 192, 128);
            backPictureBox.Image = Properties.Resources.mainScreen;
            backPictureBox.Location = new Point(0, 0);
            backPictureBox.Margin = new Padding(0);
            backPictureBox.Name = "backPictureBox";
            backPictureBox.Size = new Size(1262, 800);
            backPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            backPictureBox.TabIndex = 5;
            backPictureBox.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(264, 268);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
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
            Text = "Form1";
            Load += From1_load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)backPictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        public Panel panel1;
        private Button buttonEnd;
        private Button buttonChap2;
        private Button buttonChap1;
        private PictureBox backPictureBox;
        private PictureBox titlePictureBox;
        private Button questionButton1;
        private Button questionButton2;
        private Button button1;
    }
}
