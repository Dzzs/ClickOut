using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace ClickOut
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            speedSelectBoxes.SetItemChecked(1, true);
        }


        Random RNG = new Random();
        public enum ButtonEnum { button1, button2, button3, button4, button5 };
        bool running = false;
        public int currentScore = 0;
        public int gameSpeed = 15;

        public void GameThreads()
        {
            Thread ButtonPlacementThread = new Thread(new ThreadStart(ButtonMoveInfoThread));
            Thread GameOverCheckerThread = new Thread(new ThreadStart(GameOverCheckThread));

            GameOverCheckerThread.IsBackground = true;
            ButtonPlacementThread.IsBackground = true;

            GameOverCheckerThread.Start();
            ButtonPlacementThread.Start();
        }
        
        private void GameOver()
        {
            Invoke((MethodInvoker)delegate
            {
                scoreLabel.Text = "Score: " + currentScore;
                startButton.BackgroundImage = Properties.Resources.darkSkull;
                SetGameSpeed(500);
                brokenButtonLabel.Show();
                scoreLabel.Show();
                gameOverLabel.Show();
                startLabel.Show();
                speedSelectLabel.Show();
                speedSelectBoxes.Show();
                button1.Hide();
                button2.Hide();
                button3.Hide();
                button4.Hide();
                button5.Hide();
                deathBox.Hide();
                startButton.Text = "Restart";
                startButton.Show();
            });
        }

        private void GameOverCheckThread()
        {
            while (true)
            {                
                if ((button1.Location.X > 520 && button1.Location.X < 715) && (button1.Location.Y > 290 && button1.Location.Y < 410))
                {
                    GameOver();
                }
                if ((button2.Location.X > 520 && button2.Location.X < 715) && (button2.Location.Y > 290 && button2.Location.Y < 410))
                {
                    GameOver();
                }
                if ((button3.Location.X > 520 && button3.Location.X < 715) && (button3.Location.Y > 290 && button3.Location.Y < 410))
                {
                    GameOver();
                }
                if ((button4.Location.X > 520 && button4.Location.X < 715) && (button4.Location.Y > 290 && button4.Location.Y < 410))
                {
                    GameOver();
                }
                if ((button5.Location.X > 520 && button5.Location.X < 715) && (button5.Location.Y > 290 && button5.Location.Y < 410))
                {
                    GameOver();
                }
                
                Thread.Sleep(20);
            }
        }

        private void ButtonMoveThread(int b1, int b11, int b2, int b22, int b3, int b33, int b4, int b44, int b5, int b55, int score)
        {
            Invoke((MethodInvoker)delegate
            {
                button1.Location = new Point(b1, b11);
                button2.Location = new Point(b2, b22);
                button3.Location = new Point(b3, b33);
                button4.Location = new Point(b4, b44);
                button5.Location = new Point(b5, b55);
                Text = "ClickOut  Score: " + score;
            });
        }

        private void ButtonMoveInfoThread()
        {
            int xToMove = 2;
            int yToMove = 1;


            while (true)
            {

                int b1 = button1.Location.X;
                int b11 = button1.Location.Y;
                int b2 = button2.Location.X;
                int b22 = button2.Location.Y;
                int b3 = button3.Location.X;
                int b33 = button3.Location.Y;
                int b4 = button4.Location.X;
                int b44 = button4.Location.Y;
                int b5 = button5.Location.X;
                int b55 = button5.Location.Y;

                int[] buttonXPosArray = { button1.Location.X,
                    button2.Location.X,
                    button3.Location.X,
                    button4.Location.X,
                    button5.Location.X };

                int[] buttonYPosArray = { button1.Location.Y,
                    button2.Location.Y,
                    button3.Location.Y,
                    button4.Location.Y,
                    button5.Location.Y };

                #region X Move
                foreach (int i in buttonXPosArray)
                {
                    if (i < 610)
                    {
                        if (i == button1.Location.X)
                        {
                            b1 = i + xToMove;
                        }
                        else if (i == button2.Location.X)
                        {
                            b2 = i + xToMove;
                        }
                        else if (i == button3.Location.X)
                        {
                            b3 = i + xToMove;
                        }
                        else if (i == button4.Location.X)
                        {
                            b4 = i + xToMove;
                        }
                        else if (i == button5.Location.X)
                        {
                            b5 = i + xToMove;
                        }
                    }
                    else if (i > 610)
                    {
                        if (i == button1.Location.X)
                        {
                            b1 = i - xToMove;
                        }
                        else if (i == button2.Location.X)
                        {
                            b2 = i - xToMove;
                        }
                        else if (i == button3.Location.X)
                        {
                            b3 = i - xToMove;
                        }
                        else if (i == button4.Location.X)
                        {
                            b4 = i - xToMove;
                        }
                        else if (i == button5.Location.X)
                        {
                            b5 = i - xToMove;
                        }
                    }
                    
                }
                #endregion

                #region Y Move
                foreach (int i in buttonYPosArray)
                {
                    if (i < 330)
                    {
                        if (i == button1.Location.Y)
                        {
                            b11 = i + yToMove;
                        }
                        if (i == button2.Location.Y)
                        {
                            b22 = i + yToMove;
                        }
                        if (i == button3.Location.Y)
                        {
                            b33 = i + yToMove;
                        }
                        if (i == button4.Location.Y)
                        {
                            b44 = i + yToMove;
                        }
                        if (i == button5.Location.Y)
                        {
                            b55 = i + yToMove;
                        }
                    }
                    else if (i > 330)
                    {
                        if (i == button1.Location.Y)
                        {
                            b11 = i - yToMove;
                        }
                        if (i == button2.Location.Y)
                        {
                            b22 = i - yToMove;
                        }
                        if (i == button3.Location.Y)
                        {
                            b33 = i - yToMove;
                        }
                        if (i == button4.Location.Y)
                        {
                            b44 = i - yToMove;
                        }
                        if (i == button5.Location.Y)
                        {
                            b55 = i - yToMove;
                        }
                    }
                    
                }
                #endregion

                ButtonMoveThread(b1, b11, b2, b22, b3, b33, b4, b44, b5, b55, currentScore);
                Thread.Sleep(gameSpeed);
            }
        }

        private void ResetButton(ButtonEnum buttonID)
        {
            #region Placement RNG
            int yCheck = RNG.Next(1, 4);
            int xCheck = RNG.Next(1, 4);
            int yPlacement = 0;
            int xPlacement = 0;

            if (yCheck == 1)
            {
                yPlacement = RNG.Next(1, 86);
            }
            else if (yCheck == 2)
            {
                yPlacement = RNG.Next(575, 661);
            }
            else if (yCheck == 3 && xCheck != 3)
            {
                yPlacement = RNG.Next(1,661);
            }
            if (xCheck == 1)
            {
                xPlacement = RNG.Next(1,101);
            }
            else if (xCheck == 2)
            {
                xPlacement = RNG.Next(1050,1201);
            }
            else if (xCheck == 3 && yCheck != 3)
            {
                xPlacement = RNG.Next(1,1201);
            }

            #endregion

            // Ranges Y 1-85, 575-660
            // Ranges X 1-100, 1050-1200

            int colorRNG = RNG.Next(1, 10);

            switch (buttonID)
            {
                case ButtonEnum.button1:
                    button1.Location = new Point(xPlacement, yPlacement);
                    button1.Location = new Point(xPlacement, yPlacement);
                    #region Shit switching
                    switch (colorRNG)
                    {
                        case 1:
                            button1.BackgroundImage = Properties.Resources.blackCat;
                            break;
                        case 2:
                            button1.BackgroundImage = Properties.Resources.blackBat;
                            break;
                        case 3:
                            button1.BackgroundImage = Properties.Resources.blackGhost;
                            break;
                        case 4:
                            button1.BackgroundImage = Properties.Resources.blackJackOLantern;
                            break;
                        case 5:
                            button1.BackgroundImage = Properties.Resources.blackWitch;
                            break;
                        case 6:
                            button1.BackgroundImage = Properties.Resources.blueGhost;
                            break;
                        case 7:
                            button1.BackgroundImage = Properties.Resources.brownBat;
                            break;
                        case 8:
                            button1.BackgroundImage = Properties.Resources.catDrawing;
                            break;
                        case 9:
                            button1.BackgroundImage = Properties.Resources.jackOLantern;
                            break;
                        default:
                            button1.BackgroundImage = Properties.Resources.blueGhost;
                            break;
                    }
                    #endregion
                    break;
                case ButtonEnum.button2:
                    button2.Location = new Point(xPlacement, yPlacement);
                    button2.Location = new Point(xPlacement, yPlacement);
                    #region Shit switching
                    switch (colorRNG)
                    {
                        case 1:
                            button2.BackgroundImage = Properties.Resources.blackBat;
                            break;
                        case 2:
                            button2.BackgroundImage = Properties.Resources.blackCat;
                            break;
                        case 3:
                            button2.BackgroundImage = Properties.Resources.blackGhost;
                            break;
                        case 4:
                            button2.BackgroundImage = Properties.Resources.blackJackOLantern;
                            break;
                        case 5:
                            button2.BackgroundImage = Properties.Resources.blackWitch;
                            break;
                        case 6:
                            button2.BackgroundImage = Properties.Resources.blueGhost;
                            break;
                        case 7:
                            button2.BackgroundImage = Properties.Resources.brownBat;
                            break;
                        case 8:
                            button2.BackgroundImage = Properties.Resources.catDrawing;
                            break;
                        case 9:
                            button2.BackgroundImage = Properties.Resources.jackOLantern;
                            break;
                        default:
                            button2.BackgroundImage = Properties.Resources.blueGhost;
                            break;
                    }
                    #endregion
                    break;
                case ButtonEnum.button3:
                    button3.Location = new Point(xPlacement, yPlacement);
                    button3.Location = new Point(xPlacement, yPlacement);
                    #region Shit switching
                    switch (colorRNG)
                    {
                        case 1:
                            button3.BackgroundImage = Properties.Resources.blackBat;
                            break;
                        case 2:
                            button3.BackgroundImage = Properties.Resources.blackCat;
                            break;
                        case 3:
                            button3.BackgroundImage = Properties.Resources.blackGhost;
                            break;
                        case 4:
                            button3.BackgroundImage = Properties.Resources.blackJackOLantern;
                            break;
                        case 5:
                            button3.BackgroundImage = Properties.Resources.blackWitch;
                            break;
                        case 6:
                            button3.BackgroundImage = Properties.Resources.blueGhost;
                            break;
                        case 7:
                            button3.BackgroundImage = Properties.Resources.brownBat;
                            break;
                        case 8:
                            button3.BackgroundImage = Properties.Resources.catDrawing;
                            break;
                        case 9:
                            button3.BackgroundImage = Properties.Resources.jackOLantern;
                            break;
                        default:
                            button3.BackgroundImage = Properties.Resources.blueGhost;
                            break;
                    }
                    #endregion
                    break;
                case ButtonEnum.button4:
                    button4.Location = new Point(xPlacement, yPlacement);
                    button4.Location = new Point(xPlacement, yPlacement);
                    #region Shit switching
                    switch (colorRNG)
                    {
                        case 1:
                            button4.BackgroundImage = Properties.Resources.blackBat;
                            break;
                        case 2:
                            button4.BackgroundImage = Properties.Resources.blackCat;
                            break;
                        case 3:
                            button4.BackgroundImage = Properties.Resources.blackGhost;
                            break;
                        case 4:
                            button4.BackgroundImage = Properties.Resources.blackJackOLantern;
                            break;
                        case 5:
                            button4.BackgroundImage = Properties.Resources.blackWitch;
                            break;
                        case 6:
                            button4.BackgroundImage = Properties.Resources.blueGhost;
                            break;
                        case 7:
                            button4.BackgroundImage = Properties.Resources.jackOLantern;
                            break;
                        case 8:
                            button4.BackgroundImage = Properties.Resources.brownBat;
                            break;
                        case 9:
                            button4.BackgroundImage = Properties.Resources.catDrawing;
                            break;
                        default:
                            button4.BackgroundImage = Properties.Resources.blueGhost;
                            break;
                    }
                    #endregion
                    break;
                case ButtonEnum.button5:
                    button5.Location = new Point(xPlacement, yPlacement);
                    button5.Location = new Point(xPlacement, yPlacement);
                    #region Shit switching
                    switch (colorRNG)
                    {
                        case 1:
                            button5.BackgroundImage = Properties.Resources.blackBat;
                            break;
                        case 2:
                            button5.BackgroundImage = Properties.Resources.blackCat;
                            break;
                        case 3:
                            button5.BackgroundImage = Properties.Resources.blackGhost;
                            break;
                        case 4:
                            button5.BackgroundImage = Properties.Resources.blackJackOLantern;
                            break;
                        case 5:
                            button5.BackgroundImage = Properties.Resources.blackWitch;
                            break;
                        case 6:
                            button5.BackgroundImage = Properties.Resources.blueGhost;
                            break;
                        case 7:
                            button5.BackgroundImage = Properties.Resources.brownBat;
                            break;
                        case 8:
                            button5.BackgroundImage = Properties.Resources.catDrawing;
                            break;
                        case 9:
                            button5.BackgroundImage = Properties.Resources.jackOLantern;
                            break;
                        default:
                            button5.BackgroundImage = Properties.Resources.blueGhost;
                            break;
                    }
                    #endregion
                    break;
            }

            currentScore++;
        }

        private void button1_MouseDown_1(object sender, MouseEventArgs e)
        {
            button1.Hide();
            ResetButton(ButtonEnum.button1);
        }

        private void button2_MouseDown(object sender, MouseEventArgs e)
        {
            button2.Hide();
            ResetButton(ButtonEnum.button2);
        }

        private void button3_MouseDown(object sender, MouseEventArgs e)
        {
            button3.Hide();
            ResetButton(ButtonEnum.button3);
        }

        private void button4_MouseDown(object sender, MouseEventArgs e)
        {
            button4.Hide();
            ResetButton(ButtonEnum.button4);
        }

        private void button5_MouseDown(object sender, MouseEventArgs e)
        {
            button5.Hide();
            ResetButton(ButtonEnum.button5);
        }

        private void button1_MouseUp(object sender, MouseEventArgs e)
        {
            button1.Show();
            ResetButton(ButtonEnum.button1);
        }

        private void button2_MouseUp(object sender, MouseEventArgs e)
        {
            button2.Show();
            ResetButton(ButtonEnum.button2);
        }

        private void button3_MouseUp(object sender, MouseEventArgs e)
        {
            button3.Show();
            ResetButton(ButtonEnum.button3);
        }

        private void button4_MouseUp(object sender, MouseEventArgs e)
        {
            button4.Show();
            ResetButton(ButtonEnum.button4);
        }

        private void button5_MouseUp(object sender, MouseEventArgs e)
        {
            button5.Show();
            ResetButton(ButtonEnum.button5);
        }

        private void SetGameSpeed(int speed)
        {
            gameSpeed = speed;
        }

        private void ResetGame()
        {
            if (speedSelectBoxes.GetItemChecked(0))
            {
                SetGameSpeed(20);
            }
            else if (speedSelectBoxes.GetItemChecked(1))
            {
                SetGameSpeed(15);
            }
            else if (speedSelectBoxes.GetItemChecked(2))
            {
                SetGameSpeed(10);
            }
            currentScore = 0;
            brokenButtonLabel.Hide();
            gameOverLabel.Hide();
            scoreLabel.Hide();
            startLabel.Hide();
            speedSelectLabel.Hide();
            speedSelectBoxes.Hide();
            deathBox.Show();
            button1.Show();
            button2.Show();
            button3.Show();
            button4.Show();
            button5.Show();
            startButton.Hide();
            if (running != true)
            {
                running = true;
                GameThreads();
            }
        }

        private void ResetAllButtons()
        {
            ResetButton(ButtonEnum.button1);
            ResetButton(ButtonEnum.button2);
            ResetButton(ButtonEnum.button3);
            ResetButton(ButtonEnum.button4);
            ResetButton(ButtonEnum.button5);
        }

        private void startButton_MouseUp(object sender, MouseEventArgs e)
        {
            ResetAllButtons();
            ResetGame();
        }

        private void speedSelectBoxes_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked)
                for (int ix = 0; ix < speedSelectBoxes.Items.Count; ++ix)
                    if (e.Index != ix) speedSelectBoxes.SetItemChecked(ix, false);
        }
    }
}
