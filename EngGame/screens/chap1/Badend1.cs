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

namespace EngGame.screens.chap1
{
    public partial class Badend1 : UserControl
    {
        WindowsMediaPlayer wmp; // 소리 구현
        public Badend1()
        {
            InitializeComponent();
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
                    dialog1.Visible = true;
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
                    pictureBox1.Visible = true;
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
                { "","너무 늦어 버린 것일까?...", "dialogBoxOpen/imageOpen" },
                { "","붉은 빛이 비쳐나오는 입구 틈에서는,", "" },
                { "","알수 없는 언어들과","" },
                { "","익숙한 사람의 비명소리만 들릴뿐이였다.", "" },
                { "","", "dialogBoxClose" },
                { "","Game Over", "dialogBoxClose" },
            }; // 대사 모음, 2차원 배열 각가 캐릭터 이름, 대사, 필요한 이벤트 번호

        private void Badend1_Load(object sender, EventArgs e)
        {
            wmp = new WindowsMediaPlayer();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            UpdateDialog();
        }
    }
}
