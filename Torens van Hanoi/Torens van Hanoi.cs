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
        bool ValidMove = false;

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

        private void Disk1_Click(object sender, EventArgs e)
        {
        }

        private void Disk2_Click(object sender, EventArgs e)
        {
        }

        private void Disk3_Click(object sender, EventArgs e)
        {
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
        }

        private void Disk1_MouseDown(object sender, MouseEventArgs e) // Geld voor alle buttons.
        {
        }

        private void panel1_DragEnter(object sender, DragEventArgs e) // Geld voor alle panels.
        {
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
            if (SelectCoordinates.X <= panel4.Location.X)
            {
                if (Stack1.Count == 0)
                {
                    MessageBox.Show("No disks available!");
                    ValidMove = false;
                    ClickCount = 0;
                }
            }

            if (SelectCoordinates.X > panel4.Location.X && SelectCoordinates.X <= panel5.Location.X)
            {
                if (Stack2.Count == 0)
                {
                    MessageBox.Show("No disks available!");
                    ValidMove = false;
                    ClickCount = 0;
                }
            }

            if (SelectCoordinates.X > panel5.Location.X)
            {
                if (Stack3.Count == 0)
                {
                    MessageBox.Show("No disks available!");
                    ValidMove = false;
                    ClickCount = 0;
                }
            }           
        }

        void MoveValidation()
        {
            if (Stack1.Count == 0 && MoveCoordinates.X < 104 || Stack2.Count == 0 && MoveCoordinates.X >= 104 && MoveCoordinates.X < 292 || Stack3.Count == 0 && MoveCoordinates.X >= 292)
            {
                ValidMove = true;
            }

            for (int i = 0; i < Stacks.Length;i++)
            {
                for (int x = 0; x < Stacks.Length; x++)
                {
                    if (x != i)
                    {
                        try
                        {
                            if (Stacks[x].Count != 0 && Stacks[i].Peek() > Stacks[x].Peek())
                            {
                                MessageBox.Show("Cannot place bigger disk on smaller disk!");
                                ValidMove = false;
                                ClickCount = 0;
                                return;
                            }
                        }

                        catch
                        {
                        }                        
                    }
                }
            }            
        }

        void SelectDisk()
        {
            Coordinates = this.PointToClient(Cursor.Position);
            SelectCoordinates = Coordinates; //Dit moet elke select opnieuw bepaald worden.
            CheckForDisks();

            if (SelectCoordinates.X <= panel4.Location.X)
            {
                if (Stack1.Count > 0)
                {
                    ++ClickCount;
                    Temp = Stack1.Pop();
                }
            }

            if (SelectCoordinates.X > panel4.Location.X && SelectCoordinates.X <= panel5.Location.X)
            {
                if (Stack2.Count < 0)
                {
                    ++ClickCount;
                    Temp = Stack2.Pop();
                }
            }

            if (SelectCoordinates.X > panel5.Location.X)
            {
                if (Stack3.Count < 0)
                {
                    ++ClickCount;
                    Temp = Stack3.Pop();
                }                                
            }
        }

        void MoveDisk()
        {
            Coordinates = this.PointToClient(Cursor.Position);
            MoveCoordinates = Coordinates; //Dit moet elke move opnieuw bepaald worden.
            MoveValidation();

            if (ValidMove == true)
            {
                ++Count;
                MoveCounter.Text = "Moves: " + Count.ToString();

                if (MoveCoordinates.X <= panel4.Location.X && ValidMove == true)
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
                    ClickCount = 0;
                    ValidMove = false;
                }

                if (MoveCoordinates.X > panel4.Location.X && MoveCoordinates.X <= panel5.Location.X && ValidMove == true)
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
                    ClickCount = 0;
                    ValidMove = false;
                }

                if (MoveCoordinates.X > panel5.Location.X && ValidMove == true)
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
                    ClickCount = 0;
                    ValidMove = false;
                }
            }

            if (Stack3.Count == 8)
            {
                MessageBox.Show("Congratulations! You won!");
            }
        }        
    }
}
