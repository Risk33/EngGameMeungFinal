

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
            chap2 = new Panel();
            decoPanel = new Panel();
            name2 = new Label();
            name1 = new Label();
            dialog1 = new Label();
            dialog2 = new Label();
            chap2.SuspendLayout();
            decoPanel.SuspendLayout();
            SuspendLayout();
            // 
            // chap2
            // 
            chap2.AutoSize = true;
            chap2.BackColor = Color.Black;
            chap2.BackgroundImageLayout = ImageLayout.Zoom;
            chap2.Controls.Add(decoPanel);
            chap2.Location = new Point(0, 0);
            chap2.Name = "chap2";
            chap2.Size = new Size(1265, 682);
            chap2.TabIndex = 0;
            chap2.Click += chap1story1_Click;
            // 
            // decoPanel
            // 
            decoPanel.BackColor = Color.Transparent;
            decoPanel.BackgroundImage = Properties.Resources.dialog;
            decoPanel.BackgroundImageLayout = ImageLayout.Stretch;
            decoPanel.Controls.Add(name2);
            decoPanel.Controls.Add(name1);
            decoPanel.Controls.Add(dialog1);
            decoPanel.Controls.Add(dialog2);
            decoPanel.Location = new Point(3, 3);
            decoPanel.Name = "decoPanel";
            decoPanel.Size = new Size(1259, 673);
            decoPanel.TabIndex = 3;
            decoPanel.Click += chap1story1_Click;
            // 
            // name2
            // 
            name2.AutoSize = true;
            name2.Font = new Font("함초롬바탕 확장", 18F, FontStyle.Bold, GraphicsUnit.Point, 129);
            name2.ForeColor = Color.Red;
            name2.Location = new Point(35, 101);
            name2.Name = "name2";
            name2.Size = new Size(0, 32);
            name2.TabIndex = 4;
            name2.Visible = false;
            // 
            // name1
            // 
            name1.AutoSize = true;
            name1.Font = new Font("함초롬바탕 확장", 18F, FontStyle.Bold, GraphicsUnit.Point, 129);
            name1.ForeColor = Color.Yellow;
            name1.Location = new Point(35, 508);
            name1.Name = "name1";
            name1.Size = new Size(0, 32);
            name1.TabIndex = 3;
            // 
            // dialog1
            // 
            dialog1.AutoSize = true;
            dialog1.BackColor = Color.Transparent;
            dialog1.CausesValidation = false;
            dialog1.Font = new Font("맑은 고딕", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 129);
            dialog1.ForeColor = Color.White;
            dialog1.Location = new Point(542, 318);
            dialog1.Name = "dialog1";
            dialog1.Size = new Size(175, 47);
            dialog1.TabIndex = 0;
            dialog1.Text = "Chapter 2";
            dialog1.Click += Dialog1_Click;
            // 
            // dialog2
            // 
            dialog2.AutoSize = true;
            dialog2.BackColor = Color.Transparent;
            dialog2.CausesValidation = false;
            dialog2.Font = new Font("맑은 고딕", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 129);
            dialog2.ForeColor = Color.White;
            dialog2.Location = new Point(573, 167);
            dialog2.Name = "dialog2";
            dialog2.Size = new Size(0, 47);
            dialog2.TabIndex = 2;
            // 
            // chap2Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(chap2);
            Name = "chap2Main";
            Size = new Size(1262, 679);
            Load += chap1Main_Load;
            chap2.ResumeLayout(false);
            decoPanel.ResumeLayout(false);
            decoPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel chap2;
        private Label dialog1;
        private Label dialog2;
        private Panel decoPanel;
        private Label name1;
        private Label name2;
    }
}
