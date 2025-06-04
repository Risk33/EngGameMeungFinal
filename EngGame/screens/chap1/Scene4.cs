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
using WMPLib;
using System.Numerics;

namespace EngGame.screens.chap1
{
    public partial class Scene4 : UserControl
    {
        WindowsMediaPlayer wmp;
        WindowsMediaPlayer Player;
        public Scene4()
        {
            InitializeComponent();
        }

        private void Scene4_Load(object sender, EventArgs e)
        {
            Player = new WindowsMediaPlayer();
            wmp = new WindowsMediaPlayer();
            Player.URL = @".\Resources\sound\horror-background-atmosphere-loop.mp3";
            Player.controls.play();
            Console.WriteLine("배경음악재시작");
            if (Variable.IsNoiseMaid() == true)
            {
                timer.Text = "3 : 00";
            }
        }

        private void dialogBox_Click(object sender, EventArgs e)
        {
            UpdateDialog();
        }

        private void dialog1_Click(object sender, EventArgs e)
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
                    //pictureBox2.Visible = true;
                }   // 이미지 띄우기
                if (returnEventNum == 4)
                {
                }   // 이미지 닫기
                if (returnEventNum == 5)
                {
                    dialogBox.Visible = false;
                    dialog1.Visible = false;
                }   // 대사창 닫기
                if (returnEventNum == 7)
                {
                    dialog1.Visible = false;
                    dialogBox.Visible = false;
                    doorButton.Visible = true;
                    swordButton.Visible = true;
                    timer1.Enabled = true;
                    panel1.Visible = true;
                    Console.WriteLine("타이머 시작");
                }
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
                { "","", "" },
                { "","주위를 둘러보니 일단은 안전해 보인다.", "dialogBoxOpen/imageOpen" },
                { "","언제 의식이 시작할지 모른다! 빨리 친구를 찾자!", "" },
                { "","", "endoftheDialog/timerStart"},
            }; // 대사 모음, 2차원 배열 각가 캐릭터 이름, 대사, 필요한 이벤트 번호

        private void doorButton_Click(object sender, EventArgs e)
        {
            num = 0;
            dialog1.Visible = true;
            dialogBox.Visible = true;
            doorButton.Visible = false;
            dialog1.Text = "이 뒤에 친구가 있는게 분명하다!";
            dialog = new string[,]
            {
                { "ㅁㅁ 선생님","설마 설마 했는데 학교 지하에 이런곳이 존재하다니...", "" },
                { "","이 주위에 친구가 있는게 분명하다!", "" },
                { "","이 주위에 힌트가 될만한게 있지 않을까?", "" },
                { "","", "endoftheDialog" },
            };
            back.Visible = true;
            doorpanel.Visible = true;
            swordButton.Visible = false;
            panel1.Visible = false;
        } // 문을 누르면?
        private void bookHint_Click(object sender, EventArgs e)
        {
            num = 0;
            wmp.controls.stop();
            wmp.URL = @".\Resources\sounds\paper-turning.mp3";
            wmp.controls.play();
            dialog1.Visible = true;
            dialogBox.Visible = true;
            dialog1.Text = "노트다.";
            dialog = new string[,]
            {
                { "","노트다.", "" },
                { "","...", "" },
                { "","제사장의 일기가 적혀 있는거 같다.", "" },                
                { "","5월 14일" +
                "\n새로운 결함품을 잡아들였다.", "" },
                { "","이번이 벌써 13번째인가..", "" },
                { "","그 분의 말씀은 우리가 태어나기도 전, 오래전부터 이어진 것이니,", "" },
                { "","앞으로도 외부인이 알아내서도, 알려져도 안된다.", "" },
                { "","계속 하나씩 결함을 가진 우리들을 고쳐나가야한다.", "" },
                { "","작은 결함이여 이상을 누리기를", "" },
                { "","...", "" },
                { "","내 친구의 이야기인거 같다. 빨리 찾아야 하는데..", "" },
                { "","", "endoftheDialog" },
            }; // 대사 모음, 2차원 배열 각가 캐릭터 이름, 대사, 필요한 이벤트 번호
        } // 제단 위에 책을 누르면?

        private void back_Click(object sender, EventArgs e)
        {
            back.Visible = false;
            doorpanel.Visible = false;
            alter.Visible = false;
            dialogBox.Visible = false;
            dialog1.Visible = false;
            swordButton.Visible = true;
            panel1.Visible = true;
            doorButton.Visible = true;
        } // 뒤로 가기를 누르면??

        private void swordButton1_Click(object sender, EventArgs e)
        {
            num = 0;
            dialog = new string[,]
            {
                { "","",""},
                { "","제물 의식에 쓰이는 칼인거 같다.", "" },
                { "","너무 무거워서 들수는 없을거 같다.", "" },
                { "","...", "" },
                { "","칼 손잡이에 뭔가 적혀있다.", "" },
                { "","\"결점을 도려 이상으로\"", "" },
                { "","", "endoftheDialog" },
            }; // 대사 모음, 2차원 배열 각가 캐릭터 이름, 대사, 필요한 이벤트 번호
            dialog1.Visible = true;
            dialogBox.Visible = true;
        } // 제단의 칼을 누르면?

        private void swordButton_Click(object sender, EventArgs e)
        {
            dialog1.Text = "제단이다... 무언가 쓸만한 게 있을까?";
            back.Visible = true;
            alter.Visible = true;
            dialog1.Visible = true;
            dialogBox.Visible = true;
            swordButton.Visible = false;
            panel1.Visible = false;
            doorButton.Visible = false;
        } // 제단을 누르면?

        // 아래는 자물쇠 구현
        int num1 = 0;
        int num2 = 0;
        int num3 = 0;
        int num4 = 0;
        int num5 = 0;
        int num6 = 0;
        private void lockbutton1_Click(object sender, EventArgs e)
        {
            num1++;
            if (num1 == 8)
            {
                num1 = 0;
            }
            lockbutton1.ImageIndex = num1;
            answerCheck();
        }

        private void lockbutton2_Click(object sender, EventArgs e)
        {
            num2++;
            if (num2 == 8)
            {
                num2 = 0;
            }
            lockbutton2.ImageIndex = num2;
            answerCheck();
        }

        private void lockbutton3_Click(object sender, EventArgs e)
        {
            num3++;
            if (num3 == 8)
            {
                num3 = 0;
            }
            lockbutton3.ImageIndex = num3;
            answerCheck();
        }

        private void lockbutton4_Click(object sender, EventArgs e)
        {
            num4++;
            if (num4 == 8)
            {
                num4 = 0;
            }
            lockbutton4.ImageIndex = num4;
            answerCheck();
        }

        private void lockbutton5_Click(object sender, EventArgs e)
        {
            num5++;
            if (num5 == 8)
            {
                num5 = 0;
            }
            lockbutton5.ImageIndex = num5;
            answerCheck();
        }

        private void lockbutton6_Click(object sender, EventArgs e)
        {
            num6++;
            if (num6 == 8)
            {
                num6 = 0;
            }
            lockbutton6.ImageIndex = num6;
            answerCheck();
        }
        private void answerCheck()
        {
            if (num1 == 2 && num2 == 3 && num3 == 4 && num4 == 3 && num5 == 1 && num6 == 7)
            {
                Console.WriteLine("옳은 코드입니다.");
                dialog1.Text = "자물쇠를 열었다.";
                nextScreen();
            }
        } // 답 체크
        screens.chap1.Badend2 badend2 = new Badend2();
        screens.chap1.Scene5 scene5 = new Scene5();
        private void nextScreen()
        {
            timer1.Stop();
            Variable.timeSet(timer.Text);
            panel2.Controls.Clear();
            panel2.BackColor = Color.Black;
            panel2.Controls.Add(scene5);
            Player.controls.stop();
        }

        private void nextScreenBad()
        {
            timer1.Stop();
            panel2.Controls.Clear();
            panel2.BackColor = Color.Black;
            panel2.Controls.Add(badend2);
            Variable.Scene4End();
        }

        // 타이머 구현
        String[] time = { };
        int minute = 0;
        int sec = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {

            time = timer.Text.Split(":");
            minute = int.Parse(time[0]);
            sec = int.Parse(time[1]);

            sec--;
            if (sec < 0)
            {
                minute--;
                sec += 60;
            }
            if (sec == 0 && minute == 0)
            {
                timer1.Enabled = false;
                Console.WriteLine("시간 끝");
                wmp.URL = @".\Resources\sound\Running.mp3";
                wmp.controls.play();
                nextScreenBad();
            }
            if (sec < 10)
            {
                timer.Text = minute + " : 0" + sec;
            }
            else
            {
                timer.Text = minute + " : " + sec;
            }
        }

        private void alter_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
