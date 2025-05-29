namespace EngGame.screens.chap1
{
    partial class Scene1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Scene1));
            pictureBox1 = new PictureBox();
            dialogBox = new PictureBox();
            dialog1 = new Label();
            name = new Label();
            chainButton = new Button();
            panel1 = new Panel();
            V_checkBox = new CheckBox();
            V = new ImageList(components);
            W2_checkBox = new CheckBox();
            W = new ImageList(components);
            W_checkBox = new CheckBox();
            P_checkBox = new CheckBox();
            P = new ImageList(components);
            R_checkBox = new CheckBox();
            R = new ImageList(components);
            A2_checkBox = new CheckBox();
            imageList1 = new ImageList(components);
            T_checkBox = new CheckBox();
            T = new ImageList(components);
            L_checkBox = new CheckBox();
            L = new ImageList(components);
            A_checkbox = new CheckBox();
            pictureBox2 = new PictureBox();
            Back = new TextBox();
            panel2 = new Panel();
            timer1 = new System.Windows.Forms.Timer(components);
            hint_button = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dialogBox).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.ErrorImage = null;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1262, 679);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // dialogBox
            // 
            dialogBox.BackColor = Color.Transparent;
            dialogBox.BackgroundImage = (Image)resources.GetObject("dialogBox.BackgroundImage");
            dialogBox.Location = new Point(144, 467);
            dialogBox.Name = "dialogBox";
            dialogBox.Size = new Size(981, 193);
            dialogBox.TabIndex = 1;
            dialogBox.TabStop = false;
            dialogBox.Click += dialogBox_Click;
            // 
            // dialog1
            // 
            dialog1.AutoSize = true;
            dialog1.BackColor = Color.WhiteSmoke;
            dialog1.Font = new Font("맑은 고딕", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
            dialog1.ForeColor = Color.Black;
            dialog1.Location = new Point(155, 477);
            dialog1.Name = "dialog1";
            dialog1.Size = new Size(21, 20);
            dialog1.TabIndex = 2;
            dialog1.Text = "...";
            dialog1.Click += label1_Click;
            // 
            // name
            // 
            name.AutoSize = true;
            name.BackColor = Color.White;
            name.Font = new Font("맑은 고딕", 24F, FontStyle.Regular, GraphicsUnit.Point, 129);
            name.ForeColor = Color.Black;
            name.Image = Properties.Resources.cat_reacts;
            name.Location = new Point(143, 416);
            name.Name = "name";
            name.Size = new Size(0, 45);
            name.TabIndex = 6;
            name.Visible = false;
            // 
            // chainButton
            // 
            chainButton.BackgroundImage = Properties.Resources.chain2;
            chainButton.Cursor = Cursors.Hand;
            chainButton.FlatAppearance.BorderSize = 0;
            chainButton.FlatStyle = FlatStyle.Flat;
            chainButton.Location = new Point(111, 155);
            chainButton.Margin = new Padding(0);
            chainButton.Name = "chainButton";
            chainButton.Size = new Size(126, 40);
            chainButton.TabIndex = 7;
            chainButton.UseVisualStyleBackColor = true;
            chainButton.Click += chainButton_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(V_checkBox);
            panel1.Controls.Add(W2_checkBox);
            panel1.Controls.Add(W_checkBox);
            panel1.Controls.Add(P_checkBox);
            panel1.Controls.Add(R_checkBox);
            panel1.Controls.Add(A2_checkBox);
            panel1.Controls.Add(T_checkBox);
            panel1.Controls.Add(L_checkBox);
            panel1.Controls.Add(A_checkbox);
            panel1.Controls.Add(pictureBox2);
            panel1.Location = new Point(459, 6);
            panel1.Name = "panel1";
            panel1.Size = new Size(302, 453);
            panel1.TabIndex = 8;
            panel1.Visible = false;
            // 
            // V_checkBox
            // 
            V_checkBox.Appearance = Appearance.Button;
            V_checkBox.BackColor = Color.Black;
            V_checkBox.BackgroundImageLayout = ImageLayout.None;
            V_checkBox.Cursor = Cursors.Hand;
            V_checkBox.FlatAppearance.BorderColor = Color.Black;
            V_checkBox.FlatAppearance.BorderSize = 0;
            V_checkBox.FlatAppearance.CheckedBackColor = Color.Black;
            V_checkBox.FlatAppearance.MouseDownBackColor = SystemColors.ActiveBorder;
            V_checkBox.FlatAppearance.MouseOverBackColor = SystemColors.ActiveBorder;
            V_checkBox.FlatStyle = FlatStyle.Flat;
            V_checkBox.ImageIndex = 0;
            V_checkBox.ImageList = V;
            V_checkBox.Location = new Point(167, 264);
            V_checkBox.Margin = new Padding(0);
            V_checkBox.Name = "V_checkBox";
            V_checkBox.Size = new Size(25, 27);
            V_checkBox.TabIndex = 9;
            V_checkBox.TabStop = false;
            V_checkBox.TextImageRelation = TextImageRelation.ImageAboveText;
            V_checkBox.UseVisualStyleBackColor = false;
            V_checkBox.CheckedChanged += V_CheckedChanged;
            // 
            // V
            // 
            V.ColorDepth = ColorDepth.Depth32Bit;
            V.ImageStream = (ImageListStreamer)resources.GetObject("V.ImageStream");
            V.TransparentColor = Color.Transparent;
            V.Images.SetKeyName(0, "V.png");
            V.Images.SetKeyName(1, "V_pressed.png");
            // 
            // W2_checkBox
            // 
            W2_checkBox.Appearance = Appearance.Button;
            W2_checkBox.BackColor = Color.Black;
            W2_checkBox.BackgroundImageLayout = ImageLayout.None;
            W2_checkBox.Cursor = Cursors.Hand;
            W2_checkBox.FlatAppearance.BorderColor = Color.Black;
            W2_checkBox.FlatAppearance.BorderSize = 0;
            W2_checkBox.FlatAppearance.CheckedBackColor = Color.Black;
            W2_checkBox.FlatAppearance.MouseDownBackColor = SystemColors.ActiveBorder;
            W2_checkBox.FlatAppearance.MouseOverBackColor = SystemColors.ActiveBorder;
            W2_checkBox.FlatStyle = FlatStyle.Flat;
            W2_checkBox.ImageIndex = 0;
            W2_checkBox.ImageList = W;
            W2_checkBox.Location = new Point(136, 264);
            W2_checkBox.Margin = new Padding(0);
            W2_checkBox.Name = "W2_checkBox";
            W2_checkBox.Size = new Size(25, 27);
            W2_checkBox.TabIndex = 8;
            W2_checkBox.TabStop = false;
            W2_checkBox.TextImageRelation = TextImageRelation.ImageAboveText;
            W2_checkBox.UseVisualStyleBackColor = false;
            W2_checkBox.CheckedChanged += W2_CheckedChanged;
            // 
            // W
            // 
            W.ColorDepth = ColorDepth.Depth32Bit;
            W.ImageStream = (ImageListStreamer)resources.GetObject("W.ImageStream");
            W.TransparentColor = Color.Transparent;
            W.Images.SetKeyName(0, "W.png");
            W.Images.SetKeyName(1, "W_pressed.PNG");
            // 
            // W_checkBox
            // 
            W_checkBox.Appearance = Appearance.Button;
            W_checkBox.BackColor = Color.Black;
            W_checkBox.BackgroundImageLayout = ImageLayout.None;
            W_checkBox.Cursor = Cursors.Hand;
            W_checkBox.FlatAppearance.BorderColor = Color.Black;
            W_checkBox.FlatAppearance.BorderSize = 0;
            W_checkBox.FlatAppearance.CheckedBackColor = Color.Black;
            W_checkBox.FlatAppearance.MouseDownBackColor = SystemColors.ActiveBorder;
            W_checkBox.FlatAppearance.MouseOverBackColor = SystemColors.ActiveBorder;
            W_checkBox.FlatStyle = FlatStyle.Flat;
            W_checkBox.ImageIndex = 0;
            W_checkBox.ImageList = W;
            W_checkBox.Location = new Point(104, 264);
            W_checkBox.Margin = new Padding(0);
            W_checkBox.Name = "W_checkBox";
            W_checkBox.Size = new Size(25, 27);
            W_checkBox.TabIndex = 7;
            W_checkBox.TabStop = false;
            W_checkBox.TextImageRelation = TextImageRelation.ImageAboveText;
            W_checkBox.UseVisualStyleBackColor = false;
            W_checkBox.CheckedChanged += W_CheckedChanged;
            // 
            // P_checkBox
            // 
            P_checkBox.Appearance = Appearance.Button;
            P_checkBox.BackColor = Color.Black;
            P_checkBox.BackgroundImageLayout = ImageLayout.None;
            P_checkBox.Cursor = Cursors.Hand;
            P_checkBox.FlatAppearance.BorderColor = Color.Black;
            P_checkBox.FlatAppearance.BorderSize = 0;
            P_checkBox.FlatAppearance.CheckedBackColor = Color.Black;
            P_checkBox.FlatAppearance.MouseDownBackColor = SystemColors.ActiveBorder;
            P_checkBox.FlatAppearance.MouseOverBackColor = SystemColors.ActiveBorder;
            P_checkBox.FlatStyle = FlatStyle.Flat;
            P_checkBox.ImageIndex = 0;
            P_checkBox.ImageList = P;
            P_checkBox.Location = new Point(166, 233);
            P_checkBox.Margin = new Padding(0);
            P_checkBox.Name = "P_checkBox";
            P_checkBox.Size = new Size(25, 25);
            P_checkBox.TabIndex = 6;
            P_checkBox.TabStop = false;
            P_checkBox.TextImageRelation = TextImageRelation.ImageAboveText;
            P_checkBox.UseVisualStyleBackColor = false;
            P_checkBox.CheckedChanged += P_CheckedChanged;
            // 
            // P
            // 
            P.ColorDepth = ColorDepth.Depth32Bit;
            P.ImageStream = (ImageListStreamer)resources.GetObject("P.ImageStream");
            P.TransparentColor = Color.Transparent;
            P.Images.SetKeyName(0, "P.png");
            P.Images.SetKeyName(1, "P_pressed.PNG");
            // 
            // R_checkBox
            // 
            R_checkBox.Appearance = Appearance.Button;
            R_checkBox.BackColor = Color.Black;
            R_checkBox.BackgroundImageLayout = ImageLayout.None;
            R_checkBox.Cursor = Cursors.Hand;
            R_checkBox.FlatAppearance.BorderColor = Color.Black;
            R_checkBox.FlatAppearance.BorderSize = 0;
            R_checkBox.FlatAppearance.CheckedBackColor = Color.Black;
            R_checkBox.FlatAppearance.MouseDownBackColor = SystemColors.ActiveBorder;
            R_checkBox.FlatAppearance.MouseOverBackColor = SystemColors.ActiveBorder;
            R_checkBox.FlatStyle = FlatStyle.Flat;
            R_checkBox.ImageIndex = 0;
            R_checkBox.ImageList = R;
            R_checkBox.Location = new Point(136, 233);
            R_checkBox.Margin = new Padding(0);
            R_checkBox.Name = "R_checkBox";
            R_checkBox.Size = new Size(25, 27);
            R_checkBox.TabIndex = 5;
            R_checkBox.TabStop = false;
            R_checkBox.TextImageRelation = TextImageRelation.ImageAboveText;
            R_checkBox.UseVisualStyleBackColor = false;
            R_checkBox.CheckedChanged += R_CheckedChanged;
            // 
            // R
            // 
            R.ColorDepth = ColorDepth.Depth32Bit;
            R.ImageStream = (ImageListStreamer)resources.GetObject("R.ImageStream");
            R.TransparentColor = Color.Transparent;
            R.Images.SetKeyName(0, "R.png");
            R.Images.SetKeyName(1, "R_pressed.PNG");
            // 
            // A2_checkBox
            // 
            A2_checkBox.Appearance = Appearance.Button;
            A2_checkBox.BackColor = Color.Black;
            A2_checkBox.BackgroundImageLayout = ImageLayout.None;
            A2_checkBox.Cursor = Cursors.Hand;
            A2_checkBox.FlatAppearance.BorderColor = Color.Black;
            A2_checkBox.FlatAppearance.BorderSize = 0;
            A2_checkBox.FlatAppearance.CheckedBackColor = Color.Black;
            A2_checkBox.FlatAppearance.MouseDownBackColor = SystemColors.ActiveBorder;
            A2_checkBox.FlatAppearance.MouseOverBackColor = SystemColors.ActiveBorder;
            A2_checkBox.FlatStyle = FlatStyle.Flat;
            A2_checkBox.ImageIndex = 0;
            A2_checkBox.ImageList = imageList1;
            A2_checkBox.Location = new Point(104, 233);
            A2_checkBox.Margin = new Padding(0);
            A2_checkBox.Name = "A2_checkBox";
            A2_checkBox.Size = new Size(25, 27);
            A2_checkBox.TabIndex = 4;
            A2_checkBox.TabStop = false;
            A2_checkBox.TextImageRelation = TextImageRelation.ImageAboveText;
            A2_checkBox.UseVisualStyleBackColor = false;
            A2_checkBox.CheckedChanged += A2_CheckedChanged;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Black;
            imageList1.Images.SetKeyName(0, "A.PNG");
            imageList1.Images.SetKeyName(1, "A_pressed.PNG");
            // 
            // T_checkBox
            // 
            T_checkBox.Appearance = Appearance.Button;
            T_checkBox.BackColor = Color.Black;
            T_checkBox.BackgroundImageLayout = ImageLayout.None;
            T_checkBox.Cursor = Cursors.Hand;
            T_checkBox.FlatAppearance.BorderColor = Color.Black;
            T_checkBox.FlatAppearance.BorderSize = 0;
            T_checkBox.FlatAppearance.CheckedBackColor = Color.Black;
            T_checkBox.FlatAppearance.MouseDownBackColor = SystemColors.ActiveBorder;
            T_checkBox.FlatAppearance.MouseOverBackColor = SystemColors.ActiveBorder;
            T_checkBox.FlatStyle = FlatStyle.Flat;
            T_checkBox.ImageIndex = 0;
            T_checkBox.ImageList = T;
            T_checkBox.Location = new Point(165, 202);
            T_checkBox.Margin = new Padding(0);
            T_checkBox.Name = "T_checkBox";
            T_checkBox.Size = new Size(25, 27);
            T_checkBox.TabIndex = 3;
            T_checkBox.TabStop = false;
            T_checkBox.TextImageRelation = TextImageRelation.ImageAboveText;
            T_checkBox.UseVisualStyleBackColor = false;
            T_checkBox.CheckedChanged += T_CheckedChanged;
            // 
            // T
            // 
            T.ColorDepth = ColorDepth.Depth32Bit;
            T.ImageStream = (ImageListStreamer)resources.GetObject("T.ImageStream");
            T.TransparentColor = Color.Transparent;
            T.Images.SetKeyName(0, "T.PNG");
            T.Images.SetKeyName(1, "T_pressed.PNG");
            // 
            // L_checkBox
            // 
            L_checkBox.Appearance = Appearance.Button;
            L_checkBox.BackColor = Color.Black;
            L_checkBox.BackgroundImageLayout = ImageLayout.None;
            L_checkBox.Cursor = Cursors.Hand;
            L_checkBox.FlatAppearance.BorderColor = Color.Black;
            L_checkBox.FlatAppearance.BorderSize = 0;
            L_checkBox.FlatAppearance.CheckedBackColor = Color.Black;
            L_checkBox.FlatAppearance.MouseDownBackColor = SystemColors.ActiveBorder;
            L_checkBox.FlatAppearance.MouseOverBackColor = SystemColors.ActiveBorder;
            L_checkBox.FlatStyle = FlatStyle.Flat;
            L_checkBox.ImageIndex = 0;
            L_checkBox.ImageList = L;
            L_checkBox.Location = new Point(136, 202);
            L_checkBox.Margin = new Padding(0);
            L_checkBox.Name = "L_checkBox";
            L_checkBox.Size = new Size(25, 27);
            L_checkBox.TabIndex = 2;
            L_checkBox.TabStop = false;
            L_checkBox.TextImageRelation = TextImageRelation.ImageAboveText;
            L_checkBox.UseVisualStyleBackColor = false;
            L_checkBox.CheckedChanged += L_CheckedChanged;
            // 
            // L
            // 
            L.ColorDepth = ColorDepth.Depth32Bit;
            L.ImageStream = (ImageListStreamer)resources.GetObject("L.ImageStream");
            L.TransparentColor = Color.Transparent;
            L.Images.SetKeyName(0, "L.PNG");
            L.Images.SetKeyName(1, "L_pressed.PNG");
            // 
            // A_checkbox
            // 
            A_checkbox.Appearance = Appearance.Button;
            A_checkbox.BackColor = Color.Black;
            A_checkbox.BackgroundImageLayout = ImageLayout.None;
            A_checkbox.Cursor = Cursors.Hand;
            A_checkbox.FlatAppearance.BorderColor = Color.Black;
            A_checkbox.FlatAppearance.BorderSize = 0;
            A_checkbox.FlatAppearance.CheckedBackColor = Color.Black;
            A_checkbox.FlatAppearance.MouseDownBackColor = SystemColors.ActiveBorder;
            A_checkbox.FlatAppearance.MouseOverBackColor = SystemColors.ActiveBorder;
            A_checkbox.FlatStyle = FlatStyle.Flat;
            A_checkbox.ImageIndex = 0;
            A_checkbox.ImageList = imageList1;
            A_checkbox.Location = new Point(104, 203);
            A_checkbox.Margin = new Padding(0);
            A_checkbox.Name = "A_checkbox";
            A_checkbox.Size = new Size(25, 27);
            A_checkbox.TabIndex = 1;
            A_checkbox.TabStop = false;
            A_checkbox.TextImageRelation = TextImageRelation.ImageAboveText;
            A_checkbox.UseVisualStyleBackColor = false;
            A_checkbox.CheckedChanged += A_CheckedChanged;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Black;
            pictureBox2.BackgroundImage = Properties.Resources.자물쇠_교실;
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Location = new Point(0, -2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(302, 455);
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // Back
            // 
            Back.BackColor = Color.Silver;
            Back.BorderStyle = BorderStyle.None;
            Back.Cursor = Cursors.Hand;
            Back.Font = new Font("맑은 고딕", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
            Back.Location = new Point(30, 24);
            Back.Name = "Back";
            Back.Size = new Size(78, 26);
            Back.TabIndex = 10;
            Back.Text = "뒤로가기";
            Back.Visible = false;
            Back.MouseClick += Back_MouseClick;
            // 
            // panel2
            // 
            panel2.Controls.Add(dialog1);
            panel2.Controls.Add(dialogBox);
            panel2.Controls.Add(hint_button);
            panel2.Controls.Add(Back);
            panel2.Controls.Add(chainButton);
            panel2.Controls.Add(panel1);
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1262, 679);
            panel2.TabIndex = 11;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            // 
            // hint_button
            // 
            hint_button.BackgroundImage = (Image)resources.GetObject("hint_button.BackgroundImage");
            hint_button.Cursor = Cursors.Hand;
            hint_button.FlatAppearance.BorderSize = 0;
            hint_button.FlatStyle = FlatStyle.Flat;
            hint_button.Location = new Point(342, 525);
            hint_button.Margin = new Padding(0);
            hint_button.Name = "hint_button";
            hint_button.Size = new Size(154, 91);
            hint_button.TabIndex = 11;
            hint_button.UseVisualStyleBackColor = true;
            hint_button.Click += hint_button_Click;
            // 
            // Scene1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(name);
            Controls.Add(panel2);
            Name = "Scene1";
            Size = new Size(1262, 679);
            Load += Scene1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dialogBox).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox dialogBox;
        private Label dialog1;
        private Label name;
        private Button chainButton;
        private Panel panel1;
        private PictureBox pictureBox2;
        private CheckBox A_checkbox;
        private ImageList imageList1;
        private CheckBox L_checkBox;
        private ImageList L;
        private ImageList P;
        private ImageList R;
        private ImageList T;
        private ImageList V;
        private ImageList W;
        private CheckBox T_checkBox;
        private CheckBox P_checkBox;
        private CheckBox R_checkBox;
        private CheckBox A2_checkBox;
        private CheckBox V_checkBox;
        private CheckBox W2_checkBox;
        private CheckBox W_checkBox;
        private TextBox Back;
        private Panel panel2;
        private System.Windows.Forms.Timer timer1;
        private Button hint_button;
    }
}
