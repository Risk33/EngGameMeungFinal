using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngGame.screens
{   
    class Variable
    {
        public static int checkDialog(String[,] dialog, int lineNum)
        {
            try
            {
                if (dialog[lineNum, 2] == "dialogBoxOpen")
                {
                    Console.WriteLine("대사 박스 열기");
                    return 1;
                }
                if (dialog[lineNum, 2] == "dialogBoxClose")
                {
                    Console.WriteLine("대사 박스 닫기");
                    return 2;
                }
                return 0;
            }
            catch
            {
                Console.WriteLine("해당 씬의 끝입니다.");
                return 0;
            }
        }
        // 이벤트 번호 해석
    }
}
