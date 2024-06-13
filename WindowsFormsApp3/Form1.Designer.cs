namespace WindowsFormsApp3
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
            this.label1 = new System.Windows.Forms.Label();
            this.textIngresa = new System.Windows.Forms.TextBox();
            this.buttonIngresa = new System.Windows.Forms.Button();
            this.buttonSale = new System.Windows.Forms.Button();
            this.textSale = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DGBtabla = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGBtabla)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ingresar auto";
            // 
            // textIngresa
            // 
            this.textIngresa.Location = new System.Drawing.Point(12, 25);
            this.textIngresa.Name = "textIngresa";
            this.textIngresa.Size = new System.Drawing.Size(100, 20);
            this.textIngresa.TabIndex = 1;
            // 
            // buttonIngresa
            // 
            this.buttonIngresa.Location = new System.Drawing.Point(12, 51);
            this.buttonIngresa.Name = "buttonIngresa";
            this.buttonIngresa.Size = new System.Drawing.Size(100, 23);
            this.buttonIngresa.TabIndex = 2;
            this.buttonIngresa.Text = "ingresar";
            this.buttonIngresa.UseVisualStyleBackColor = true;
            this.buttonIngresa.Click += new System.EventHandler(this.buttonIngresa_Click);
            // 
            // buttonSale
            // 
            this.buttonSale.Location = new System.Drawing.Point(12, 145);
            this.buttonSale.Name = "buttonSale";
            this.buttonSale.Size = new System.Drawing.Size(100, 23);
            this.buttonSale.TabIndex = 5;
            this.buttonSale.Text = "sale";
            this.buttonSale.UseVisualStyleBackColor = true;
            this.buttonSale.Click += new System.EventHandler(this.buttonSale_Click);
            // 
            // textSale
            // 
            this.textSale.Location = new System.Drawing.Point(12, 119);
            this.textSale.Name = "textSale";
            this.textSale.Size = new System.Drawing.Size(100, 20);
            this.textSale.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sale auto";
            // 
            // DGBtabla
            // 
            this.DGBtabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGBtabla.Location = new System.Drawing.Point(203, 12);
            this.DGBtabla.Name = "DGBtabla";
            this.DGBtabla.Size = new System.Drawing.Size(500, 333);
            this.DGBtabla.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 424);
            this.Controls.Add(this.DGBtabla);
            this.Controls.Add(this.buttonIngresa);
            this.Controls.Add(this.buttonSale);
            this.Controls.Add(this.textSale);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textIngresa);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGBtabla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textIngresa;
        private System.Windows.Forms.Button buttonIngresa;
        private System.Windows.Forms.Button buttonSale;
        private System.Windows.Forms.TextBox textSale;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView DGBtabla;
    }
}

