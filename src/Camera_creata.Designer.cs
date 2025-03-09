namespace WindowsFormsApp1
{
    partial class Camera_creata
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
            this.Room_code = new System.Windows.Forms.TextBox();
            this.Lista_useri = new System.Windows.Forms.TextBox();
            this.Actual_room_code = new System.Windows.Forms.TextBox();
            this.nr_useri = new System.Windows.Forms.TextBox();
            this.Start_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Room_code
            // 
            this.Room_code.BackColor = System.Drawing.Color.LightSalmon;
            this.Room_code.Cursor = System.Windows.Forms.Cursors.Default;
            this.Room_code.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Room_code.Location = new System.Drawing.Point(865, 270);
            this.Room_code.Multiline = true;
            this.Room_code.Name = "Room_code";
            this.Room_code.ReadOnly = true;
            this.Room_code.Size = new System.Drawing.Size(187, 40);
            this.Room_code.TabIndex = 0;
            this.Room_code.Text = "Codul Camerei:";
            this.Room_code.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Lista_useri
            // 
            this.Lista_useri.BackColor = System.Drawing.Color.Coral;
            this.Lista_useri.Cursor = System.Windows.Forms.Cursors.Default;
            this.Lista_useri.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lista_useri.Location = new System.Drawing.Point(203, 308);
            this.Lista_useri.Multiline = true;
            this.Lista_useri.Name = "Lista_useri";
            this.Lista_useri.ReadOnly = true;
            this.Lista_useri.Size = new System.Drawing.Size(156, 75);
            this.Lista_useri.TabIndex = 1;
            this.Lista_useri.Text = "Numar\r\n de \r\nParticipanti:";
            this.Lista_useri.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Actual_room_code
            // 
            this.Actual_room_code.BackColor = System.Drawing.Color.DarkSalmon;
            this.Actual_room_code.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Actual_room_code.Location = new System.Drawing.Point(865, 398);
            this.Actual_room_code.Multiline = true;
            this.Actual_room_code.Name = "Actual_room_code";
            this.Actual_room_code.ReadOnly = true;
            this.Actual_room_code.Size = new System.Drawing.Size(187, 33);
            this.Actual_room_code.TabIndex = 2;
            this.Actual_room_code.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nr_useri
            // 
            this.nr_useri.BackColor = System.Drawing.Color.DarkOrange;
            this.nr_useri.Cursor = System.Windows.Forms.Cursors.Default;
            this.nr_useri.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nr_useri.Location = new System.Drawing.Point(549, 77);
            this.nr_useri.Multiline = true;
            this.nr_useri.Name = "nr_useri";
            this.nr_useri.ReadOnly = true;
            this.nr_useri.Size = new System.Drawing.Size(216, 121);
            this.nr_useri.TabIndex = 4;
            this.nr_useri.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Start_button
            // 
            this.Start_button.BackColor = System.Drawing.Color.Gold;
            this.Start_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Start_button.Location = new System.Drawing.Point(507, 290);
            this.Start_button.Name = "Start_button";
            this.Start_button.Size = new System.Drawing.Size(275, 108);
            this.Start_button.TabIndex = 5;
            this.Start_button.Text = "START!";
            this.Start_button.UseVisualStyleBackColor = false;
            this.Start_button.Click += new System.EventHandler(this.Start_button_Click);
            // 
            // Camera_creata
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.XMAS_Corona;
            this.ClientSize = new System.Drawing.Size(1313, 768);
            this.Controls.Add(this.Start_button);
            this.Controls.Add(this.nr_useri);
            this.Controls.Add(this.Actual_room_code);
            this.Controls.Add(this.Lista_useri);
            this.Controls.Add(this.Room_code);
            this.Name = "Camera_creata";
            this.Text = "Camera_creata";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Camera_creata_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Room_code;
        private System.Windows.Forms.TextBox Lista_useri;
        private System.Windows.Forms.TextBox Actual_room_code;
        private System.Windows.Forms.TextBox nr_useri;
        private System.Windows.Forms.Button Start_button;
    }
}