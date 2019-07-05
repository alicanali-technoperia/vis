using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Snake
{
    public enum DirectionEnum
    {
        Top,
        Right,
        Bot,
        Left
    }

    public partial class SnakeGame : Form
    {
        private int posX;
        private int posY;
        private const int xMax = 59;
        private const int xMin = 0;
        private const int yMax = 49;
        private const int yMin = 0;



        private bool lastKeyProcessed = true;
        private int multiplier = 11;
        private int gamePoint = 0;
        private DirectionEnum direction;
        private Point bait;
        private List<Point> snakePosition = new List<Point>();

        private const Keys top = Keys.Up;
        private const Keys right = Keys.Right;
        private const Keys bot = Keys.Down;
        private const Keys left = Keys.Left;

        public SnakeGame()
        {
            InitializeComponent();
        }

        private void SnakeGame_Load(object sender, EventArgs e)
        {
            speedSelection.SelectedIndex = 2;
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            speedSelection.Enabled = false;
            startButton.Enabled = false;
            setGameSpeed();
            gameTimer.Enabled = true;
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            playGame();
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            gameTimer.Enabled = false;
            startButton.Enabled = true;
            speedSelection.Enabled = true;
            createNewSnake();
            resetVariables();
            createBait();
            drawSnake();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (gameTimer.Enabled && lastKeyProcessed)
            {
                lastKeyProcessed = false;
                determineDirection(keyData);
            }

            pauseGame(keyData);
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void playGame()
        {
            setPositionValues();
            bool isGameEnded = isGameOver();

            if (isGameEnded)
            {
                gameTimer.Enabled = false;
                MessageBox.Show(String.Format("Game Over !\n\nScore: {0}", gamePoint), "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            snakePosition.Insert(0, new Point(posX, posY));
            snakePosition.RemoveAt(snakePosition.Count - 1);

            if (bait.X == posX * multiplier && bait.Y == posY * multiplier)
            {
                eatBait();
            }

            drawSnake();
            lastKeyProcessed = true;
        }

        private void pauseGame(Keys keyData)
        {
            if (keyData == Keys.P)
            {
                gameTimer.Enabled = !gameTimer.Enabled;
            }
        }

        private void setGameSpeed()
        {
            switch (speedSelection.SelectedIndex)
            {
                case 0:
                    gameTimer.Interval = 100;
                    break;
                case 1:
                    gameTimer.Interval = 75;
                    break;
                case 2:
                default:
                    gameTimer.Interval = 50;
                    break;
                case 3:
                    gameTimer.Interval = 40;
                    break;
                case 4:
                    gameTimer.Interval = 25;
                    break;
                case 5:
                    gameTimer.Interval = 10;
                    break;
            }
        }

        private void resetVariables()
        {
            posX = 12;
            posY = 20;
            gamePoint = 0;
            direction = DirectionEnum.Right;
            printStat();
        }

        private void createNewSnake()
        {
            snakePosition.Clear();
            snakePosition.Add(new Point(12, 20));
            snakePosition.Add(new Point(11, 20));
            snakePosition.Add(new Point(10, 20));
            snakePosition.Add(new Point(9, 20));
        }

        private void setPositionValues()
        {
            switch (direction)
            {
                case DirectionEnum.Bot:
                    posY++;
                    break;
                case DirectionEnum.Top:
                    posY--;
                    break;
                case DirectionEnum.Left:
                    posX--;
                    break;
                case DirectionEnum.Right:
                default:
                    posX++;
                    break;
            }
        }

        private bool isGameOver()
        {
            //Check limits
            if (posX > xMax || posX < xMin || posY > yMax || posY < yMin)
            {
                return true;
            }

            //Eat itself
            if (snakePosition.Any(t => t.X == posX && t.Y == posY))
            {
                return true;
            }

            return false;
        }

        private void createBait()
        {
            Random random = new Random(DateTime.Now.TimeOfDay.Milliseconds);
            int x = 0;
            int y = 0;
            bool contains = true;

            while (contains)
            {
                x = random.Next(xMin, xMax + 1) * multiplier;
                y = random.Next(yMin, yMax + 1) * multiplier;
                contains = snakePosition.Any(t => t.X == x && t.Y == y);
            }
            bait = new Point(x, y);
        }

        private void eatBait()
        {
            Point lastPoint = snakePosition[snakePosition.Count - 1];
            snakePosition.Add(new Point(lastPoint.X, lastPoint.Y));
            gamePoint += 10;
            printStat();
            createBait();
        }

        private void printStat()
        {
            scoreLabel.Text = gamePoint.ToString();
            baitLabel.Text = (snakePosition.Count - 4).ToString();
        }

        private void determineDirection(Keys keyData)
        {
            switch (keyData)
            {
                case top:
                    if (direction != DirectionEnum.Bot)
                        direction = DirectionEnum.Top;
                    break;
                case bot:
                    if (direction != DirectionEnum.Top)
                        direction = DirectionEnum.Bot;
                    break;
                case left:
                    if (direction != DirectionEnum.Right)
                        direction = DirectionEnum.Left;
                    break;
                case right:
                default:
                    if (direction != DirectionEnum.Left)
                        direction = DirectionEnum.Right;
                    break;
            }
        }


        private void drawSnake()
        {
            gameArea.Refresh();
            drawPoint(bait.X, bait.Y, false);
            foreach (Point item in snakePosition)
            {
                int xVal = item.X * multiplier;
                int yVal = item.Y * multiplier;
                drawPoint(xVal, yVal);
            }
        }

        private void drawPoint(int x, int y, bool isBlack = true)
        {
            using(Graphics g = this.gameArea.CreateGraphics())
            {
                Color penColor = isBlack ? Color.Black : Color.Red;
                Pen pen = new Pen(penColor, 5);
                g.DrawRectangle(pen, x, y, 5, 5);
                pen.Dispose();
            }
        }
    }
}
