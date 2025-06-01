using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
using EngGame.Properties;
using WMPLib;
using System.Media;
using System.Numerics;

namespace EngGame.screens.chap1
{
    public partial class Scene2 : UserControl
    {
        WindowsMediaPlayer wmp; // 소리 구현
        WindowsMediaPlayer Player;
        public Scene2()
        {
            InitializeComponent();
        }

        private void Dialog1_Click(object sender, EventArgs e)
        {
            UpdateDialog();
        }

        private void dialogBox_Click(object sender, EventArgs e)
        {
            UpdateDialog();
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            UpdateDialog();
        }

        int num;
        bool center = true;
        int imgnum = 0;
        private void UpdateDialog() // 대사 넘기기
        {
            num++;
            string[] ss = { };
            try
            {
                ss = dialog[num, 2].Split("/");
                dialog1.Text = dialog[num, 1];
                name.Text = dialog[num, 0];
            }
            catch
            {
                Console.WriteLine("화면1의 끝입니다.");
            } // 대사가 끝나면 중단


            int returnEventNum;
            for (int i = 0; i < ss.Length; i++)
            {
                returnEventNum = Variable.checkDialog(ss[i]);

                if (returnEventNum == 1) // 대사 창이 따로 필요하다면?
                {
                    name.Visible = true;
                    dialogBox.Visible = true;
                    dialog1.BringToFront();
                    dialog1.ForeColor = Color.Black;
                    dialog1.BackColor = Color.FromArgb(255, 193, 198);
                    dialog1.Location = new Point(150, 471);
                    dialog1.Font = new Font("맑은 고딕", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
                    center = false;
                }   // 대사 창 켜고 대사 위치 조정
                if (returnEventNum == 2) // 대사 창이 필요 없다면?
                {
                    name.Visible = false;
                    dialogBox.Visible = false;
                    dialog1.ForeColor = Color.White;
                    dialog1.Location = new Point(491, 265);
                    dialog1.BackColor = Color.Black;
                    dialog1.Font = new Font("맑은 고딕", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 129);
                    center = true;
                }   // 원래 자리로 돌려놓고 대사창 끄기
                if (returnEventNum == 3)
                {
                    imgnum++;
                    switch (imgnum)
                    {
                        case 1:
                            pictureBox1.Visible = true;
                            enter_button.Visible = true;
                            peek_button.Visible = true;
                            break;
                    }

                }   // 이미지 띄우기
                if (returnEventNum == 4)
                {
                    panel1.BackgroundImage = null;
                }   // 이미지 닫기
            }
        }

        private String[,] dialog = new string[,]
    {
                { "","SampleText", "" },
                { "ㅁㅁ선생님","시간이 얼마 없으니까 바로 선생님들 목소리가 들렸던 지하로 가보자.", "dialogBoxOpen" },
                { "","지하에 도착했다. 어떻게 해야할까?", "imageOpen/eventTempStop" },
    }; // 대사 모음, 2차원 배열 각가 캐릭터 이름, 대사, 필요한 이벤트 번호

        private void peek_button_Click(object sender, EventArgs e)
        {
            wmp.URL = @".\Resources\sound\wood-creek-short.mp3";
            wmp.controls.play();
            pictureBox1.BackgroundImage = Resources.배경_제사실_내부_peek;
            dialog1.Text = "일단은 안전한거 같은데. 친구의 모습은 보이지 않는다." +
                            "\n...손만 대었는데 문이 삐걱거린다..";
            peek_button.Visible = false;
            enter_button.Visible = false;
            back.Visible = true;
        }

        private void back_Click(object sender, EventArgs e)
        {
            pictureBox1.BackgroundImage = Resources.배경_제사실_앞;
            dialog1.Text = "어떻게 할까?";
            peek_button.Visible = true;
            enter_button.Visible = true;
            back.Visible = false;
        }

        screens.chap1.Scene3 scene3 = new Scene3();
        private void nextScreen()
        {      
            panel1.Controls.Clear();
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(scene3);
            Player.controls.stop();
        }

        private void enter_button_Click(object sender, EventArgs e)
        {
            nextScreen();
        }

        private void Scene2_Load(object sender, EventArgs e)
        {
            
            Player = new WindowsMediaPlayer();
            Player.URL = @".\Resources\sound\horror-background-atmosphere.mp3";
            Player.controls.play();
            Console.WriteLine("배경음악시작");
            wmp = new WindowsMediaPlayer();
        }

    }
}
