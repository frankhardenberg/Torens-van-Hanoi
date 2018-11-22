using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Torens_van_Hanoi
{
    public partial class TorensvanHanoi : Form
    {
        Point Coordinates;
        Point SelectCoordinates;
        Point MoveCoordinates;
        int Count = 0;
        int ClickCount = 0;
        int Temp;
        Stack<int> Stack1 = new Stack<int>();
        Stack<int> Stack2 = new Stack<int>();
        Stack<int> Stack3 = new Stack<int>();
        Stack<int>[] Stacks;
        bool ValidMove = true;

        public TorensvanHanoi()
        {
            InitializeComponent();
            this.Capture = true;
            MoveCounter.Text = "Moves: " + Count.ToString();
            Stacks = new Stack<int>[] { Stack1, Stack2, Stack3 };
            StartStack();           
        }        

        void StartStack()
        {
            if (Disk7.Location.X <= 104)
            {
                Stack1.Push(Convert.ToInt32(Disk7.Text));
            }

            if (Disk6.Location.X <= 104)
            {
                Stack1.Push(Convert.ToInt32(Disk6.Text));
            }

            if (Disk5.Location.X <= 104)
            {
                Stack1.Push(Convert.ToInt32(Disk5.Text));
            }

            if (Disk4.Location.X <= 104)
            {
                Stack1.Push(Convert.ToInt32(Disk4.Text));
            }

            if (Disk3.Location.X <= 104)
            {
                Stack1.Push(Convert.ToInt32(Disk3.Text));
            }

            if (Disk2.Location.X <= 104)
            {
                Stack1.Push(Convert.ToInt32(Disk2.Text));
            }

            if (Disk1.Location.X <= 104)
            {
                Stack1.Push(Convert.ToInt32(Disk1.Text));
            }
        }        
        
        private void TorensvanHanoi_MouseClick(object sender, MouseEventArgs e)
        {
            this.Activate();

            if (ClickCount == 0)
            {
                SelectDisk();
            }

            else
            {
                MoveDisk();
            }
        }
        
        void CheckForDisks()
        {
            if (SelectCoordinates.X <= panel4.Location.X && Stack1.Count == 0)
            {
                MessageBox.Show("No disks available!");
                ClickCount = -1;
            }

            if (SelectCoordinates.X > panel4.Location.X && SelectCoordinates.X <= panel5.Location.X && Stack2.Count == 0)
            {
                MessageBox.Show("No disks available!");
                ClickCount = -1;                
            }

            if (SelectCoordinates.X > panel5.Location.X && Stack3.Count == 0)
            {
                MessageBox.Show("No disks available!");
                ClickCount = -1;
            }

            UpdateStacks();
        }

        void UpdateStacks()
        {
            Stacks = new Stack<int>[] { Stack1, Stack2, Stack3 };
        }

        void MoveValidation()
        {
            if (Stack1.Count > 7 || Stack2.Count > 7) //Deze even checken op het eind of die klopt.
            {
                ValidMove = false;
                MessageBox.Show("There is only place for 7 disks on each tower!");
            }

            if (MoveCoordinates.X >= panel4.Location.X && MoveCoordinates.X < panel5.Location.X)
            {
                if (SelectCoordinates.X < panel4.Location.X)
                {
                    if (Stack2.Count > 0 && Stack1.Count > 0)
                    {
                        if (Stack1.Peek() > Stack2.Peek())
                        {
                            MessageBox.Show("Cannot place bigger disk on smaller disk!");
                            ClickCount = 0;
                            ValidMove = false;
                        }
                    }
                }

                else
                {
                    if (Stack2.Count > 0 && Stack3.Count > 0)
                    {
                        if (Stack3.Peek() > Stack2.Peek())
                        {
                            MessageBox.Show("Cannot place bigger disk on smaller disk!");
                            ClickCount = 0;
                            ValidMove = false;
                        }
                    }
                }
            }

            if (MoveCoordinates.X < panel4.Location.X)
            {
                if (SelectCoordinates.X >= panel5.Location.X)
                {
                    if (Stack1.Count > 0 && Stack3.Count > 0)
                    {
                        if (Stack3.Peek() > Stack1.Peek())
                        {
                            MessageBox.Show("Cannot place bigger disk on smaller disk!");
                            ClickCount = 0;
                            ValidMove = false;
                        }
                    }
                }

                else
                {
                    if (Stack1.Count > 0 && Stack2.Count > 0)
                    {
                        if (Stack2.Peek() > Stack1.Peek())
                        {
                            MessageBox.Show("Cannot place bigger disk on smaller disk!");
                            ClickCount = 0;
                            ValidMove = false;
                        }
                    }
                }
            }

            if (MoveCoordinates.X >= panel5.Location.X)
            {
                if (SelectCoordinates.X < panel5.Location.X && SelectCoordinates.X >= panel4.Location.X)
                {
                    if (Stack3.Count > 0 && Stack2.Count > 0)
                    {
                        if (Stack2.Peek() > Stack3.Peek())
                        {
                            MessageBox.Show("Cannot place bigger disk on smaller disk!");
                            ClickCount = 0;
                            ValidMove = false;                            
                        }
                    }
                }

                else
                {
                    if (Stack3.Count > 0 && Stack1.Count > 0)
                    {
                        if (Stack1.Peek() > Stack3.Peek())
                        {
                            MessageBox.Show("Cannot place bigger disk on smaller disk!");
                            ClickCount = 0;
                            ValidMove = false;
                        }
                    }
                }    
            }

            UpdateStacks();
        }

        void SelectDisk()
        {
            Coordinates = this.PointToClient(Cursor.Position);
            Console.WriteLine(Coordinates + "SelectDisk");
            SelectCoordinates = Coordinates;
            CheckForDisks();

            if (SelectCoordinates.X <= panel4.Location.X)
            {
                if (Stack1.Count > 0)
                {
                    Temp = Stack1.Pop();
                    UpdateStacks();
                }
            }

            if (SelectCoordinates.X > panel4.Location.X && SelectCoordinates.X <= panel5.Location.X)
            {
                if (Stack2.Count > 0)
                {
                    Temp = Stack2.Pop();
                    UpdateStacks();
                }
            }

            if (SelectCoordinates.X > panel5.Location.X)
            {
                if (Stack3.Count > 0)
                {
                    Temp = Stack3.Pop();
                    UpdateStacks();
                }                                
            }

            ClickCount++;
        }

        void MoveDisk()
        {
            Coordinates = this.PointToClient(Cursor.Position);
            Console.WriteLine(Coordinates + "MoveDisk");
            MoveCoordinates = Coordinates;
            MoveValidation();

            if (ValidMove == true)
            {
                ++Count;
                MoveCounter.Text = "Moves: " + Count.ToString();

                if (MoveCoordinates.X <= panel4.Location.X)
                {
                    int Height = 185 - (Stack1.Count * 24);
                    int Width = 113 - (Temp * 9);

                    for (int i = 0; i < 8; i++)
                    {
                        if (Stack1.Count == i)
                        {
                            switch (Temp)
                            {
                                case 1:
                                    Disk1.Location = new Point(Width, Height);
                                    break;
                                case 2:
                                    Disk2.Location = new Point(Width, Height);
                                    break;
                                case 3:
                                    Disk3.Location = new Point(Width, Height);
                                    break;
                                case 4:
                                    Disk4.Location = new Point(Width, Height);
                                    break;
                                case 5:
                                    Disk5.Location = new Point(Width, Height);
                                    break;
                                case 6:
                                    Disk6.Location = new Point(Width, Height);
                                    break;
                                case 7:
                                    Disk7.Location = new Point(Width, Height);
                                    break;
                            }
                        }
                    }                    
                    
                    Stack1.Push(Temp);
                    UpdateStacks();
                    ClickCount = 0;
                }

                if (MoveCoordinates.X > panel4.Location.X && MoveCoordinates.X <= panel5.Location.X)
                {
                    int Height = 185 - (Stack2.Count * 24);
                    int Width = 301 - (Temp * 9);

                    for (int i = 0; i < 8; i++)
                    {
                        if (Stack2.Count == i)
                        {
                            switch (Temp)
                            {
                                case 1:
                                    Disk1.Location = new Point(Width, Height);
                                    break;
                                case 2:
                                    Disk2.Location = new Point(Width, Height);
                                    break;
                                case 3:
                                    Disk3.Location = new Point(Width, Height);
                                    break;
                                case 4:
                                    Disk4.Location = new Point(Width, Height);
                                    break;
                                case 5:
                                    Disk5.Location = new Point(Width, Height);
                                    break;
                                case 6:
                                    Disk6.Location = new Point(Width, Height);
                                    break;
                                case 7:
                                    Disk7.Location = new Point(Width, Height);
                                    break;
                            }
                        }
                    }
                    
                    Stack2.Push(Temp);
                    UpdateStacks();
                    ClickCount = 0;
                }

                if (MoveCoordinates.X > panel5.Location.X)
                {
                    int Height = 185 - (Stack3.Count * 24);
                    int Width = 489 - (Temp * 9);

                    for (int i = 0; i < 8; i++)
                    {
                        if (Stack3.Count == i)
                        {
                            switch (Temp)
                            {
                                case 1:
                                    Disk1.Location = new Point(Width, Height);                                                                      
                                    break;
                                case 2:
                                    Disk2.Location = new Point(Width, Height);
                                    break;
                                case 3:
                                    Disk3.Location = new Point(Width, Height);
                                    break;
                                case 4:
                                    Disk4.Location = new Point(Width, Height);
                                    break;
                                case 5:
                                    Disk5.Location = new Point(Width, Height);
                                    break;
                                case 6:
                                    Disk6.Location = new Point(Width, Height);
                                    break;
                                case 7:
                                    Disk7.Location = new Point(Width, Height);
                                    break;
                            }
                        }
                    }                    

                    Stack3.Push(Temp);
                    UpdateStacks();
                    ClickCount = 0;
                }
            }

            if (Stack3.Count == 7)
            {
                MessageBox.Show("Congratulations! You won!");
            }            
        }        
    }
}
// Als no disks available melding is geweest gaat die geen buttons meer verplaatsen.
// Soms bij de middelste panel geeft die onterecht cannot place bigger disk on smaller disk en verplaatst die ook geen buttons meer.