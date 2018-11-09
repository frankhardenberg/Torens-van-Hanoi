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
            StartStack();
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

            else
            {
                MoveDisk();
            }
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

        void UpdateStack()
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
            if (Stack1.Count == 0 && Coordinates.X < 104 || Stack2.Count == 0 && Coordinates.X >= 104 && Coordinates.X < 292 || Stack3.Count == 0 && Coordinates.X >= 292)
            {
                ValidMove = true;
            }

            if (Stack1.Count != 0 && Stack2.Count != 0)
            {
                try
                {
                    if (Stack1.Peek() == 0 || Stack2.Peek() == 0)
                    {
                        MessageBox.Show("No disks available!");
                    }
                }

                catch (InvalidOperationException)
                {

                }

                if (Stack1.Peek() > Stack2.Peek())
                {
                    MessageBox.Show("Cannot place bigger disk on smaller disk!");
                    ClickCount = 0;
                    return;
                }                
            }

            else if (Stack1.Count != 0 && Stack3.Count != 0)
            {
                try
                {                    
                    if (Stack1.Peek() == 0 || Stack3.Peek() == 0)
                    {
                        MessageBox.Show("No disks available!");
                    }
                }

                catch (InvalidOperationException)
                {

                }

                if (Stack1.Peek() > Stack3.Peek())
                {
                    MessageBox.Show("Cannot place bigger disk on smaller disk!");
                    ClickCount = 0;
                    return;
                }
            }

            if (Stack2.Count != 0 && Stack1.Count != 0)
            {
                try
                {
                    if (Stack2.Peek() == 0 || Stack1.Peek() == 0)
                    {
                        MessageBox.Show("No disks available!");
                    }
                }
                catch (InvalidOperationException)
                {

                }

                if (Stack2.Peek() > Stack1.Peek())
                {
                    MessageBox.Show("Cannot place bigger disk on smaller disk!");
                    ClickCount = 0;
                    return;
                }
            }

            else if (Stack2.Count != 0 && Stack3.Count != 0)
            {
                try
                {
                    if (Stack2.Peek() == 0 || Stack3.Peek() == 0)
                    {

                    }
                }
                catch (InvalidOperationException)
                {

                }

                if (Stack2.Peek() > Stack3.Peek())
                {
                    MessageBox.Show("Cannot place bigger disk on smaller disk!");
                    ClickCount = 0;
                    return;
                }
            }

            if (Stack3.Count != 0 && Stack1.Count != 0)
            {
                try
                {
                    if (Stack3.Peek() == 0 || Stack1.Peek() == 0)
                    {

                    }
                }
                catch (InvalidOperationException)
                {

                }

                if (Stack3.Peek() > Stack1.Peek())
                {
                    MessageBox.Show("Cannot place bigger disk on smaller disk!");
                    ClickCount = 0;
                    return;
                }
            }

            else if (Stack3.Count != 0 && Stack2.Count != 0)
            {
                try
                {
                    if (Stack3.Peek() == 0 || Stack2.Peek() == 0)
                    {

                    }
                }
                catch (InvalidOperationException)
                {

                }

                if (Stack3.Peek() > Stack2.Peek())
                {
                    MessageBox.Show("Cannot place bigger disk on smaller disk!");
                    ClickCount = 0;
                    return;
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

                if (Stack1.Count > 0)
                {
                    ++ClickCount;
                    Temp = Stack1.Pop();
                }
            }

            if (Coordinates.X > panel4.Location.X && Coordinates.X <= panel5.Location.X)
            {
                if (Stack2.Count == 0)
                {
                    MessageBox.Show("No disks available!");
                }                

                if (Stack2.Count < 0)
                {
                    ++ClickCount;
                    Temp = Stack2.Pop();
                }
            }

            if (Coordinates.X > panel5.Location.X)
            {
                if (Stack3.Count == 0)
                {
                    MessageBox.Show("No disks available!");
                }                

                if (Stack3.Count < 0)
                {
                    ++ClickCount;
                    Temp = Stack3.Pop();
                }                                
            }
        }

        void MoveDisk()
        {
            MoveValidation();

            if (ValidMove == true)
            {
                ++Count;
                MoveCounter.Text = "Moves: " + Count.ToString();

                if (Coordinates.X <= panel4.Location.X && ValidMove == true)
                {
                    int Height = 185 - (Stack2.Count * 24);
                    int Width = 113 - (Temp * 9);

                    if (Stack1.Count == 0)
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

                    if (Stack1.Count == 1)
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

                    if (Stack1.Count == 2)
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

                    if (Stack1.Count == 3)
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

                    if (Stack1.Count == 4)
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

                    if (Stack1.Count == 5)
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

                    if (Stack1.Count == 6)
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

                    Stack1.Push(Temp);
                }

                if (Coordinates.X > panel4.Location.X && Coordinates.X <= panel5.Location.X && ValidMove == true)
                {
                    int Height = 209 - (Temp * 24);
                    int Width = 301 - (Temp * 9);

                    if (Stack2.Count == 0)
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

                    if (Stack2.Count == 1)
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

                    if (Stack2.Count == 2)
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

                    if (Stack2.Count == 3)
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

                    if (Stack2.Count == 4)
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

                    if (Stack2.Count == 5)
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

                    if (Stack2.Count == 6)
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

                    Stack2.Push(Temp);
                }

                if (Coordinates.X > panel5.Location.X && ValidMove == true)
                {
                    int Height = 185 - (Stack3.Count * 24);
                    int Width = 489 - (Temp * 9);

                    if (Stack3.Count == 0)
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

                    if (Stack3.Count == 1)
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

                    if (Stack3.Count == 2)
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

                    if (Stack3.Count == 3)
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

                    if (Stack3.Count == 4)
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

                    if (Stack3.Count == 5)
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

                    if (Stack3.Count == 6)
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

                    Stack3.Push(Temp);
                    ClickCount = 0;
                    ValidMove = false;
                }
            }
        }        
    }
}
