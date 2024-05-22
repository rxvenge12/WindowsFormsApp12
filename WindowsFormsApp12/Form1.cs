using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void findButton_Click(object sender, EventArgs e)
        {
            string inputText = inputTextBox.Text;
            List<string> maxLengthWords = FindMaxLengthWords(inputText);
            resultLabel.Text = "Слова максимальной длины: " + string.Join(", ", maxLengthWords);
        }

        private List<string> FindMaxLengthWords(string input)
        {
          
            string[] words = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            int maxLength = words.Max(word => word.Length);

            List<string> maxLengthWords = words.Where(word => word.Length == maxLength).ToList();

            return maxLengthWords;
        }
    }
}
