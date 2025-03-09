namespace WindowsFormsApp1
{
    partial class Main_Menu
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
            this.Create_Room = new System.Windows.Forms.Button();
            this.Join_Room = new System.Windows.Forms.Button();
            this.Nume_Util = new System.Windows.Forms.TextBox();
            this.Text_Nume = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Create_Room
            // 
            this.Create_Room.BackColor = System.Drawing.Color.OliveDrab;
            this.Create_Room.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Create_Room.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Create_Room.Location = new System.Drawing.Point(551, 438);
            this.Create_Room.Name = "Create_Room";
            this.Create_Room.Size = new System.Drawing.Size(210, 119);
            this.Create_Room.TabIndex = 0;
            this.Create_Room.Text = "Camera Noua";
            this.Create_Room.UseVisualStyleBackColor = false;
            this.Create_Room.Click += new System.EventHandler(this.Create_Room_Click);
            // 
            // Join_Room
            // 
            this.Join_Room.BackColor = System.Drawing.Color.Plum;
            this.Join_Room.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Join_Room.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Join_Room.Location = new System.Drawing.Point(551, 587);
            this.Join_Room.Name = "Join_Room";
            this.Join_Room.Size = new System.Drawing.Size(210, 119);
            this.Join_Room.TabIndex = 1;
            this.Join_Room.Text = "Alatura-te Unei Camere";
            this.Join_Room.UseVisualStyleBackColor = false;
            this.Join_Room.Click += new System.EventHandler(this.Join_Room_Click);
            // 
            // Nume_Util
            // 
            this.Nume_Util.BackColor = System.Drawing.SystemColors.Info;
            this.Nume_Util.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nume_Util.Location = new System.Drawing.Point(551, 338);
            this.Nume_Util.Multiline = true;
            this.Nume_Util.Name = "Nume_Util";
            this.Nume_Util.Size = new System.Drawing.Size(210, 64);
            this.Nume_Util.TabIndex = 2;
            // 
            // Text_Nume
            // 
            this.Text_Nume.BackColor = System.Drawing.Color.DarkOrange;
            this.Text_Nume.Cursor = System.Windows.Forms.Cursors.Default;
            this.Text_Nume.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Text_Nume.Location = new System.Drawing.Point(551, 292);
            this.Text_Nume.Multiline = true;
            this.Text_Nume.Name = "Text_Nume";
            this.Text_Nume.ReadOnly = true;
            this.Text_Nume.Size = new System.Drawing.Size(210, 26);
            this.Text_Nume.TabIndex = 3;
            this.Text_Nume.Text = "Introduceti Numele:\r\n";
            this.Text_Nume.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.LavenderBlush;
            this.textBox1.Location = new System.Drawing.Point(911, 573);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(298, 133);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "Optional*";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.Pink;
            this.textBox2.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.Maroon;
            this.textBox2.Location = new System.Drawing.Point(395, 38);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(525, 180);
            this.textBox2.TabIndex = 5;
            this.textBox2.Text = "SANTA\'S\r\n\"SECRET SANTA\"\r\nHELPER";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.DarkOrange;
            this.textBox3.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(911, 531);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(216, 36);
            this.textBox3.TabIndex = 6;
            this.textBox3.Text = "Preferinte de cadouri?";
            // 
            // Main_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.XMAS_Corona;
            this.ClientSize = new System.Drawing.Size(1312, 772);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Text_Nume);
            this.Controls.Add(this.Nume_Util);
            this.Controls.Add(this.Join_Room);
            this.Controls.Add(this.Create_Room);
            this.Name = "Main_Menu";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_Menu_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Create_Room;
        private System.Windows.Forms.Button Join_Room;
        private System.Windows.Forms.TextBox Nume_Util;
        private System.Windows.Forms.TextBox Text_Nume;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
    }
}

