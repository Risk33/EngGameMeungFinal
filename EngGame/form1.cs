
using EngGame.screens;
using System.Drawing.Imaging;
using System.Windows.Forms;
using WMPLib;

namespace EngGame
{

    public partial class Form1 : Form
    {
        WindowsMediaPlayer Player;

        private void MakeRoundedButton(Button btn, int radius) // �ձ� ��ư�� ����� �Լ�
        {
            var path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(btn.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(btn.Width - radius, btn.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, btn.Height - radius, radius, radius, 90, 90);
            path.CloseAllFigures();
            btn.Region = new Region(path);
        }

        screens.chap1Main chap1 = new screens.chap1Main();   // screen ������ gameScreen Ŭ������ ����
        screens.chap2Main chap2 = new screens.chap2Main();


        public Form1()
        {
            InitializeComponent();
            Player = new WindowsMediaPlayer();

            this.FormBorderStyle = FormBorderStyle.FixedSingle; // â �׵θ� ���� ��Ÿ��
            this.MaximizeBox = false; // �ִ�ȭ ��ư ��Ȱ��ȭ
            this.MinimizeBox = true;  // �ּ�ȭ ��ư�� ���ϸ� ����
            this.ControlBox = true;   // �ݱ� ��ư�� ����

            MakeRoundedButton(questionButton1, 30);
            MakeRoundedButton(questionButton2, 30);
            
            questionButton1.FlatStyle = FlatStyle.Flat;
        }
        // ���� ȭ�� ��ư
        private void Form1_load(object sender,EventArgs e)
        {
            Player.URL = @".\Resources\sound\MainScreenBGM.mp3";
            Console.WriteLine("������ǽ���");
        }

        private void questionbutton1_Click(object sender, EventArgs e)
        {
            SentenceChap1 sentenceForm1 = new SentenceChap1();
            sentenceForm1.Show();  // �� â���� ��� (����)

        }

        private void questionButton2_Click_1(object sender, EventArgs e)
        {
            SentenceChap2 sentenceForm2 = new SentenceChap2();
            sentenceForm2.Show();  // �� â���� ��� (����)
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Player.controls.stop();
            panel1.Controls.Clear();
            panel1.Controls.Add(chap1);
            // ȭ�� ��ȯ
        }


        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Player.controls.stop();
            panel1.Controls.Clear();
            panel1.Controls.Add(chap2);
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            Player.controls.stop();
            panel1.Controls.Clear();
            panel1.Controls.Add(chap1);
            // ȭ�� ��ȯ
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
