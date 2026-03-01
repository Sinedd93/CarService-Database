namespace Autok_Szervíz
{
    partial class AutokUrlap
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
            this.lb_rednszam = new System.Windows.Forms.Label();
            this.lb_tipus = new System.Windows.Forms.Label();
            this.lb_evjarat = new System.Windows.Forms.Label();
            this.tb_rendszam = new System.Windows.Forms.TextBox();
            this.dtp_datum = new System.Windows.Forms.DateTimePicker();
            this.cb_tipus = new System.Windows.Forms.ComboBox();
            this.bt_ok = new System.Windows.Forms.Button();
            this.bt_megse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_rednszam
            // 
            this.lb_rednszam.AutoSize = true;
            this.lb_rednszam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lb_rednszam.Location = new System.Drawing.Point(12, 35);
            this.lb_rednszam.Name = "lb_rednszam";
            this.lb_rednszam.Size = new System.Drawing.Size(86, 20);
            this.lb_rednszam.TabIndex = 0;
            this.lb_rednszam.Text = "Rendszám";
            // 
            // lb_tipus
            // 
            this.lb_tipus.AutoSize = true;
            this.lb_tipus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lb_tipus.Location = new System.Drawing.Point(12, 75);
            this.lb_tipus.Name = "lb_tipus";
            this.lb_tipus.Size = new System.Drawing.Size(47, 20);
            this.lb_tipus.TabIndex = 1;
            this.lb_tipus.Text = "Típus";
            // 
            // lb_evjarat
            // 
            this.lb_evjarat.AutoSize = true;
            this.lb_evjarat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lb_evjarat.Location = new System.Drawing.Point(355, 36);
            this.lb_evjarat.Name = "lb_evjarat";
            this.lb_evjarat.Size = new System.Drawing.Size(58, 20);
            this.lb_evjarat.TabIndex = 2;
            this.lb_evjarat.Text = "Évjárat";
            // 
            // tb_rendszam
            // 
            this.tb_rendszam.Location = new System.Drawing.Point(134, 32);
            this.tb_rendszam.Name = "tb_rendszam";
            this.tb_rendszam.Size = new System.Drawing.Size(121, 20);
            this.tb_rendszam.TabIndex = 3;
            // 
            // dtp_datum
            // 
            this.dtp_datum.Location = new System.Drawing.Point(420, 36);
            this.dtp_datum.Name = "dtp_datum";
            this.dtp_datum.Size = new System.Drawing.Size(200, 20);
            this.dtp_datum.TabIndex = 4;
            // 
            // cb_tipus
            // 
            this.cb_tipus.FormattingEnabled = true;
            this.cb_tipus.Location = new System.Drawing.Point(134, 74);
            this.cb_tipus.Name = "cb_tipus";
            this.cb_tipus.Size = new System.Drawing.Size(121, 21);
            this.cb_tipus.TabIndex = 5;
            // 
            // bt_ok
            // 
            this.bt_ok.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.bt_ok.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bt_ok.Location = new System.Drawing.Point(212, 166);
            this.bt_ok.Name = "bt_ok";
            this.bt_ok.Size = new System.Drawing.Size(81, 31);
            this.bt_ok.TabIndex = 6;
            this.bt_ok.Text = "OK";
            this.bt_ok.UseVisualStyleBackColor = true;
            this.bt_ok.Click += new System.EventHandler(this.bt_ok_Click);
            // 
            // bt_megse
            // 
            this.bt_megse.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bt_megse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bt_megse.Location = new System.Drawing.Point(328, 166);
            this.bt_megse.Name = "bt_megse";
            this.bt_megse.Size = new System.Drawing.Size(85, 31);
            this.bt_megse.TabIndex = 7;
            this.bt_megse.Text = "Mégse";
            this.bt_megse.UseVisualStyleBackColor = true;
            // 
            // AutokUrlap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 257);
            this.Controls.Add(this.bt_megse);
            this.Controls.Add(this.bt_ok);
            this.Controls.Add(this.cb_tipus);
            this.Controls.Add(this.dtp_datum);
            this.Controls.Add(this.tb_rendszam);
            this.Controls.Add(this.lb_evjarat);
            this.Controls.Add(this.lb_tipus);
            this.Controls.Add(this.lb_rednszam);
            this.Name = "AutokUrlap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AutokUrlap";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_rednszam;
        private System.Windows.Forms.Label lb_tipus;
        private System.Windows.Forms.Label lb_evjarat;
        private System.Windows.Forms.TextBox tb_rendszam;
        private System.Windows.Forms.DateTimePicker dtp_datum;
        private System.Windows.Forms.ComboBox cb_tipus;
        private System.Windows.Forms.Button bt_ok;
        private System.Windows.Forms.Button bt_megse;
    }
}