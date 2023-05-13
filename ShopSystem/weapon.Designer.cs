namespace ShopSystem {
    partial class weapon {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing&&(components!=null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.label1 = new System.Windows.Forms.Label();
            this.weapon_1_Btn = new System.Windows.Forms.Button();
            this.weapon_1_pic = new System.Windows.Forms.PictureBox();
            this.weapon_1_name = new System.Windows.Forms.Label();
            this.weapon_price_1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.weapon_1_pic)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(232, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "WEAPON TAB";
            // 
            // weapon_1_Btn
            // 
            this.weapon_1_Btn.Location = new System.Drawing.Point(33, 53);
            this.weapon_1_Btn.Name = "weapon_1_Btn";
            this.weapon_1_Btn.Size = new System.Drawing.Size(158, 329);
            this.weapon_1_Btn.TabIndex = 1;
            this.weapon_1_Btn.UseVisualStyleBackColor = true;
            // 
            // weapon_1_pic
            // 
            this.weapon_1_pic.Location = new System.Drawing.Point(51, 84);
            this.weapon_1_pic.Name = "weapon_1_pic";
            this.weapon_1_pic.Size = new System.Drawing.Size(120, 113);
            this.weapon_1_pic.TabIndex = 2;
            this.weapon_1_pic.TabStop = false;
            // 
            // weapon_1_name
            // 
            this.weapon_1_name.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.weapon_1_name.AutoSize = true;
            this.weapon_1_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weapon_1_name.Location = new System.Drawing.Point(46, 232);
            this.weapon_1_name.MaximumSize = new System.Drawing.Size(180, 60);
            this.weapon_1_name.Name = "weapon_1_name";
            this.weapon_1_name.Size = new System.Drawing.Size(70, 60);
            this.weapon_1_name.TabIndex = 3;
            this.weapon_1_name.Text = "label2\r\n\r\ngh";
            this.weapon_1_name.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // weapon_price_1
            // 
            this.weapon_price_1.AutoSize = true;
            this.weapon_price_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weapon_price_1.Location = new System.Drawing.Point(75, 295);
            this.weapon_price_1.Name = "weapon_price_1";
            this.weapon_price_1.Size = new System.Drawing.Size(70, 26);
            this.weapon_price_1.TabIndex = 4;
            this.weapon_price_1.Text = "label3";
            // 
            // weapon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.weapon_price_1);
            this.Controls.Add(this.weapon_1_name);
            this.Controls.Add(this.weapon_1_pic);
            this.Controls.Add(this.weapon_1_Btn);
            this.Controls.Add(this.label1);
            this.Name = "weapon";
            this.Size = new System.Drawing.Size(546, 425);
            ((System.ComponentModel.ISupportInitialize)(this.weapon_1_pic)).EndInit();
            //this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button weapon_1_Btn;
        private System.Windows.Forms.PictureBox weapon_1_pic;
        private System.Windows.Forms.Label weapon_price_1;
        private System.Windows.Forms.Label weapon_1_name;
    }
}
