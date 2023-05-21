namespace ShopSystem {
    partial class Form1 {
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.weaponBTN = new System.Windows.Forms.Button();
            this.generalBTN = new System.Windows.Forms.Button();
            this.armorBTN = new System.Windows.Forms.Button();
            this.cart = new System.Windows.Forms.Button();
            this.total = new System.Windows.Forms.Panel();
            this.total_label2 = new System.Windows.Forms.Label();
            this.sell = new System.Windows.Forms.Button();
            this.Buy = new System.Windows.Forms.Button();
            this.pictureBox_Merchant = new System.Windows.Forms.PictureBox();
            this.MenuLabel = new System.Windows.Forms.Label();
            this.Currency_label = new System.Windows.Forms.Label();
            this.placeHolder_Quanti = new System.Windows.Forms.Label();
            this.armor1 = new ShopSystem.armor();
            this.general1 = new ShopSystem.general();
            this.weapon1 = new ShopSystem.weapon();
            this.total.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Merchant)).BeginInit();
            this.SuspendLayout();
            // 
            // weaponBTN
            // 
            this.weaponBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weaponBTN.Location = new System.Drawing.Point(12, 12);
            this.weaponBTN.Name = "weaponBTN";
            this.weaponBTN.Size = new System.Drawing.Size(121, 41);
            this.weaponBTN.TabIndex = 0;
            this.weaponBTN.Text = "Weapon";
            this.weaponBTN.UseVisualStyleBackColor = true;
            this.weaponBTN.Click += new System.EventHandler(this.weapon_Click);
            // 
            // generalBTN
            // 
            this.generalBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generalBTN.Location = new System.Drawing.Point(157, 12);
            this.generalBTN.Name = "generalBTN";
            this.generalBTN.Size = new System.Drawing.Size(126, 41);
            this.generalBTN.TabIndex = 1;
            this.generalBTN.Text = "General";
            this.generalBTN.UseVisualStyleBackColor = true;
            this.generalBTN.Click += new System.EventHandler(this.general_Click);
            // 
            // armorBTN
            // 
            this.armorBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.armorBTN.Location = new System.Drawing.Point(305, 12);
            this.armorBTN.Name = "armorBTN";
            this.armorBTN.Size = new System.Drawing.Size(119, 41);
            this.armorBTN.TabIndex = 2;
            this.armorBTN.Text = "Armor";
            this.armorBTN.UseVisualStyleBackColor = true;
            this.armorBTN.Click += new System.EventHandler(this.armor_Click);
            // 
            // cart
            // 
            this.cart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cart.Location = new System.Drawing.Point(12, 574);
            this.cart.Name = "cart";
            this.cart.Size = new System.Drawing.Size(103, 41);
            this.cart.TabIndex = 4;
            this.cart.Text = "Cart";
            this.cart.UseVisualStyleBackColor = true;
            this.cart.Click += new System.EventHandler(this.cart_Click);
            // 
            // total
            // 
            this.total.BackColor = System.Drawing.SystemColors.ControlLight;
            this.total.Controls.Add(this.total_label2);
            this.total.Location = new System.Drawing.Point(130, 574);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(189, 41);
            this.total.TabIndex = 5;
            // 
            // total_label2
            // 
            this.total_label2.AutoSize = true;
            this.total_label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_label2.Location = new System.Drawing.Point(3, 11);
            this.total_label2.Name = "total_label2";
            this.total_label2.Size = new System.Drawing.Size(45, 18);
            this.total_label2.TabIndex = 1;
            this.total_label2.Text = "Total:";
            // 
            // sell
            // 
            this.sell.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sell.Location = new System.Drawing.Point(438, 574);
            this.sell.Name = "sell";
            this.sell.Size = new System.Drawing.Size(103, 41);
            this.sell.TabIndex = 6;
            this.sell.Text = "Sell";
            this.sell.UseVisualStyleBackColor = true;
            // 
            // Buy
            // 
            this.Buy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Buy.Location = new System.Drawing.Point(547, 574);
            this.Buy.Name = "Buy";
            this.Buy.Size = new System.Drawing.Size(103, 41);
            this.Buy.TabIndex = 7;
            this.Buy.Text = "Buy";
            this.Buy.UseVisualStyleBackColor = true;
            // 
            // pictureBox_Merchant
            // 
            this.pictureBox_Merchant.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_Merchant.Image")));
            this.pictureBox_Merchant.Location = new System.Drawing.Point(673, 12);
            this.pictureBox_Merchant.Name = "pictureBox_Merchant";
            this.pictureBox_Merchant.Size = new System.Drawing.Size(404, 581);
            this.pictureBox_Merchant.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Merchant.TabIndex = 11;
            this.pictureBox_Merchant.TabStop = false;
            // 
            // MenuLabel
            // 
            this.MenuLabel.AutoSize = true;
            this.MenuLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuLabel.Location = new System.Drawing.Point(188, 90);
            this.MenuLabel.Name = "MenuLabel";
            this.MenuLabel.Size = new System.Drawing.Size(236, 39);
            this.MenuLabel.TabIndex = 12;
            this.MenuLabel.Text = "* WEAPONS *";
            // 
            // Currency_label
            // 
            this.Currency_label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Currency_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Currency_label.Location = new System.Drawing.Point(441, 12);
            this.Currency_label.Name = "Currency_label";
            this.Currency_label.Size = new System.Drawing.Size(209, 41);
            this.Currency_label.TabIndex = 13;
            this.Currency_label.Text = "Currency:";
            // 
            // placeHolder_Quanti
            // 
            this.placeHolder_Quanti.AutoSize = true;
            this.placeHolder_Quanti.Font = new System.Drawing.Font("Monotype Corsiva", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.placeHolder_Quanti.Location = new System.Drawing.Point(567, 14);
            this.placeHolder_Quanti.Name = "placeHolder_Quanti";
            this.placeHolder_Quanti.Size = new System.Drawing.Size(27, 33);
            this.placeHolder_Quanti.TabIndex = 14;
            this.placeHolder_Quanti.Text = "0";
            // 
            // armor1
            // 
            this.armor1.AutoScroll = true;
            this.armor1.Location = new System.Drawing.Point(12, 90);
            this.armor1.Name = "armor1";
            this.armor1.Size = new System.Drawing.Size(546, 425);
            this.armor1.TabIndex = 10;
            // 
            // general1
            // 
            this.general1.AutoScroll = true;
            this.general1.Location = new System.Drawing.Point(12, 90);
            this.general1.Name = "general1";
            this.general1.Size = new System.Drawing.Size(546, 425);
            this.general1.TabIndex = 9;
            // 
            // weapon1
            // 
            this.weapon1.AutoScroll = true;
            this.weapon1.Location = new System.Drawing.Point(12, 90);
            this.weapon1.Name = "weapon1";
            this.weapon1.Size = new System.Drawing.Size(546, 425);
            this.weapon1.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 677);
            this.Controls.Add(this.placeHolder_Quanti);
            this.Controls.Add(this.Currency_label);
            this.Controls.Add(this.MenuLabel);
            this.Controls.Add(this.pictureBox_Merchant);
            this.Controls.Add(this.armor1);
            this.Controls.Add(this.general1);
            this.Controls.Add(this.weapon1);
            this.Controls.Add(this.Buy);
            this.Controls.Add(this.sell);
            this.Controls.Add(this.total);
            this.Controls.Add(this.cart);
            this.Controls.Add(this.armorBTN);
            this.Controls.Add(this.generalBTN);
            this.Controls.Add(this.weaponBTN);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.total.ResumeLayout(false);
            this.total.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Merchant)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button weaponBTN;
        private System.Windows.Forms.Button generalBTN;
        private System.Windows.Forms.Button armorBTN;
        private System.Windows.Forms.Button cart;
        private System.Windows.Forms.Panel total;
        private System.Windows.Forms.Label total_label2;
        private System.Windows.Forms.Button sell;
        private System.Windows.Forms.Button Buy;
        private weapon weapon1;
        private general general1;
        private armor armor1;
        private System.Windows.Forms.PictureBox pictureBox_Merchant;
        private System.Windows.Forms.Label MenuLabel;
        private System.Windows.Forms.Label Currency_label;
        private System.Windows.Forms.Label placeHolder_Quanti;
    }
}

