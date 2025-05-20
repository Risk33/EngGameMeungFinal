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

        private void UpdateDialog()
        {
            int num = 0;
            num++;
            try {
                dialog1.Text = dialog[num];
            }
            catch
            {
                Console.WriteLine("대사의 끝입니다.");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private String[] dialog = new string[3]
           {
               "SampleText",
               "예시 대사2\r\n" +
               "2번째줄 게이밍\r\n" +
               "3번째줄 게이밍",
               "예시 대사3"
           };
    }
}
