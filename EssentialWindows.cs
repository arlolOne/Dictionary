/* НЕКОТОРЫЕ ПОЛЕЗНЫЕ РЕАЛИЗАЦИИ (ОСОБЕННОСТИ)
1. Выдача случайных неповторяющихся чисел в диапазоне: GetRandomNum();
2. Задержка выполнения операторов в коде: ErrorColor();
*/

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Timers;
using System.Windows.Forms;
using Timer = System.Timers.Timer;

namespace Dictionary
{
    public partial class EssentialWindows : Form
    {
        private readonly List<Word> words;
        private readonly int mode;

        private int id;
        private int increment;

        private Color initialColor;
        private Timer timerForColor;
        private bool expressionMode;

        private List<(int index, int increment)> skipedItems;
        private List<int> indexList;
        private Random randomNum;

        private int maxIndex;
        private int errorCounter;
        private int quantityWords;

        public EssentialWindows(List<Word> words, int mode)
        {
            this.words = words;
            this.mode = mode;

            InitializeComponent();
            InitializeData();
            Testing();
        }

        private void InitializeData()
        {
            ActiveControl = answer;
            initialColor = answer.BackColor;
            maxIndex = words.Count - 1;

            skipedItems = new List<(int index, int increment)>();
            indexList = new List<int>();
            randomNum = new Random();

            for (int i = 0; i < words.Count; i++)
            {
                indexList.Add(i);
            }

            quantityWords = words.Count;
        }

        private void accept_Click(object sender, EventArgs e)
        {
            if (mode == 0)
                expressionMode = answer.Text == words[id].RussianWord;
            else
                expressionMode = answer.Text == words[id].ForeignWord;

            if (expressionMode)
            {
                if (increment != quantityWords)
                    Testing();
                else
                    LastTesting();
            }
            else
                ErrorColor();
        }

        private void skip_Click(object sender, EventArgs e)
        {
            skipedItems.Add((id, increment));

            if (increment != quantityWords)
                Testing();
            else
                LastTesting();
        }

        private void Testing()
        {
            GetRandomNum(ref id);

            increment++;
            wordNum.Text = increment.ToString();

            if (mode == 0)
                currentWord.Text = words[id].ForeignWord;
            else
                currentWord.Text = words[id].RussianWord;

            answer.Text = "";
        }

        private void LastTesting()
        {
            if (!expressionMode)
                ErrorColor();

            if (indexList.Count == 0 && skipedItems.Count != 0)
                ReplaceIndexes();
            else if (skipedItems.Count == 0 && indexList.Count == 0)
                EndingTest();
        }

        private void ErrorColor()
        {
            answer.BackColor = Color.FromArgb(255, 192, 192);
            timerForColor = new Timer(400);
            timerForColor.Elapsed += new ElapsedEventHandler(ReturnColor);
            timerForColor.Start();
            errorCounter++;
        }
        
        private void ReturnColor(Object source, ElapsedEventArgs e)
        {
            answer.BackColor = initialColor;
            timerForColor.Dispose();
        }

        private void GetRandomNum(ref int id) 
        {
            int currentIndex = randomNum.Next(0, maxIndex);
            id = indexList[currentIndex];
            indexList.RemoveAt(currentIndex);
            maxIndex--;
        }

        private void ReplaceIndexes()
        {
            MessageBox.Show($"А теперь ответьте на пропущенные слова: {skipedItems.Count}");

            increment = 0;
            maxIndex = skipedItems.Count - 1;
            indexList.Clear();

            for (int i = 0; i < skipedItems.Count; i++)
            {
                indexList.Add(skipedItems[i].index);
            }

            quantityWords = indexList.Count; 
            skipedItems.Clear();
            Testing();
        }

        private void EndingTest()
        {
            Close();
            MessageBox.Show($"Тестирование окончено! \n Количество неверных попыток: {errorCounter}");
        }

        private void close_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
