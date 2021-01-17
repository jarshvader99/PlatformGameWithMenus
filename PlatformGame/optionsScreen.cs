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
    public partial class optionsScreen : Form
    {
        public optionsScreen()
        {
            InitializeComponent();
        }

        private void mainMenu(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
