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
        static Boolean noise = false;
        static String leftOverTime = "";
        public static void NoiseMade()
        {
            noise = true;
        }
        public static Boolean IsNoiseMaid()
        {
            return noise;
        }
        public static void timeSet(String time)
        {
            leftOverTime = time;
        }
        public static String timeGet()
        {
            return leftOverTime;
        }
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
                    Console.WriteLine("이미지 닫기");
                    return 4;
                }
                if (dialog == "endoftheDialog")
                {
                    return 5;
                }
                if (dialog == "soundPlay")
                {
                    return 6;
                }
                if (dialog == "timerStart")
                    return 7;
                return 0;
            }
            catch
            {
                Console.WriteLine("해당 씬의 끝입니다.");
                return 0;
            }
            return 0;
        }
        // 이벤트 번호 해석(맞지 않을 수도 있음)




    }

    
}

