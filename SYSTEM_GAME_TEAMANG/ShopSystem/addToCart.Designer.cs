namespace ShopSystem
{
    partial class addToCart
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
            this.addtocart_checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.total_Label = new System.Windows.Forms.Label();
            this.total_Placeholder = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // addtocart_checkedListBox1
            // 
            this.addtocart_checkedListBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addtocart_checkedListBox1.FormattingEnabled = true;
            this.addtocart_checkedListBox1.Location = new System.Drawing.Point(34, 37);
            this.addtocart_checkedListBox1.Name = "addtocart_checkedListBox1";
            this.addtocart_checkedListBox1.Size = new System.Drawing.Size(583, 364);
            this.addtocart_checkedListBox1.TabIndex = 0;
            this.addtocart_checkedListBox1.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.when_Checkbox_checked);
            // 
            // total_Label
            // 
            this.total_Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.total_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_Label.ForeColor = System.Drawing.SystemColors.ControlText;
            this.total_Label.Location = new System.Drawing.Point(532, 421);
            this.total_Label.Name = "total_Label";
            this.total_Label.Size = new System.Drawing.Size(175, 37);
            this.total_Label.TabIndex = 1;
            this.total_Label.Text = "Total: ";
            // 
            // total_Placeholder
            // 
            this.total_Placeholder.AutoSize = true;
            this.total_Placeholder.BackColor = System.Drawing.Color.Transparent;
            this.total_Placeholder.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_Placeholder.Location = new System.Drawing.Point(623, 424);
            this.total_Placeholder.Name = "total_Placeholder";
            this.total_Placeholder.Size = new System.Drawing.Size(31, 33);
            this.total_Placeholder.TabIndex = 2;
            this.total_Placeholder.Text = "0";
            // 
            // addToCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 479);
            this.Controls.Add(this.total_Placeholder);
            this.Controls.Add(this.total_Label);
            this.Controls.Add(this.addtocart_checkedListBox1);
            this.Name = "addToCart";
            this.Text = "addToCart";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox addtocart_checkedListBox1;
        private System.Windows.Forms.Label total_Label;
        private System.Windows.Forms.Label total_Placeholder;
    }
}