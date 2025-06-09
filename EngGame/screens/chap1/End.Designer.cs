namespace EngGame.screens.chap1
{
    partial class End
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
            panel1 = new Panel();
            dialog1 = new Label();
            dialogBox = new Panel();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            dialogBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.탈출;
            panel1.BackgroundImageLayout = ImageLayout.Zoom;
            panel1.Controls.Add(dialogBox);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1262, 679);
            panel1.TabIndex = 0;
            panel1.Click += panel1_Click;
            // 
            // dialog1
            // 
            dialog1.Anchor = AnchorStyles.Top;
            dialog1.AutoSize = true;
            dialog1.BackColor = Color.Black;
            dialog1.CausesValidation = false;
            dialog1.Font = new Font("함초롬돋움", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
            dialog1.ForeColor = Color.White;
            dialog1.Location = new Point(169, 239);
            dialog1.Name = "dialog1";
            dialog1.Size = new Size(933, 45);
            dialog1.TabIndex = 1;
            dialog1.Text = "우리는 운이 좋게 아무도 마주치지 않고 빠져나올 수 있었다.";
            dialog1.Click += panel1_Click;
            // 
            // dialogBox
            // 
            dialogBox.BackColor = Color.Transparent;
            dialogBox.BackgroundImage = Properties.Resources.dialog1;
            dialogBox.BackgroundImageLayout = ImageLayout.Stretch;
            dialogBox.Controls.Add(dialog1);
            dialogBox.Controls.Add(pictureBox1);
            dialogBox.ForeColor = SystemColors.ControlText;
            dialogBox.Location = new Point(3, 3);
            dialogBox.Name = "dialogBox";
            dialogBox.Size = new Size(1259, 676);
            dialogBox.TabIndex = 8;
            dialogBox.Click += panel1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Black;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1262, 679);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // End
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            Controls.Add(panel1);
            Name = "End";
            Size = new Size(1262, 679);
            panel1.ResumeLayout(false);
            dialogBox.ResumeLayout(false);
            dialogBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label dialog1;
        private PictureBox pictureBox1;
        private Panel dialogBox;
    }
}
