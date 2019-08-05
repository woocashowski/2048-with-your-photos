using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game.View
{ 
    public partial class View : Form
    {
        public View()
        {
            InitializeComponent();
            //Plansza objekt;
            this.obiekt = new IBoard();
            this.obiekt.Location = new System.Drawing.Point(6, 6);
            this.obiekt.Load += new System.EventHandler(this.obiekt_Load);
            this.Controls.Add(obiekt);
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void obiekt_Load(object sender, EventArgs e)
        {

        }
        public IBoard obiekt;

		private void View_KeyDown(object sender, KeyEventArgs e)
		{
			obiekt.CustomKeyDown(sender, e);
		}
	}
}
