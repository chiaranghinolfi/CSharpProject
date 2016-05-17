namespace ProgettoTest
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Liberare le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.ifButton = new System.Windows.Forms.Button();
            this.switchButton = new System.Windows.Forms.Button();
            this.forButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.Label();
            this.sommaButt = new System.Windows.Forms.Button();
            this.aTxt = new System.Windows.Forms.TextBox();
            this.bTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.diffButt = new System.Windows.Forms.Button();
            this.aBtxt = new System.Windows.Forms.TextBox();
            this.bBtxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.resultB = new System.Windows.Forms.Label();
            this.moltButt = new System.Windows.Forms.Button();
            this.divButt = new System.Windows.Forms.Button();
            this.bDtxt = new System.Windows.Forms.TextBox();
            this.bCtxt = new System.Windows.Forms.TextBox();
            this.aDtxt = new System.Windows.Forms.TextBox();
            this.aCtxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.resultC = new System.Windows.Forms.Label();
            this.resultD = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ifButton
            // 
            this.ifButton.Location = new System.Drawing.Point(12, 12);
            this.ifButton.Name = "ifButton";
            this.ifButton.Size = new System.Drawing.Size(83, 31);
            this.ifButton.TabIndex = 0;
            this.ifButton.Text = "If button";
            this.ifButton.UseVisualStyleBackColor = true;
            this.ifButton.Click += new System.EventHandler(this.ifButton_Click);
            // 
            // switchButton
            // 
            this.switchButton.Location = new System.Drawing.Point(12, 49);
            this.switchButton.Name = "switchButton";
            this.switchButton.Size = new System.Drawing.Size(83, 31);
            this.switchButton.TabIndex = 1;
            this.switchButton.Text = "Switch button";
            this.switchButton.UseVisualStyleBackColor = true;
            this.switchButton.Click += new System.EventHandler(this.switchButton_Click);
            // 
            // forButton
            // 
            this.forButton.Location = new System.Drawing.Point(12, 86);
            this.forButton.Name = "forButton";
            this.forButton.Size = new System.Drawing.Size(83, 31);
            this.forButton.TabIndex = 2;
            this.forButton.Text = "For button";
            this.forButton.UseVisualStyleBackColor = true;
            this.forButton.Click += new System.EventHandler(this.forButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Location = new System.Drawing.Point(235, 134);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(13, 13);
            this.result.TabIndex = 4;
            this.result.Text = "0";
            // 
            // sommaButt
            // 
            this.sommaButt.Location = new System.Drawing.Point(11, 120);
            this.sommaButt.Name = "sommaButt";
            this.sommaButt.Size = new System.Drawing.Size(83, 31);
            this.sommaButt.TabIndex = 5;
            this.sommaButt.Text = "Somma";
            this.sommaButt.UseVisualStyleBackColor = true;
            this.sommaButt.Click += new System.EventHandler(this.sommaButt_Click);
            // 
            // aTxt
            // 
            this.aTxt.Location = new System.Drawing.Point(100, 131);
            this.aTxt.Name = "aTxt";
            this.aTxt.Size = new System.Drawing.Size(43, 20);
            this.aTxt.TabIndex = 6;
            this.aTxt.Text = "0";
            this.aTxt.TextChanged += new System.EventHandler(this.aTxt_TextChanged);
            // 
            // bTxt
            // 
            this.bTxt.Location = new System.Drawing.Point(167, 131);
            this.bTxt.Name = "bTxt";
            this.bTxt.Size = new System.Drawing.Size(43, 20);
            this.bTxt.TabIndex = 7;
            this.bTxt.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(149, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "+";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(216, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "=";
            // 
            // diffButt
            // 
            this.diffButt.Location = new System.Drawing.Point(11, 159);
            this.diffButt.Name = "diffButt";
            this.diffButt.Size = new System.Drawing.Size(83, 31);
            this.diffButt.TabIndex = 10;
            this.diffButt.Text = "Differenza";
            this.diffButt.UseVisualStyleBackColor = true;
            this.diffButt.Click += new System.EventHandler(this.diffButt_Click);
            // 
            // aBtxt
            // 
            this.aBtxt.Location = new System.Drawing.Point(102, 165);
            this.aBtxt.Name = "aBtxt";
            this.aBtxt.Size = new System.Drawing.Size(43, 20);
            this.aBtxt.TabIndex = 11;
            this.aBtxt.Text = "0";
            // 
            // bBtxt
            // 
            this.bBtxt.Location = new System.Drawing.Point(167, 168);
            this.bBtxt.Name = "bBtxt";
            this.bBtxt.Size = new System.Drawing.Size(43, 20);
            this.bBtxt.TabIndex = 12;
            this.bBtxt.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(151, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(10, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "-";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(216, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "=";
            // 
            // resultB
            // 
            this.resultB.AutoSize = true;
            this.resultB.Location = new System.Drawing.Point(235, 171);
            this.resultB.Name = "resultB";
            this.resultB.Size = new System.Drawing.Size(13, 13);
            this.resultB.TabIndex = 15;
            this.resultB.Text = "0";
            // 
            // moltButt
            // 
            this.moltButt.Location = new System.Drawing.Point(3, 199);
            this.moltButt.Name = "moltButt";
            this.moltButt.Size = new System.Drawing.Size(92, 26);
            this.moltButt.TabIndex = 16;
            this.moltButt.Text = "Moltiplicazione";
            this.moltButt.UseVisualStyleBackColor = true;
            this.moltButt.Click += new System.EventHandler(this.moltButt_Click);
            // 
            // divButt
            // 
            this.divButt.Location = new System.Drawing.Point(12, 236);
            this.divButt.Name = "divButt";
            this.divButt.Size = new System.Drawing.Size(83, 31);
            this.divButt.TabIndex = 17;
            this.divButt.Text = "Divisione";
            this.divButt.UseVisualStyleBackColor = true;
            this.divButt.Click += new System.EventHandler(this.divButt_Click);
            // 
            // bDtxt
            // 
            this.bDtxt.Location = new System.Drawing.Point(168, 242);
            this.bDtxt.Name = "bDtxt";
            this.bDtxt.Size = new System.Drawing.Size(43, 20);
            this.bDtxt.TabIndex = 18;
            this.bDtxt.Text = "0";
            // 
            // bCtxt
            // 
            this.bCtxt.Location = new System.Drawing.Point(171, 202);
            this.bCtxt.Name = "bCtxt";
            this.bCtxt.Size = new System.Drawing.Size(43, 20);
            this.bCtxt.TabIndex = 19;
            this.bCtxt.Text = "0";
            // 
            // aDtxt
            // 
            this.aDtxt.Location = new System.Drawing.Point(100, 242);
            this.aDtxt.Name = "aDtxt";
            this.aDtxt.Size = new System.Drawing.Size(43, 20);
            this.aDtxt.TabIndex = 20;
            this.aDtxt.Text = "0";
            // 
            // aCtxt
            // 
            this.aCtxt.Location = new System.Drawing.Point(102, 202);
            this.aCtxt.Name = "aCtxt";
            this.aCtxt.Size = new System.Drawing.Size(43, 20);
            this.aCtxt.TabIndex = 21;
            this.aCtxt.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(151, 208);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "X";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(152, 245);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(10, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = ":";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(217, 245);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(13, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "=";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(216, 212);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(13, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "=";
            // 
            // resultC
            // 
            this.resultC.AutoSize = true;
            this.resultC.Location = new System.Drawing.Point(235, 212);
            this.resultC.Name = "resultC";
            this.resultC.Size = new System.Drawing.Size(13, 13);
            this.resultC.TabIndex = 26;
            this.resultC.Text = "0";
            // 
            // resultD
            // 
            this.resultD.AutoSize = true;
            this.resultD.Location = new System.Drawing.Point(236, 245);
            this.resultD.Name = "resultD";
            this.resultD.Size = new System.Drawing.Size(13, 13);
            this.resultD.TabIndex = 27;
            this.resultD.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 296);
            this.Controls.Add(this.resultD);
            this.Controls.Add(this.resultC);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.aCtxt);
            this.Controls.Add(this.aDtxt);
            this.Controls.Add(this.bCtxt);
            this.Controls.Add(this.bDtxt);
            this.Controls.Add(this.divButt);
            this.Controls.Add(this.moltButt);
            this.Controls.Add(this.resultB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bBtxt);
            this.Controls.Add(this.aBtxt);
            this.Controls.Add(this.diffButt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bTxt);
            this.Controls.Add(this.aTxt);
            this.Controls.Add(this.sommaButt);
            this.Controls.Add(this.result);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.forButton);
            this.Controls.Add(this.switchButton);
            this.Controls.Add(this.ifButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ifButton;
        private System.Windows.Forms.Button switchButton;
        private System.Windows.Forms.Button forButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.Button sommaButt;
        private System.Windows.Forms.TextBox aTxt;
        private System.Windows.Forms.TextBox bTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button diffButt;
        private System.Windows.Forms.TextBox aBtxt;
        private System.Windows.Forms.TextBox bBtxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label resultB;
        private System.Windows.Forms.Button moltButt;
        private System.Windows.Forms.Button divButt;
        private System.Windows.Forms.TextBox bDtxt;
        private System.Windows.Forms.TextBox bCtxt;
        private System.Windows.Forms.TextBox aDtxt;
        private System.Windows.Forms.TextBox aCtxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label resultC;
        private System.Windows.Forms.Label resultD;
    }
}

