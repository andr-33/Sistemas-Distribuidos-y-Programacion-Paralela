namespace Client
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbFromCurrency = new System.Windows.Forms.ComboBox();
            this.cbToCurrency = new System.Windows.Forms.ComboBox();
            this.lbTitle = new System.Windows.Forms.Label();
            this.lbFrom = new System.Windows.Forms.Label();
            this.tbAmount = new System.Windows.Forms.TextBox();
            this.lbTo = new System.Windows.Forms.Label();
            this.lbAmount = new System.Windows.Forms.Label();
            this.lbResult = new System.Windows.Forms.Label();
            this.lbNewAmount = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbFromCurrency
            // 
            this.cbFromCurrency.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbFromCurrency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFromCurrency.FormattingEnabled = true;
            this.cbFromCurrency.Items.AddRange(new object[] {
            "EUR",
            "USD"});
            this.cbFromCurrency.Location = new System.Drawing.Point(94, 74);
            this.cbFromCurrency.Name = "cbFromCurrency";
            this.cbFromCurrency.Size = new System.Drawing.Size(66, 21);
            this.cbFromCurrency.TabIndex = 0;
            // 
            // cbToCurrency
            // 
            this.cbToCurrency.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbToCurrency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbToCurrency.FormattingEnabled = true;
            this.cbToCurrency.Items.AddRange(new object[] {
            "EUR",
            "USD"});
            this.cbToCurrency.Location = new System.Drawing.Point(94, 110);
            this.cbToCurrency.Name = "cbToCurrency";
            this.cbToCurrency.Size = new System.Drawing.Size(66, 21);
            this.cbToCurrency.TabIndex = 1;
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft YaHei UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(33, 9);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(187, 46);
            this.lbTitle.TabIndex = 2;
            this.lbTitle.Text = "Exchange";
            // 
            // lbFrom
            // 
            this.lbFrom.AutoSize = true;
            this.lbFrom.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFrom.Location = new System.Drawing.Point(34, 74);
            this.lbFrom.Name = "lbFrom";
            this.lbFrom.Size = new System.Drawing.Size(54, 21);
            this.lbFrom.TabIndex = 3;
            this.lbFrom.Text = "From:";
            // 
            // tbAmount
            // 
            this.tbAmount.Location = new System.Drawing.Point(94, 141);
            this.tbAmount.Name = "tbAmount";
            this.tbAmount.Size = new System.Drawing.Size(66, 20);
            this.tbAmount.TabIndex = 6;
            // 
            // lbTo
            // 
            this.lbTo.AutoSize = true;
            this.lbTo.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTo.Location = new System.Drawing.Point(55, 110);
            this.lbTo.Name = "lbTo";
            this.lbTo.Size = new System.Drawing.Size(33, 21);
            this.lbTo.TabIndex = 7;
            this.lbTo.Text = "To:";
            // 
            // lbAmount
            // 
            this.lbAmount.AutoSize = true;
            this.lbAmount.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAmount.Location = new System.Drawing.Point(12, 141);
            this.lbAmount.Name = "lbAmount";
            this.lbAmount.Size = new System.Drawing.Size(76, 21);
            this.lbAmount.TabIndex = 8;
            this.lbAmount.Text = "Amount:";
            // 
            // lbResult
            // 
            this.lbResult.AutoSize = true;
            this.lbResult.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResult.Location = new System.Drawing.Point(28, 176);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(60, 21);
            this.lbResult.TabIndex = 9;
            this.lbResult.Text = "Result:";
            // 
            // lbNewAmount
            // 
            this.lbNewAmount.AutoSize = true;
            this.lbNewAmount.Location = new System.Drawing.Point(94, 182);
            this.lbNewAmount.Name = "lbNewAmount";
            this.lbNewAmount.Size = new System.Drawing.Size(0, 13);
            this.lbNewAmount.TabIndex = 10;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.Khaki;
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(181, 142);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(64, 23);
            this.btnSubmit.TabIndex = 11;
            this.btnSubmit.Text = "Go!";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(257, 263);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lbNewAmount);
            this.Controls.Add(this.lbResult);
            this.Controls.Add(this.lbAmount);
            this.Controls.Add(this.lbTo);
            this.Controls.Add(this.tbAmount);
            this.Controls.Add(this.lbFrom);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.cbToCurrency);
            this.Controls.Add(this.cbFromCurrency);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbFromCurrency;
        private System.Windows.Forms.ComboBox cbToCurrency;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Label lbFrom;
        private System.Windows.Forms.TextBox tbAmount;
        private System.Windows.Forms.Label lbTo;
        private System.Windows.Forms.Label lbAmount;
        private System.Windows.Forms.Label lbResult;
        private System.Windows.Forms.Label lbNewAmount;
        private System.Windows.Forms.Button btnSubmit;
    }
}

