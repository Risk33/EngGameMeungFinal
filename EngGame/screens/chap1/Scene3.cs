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
using System.Xml.Linq;
using WMPLib;
using System.Numerics;

namespace EngGame.screens.chap1
{
    public partial class Scene3 : UserControl
    {
        WindowsMediaPlayer wmp;
        WindowsMediaPlayer Player;
        public Scene3()
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
        private void UpdateDialog() // 대사 넘기기
        {
            num++;
            string[] ss = { };
            try
            {
                ss = dialog[num, 2].Split("/");
                dialog1.Text = dialog[num, 1];
            }
            catch
            {
                hintButton.Visible = true;
                inputBox.Visible = true;
                inputConfirm.Visible = true;
                Console.WriteLine("화면1의 끝입니다.");
            } // 대사가 끝나면 중단


            int returnEventNum;
            for (int i = 0; i < ss.Length; i++)
            {
                returnEventNum = Variable.checkDialog(ss[i]);

                if (returnEventNum == 1) // 대사 창이 따로 필요하다면?
                {
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
                    
                    dialogBox.Visible = false;
                    dialog1.ForeColor = Color.White;
                    dialog1.Location = new Point(491, 265);
                    dialog1.BackColor = Color.Black;
                    dialog1.Font = new Font("맑은 고딕", 20F, FontStyle.Regular, GraphicsUnit.Point, 129);
                    center = true;
                }   // 원래 자리로 돌려놓고 대사창 끄기
                if (returnEventNum == 3)
                {
                    pictureBox2.Visible = true;
                }   // 이미지 띄우기
                if (returnEventNum == 4)
                {
                    nextScreen();
                }   // 이미지 닫기
            }

            if (center == true)
            {
                dialog1.Left = (pictureBox1.Width - dialog1.Width) / 2;
            }
            else
            {
                dialog1.Location = new Point(150, 471);
            }
        }

        private String[,] dialog = new string[,]
            {
                { "","SampleText", "" },
                { "","잠깐..", "dialogBoxOpen/imageOpen" },
                { "","이 문은...", "" },
                { "","어떻게 열어야 하지?", "" },
            }; // 대사 모음, 2차원 배열 각가 캐릭터 이름, 대사, 필요한 이벤트 번호

        private void hintButton_Click(object sender, EventArgs e)
        {
            label1.BringToFront();
            label1.Visible = true;
            dialog1.Text = "살짝 만지자 마자 문이 삐걱 거렸다. 최대한               열어야 할거 같다." +
                "\n(상황에 맞는 영단어를 입력해주세요!)";
        }

        screens.chap1.Scene4 scene4 = new Scene4();
        private void nextScreen()
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(scene4);
            Player.controls.stop();
        }

        private void inputConfirm_Click(object sender, EventArgs e) // 영단어 체크
        {
            label1.Visible = false;
            hintButton.Visible = false;
            inputBox.Visible = false;
            inputConfirm.Visible = false;
            wmp.URL = @"Resources\sound\creaking-wooden-door-loud.mp3";
            wmp.controls.stop();
            String answer = inputBox.Text;
            if (answer.ToLower().Contains("silently"))
            {
                num = 0;
                dialog = new string[,]
                {
                    { "","...", "" },
                    { "","조용하게 들어갈 수 있었다.", "" },
                    { "","...", "imageClose" },
                };
            }
            else
            {
                wmp.controls.play();
                num = 0;
                dialog = new string[,]
                {
                    { "","...", "" },
                    { "","큰소리를 내버렸다... 느낌이 좋지 않다.", "" },
                    { "","...", "imageClose" },
                };

                Variable.NoiseMade();
            }
        }

        private void Scene3_Load(object sender, EventArgs e)
        {
            
            Player = new WindowsMediaPlayer();
            Player.URL = @".\Resources\sound\horror-background-atmosphere-loop.mp3";
            Player.controls.play();
            Console.WriteLine("배경음악재시작");
            wmp = new WindowsMediaPlayer();
        }
    }
}
