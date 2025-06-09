

namespace EngGame.screens
{
    partial class chap1Main
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
            chap1 = new Panel();
            dialogBox = new Panel();
            name = new Label();
            dialog1 = new Label();
            chap1.SuspendLayout();
            dialogBox.SuspendLayout();
            SuspendLayout();
            // 
            // chap1
            // 
            chap1.BackColor = Color.Black;
            chap1.BackgroundImageLayout = ImageLayout.Zoom;
            chap1.Controls.Add(dialogBox);
            chap1.Location = new Point(0, 0);
            chap1.Name = "chap1";
            chap1.Size = new Size(1262, 679);
            chap1.TabIndex = 0;
            chap1.Click += chap1story1_Click;
            // 
            // dialogBox
            // 
            dialogBox.BackColor = Color.Transparent;
            dialogBox.BackgroundImage = Properties.Resources.dialog1;
            dialogBox.BackgroundImageLayout = ImageLayout.Stretch;
            dialogBox.Controls.Add(name);
            dialogBox.Controls.Add(dialog1);
            dialogBox.Location = new Point(0, 0);
            dialogBox.Name = "dialogBox";
            dialogBox.Size = new Size(1262, 679);
            dialogBox.TabIndex = 6;
            dialogBox.Click += dialogBox_Click;
            // 
            // name
            // 
            name.AutoSize = true;
            name.BackColor = Color.Transparent;
            name.Font = new Font("함초롬돋움", 24F, FontStyle.Bold, GraphicsUnit.Point, 129);
            name.ForeColor = Color.White;
            name.Location = new Point(106, 460);
            name.Name = "name";
            name.Size = new Size(80, 41);
            name.TabIndex = 5;
            name.Text = "이름";
            name.Visible = false;
            // 
            // dialog1
            // 
            dialog1.Anchor = AnchorStyles.Top;
            dialog1.AutoSize = true;
            dialog1.BackColor = Color.Transparent;
            dialog1.CausesValidation = false;
            dialog1.Font = new Font("Felix Titling", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dialog1.ForeColor = Color.White;
            dialog1.Location = new Point(517, 266);
            dialog1.Name = "dialog1";
            dialog1.Size = new Size(209, 40);
            dialog1.TabIndex = 0;
            dialog1.Text = "Chapter 1";
            dialog1.Click += Dialog1_Click;
            // 
            // chap1Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(chap1);
            Name = "chap1Main";
            Size = new Size(1262, 679);
            Load += chap1Main_Load;
            chap1.ResumeLayout(false);
            dialogBox.ResumeLayout(false);
            dialogBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel chap1;
        private Label dialog1;
        private Label name;
        private Panel dialogBox;
    }
}
