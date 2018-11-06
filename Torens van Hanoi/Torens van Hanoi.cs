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
        int ClickCount = 0;
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
            Coordinates = this.PointToClient(Cursor.Position);

            if (ClickCount == 0)
            {
                SelectDisk();
            }
        }

        void AddToStack()
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

            if (Disk7.Location.X > 104 && Disk7.Location.X <= 292)
            {
                Stack2.Push(Convert.ToInt32(Disk7.Text));
            }

            if (Disk6.Location.X > 104 && Disk6.Location.X <= 292)
            {
                Stack2.Push(Convert.ToInt32(Disk6.Text));
            }

            if (Disk5.Location.X > 104 && Disk5.Location.X <= 292)
            {
                Stack2.Push(Convert.ToInt32(Disk5.Text));
            }

            if (Disk4.Location.X > 104 && Disk4.Location.X <= 292)
            {
                Stack2.Push(Convert.ToInt32(Disk4.Text));
            }

            if (Disk3.Location.X > 104 && Disk3.Location.X <= 292)
            {
                Stack2.Push(Convert.ToInt32(Disk3.Text));
            }

            if (Disk2.Location.X > 104 && Disk2.Location.X <= 292)
            {
                Stack2.Push(Convert.ToInt32(Disk2.Text));
            }

            if (Disk1.Location.X > 104 && Disk1.Location.X <= 292)
            {
                Stack2.Push(Convert.ToInt32(Disk1.Text));
            }

            if (Disk7.Location.X > 292)
            {
                Stack3.Push(Convert.ToInt32(Disk7.Text));
            }

            if (Disk6.Location.X > 292)
            {
                Stack3.Push(Convert.ToInt32(Disk6.Text));
            }

            if (Disk5.Location.X > 292)
            {
                Stack3.Push(Convert.ToInt32(Disk5.Text));
            }

            if (Disk4.Location.X > 292)
            {
                Stack3.Push(Convert.ToInt32(Disk4.Text));
            }

            if (Disk3.Location.X > 292)
            {
                Stack3.Push(Convert.ToInt32(Disk3.Text));
            }

            if (Disk2.Location.X > 292)
            {
                Stack3.Push(Convert.ToInt32(Disk2.Text));
            }

            if (Disk1.Location.X > 292)
            {
                Stack3.Push(Convert.ToInt32(Disk1.Text));
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

        void SelectDisk()
        {
            if (Coordinates.X <= panel4.Location.X)
            {
                if (Stack1.Count == 0)
                {
                    MessageBox.Show("No disks available!");
                }

                ++ClickCount;

                if (Stack1.Count > 0)
                {
                    Temp = Stack1.Pop();

                    if (ClickCount == 1)
                    {                        
                        MoveDisk();
                    }
                }
            }

            if (Coordinates.X > panel4.Location.X && Coordinates.X <= panel5.Location.X)
            {
                if (Stack2.Count == 0)
                {
                    MessageBox.Show("No disks available!");
                }

                ++ClickCount;

                if (Stack2.Count < 0)
                {
                    Temp = Stack2.Pop();

                    if (ClickCount == 1)
                    {
                        MoveDisk();
                    }
                }

                if (Coordinates.X > panel5.Location.X)
                {
                    if (Stack3.Count == 0)
                    {
                        MessageBox.Show("No disks available!");
                    }

                    ++ClickCount;

                    if (Stack3.Count < 0)
                    {
                        Temp = Stack2.Pop();

                        if (ClickCount == 1)
                        {
                            MoveDisk();
                        }
                    }
                }                
            }
        }

        void MoveDisk()
        {
            Coordinates2 = this.PointToClient(Cursor.Position);
            MoveValidation();

            if (ValidMove == true)
            {
                ++Count;
            }

            MoveCounter.Text = "Moves: " + Count.ToString();

            if (Coordinates2.X <= panel4.Location.X)
            {
                Stack1.Push(Temp);
            }

            if (Coordinates2.X > panel4.Location.X && Coordinates.X <= panel5.Location.X)
            {
                Stack2.Push(Temp);
            }

            if (Coordinates2.X > panel5.Location.X)
            {
                Stack3.Push(Temp);
            }

            ClickCount = 0;
        }                
    }
}
