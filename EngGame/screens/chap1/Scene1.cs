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
using System.Drawing.Text;
using System.Xml.Linq;
using WMPLib;
using System.Runtime.CompilerServices;

namespace EngGame.screens.chap1
{
    public partial class Scene1 : UserControl
    {
        WindowsMediaPlayer wmp; // 소리 구현
        public Scene1()
        {
            InitializeComponent();
        }

        private void Scene1_Load(object sender, EventArgs e)
        {
            wmp = new WindowsMediaPlayer();
            dialog1.BackColor = Color.FromArgb(255, 193, 198);
            dialog1.Font = new Font("맑은 고딕", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
        }

        private void dialogBox_Click(object sender, EventArgs e)
        {
            UpdateDialog();
        }

        int num;
        bool center = true;
        private void UpdateDialog() // 대사 넘기기
        {
            string[] ss = { };
            num++;
            try
            {
                ss = dialog[num, 2].Split("/");
                dialog1.Text = dialog[num, 1];
                name.Text = dialog[num, 0];
            }
            catch
            {
                Console.WriteLine("화면1의 끝입니다.");
                dialogBox.Visible = false;
                dialog1.Visible = false;
            } // 대사가 끝나면 다음 씬으로


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
                    //dialog1.Location = new Point(150, 471);
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
                }   // 이미지 띄우기
                if (returnEventNum == 4)
                {
                }   // 이미지 닫기
                if (returnEventNum == 5)
                {
                    dialogBox.Visible = false;
                }
                if (returnEventNum == 6)
                {
                    wmp.URL = @".\Resources\sound\doorLocked.mp3";
                    Console.WriteLine(wmp.URL);
                    wmp.controls.play();
                }
                if (returnEventNum == 7)
                {
                    chainButton.Visible = true;
                    timer1.Enabled = true;
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



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private String[,] dialog = new string[,]
            {
                {"","","" },
                { "","선생님... 문이 잠긴 것 같아요....", "dialogBoxOpen" },
                { "","친구가 어떻게 될지 모르는데.. 최대한 빨리 나갈 방법을 찾아보자!", "dialogBoxOpen/timerStart" },
                {"","","endoftheDialog" }
            }; // 대사 모음, 2차원 배열 각가 캐릭터 이름, 대사, 필요한 이벤트 번호

        private void hint_button_Click(object sender, EventArgs e)
        {
            dialog1.Text = "제단...?";
            dialog1.Visible = true;
            dialogBox.Visible = true;
            Back.Visible = true;
            hint.Visible = true;
        }

        private void chainButton_Click(object sender, EventArgs e)
        {
            dialog1.Text = "자물쇠를 풀어야 나갈 수 있을거 같다.";
            dialog1.Visible = true;
            dialogBox.Visible = true;
            panel1.Visible = true;
            Back.Visible = true;
        }

        screens.chap1.Scene2 Scene2 = new screens.chap1.Scene2();
        screens.chap1.Badend1 badend1 = new screens.chap1.Badend1();
        private void nextScreen() // 다음 화면
        {
            panel2.Controls.Clear();
            panel2.Controls.Add(Scene2);
            // 화면 전환
        }

        private void nextScreenBadEnd1() // 배드 엔드 1로
        {
            panel2.Controls.Clear();
            panel2.Controls.Add(badend1);
            // 화면 전환
        }

        private void check_keypad() // 정답 확인
        {
            if (A_checkbox.Checked && A2_checkBox.Checked && L_checkBox.Checked &&
                T_checkBox.Checked && R_checkBox.Checked && W_checkBox.Checked == false &&
                W2_checkBox.Checked == false && V_checkBox.Checked == false && P_checkBox.Checked == false)
            {
                Console.WriteLine("옳은 코드 입력");
                // 분기점 추가 해야함
                if (timer1.Enabled) {
                    Console.WriteLine("시간안에 성공");
                    timer1.Enabled = false;
                    nextScreen();
                }
                else
                {
                    nextScreenBadEnd1();
                }
                wmp.URL = @".\Resources\sound\chainDrop.mp3";
                wmp.controls.play();
            }
        }


        // 아래는 키패드 입력받기
        private void A_CheckedChanged(object sender, EventArgs e)
        {
            Console.WriteLine("[Lock] a pressed");

            if (A_checkbox.Checked)
            {
                A_checkbox.ImageIndex = 1;
                A_checkbox.BackColor = Color.Black;
            }
            else
            {
                A_checkbox.ImageIndex = 0;
            }

            check_keypad(); // 정답인지 확인
        }

        private void L_CheckedChanged(object sender, EventArgs e)
        {
            Console.WriteLine("[Lock] L pressed");

            if (L_checkBox.Checked)
            {
                L_checkBox.ImageIndex = 1;
                L_checkBox.BackColor = Color.Black;
            }
            else
            {
                L_checkBox.ImageIndex = 0;
            }
            check_keypad();
        }

        private void A2_CheckedChanged(object sender, EventArgs e)
        {
            Console.WriteLine("[Lock] A2 pressed");

            if (A2_checkBox.Checked)
            {
                A2_checkBox.ImageIndex = 1;
                A2_checkBox.BackColor = Color.Black;
            }
            else
            {
                A2_checkBox.ImageIndex = 0;
            }
            check_keypad();
        }

        private void T_CheckedChanged(object sender, EventArgs e)
        {
            Console.WriteLine("[Lock] T pressed");

            if (T_checkBox.Checked)
            {
                T_checkBox.ImageIndex = 1;
                T_checkBox.BackColor = Color.Black;
            }
            else
            {
                T_checkBox.ImageIndex = 0;
            }
            check_keypad();
        }

        private void R_CheckedChanged(object sender, EventArgs e)
        {
            Console.WriteLine("[Lock] R pressed");

            if (R_checkBox.Checked)
            {
                R_checkBox.ImageIndex = 1;
                R_checkBox.BackColor = Color.Black;
            }
            else
            {
                R_checkBox.ImageIndex = 0;
            }
            check_keypad();
        }
        private void W_CheckedChanged(object sender, EventArgs e)
        {
            Console.WriteLine("[Lock] W pressed");

            if (W_checkBox.Checked)
            {
                W_checkBox.ImageIndex = 1;
                W_checkBox.BackColor = Color.Black;
            }
            else
            {
                W_checkBox.ImageIndex = 0;
            }
            check_keypad();
        }

        private void W2_CheckedChanged(object sender, EventArgs e)
        {
            Console.WriteLine("[Lock] W2 pressed");

            if (W2_checkBox.Checked)
            {
                W2_checkBox.ImageIndex = 1;
                W2_checkBox.BackColor = Color.Black;
            }
            else
            {
                W2_checkBox.ImageIndex = 0;
            }
            check_keypad();
        }

        private void V_CheckedChanged(object sender, EventArgs e)
        {
            Console.WriteLine("[Lock] V pressed");

            if (V_checkBox.Checked)
            {
                V_checkBox.ImageIndex = 1;
                V_checkBox.BackColor = Color.Black;
            }
            else
            {
                V_checkBox.ImageIndex = 0;
            }
            check_keypad();
        }

        private void P_CheckedChanged(object sender, EventArgs e)
        {
            Console.WriteLine("[Lock] P pressed");

            if (P_checkBox.Checked)
            {
                P_checkBox.ImageIndex = 1;
                P_checkBox.BackColor = Color.Black;
            }
            else
            {
                P_checkBox.ImageIndex = 0;
            }
            check_keypad();
        }

        private void Back_MouseClick(object sender, MouseEventArgs e)
        {
            Back.Visible = false;
            panel1.Visible = false;
            hint.Visible = false;
            dialogBox.Visible = false;
            dialog1.Visible = false;
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
            if(sec < 0)
            {
                minute--;
                sec += 60;
            }
            if (sec == 0 && minute == 0)
            {
                timer1.Enabled = false;
                Console.WriteLine("시간 끝");
                dialog1.Text = "불길한 예감이 든다.";
                dialog1.Visible = true;
                dialogBox.Visible = true;
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
