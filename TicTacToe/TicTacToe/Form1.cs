using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class TicTacToe : Form
    {
        const string xx = "X";
        const string oo = "O";
        bool goesFirst = true;
        Random rand = new Random();

        public TicTacToe()
        {
            InitializeComponent();
        }

        #region Button actions

        /*xoComboBox_SelectedIndexChanged will take a decision from the user who decides to play as "X" or "O".
         *If the user chooses "X", the user goes first.  If the uses chooses "O", the computer goes first.
         *goesFirst is flagged as true or false and used throughout the program.*/
        private void xoComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (xoComboBox.SelectedItem.ToString() == "X" || xoComboBox.SelectedItem.ToString() == "O")
            {
                NewGame();
                xoComboBox.Enabled = false;
                tic00RadioButton.Enabled = true;
                tic01RadioButton.Enabled = true;
                tic02RadioButton.Enabled = true;
                tic10RadioButton.Enabled = true;
                tic11RadioButton.Enabled = true;
                tic12RadioButton.Enabled = true;
                tic20RadioButton.Enabled = true;
                tic21RadioButton.Enabled = true;
                tic22RadioButton.Enabled = true;

                if (xoComboBox.SelectedItem.ToString() == "X")
                    goesFirst = true;
                else if (xoComboBox.SelectedItem.ToString() == "O")
                {
                    goesFirst = false;
                    ComputerPlayerTurn(goesFirst);
                }
            }
        }

        /*tic**RadioButton_CheckedChanged use the result of xoComboBox_SelectedIndexChanged "goesFirst"
         *to determine which letter to fill into the radiobutton's text.  Checks for a winner take place.
         *If none is found with WinnerCheck(), it determines who goes first and marks the appropriate letter.
         *WinnerCheck() takes place again.  If no winner is found, ComputerPlayerTurn() is executed.*/
        private void tic00RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (tic00RadioButton.Checked)
            {
                if (!WinnerCheck())
                {
                    if (goesFirst)
                    {
                        tic00RadioButton.Text = xx;
                        tic00RadioButton.Enabled = false;
                    }
                    else
                    {
                        tic00RadioButton.Text = oo;
                        tic00RadioButton.Enabled = false;
                    }
                    if (!WinnerCheck())
                        ComputerPlayerTurn(goesFirst);
                }
            }
        }

        private void tic01RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (tic01RadioButton.Checked)
            {
                if (!WinnerCheck())
                {
                    if (goesFirst)
                    {
                        tic01RadioButton.Text = xx;
                        tic01RadioButton.Enabled = false;
                    }
                    else
                    {
                        tic01RadioButton.Text = oo;
                        tic01RadioButton.Enabled = false;
                    }
                    if (!WinnerCheck())
                        ComputerPlayerTurn(goesFirst);
                }
            }
        }

        private void tic02RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (tic02RadioButton.Checked)
            {
                if (!WinnerCheck())
                {
                    if (goesFirst)
                    {
                        tic02RadioButton.Text = xx;
                        tic02RadioButton.Enabled = false;
                    }
                    else
                    {
                        tic02RadioButton.Text = oo;
                        tic02RadioButton.Enabled = false;
                    }
                    if (!WinnerCheck())
                        ComputerPlayerTurn(goesFirst);
                }
            }
        }

        private void tic10RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (tic10RadioButton.Checked)
            {
                if (!WinnerCheck())
                {
                    if (goesFirst)
                    {
                        tic10RadioButton.Text = xx;
                        tic10RadioButton.Enabled = false;
                    }
                    else
                    {
                        tic10RadioButton.Text = oo;
                        tic10RadioButton.Enabled = false;
                    }
                    if (!WinnerCheck())
                        ComputerPlayerTurn(goesFirst);
                }
            }
        }

        private void tic11RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (tic11RadioButton.Checked)
            {
                if (!WinnerCheck())
                {
                    if (goesFirst)
                    {
                        tic11RadioButton.Text = xx;
                        tic11RadioButton.Enabled = false;
                    }
                    else
                    {
                        tic11RadioButton.Text = oo;
                        tic11RadioButton.Enabled = false;
                    }
                    if (!WinnerCheck())
                        ComputerPlayerTurn(goesFirst);
                }
            }
        }

        private void tic12RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (tic12RadioButton.Checked)
            {
                if (!WinnerCheck())
                {
                    if (goesFirst)
                    {
                        tic12RadioButton.Text = xx;
                        tic12RadioButton.Enabled = false;
                    }
                    else
                    {
                        tic12RadioButton.Text = oo;
                        tic12RadioButton.Enabled = false;
                    }
                    if (!WinnerCheck())
                        ComputerPlayerTurn(goesFirst);
                }
            }
        }

        private void tic20RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (tic20RadioButton.Checked)
            {
                if (!WinnerCheck())
                {
                    if (goesFirst)
                    {
                        tic20RadioButton.Text = xx;
                        tic20RadioButton.Enabled = false;
                    }
                    else
                    {
                        tic20RadioButton.Text = oo;
                        tic20RadioButton.Enabled = false;
                    }
                    if (!WinnerCheck())
                        ComputerPlayerTurn(goesFirst);
                }
            }
        }

        private void tic21RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (tic21RadioButton.Checked)
            {
                if (!WinnerCheck())
                {
                    if (goesFirst)
                    {
                        tic21RadioButton.Text = xx;
                        tic21RadioButton.Enabled = false;
                    }
                    else
                    {
                        tic21RadioButton.Text = oo;
                        tic21RadioButton.Enabled = false;
                    }
                    if (!WinnerCheck())
                        ComputerPlayerTurn(goesFirst);
                }
            }
        }

        private void tic22RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (tic22RadioButton.Checked)
            {
                if (!WinnerCheck())
                {
                    if (goesFirst)
                    {
                        tic22RadioButton.Text = xx;
                        tic22RadioButton.Enabled = false;
                    }
                    else
                    {
                        tic22RadioButton.Text = oo;
                        tic22RadioButton.Enabled = false;
                    }
                    if (!WinnerCheck())
                        ComputerPlayerTurn(goesFirst);
                }
            }
        }

        /*The new game and reset all menu buttons are simple.  Both reset the board.
         * They differ in that reset all clears the wins, losses and draws counts.*/

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewGame();
        }

        private void resetAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewGame();
            winsTextBox.Text = "0";
            lossesTextBox.Text = "0";
            drawsTextBox.Text = "0";
        }
        #endregion

        #region Computer Player methods
        /*ComputerPlayerTurn() uses randomy generated numbers to pick a location to fill with an "X" or an "O".
         *It also uses goesFirst to determine which letter must be placed in the radiobutton's text.
         *Specifically, it WinnerCheck()'s while entering and exiting the loop.*/
        private void ComputerPlayerTurn(bool goes1st)
        {
            string mark = string.Empty;
            bool isFilled = false;
            ushort x = Rando();
            ushort y = Rando();

            if (goes1st)
                mark = oo;
            else
                mark = xx;

            while (!isFilled && !WinnerCheck())
            {
                if (x == 0 && y == 0)
                {
                    if (tic00RadioButton.Text == string.Empty)
                    {
                        tic00RadioButton.Text = mark;
                        isFilled = true;
                        tic00RadioButton.Enabled = false;
                    }
                    else
                    {
                        x = Rando();
                        y = Rando();
                    }
                }
                else if (x == 0 && y == 1)
                {
                    if(tic01RadioButton.Text == string.Empty)
                    {
                        tic01RadioButton.Text = mark;
                        isFilled = true;
                        tic01RadioButton.Enabled = false;
                    }
                    else
                    {
                        x = Rando();
                        y = Rando();
                    }
                }
                else if (x == 0 && y == 2)
                {
                    if (tic02RadioButton.Text == string.Empty)
                    {
                        tic02RadioButton.Text = mark;
                        isFilled = true;
                        tic02RadioButton.Enabled = false;
                    }
                    else
                    {
                        x = Rando();
                        y = Rando();
                    }
                }
                else if (x == 1 && y == 0)
                {
                    if (tic10RadioButton.Text == string.Empty)
                    {
                        tic10RadioButton.Text = mark;
                        isFilled = true;
                        tic10RadioButton.Enabled = false;
                    }
                    else
                    {
                        x = Rando();
                        y = Rando();
                    }
                }
                else if (x == 1 && y == 1)
                {
                    if (tic11RadioButton.Text == string.Empty)
                    {
                        tic11RadioButton.Text = mark;
                        isFilled = true;
                        tic11RadioButton.Enabled = false;
                    }
                    else
                    {
                        x = Rando();
                        y = Rando();
                    }
                }
                else if (x == 1 && y == 2)
                {
                    if (tic12RadioButton.Text == string.Empty)
                    {
                        tic12RadioButton.Text = mark;
                        isFilled = true;
                        tic12RadioButton.Enabled = false;
                    }
                    else
                    {
                        x = Rando();
                        y = Rando();
                    }
                }
                else if (x == 2 && y == 0)
                {
                    if (tic20RadioButton.Text == string.Empty)
                    {
                        tic20RadioButton.Text = mark;
                        isFilled = true;
                        tic20RadioButton.Enabled = false;
                    }
                    else
                    {
                        x = Rando();
                        y = Rando();
                    }
                }
                else if (x == 2 && y == 1)
                {
                    if (tic21RadioButton.Text == string.Empty)
                    {
                        tic21RadioButton.Text = mark;
                        isFilled = true;
                        tic21RadioButton.Enabled = false;
                    }
                    else
                    {
                        x = Rando();
                        y = Rando();
                    }
                }
                else if (x == 2 && y == 2)
                {
                    if (tic22RadioButton.Text == string.Empty)
                    {
                        tic22RadioButton.Text = mark;
                        isFilled = true;
                        tic22RadioButton.Enabled = false;
                    }
                    else
                    {
                        x = Rando();
                        y = Rando();
                    }
                }
            }
            isFilled = WinnerCheck();
        }

        private ushort Rando()
        {
            return (ushort)rand.Next(0, 3);
        }
        #endregion

        #region Check for Winner method

        /*There are only 8 ways to win in Tic Tac Toe.  Each one needed to be programmed individually.  They're all 
         *basically identical, but there is a section to catch draws too.  It uses goesFirst to determine which letter should be marked
         *and who wins (or loses) accordingly. If a win, loss or draw is detected, the rest of the radio buttons are disabled.*/
        private bool WinnerCheck()
        {
            bool winLoseOrDraw = false;
            if ((tic00RadioButton.Text == xx && tic01RadioButton.Text == xx && tic02RadioButton.Text == xx)
                || (tic00RadioButton.Text == oo && tic01RadioButton.Text == oo && tic02RadioButton.Text == oo))
            {
                if (goesFirst)
                {
                    if (tic00RadioButton.Text == xx && tic01RadioButton.Text == xx && tic02RadioButton.Text == xx)
                    {
                        winsTextBox.Text = (uint.Parse(winsTextBox.Text) + 1).ToString();
                        winLoseOrDraw = true;
                    }
                    else if (tic00RadioButton.Text == oo && tic01RadioButton.Text == oo && tic02RadioButton.Text == oo)
                    {
                        lossesTextBox.Text = (uint.Parse(lossesTextBox.Text) + 1).ToString();
                        winLoseOrDraw = true;
                    }
                }
                else
                {
                    if (tic00RadioButton.Text == oo && tic01RadioButton.Text == oo && tic02RadioButton.Text == oo)
                    {
                        winsTextBox.Text = (uint.Parse(winsTextBox.Text) + 1).ToString();
                        winLoseOrDraw = true;
                    }
                    else if (tic00RadioButton.Text == xx && tic01RadioButton.Text == xx && tic02RadioButton.Text == xx)
                    {
                        lossesTextBox.Text = (uint.Parse(lossesTextBox.Text) + 1).ToString();
                        winLoseOrDraw = true;
                    }
                }
                
            }
            else if ((tic10RadioButton.Text == xx && tic11RadioButton.Text == xx && tic12RadioButton.Text == xx)
                    || (tic10RadioButton.Text == oo && tic11RadioButton.Text == oo && tic12RadioButton.Text == oo))
            {
                if (goesFirst)
                {
                    if (tic10RadioButton.Text == xx && tic11RadioButton.Text == xx && tic12RadioButton.Text == xx)
                    {
                        winsTextBox.Text = (uint.Parse(winsTextBox.Text) + 1).ToString();
                        winLoseOrDraw = true;
                    }
                    else if (tic10RadioButton.Text == oo && tic11RadioButton.Text == oo && tic12RadioButton.Text == oo)
                    {
                        lossesTextBox.Text = (uint.Parse(lossesTextBox.Text) + 1).ToString();
                        winLoseOrDraw = true;
                    }
                }
                else
                {
                    if (tic10RadioButton.Text == oo && tic11RadioButton.Text == oo && tic12RadioButton.Text == oo)
                    {
                        winsTextBox.Text = (uint.Parse(winsTextBox.Text) + 1).ToString();
                        winLoseOrDraw = true;
                    }
                    else if (tic10RadioButton.Text == xx && tic11RadioButton.Text == xx && tic12RadioButton.Text == xx)
                    {
                        lossesTextBox.Text = (uint.Parse(lossesTextBox.Text) + 1).ToString();
                        winLoseOrDraw = true;
                    }
                }
            }
            else if ((tic20RadioButton.Text == xx && tic21RadioButton.Text == xx && tic22RadioButton.Text == xx)
                    || (tic20RadioButton.Text == oo && tic21RadioButton.Text == oo && tic22RadioButton.Text == oo))
            {
                if (goesFirst)
                {
                    if (tic20RadioButton.Text == xx && tic21RadioButton.Text == xx && tic22RadioButton.Text == xx)
                    {
                        winsTextBox.Text = (uint.Parse(winsTextBox.Text) + 1).ToString();
                        winLoseOrDraw = true;
                    }
                    else if (tic20RadioButton.Text == oo && tic21RadioButton.Text == oo && tic22RadioButton.Text == oo)
                    {
                        lossesTextBox.Text = (uint.Parse(lossesTextBox.Text) + 1).ToString();
                        winLoseOrDraw = true;
                    }
                }
                else
                {
                    if (tic20RadioButton.Text == oo && tic21RadioButton.Text == oo && tic22RadioButton.Text == oo)
                    {
                        winsTextBox.Text = (uint.Parse(winsTextBox.Text) + 1).ToString();
                        winLoseOrDraw = true;
                    }
                    else if (tic20RadioButton.Text == xx && tic21RadioButton.Text == xx && tic22RadioButton.Text == xx)
                    {
                        lossesTextBox.Text = (uint.Parse(lossesTextBox.Text) + 1).ToString();
                        winLoseOrDraw = true;
                    }
                }
            }
            else if ((tic20RadioButton.Text == xx && tic10RadioButton.Text == xx && tic00RadioButton.Text == xx)
                    || (tic20RadioButton.Text == oo && tic10RadioButton.Text == oo && tic00RadioButton.Text == oo))
            {
                if (goesFirst)
                {
                    if (tic20RadioButton.Text == xx && tic10RadioButton.Text == xx && tic00RadioButton.Text == xx)
                    {
                        winsTextBox.Text = (uint.Parse(winsTextBox.Text) + 1).ToString();
                        winLoseOrDraw = true;
                    }
                    else if (tic20RadioButton.Text == oo && tic10RadioButton.Text == oo && tic00RadioButton.Text == oo)
                    {
                        lossesTextBox.Text = (uint.Parse(lossesTextBox.Text) + 1).ToString();
                        winLoseOrDraw = true;
                    }
                }
                else
                {
                    if (tic20RadioButton.Text == oo && tic10RadioButton.Text == oo && tic00RadioButton.Text == oo)
                    {
                        winsTextBox.Text = (uint.Parse(winsTextBox.Text) + 1).ToString();
                        winLoseOrDraw = true;
                    }
                    else if (tic20RadioButton.Text == xx && tic10RadioButton.Text == xx && tic00RadioButton.Text == xx)
                    {
                        lossesTextBox.Text = (uint.Parse(lossesTextBox.Text) + 1).ToString();
                        winLoseOrDraw = true;
                    }
                }
            }
            else if ((tic21RadioButton.Text == xx && tic11RadioButton.Text == xx && tic01RadioButton.Text == xx)
                    || (tic21RadioButton.Text == oo && tic11RadioButton.Text == oo && tic01RadioButton.Text == oo))
            {
                if (goesFirst)
                {
                    if (tic21RadioButton.Text == xx && tic11RadioButton.Text == xx && tic01RadioButton.Text == xx)
                    {
                        winsTextBox.Text = (uint.Parse(winsTextBox.Text) + 1).ToString();
                        winLoseOrDraw = true;
                    }
                    else if (tic21RadioButton.Text == oo && tic11RadioButton.Text == oo && tic01RadioButton.Text == oo)
                    {
                        lossesTextBox.Text = (uint.Parse(lossesTextBox.Text) + 1).ToString();
                        winLoseOrDraw = true;
                    }
                }
                else
                {
                    if (tic21RadioButton.Text == oo && tic11RadioButton.Text == oo && tic01RadioButton.Text == oo)
                    {
                        winsTextBox.Text = (uint.Parse(winsTextBox.Text) + 1).ToString();
                        winLoseOrDraw = true;
                    }
                    else if (tic21RadioButton.Text == xx && tic11RadioButton.Text == xx && tic01RadioButton.Text == xx)
                    {
                        lossesTextBox.Text = (uint.Parse(lossesTextBox.Text) + 1).ToString();
                        winLoseOrDraw = true;
                    }
                }
            }
            else if ((tic22RadioButton.Text == xx && tic12RadioButton.Text == xx && tic02RadioButton.Text == xx)
                    || (tic22RadioButton.Text == oo && tic12RadioButton.Text == oo && tic02RadioButton.Text == oo))
            {
                if (goesFirst)
                {
                    if (tic22RadioButton.Text == xx && tic12RadioButton.Text == xx && tic02RadioButton.Text == xx)
                    {
                        winsTextBox.Text = (uint.Parse(winsTextBox.Text) + 1).ToString();
                        winLoseOrDraw = true;
                    }
                    else if (tic22RadioButton.Text == oo && tic12RadioButton.Text == oo && tic02RadioButton.Text == oo)
                    {
                        lossesTextBox.Text = (uint.Parse(lossesTextBox.Text) + 1).ToString();
                        winLoseOrDraw = true;
                    }
                }
                else
                {
                    if (tic22RadioButton.Text == oo && tic12RadioButton.Text == oo && tic02RadioButton.Text == oo)
                    {
                        winsTextBox.Text = (uint.Parse(winsTextBox.Text) + 1).ToString();
                        winLoseOrDraw = true;
                    }
                    else if (tic22RadioButton.Text == xx && tic12RadioButton.Text == xx && tic02RadioButton.Text == xx)
                    {
                        lossesTextBox.Text = (uint.Parse(lossesTextBox.Text) + 1).ToString();
                        winLoseOrDraw = true;
                    }
                }
            }
            else if ((tic00RadioButton.Text == xx && tic11RadioButton.Text == xx && tic22RadioButton.Text == xx)
                    || (tic00RadioButton.Text == oo && tic11RadioButton.Text == oo && tic22RadioButton.Text == oo))
            {
                if (goesFirst)
                {
                    if (tic00RadioButton.Text == xx && tic11RadioButton.Text == xx && tic22RadioButton.Text == xx)
                    {
                        winsTextBox.Text = (uint.Parse(winsTextBox.Text) + 1).ToString();
                        winLoseOrDraw = true;
                    }
                    else if (tic00RadioButton.Text == oo && tic11RadioButton.Text == oo && tic22RadioButton.Text == oo)
                    {
                        lossesTextBox.Text = (uint.Parse(lossesTextBox.Text) + 1).ToString();
                        winLoseOrDraw = true;
                    }
                }
                else
                {
                    if (tic00RadioButton.Text == oo && tic11RadioButton.Text == oo && tic22RadioButton.Text == oo)
                    {
                        winsTextBox.Text = (uint.Parse(winsTextBox.Text) + 1).ToString();
                        winLoseOrDraw = true;
                    }
                    else if (tic00RadioButton.Text == xx && tic11RadioButton.Text == xx && tic22RadioButton.Text == xx)
                    {
                        lossesTextBox.Text = (uint.Parse(lossesTextBox.Text) + 1).ToString();
                        winLoseOrDraw = true;
                    }
                }
            }
            else if ((tic20RadioButton.Text == xx && tic11RadioButton.Text == xx && tic02RadioButton.Text == xx)
                    || (tic20RadioButton.Text == oo && tic11RadioButton.Text == oo && tic02RadioButton.Text == oo))
            {
                if (goesFirst)
                {
                    if (tic20RadioButton.Text == xx && tic11RadioButton.Text == xx && tic02RadioButton.Text == xx)
                    {
                        winsTextBox.Text = (uint.Parse(winsTextBox.Text) + 1).ToString();
                        winLoseOrDraw = true;
                    }
                    else if (tic20RadioButton.Text == oo && tic11RadioButton.Text == oo && tic02RadioButton.Text == oo)
                    {
                        lossesTextBox.Text = (uint.Parse(lossesTextBox.Text) + 1).ToString();
                        winLoseOrDraw = true;
                    }
                }
                else
                {
                    if (tic20RadioButton.Text == oo && tic11RadioButton.Text == oo && tic02RadioButton.Text == oo)
                    {
                        winsTextBox.Text = (uint.Parse(winsTextBox.Text) + 1).ToString();
                        winLoseOrDraw = true;
                    }
                    else if (tic20RadioButton.Text == xx && tic11RadioButton.Text == xx && tic02RadioButton.Text == xx)
                    {
                        lossesTextBox.Text = (uint.Parse(lossesTextBox.Text) + 1).ToString();
                        winLoseOrDraw = true;
                    }
                }
            }
            else if ((tic00RadioButton.Text == xx || tic00RadioButton.Text == oo)
                    && (tic01RadioButton.Text == xx || tic01RadioButton.Text == oo)
                    && (tic02RadioButton.Text == xx || tic02RadioButton.Text == oo)
                    && (tic10RadioButton.Text == xx || tic10RadioButton.Text == oo)
                    && (tic11RadioButton.Text == xx || tic11RadioButton.Text == oo)
                    && (tic12RadioButton.Text == xx || tic12RadioButton.Text == oo)
                    && (tic20RadioButton.Text == xx || tic20RadioButton.Text == oo)
                    && (tic21RadioButton.Text == xx || tic21RadioButton.Text == oo)
                    && (tic22RadioButton.Text == xx || tic22RadioButton.Text == oo))
                {
                    drawsTextBox.Text = (uint.Parse(drawsTextBox.Text) + 1).ToString();
                    winLoseOrDraw = true;
                }

            if (winLoseOrDraw)
            {
                DisableRadioButtons();
            }

            return winLoseOrDraw;

        }
        #endregion

        #region RadioButton manipulation methods
        private void DisableRadioButtons()
        {
            tic00RadioButton.Enabled = false;
            tic01RadioButton.Enabled = false;
            tic02RadioButton.Enabled = false;
            tic10RadioButton.Enabled = false;
            tic11RadioButton.Enabled = false;
            tic12RadioButton.Enabled = false;
            tic20RadioButton.Enabled = false;
            tic21RadioButton.Enabled = false;
            tic22RadioButton.Enabled = false;
        }

        private void NewGame()
        {
            DisableRadioButtons();
            tic00RadioButton.Text = string.Empty;
            tic00RadioButton.Checked = false;

            tic01RadioButton.Text = string.Empty;
            tic01RadioButton.Checked = false;

            tic02RadioButton.Text = string.Empty;
            tic02RadioButton.Checked = false;

            tic10RadioButton.Text = string.Empty;
            tic10RadioButton.Checked = false;

            tic11RadioButton.Text = string.Empty;
            tic11RadioButton.Checked = false;

            tic12RadioButton.Text = string.Empty;
            tic12RadioButton.Checked = false;

            tic20RadioButton.Text = string.Empty;
            tic20RadioButton.Checked = false;

            tic21RadioButton.Text = string.Empty;
            tic21RadioButton.Checked = false;

            tic22RadioButton.Text = string.Empty;
            tic22RadioButton.Checked = false;

            xoComboBox.Enabled = true;
        }

        #endregion

    }
}
