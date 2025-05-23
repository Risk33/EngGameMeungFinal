using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EngGame.screens
{



    public partial class SentenceChap1 : Form
    {
        public List<word> Words { get; set; }

        public SentenceChap1()
        {
            Words = new List<word>();
            InitializeComponent();
            LoadWordData(); // 여기에 단어를 추가
        }

        private void LoadWordData()
        {
            var wordData = new (string 단어, string 뜻, string 품사)[]
            {
        // 교육 관련 고급 단어
        ("curriculum", "교육과정", "명사"),
        ("pedagogy", "교육학, 교수법", "명사"),
        ("didactic", "교훈적인, 가르치려는", "형용사"),
        ("syllabus", "강의 계획서, 수업 요강", "명사"),
        ("tuition", "수업료, 등록금", "명사"),
        ("extracurricular", "과외의, 정규 교과 외의", "형용사"),
        ("scholarship", "장학금 / 학문", "명사"),
        ("proficiency", "숙련, 능숙함", "명사"),
        ("remedial", "기초 보충의, 교정의", "형용사"),
        ("assessment", "평가, 시험", "명사"),
        // 학교 환경 및 제도 관련 단어
        ("faculty", "교수진", "명사"),
        ("administration", "행정, 학교 행정부", "명사"),
        ("matriculation", "입학 (특히 대학)", "명사"),
        ("commencement", "졸업식", "명사"),
        ("alumni", "동문, 졸업생들", "명사"),
        ("disciplinary", "징계의, 규율의", "형용사"),
        ("enrollment", "등록, 입학 인원", "명사"),
        ("valedictorian", "졸업생 대표 연설자", "명사"),
        ("dormitory", "기숙사", "명사"),
        ("bursar", "재무 담당자 (학교에서의)", "명사"),
        // 학생과 학습 관련 단어
        ("diligent", "근면한, 성실한", "형용사"),
        ("inquisitive", "호기심 많은, 탐구적인", "형용사"),
        ("articulate", "분명하게 표현하는, 말 잘하는", "형용사"),
        ("analytical", "분석적인", "형용사"),
        ("plagiarism", "표절", "명사"),
        ("collaborative", "협동적인", "형용사"),
        ("intellect", "지적 능력", "명사"),
        ("aptitude", "소질, 적성", "명사"),
        ("attentiveness", "주의 깊음, 집중력", "명사"),
        ("self-discipline", "자기 절제, 자제력", "명사")
            };

            foreach (var (단어, 뜻, 품사) in wordData)
            {
                Words.Add(new word { 단어 = 단어, 뜻 = 뜻, 품사 = 품사 });
            }
        }

        private void Sentence_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = Words;
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
