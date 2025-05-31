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
            panel1 = new Panel();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dialogBox).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.배경1;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1259, 676);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // dialog1
            // 
            dialog1.AutoSize = true;
            dialog1.BackColor = Color.FromArgb(255, 193, 198);
            dialog1.Font = new Font("맑은 고딕", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
            dialog1.ForeColor = Color.Black;
            dialog1.Location = new Point(149, 484);
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
            dialogBox.Location = new Point(138, 470);
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
            swordButton.FlatAppearance.BorderSize = 0;
            swordButton.FlatStyle = FlatStyle.Flat;
            swordButton.Location = new Point(612, 350);
            swordButton.Name = "swordButton";
            swordButton.Size = new Size(32, 160);
            swordButton.TabIndex = 6;
            swordButton.UseVisualStyleBackColor = true;
            swordButton.Visible = false;
            swordButton.Click += button2_Click;
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.제단;
            panel1.BackgroundImageLayout = ImageLayout.Zoom;
            panel1.Controls.Add(button1);
            panel1.Location = new Point(495, 57);
            panel1.Name = "panel1";
            panel1.Size = new Size(265, 407);
            panel1.TabIndex = 7;
            panel1.Visible = false;
            // 
            // button1
            // 
            button1.BackgroundImage = Properties.Resources.sworddisc;
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(122, 40);
            button1.Name = "button1";
            button1.Size = new Size(20, 288);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = true;
            button1.Visible = false;
            // 
            // Scene4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            Controls.Add(dialog1);
            Controls.Add(dialogBox);
            Controls.Add(panel1);
            Controls.Add(swordButton);
            Controls.Add(doorButton);
            Controls.Add(pictureBox1);
            Name = "Scene4";
            Size = new Size(1262, 679);
            Load += Scene4_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dialogBox).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private Label dialog1;
        private PictureBox dialogBox;
        private Button doorButton;
        private Button swordButton;
        private Panel panel1;
        private Button button1;
    }
}
