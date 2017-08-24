using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EtchAndSketch
{
    public partial class EtchAndSketch : Form
    {
        private float posX, posY;
        private Graphics g;
        public EtchAndSketch()
        {
            InitializeComponent();

            posX = drawingPanel.Width / 2;
            posY = drawingPanel.Height / 2;

            g = drawingPanel.CreateGraphics();

        }

        private void upButton_Click(object sender, EventArgs e)
        {
            g.DrawLine(new Pen(Color.Red), posX, posY, posX, posY - 5);
            posY -= 5;
        }

        private void rightButton_Click(object sender, EventArgs e)
        {
            g.DrawLine(new Pen(Color.Blue), posX, posY, posX + 5, posY);
            posX += 5;
        }

        private void downButton_Click(object sender, EventArgs e)
        {
            g.DrawLine(new Pen(Color.Red), posX, posY, posX, posY + 5);
            posY += 5;
        }

        private void leftButton_Click(object sender, EventArgs e)
        {
            g.DrawLine(new Pen(Color.Blue), posX, posY, posX - 5, posY);
            posX -= 5;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            posX = drawingPanel.Width / 2;
            posY = drawingPanel.Height / 2;
        }
    }
}
