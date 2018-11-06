namespace Torens_van_Hanoi
{
    partial class TorensvanHanoi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Disk1 = new System.Windows.Forms.Button();
            this.Disk2 = new System.Windows.Forms.Button();
            this.Disk3 = new System.Windows.Forms.Button();
            this.Disk5 = new System.Windows.Forms.Button();
            this.Disk4 = new System.Windows.Forms.Button();
            this.Disk6 = new System.Windows.Forms.Button();
            this.Disk7 = new System.Windows.Forms.Button();
            this.MoveCounter = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AllowDrop = true;
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Location = new System.Drawing.Point(159, 50);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(12, 197);
            this.panel1.TabIndex = 0;
            this.panel1.DragEnter += new System.Windows.Forms.DragEventHandler(this.panel1_DragEnter);
            // 
            // panel2
            // 
            this.panel2.AllowDrop = true;
            this.panel2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel2.Location = new System.Drawing.Point(409, 50);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(12, 197);
            this.panel2.TabIndex = 1;
            this.panel2.DragEnter += new System.Windows.Forms.DragEventHandler(this.panel1_DragEnter);
            // 
            // panel3
            // 
            this.panel3.AllowDrop = true;
            this.panel3.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel3.Location = new System.Drawing.Point(659, 50);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(12, 197);
            this.panel3.TabIndex = 1;
            this.panel3.DragEnter += new System.Windows.Forms.DragEventHandler(this.panel1_DragEnter);
            // 
            // Disk1
            // 
            this.Disk1.BackColor = System.Drawing.Color.SpringGreen;
            this.Disk1.ForeColor = System.Drawing.Color.SpringGreen;
            this.Disk1.Location = new System.Drawing.Point(139, 50);
            this.Disk1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Disk1.Name = "Disk1";
            this.Disk1.Size = new System.Drawing.Size(52, 25);
            this.Disk1.TabIndex = 2;
            this.Disk1.Text = "1";
            this.Disk1.UseVisualStyleBackColor = false;
            this.Disk1.Click += new System.EventHandler(this.Disk1_Click);
            this.Disk1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Disk1_MouseDown);
            // 
            // Disk2
            // 
            this.Disk2.BackColor = System.Drawing.Color.SpringGreen;
            this.Disk2.ForeColor = System.Drawing.Color.SpringGreen;
            this.Disk2.Location = new System.Drawing.Point(127, 80);
            this.Disk2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Disk2.Name = "Disk2";
            this.Disk2.Size = new System.Drawing.Size(76, 25);
            this.Disk2.TabIndex = 3;
            this.Disk2.Text = "2";
            this.Disk2.UseVisualStyleBackColor = false;
            this.Disk2.Click += new System.EventHandler(this.Disk2_Click);
            this.Disk2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Disk1_MouseDown);
            // 
            // Disk3
            // 
            this.Disk3.BackColor = System.Drawing.Color.SpringGreen;
            this.Disk3.ForeColor = System.Drawing.Color.SpringGreen;
            this.Disk3.Location = new System.Drawing.Point(115, 110);
            this.Disk3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Disk3.Name = "Disk3";
            this.Disk3.Size = new System.Drawing.Size(100, 25);
            this.Disk3.TabIndex = 4;
            this.Disk3.Text = "3";
            this.Disk3.UseVisualStyleBackColor = false;
            this.Disk3.Click += new System.EventHandler(this.Disk3_Click);
            this.Disk3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Disk1_MouseDown);
            // 
            // Disk5
            // 
            this.Disk5.BackColor = System.Drawing.Color.SpringGreen;
            this.Disk5.ForeColor = System.Drawing.Color.SpringGreen;
            this.Disk5.Location = new System.Drawing.Point(91, 169);
            this.Disk5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Disk5.Name = "Disk5";
            this.Disk5.Size = new System.Drawing.Size(148, 25);
            this.Disk5.TabIndex = 5;
            this.Disk5.Text = "5";
            this.Disk5.UseVisualStyleBackColor = false;
            this.Disk5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Disk1_MouseDown);
            // 
            // Disk4
            // 
            this.Disk4.BackColor = System.Drawing.Color.SpringGreen;
            this.Disk4.ForeColor = System.Drawing.Color.SpringGreen;
            this.Disk4.Location = new System.Drawing.Point(103, 139);
            this.Disk4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Disk4.Name = "Disk4";
            this.Disk4.Size = new System.Drawing.Size(124, 25);
            this.Disk4.TabIndex = 6;
            this.Disk4.Text = "4";
            this.Disk4.UseVisualStyleBackColor = false;
            this.Disk4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Disk1_MouseDown);
            // 
            // Disk6
            // 
            this.Disk6.BackColor = System.Drawing.Color.SpringGreen;
            this.Disk6.ForeColor = System.Drawing.Color.SpringGreen;
            this.Disk6.Location = new System.Drawing.Point(79, 198);
            this.Disk6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Disk6.Name = "Disk6";
            this.Disk6.Size = new System.Drawing.Size(172, 25);
            this.Disk6.TabIndex = 7;
            this.Disk6.Text = "6";
            this.Disk6.UseVisualStyleBackColor = false;
            this.Disk6.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Disk1_MouseDown);
            // 
            // Disk7
            // 
            this.Disk7.BackColor = System.Drawing.Color.SpringGreen;
            this.Disk7.ForeColor = System.Drawing.Color.SpringGreen;
            this.Disk7.Location = new System.Drawing.Point(67, 228);
            this.Disk7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Disk7.Name = "Disk7";
            this.Disk7.Size = new System.Drawing.Size(196, 25);
            this.Disk7.TabIndex = 8;
            this.Disk7.Text = "7";
            this.Disk7.UseVisualStyleBackColor = false;
            this.Disk7.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Disk1_MouseDown);
            // 
            // MoveCounter
            // 
            this.MoveCounter.AutoSize = true;
            this.MoveCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MoveCounter.Location = new System.Drawing.Point(13, 13);
            this.MoveCounter.Name = "MoveCounter";
            this.MoveCounter.Size = new System.Drawing.Size(0, 25);
            this.MoveCounter.TabIndex = 9;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel4.Location = new System.Drawing.Point(284, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1, 279);
            this.panel4.TabIndex = 10;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel5.Location = new System.Drawing.Point(534, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1, 279);
            this.panel5.TabIndex = 11;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // TorensvanHanoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 280);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.MoveCounter);
            this.Controls.Add(this.Disk7);
            this.Controls.Add(this.Disk6);
            this.Controls.Add(this.Disk4);
            this.Controls.Add(this.Disk5);
            this.Controls.Add(this.Disk3);
            this.Controls.Add(this.Disk1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Disk2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "TorensvanHanoi";
            this.Text = "Torens van Hanoi";
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TorensvanHanoi_MouseClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Disk3;
        private System.Windows.Forms.Button Disk2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button Disk1;
        private System.Windows.Forms.Button Disk5;
        private System.Windows.Forms.Button Disk4;
        private System.Windows.Forms.Button Disk6;
        private System.Windows.Forms.Button Disk7;
        private System.Windows.Forms.Label MoveCounter;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
    }
}

