using System;
using System.Drawing;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        Boolean check;
        int add;
        void falsechk()
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;

        }


        void score()
        {
            if (button1.Text == "X" && button2.Text == "X" && button3.Text == "X")
            {
                button1.BackColor = Color.PowderBlue;
                button2.BackColor = Color.PowderBlue;
                button3.BackColor = Color.PowderBlue;

                MessageBox.Show("Winner is X", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                add = int.Parse(lblplx.Text);
                lblplx.Text = Convert.ToString(add);
                falsechk();
            }
            if (button1.Text == "X" && button4.Text == "X" && button7.Text == "X")
            {
                button1.BackColor = Color.PowderBlue;
                button4.BackColor = Color.PowderBlue;
                button7.BackColor = Color.PowderBlue;

                MessageBox.Show("Winner is X", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                add = int.Parse(lblplx.Text);
                lblplx.Text = Convert.ToString(add);
                falsechk();
            }
            if (button1.Text == "X" && button5.Text == "X" && button9.Text == "X")
            {
                button1.BackColor = Color.PowderBlue;
                button5.BackColor = Color.PowderBlue;
                button9.BackColor = Color.PowderBlue;

                MessageBox.Show("Winner is X", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                add = int.Parse(lblplx.Text);
                lblplx.Text = Convert.ToString(add);
                falsechk();
            }
            if (button3.Text == "X" && button5.Text == "X" && button7.Text == "X")
            {
                button3.BackColor = Color.PowderBlue;
                button5.BackColor = Color.PowderBlue;
                button7.BackColor = Color.PowderBlue;

                MessageBox.Show("Winner is X", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                add = int.Parse(lblplx.Text);
                lblplx.Text = Convert.ToString(add);
                falsechk();
            }
            if (button2.Text == "X" && button5.Text == "X" && button8.Text == "X")
            {
                button2.BackColor = Color.PowderBlue;
                button5.BackColor = Color.PowderBlue;
                button8.BackColor = Color.PowderBlue;

                MessageBox.Show("Winner is X", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                add = int.Parse(lblplx.Text);
                lblplx.Text = Convert.ToString(add);
                falsechk();
            }
            if (button4.Text == "X" && button5.Text == "X" && button6.Text == "X")
            {
                button4.BackColor = Color.PowderBlue;
                button5.BackColor = Color.PowderBlue;
                button6.BackColor = Color.PowderBlue;

                MessageBox.Show("Winner is X", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                add = int.Parse(lblplx.Text);
                lblplx.Text = Convert.ToString(add );
                falsechk();
            }
            if (button1.Text == "X" && button2.Text == "X" && button3.Text == "X")
            {
                button1.BackColor = Color.PowderBlue;
                button2.BackColor = Color.PowderBlue;
                button3.BackColor = Color.PowderBlue;

                MessageBox.Show("Winner is X", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                add = int.Parse(lblplx.Text);
                lblplx.Text = Convert.ToString(add );
                falsechk();
            }
            if (button1.Text == "X" && button4.Text == "X" && button7.Text == "X")
            {
                button1.BackColor = Color.PowderBlue;
                button4.BackColor = Color.PowderBlue;
                button7.BackColor = Color.PowderBlue;

                MessageBox.Show("Winner is X", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                add = int.Parse(lblplx.Text);
                lblplx.Text = Convert.ToString(add );
                falsechk();
            }
            if (button1.Text == "X" && button5.Text == "X" && button9.Text == "X")
            {
                button1.BackColor = Color.PowderBlue;
                button5.BackColor = Color.PowderBlue;
                button9.BackColor = Color.PowderBlue;

                MessageBox.Show("Winner is X", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                add = int.Parse(lblplx.Text);
                lblplx.Text = Convert.ToString(add );
                falsechk();
            }
            if (button3.Text == "X" && button5.Text == "X" && button7.Text == "X")
            {
                button3.BackColor = Color.PowderBlue;
                button5.BackColor = Color.PowderBlue;
                button7.BackColor = Color.PowderBlue;

                MessageBox.Show("Winner is X", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                add = int.Parse(lblplx.Text);
                lblplx.Text = Convert.ToString(add );
                falsechk();
            }
            if (button2.Text == "X" && button5.Text == "X" && button8.Text == "X")
            {
                button2.BackColor = Color.PowderBlue;
                button5.BackColor = Color.PowderBlue;
                button8.BackColor = Color.PowderBlue;

                MessageBox.Show("Winner is X", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                add = int.Parse(lblplx.Text);
                lblplx.Text = Convert.ToString(add );
                falsechk();
            }
            if (button4.Text == "X" && button5.Text == "X" && button6.Text == "X")
            {
                button4.BackColor = Color.PowderBlue;
                button5.BackColor = Color.PowderBlue;
                button6.BackColor = Color.PowderBlue;

                MessageBox.Show("Winner is X", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                add = int.Parse(lblplx.Text);
                lblplx.Text = Convert.ToString(add );
                falsechk();
            }
            ///////////////////////////////////////////////////////////////////
            if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O")
            {
                button1.BackColor = Color.PowderBlue;
                button2.BackColor = Color.PowderBlue;
                button3.BackColor = Color.PowderBlue;

                MessageBox.Show("Winner is O", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                add = int.Parse(lblplo.Text);
                lblplo.Text = Convert.ToString(add );
                falsechk();
            }
            if (button1.Text == "O" && button4.Text == "O" && button7.Text == "O")
            {
                button1.BackColor = Color.PowderBlue;
                button4.BackColor = Color.PowderBlue;
                button7.BackColor = Color.PowderBlue;

                MessageBox.Show("Winner is O", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                add = int.Parse(lblplo.Text);
                lblplo.Text = Convert.ToString(add );
                falsechk();
            }
            if (button1.Text == "O" && button5.Text == "O" && button9.Text == "O")
            {
                button1.BackColor = Color.PowderBlue;
                button5.BackColor = Color.PowderBlue;
                button9.BackColor = Color.PowderBlue;

                MessageBox.Show("Winner is O", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                add = int.Parse(lblplo.Text);
                lblplo.Text = Convert.ToString(add );
                falsechk();
            }
            if (button3.Text == "O" && button5.Text == "O" && button7.Text == "O")
            {
                button3.BackColor = Color.PowderBlue;
                button5.BackColor = Color.PowderBlue;
                button7.BackColor = Color.PowderBlue;

                MessageBox.Show("Winner is O", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                add = int.Parse(lblplo.Text);
                lblplo.Text = Convert.ToString(add );
                falsechk();
            }
            if (button2.Text == "O" && button5.Text == "O" && button8.Text == "O")
            {
                button2.BackColor = Color.PowderBlue;
                button5.BackColor = Color.PowderBlue;
                button8.BackColor = Color.PowderBlue;

                MessageBox.Show("Winner is O", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                add = int.Parse(lblplo.Text);
                lblplo.Text = Convert.ToString(add );
                falsechk();
            }
            if (button4.Text == "O" && button5.Text == "O" && button6.Text == "O")
            {
                button4.BackColor = Color.PowderBlue;
                button5.BackColor = Color.PowderBlue;
                button6.BackColor = Color.PowderBlue;

                MessageBox.Show("Winner is O", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                add = int.Parse(lblplo.Text);
                lblplo.Text = Convert.ToString(add);
                falsechk();
            }
            if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O")
            {
                button1.BackColor = Color.PowderBlue;
                button2.BackColor = Color.PowderBlue;
                button3.BackColor = Color.PowderBlue;

                MessageBox.Show("Winner is O", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                add = int.Parse(lblplo.Text);
                lblplo.Text = Convert.ToString(add );
                falsechk();
            }
            if (button1.Text == "O" && button4.Text == "O" && button7.Text == "O")
            {
                button1.BackColor = Color.PowderBlue;
                button4.BackColor = Color.PowderBlue;
                button7.BackColor = Color.PowderBlue;

                MessageBox.Show("Winner is O", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                add = int.Parse(lblplo.Text);
                lblplo.Text = Convert.ToString(add);
                falsechk();
            }
            if (button1.Text == "O" && button5.Text == "O" && button9.Text == "O")
            {
                button1.BackColor = Color.PowderBlue;
                button5.BackColor = Color.PowderBlue;
                button9.BackColor = Color.PowderBlue;

                MessageBox.Show("Winner is O", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                add = int.Parse(lblplo.Text);
                lblplo.Text = Convert.ToString(add );
                falsechk();
            }
            if (button3.Text == "O" && button5.Text == "O" && button7.Text == "O")
            {
                button3.BackColor = Color.PowderBlue;
                button5.BackColor = Color.PowderBlue;
                button7.BackColor = Color.PowderBlue;

                MessageBox.Show("Winner is O", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                add = int.Parse(lblplo.Text);
                lblplo.Text = Convert.ToString(add );
                falsechk();
            }
            if (button2.Text == "O" && button5.Text == "O" && button8.Text == "O")
            {
                button2.BackColor = Color.PowderBlue;
                button5.BackColor = Color.PowderBlue;
                button8.BackColor = Color.PowderBlue;

                MessageBox.Show("Winner is O", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                add = int.Parse(lblplo.Text);
                lblplo.Text = Convert.ToString(add );
                falsechk();
            }
            if (button4.Text == "O" && button5.Text == "O" && button6.Text == "O")
            {
                button4.BackColor = Color.PowderBlue;
                button5.BackColor = Color.PowderBlue;
                button6.BackColor = Color.PowderBlue;

                MessageBox.Show("Winner is O", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                add = int.Parse(lblplo.Text);
                lblplo.Text = Convert.ToString(add);
                falsechk();
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                if (check == false)
                {
                    button1.Text = "X";
                    check = true;
                }
                else
                {
                    button1.Text = "O";
                    check = false;
                }
                score();
                button1.Enabled = false;


            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            {
                if (check == false)
                {
                    button2.Text = "X";
                    check = true;
                }
                else
                {
                    button2.Text = "O";
                    check = false;  
                }
                score();
                button2.Enabled = false;


            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            {
                if (check == false)
                {
                    button3.Text = "X";
                    check = true;
                }
                else
                {
                    button3.Text = "O";
                    check = false;
                }
                score();
                button3.Enabled = false;


            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            {
                if (check == false)
                {
                    button4.Text = "X";
                    check = true;
                }
                else
                {
                    button4.Text = "O";
                    check = false;
                }
                score();
                button4.Enabled = false;


            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            {
                if (check == false)
                {
                    button5.Text = "X";
                    check = true;
                }
                else
                {
                    button5.Text = "O";
                    check = false;
                }
                score();
                button5.Enabled = false;


            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            {
                if (check == false)
                {
                    button6.Text = "X";
                    check = true;
                }
                else
                {
                    button6.Text = "O";
                    check = false;
                }
                score();
                button6.Enabled = false;


            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            {
                if (check == false)
                {
                    button7.Text = "X";
                    check = true;
                }
                else
                {
                    button7.Text = "O";
                    check = false;
                }
                score();
                button7.Enabled = false;


            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            {
                if (check == false)
                {
                    button8.Text = "X";
                    check = true;
                }
                else
                {
                    button8.Text = "O";
                    check = false;
                }
                score();
                button8.Enabled = false;


            }
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            {
                if (check == false)
                {
                    button9.Text = "X";
                    check = true;
                }
                else
                {
                    button9.Text = "O";
                    check = false;
                }
                score();
                button9.Enabled = false;


            }
        }

        private void newgamebtn_Click(object sender, EventArgs e)
        {
           
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = true;
                button6.Enabled = true;
                button7.Enabled = true;
                button8.Enabled = true;
                button9.Enabled = true;

                button1.Text = "";
                button2.Text = "";
                button3.Text = "";
                button4.Text = "";
                button5.Text = "";
                button6.Text = "";
                button7.Text = "";
                button8.Text = "";
                button9.Text = "";

                lblplx.Text = "0";
                lblplo.Text = "0";


                button1.BackColor = Color.White;
                button2.BackColor = Color.White;
                button3.BackColor = Color.White;
                button4.BackColor = Color.White;
                button5.BackColor = Color.White;
                button6.BackColor = Color.White;
                button7.BackColor = Color.White;
                button8.BackColor = Color.White;
                button9.BackColor = Color.White;
            
           

        }

        private void resetgme_click(object sender, EventArgs e)
        {
          
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = true;
                button6.Enabled = true;
                button7.Enabled = true;
                button8.Enabled = true;
                button9.Enabled = true;

                button1.Text = "";
                button2.Text = "";
                button3.Text = "";
                button4.Text = "";
                button5.Text = "";
                button6.Text = "";
                button7.Text = "";
                button8.Text = "";
                button9.Text = "";



                button1.BackColor = Color.White;
                button2.BackColor = Color.White;
                button3.BackColor = Color.White;
                button4.BackColor = Color.White;
                button5.BackColor = Color.White;
                button6.BackColor = Color.White;
                button7.BackColor = Color.White;
                button8.BackColor = Color.White;
                button9.BackColor = Color.White;
          

        }

      
    }
}
