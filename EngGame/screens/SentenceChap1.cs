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
        ("apple", "사과", "명사"),
        ("run", "달리다", "동사"),
        ("beautiful", "아름다운", "형용사"),
        ("quickly", "빠르게", "부사"),
        ("think", "생각하다", "동사"),
        ("이거", "새로", "추가")
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
