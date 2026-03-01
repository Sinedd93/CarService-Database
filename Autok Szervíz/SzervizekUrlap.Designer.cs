namespace Autok_Szervíz
{
    partial class SzervizekUrlap
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
            this.lb_datum = new System.Windows.Forms.Label();
            this.lb_leiras = new System.Windows.Forms.Label();
            this.lb_koltseg = new System.Windows.Forms.Label();
            this.dtp_datum = new System.Windows.Forms.DateTimePicker();
            this.tb_leiras = new System.Windows.Forms.TextBox();
            this.nud_koltseg = new System.Windows.Forms.NumericUpDown();
            this.bt_ok = new System.Windows.Forms.Button();
            this.bt_mesge = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nud_koltseg)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_datum
            // 
            this.lb_datum.AutoSize = true;
            this.lb_datum.Location = new System.Drawing.Point(374, 44);
            this.lb_datum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_datum.Name = "lb_datum";
            this.lb_datum.Size = new System.Drawing.Size(46, 16);
            this.lb_datum.TabIndex = 0;
            this.lb_datum.Text = "Dátum";
            // 
            // lb_leiras
            // 
            this.lb_leiras.AutoSize = true;
            this.lb_leiras.Location = new System.Drawing.Point(16, 48);
            this.lb_leiras.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_leiras.Name = "lb_leiras";
            this.lb_leiras.Size = new System.Drawing.Size(44, 16);
            this.lb_leiras.TabIndex = 1;
            this.lb_leiras.Text = "Leírás";
            // 
            // lb_koltseg
            // 
            this.lb_koltseg.AutoSize = true;
            this.lb_koltseg.Location = new System.Drawing.Point(16, 105);
            this.lb_koltseg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_koltseg.Name = "lb_koltseg";
            this.lb_koltseg.Size = new System.Drawing.Size(52, 16);
            this.lb_koltseg.TabIndex = 2;
            this.lb_koltseg.Text = "Költség";
            // 
            // dtp_datum
            // 
            this.dtp_datum.Location = new System.Drawing.Point(462, 44);
            this.dtp_datum.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtp_datum.Name = "dtp_datum";
            this.dtp_datum.Size = new System.Drawing.Size(265, 22);
            this.dtp_datum.TabIndex = 3;
            // 
            // tb_leiras
            // 
            this.tb_leiras.Location = new System.Drawing.Point(183, 44);
            this.tb_leiras.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_leiras.Name = "tb_leiras";
            this.tb_leiras.Size = new System.Drawing.Size(160, 22);
            this.tb_leiras.TabIndex = 4;
            // 
            // nud_koltseg
            // 
            this.nud_koltseg.Location = new System.Drawing.Point(183, 103);
            this.nud_koltseg.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nud_koltseg.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.nud_koltseg.Name = "nud_koltseg";
            this.nud_koltseg.Size = new System.Drawing.Size(160, 22);
            this.nud_koltseg.TabIndex = 5;
            // 
            // bt_ok
            // 
            this.bt_ok.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.bt_ok.Location = new System.Drawing.Point(226, 174);
            this.bt_ok.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt_ok.Name = "bt_ok";
            this.bt_ok.Size = new System.Drawing.Size(100, 28);
            this.bt_ok.TabIndex = 6;
            this.bt_ok.Text = "OK";
            this.bt_ok.UseVisualStyleBackColor = true;
            this.bt_ok.Click += new System.EventHandler(this.bt_ok_Click);
            // 
            // bt_mesge
            // 
            this.bt_mesge.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bt_mesge.Location = new System.Drawing.Point(346, 174);
            this.bt_mesge.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt_mesge.Name = "bt_mesge";
            this.bt_mesge.Size = new System.Drawing.Size(100, 28);
            this.bt_mesge.TabIndex = 7;
            this.bt_mesge.Text = "Megse";
            this.bt_mesge.UseVisualStyleBackColor = true;
            // 
            // SzervizekUrlap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 252);
            this.Controls.Add(this.bt_mesge);
            this.Controls.Add(this.bt_ok);
            this.Controls.Add(this.nud_koltseg);
            this.Controls.Add(this.tb_leiras);
            this.Controls.Add(this.dtp_datum);
            this.Controls.Add(this.lb_koltseg);
            this.Controls.Add(this.lb_leiras);
            this.Controls.Add(this.lb_datum);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "SzervizekUrlap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SzervizekUrlap";
            ((System.ComponentModel.ISupportInitialize)(this.nud_koltseg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_datum;
        private System.Windows.Forms.Label lb_leiras;
        private System.Windows.Forms.Label lb_koltseg;
        private System.Windows.Forms.DateTimePicker dtp_datum;
        private System.Windows.Forms.TextBox tb_leiras;
        private System.Windows.Forms.NumericUpDown nud_koltseg;
        private System.Windows.Forms.Button bt_ok;
        private System.Windows.Forms.Button bt_mesge;
    }
}