namespace projektZH
{
    public partial class Form1 : Form
    {
        public string selectedWord { get; private set; }
        public Form1()
        {
            InitializeComponent();
        }

        Word word;
        public async void Form1_Load(object sender, EventArgs e)
        {
            List<string> words = LoadWordsFromFile();
            if (words.Count > 0)
            {
                Random random = new Random();
                int index = random.Next(0, words.Count);
                selectedWord = words[index];
                word = new Word(selectedWord);
            }
            else
            {
                MessageBox.Show("Nem sikerült betölteni a szavakat a fájlból!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }

            KeyPress += Form1_KeyPress;
        }

        private int wrongGuessCount = 0;

        private async void UpdateWordMaskButtons(string wordMask)
        {
            panel1.Controls.Clear();

            int buttonWidth = 40;
            int buttonHeight = 40;
            int panelWidth = panel1.Width;
            int totalButtonWidth = wordMask.Length * buttonWidth;
            int leftMargin = (panelWidth - totalButtonWidth) / 2;

            for (int i = 0; i < wordMask.Length; i++)
            {
                Button btn = new Button();
                btn.Text = wordMask[i].ToString();
                btn.Width = buttonWidth;
                btn.Height = buttonHeight;
                btn.Left = leftMargin + i * buttonWidth;
                panel1.Controls.Add(btn);
            }

            if (string.Join("", panel1.Controls.OfType<Button>().Select(btn => btn.Text)) == selectedWord)
            {
                label1.Text = "Nyertél!";
                label2.Text = "A játék hamarosan újraindul";
                await Task.Delay(7000);
                RestartGame();
            }
        }

        private async void Form1_KeyPress(object? sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)27)
            {
                DialogResult result = MessageBox.Show("Szeretnél új játékot indítani?", "Új játék", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    RestartGame();
                    return;
                }
            }

            if (wrongGuessCount == 8)
            {
                return;
            }

            if (word.Guess(e.KeyChar))
            {
                UpdateWordMaskButtons(word.WordMask);

            }
            else
            {
                label2.Text = "Nem talált!";
                wrongGuessCount++;
                DrawHangman(wrongGuessCount);
                if (wrongGuessCount == 8)
                {
                    label1.Text = "Vesztettél!";
                    label2.Text = "A játék hamarosan újraindul";
                    await Task.Delay(7000);
                    RestartGame();
                }
                else
                {
                    await Task.Delay(5000);
                    label2.Text = "";
                }
            }

        }

        private void RestartGame()
        {
            wrongGuessCount = 0;
            label1.Text = "Nyomj egy betűt!";
            label2.Text = "";

            Graphics g = this.CreateGraphics();
            g.Clear(this.BackColor);
            List<string> words = LoadWordsFromFile();
            if (words.Count > 0)
            {
                Random random = new Random();
                int index = random.Next(0, words.Count);
                string selectedWord = words[index];
                word = new Word(selectedWord);
            }
            else
            {
                MessageBox.Show("Nem sikerült betölteni a szavakat a fájlból!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }


        }

        private void DrawHangman(int wrongGuessCount)
        {
            Graphics g = this.CreateGraphics();
            g.Clear(this.BackColor);

            switch (wrongGuessCount)
            {
                case 1:
                    g.DrawEllipse(Pens.Black, 380, 125, 40, 40);
                    break;
                case 2:
                    g.DrawEllipse(Pens.Black, 380, 125, 40, 40);
                    g.DrawLine(Pens.Black, 400, 165, 400, 240);
                    break;
                case 3:
                    g.DrawEllipse(Pens.Black, 380, 125, 40, 40);
                    g.DrawLine(Pens.Black, 400, 165, 400, 240);
                    g.DrawLine(Pens.Black, 400, 170, 370, 190);
                    break;
                case 4:
                    g.DrawEllipse(Pens.Black, 380, 125, 40, 40);
                    g.DrawLine(Pens.Black, 400, 165, 400, 240);
                    g.DrawLine(Pens.Black, 400, 170, 370, 190);
                    g.DrawLine(Pens.Black, 400, 170, 430, 190);
                    break;
                case 5:
                    g.DrawEllipse(Pens.Black, 380, 125, 40, 40);
                    g.DrawLine(Pens.Black, 400, 165, 400, 240);
                    g.DrawLine(Pens.Black, 400, 170, 370, 190);
                    g.DrawLine(Pens.Black, 400, 170, 430, 190);
                    g.DrawLine(Pens.Black, 400, 240, 370, 260);
                    break;
                case 6:
                    g.DrawEllipse(Pens.Black, 380, 125, 40, 40);
                    g.DrawLine(Pens.Black, 400, 165, 400, 240);
                    g.DrawLine(Pens.Black, 400, 170, 370, 190);
                    g.DrawLine(Pens.Black, 400, 170, 430, 190);
                    g.DrawLine(Pens.Black, 400, 240, 370, 260);
                    g.DrawLine(Pens.Black, 400, 240, 430, 260);
                    break;
                case 7:
                    g.DrawEllipse(Pens.Black, 380, 125, 40, 40);
                    g.DrawLine(Pens.Black, 400, 165, 400, 240);
                    g.DrawLine(Pens.Black, 400, 170, 370, 190);
                    g.DrawLine(Pens.Black, 400, 170, 430, 190);
                    g.DrawLine(Pens.Black, 400, 240, 370, 260);
                    g.DrawLine(Pens.Black, 400, 240, 430, 260);
                    g.DrawLine(Pens.Red, 390, 135, 395, 145);
                    g.DrawLine(Pens.Red, 390, 145, 395, 135);
                    g.DrawLine(Pens.Red, 410, 135, 405, 145);
                    g.DrawLine(Pens.Red, 410, 145, 405, 135);
                    g.DrawLine(Pens.Red, 390, 155, 410, 155);
                    g.DrawLine(Pens.Black, 375, 170, 420, 170);
                    g.DrawLine(Pens.Black, 375, 170, 375, 0);
                    break;
            }
        }

        private List<string> LoadWordsFromFile()
        {
            List<string> words = new List<string>();

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text Files (*.txt)|*.txt";
            openFileDialog.Title = "Select a Word List File";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    words = File.ReadAllLines(openFileDialog.FileName).ToList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error reading word list file: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return words;
        }




    }
}
