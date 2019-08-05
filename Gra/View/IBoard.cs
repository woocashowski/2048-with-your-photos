using System;
using System.Drawing;
using System.Windows.Forms;

namespace Game.View
{
    public partial class IBoard : UserControl
    {

        public IBoard()
        {
            InitializeComponent();
        }

        #region PROPERTIES
        //uint[,] Table;
        public event Func<uint[,], char, uint[,]> MoveTable;


        public uint[,] Board
        {
            get
            {
                Model.Block block = new Model.Block();
                //Zczytanie zdjęć i ich wartości
                uint[,] table = new uint[4, 4];
                uint k;


                //przypisanie wartości
                for (uint x = 0; x < 4; x++)
                {
                    for (uint y = 0; y < 4; y++)
                    {
                        k = ((4 * x) + y);
                        for (uint i = 0; i < 12; i++)
                        {
                            //if (k==0)
                            System.Console.WriteLine(i);
                            {
                                table[x, y] = block.GetVal(x, y);
                            }
                        }
                    }
                }
                return table;
            }

            set
            {
                Model.Block block = new Model.Block();
                Bitmap[] pictures = new Bitmap[16];
                Bitmap[] bitmap = new Bitmap[12];
                bitmap[0] = Properties.Resources._2;
                bitmap[1] = Properties.Resources._4;
                bitmap[2] = Properties.Resources._8;
                bitmap[3] = Properties.Resources._16;
                bitmap[4] = Properties.Resources._32;
                bitmap[5] = Properties.Resources._64;
                bitmap[6] = Properties.Resources._128;
                bitmap[7] = Properties.Resources._256;
                bitmap[8] = Properties.Resources._512;
                bitmap[9] = Properties.Resources._1024;
                bitmap[10] = Properties.Resources._2048;
                bitmap[11] = Properties.Resources._0;
                for (uint x = 0; x < 4; x++)
                {
                    for (uint y = 0; y < 4; y++)
                    {
                        uint k = ((4 * x) + y);

                        for (uint i = 0; i < 12; i++)
                        {
                            //if (k==0)
                            System.Console.WriteLine(i);
                            {
                                block.SetVal(value[x,y], x, y);

                                if (value[x, y] == 0) pictures[k] = bitmap[11];
                                if (value[x, y] == 2) pictures[k] = bitmap[0];
                                if (value[x, y] == 4) pictures[k] = bitmap[1];
                                if (value[x, y] == 8) pictures[k] = bitmap[2];
                                if (value[x, y] == 16) pictures[k] = bitmap[3];
                                if (value[x, y] == 32) pictures[k] = bitmap[4];
                                if (value[x, y] == 64) pictures[k] = bitmap[5];
                                if (value[x, y] == 128) pictures[k] = bitmap[6];
                                if (value[x, y] == 256) pictures[k] = bitmap[7];
                                if (value[x, y] == 512) pictures[k] = bitmap[8];
                                if (value[x, y] == 1024) pictures[k] = bitmap[9];
                                if (value[x, y] == 2048) pictures[k] = bitmap[10];
                            }
                        }
                    }
                }

                pictureBox1.Image = pictures[0];
                pictureBox2.Image = pictures[1];
                pictureBox3.Image = pictures[2];
                pictureBox4.Image = pictures[3];
                pictureBox5.Image = pictures[4];
                pictureBox6.Image = pictures[5];
                pictureBox7.Image = pictures[6];
                pictureBox8.Image = pictures[7];
                pictureBox9.Image = pictures[8];
                pictureBox10.Image = pictures[9];
                pictureBox11.Image = pictures[10];
                pictureBox12.Image = pictures[11];
                pictureBox13.Image = pictures[12];
                pictureBox14.Image = pictures[13];
                pictureBox15.Image = pictures[14];
                pictureBox16.Image = pictures[15];
            }
        }



        #endregion

        public void CustomKeyDown(object sender, KeyEventArgs e)
        {
            if (MoveTable != null)
                Board = MoveTable(Board, Convert.ToChar(e.KeyCode));
            //wysyła znak i tablicę, dostaje tablicę
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources._2048;
        }

        //private void IBoard_KeyDown(object sender, KeyEventArgs e)
        //{
        //    pictureBox1.Image = Properties.Resources._2048;
        //}

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            // pictureBox1.Image = Game.Properties.Resources._2048;
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            if (MoveTable != null)
                Board = MoveTable(Board, 'r');
            pictureBox1.Image = Properties.Resources._0;
            pictureBox2.Image = Properties.Resources._0;
            pictureBox3.Image = Properties.Resources._0;
            pictureBox4.Image = Properties.Resources._0;
            pictureBox5.Image = Properties.Resources._0;
            pictureBox6.Image = Properties.Resources._0;
            pictureBox7.Image = Properties.Resources._0;
            pictureBox8.Image = Properties.Resources._0;
            pictureBox9.Image = Properties.Resources._0;
            pictureBox10.Image = Properties.Resources._0;
            pictureBox11.Image = Properties.Resources._0;
            pictureBox12.Image = Properties.Resources._0;
            pictureBox13.Image = Properties.Resources._0;
            pictureBox14.Image = Properties.Resources._0;
            pictureBox15.Image = Properties.Resources._0;
            pictureBox16.Image = Properties.Resources._0;
            progressBar1.Value = 0;
            
        }

        private void IBoard_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {

        }
    }
}
