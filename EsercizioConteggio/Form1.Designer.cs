namespace EsercizioConteggio
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
            this.txb_nome = new System.Windows.Forms.TextBox();
            this.txb_cognome = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txb_città = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_calcola = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_nome_completo = new System.Windows.Forms.Label();
            this.lbl_età = new System.Windows.Forms.Label();
            this.lbl_conteggio_carattere = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txb_nome
            // 
            this.txb_nome.Location = new System.Drawing.Point(58, 83);
            this.txb_nome.Name = "txb_nome";
            this.txb_nome.Size = new System.Drawing.Size(223, 31);
            this.txb_nome.TabIndex = 0;
            // 
            // txb_cognome
            // 
            this.txb_cognome.Location = new System.Drawing.Point(307, 83);
            this.txb_cognome.Name = "txb_cognome";
            this.txb_cognome.Size = new System.Drawing.Size(223, 31);
            this.txb_cognome.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(561, 83);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(297, 31);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // txb_città
            // 
            this.txb_città.Location = new System.Drawing.Point(897, 81);
            this.txb_città.Name = "txb_città";
            this.txb_città.Size = new System.Drawing.Size(223, 31);
            this.txb_città.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(307, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Cognome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(897, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Città";
            // 
            // btn_calcola
            // 
            this.btn_calcola.Location = new System.Drawing.Point(362, 167);
            this.btn_calcola.Name = "btn_calcola";
            this.btn_calcola.Size = new System.Drawing.Size(413, 44);
            this.btn_calcola.TabIndex = 7;
            this.btn_calcola.Text = "Calcola";
            this.btn_calcola.UseVisualStyleBackColor = true;
            this.btn_calcola.Click += new System.EventHandler(this.btn_calcola_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 287);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Nome Completo:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(58, 332);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Età:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(58, 379);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(163, 25);
            this.label6.TabIndex = 10;
            this.label6.Text = "Conteggio Lettere: ";
            // 
            // lbl_nome_completo
            // 
            this.lbl_nome_completo.AutoSize = true;
            this.lbl_nome_completo.Location = new System.Drawing.Point(250, 287);
            this.lbl_nome_completo.Name = "lbl_nome_completo";
            this.lbl_nome_completo.Size = new System.Drawing.Size(17, 25);
            this.lbl_nome_completo.TabIndex = 11;
            this.lbl_nome_completo.Text = " ";
            // 
            // lbl_età
            // 
            this.lbl_età.AutoSize = true;
            this.lbl_età.Location = new System.Drawing.Point(250, 332);
            this.lbl_età.Name = "lbl_età";
            this.lbl_età.Size = new System.Drawing.Size(17, 25);
            this.lbl_età.TabIndex = 12;
            this.lbl_età.Text = " ";
            // 
            // lbl_conteggio_carattere
            // 
            this.lbl_conteggio_carattere.AutoSize = true;
            this.lbl_conteggio_carattere.Location = new System.Drawing.Point(250, 379);
            this.lbl_conteggio_carattere.Name = "lbl_conteggio_carattere";
            this.lbl_conteggio_carattere.Size = new System.Drawing.Size(17, 25);
            this.lbl_conteggio_carattere.TabIndex = 13;
            this.lbl_conteggio_carattere.Text = " ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1186, 450);
            this.Controls.Add(this.lbl_conteggio_carattere);
            this.Controls.Add(this.lbl_età);
            this.Controls.Add(this.lbl_nome_completo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_calcola);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txb_città);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txb_cognome);
            this.Controls.Add(this.txb_nome);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txb_nome;
        private TextBox txb_cognome;
        private DateTimePicker dateTimePicker1;
        private TextBox txb_città;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btn_calcola;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label lbl_nome_completo;
        private Label lbl_età;
        private Label lbl_conteggio_carattere;
    }
}