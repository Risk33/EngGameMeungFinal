
using System.Windows.Forms;
using EngGame.screens;
using System.Drawing.Imaging;

namespace EngGame
{

    public partial class Form1 : Form
    {
        private void MakeRoundedButton(Button btn, int radius) // 둥근 버튼을 만드는 함수
        {
            var path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(btn.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(btn.Width - radius, btn.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, btn.Height - radius, radius, radius, 90, 90);
            path.CloseAllFigures();
            btn.Region = new Region(path);
        }

        screens.chap1Main chap1 = new screens.chap1Main();   // screen 폴더의 gameScreen 클래스를 정의
        screens.chap2Main chap2 = new screens.chap2Main();


        public Form1()
        {
            InitializeComponent();

        }

        private void From1_load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle; // 창 테두리 고정 스타일
            this.MaximizeBox = false; // 최대화 버튼 비활성화
            this.MinimizeBox = true;  // 최소화 버튼은 원하면 유지
            this.ControlBox = true;   // 닫기 버튼은 유지

            MakeRoundedButton(questionButton1, 30);
            MakeRoundedButton(questionButton2, 30);

            questionButton1.FlatStyle = FlatStyle.Flat;
            questionButton1.FlatAppearance.BorderSize = 0;
            questionButton2.FlatStyle = FlatStyle.Flat;
            questionButton2.FlatAppearance.BorderSize = 0;

        }
        // 메인 화면 버튼



        private void button1Mid_Click(object sender, EventArgs e)
        {

            panel1.Controls.Clear();
            panel1.Controls.Add(chap1);
            // 화면 전환
        }

        private void button2High_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(chap2);
        }

        private void buttonEnd_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void StyleButtons()
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            StyleButtons();
        }

        private void questionbutton1_Click(object sender, EventArgs e)
        {
            SentenceChap1 sentenceForm1 = new SentenceChap1();
            sentenceForm1.Show();  // 새 창으로 띄움 (비모달)

        }

        private void questionButton2_Click_1(object sender, EventArgs e)
        {
            SentenceChap2 sentenceForm2 = new SentenceChap2();
            sentenceForm2.Show();  // 새 창으로 띄움 (비모달)
        }

        private void backPictureBox_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(chap1);
            // 화면 전환
        }

        private void titlePictureBox_Click(object sender, EventArgs e)
        {

        }

        screens.chap1.Badend2 end2 = new screens.chap1.Badend2();
        private void button1_Click_1(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.BackColor = Color.Black;
            Variable.Scene4End();
            panel1.Controls.Add(end2);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(chap2);
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(chap1);
            // 화면 전환
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
