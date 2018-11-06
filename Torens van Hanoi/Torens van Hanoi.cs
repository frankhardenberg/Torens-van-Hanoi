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
        Point Coordinates2;
        int Count = 0;
        int Temp;
        Stack<int> Stack1 = new Stack<int>();
        Stack<int> Stack2 = new Stack<int>();
        Stack<int> Stack3 = new Stack<int>();
        bool ValidMove = false;

        public TorensvanHanoi()
        {
            InitializeComponent();
            this.Capture = true;
            MoveCounter.Text = "Moves: " + Count.ToString();
            AddToStack();
        }

        void AddToStack()
        {
            if (Disk1.Location.X <= 104)
            {
                Stack1.Push(Convert.ToInt32(Disk1.Text));
            }

            if (Disk2.Location.X <= 104)
            {
                Stack1.Push(Convert.ToInt32(Disk2.Text));
            }

            if (Disk3.Location.X <= 104)
            {
                Stack1.Push(Convert.ToInt32(Disk3.Text));
            }

            if (Disk4.Location.X <= 104)
            {
                Stack1.Push(Convert.ToInt32(Disk4.Text));
            }

            if (Disk5.Location.X <= 104)
            {
                Stack1.Push(Convert.ToInt32(Disk5.Text));
            }

            if (Disk6.Location.X <= 104)
            {
                Stack1.Push(Convert.ToInt32(Disk6.Text));
            }

            if (Disk7.Location.X <= 104)
            {
                Stack1.Push(Convert.ToInt32(Disk7.Text));            
            }

            if (Disk1.Location.X > 104 && Disk1.Location.X <= 292)
            {
                Stack2.Push(Convert.ToInt32(Disk1.Text));
            }

            if (Disk2.Location.X > 104 && Disk2.Location.X <= 292)
            {
                Stack2.Push(Convert.ToInt32(Disk2.Text));
            }

            if (Disk3.Location.X > 104 && Disk3.Location.X <= 292)
            {
                Stack2.Push(Convert.ToInt32(Disk3.Text));
            }

            if (Disk4.Location.X > 104 && Disk4.Location.X <= 292)
            {
                Stack2.Push(Convert.ToInt32(Disk4.Text));
            }

            if (Disk5.Location.X > 104 && Disk5.Location.X <= 292)
            {
                Stack2.Push(Convert.ToInt32(Disk5.Text));
            }

            if (Disk6.Location.X > 104 && Disk6.Location.X <= 292)
            {
                Stack2.Push(Convert.ToInt32(Disk6.Text));
            }

            if (Disk7.Location.X > 104 && Disk7.Location.X <= 292)
            {
                Stack2.Push(Convert.ToInt32(Disk7.Text));
            }

            if (Disk1.Location.X > 292)
            {
                Stack3.Push(Convert.ToInt32(Disk1.Text));
            }

            if (Disk2.Location.X > 292)
            {
                Stack3.Push(Convert.ToInt32(Disk2.Text));
            }

            if (Disk3.Location.X > 292)
            {
                Stack3.Push(Convert.ToInt32(Disk3.Text));
            }

            if (Disk4.Location.X > 292)
            {
                Stack3.Push(Convert.ToInt32(Disk4.Text));
            }

            if (Disk5.Location.X > 292)
            {
                Stack3.Push(Convert.ToInt32(Disk5.Text));
            }

            if (Disk6.Location.X > 292)
            {
                Stack3.Push(Convert.ToInt32(Disk6.Text));
            }

            if (Disk7.Location.X > 292)
            {
                Stack3.Push(Convert.ToInt32(Disk7.Text));
            }
        }

        void MoveValidation()
        {
            if (Stack1.Count == 0 || Stack2.Count == 0 || Stack3.Count == 0)
            {
                ValidMove = true;
            }

            if (Stack1.Count > 0 && Stack2.Count > 0 || Stack1.Count > 0 && Stack3.Count > 0)
            {
                if (Stack1.Peek() > Stack2.Peek())
                {
                    MessageBox.Show("Cannot place bigger disk on smaller disk!");
                }

                if (Stack1.Peek() > Stack3.Peek())
                {
                    MessageBox.Show("Cannot place bigger disk on smaller disk!");
                }
            }

            if (Stack2.Count > 0 && Stack1.Count > 0 || Stack2.Count > 0 && Stack3.Count > 0)
            {
                if (Stack2.Peek() > Stack1.Peek())
                {
                    MessageBox.Show("Cannot place bigger disk on smaller disk!");
                }

                if (Stack2.Peek() > Stack3.Peek())
                {
                    MessageBox.Show("Cannot place bigger disk on smaller disk!");
                }
            }

            if (Stack3.Count > 0 && Stack1.Count > 0 || Stack3.Count > 0 && Stack2.Count > 0)
            {
                if (Stack3.Peek() > Stack1.Peek())
                {
                    MessageBox.Show("Cannot place bigger disk on smaller disk!");
                }

                if (Stack3.Peek() > Stack2.Peek())
                {
                    MessageBox.Show("Cannot place bigger disk on smaller disk!");
                }
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

        private void Disk1_MouseDown(object sender, MouseEventArgs e) // Geld voor alle buttons.
        {
            
        }

        private void panel1_DragEnter(object sender, DragEventArgs e) // Geld voor alle panels.
        {

        }

        private void TorensvanHanoi_MouseClick(object sender, MouseEventArgs e)
        {
            this.Activate();
            Coordinates = this.PointToClient(Cursor.Position);
            SelectDisk();

            void SelectDisk()
            {
                int ClickCount = 0;

                if (Coordinates.X <= 104)
                {
                    if (Stack1.Count == 0)
                    {
                        MessageBox.Show("No disks available!");
                    }

                    if (Stack1.Count > 0)
                    {
                        ++ClickCount;
                        Temp = Stack1.Pop();

                        if (ClickCount == 1)
                        {
                            Coordinates2 = this.PointToClient(Cursor.Position);
                            MoveDisk();
                        }
                    }
                }

                if (Coordinates.X > 104 && Coordinates.X <= 292)
                {
                    if (Stack2.Count == 0)
                    {
                        MessageBox.Show("No disks available!");
                    }

                    if (Stack2.Count < 0)
                    {
                        ++ClickCount;
                        Temp = Stack2.Pop();

                        if (ClickCount == 1)
                        {
                            Coordinates2 = this.PointToClient(Cursor.Position);
                            MoveDisk();
                        }
                    }                    
                }

                if (Coordinates.X > 292)
                {
                    if (Stack3.Count == 0)
                    {
                        MessageBox.Show("No disks available!");
                    }

                    if (Stack3.Count < 0)
                    {
                        ++ClickCount;
                        Temp = Stack2.Pop();

                        if (ClickCount == 1)
                        {
                            Coordinates2 = this.PointToClient(Cursor.Position);
                            MoveDisk();
                        }
                    }
                }
            }

            void MoveDisk()
            {                
                MoveValidation();

                if (ValidMove == true)
                {
                    ++Count;
                }
                
                MoveCounter.Text = "Moves: " + Count.ToString();

                if (Coordinates.X <= 104)
                {
                    Stack1.Push(Temp);
                }

                if (Coordinates.X > 104 && Coordinates.X <= 292)
                {
                    Stack2.Push(Temp);
                }

                if (Coordinates.X > 292 && Coordinates.X <= 480)
                {
                    Stack3.Push(Temp);
                }
            }

            /*if (Coordinates.X < panel1.Location.X)
            {
                if (Disk1.Location.X == 292)
                {
                    Disk1.Location = Disk1.Location;
                }

                else
                {
                    Disk1.Left -= 188;
                }
            }

            if (Coordinates.X > panel1.Location.X && Coordinates.X < panel2.Location.X)
            {
                if (Disk1.Location.X == 480)
                {
                    Disk1.Left += 0;
                }

                else
                {
                    Disk1.Left += 188;
                }                
            }

            if (Coordinates.X > panel2.Location.X && Coordinates.X < panel3.Location.X || Coordinates.X > panel2.Location.X && Coordinates.X > panel3.Location.X)
            {
                if (Disk1.Location.X == 668)
                {
                    Disk1.Left += 0;
                }

                else
                {
                    Disk1.Left += 188;
                }                
            }

            if (Coordinates.X > panel3.Location.X)
            {
                if (Disk1.Location.X == 668)
                {
                    Disk1.Left += 0;
                }

                else
                {
                    Disk1.Left += 188;
                }
            }*/

            /*if (Coordinates.X < panel4.Location.X)
            {
                Disk1.Location = Disk1.Location;
            }

            if (Coordinates.X > panel4.Location.X && Coordinates.X < panel5.Location.X)
            {
                int i = 0;

                if (i == 0)
                {
                    MoveDisk();
                    i++;
                }
            }

            if (Coordinates.X > panel5.Location.X)
            {
                int i = 0;

                if (Disk1.Location.X == 480)
                {
                    
                }

                else
                {
                    for (i = 0; i < 2; i++)
                    {
                        MoveDisk();
                    }

                    if (i >= 2)
                    {
                        
                    }
                }                
            }*/
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}
