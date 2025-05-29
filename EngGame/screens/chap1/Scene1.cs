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

namespace EngGame.screens.chap1
{
    public partial class Scene1 : UserControl
    {
        public Scene1()
        {
            InitializeComponent();
        }

        private void Scene1_Load(object sender, EventArgs e)
        {

        }   

        private void dialogBox_Click(object sender, EventArgs e)
        {
            UpdateDialog();
        }

        int num;
        bool center = true;
        private void UpdateDialog() // 대사 넘기기
        {
            num++;
            try
            {
                dialog1.Text = dialog[num, 1];
                name.Text = dialog[num, 0];
            }
            catch
            {
                Console.WriteLine("화면1의 끝입니다.");
                dialog1.Visible = false;
            } // 대사가 끝나면 다음 씬으로

            string[] ss = dialog[num, 2].Split("/");
            int returnEventNum;
            for (int i = 0; i <= ss.Length; i++)
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
                { "","선생님... 문이 잠긴 것 같아요....", "dialogBoxOpen" },
                {"","","endoftheDialog" }
            }; // 대사 모음, 2차원 배열 각가 캐릭터 이름, 대사, 필요한 이벤트 번호

    }
}
