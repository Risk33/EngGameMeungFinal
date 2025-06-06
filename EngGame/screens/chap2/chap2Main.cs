﻿using System;
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
using System.Runtime.CompilerServices;
using System.Drawing.Imaging;
using Timer = System.Windows.Forms.Timer;

namespace EngGame.screens
{
    public partial class chap2Main : UserControl
    {
        public chap2Main()
        {
            InitializeComponent();
        }
        private void process1_Exited(object sender, EventArgs e)
        {

        }

        private void chap1Main_Load(object sender, EventArgs e)
        {
            dialog1.Left = (chap1.Width - dialog1.Width) / 2;
            pictureBox1.Left = (chap1.Width - pictureBox1.Width) / 2;
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            UpdateDialog();
        }

        int num = 0;
        bool center = true;
        private void UpdateDialog() // 대사 넘기기
        {
            num++;
            string[] ss = { };
            try
            {
                dialog1.Text = dialog[num, 1];
                name.Text = dialog[num, 0];
                ss = dialog[num, 2].Split("/");
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
                    pictureBox1.Visible = true;
                }   // 이미지 띄우기
                if (returnEventNum == 4)
                {
                    pictureBox1.Visible = false;
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
                { "","...", "" },
                { "만식","네, 전화받았습니다.", "dialogBoxOpen" },
                { "공철","오랜만이네, 동창회 이후로 몇 달 만이지. 다름이 아니라 이번에 ㅁㅁ리에 있는 ㅇㅇ병원 취재를 맡았어. 혹시 아는 거 있어?","" },
                { "만식","거기 완전 외딴 마을 아냐? 뭐 때문에?", "" },
                { "공철","신혼부부가 여행 갔다가 남편이 다쳐서 그 병원에 입원했는데, 퇴원도 안 시켜주고 면회도 안 된다더라. 수상해서 직접 가보려고.", "" },
                { "만식", "조심해라. 이상하면 바로 빠져나오고.", "" },
                { "공철","응. 일 끝나고 연락할게. 한잔하자.","dialogBoxOpen" },
                { "","그렇게 며칠뒤..","dialogBoxClose" }
                ,{ "","[음성 메시지 도착 소리]",""}
                ,{ "공철(녹음된 메시지)","야, 여기 뭔가 이상해... " +
                    "감기 환자처럼 위장하고 진료받았는데, 입원하라고 하더니 물건도 뺏기고 이상한 주사를 놓더라. " +
                    "[신호 끊김]","dialogBoxOpen"}
                ,{ "만식","(무슨 일이 생긴 게 분명해...)",""}
                ,{ "","[그날 바로 병원 앞에서 잠복해 보았지만 아무것도 찾지 못했다.]","dialogBoxClose/imageOpen"}
                ,{ "","[그러면 뭐... 직접 들어가 보는 수밖에 없지]",""}
                ,{ "","(낮에는 아무런 증거를 찾지 못했다. " +
                    "병원은 평범한 것처럼 보였지만… 뭔가 감춰져 있어.)","dialogBoxOpen/imageClose"}
                ,{ "","[병원 복도는 비상등 불빛만 작게 빛나 음산한 분위기를 자아냈다.]",""}
                ,{ "만식","공철... 네가 마지막으로 연락한 그날, 대체 무슨 일이 있었던 거야.",""}
                ,{ "","[이후 난 폐쇄된 병실, 의무 기록서, 의료 장비등을 수색했다.]",""}
                ,{ "만식","이건… 감기 환자 기록이라기엔 이상한 처방 내역인데…",""}
                ,{ "","[원장실 앞]",""}
                ,{ "만식","여긴… 분명히 잠겨 있었는데, 열려 있어?",""}
                ,{ "","[원장실 내부에 들어섬]",""}
                ,{ "만식","뭐야…? 문이 잠겼어?!",""}
                ,{ "","[불이 꺼지고 경고등이 켜짐]",""}
                ,{ "만식","(이 병원, 그냥 이상한 수준이 아니야. 반드시 진실을 밝혀야 해… 그리고 공철을 찾아야 한다.)",""}
                ,{ "만식","...여기서 나가야 해. 그리고 진실을 밝혀야 한다.",""}
            }; // 대사 모음, 2차원 배열 각가 캐릭터 이름, 대사, 필요한 이벤트 번호



        private Timer fadeTimer = new Timer();
        private float opacity = 0f; // 0: 완전 투명, 1: 완전 불투명
        private bool fadeIn = true;
        private Image originalImage;

        private Image SetImageOpacity(Image image, float opacity)
        {
            Bitmap bmp = new Bitmap(image.Width, image.Height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                ColorMatrix matrix = new ColorMatrix();
                matrix.Matrix33 = opacity; // 알파값 설정
                ImageAttributes attributes = new ImageAttributes();
                attributes.SetColorMatrix(matrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);
                g.DrawImage(image, new Rectangle(0, 0, bmp.Width, bmp.Height), 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, attributes);
            }
            return bmp;
        }

        private void FadeTimer_Tick(object sender, EventArgs e)
        {
            if (fadeIn)
            {
                opacity += 0.05f;
                if (opacity >= 1f)
                {
                    opacity = 1f;
                    fadeTimer.Stop();
                }
            }
            else
            {
                opacity -= 0.05f;
                if (opacity <= 0f)
                {
                    opacity = 0f;
                    fadeTimer.Stop();
                }
            }
            pictureBox1.Image = SetImageOpacity(originalImage, opacity);
        }
        private void StartFadeIn()
        {
            fadeIn = true;
            opacity = 0f;
            fadeTimer.Start();
        }

        private void StartFadeOut()
        {
            fadeIn = false;
            opacity = 1f;
            fadeTimer.Start();
        }
    }
}
