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

namespace EngGame.screens.chap1
{
    public partial class Badend2 : UserControl
    {
        public Badend2()
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
            for (int i = 0; i < ss.Length; i++)
            {
                returnEventNum = Variable.checkDialog(ss[i]);

                if (returnEventNum == 1) // 대사 창이 따로 필요하다면?
                {
                    pictureBox2.Visible = false;
                    dialogBox.Visible = true;
                    dialog1.BringToFront();
                    dialog1.ForeColor = Color.White;
                    dialog1.BackColor = Color.Transparent;
                    dialog1.Location = new Point(150, 471);
                    dialog1.Font = new Font("맑은 고딕", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
                    center = false;
                }   // 대사 창 켜고 대사 위치 조정
                if (returnEventNum == 2) // 대사 창이 필요 없다면?
                {
                    dialog1.BringToFront();
                    pictureBox2.Visible = true;
                    dialog1.ForeColor = Color.White;
                    dialog1.Location = new Point(491, 265);
                    dialog1.BackColor = Color.Black;
                    dialog1.Font = new Font("함초롬돋움", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
                    center = true;
                }   // 원래 자리로 돌려놓고 대사창 끄기
                if (returnEventNum == 3)
                {
                }   // 이미지 띄우기
                if (returnEventNum == 4)
                {
                }   // 이미지 닫기

                if (center == true)
                {
                    dialog1.Left = (dialogBox.Width - dialog1.Width) / 2;
                }
                else
                {
                    dialog1.Location = new Point(100, 509);
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
                { "","침입자다!", "dialogBoxClose" },
                { "","밝게 반겨주시던 선생님들이 이곳에서는 무언가에 미쳐있는 사람들로밖에 보이지 않았다.", "dialogBoxOpen" },
                { "","선생님들께 붙잡히고 나는, 영원히 눈을 뜰 수 없었다.", "" },
                { "","배드엔딩3", "dialogBoxClose" },
        }; // 대사 모음, 2차원 배열 각가 캐릭터 이름, 대사, 필요한 이벤트 번호

        private String[,] dialog2 = new string[,]
        {
                { "","SampleText", "" },
                { "","침입자다!", "dialogBoxClose" },
                { "","섬뜩한 복장을 한 선생님들에게 붙잡힌 후 창고로 끌려간 후에야 나는 친구의 모습을 볼 수 있었다.", "dialogBoxOpen" },
                { "","...", "" },
                { "","마지막으로 말이다.", "" },
                { "","배드엔딩2", "dialogBoxClose" },
        }; // 대사 모음, 2차원 배열 각가 캐릭터 이름, 대사, 필요한 이벤트 번호
        private void dialogBox_Click(object sender, EventArgs e)
        {
            UpdateDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            UpdateDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
            UpdateDialog();
        }

        private void Badend2_Load(object sender, EventArgs e)
        {
            if (Variable.Scene4EndTrue())
            {
                dialog = dialog2;
            }
        }
    }
}
