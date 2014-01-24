namespace WorkWithClasses
{
    partial class Form2
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.LaAmount = new System.Windows.Forms.Label();
            this.btnAction = new System.Windows.Forms.Button();
            this.rbtnAdd = new System.Windows.Forms.RadioButton();
            this.rbtnSubstract = new System.Windows.Forms.RadioButton();
            this.txbxQty = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(197, 227);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Amount :";
            // 
            // LaAmount
            // 
            this.LaAmount.AutoSize = true;
            this.LaAmount.Location = new System.Drawing.Point(68, 13);
            this.LaAmount.Name = "LaAmount";
            this.LaAmount.Size = new System.Drawing.Size(13, 13);
            this.LaAmount.TabIndex = 2;
            this.LaAmount.Text = "0";
            // 
            // btnAction
            // 
            this.btnAction.Location = new System.Drawing.Point(27, 144);
            this.btnAction.Name = "btnAction";
            this.btnAction.Size = new System.Drawing.Size(75, 23);
            this.btnAction.TabIndex = 3;
            this.btnAction.Text = "Procesar";
            this.btnAction.UseVisualStyleBackColor = true;
            this.btnAction.Click += new System.EventHandler(this.btnAction_Click);
            // 
            // rbtnAdd
            // 
            this.rbtnAdd.AutoSize = true;
            this.rbtnAdd.Checked = true;
            this.rbtnAdd.Location = new System.Drawing.Point(5, 18);
            this.rbtnAdd.Name = "rbtnAdd";
            this.rbtnAdd.Size = new System.Drawing.Size(90, 17);
            this.rbtnAdd.TabIndex = 4;
            this.rbtnAdd.TabStop = true;
            this.rbtnAdd.Text = "Añadir fondos";
            this.rbtnAdd.UseVisualStyleBackColor = true;
            // 
            // rbtnSubstract
            // 
            this.rbtnSubstract.AutoSize = true;
            this.rbtnSubstract.Location = new System.Drawing.Point(5, 41);
            this.rbtnSubstract.Name = "rbtnSubstract";
            this.rbtnSubstract.Size = new System.Drawing.Size(93, 17);
            this.rbtnSubstract.TabIndex = 5;
            this.rbtnSubstract.Text = "Extraer fondos";
            this.rbtnSubstract.UseVisualStyleBackColor = true;
            // 
            // txbxQty
            // 
            this.txbxQty.Location = new System.Drawing.Point(12, 43);
            this.txbxQty.Name = "txbxQty";
            this.txbxQty.Size = new System.Drawing.Size(100, 20);
            this.txbxQty.TabIndex = 6;
            this.txbxQty.Text = "0";
            this.txbxQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnSubstract);
            this.groupBox1.Controls.Add(this.rbtnAdd);
            this.groupBox1.Location = new System.Drawing.Point(7, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(113, 69);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txbxQty);
            this.Controls.Add(this.btnAction);
            this.Controls.Add(this.LaAmount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LaAmount;
        private System.Windows.Forms.Button btnAction;
        private System.Windows.Forms.RadioButton rbtnAdd;
        private System.Windows.Forms.RadioButton rbtnSubstract;
        private System.Windows.Forms.TextBox txbxQty;
        private System.Windows.Forms.GroupBox groupBox1;

    }
}