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

        public TorensvanHanoi()
        {
            InitializeComponent();
            this.Capture = true;
            MoveCounter.Text = "Moves: " + Count.ToString();
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
            
            void MoveDisk()
            {
                ++Count;
                MoveCounter.Text = "Moves: " + Count.ToString();
                if (Coordinates.X <= 104)
                {
                    //Disk1.Location = new Point(104, 41);
                }

                if (Coordinates.X > 104 && Coordinates.X <= 292)
                {
                    Disk1.Location = new Point(292, 100);
                }

                if (Coordinates.X > 292 && Coordinates.X <= 480)
                {
                    Disk1.Location = new Point(480, 198);
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

            if (Coordinates.X < panel4.Location.X)
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
            }
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}
