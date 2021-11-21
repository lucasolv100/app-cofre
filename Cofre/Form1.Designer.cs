
namespace Cofre
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnInserirMoeda = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lbQtdMoeda = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbMoedasUmReal = new System.Windows.Forms.Label();
            this.lbValorDolar = new System.Windows.Forms.Label();
            this.lbValorReal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(18, 45);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(125, 27);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Insira moedas no cofre";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnInserirMoeda
            // 
            this.btnInserirMoeda.Location = new System.Drawing.Point(145, 44);
            this.btnInserirMoeda.Name = "btnInserirMoeda";
            this.btnInserirMoeda.Size = new System.Drawing.Size(79, 28);
            this.btnInserirMoeda.TabIndex = 2;
            this.btnInserirMoeda.Text = "Inserir Moeda";
            this.btnInserirMoeda.UseVisualStyleBackColor = true;
            this.btnInserirMoeda.Click += new System.EventHandler(this.btnInserirMoeda_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Qtd Moedas No Cofre";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbQtdMoeda
            // 
            this.lbQtdMoeda.AutoSize = true;
            this.lbQtdMoeda.Location = new System.Drawing.Point(15, 142);
            this.lbQtdMoeda.Name = "lbQtdMoeda";
            this.lbQtdMoeda.Size = new System.Drawing.Size(17, 20);
            this.lbQtdMoeda.TabIndex = 4;
            this.lbQtdMoeda.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(180, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Qtd Moedas R$ 1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(317, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Valor total em dolar";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(466, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Valor total em real";
            // 
            // lbMoedasUmReal
            // 
            this.lbMoedasUmReal.AutoSize = true;
            this.lbMoedasUmReal.Location = new System.Drawing.Point(191, 142);
            this.lbMoedasUmReal.Name = "lbMoedasUmReal";
            this.lbMoedasUmReal.Size = new System.Drawing.Size(17, 20);
            this.lbMoedasUmReal.TabIndex = 8;
            this.lbMoedasUmReal.Text = "0";
            // 
            // lbValorDolar
            // 
            this.lbValorDolar.AutoSize = true;
            this.lbValorDolar.Location = new System.Drawing.Point(323, 143);
            this.lbValorDolar.Name = "lbValorDolar";
            this.lbValorDolar.Size = new System.Drawing.Size(17, 20);
            this.lbValorDolar.TabIndex = 9;
            this.lbValorDolar.Text = "0";
            // 
            // lbValorReal
            // 
            this.lbValorReal.AutoSize = true;
            this.lbValorReal.Location = new System.Drawing.Point(472, 143);
            this.lbValorReal.Name = "lbValorReal";
            this.lbValorReal.Size = new System.Drawing.Size(17, 20);
            this.lbValorReal.TabIndex = 10;
            this.lbValorReal.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbValorReal);
            this.Controls.Add(this.lbValorDolar);
            this.Controls.Add(this.lbMoedasUmReal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbQtdMoeda);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnInserirMoeda);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnInserirMoeda;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbQtdMoeda;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbMoedasUmReal;
        private System.Windows.Forms.Label lbValorDolar;
        private System.Windows.Forms.Label lbValorReal;
    }
}

