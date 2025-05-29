using EngGame.Properties;
using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using Timer = System.Windows.Forms.Timer;

namespace EngGame.screens
{
    class Variable
    {
        public static int checkDialog(String dialog)
        {
            try
            {
                if (dialog == "dialogBoxOpen")
                {
                    Console.WriteLine("대사 박스 열기");
                    return 1;
                }
                if (dialog == "dialogBoxClose")
                {
                    Console.WriteLine("대사 박스 닫기");
                    return 2;
                }
                if (dialog.Contains("imageOpen"))
                {
                    Console.WriteLine("이미지 오픈");
                    return 3;
                }
                if (dialog.Contains("imageClose"))
                {
                    Console.WriteLine("이미지 ek");
                    return 4;
                }
                if (dialog == "endoftheDialog")
                {
                    return 5;
                }
                return 0;
            }
            catch
            {
                Console.WriteLine("해당 씬의 끝입니다.");
                return 0;
            }
            return 0;
        }
        public static void nextScene()
        {

        }
        public static String returnImage(String imagename)
        {
            if (imagename.Contains("병원"))
            {
                return @"Resources\hospital\배경.새벽 병원_외관.jpg";
            }
            if (imagename.Contains("학교"))
            {
                return "배경.새벽 병원_내부.jpg";
            }
            return "Defaultimg.png";
        }
        // 이벤트 번호 해석




    }

    
}

