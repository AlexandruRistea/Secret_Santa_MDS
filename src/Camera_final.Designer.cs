namespace WindowsFormsApp1
{
    partial class Camera_final
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
            this.Copy_data = new System.Windows.Forms.Button();
            this.Mesaj_final = new System.Windows.Forms.TextBox();
            this.Nume_spiridus = new System.Windows.Forms.TextBox();
            this.Back_to_menu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Copy_data
            // 
            this.Copy_data.BackColor = System.Drawing.Color.Turquoise;
            this.Copy_data.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Copy_data.Location = new System.Drawing.Point(463, 605);
            this.Copy_data.Name = "Copy_data";
            this.Copy_data.Size = new System.Drawing.Size(385, 79);
            this.Copy_data.TabIndex = 0;
            this.Copy_data.Text = "Copiaza datele";
            this.Copy_data.UseVisualStyleBackColor = false;
            this.Copy_data.Click += new System.EventHandler(this.Copy_data_Click);
            // 
            // Mesaj_final
            // 
            this.Mesaj_final.BackColor = System.Drawing.Color.LightCoral;
            this.Mesaj_final.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mesaj_final.Location = new System.Drawing.Point(463, 147);
            this.Mesaj_final.Multiline = true;
            this.Mesaj_final.Name = "Mesaj_final";
            this.Mesaj_final.ReadOnly = true;
            this.Mesaj_final.Size = new System.Drawing.Size(385, 84);
            this.Mesaj_final.TabIndex = 1;
            this.Mesaj_final.Text = "Felicitari!\r\nEsti mosul lui:";
            this.Mesaj_final.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Nume_spiridus
            // 
            this.Nume_spiridus.BackColor = System.Drawing.Color.DarkRed;
            this.Nume_spiridus.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nume_spiridus.Location = new System.Drawing.Point(463, 301);
            this.Nume_spiridus.Multiline = true;
            this.Nume_spiridus.Name = "Nume_spiridus";
            this.Nume_spiridus.ReadOnly = true;
            this.Nume_spiridus.Size = new System.Drawing.Size(384, 219);
            this.Nume_spiridus.TabIndex = 2;
            this.Nume_spiridus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Back_to_menu
            // 
            this.Back_to_menu.BackColor = System.Drawing.Color.Tomato;
            this.Back_to_menu.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back_to_menu.Location = new System.Drawing.Point(1015, 605);
            this.Back_to_menu.Name = "Back_to_menu";
            this.Back_to_menu.Size = new System.Drawing.Size(216, 79);
            this.Back_to_menu.TabIndex = 3;
            this.Back_to_menu.Text = "Inapoi la meniu";
            this.Back_to_menu.UseVisualStyleBackColor = false;
            this.Back_to_menu.Click += new System.EventHandler(this.Back_to_menu_Click);
            // 
            // Camera_final
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.XMAS_Corona;
            this.ClientSize = new System.Drawing.Size(1313, 767);
            this.Controls.Add(this.Back_to_menu);
            this.Controls.Add(this.Nume_spiridus);
            this.Controls.Add(this.Mesaj_final);
            this.Controls.Add(this.Copy_data);
            this.Name = "Camera_final";
            this.Text = "Camera_final";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Camera_final_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Copy_data;
        private System.Windows.Forms.TextBox Mesaj_final;
        private System.Windows.Forms.TextBox Nume_spiridus;
        private System.Windows.Forms.Button Back_to_menu;
    }
}