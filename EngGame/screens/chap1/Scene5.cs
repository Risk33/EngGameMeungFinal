using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;
using System.Runtime.CompilerServices;

namespace EngGame.screens.chap1
{
    public partial class Scene5 : UserControl
    {
        WindowsMediaPlayer wmp;
        
        public Scene5()
        {
            InitializeComponent();
            wmp = new WindowsMediaPlayer();
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
                    dialog1.BackColor = Color.FromArgb(255, 193, 198);
                    dialog1.Location = new Point(150, 471);
                    dialog1.Font = new Font("맑은 고딕", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
                    center = false;
                }   // 대사 창 켜고 대사 위치 조정
                if (returnEventNum == 2) // 대사 창이 필요 없다면?
                {
                    dialog1.BringToFront();
                    dialogBox.Visible = false;
                    dialog1.ForeColor = Color.White;
                    dialog1.Location = new Point(491, 265);
                    dialog1.BackColor = Color.Black;
                    dialog1.Font = new Font("맑은 고딕", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 129);
                    center = true;
                }   // 원래 자리로 돌려놓고 대사창 끄기
                if (returnEventNum == 3)
                {
                    openSafePanel.Visible = true;
                    panel2.Visible = false;
                }   // 이미지 띄우기
                if (returnEventNum == 4)
                {
                    nextScreen();
                }   // 이미지 닫기 였던것
                if (returnEventNum == 5)
                {
                    bookButton.Visible = true;
                    dialog1.Visible = false;
                    dialogBox.Visible = false;
                    safebutton.Visible = true;
                    panel1.Visible = true;
                    timer.Visible = true;
                    timer.Text = Variable.timeGet();
                    timer1.Enabled = true;
                    Console.WriteLine("타이머 다시 시작");
                }
            }
        }

        chap1.End end = new chap1.End();
        private void nextScreen()
        {
            chap1.Scene2 scene2 = new Scene2();
            scene2.Player_Stop();
            timer1.Enabled = false;
            panel1.Controls.Clear();
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(end);
        }

        private String[,] dialog = new string[,]
        {
                { "","ㅇㅇ아..! 얼른 수갑을 풀어줘야겠어..!", "" },
                { "","ㅇㅇ아! 일어나!", "" },
                { "","(숨은 쉬는데 반응이 없다...)", "" },
                { "","빨리 ㅇㅇ이의 수갑을 풀고 탈출하자!", "" },
                { "","", "endoftheDialog" },
        }; // 대사 모음, 2차원 배열 각가 캐릭터 이름, 대사, 필요한 이벤트 번호

        private void dialogBox_Click(object sender, EventArgs e)
        {
            UpdateDialog();
        }

        private void bookButton_Click(object sender, EventArgs e)
        {
            num = 0;
            back.Visible = true;
            bookButton.Visible = false;
            safebutton.Visible = false;
            dialog1.Visible = true;
            dialogBox.Visible = true;
            dialog1.Text = "창고를 관리하는 장부 같다.";
            dialog = new string[,]
            {
                { "","", "" },
                { "","\"5월 1일\"" +
                "\n월간 순기 업무로 금고 비밀번호 변경 완료했습니다." +
                "\n비밀번호는 다들 알듯이 \"이번달 의식\" 날짜에다 \"희생 횟수\"입니다.", "" },
                { "","의식 날짜는 당연히 오늘인 5월 16일일 것이고, \"희생 횟수\"는 뭐지?", "" },
            };
        }

        private void safebutton_Click(object sender, EventArgs e)
        {
            wmp.URL = @".\Resources\sound\safe-dial-switch.mp3";
            inputSTOP = false;
            panel2.MouseWheel += VaultPasswordEvent;
            bookButton.Visible = false;
            back.Visible = true;
            panel2.Visible = true;
            pass1.Text = "00";
            pass2.Text = "00";
            num = 0;
            dialog = new string[,]
            {
                { "","금고다! 이 안에 분명히 ㅁㅁ이를 깨우는 약이 들어있을꺼야!", "" },
                { "","비밀번호가 필요한거 같다. 어딘가에 적혀 있지 않을까?", "" },
                { "","마우스 휠으로 입력", "" },
            };
        }
        int vaultNum = 0;
        Boolean inputSTOP = false; //!!!!
        private void VaultPasswordEvent(object sender, MouseEventArgs e)
        {           
            if (inputSTOP == false)
            {
                if (e.Delta > 0)
                {
                    vaultNum++;
                    wmp.controls.play();
                    if (vaultNum > 100)
                    {
                        vaultNum = 0;
                    }
                    if (vaultNum < 10)
                        pass1.Text = "0" + vaultNum;
                    else
                        pass1.Text = "" + vaultNum;
                    Console.WriteLine(vaultNum);
                }
                else if (e.Delta < 0)
                {
                    inputSTOP = true;
                    vaultNum = 0;
                }
            }
            else if (inputSTOP)
            {
                if (e.Delta < 0)
                {
                    vaultNum++;
                    if (vaultNum > 100)
                    {
                        vaultNum = 0;
                    }
                    if (vaultNum < 10)
                        pass2.Text = "0" + vaultNum;
                    else
                        pass2.Text = "" + vaultNum;
                    Console.WriteLine(vaultNum);
                    wmp.controls.play();
                }
                else if (e.Delta > 0)
                {
                    inputSTOP = true;
                    panel2.MouseWheel -= VaultPasswordEvent;
                }
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            vaultNum = 0;
            bookButton.Visible = true;
            panel2.Visible = false;
            safebutton.Visible = true;
            back.Visible = false;
            dialog1.Visible = false;
            dialogBox.Visible = false;
            panel2.MouseWheel -= VaultPasswordEvent;
        }

        private void passSubmit_Click(object sender, EventArgs e)
        {
            if(pass1.Text == "16" && pass2.Text == "13")
            {
                wmp.URL = @".\Resources\sound\금고_open.mp3";
                safebutton.Visible = false;
                afterVault();
            }
            else
            {
                dialogBox.Visible = true;
                dialog1.Visible = true;
                dialog1.Text = "코드를 잘못 입력한거 같다.";
            }
        }

        private void afterVault()
        {
            num = 0;
            dialogBox.Visible = true;
            dialog1.Visible = true;
            dialog1.Text = "이걸 먹이면 될꺼야!";
            dialog = new string[,]
            {
                { "ㅁㅁ 선생님","이걸 먹이면 될꺼야!", "imageOpen" },
                { "","네, 선생님!", "" },
                { "","그렇게 우리는 친구를 깨운후 탈출했다.", "" },
                { "","", "imageClose/dialogBoxClose" }, //헉 만들기 귀찮아서 안쓰는 이벤트 번호 재활용
            };
        }

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
    }
}
