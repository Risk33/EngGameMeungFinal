using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using EngGame;
using System.Drawing.Text;
using EngGame.screens.chap1;
using System.Resources;

namespace EngGame.screens
{
    public partial class chap1Main : UserControl
    {
        public chap1Main()
        {
            InitializeComponent();
        }
        private void process1_Exited(object sender, EventArgs e)
        {

        }

        private void chap1Main_Load(object sender, EventArgs e)
        {
            dialog1.Left = (chap1.Width - dialog1.Width) / 2;
        }

        int line = 0;
        private void chap1story1_Click(object sender, EventArgs e)
        {
            UpdateDialog();
        }

        private void Dialog1_Click(object sender, EventArgs e)
        {
            UpdateDialog();
        }

        private void dialogBox_Click(object sender, EventArgs e)
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
                nextScreen();
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
                    imgnum++;
                    switch (imgnum)
                    {
                        case 1 :
                                chap1.BackgroundImage = Properties.Resources.배경_학교_복도_낮;
                            break;
                        case 2:
                            chap1.BackgroundImage = Properties.Resources.배경_학교_복도_낮;
                            break;
                        case 3:
                            chap1.BackgroundImage = Properties.Resources.배경_학교_상담실_낮;
                            break;
                    }
                    
                }   // 이미지 띄우기
                if (returnEventNum == 4)
                {
                    chap1.BackgroundImage = null;
                }   // 이미지 닫기
            }




            if (center == true)
            {
                dialog1.Left = (chap1.Width - dialog1.Width) / 2;
            }
            else
            {
                dialog1.Location = new Point(150, 471);
            }
        }
        screens.chap1.Scene1 Scene1 = new screens.chap1.Scene1();
        private void nextScreen()
        {
            chap1.Controls.Clear();
            chap1.BackColor = Color.Black;
            chap1.Controls.Add(Scene1);
            // 화면 전환
        }

        private String[,] dialog = new string[,]
            {
                { "","SampleText", "" },
                { "","2025년 5월 16일, 오늘도 ㅇㅇ이가 학교에 오지 않았다. ", "dialogBoxOpen" },
                { "","ㅇㅇ이가 학교에 안온지 이틀째다. ", "" },
                { "","...","" },
                { "","연락을 해도 보지도 않고... 이런 애가 아닌데... ", "" },
                { "","먼저 화요일에 ㅇㅇ이를 불렀다는 선생님께 여쭤봐야겠다.", "" },
                { "", "...", "soundEffect/WalkingSound.mp3" },
                { "","안녕하세요 선생님, 저 혹시... 화요일에 ㅇㅇ이랑 대화 후에 ㅇㅇ이 어디로 갔는지 아시나요..?","imageOpen" },
                { "","ㅇㅇ이가 그 이후로 연락이 안되어서요...", "" },
                { "수학 선생님","아니. 선생님은 잘 모르겠네... 선생님이랑은 간단히 진로 상담만 해서...","" }
                ,{ "","아아... 넵 알겠습니다...",""}
                ,{ "","그렇게 방과후...","dialogBoxClose/imageClose"}
                ,{ "","...",""}
                ,{ "","교실로 돌아가는 중에 옛 과외 선생님인 ㅁㅁ선생님을 만났다. ",""}
                ,{ "","어 선생님..! 혹시 잠깐 시간 되세요..?","dialogBoxOpen/imageOpen"}
                ,{ "ㅁㅁ 선생님","어 ㅇㅇ아. 왜?",""}
                ,{ "","나는 ㅇㅇ이가 학교에 이틀째 안 오고 연락도 두절된 사실을 선생님께 알렸다","dialogBoxClose/imageClose"}
                ,{ "","화요일 방과후에 진로 상담 때문에 수학 선생님한테 갔거든요... ","dialogBoxOpen/imageOpen"}
                ,{ "","아! 그리고 일주일 전에 ㅇㅇ이가 우리 학교에 괴담이 있다고 조사해 보고 알려준다고 했었는데... ",""}
                ,{ "","그거랑 관련 있는 걸까요..?",""}
                ,{ "ㅁㅁ 선생님","내가 며칠 전에 퇴근하고 놓고 온게 있어서 다시 학교로 갔던 적이 있거든?",""}
                ,{ "ㅁㅁ 선생님"," ...그때. 어딘가에 불이 켜져 있는 거야. 근데 선생님들 목소리가 들리면서 희미하게...",""}
                ,{ "ㅁㅁ 선생님","제물... 그리고 의식.... 뭐 그런 말을 하면서 시간이 얼마 남지 않았다고, 적어도 16일에는 해야 한다고 하더라.",""}
                ,{ "ㅁㅁ 선생님","아무래도 선생님들과 이 학교.",""}
                ,{ "ㅁㅁ 선생님","학생들을 제물로 바치는 사이비 단체인 것 같아.",""}
                ,{ "","저희 그럼 늦기 전에 ㅇㅇ이 찾으러 가봐요! 시간이 얼마 남지 않았어요...! 당장 오늘이에요 선생님..!",""}
                ,{ "ㅁㅁ 선생님","맞아... 그럼 오늘 6시에 너희 반 교실에서 만나자. 그때 만나서 ㅇㅇ이를 찾아보는 거야. 알았지?",""}
                ,{ "","네 선생님..!",""}
                ,{ "","당일 방과후 교실","dialogBoxClose/imageClose"}
                ,{ "","선생님..! 저 왔어요!","dialogBoxOpen"}
                ,{ "ㅁㅁ 선생님","쉿. 누가 오고 있어. 숙여!",""}
                ,{ "","(덜그럭덜그럭 찰칵; 문 잠기는 효과음)","dialogBoxClose/"}
            }; // 대사 모음, 2차원 배열 각가 캐릭터 이름, 대사, 필요한 이벤트 번호


    }
}
