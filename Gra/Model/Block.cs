using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Model
{
    class Block
    {
        public uint[,] Value = new uint[4, 4];

        public uint GetVal(uint x, uint y)
        {
            try
            {
                var lines = File.ReadAllLines("D:\\plik.txt");
                //Continue to read until you reach end of file
                for (int x1 = 0; x1 < 4; x1++)
                {
                    for (int y2 = 0; y2 < 4; y2++)
                    {
                        int k = 4 * x1 + y2;
                        Value[x1,y2] = Convert.ToUInt32(lines[k]);
                    }
                }
            }
            catch { }
            return Value[x,y];
        }

        public void SetVal(uint val, uint x, uint y)
        {
            try
            {
                var lines = File.ReadAllLines("D:\\plik.txt");
                lines[4 * x + y] = Convert.ToString(val);
            }
            catch
            {
                System.Console.WriteLine("ERROR");
            }
        }
    }
}
