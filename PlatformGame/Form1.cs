using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlatformGame
{
    public partial class Form1 : Form
    {
        gameScreen inGameScreen = new gameScreen();
        optionsScreen inOptionsScreen = new optionsScreen();
        public Form1()
        {
            InitializeComponent();
        }

        private void startGame(object sender, EventArgs e)
        {
            this.Hide();
            inGameScreen.Show();
        }

        private void showOptions(object sender, EventArgs e)
        {
            this.Hide();
            inOptionsScreen.Show();
        }

        private void keyisdown(object sender, KeyEventArgs e)
        {

        }
    }
}
