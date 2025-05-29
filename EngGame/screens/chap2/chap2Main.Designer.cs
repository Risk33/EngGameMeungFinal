

namespace EngGame.screens
{
    partial class chap2Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(chap2Main));
            chap1 = new Panel();
            dialog1 = new Label();
            name = new Label();
            dialogBox = new PictureBox();
            pictureBox1 = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            chap1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dialogBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // chap1
            // 
            chap1.AutoSize = true;
            chap1.BackColor = Color.Black;
            chap1.BackgroundImageLayout = ImageLayout.Center;
            chap1.Controls.Add(dialog1);
            chap1.Controls.Add(name);
            chap1.Controls.Add(dialogBox);
            chap1.Controls.Add(pictureBox1);
            chap1.Location = new Point(0, 0);
            chap1.Name = "chap1";
            chap1.Size = new Size(1262, 682);
            chap1.TabIndex = 0;
            chap1.Click += chap1story1_Click;
            // 
            // dialog1
            // 
            dialog1.AutoSize = true;
            dialog1.BackColor = Color.Transparent;
            dialog1.CausesValidation = false;
            dialog1.Font = new Font("맑은 고딕", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 129);
            dialog1.ForeColor = Color.White;
            dialog1.Location = new Point(532, 325);
            dialog1.Name = "dialog1";
            dialog1.Size = new Size(175, 47);
            dialog1.TabIndex = 0;
            dialog1.Text = "Chapter 2";
            dialog1.Click += Dialog1_Click;
            // 
            // name
            // 
            name.AutoSize = true;
            name.BackColor = Color.White;
            name.Font = new Font("맑은 고딕", 24F, FontStyle.Regular, GraphicsUnit.Point, 129);
            name.ForeColor = Color.Black;
            name.Image = Properties.Resources.cat_reacts;
            name.Location = new Point(151, 412);
            name.Name = "name";
            name.Size = new Size(84, 45);
            name.TabIndex = 5;
            name.Text = "이름";
            name.Visible = false;
            // 
            // dialogBox
            // 
            dialogBox.BackColor = Color.Transparent;
            dialogBox.BackgroundImage = (Image)resources.GetObject("dialogBox.BackgroundImage");
            dialogBox.ErrorImage = null;
            dialogBox.InitialImage = (Image)resources.GetObject("dialogBox.InitialImage");
            dialogBox.Location = new Point(144, 465);
            dialogBox.Name = "dialogBox";
            dialogBox.Size = new Size(981, 193);
            dialogBox.TabIndex = 3;
            dialogBox.TabStop = false;
            dialogBox.Visible = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Image = Properties.Resources.배경_새벽_병원_외관;
            pictureBox1.Location = new Point(88, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1072, 679);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            pictureBox1.Visible = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // chap2Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(chap1);
            Name = "chap2Main";
            Size = new Size(1262, 679);
            Load += chap1Main_Load;
            chap1.ResumeLayout(false);
            chap1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dialogBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel chap1;
        private Label dialog1;
        private PictureBox dialogBox;
        private Label name;
        private PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
    }
}
