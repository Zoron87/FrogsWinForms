namespace FrogsWinFormsApp
{
    public partial class MainForm : Form
    {
        int stepsCounter = 0;
        int defaultPictureBoxSize = 100;
        int numberFrogs = 4;
        int numberEmptyFrogs = 1;
        int minStepsForWin = 24;
        int numberCellFrogJump = 2;

        string pictureBoxName;
        string manySteps;
        PictureBox currentPictureBox;

        List<PictureBox> frogs = new List<PictureBox>();

        public MainForm()
        {
            InitializeComponent();
        }

        private void PictureBox_Click(object sender, EventArgs e)
        {

            Swap((PictureBox)sender);
        }

        private void Swap(PictureBox clickedPicture)
        {
            var emptyPictureBox = frogs.Where(f => f.Name == "emptyPictureBox").FirstOrDefault();

            var cellNumber = (Math.Abs(emptyPictureBox.Location.X - clickedPicture.Location.X)) / clickedPicture.Size.Width;

            if (cellNumber > numberCellFrogJump)
            {
                MessageBox.Show("Перепрыгивать больше, чем через одну клетку нельзя!");
            }
            else
            {
                var location = clickedPicture.Location;
                clickedPicture.Location = emptyPictureBox.Location;
                emptyPictureBox.Location = location;

                stepsLabel.Text = "Кол-во шагов: " + ++stepsCounter;

                if (CheckWinGame())
                {
                    if (stepsCounter > minStepsForWin)
                        manySteps = "Но это не минимальное количество ходов! \r\nМинимальное равно - 24";

                    MessageBox.Show($"Вы победили за {stepsCounter} шага(ов).\r\n{manySteps}");
                }
            }
        }

        private bool CheckWinGame()
        {
            int leftFrogs = 0, rightFrogs = 0;

            for (int i = 0; i < frogs.Count; i++)
            {
                if (frogs[i].Location.X < numberFrogs * defaultPictureBoxSize && frogs[i].Name == "leftPictureBox")
                {
                    leftFrogs++;
                }

                if (frogs[i].Location.X > (numberFrogs) * defaultPictureBoxSize && frogs[i].Name == "rightPictureBox")
                {
                    rightFrogs++;
                }
            }

            if (leftFrogs == rightFrogs && rightFrogs == numberFrogs)
                return true;

            return false;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 2 * numberFrogs + numberEmptyFrogs; i++)
            {
                currentPictureBox = new PictureBox();

                if (i >= 0)
                {
                    pictureBoxName = "rightPictureBox";
                    currentPictureBox.Image = Properties.Resources.rightFrog;
                }

                if (i == numberFrogs)
                {
                    pictureBoxName = "emptyPictureBox";
                    currentPictureBox.Image = Properties.Resources.empty;
                }

                if (i >= numberFrogs + numberEmptyFrogs)
                {
                    pictureBoxName = "leftPictureBox";
                    currentPictureBox.Image = Properties.Resources.leftFrog;
                }

                int pointX = defaultPictureBoxSize * i;
                currentPictureBox.Location = new Point(pointX, 0);
                currentPictureBox.Name = pictureBoxName;
                currentPictureBox.Size = new Size(100, 100);
                currentPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                currentPictureBox.TabIndex = 0;
                currentPictureBox.TabStop = false;
                currentPictureBox.Click += PictureBox_Click;

                this.Controls.Add(currentPictureBox);

                frogs.Add(currentPictureBox);
            }
        }

        private void RestartGame_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}