using System;
using System.IO;

namespace Game.Model
{
    class Logic
    {
        //private Block[,] tab = new Block[4, 4];
        //Block Return;

        public uint[,] MoveTable(uint[,] Tab, char Move) //odpowiada za ruch planszy
        {
            //Tab[1, 2] = 8;


            var lines = File.ReadAllLines("D:\\plik.txt");
            //Continue to read until you reach end of file
            for (int x1 = 0; x1 < 4; x1++)
            {
                for (int y2 = 0; y2 < 4; y2++)
                {
                    int k = (4 * x1) + y2;
                    Tab[x1, y2] = Convert.ToUInt32(lines[k]);
                }
            }

        bool moved = false;
            //Ruch w górę - czyli prawo
            if (Move == 'a' || Move == 'A')

            {
                for (int x = 0; x < 4; x++) //wszystkie X
                {
                    for (int y = 0; y < 3; y++) //Y bez dolnego rzędu są sprawdzane
                    {
                        if (Tab[x, y].Equals(0))
                        {
                            if (!(Tab[x, y + 1].Equals(0)))
                            {
                                Tab[x, y] = Tab[x, y + 1];
                                Tab[x, y + 1] = 0;
                                moved = true;
                            }
                            else if (y < 2&&!(Tab[x, y + 2].Equals(0)) )
                            {
                                Tab[x, y] = Tab[x, y + 2];
                                Tab[x, y + 2] = 0;
                                moved = true;
                            }
                            else if (y < 1 && !Tab[x, y + 3].Equals(0) )
                            {
                                Tab[x, y] = Tab[x, y + 3];
                                Tab[x, y + 3] = 0;
                                moved = true;
                            }
                        }

                        if (!Tab[x, y].Equals(0))
                        {
                            if (Tab[x, y] == Tab[x, y + 1]) //Sprawdzenie czy można połączyć sąsiadujące
                            {
                                Tab[x, y] = Tab[x, y] * 2;

                                Tab[x, y + 1] = 0;
                                moved = true;
                            }

                            // Czy można połączyć z odległym o 2
                            else if (y < 2 && Tab[x, y] == Tab[x, y + 2] && Tab[x, y + 1].Equals(0) && !Tab[x, y + 2].Equals(0) )
                            {


                                Tab[x, y] = Tab[x, y] * 2;
                                Tab[x, y + 2] = 0;
                                moved = true;
                            }

                            // Czy można połączyć z odległym o 3
                            else if ( y < 1 &&Tab[x, y] == Tab[x, y + 3] && Tab[x, y + 1].Equals(0) && Tab[x, y + 2].Equals(0) && !Tab[x, y + 3].Equals(0))
                            {
                                Tab[x, y] = Tab[x, y] * 2;
                                Tab[x, y + 3] = 0;
                                moved = true;
                            }
                        }

                        // Jeśli pole jest równe 0 to sprawdź czy da się coś "wstawić"
                        else if (Tab[x, y].Equals(0))
                        {
                            if (!Tab[x, y + 1].Equals(0))
                            {
                                Tab[x, y] = Tab[x, y + 1];
                                Tab[x, y + 1] = 0;
                                moved = true;
                            }
                            else if (y < 2&&!Tab[x, y + 2].Equals(0) )
                            {
                                Tab[x, y] = Tab[x, y + 2];
                                Tab[x, y + 2] = 0;
                                moved = true;
                            }
                            else if (y < 1&&!Tab[x, y + 3].Equals(0) )
                            {
                                Tab[x, y] = Tab[x, y + 3];
                                Tab[x, y + 3] = 0;
                                moved = true;
                            }
                            else
                            {
                                //cout << "Brak ruchu";
                            }
                        }
                    }
                }

                if (moved)
                {
                    //cout << " Bylo " << k;
                    //getchar();
                    //getchar();
                }
                else
                {
                    //cout << " Nie bylo "<<k;
                    //getchar();
                    //getchar();
                    //generuj();
                }
                //Kolejne znaki
            }

            //Ruch w dół, który jest w prawo bo zjebałem XD
            if (Move == 'd' || Move == 'D')
            {
                //Return = Tab;
                
                //return Tab;
                for (int x = 0; x < 4; x++) //wszystkie X
                    for (int y = 3; y > 0; y--) //Y bez dolnego rzędu są sprawdzane
                    {
                        if (Tab[x, y].Equals(0))
                        {
                            if (!Tab[x, y - 1].Equals(0))
                            {
                                Tab[x, y] = Tab[x, y - 1];
                                Tab[x, y - 1] = 0;
                                moved = true;
                            }
                            else if (y > 1 && !Tab[x, y - 2].Equals(0))
                            {
                                Tab[x, y] = Tab[x, y - 2];
                                Tab[x, y - 2] = 0;
                                moved = true;
                            }
                            else if (y > 2 && !Tab[x, y - 3].Equals(0))
                            {
                                Tab[x, y] = Tab[x, y - 3];
                                Tab[x, y - 3] = 0;
                                moved = true;
                            }
                        }

                        if (!Tab[x, y].Equals(0))
                        {
                            if (Tab[x, y] == Tab[x, y - 1]) //Sprawdzenie czy można połączyć sąsiadujące
                            {
                                Tab[x, y] = Tab[x, y] * 2;
                                Tab[x, y - 1] = 0;
                                moved = true;
                            }

                            // Czy można połączyć z odległym o 2
                            else if (y > 2 && Tab[x, y] == Tab[x, y - 2] && Tab[x, y - 1].Equals(0) && y > 1)
                            {
                                Tab[x, y] = Tab[x, y] * 2;
                                Tab[x, y - 2] = 0;
                                moved = true;
                            }

                            // Czy można połączyć z odległym o 3
                            else if (y > 2 && Tab[x, y] == Tab[x, y - 3] && Tab[x, y - 1].Equals(0) && Tab[x, y - 2].Equals(0))
                            {
                                Tab[x, y] = Tab[x, y] * 2;
                                Tab[x, y - 3] = 0;
                                moved = true;
                            }
                        }

                        // Jeśli pole jest równe 0 to sprawdź czy da się coś "wstawić"
                        else if (Tab[x, y].Equals(0))
                        {
                            if (!Tab[x, y - 1].Equals(0))
                            {
                                Tab[x, y] = Tab[x, y - 1];
                                Tab[x, y - 1] = 0;
                                moved = true;
                            }
                            else if (y > 1 && !Tab[x, y - 2].Equals(0))
                            {
                                Tab[x, y] = Tab[x, y - 2];
                                Tab[x, y - 2] = 0;
                                moved = true;
                            }
                            else if (y > 2 && !Tab[x, y - 3].Equals(0))
                            {
                                Tab[x, y] = Tab[x, y - 3];
                                Tab[x, y - 3] = 0;
                                moved = true;
                            }
                        }
                    }
                /*bool chec = true;
                for (int i = 0; i < 4; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        if (Tab[i, j] != 0) chec = false;
                    }
                }
                if (moved || chec)
                {
                    Random rand = new Random();
                    uint a, b, c, d = 0;
                    for (; d == 0;)
                    {
                        a = Convert.ToUInt32(rand.Next(4));
                        b = Convert.ToUInt32(rand.Next(4));
                        c = Convert.ToUInt32(rand.Next(2));
                        if (Tab[a, b] == 0)
                        {
                            Tab[a, b] = (c + 1) * 2;
                            d = 1;
                        }
                    }
                    //cout << " Bylo " << k;
                    //getchar();
                    //getchar();
                }
                else
                {
                    //cout << " Nie bylo "<<k;
                    //getchar();
                    //getchar();
                    //generuj();
                }
                */

            }

            //ruch w lewo - górę
            if (Move == 'w' || Move == 'W')
            {
                for (int x = 0; x < 3; x++)
                    for (int y = 0; y < 4; y++)
                    {
                        if (Tab[x, y].Equals(0))
                        {
                            if (!Tab[x + 1, y].Equals(0))
                            {
                                Tab[x, y] = Tab[x + 1, y];
                                Tab[x + 1, y] = 0;
                                moved = true; ;
                            }
                            else if (x < 2 && !Tab[x + 2, y].Equals(0))
                            {
                                Tab[x, y] = Tab[x + 2, y];
                                Tab[x + 2, y] = 0;
                                moved = true; ;
                            }
                            else if (x < 1 && Tab[x + 3, y].Equals(0) )
                            {
                                Tab[x, y] = Tab[x + 3, y];
                                Tab[x + 3, y] = 0;
                                moved = true; ;
                            }
                        }

                        if (!Tab[x, y].Equals(0))
                        {
                            if (Tab[x, y] == Tab[x + 1, y]) //Sprawdzenie czy można połączyć sąsiadujące
                            {
                                Tab[x, y] = Tab[x, y] * 2;
                                Tab[x + 1, y] = 0;
                                moved = true; ;
                            }

                            // Czy można połączyć z odległym o 2
                            else if (x < 2&&Tab[x, y] == Tab[x + 2, y] && Tab[x + 1, y].Equals(0) && !Tab[x + 2, y].Equals(0) )
                            {
                                Tab[x, y] = Tab[x, y] * 2;
                                Tab[x + 2, y] = 0;
                                moved = true; ;
                            }

                            // Czy można połączyć z odległym o 3
                            else if (x < 1 &&Tab[x, y] == Tab[x + 3, y] && Tab[x + 1, y].Equals(0) && Tab[x + 2, y].Equals(0) && !Tab[x + 3, y].Equals(0) )
                            {
                                Tab[x, y] = Tab[x, y] * 2;
                                Tab[x + 3, y] = 0;
                                moved = true; ;
                            }
                        }

                        // Jeśli pole jest równe 0 to sprawdź czy da się coś "wstawić"
                        else if (Tab[x, y].Equals(0))
                        {
                            if (!Tab[x + 1, y].Equals(0))
                            {
                                Tab[x, y] = Tab[x + 1, y];
                                Tab[x + 1, y] = 0;
                            }
                            else if (x < 2&&!Tab[x + 2, y].Equals(0) )
                            {
                                Tab[x, y] = Tab[x + 2, y];
                                Tab[x + 2, y] = 0;
                            }
                            else if (x < 1&&!Tab[x + 3, y].Equals(0) )
                            {
                                Tab[x, y] = Tab[x + 3, y];
                                Tab[x + 3, y] = 0;
                            }
                        }
                    }
                if (moved == true)
                {
                    //cout << " Bylo " << k;
                    //getchar();
                    //getchar();
                }
                else
                {
                    //cout << " Nie bylo "<<k;
                    //getchar();
                    //getchar();
                    //generuj();
                }
            }

            //ruch w prawo - dół
            if (Move == 's' || Move == 'S')
            {
                for (int x = 3; x > 0; x--)
                    for (int y = 0; y < 4; y++)
                    {
                        if (Tab[x, y].Equals(0))
                        {
                            if (!Tab[x - 1, y].Equals(0))
                            {
                                Tab[x, y] = Tab[x - 1, y];
                                Tab[x - 1, y] = 0;
                                moved = true;
                            }
                            else if (x > 1&&!Tab[x - 2, y].Equals(0) )
                            {
                                Tab[x, y] = Tab[x - 2, y];
                                Tab[x - 2, y] = 0;
                                moved = true;
                            }
                            else if (x > 2&&!Tab[x - 3, y].Equals(0) )
                            {
                                Tab[x, y] = Tab[x - 3, y];
                                Tab[x - 3, y] = 0;
                                moved = true;
                            }
                        }

                        if (!Tab[x, y].Equals(0))
                        {
                            if (Tab[x, y] == Tab[x - 1, y]) //Sprawdzenie czy można połączyć sąsiadujące
                            {
                                Tab[x, y] = Tab[x, y] * 2;
                                Tab[x - 1, y] = 0;
                                moved = true;
                            }

                            // Czy można połączyć z odległym o 2
                            else if (x > 1&&Tab[x, y] == Tab[x - 2, y] && Tab[x - 1, y].Equals(0) )
                            {
                                Tab[x, y] = Tab[x, y] * 2;
                                Tab[x - 2, y] = 0;
                                moved = true;
                            }

                            // Czy można połączyć z odległym o 3
                            else if (x > 2&&Tab[x, y] == Tab[x - 3, y] && Tab[x - 1, y].Equals(0) && Tab[x - 2, y].Equals(0) )
                            {
                                Tab[x, y] = Tab[x, y] * 2;
                                Tab[x - 3, y] = 0;
                                moved = true;
                            }
                        }

                        // Jeśli pole jest równe 0 to sprawdź czy da się coś "wstawić"
                        else if (Tab[x, y].Equals(0))
                        {
                            if (!Tab[x - 1, y].Equals(0))
                            {
                                Tab[x, y] = Tab[x - 1, y];
                                Tab[x - 1, y] = 0;
                                moved = true;
                            }
                            else if (x > 1&&!Tab[x - 2, y].Equals(0) )
                            {
                                Tab[x, y] = Tab[x - 2, y];
                                Tab[x - 2, y] = 0;
                                moved = true;
                            }
                            else if (x > 2&&!Tab[x - 3, y].Equals(0) )
                            {
                                Tab[x, y] = Tab[x - 3, y];
                                Tab[x - 3, y] = 0;
                                moved = true;
                            }
                        }

                    }
                if (moved == true)
                {
                    //cout << " Bylo " << k;
                    //getchar();
                    //getchar();
                }
                else
                {
                    //cout << " Nie bylo "<<k;
                    //getchar();
                    //getchar();
                    //generuj();
                }
            }

            if (Move == 'r' || Move == 'R')
            {
                for (int i = 0; i < 4; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        Tab[i, j] = 0;
                    }
                }
            }



                bool chec = true;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (Tab[i, j] != 0) chec = false;
                }
            }
            if (moved || chec)
            {
                Random rand = new Random();
                uint a, b, c, d = 0;
                for (; d == 0;)
                {
                    a = Convert.ToUInt32(rand.Next(4));
                    b = Convert.ToUInt32(rand.Next(4));
                    c = Convert.ToUInt32(rand.Next(2));
                    if (Tab[a, b] == 0)
                    {
                        Tab[a, b] = (c + 1) * 2;
                        d = 1;
                    }
                }
                //cout << " Bylo " << k;
                //getchar();
                //getchar();
            }
            //*
            for (int x = 0; x < 4; x++)
            {
                for (int y = 0; y < 4; y++)
                    System.Console.WriteLine(Tab[x, y]);
            }//*/
            lines = File.ReadAllLines("D:\\plik.txt");
            for (int x1 = 0; x1 < 4; x1++)
            {
                for (int y2 = 0; y2 < 4; y2++)
                {
                    int k = 4 * x1 + y2;
                    lines[4 * x1 + y2] = Convert.ToString(Tab[x1,y2]);
                }
            }
            string path = @"D:\plik.txt";
            using (StreamWriter sw = File.CreateText(path))
            {
                for (int x1 = 0; x1 < 4; x1++)
                {
                    for (int y2 = 0; y2 < 4; y2++)
                    {
                        int k = 4 * x1 + y2;
                        //lines[4 * x1 + y2] = Convert.ToString(Tab[x1, y2]);
                        sw.WriteLine(Convert.ToString(Tab[x1, y2]));
                    }
                }
                
            }

            return Tab;
        }

        uint[,] Generate(uint[,] tab) //Generuje w losowym miejsu 2 lub 4
        {
            uint[,] vs = new uint[4, 4];
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    vs[i, j] = tab[i, j];
                    //System.Console.WriteLine(tab[i, j]);
                }
            }
            //tab = new uint[4, 4];
            vs = tab;
            Random rand = new Random();
            uint a, b, c, d = 0;
            for (; d == 0;)
            {
                a = Convert.ToUInt32(rand.Next(4));
                b = Convert.ToUInt32(rand.Next(4));
                c = Convert.ToUInt32(rand.Next(2));
                if (vs[a, b].Equals(0))
                {
                    vs[a, b] = (c + 1) * 2;
                    d = 1;
                }
            }
            return vs;
        }

        uint[,] Reset()
        {
            uint[,] Tab = new uint[4, 4];


            for (int x = 0; x < 4; x++)
            {
                for (int y = 0; y < 4; y++)
                    ;// Tab[x, y] = 0;
            }
            Tab = Generate(Tab);
            /*for (int x = 0; x < 4; x++)
            {
                for (int y = 0; y < 4; y++)
                    Return[x, y] = Tab[x, y].Return(Tab[x, y]);
            }*/
            return Tab;
        }

        bool Check(uint[,] Tab) // Czy można wykonać ruch?
        {
            // Czy jest jakieś 0:
            for (int x = 0; x < 4; x++)
            {
                for (int y = 0; y < 4; y++)
                    if (Tab[x, y].Equals(0))
                        return true;
            }

            // Czy można coś połączyć:
            for (int x = 0; x < 4; x++)
            {
                for (int y = 0; y < 4; y++)
                {
                    if (Tab[x, y] == Tab[x + 1, y] && x < 3)
                        return true;
                    else if (Tab[x, y] == Tab[x, y + 1] && y < 3)
                        return true;
                }
            }
            // Jeśli nie ma możliwości ruchu:
            return false;

        }


    }
}