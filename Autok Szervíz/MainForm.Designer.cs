namespace Autok_Szervíz
{
    partial class MainForm
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
            this.lb_autok = new System.Windows.Forms.ListBox();
            this.bt_felvétel = new System.Windows.Forms.Button();
            this.bt_modositas = new System.Windows.Forms.Button();
            this.bt_törlés = new System.Windows.Forms.Button();
            this.bt_szerviztorles = new System.Windows.Forms.Button();
            this.bt_szevizmodositas = new System.Windows.Forms.Button();
            this.bt_Szervízfelvétel = new System.Windows.Forms.Button();
            this.lb_szerviz = new System.Windows.Forms.ListBox();
            this.lb_Kereses = new System.Windows.Forms.ListBox();
            this.bt_autokereses = new System.Windows.Forms.Button();
            this.tb_rendszam = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lb_autok
            // 
            this.lb_autok.FormattingEnabled = true;
            this.lb_autok.Location = new System.Drawing.Point(12, 12);
            this.lb_autok.Name = "lb_autok";
            this.lb_autok.Size = new System.Drawing.Size(524, 277);
            this.lb_autok.TabIndex = 0;
            this.lb_autok.SelectedIndexChanged += new System.EventHandler(this.lb_autok_SelectedIndexChanged);
            // 
            // bt_felvétel
            // 
            this.bt_felvétel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bt_felvétel.Location = new System.Drawing.Point(167, 295);
            this.bt_felvétel.Name = "bt_felvétel";
            this.bt_felvétel.Size = new System.Drawing.Size(198, 31);
            this.bt_felvétel.TabIndex = 1;
            this.bt_felvétel.Text = "Autók Felvétele";
            this.bt_felvétel.UseVisualStyleBackColor = true;
            this.bt_felvétel.Click += new System.EventHandler(this.bt_felvétel_Click);
            // 
            // bt_modositas
            // 
            this.bt_modositas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bt_modositas.Location = new System.Drawing.Point(167, 332);
            this.bt_modositas.Name = "bt_modositas";
            this.bt_modositas.Size = new System.Drawing.Size(198, 31);
            this.bt_modositas.TabIndex = 2;
            this.bt_modositas.Text = "Autók Módosítása";
            this.bt_modositas.UseVisualStyleBackColor = true;
            this.bt_modositas.Click += new System.EventHandler(this.bt_modositas_Click);
            // 
            // bt_törlés
            // 
            this.bt_törlés.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bt_törlés.Location = new System.Drawing.Point(167, 369);
            this.bt_törlés.Name = "bt_törlés";
            this.bt_törlés.Size = new System.Drawing.Size(198, 31);
            this.bt_törlés.TabIndex = 3;
            this.bt_törlés.Text = "Autók Törlése";
            this.bt_törlés.UseVisualStyleBackColor = true;
            this.bt_törlés.Click += new System.EventHandler(this.bt_törlés_Click);
            // 
            // bt_szerviztorles
            // 
            this.bt_szerviztorles.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bt_szerviztorles.Location = new System.Drawing.Point(621, 369);
            this.bt_szerviztorles.Name = "bt_szerviztorles";
            this.bt_szerviztorles.Size = new System.Drawing.Size(198, 31);
            this.bt_szerviztorles.TabIndex = 7;
            this.bt_szerviztorles.Text = "Szervíz Törlése";
            this.bt_szerviztorles.UseVisualStyleBackColor = true;
            this.bt_szerviztorles.Click += new System.EventHandler(this.bt_szerviztorles_Click);
            // 
            // bt_szevizmodositas
            // 
            this.bt_szevizmodositas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bt_szevizmodositas.Location = new System.Drawing.Point(621, 332);
            this.bt_szevizmodositas.Name = "bt_szevizmodositas";
            this.bt_szevizmodositas.Size = new System.Drawing.Size(198, 31);
            this.bt_szevizmodositas.TabIndex = 6;
            this.bt_szevizmodositas.Text = "Szervíz Módosítása";
            this.bt_szevizmodositas.UseVisualStyleBackColor = true;
            this.bt_szevizmodositas.Click += new System.EventHandler(this.bt_szevizmodositas_Click);
            // 
            // bt_Szervízfelvétel
            // 
            this.bt_Szervízfelvétel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bt_Szervízfelvétel.Location = new System.Drawing.Point(621, 295);
            this.bt_Szervízfelvétel.Name = "bt_Szervízfelvétel";
            this.bt_Szervízfelvétel.Size = new System.Drawing.Size(198, 31);
            this.bt_Szervízfelvétel.TabIndex = 5;
            this.bt_Szervízfelvétel.Text = "Szervíz Felvétel";
            this.bt_Szervízfelvétel.UseVisualStyleBackColor = true;
            this.bt_Szervízfelvétel.Click += new System.EventHandler(this.bt_Szervízfelvétel_Click);
            // 
            // lb_szerviz
            // 
            this.lb_szerviz.FormattingEnabled = true;
            this.lb_szerviz.Location = new System.Drawing.Point(554, 12);
            this.lb_szerviz.Name = "lb_szerviz";
            this.lb_szerviz.Size = new System.Drawing.Size(332, 277);
            this.lb_szerviz.TabIndex = 4;
            // 
            // lb_Kereses
            // 
            this.lb_Kereses.FormattingEnabled = true;
            this.lb_Kereses.Location = new System.Drawing.Point(901, 12);
            this.lb_Kereses.Name = "lb_Kereses";
            this.lb_Kereses.Size = new System.Drawing.Size(297, 277);
            this.lb_Kereses.TabIndex = 8;
            // 
            // bt_autokereses
            // 
            this.bt_autokereses.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bt_autokereses.Location = new System.Drawing.Point(901, 295);
            this.bt_autokereses.Name = "bt_autokereses";
            this.bt_autokereses.Size = new System.Drawing.Size(198, 31);
            this.bt_autokereses.TabIndex = 9;
            this.bt_autokereses.Text = "Keresés";
            this.bt_autokereses.UseVisualStyleBackColor = true;
            this.bt_autokereses.Click += new System.EventHandler(this.bt_autokereses_Click);
            // 
            // tb_rendszam
            // 
            this.tb_rendszam.Location = new System.Drawing.Point(1105, 301);
            this.tb_rendszam.Name = "tb_rendszam";
            this.tb_rendszam.Size = new System.Drawing.Size(150, 20);
            this.tb_rendszam.TabIndex = 10;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1279, 436);
            this.Controls.Add(this.tb_rendszam);
            this.Controls.Add(this.bt_autokereses);
            this.Controls.Add(this.lb_Kereses);
            this.Controls.Add(this.bt_szerviztorles);
            this.Controls.Add(this.bt_szevizmodositas);
            this.Controls.Add(this.bt_Szervízfelvétel);
            this.Controls.Add(this.lb_szerviz);
            this.Controls.Add(this.bt_törlés);
            this.Controls.Add(this.bt_modositas);
            this.Controls.Add(this.bt_felvétel);
            this.Controls.Add(this.lb_autok);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lb_autok;
        private System.Windows.Forms.Button bt_felvétel;
        private System.Windows.Forms.Button bt_modositas;
        private System.Windows.Forms.Button bt_törlés;
        private System.Windows.Forms.Button bt_szerviztorles;
        private System.Windows.Forms.Button bt_szevizmodositas;
        private System.Windows.Forms.Button bt_Szervízfelvétel;
        private System.Windows.Forms.ListBox lb_szerviz;
        private System.Windows.Forms.ListBox lb_Kereses;
        private System.Windows.Forms.Button bt_autokereses;
        private System.Windows.Forms.TextBox tb_rendszam;
    }
}