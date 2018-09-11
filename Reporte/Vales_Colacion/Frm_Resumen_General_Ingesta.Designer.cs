namespace Vales_Colacion
{
    partial class Frm_Resumen_General_Ingesta
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
            this.Btn_imprimir = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtfec = new System.Windows.Forms.Label();
            this.txtpac = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Btn_imprimir
            // 
            this.Btn_imprimir.Image = global::Vales_Colacion.Properties.Resources.reportes;
            this.Btn_imprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_imprimir.Location = new System.Drawing.Point(384, 84);
            this.Btn_imprimir.Name = "Btn_imprimir";
            this.Btn_imprimir.Size = new System.Drawing.Size(75, 36);
            this.Btn_imprimir.TabIndex = 198;
            this.Btn_imprimir.Text = "Imprime";
            this.Btn_imprimir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_imprimir.UseVisualStyleBackColor = true;
            this.Btn_imprimir.Click += new System.EventHandler(this.Btn_imprimir_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 200;
            this.label3.Text = "Paciente";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtfec);
            this.groupBox1.Controls.Add(this.txtpac);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.Btn_imprimir);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(465, 126);
            this.groupBox1.TabIndex = 201;
            this.groupBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(68, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(10, 13);
            this.label6.TabIndex = 206;
            this.label6.Text = ":";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(69, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(10, 13);
            this.label5.TabIndex = 205;
            this.label5.Text = ":";
            // 
            // txtfec
            // 
            this.txtfec.AutoSize = true;
            this.txtfec.Location = new System.Drawing.Point(86, 65);
            this.txtfec.Name = "txtfec";
            this.txtfec.Size = new System.Drawing.Size(16, 13);
            this.txtfec.TabIndex = 204;
            this.txtfec.Text = "fe";
            // 
            // txtpac
            // 
            this.txtpac.AutoSize = true;
            this.txtpac.Location = new System.Drawing.Point(85, 41);
            this.txtpac.Name = "txtpac";
            this.txtpac.Size = new System.Drawing.Size(25, 13);
            this.txtpac.TabIndex = 203;
            this.txtpac.Text = "pac";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 202;
            this.label1.Text = "Fecha";
            // 
            // label7
            // 
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Image = global::Vales_Colacion.Properties.Resources.HeaderLarge;
            this.label7.Location = new System.Drawing.Point(0, 6);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(465, 25);
            this.label7.TabIndex = 201;
            this.label7.Text = "Resumen General ";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Frm_Resumen_General_Ingesta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 150);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Resumen_General_Ingesta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Resumen General Ingesta";
            this.Load += new System.EventHandler(this.Frm_Resumen_General_Ingesta_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_imprimir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label txtpac;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label txtfec;
    }
}