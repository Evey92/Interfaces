using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minesweeper
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            int ButtonWidth = 40;
            int ButtonHeight = 40;
            int Distance = 20;
            int start_x = 20;
            int start_y = 20;

            for (int x = 0; x < 5; x++)
            {                                   //Estos 2 fors controlan el tamaño del grid
                for (int y = 0; y < 5; y++)
                {
                    Button tmpButton = new Button();
                    tmpButton.Top = start_x + (x * ButtonHeight + Distance);
                    tmpButton.Left = start_y + (y * ButtonWidth + Distance);
                    tmpButton.Width = ButtonWidth;
                    tmpButton.Height = ButtonHeight;
                    tmpButton.Text = "?";
                    // Possible add Buttonclick event etc..
                    this.Controls.Add(tmpButton);
                }

            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
