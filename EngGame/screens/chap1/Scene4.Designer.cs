namespace EngGame.screens.chap1
{
    partial class Scene4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Scene4));
            pictureBox1 = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            dialog1 = new Label();
            dialogBox = new PictureBox();
            doorButton = new Button();
            swordButton = new Button();
            alter = new Panel();
            bookHint = new Button();
            swordButton1 = new Button();
            doorpanel = new Panel();
            lockbutton6 = new Button();
            imageList1 = new ImageList(components);
            lockbutton5 = new Button();
            lockbutton4 = new Button();
            lockbutton3 = new Button();
            lockbutton2 = new Button();
            lockbutton1 = new Button();
            back = new Button();
            panel1 = new Panel();
            timer = new Label();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dialogBox).BeginInit();
            alter.SuspendLayout();
            doorpanel.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.배경1;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(-1, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1259, 676);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // dialog1
            // 
            dialog1.AutoSize = true;
            dialog1.BackColor = Color.FromArgb(255, 193, 198);
            dialog1.Font = new Font("맑은 고딕", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
            dialog1.ForeColor = Color.Black;
            dialog1.Location = new Point(152, 490);
            dialog1.Name = "dialog1";
            dialog1.Size = new Size(21, 20);
            dialog1.TabIndex = 4;
            dialog1.Text = "...";
            dialog1.Click += dialog1_Click;
            // 
            // dialogBox
            // 
            dialogBox.BackColor = Color.Transparent;
            dialogBox.BackgroundImage = (Image)resources.GetObject("dialogBox.BackgroundImage");
            dialogBox.Location = new Point(137, 470);
            dialogBox.Name = "dialogBox";
            dialogBox.Size = new Size(981, 193);
            dialogBox.TabIndex = 3;
            dialogBox.TabStop = false;
            dialogBox.Click += dialogBox_Click;
            // 
            // doorButton
            // 
            doorButton.AutoSize = true;
            doorButton.BackgroundImage = Properties.Resources.door;
            doorButton.BackgroundImageLayout = ImageLayout.Zoom;
            doorButton.Cursor = Cursors.Hand;
            doorButton.FlatAppearance.BorderSize = 0;
            doorButton.FlatStyle = FlatStyle.Flat;
            doorButton.Location = new Point(562, 279);
            doorButton.Name = "doorButton";
            doorButton.Size = new Size(122, 143);
            doorButton.TabIndex = 5;
            doorButton.UseVisualStyleBackColor = true;
            doorButton.Visible = false;
            doorButton.Click += doorButton_Click;
            // 
            // swordButton
            // 
            swordButton.AutoSize = true;
            swordButton.BackgroundImage = Properties.Resources.sword;
            swordButton.Cursor = Cursors.Hand;
            swordButton.FlatAppearance.BorderSize = 0;
            swordButton.FlatStyle = FlatStyle.Flat;
            swordButton.Location = new Point(0, 0);
            swordButton.Name = "swordButton";
            swordButton.Size = new Size(32, 160);
            swordButton.TabIndex = 6;
            swordButton.UseVisualStyleBackColor = true;
            swordButton.Visible = false;
            swordButton.Click += swordButton_Click;
            // 
            // alter
            // 
            alter.BackgroundImage = Properties.Resources.제단1;
            alter.BackgroundImageLayout = ImageLayout.Zoom;
            alter.Controls.Add(bookHint);
            alter.Controls.Add(swordButton1);
            alter.Location = new Point(494, 57);
            alter.Name = "alter";
            alter.Size = new Size(265, 407);
            alter.TabIndex = 7;
            alter.Visible = false;
            alter.Paint += alter_Paint;
            // 
            // bookHint
            // 
            bookHint.BackgroundImage = Properties.Resources.book;
            bookHint.BackgroundImageLayout = ImageLayout.Zoom;
            bookHint.Cursor = Cursors.Hand;
            bookHint.FlatAppearance.BorderSize = 0;
            bookHint.FlatStyle = FlatStyle.Flat;
            bookHint.Location = new Point(33, 339);
            bookHint.Name = "bookHint";
            bookHint.Size = new Size(36, 22);
            bookHint.TabIndex = 1;
            bookHint.UseVisualStyleBackColor = true;
            bookHint.Click += bookHint_Click;
            // 
            // swordButton1
            // 
            swordButton1.BackgroundImage = Properties.Resources.sworddisc;
            swordButton1.BackgroundImageLayout = ImageLayout.Zoom;
            swordButton1.Cursor = Cursors.Hand;
            swordButton1.FlatAppearance.BorderSize = 0;
            swordButton1.FlatStyle = FlatStyle.Flat;
            swordButton1.Location = new Point(122, 40);
            swordButton1.Name = "swordButton1";
            swordButton1.Size = new Size(20, 288);
            swordButton1.TabIndex = 0;
            swordButton1.UseVisualStyleBackColor = true;
            swordButton1.Click += swordButton1_Click;
            // 
            // doorpanel
            // 
            doorpanel.BackgroundImage = (Image)resources.GetObject("doorpanel.BackgroundImage");
            doorpanel.BackgroundImageLayout = ImageLayout.Zoom;
            doorpanel.Controls.Add(lockbutton6);
            doorpanel.Controls.Add(lockbutton5);
            doorpanel.Controls.Add(lockbutton4);
            doorpanel.Controls.Add(lockbutton3);
            doorpanel.Controls.Add(lockbutton2);
            doorpanel.Controls.Add(lockbutton1);
            doorpanel.Location = new Point(443, 131);
            doorpanel.Name = "doorpanel";
            doorpanel.Size = new Size(368, 235);
            doorpanel.TabIndex = 8;
            doorpanel.Visible = false;
            // 
            // lockbutton6
            // 
            lockbutton6.BackColor = Color.Transparent;
            lockbutton6.FlatAppearance.BorderSize = 0;
            lockbutton6.FlatStyle = FlatStyle.Flat;
            lockbutton6.ImageIndex = 0;
            lockbutton6.ImageList = imageList1;
            lockbutton6.Location = new Point(255, 141);
            lockbutton6.Name = "lockbutton6";
            lockbutton6.Size = new Size(32, 41);
            lockbutton6.TabIndex = 5;
            lockbutton6.UseVisualStyleBackColor = false;
            lockbutton6.Click += lockbutton6_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "A_Lock.PNG");
            imageList1.Images.SetKeyName(1, "C_Lock.PNG");
            imageList1.Images.SetKeyName(2, "D_Lock.PNG");
            imageList1.Images.SetKeyName(3, "E_Lock.PNG");
            imageList1.Images.SetKeyName(4, "F_Lock.PNG");
            imageList1.Images.SetKeyName(5, "H_Lock.PNG");
            imageList1.Images.SetKeyName(6, "I_Lock.PNG");
            imageList1.Images.SetKeyName(7, "T_Lock.PNG");
            // 
            // lockbutton5
            // 
            lockbutton5.BackColor = Color.Transparent;
            lockbutton5.FlatAppearance.BorderSize = 0;
            lockbutton5.FlatStyle = FlatStyle.Flat;
            lockbutton5.ImageIndex = 0;
            lockbutton5.ImageList = imageList1;
            lockbutton5.Location = new Point(218, 141);
            lockbutton5.Name = "lockbutton5";
            lockbutton5.Size = new Size(32, 41);
            lockbutton5.TabIndex = 4;
            lockbutton5.UseVisualStyleBackColor = false;
            lockbutton5.Click += lockbutton5_Click;
            // 
            // lockbutton4
            // 
            lockbutton4.BackColor = Color.Transparent;
            lockbutton4.FlatAppearance.BorderSize = 0;
            lockbutton4.FlatStyle = FlatStyle.Flat;
            lockbutton4.ImageIndex = 0;
            lockbutton4.ImageList = imageList1;
            lockbutton4.Location = new Point(184, 141);
            lockbutton4.Name = "lockbutton4";
            lockbutton4.Size = new Size(29, 41);
            lockbutton4.TabIndex = 3;
            lockbutton4.UseVisualStyleBackColor = false;
            lockbutton4.Click += lockbutton4_Click;
            // 
            // lockbutton3
            // 
            lockbutton3.BackColor = Color.Transparent;
            lockbutton3.FlatAppearance.BorderSize = 0;
            lockbutton3.FlatStyle = FlatStyle.Flat;
            lockbutton3.ImageIndex = 0;
            lockbutton3.ImageList = imageList1;
            lockbutton3.Location = new Point(151, 141);
            lockbutton3.Name = "lockbutton3";
            lockbutton3.Size = new Size(29, 41);
            lockbutton3.TabIndex = 2;
            lockbutton3.UseVisualStyleBackColor = false;
            lockbutton3.Click += lockbutton3_Click;
            // 
            // lockbutton2
            // 
            lockbutton2.BackColor = Color.Transparent;
            lockbutton2.FlatAppearance.BorderSize = 0;
            lockbutton2.FlatStyle = FlatStyle.Flat;
            lockbutton2.ImageIndex = 0;
            lockbutton2.ImageList = imageList1;
            lockbutton2.Location = new Point(115, 141);
            lockbutton2.Name = "lockbutton2";
            lockbutton2.Size = new Size(31, 41);
            lockbutton2.TabIndex = 1;
            lockbutton2.UseVisualStyleBackColor = false;
            lockbutton2.Click += lockbutton2_Click;
            // 
            // lockbutton1
            // 
            lockbutton1.BackColor = Color.Transparent;
            lockbutton1.FlatAppearance.BorderSize = 0;
            lockbutton1.FlatStyle = FlatStyle.Flat;
            lockbutton1.ImageIndex = 0;
            lockbutton1.ImageList = imageList1;
            lockbutton1.Location = new Point(80, 141);
            lockbutton1.Name = "lockbutton1";
            lockbutton1.Size = new Size(31, 41);
            lockbutton1.TabIndex = 0;
            lockbutton1.UseVisualStyleBackColor = false;
            lockbutton1.Click += lockbutton1_Click;
            // 
            // back
            // 
            back.Location = new Point(137, 25);
            back.Name = "back";
            back.Size = new Size(130, 38);
            back.TabIndex = 12;
            back.Text = "뒤로 가기";
            back.UseVisualStyleBackColor = true;
            back.Visible = false;
            back.Click += back_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(swordButton);
            panel1.Location = new Point(612, 350);
            panel1.Name = "panel1";
            panel1.Size = new Size(32, 100);
            panel1.TabIndex = 13;
            panel1.Visible = false;
            // 
            // timer
            // 
            timer.AutoSize = true;
            timer.BackColor = Color.FromArgb(255, 128, 0);
            timer.BorderStyle = BorderStyle.FixedSingle;
            timer.Font = new Font("맑은 고딕", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
            timer.Location = new Point(1026, 18);
            timer.Name = "timer";
            timer.Size = new Size(92, 39);
            timer.TabIndex = 14;
            timer.Text = "2 : 00";
            // 
            // panel2
            // 
            panel2.Controls.Add(doorpanel);
            panel2.Controls.Add(alter);
            panel2.Controls.Add(doorButton);
            panel2.Controls.Add(dialog1);
            panel2.Controls.Add(dialogBox);
            panel2.Controls.Add(timer);
            panel2.Controls.Add(back);
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1262, 679);
            panel2.TabIndex = 15;
            // 
            // Scene4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "Scene4";
            Size = new Size(1262, 679);
            Load += Scene4_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dialogBox).EndInit();
            alter.ResumeLayout(false);
            doorpanel.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private Label dialog1;
        private PictureBox dialogBox;
        private Button doorButton;
        private Button swordButton;
        private Panel alter;
        private Button swordButton1;
        private Button bookHint;
        private Panel doorpanel;
        private Button back;
        private Panel panel1;
        private Button lockbutton1;
        private ImageList imageList1;
        private Button lockbutton6;
        private Button lockbutton5;
        private Button lockbutton4;
        private Button lockbutton3;
        private Button lockbutton2;
        private Label timer;
        private Panel panel2;
    }
}
