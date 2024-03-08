namespace tpAula2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtP1 = new System.Windows.Forms.TextBox();
            this.txtP4 = new System.Windows.Forms.TextBox();
            this.txtP3 = new System.Windows.Forms.TextBox();
            this.txtP2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCalcularNota = new System.Windows.Forms.Button();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtP1
            // 
            this.txtP1.Location = new System.Drawing.Point(295, 58);
            this.txtP1.Name = "txtP1";
            this.txtP1.Size = new System.Drawing.Size(100, 23);
            this.txtP1.TabIndex = 0;
            // 
            // txtP4
            // 
            this.txtP4.Location = new System.Drawing.Point(295, 145);
            this.txtP4.Name = "txtP4";
            this.txtP4.Size = new System.Drawing.Size(100, 23);
            this.txtP4.TabIndex = 1;
            // 
            // txtP3
            // 
            this.txtP3.Location = new System.Drawing.Point(295, 116);
            this.txtP3.Name = "txtP3";
            this.txtP3.Size = new System.Drawing.Size(100, 23);
            this.txtP3.TabIndex = 2;
            // 
            // txtP2
            // 
            this.txtP2.Location = new System.Drawing.Point(295, 87);
            this.txtP2.Name = "txtP2";
            this.txtP2.Size = new System.Drawing.Size(100, 23);
            this.txtP2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(227, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nota P1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(227, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nota P2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(227, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nota P3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(227, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Nota P4";
            // 
            // btnCalcularNota
            // 
            this.btnCalcularNota.Location = new System.Drawing.Point(320, 193);
            this.btnCalcularNota.Name = "btnCalcularNota";
            this.btnCalcularNota.Size = new System.Drawing.Size(75, 23);
            this.btnCalcularNota.TabIndex = 8;
            this.btnCalcularNota.Text = "Calcular";
            this.btnCalcularNota.UseVisualStyleBackColor = true;
            this.btnCalcularNota.Click += new System.EventHandler(this.btnCalcularNota_Click);
            // 
            // txtResultado
            // 
            this.txtResultado.Enabled = false;
            this.txtResultado.Location = new System.Drawing.Point(295, 250);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(100, 23);
            this.txtResultado.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(201, 253);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Resultado Nota";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.btnCalcularNota);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtP2);
            this.Controls.Add(this.txtP3);
            this.Controls.Add(this.txtP4);
            this.Controls.Add(this.txtP1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtP1;
        private TextBox txtP4;
        private TextBox txtP3;
        private TextBox txtP2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnCalcularNota;
        private TextBox txtResultado;
        private Label label5;
    }
}