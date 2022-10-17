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
        

        private void Form1_Load(object sender, EventArgs e)
        {
            lblMap.Text = gameEngine.View;
            lblStats.Text = gameEngine.hero.ToString();
        }

        public Form1()
        {
            

            gameEngine = new GameEngine();
            
            InitializeComponent();
            

        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            //gameEngine.MovePlayer(Movement.Up);
            //lblMap.Text = gameEngine.View;

            gameEngine.MovePlayer(Movement.Up);
            lblStats.Text = gameEngine.hero.ToString();
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
        private void frmGame_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            
            if (e.KeyChar == 'i')
            {
                lblStats.Text = gameEngine.PlayerAttack(Tile.AttackDirection.Up);
                lblMap.Text = gameEngine.View;
            }
            else if (e.KeyChar == 'j')
            {
                lblStats.Text = gameEngine.PlayerAttack(Tile.AttackDirection.Left);
                lblMap.Text = gameEngine.View;
            }
            else if (e.KeyChar == 'k')
            {
                lblStats.Text = gameEngine.PlayerAttack(Tile.AttackDirection.Down);
                lblMap.Text = gameEngine.View;
            }
            else if (e.KeyChar == 'l')
            {
                lblStats.Text = gameEngine.PlayerAttack(Tile.AttackDirection.Right);
                lblMap.Text = gameEngine.View;
            }
            
        }


    }
}
