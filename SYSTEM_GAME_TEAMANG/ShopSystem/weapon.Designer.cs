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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(weapon));
            this.label1 = new System.Windows.Forms.Label();
            this.weapon_1_Btn = new System.Windows.Forms.Button();
            this.weapon_1_pic = new System.Windows.Forms.PictureBox();
            this.weapon_1_name = new System.Windows.Forms.Label();
            this.weapon_1_price = new System.Windows.Forms.Label();
            this.weapon_1_desc = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
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
            this.weapon_1_Btn.Location = new System.Drawing.Point(33, 65);
            this.weapon_1_Btn.Name = "weapon_1_Btn";
            this.weapon_1_Btn.Size = new System.Drawing.Size(207, 317);
            this.weapon_1_Btn.TabIndex = 1;
            this.weapon_1_Btn.UseVisualStyleBackColor = true;
            this.weapon_1_Btn.Click += new System.EventHandler(this.weapon_1_Btn_Click);
            // 
            // weapon_1_pic
            // 
            this.weapon_1_pic.Image = ((System.Drawing.Image)(resources.GetObject("weapon_1_pic.Image")));
            this.weapon_1_pic.Location = new System.Drawing.Point(71, 84);
            this.weapon_1_pic.Name = "weapon_1_pic";
            this.weapon_1_pic.Size = new System.Drawing.Size(120, 113);
            this.weapon_1_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.weapon_1_pic.TabIndex = 2;
            this.weapon_1_pic.TabStop = false;
            // 
            // weapon_1_name
            // 
            this.weapon_1_name.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.weapon_1_name.AutoSize = true;
            this.weapon_1_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weapon_1_name.Location = new System.Drawing.Point(56, 208);
            this.weapon_1_name.MaximumSize = new System.Drawing.Size(180, 60);
            this.weapon_1_name.Name = "weapon_1_name";
            this.weapon_1_name.Size = new System.Drawing.Size(154, 26);
            this.weapon_1_name.TabIndex = 3;
            this.weapon_1_name.Text = "Weapon name";
            this.weapon_1_name.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // weapon_1_price
            // 
            this.weapon_1_price.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.weapon_1_price.AutoSize = true;
            this.weapon_1_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weapon_1_price.Location = new System.Drawing.Point(56, 243);
            this.weapon_1_price.MaximumSize = new System.Drawing.Size(180, 60);
            this.weapon_1_price.Name = "weapon_1_price";
            this.weapon_1_price.Size = new System.Drawing.Size(59, 26);
            this.weapon_1_price.TabIndex = 6;
            this.weapon_1_price.Text = "price";
            this.weapon_1_price.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // weapon_1_desc
            // 
            this.weapon_1_desc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.weapon_1_desc.AutoSize = true;
            this.weapon_1_desc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weapon_1_desc.Location = new System.Drawing.Point(57, 279);
            this.weapon_1_desc.MaximumSize = new System.Drawing.Size(180, 60);
            this.weapon_1_desc.Name = "weapon_1_desc";
            this.weapon_1_desc.Size = new System.Drawing.Size(47, 20);
            this.weapon_1_desc.TabIndex = 7;
            this.weapon_1_desc.Text = "desc:";
            this.weapon_1_desc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(246, 65);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(207, 317);
            this.button1.TabIndex = 8;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(459, 65);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(207, 317);
            this.button2.TabIndex = 9;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // weapon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.weapon_1_desc);
            this.Controls.Add(this.weapon_1_price);
            this.Controls.Add(this.weapon_1_name);
            this.Controls.Add(this.weapon_1_pic);
            this.Controls.Add(this.weapon_1_Btn);
            this.Controls.Add(this.label1);
            this.Name = "weapon";
            this.Size = new System.Drawing.Size(700, 425);
            ((System.ComponentModel.ISupportInitialize)(this.weapon_1_pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button weapon_1_Btn;
        private System.Windows.Forms.PictureBox weapon_1_pic;
        private System.Windows.Forms.Label weapon_1_name;
        private System.Windows.Forms.Label weapon_1_price;
        private System.Windows.Forms.Label weapon_1_desc;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}
