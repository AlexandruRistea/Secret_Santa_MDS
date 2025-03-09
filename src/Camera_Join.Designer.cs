namespace WindowsFormsApp1
{
    partial class Camera_Join
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
            this.Add_room = new System.Windows.Forms.TextBox();
            this.Write_room = new System.Windows.Forms.TextBox();
            this.Join_the_room = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Add_room
            // 
            this.Add_room.BackColor = System.Drawing.Color.Peru;
            this.Add_room.Cursor = System.Windows.Forms.Cursors.Default;
            this.Add_room.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_room.Location = new System.Drawing.Point(513, 178);
            this.Add_room.Multiline = true;
            this.Add_room.Name = "Add_room";
            this.Add_room.ReadOnly = true;
            this.Add_room.Size = new System.Drawing.Size(285, 109);
            this.Add_room.TabIndex = 0;
            this.Add_room.Text = "Introduceti Codul Camerei:";
            this.Add_room.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Write_room
            // 
            this.Write_room.BackColor = System.Drawing.Color.Peru;
            this.Write_room.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Write_room.Location = new System.Drawing.Point(513, 364);
            this.Write_room.Multiline = true;
            this.Write_room.Name = "Write_room";
            this.Write_room.Size = new System.Drawing.Size(284, 85);
            this.Write_room.TabIndex = 1;
            this.Write_room.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Join_the_room
            // 
            this.Join_the_room.BackColor = System.Drawing.Color.IndianRed;
            this.Join_the_room.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Join_the_room.Location = new System.Drawing.Point(513, 536);
            this.Join_the_room.Name = "Join_the_room";
            this.Join_the_room.Size = new System.Drawing.Size(284, 95);
            this.Join_the_room.TabIndex = 2;
            this.Join_the_room.Text = "Intra!";
            this.Join_the_room.UseVisualStyleBackColor = false;
            this.Join_the_room.Click += new System.EventHandler(this.Join_the_room_Click);
            // 
            // Camera_Join
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.XMAS_Corona;
            this.ClientSize = new System.Drawing.Size(1313, 768);
            this.Controls.Add(this.Join_the_room);
            this.Controls.Add(this.Write_room);
            this.Controls.Add(this.Add_room);
            this.Name = "Camera_Join";
            this.Text = "Camera_Join";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Camera_Join_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Add_room;
        private System.Windows.Forms.TextBox Write_room;
        private System.Windows.Forms.Button Join_the_room;
    }
}