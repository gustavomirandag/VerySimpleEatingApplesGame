using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameApp
{
    public partial class form1 : Form
    {
        public form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Right)
                pikachu.Left += 10;
            else if (keyData == Keys.Left)
                pikachu.Left -= 10;
            else if (keyData == Keys.Up)
                pikachu.Top -= 10;
            else if (keyData == Keys.Down)
                pikachu.Top += 10;

            //Será que teve colisão?
            if (pikachu.Top <= maca.Top &&
                pikachu.Top + pikachu.Height >= maca.Top + maca.Height &&
                pikachu.Left <= maca.Left &&
                pikachu.Left + pikachu.Width >= maca.Left + maca.Width)
            {
                //Como a Maça
                labelScore.Text = (int.Parse(labelScore.Text) + 1).ToString();
                var rand = new Random();
                int x = rand.Next(0, this.Width - maca.Width);
                int y = rand.Next(0, this.Height - maca.Height);
                maca.Left = x;
                maca.Top = y;

            }


            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
