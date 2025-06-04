namespace EngGame.screens.chap1
{
    partial class Scene2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Scene2));
            panel1 = new Panel();
            back = new Button();
            enter_button = new Button();
            peek_button = new Button();
            dialog1 = new Label();
            name = new Label();
            dialogBox = new PictureBox();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dialogBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(back);
            panel1.Controls.Add(enter_button);
            panel1.Controls.Add(peek_button);
            panel1.Controls.Add(dialog1);
            panel1.Controls.Add(name);
            panel1.Controls.Add(dialogBox);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1262, 679);
            panel1.TabIndex = 0;
            panel1.MouseClick += panel1_MouseClick;
            // 
            // back
            // 
            back.Location = new Point(50, 31);
            back.Name = "back";
            back.Size = new Size(130, 38);
            back.TabIndex = 11;
            back.Text = "뒤로 가기";
            back.UseVisualStyleBackColor = true;
            back.Visible = false;
            back.Click += back_Click;
            // 
            // enter_button
            // 
            enter_button.Location = new Point(951, 414);
            enter_button.Name = "enter_button";
            enter_button.Size = new Size(169, 38);
            enter_button.TabIndex = 10;
            enter_button.Text = "진입하기";
            enter_button.UseVisualStyleBackColor = true;
            enter_button.Visible = false;
            enter_button.Click += enter_button_Click;
            // 
            // peek_button
            // 
            peek_button.Location = new Point(951, 368);
            peek_button.Name = "peek_button";
            peek_button.Size = new Size(169, 38);
            peek_button.TabIndex = 9;
            peek_button.Text = "엿보기";
            peek_button.UseVisualStyleBackColor = true;
            peek_button.Visible = false;
            peek_button.Click += peek_button_Click;
            // 
            // dialog1
            // 
            dialog1.Anchor = AnchorStyles.Top;
            dialog1.AutoSize = true;
            dialog1.BackColor = Color.Transparent;
            dialog1.CausesValidation = false;
            dialog1.Font = new Font("맑은 고딕", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 129);
            dialog1.ForeColor = Color.White;
            dialog1.Location = new Point(368, 311);
            dialog1.Name = "dialog1";
            dialog1.Size = new Size(519, 47);
            dialog1.TabIndex = 8;
            dialog1.Text = "자물쇠를 풀고 지하로 내려갔다.";
            // 
            // name
            // 
            name.AutoSize = true;
            name.BackColor = Color.White;
            name.Font = new Font("맑은 고딕", 24F, FontStyle.Regular, GraphicsUnit.Point, 129);
            name.ForeColor = Color.Black;
            name.Image = Properties.Resources.simpleName;
            name.Location = new Point(149, 403);
            name.Name = "name";
            name.Size = new Size(0, 45);
            name.TabIndex = 7;
            name.Visible = false;
            // 
            // dialogBox
            // 
            dialogBox.BackColor = Color.Transparent;
            dialogBox.BackgroundImage = (Image)resources.GetObject("dialogBox.BackgroundImage");
            dialogBox.ErrorImage = null;
            dialogBox.InitialImage = (Image)resources.GetObject("dialogBox.InitialImage");
            dialogBox.Location = new Point(139, 463);
            dialogBox.Name = "dialogBox";
            dialogBox.Size = new Size(981, 193);
            dialogBox.TabIndex = 6;
            dialogBox.TabStop = false;
            dialogBox.Visible = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Black;
            pictureBox1.BackgroundImage = Properties.Resources.배경_제사실_앞;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(0, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1262, 679);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Visible = false;
            // 
            // Scene2
            // 
            AutoScaleMode = AutoScaleMode.None;
            Controls.Add(panel1);
            Name = "Scene2";
            Size = new Size(1262, 679);
            Load += Scene2_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dialogBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label name;
        private PictureBox dialogBox;
        private Label dialog1;
        private Button enter_button;
        private Button peek_button;
        private Button back;
    }
}
