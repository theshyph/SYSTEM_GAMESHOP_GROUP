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
            this.weaponBTN = new System.Windows.Forms.Button();
            this.generalBTN = new System.Windows.Forms.Button();
            this.armorBTN = new System.Windows.Forms.Button();
            this.currency_panel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cart = new System.Windows.Forms.Button();
            this.total = new System.Windows.Forms.Panel();
            this.total_label2 = new System.Windows.Forms.Label();
            this.sell = new System.Windows.Forms.Button();
            this.Buy = new System.Windows.Forms.Button();
            this.armor1 = new ShopSystem.armor();
            this.general1 = new ShopSystem.general();
            this.weapon1 = new ShopSystem.weapon();
            this.currency_panel.SuspendLayout();
            this.total.SuspendLayout();
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
            // currency_panel
            // 
            this.currency_panel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.currency_panel.Controls.Add(this.label1);
            this.currency_panel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currency_panel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.currency_panel.Location = new System.Drawing.Point(449, 12);
            this.currency_panel.Name = "currency_panel";
            this.currency_panel.Size = new System.Drawing.Size(200, 41);
            this.currency_panel.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "currency";
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
            // armor1
            // 
            this.armor1.Location = new System.Drawing.Point(12, 90);
            this.armor1.Name = "armor1";
            this.armor1.Size = new System.Drawing.Size(546, 425);
            this.armor1.TabIndex = 10;
            // 
            // general1
            // 
            this.general1.Location = new System.Drawing.Point(12, 90);
            this.general1.Name = "general1";
            this.general1.Size = new System.Drawing.Size(546, 425);
            this.general1.TabIndex = 9;
            // 
            // weapon1
            // 
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
            this.Controls.Add(this.armor1);
            this.Controls.Add(this.general1);
            this.Controls.Add(this.weapon1);
            this.Controls.Add(this.Buy);
            this.Controls.Add(this.sell);
            this.Controls.Add(this.total);
            this.Controls.Add(this.cart);
            this.Controls.Add(this.currency_panel);
            this.Controls.Add(this.armorBTN);
            this.Controls.Add(this.generalBTN);
            this.Controls.Add(this.weaponBTN);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.currency_panel.ResumeLayout(false);
            this.currency_panel.PerformLayout();
            this.total.ResumeLayout(false);
            this.total.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button weaponBTN;
        private System.Windows.Forms.Button generalBTN;
        private System.Windows.Forms.Button armorBTN;
        private System.Windows.Forms.Panel currency_panel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cart;
        private System.Windows.Forms.Panel total;
        private System.Windows.Forms.Label total_label2;
        private System.Windows.Forms.Button sell;
        private System.Windows.Forms.Button Buy;
        private weapon weapon1;
        private general general1;
        private armor armor1;
    }
}

