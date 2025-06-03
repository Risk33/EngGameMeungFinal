namespace EngGame.screens.chap1
{
    partial class Scene5
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Scene5));
            panel1 = new Panel();
            timer = new Label();
            openSafePanel = new Panel();
            dialog1 = new Label();
            dialogBox = new PictureBox();
            back = new Button();
            panel2 = new Panel();
            passSubmit = new Button();
            pass2 = new Label();
            pass1 = new Label();
            safebutton = new Button();
            bookButton = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dialogBox).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Zoom;
            panel1.Controls.Add(timer);
            panel1.Controls.Add(openSafePanel);
            panel1.Controls.Add(dialog1);
            panel1.Controls.Add(dialogBox);
            panel1.Controls.Add(back);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(safebutton);
            panel1.Controls.Add(bookButton);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1262, 679);
            panel1.TabIndex = 0;
            // 
            // timer
            // 
            timer.AutoSize = true;
            timer.BackColor = Color.FromArgb(255, 128, 0);
            timer.BorderStyle = BorderStyle.FixedSingle;
            timer.Font = new Font("맑은 고딕", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
            timer.Location = new Point(1035, 45);
            timer.Name = "timer";
            timer.Size = new Size(92, 39);
            timer.TabIndex = 15;
            timer.Text = "2 : 00";
            timer.Visible = false;
            // 
            // openSafePanel
            // 
            openSafePanel.BackgroundImage = Properties.Resources.openSafe;
            openSafePanel.BackgroundImageLayout = ImageLayout.Zoom;
            openSafePanel.Location = new Point(448, 47);
            openSafePanel.Name = "openSafePanel";
            openSafePanel.Size = new Size(382, 387);
            openSafePanel.TabIndex = 14;
            openSafePanel.Visible = false;
            // 
            // dialog1
            // 
            dialog1.AutoSize = true;
            dialog1.BackColor = Color.FromArgb(255, 193, 198);
            dialog1.Font = new Font("맑은 고딕", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
            dialog1.ForeColor = Color.Black;
            dialog1.Location = new Point(145, 473);
            dialog1.Name = "dialog1";
            dialog1.Size = new Size(260, 20);
            dialog1.TabIndex = 6;
            dialog1.Text = "ㅇㅇ아..! 얼른 수갑을 풀어줘야겠어..!";
            dialog1.Click += dialogBox_Click;
            // 
            // dialogBox
            // 
            dialogBox.BackColor = Color.Transparent;
            dialogBox.BackgroundImage = (Image)resources.GetObject("dialogBox.BackgroundImage");
            dialogBox.Location = new Point(134, 463);
            dialogBox.Name = "dialogBox";
            dialogBox.Size = new Size(981, 193);
            dialogBox.TabIndex = 5;
            dialogBox.TabStop = false;
            dialogBox.Click += dialogBox_Click;
            // 
            // back
            // 
            back.Location = new Point(985, 396);
            back.Name = "back";
            back.Size = new Size(130, 38);
            back.TabIndex = 13;
            back.Text = "뒤로 가기";
            back.UseVisualStyleBackColor = true;
            back.Visible = false;
            back.Click += back_Click;
            // 
            // panel2
            // 
            panel2.BackgroundImage = Properties.Resources.vault;
            panel2.BackgroundImageLayout = ImageLayout.Zoom;
            panel2.Controls.Add(passSubmit);
            panel2.Controls.Add(pass2);
            panel2.Controls.Add(pass1);
            panel2.Location = new Point(400, 101);
            panel2.Name = "panel2";
            panel2.Size = new Size(483, 297);
            panel2.TabIndex = 9;
            panel2.Visible = false;
            // 
            // passSubmit
            // 
            passSubmit.BackgroundImage = Properties.Resources.vault_submit;
            passSubmit.Cursor = Cursors.Hand;
            passSubmit.FlatAppearance.BorderSize = 0;
            passSubmit.FlatStyle = FlatStyle.Flat;
            passSubmit.Location = new Point(172, 90);
            passSubmit.Name = "passSubmit";
            passSubmit.Size = new Size(134, 133);
            passSubmit.TabIndex = 4;
            passSubmit.UseVisualStyleBackColor = true;
            passSubmit.Click += passSubmit_Click;
            // 
            // pass2
            // 
            pass2.AutoSize = true;
            pass2.BackColor = Color.Black;
            pass2.Font = new Font("맑은 고딕", 20F, FontStyle.Bold);
            pass2.ForeColor = Color.DarkGreen;
            pass2.Location = new Point(392, 25);
            pass2.Name = "pass2";
            pass2.Size = new Size(49, 37);
            pass2.TabIndex = 3;
            pass2.Text = "00";
            // 
            // pass1
            // 
            pass1.AutoSize = true;
            pass1.BackColor = Color.Black;
            pass1.Font = new Font("맑은 고딕", 20F, FontStyle.Bold);
            pass1.ForeColor = Color.DarkGreen;
            pass1.Location = new Point(36, 25);
            pass1.Name = "pass1";
            pass1.Size = new Size(49, 37);
            pass1.TabIndex = 0;
            pass1.Text = "00";
            // 
            // safebutton
            // 
            safebutton.Cursor = Cursors.Hand;
            safebutton.FlatAppearance.BorderSize = 0;
            safebutton.FlatStyle = FlatStyle.Flat;
            safebutton.Image = Properties.Resources.safe;
            safebutton.Location = new Point(139, 175);
            safebutton.Name = "safebutton";
            safebutton.Size = new Size(134, 270);
            safebutton.TabIndex = 8;
            safebutton.UseVisualStyleBackColor = true;
            safebutton.Click += safebutton_Click;
            // 
            // bookButton
            // 
            bookButton.BackgroundImage = Properties.Resources.bookB;
            bookButton.Cursor = Cursors.Hand;
            bookButton.FlatAppearance.BorderSize = 0;
            bookButton.FlatStyle = FlatStyle.Flat;
            bookButton.Location = new Point(199, 47);
            bookButton.Name = "bookButton";
            bookButton.Size = new Size(260, 48);
            bookButton.TabIndex = 7;
            bookButton.UseVisualStyleBackColor = true;
            bookButton.Click += bookButton_Click;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // Scene5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "Scene5";
            Size = new Size(1262, 679);
            Load += Scene5_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dialogBox).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label dialog1;
        private PictureBox dialogBox;
        private Button bookButton;
        private Button safebutton;
        private Panel panel2;
        private Label pass2;
        private Label pass1;
        private Button back;
        private System.Windows.Forms.Timer timer1;
        private Button passSubmit;
        private Panel openSafePanel;
        private Label timer;
    }
}
