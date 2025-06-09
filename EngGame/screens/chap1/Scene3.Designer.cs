namespace EngGame.screens.chap1
{
    partial class Scene3
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
            panel1 = new Panel();
            label1 = new Label();
            hintButton = new Button();
            inputConfirm = new Button();
            inputBox = new TextBox();
            dialog1 = new Label();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Black;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1262, 679);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += Dialog1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(hintButton);
            panel1.Controls.Add(inputConfirm);
            panel1.Controls.Add(inputBox);
            panel1.Controls.Add(dialog1);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1265, 679);
            panel1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("맑은 고딕", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(400, 509);
            label1.Name = "label1";
            label1.Size = new Size(69, 20);
            label1.TabIndex = 12;
            label1.Text = "조용하게";
            label1.Visible = false;
            // 
            // hintButton
            // 
            hintButton.BackColor = Color.Silver;
            hintButton.FlatStyle = FlatStyle.Flat;
            hintButton.Location = new Point(1048, 623);
            hintButton.Name = "hintButton";
            hintButton.Size = new Size(63, 23);
            hintButton.TabIndex = 10;
            hintButton.Text = "힌트";
            hintButton.UseVisualStyleBackColor = false;
            hintButton.Visible = false;
            hintButton.Click += hintButton_Click;
            // 
            // inputConfirm
            // 
            inputConfirm.BackColor = Color.Silver;
            inputConfirm.FlatStyle = FlatStyle.Flat;
            inputConfirm.ForeColor = Color.Black;
            inputConfirm.Location = new Point(979, 623);
            inputConfirm.Name = "inputConfirm";
            inputConfirm.Size = new Size(61, 23);
            inputConfirm.TabIndex = 9;
            inputConfirm.Text = "확인";
            inputConfirm.UseVisualStyleBackColor = false;
            inputConfirm.Visible = false;
            inputConfirm.Click += inputConfirm_Click;
            // 
            // inputBox
            // 
            inputBox.BackColor = Color.FromArgb(224, 224, 224);
            inputBox.Location = new Point(839, 623);
            inputBox.Name = "inputBox";
            inputBox.Size = new Size(132, 23);
            inputBox.TabIndex = 8;
            inputBox.Visible = false;
            // 
            // dialog1
            // 
            dialog1.Anchor = AnchorStyles.Top;
            dialog1.AutoSize = true;
            dialog1.BackColor = Color.Transparent;
            dialog1.CausesValidation = false;
            dialog1.Font = new Font("함초롬돋움", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
            dialog1.ForeColor = Color.White;
            dialog1.Location = new Point(431, 209);
            dialog1.Name = "dialog1";
            dialog1.Size = new Size(357, 45);
            dialog1.TabIndex = 11;
            dialog1.Text = "문에 가까이 접근했다.";
            dialog1.Click += Dialog1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = Properties.Resources.openthedoor;
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Location = new Point(426, 48);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(377, 377);
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            pictureBox2.Visible = false;
            // 
            // Scene3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "Scene3";
            Size = new Size(1262, 679);
            Load += Scene3_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panel1;
        private PictureBox pictureBox2;
        private TextBox inputBox;
        private Button inputConfirm;
        private Button hintButton;
        private Label dialog1;
        private Label label1;
    }
}
