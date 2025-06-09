namespace EngGame.screens.chap1
{
    partial class Badend1
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
            dialog1 = new Label();
            name = new Label();
            dialogBox = new Panel();
            panel1 = new Panel();
            dialogBox.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dialog1
            // 
            dialog1.AutoSize = true;
            dialog1.BackColor = Color.Transparent;
            dialog1.Font = new Font("함초롬돋움", 21.7499962F, FontStyle.Bold, GraphicsUnit.Point, 129);
            dialog1.ForeColor = Color.White;
            dialog1.Location = new Point(591, 317);
            dialog1.Name = "dialog1";
            dialog1.Size = new Size(41, 38);
            dialog1.TabIndex = 8;
            dialog1.Text = "...";
            dialog1.Visible = false;
            dialog1.Click += dialogBox_Click;
            // 
            // name
            // 
            name.AutoSize = true;
            name.BackColor = Color.White;
            name.Font = new Font("맑은 고딕", 24F, FontStyle.Regular, GraphicsUnit.Point, 129);
            name.ForeColor = Color.Black;
            name.Image = Properties.Resources.cat_reacts;
            name.Location = new Point(147, 422);
            name.Name = "name";
            name.Size = new Size(0, 45);
            name.TabIndex = 9;
            name.Visible = false;
            // 
            // dialogBox
            // 
            dialogBox.BackColor = Color.Transparent;
            dialogBox.BackgroundImage = Properties.Resources.dialog1;
            dialogBox.BackgroundImageLayout = ImageLayout.Stretch;
            dialogBox.Controls.Add(dialog1);
            dialogBox.Location = new Point(0, 0);
            dialogBox.Name = "dialogBox";
            dialogBox.Size = new Size(1262, 679);
            dialogBox.TabIndex = 10;
            dialogBox.Click += pictureBox1_Click;
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.badend1;
            panel1.BackgroundImageLayout = ImageLayout.Zoom;
            panel1.Controls.Add(dialogBox);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1262, 679);
            panel1.TabIndex = 0;
            // 
            // Badend1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            BackgroundImageLayout = ImageLayout.Zoom;
            Controls.Add(panel1);
            Controls.Add(name);
            Name = "Badend1";
            Size = new Size(1262, 679);
            Load += Badend1_Load;
            dialogBox.ResumeLayout(false);
            dialogBox.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label dialog1;
        private Label name;
        private Panel dialogBox;
        private Panel panel1;
    }
}
