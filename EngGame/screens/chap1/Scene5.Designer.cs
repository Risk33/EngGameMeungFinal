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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Scene5));
            panel1 = new Panel();
            dialog1 = new Label();
            dialogBox = new PictureBox();
            bookButton = new Button();
            safebutton = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dialogBox).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Zoom;
            panel1.Controls.Add(safebutton);
            panel1.Controls.Add(bookButton);
            panel1.Controls.Add(dialog1);
            panel1.Controls.Add(dialogBox);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1262, 679);
            panel1.TabIndex = 0;
            // 
            // dialog1
            // 
            dialog1.AutoSize = true;
            dialog1.BackColor = Color.WhiteSmoke;
            dialog1.Font = new Font("맑은 고딕", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
            dialog1.ForeColor = Color.Black;
            dialog1.Location = new Point(145, 473);
            dialog1.Name = "dialog1";
            dialog1.Size = new Size(21, 20);
            dialog1.TabIndex = 6;
            dialog1.Text = "...";
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
            // 
            // bookButton
            // 
            bookButton.BackgroundImage = Properties.Resources.bookB;
            bookButton.FlatAppearance.BorderSize = 0;
            bookButton.FlatStyle = FlatStyle.Flat;
            bookButton.Location = new Point(199, 47);
            bookButton.Name = "bookButton";
            bookButton.Size = new Size(260, 48);
            bookButton.TabIndex = 7;
            bookButton.UseVisualStyleBackColor = true;
            bookButton.Click += this.bookButton_Click;
            // 
            // safebutton
            // 
            safebutton.FlatAppearance.BorderSize = 0;
            safebutton.FlatStyle = FlatStyle.Flat;
            safebutton.Image = Properties.Resources.safe;
            safebutton.Location = new Point(139, 175);
            safebutton.Name = "safebutton";
            safebutton.Size = new Size(134, 270);
            safebutton.TabIndex = 8;
            safebutton.Text = "button2";
            safebutton.UseVisualStyleBackColor = true;
            safebutton.Click += this.safebutton_Click;
            // 
            // Scene5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "Scene5";
            Size = new Size(1262, 679);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dialogBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label dialog1;
        private PictureBox dialogBox;
        private Button bookButton;
        private Button safebutton;
    }
}
