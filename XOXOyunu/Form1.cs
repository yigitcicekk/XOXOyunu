using System.Drawing.Text;
using System.Security.Cryptography.X509Certificates;

namespace XOXOyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void XOXFinishedGame()
        {
            lblXOX.Text = "X";

            btn1.Text = "";
            btn2.Text = "";
            btn3.Text = "";
            btn4.Text = "";
            btn5.Text = "";
            btn6.Text = "";
            btn7.Text = "";
            btn8.Text = "";
            btn9.Text = "";

            btn1.Enabled = true;
            btn2.Enabled = true;
            btn3.Enabled = true;
            btn4.Enabled = true;
            btn5.Enabled = true;
            btn6.Enabled = true;
            btn7.Enabled = true;
            btn8.Enabled = true;
            btn9.Enabled = true;
            btn9.Enabled = true;
        }

        private void ReplayGame()
        {
            DialogResult replayGame = MessageBox.Show("Tekrar Oynamak İster Misin?","Oyun Bitti",MessageBoxButtons.YesNo);

            if (replayGame == DialogResult.Yes)
            {
                XOXFinishedGame();
            }
            else
            {
                Application.Exit();
            }
        }

        private void XOXClickGame(object sender, EventArgs e)
        {

            Button button = sender as Button;

            if (lblXOX.Text == "X")
            {
                button.Text = "X";
                button.Enabled = false;
                lblXOX.Text = "O";
            }
            else
            {
                button.Text = "O";
                button.Enabled = false;
                lblXOX.Text = "X";
            }



            if (btn1.Text == "X" && btn5.Text == "X" && btn9.Text == "X")
            {
                MessageBox.Show("Kazanan X!");
                ReplayGame();

            }
            if (btn1.Text == "O" && btn5.Text == "O" && btn9.Text == "O")
            {
                MessageBox.Show("Kazanan O!");
                ReplayGame();


            }
            if (btn3.Text == "X" && btn5.Text == "X" && btn7.Text == "X")
            {
                MessageBox.Show("Kazanan X!");
                ReplayGame();


            }
            if (btn3.Text == "O" && btn5.Text == "O" && btn7.Text == "O")
            {
                MessageBox.Show("Kazanan O!");
                ReplayGame();


            }
            if (btn1.Text == "X" && btn2.Text == "X" && btn3.Text == "X")
            {
                MessageBox.Show("Kazanan X!");
                ReplayGame();


            }
            if (btn1.Text == "O" && btn2.Text == "O" && btn3.Text == "O")
            {
                MessageBox.Show("Kazanan O!");
                ReplayGame();


            }
            if (btn4.Text == "X" && btn5.Text == "X" && btn6.Text == "X")
            {
                MessageBox.Show("Kazanan X!");
                ReplayGame();


            }
            if (btn4.Text == "O" && btn5.Text == "O" && btn6.Text == "O")
            {
                MessageBox.Show("Kazanan O!");
                ReplayGame();



            }
            if (btn7.Text == "X" && btn8.Text == "X" && btn9.Text == "X")
            {
                MessageBox.Show("Kazanan X!");
                ReplayGame();


            }
            if (btn7.Text == "O" && btn8.Text == "O" && btn9.Text == "O")
            {
                MessageBox.Show("Kazanan O!");
                ReplayGame();


            }
            if (btn1.Text == "X" && btn4.Text == "X" && btn7.Text == "X")
            {
                MessageBox.Show("Kazanan X!");
                ReplayGame();


            }
            if (btn1.Text == "O" && btn4.Text == "O" && btn7.Text == "O")
            {
                MessageBox.Show("Kazanan O!");
                ReplayGame();


            }
            if (btn2.Text == "X" && btn5.Text == "X" && btn8.Text == "X")
            {
                MessageBox.Show("Kazanan X!");
                ReplayGame();


            }
            if (btn2.Text == "O" && btn5.Text == "O" && btn8.Text == "O")
            {
                MessageBox.Show("Kazanan O!");
                ReplayGame();


            }
            if (btn3.Text == "X" && btn6.Text == "X" && btn9.Text == "X")
            {
                MessageBox.Show("Kazanan X!");
                ReplayGame();


            }
            if (btn3.Text == "O" && btn6.Text == "O" && btn9.Text == "O")
            {
                MessageBox.Show("Kazanan O!");
                ReplayGame();


            }
            if (btn1.Text != "" && btn2.Text != "" && btn3.Text != "" && btn4.Text != "" && btn5.Text != "" && btn6.Text != "" && btn7.Text != "" && btn8.Text != "" && btn9.Text != "")
            {
                MessageBox.Show("Oyun Berabere!");
                ReplayGame();
            }

        }

        //var result = CheckWin();

        //if (result == "Berabere")
        //{
        //    ReplayGame();
        //}
        //else if(!string.IsNullOrEmpty(result))
        //{
        //    MessageBox.Show($"Kazanan {result}!");
        //    ReplayGame();
        //}

        //private string[] GetBoard()
        //{
        //    return new string[] { btn1.Text, btn2.Text, btn3.Text, btn4.Text, btn5.Text, btn6.Text, btn7.Text, btn8.Text, btn9.Text };
        //}

        //private string CheckWin()
        //{
        //    int[][] winConditions = new int[][]
        //    {
        //        new int[] {1, 2, 3}, 
        //        new int[] {4, 5, 6}, 
        //        new int[] {7, 8, 9}, 
        //        new int[] {1, 4, 7}, // First column
        //        new int[] {2, 5, 8}, // Second column
        //        new int[] {3, 6, 9}, // Third column
        //        new int[] {1, 5, 9}, // Diagonal from top-left to bottom-right
        //        new int[] {3, 5, 7}  // Diagonal from top-right to bottom-left
        //    };

        //    var board = GetBoard();

        //    foreach (var condition in winConditions)
        //    {
        //        if (board[condition[0]] == board[condition[1]] && board[condition[1]] == board[condition[2]])
        //        {
        //            return board[condition[0]];
        //        }
        //    }

        //    if (Array.TrueForAll(board, pos => pos == "X" || pos == "O"))
        //    {
        //        return "Berabere";
        //    }

        //    return string.Empty;
        //}
    }
}
