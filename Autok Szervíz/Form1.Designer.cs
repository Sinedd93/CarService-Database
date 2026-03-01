namespace Autok_Szervíz
{
    partial class Form1
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
            this.tb_felhasznalo = new System.Windows.Forms.TextBox();
            this.tb_jelszo = new System.Windows.Forms.TextBox();
            this.lb_felhasznalo = new System.Windows.Forms.Label();
            this.lb_jelszo = new System.Windows.Forms.Label();
            this.bt_ok = new System.Windows.Forms.Button();
            this.bt_megse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_felhasznalo
            // 
            this.tb_felhasznalo.Location = new System.Drawing.Point(140, 30);
            this.tb_felhasznalo.Name = "tb_felhasznalo";
            this.tb_felhasznalo.Size = new System.Drawing.Size(125, 20);
            this.tb_felhasznalo.TabIndex = 0;
            // 
            // tb_jelszo
            // 
            this.tb_jelszo.Location = new System.Drawing.Point(140, 77);
            this.tb_jelszo.Name = "tb_jelszo";
            this.tb_jelszo.Size = new System.Drawing.Size(125, 20);
            this.tb_jelszo.TabIndex = 1;
            // 
            // lb_felhasznalo
            // 
            this.lb_felhasznalo.AutoSize = true;
            this.lb_felhasznalo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lb_felhasznalo.Location = new System.Drawing.Point(21, 28);
            this.lb_felhasznalo.Name = "lb_felhasznalo";
            this.lb_felhasznalo.Size = new System.Drawing.Size(86, 20);
            this.lb_felhasznalo.TabIndex = 2;
            this.lb_felhasznalo.Text = "Felhsznalo";
            // 
            // lb_jelszo
            // 
            this.lb_jelszo.AutoSize = true;
            this.lb_jelszo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lb_jelszo.Location = new System.Drawing.Point(21, 77);
            this.lb_jelszo.Name = "lb_jelszo";
            this.lb_jelszo.Size = new System.Drawing.Size(54, 20);
            this.lb_jelszo.TabIndex = 3;
            this.lb_jelszo.Text = "Jelszo";
            // 
            // bt_ok
            // 
            this.bt_ok.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.bt_ok.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bt_ok.Location = new System.Drawing.Point(104, 163);
            this.bt_ok.Name = "bt_ok";
            this.bt_ok.Size = new System.Drawing.Size(80, 32);
            this.bt_ok.TabIndex = 4;
            this.bt_ok.Text = "OK";
            this.bt_ok.UseVisualStyleBackColor = true;
            this.bt_ok.Click += new System.EventHandler(this.bt_ok_Click);
            // 
            // bt_megse
            // 
            this.bt_megse.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bt_megse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bt_megse.Location = new System.Drawing.Point(190, 163);
            this.bt_megse.Name = "bt_megse";
            this.bt_megse.Size = new System.Drawing.Size(75, 32);
            this.bt_megse.TabIndex = 5;
            this.bt_megse.Text = "Megse";
            this.bt_megse.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 251);
            this.Controls.Add(this.bt_megse);
            this.Controls.Add(this.bt_ok);
            this.Controls.Add(this.lb_jelszo);
            this.Controls.Add(this.lb_felhasznalo);
            this.Controls.Add(this.tb_jelszo);
            this.Controls.Add(this.tb_felhasznalo);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_felhasznalo;
        private System.Windows.Forms.TextBox tb_jelszo;
        private System.Windows.Forms.Label lb_felhasznalo;
        private System.Windows.Forms.Label lb_jelszo;
        private System.Windows.Forms.Button bt_ok;
        private System.Windows.Forms.Button bt_megse;
    }
}

