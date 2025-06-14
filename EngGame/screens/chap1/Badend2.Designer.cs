﻿namespace EngGame.screens.chap1
{
    partial class Badend2
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
            pictureBox1 = new PictureBox();
            dialog1 = new Label();
            pictureBox2 = new PictureBox();
            dialogBox = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            dialogBox.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.badEnd2;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(98, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1262, 679);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // dialog1
            // 
            dialog1.AutoSize = true;
            dialog1.BackColor = Color.WhiteSmoke;
            dialog1.Font = new Font("맑은 고딕", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
            dialog1.ForeColor = Color.Black;
            dialog1.Location = new Point(131, 477);
            dialog1.Name = "dialog1";
            dialog1.Size = new Size(21, 20);
            dialog1.TabIndex = 4;
            dialog1.Text = "...";
            dialog1.Click += dialogBox_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Black;
            pictureBox2.Location = new Point(3, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(1262, 679);
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // dialogBox
            // 
            dialogBox.BackColor = Color.Transparent;
            dialogBox.BackgroundImage = Properties.Resources.dialog1;
            dialogBox.BackgroundImageLayout = ImageLayout.Stretch;
            dialogBox.Controls.Add(pictureBox2);
            dialogBox.Controls.Add(dialog1);
            dialogBox.Location = new Point(0, 3);
            dialogBox.Name = "dialogBox";
            dialogBox.Size = new Size(1259, 679);
            dialogBox.TabIndex = 6;
            dialogBox.Click += dialogBox_Click;
            // 
            // Badend2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            BackgroundImage = Properties.Resources.badEnd2;
            BackgroundImageLayout = ImageLayout.Zoom;
            Controls.Add(dialogBox);
            Controls.Add(pictureBox1);
            Name = "Badend2";
            Size = new Size(1262, 679);
            Load += Badend2_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            dialogBox.ResumeLayout(false);
            dialogBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Label dialog1;
        private PictureBox pictureBox2;
        private Panel dialogBox;
    }
}
