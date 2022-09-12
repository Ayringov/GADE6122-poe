using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GADE6122part1
{
    public partial class Form1 : Form
    {


        GameEngine gameEngine;
        private Hero hero;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public Form1()
        {
            InitializeComponent();

            gameEngine = new GameEngine();
            lblMap.Text = gameEngine.View;
            InitializeComponent();
            lblStats.Text = gameEngine.hero.ToString();

        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            gameEngine.MovePlayer(Movement.Up);
            lblMap.Text = gameEngine.View;
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            gameEngine.MovePlayer(Movement.Down);
            lblMap.Text = gameEngine.View;
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            gameEngine.MovePlayer(Movement.Left);
            lblMap.Text = gameEngine.View;
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            gameEngine.MovePlayer(Movement.Right);
            lblMap.Text = gameEngine.View;
        }

        private void btnLeft_Click_1(object sender, EventArgs e)
        {

        }
    }
}
