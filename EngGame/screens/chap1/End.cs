using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EngGame.Properties;
using WMPLib;

namespace EngGame.screens.chap1
{
    public partial class End : UserControl
    {
        WindowsMediaPlayer wmp = new WindowsMediaPlayer();
        public End()
        {
            InitializeComponent();
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
            int soundNum = 0;
            for (int i = 0; i < ss.Length; i++)
            {
                returnEventNum = Variable.checkDialog(ss[i]);

                if (returnEventNum == 1) // 대사 창이 따로 필요하다면?
                {
                    dialogBox.Visible = true;
                    dialog1.BringToFront();
                    dialog1.ForeColor = Color.White;
                    dialog1.BackColor = Color.Transparent;
                    dialog1.Location = new Point(150, 471);
                    dialog1.Font = new Font("함초롬돋움", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point, 129);
                    center = false;
                }   // 대사 창 켜고 대사 위치 조정
                if (returnEventNum == 2) // 대사 창이 필요 없다면?
                {
                    dialog1.ForeColor = Color.White;
                    dialog1.Location = new Point(491, 265);
                    dialog1.BackColor = Color.Black;
                    dialog1.Font = new Font("함초롬돋움", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
                    center = true;
                }   // 원래 자리로 돌려놓고 대사창 끄기
                if (returnEventNum == 3)
                {
                    pictureBox1.Visible = true;
                    dialog1.BringToFront();
                }   // 이미지 띄우기
                if (returnEventNum == 4)
                {
                    pictureBox1.Visible = false;
                }   // 이미지 닫기
                if (returnEventNum == 6)
                {
                    soundNum++;
                    switch (soundNum)
                    {
                        case 1:
                            wmp.URL = @".\Resources\sound\lecture_fadein.mp3";
                            wmp.controls.play();
                            break;
                        case 2:
                            wmp.controls.stop();
                            wmp.URL = @".\Resources\sound\lecture_fadeout.mp3";
                            wmp.controls.play();
                            break;
                    }
                } //소리 플래이
            }

            if (center == true)
            {
                dialog1.Left = (panel1.Width - dialog1.Width) / 2;
            }
            else
            {
                dialog1.Location = new Point(150, 471);
            }
        }

        private String[,] dialog = new string[,]
        {
                { "","", "" },
                { "","탈출한 우리들은 바로 경찰에 신고하고, 영훈이를 병원에 대려갔다.", "dialogBoxOpen/imageClose" },
                { "","이후 학교에 경찰이 방문하고, 학교의 교직원들이 통째로 바뀌는 등 많은 일이 있었다.", "" },
                { "","...", "dialogBoxClose/soundPlay/imageOpen" },
                { "","물론 그 일이 있었던 것도 이제는 거의 3달전...", "" },
                { "","학교는 원래의 활기찬 분위기를 되찾았고,", "" },
                { "","제단이 있던 장소는 조사가 모두 끝나 탁구장으로 리모델링을 한다고 한다.", "" },
                { "","창문 밖에서도 뛰고 있는 학생들의 열기가 여기까지 느껴지는듯 하나...", "" },
                { "","그들은 알까? 학교 아래에 그런 장소가 있었다는 걸?", "" },
                { "","...", "" },
                { "","The End", "" },
        }; // 대사 모음, 2차원 배열 각가 캐릭터 이름, 대사, 필요한 이벤트 번호

        private void panel1_Click(object sender, EventArgs e)
        {
            UpdateDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {          
            UpdateDialog();
        }
    }
}
