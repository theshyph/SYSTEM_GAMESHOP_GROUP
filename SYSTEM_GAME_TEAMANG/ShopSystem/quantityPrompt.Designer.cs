namespace ShopSystem
{
    partial class quantityPrompt
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
            this.label1 = new System.Windows.Forms.Label();
            this.quantity_TXTBox = new System.Windows.Forms.TextBox();
            this.submit_Btn = new System.Windows.Forms.Button();
            this.add_Btn = new System.Windows.Forms.Button();
            this.subtract_Btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quantity:";
            // 
            // quantity_TXTBox
            // 
            this.quantity_TXTBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantity_TXTBox.Location = new System.Drawing.Point(75, 70);
            this.quantity_TXTBox.Multiline = true;
            this.quantity_TXTBox.Name = "quantity_TXTBox";
            this.quantity_TXTBox.Size = new System.Drawing.Size(351, 48);
            this.quantity_TXTBox.TabIndex = 1;
            this.quantity_TXTBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // submit_Btn
            // 
            this.submit_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submit_Btn.Location = new System.Drawing.Point(332, 124);
            this.submit_Btn.Name = "submit_Btn";
            this.submit_Btn.Size = new System.Drawing.Size(94, 44);
            this.submit_Btn.TabIndex = 2;
            this.submit_Btn.Text = "OK";
            this.submit_Btn.UseVisualStyleBackColor = true;
            // 
            // add_Btn
            // 
            this.add_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_Btn.Location = new System.Drawing.Point(432, 70);
            this.add_Btn.Name = "add_Btn";
            this.add_Btn.Size = new System.Drawing.Size(58, 48);
            this.add_Btn.TabIndex = 3;
            this.add_Btn.Text = "+";
            this.add_Btn.UseVisualStyleBackColor = true;
            this.add_Btn.Click += new System.EventHandler(this.add_Btn_Click);
            // 
            // subtract_Btn
            // 
            this.subtract_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtract_Btn.Location = new System.Drawing.Point(11, 70);
            this.subtract_Btn.Name = "subtract_Btn";
            this.subtract_Btn.Size = new System.Drawing.Size(58, 48);
            this.subtract_Btn.TabIndex = 4;
            this.subtract_Btn.Text = "-";
            this.subtract_Btn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.subtract_Btn.UseVisualStyleBackColor = true;
            this.subtract_Btn.Click += new System.EventHandler(this.subtract_Btn_Click);
            // 
            // quantityPrompt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 179);
            this.Controls.Add(this.subtract_Btn);
            this.Controls.Add(this.add_Btn);
            this.Controls.Add(this.submit_Btn);
            this.Controls.Add(this.quantity_TXTBox);
            this.Controls.Add(this.label1);
            this.Name = "quantityPrompt";
            this.Text = "quantityPrompt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox quantity_TXTBox;
        private System.Windows.Forms.Button submit_Btn;
        private System.Windows.Forms.Button add_Btn;
        private System.Windows.Forms.Button subtract_Btn;
    }
}