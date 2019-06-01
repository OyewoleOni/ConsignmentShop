namespace ConsignmentShopUI
{
    partial class ConsignmentShop
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
            this.lblHeaderText = new System.Windows.Forms.Label();
            this.itemsListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddToCart = new System.Windows.Forms.Button();
            this.lblShopingCartlistBoxlabe = new System.Windows.Forms.Label();
            this.shoppingCartListBox = new System.Windows.Forms.ListBox();
            this.btnMakePurchase = new System.Windows.Forms.Button();
            this.lblVendorList = new System.Windows.Forms.Label();
            this.vendorListBox = new System.Windows.Forms.ListBox();
            this.lblStoreProfit = new System.Windows.Forms.Label();
            this.lblStoreProfitValue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblHeaderText
            // 
            this.lblHeaderText.AutoSize = true;
            this.lblHeaderText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeaderText.Location = new System.Drawing.Point(49, 30);
            this.lblHeaderText.Name = "lblHeaderText";
            this.lblHeaderText.Size = new System.Drawing.Size(213, 20);
            this.lblHeaderText.TabIndex = 0;
            this.lblHeaderText.Text = "Consignment Shop Demo";
            // 
            // itemsListBox
            // 
            this.itemsListBox.FormattingEnabled = true;
            this.itemsListBox.ItemHeight = 20;
            this.itemsListBox.Location = new System.Drawing.Point(53, 107);
            this.itemsListBox.Name = "itemsListBox";
            this.itemsListBox.Size = new System.Drawing.Size(223, 124);
            this.itemsListBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Store Items";
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddToCart.Location = new System.Drawing.Point(297, 159);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new System.Drawing.Size(107, 29);
            this.btnAddToCart.TabIndex = 3;
            this.btnAddToCart.Text = "Add To Cart ->";
            this.btnAddToCart.UseVisualStyleBackColor = true;
            this.btnAddToCart.Click += new System.EventHandler(this.btnAddToCart_Click);
            // 
            // lblShopingCartlistBoxlabe
            // 
            this.lblShopingCartlistBoxlabe.AutoSize = true;
            this.lblShopingCartlistBoxlabe.Location = new System.Drawing.Point(452, 74);
            this.lblShopingCartlistBoxlabe.Name = "lblShopingCartlistBoxlabe";
            this.lblShopingCartlistBoxlabe.Size = new System.Drawing.Size(111, 20);
            this.lblShopingCartlistBoxlabe.TabIndex = 5;
            this.lblShopingCartlistBoxlabe.Text = "Shoppnig Cart";
            // 
            // shoppingCartListBox
            // 
            this.shoppingCartListBox.FormattingEnabled = true;
            this.shoppingCartListBox.ItemHeight = 20;
            this.shoppingCartListBox.Location = new System.Drawing.Point(435, 107);
            this.shoppingCartListBox.Name = "shoppingCartListBox";
            this.shoppingCartListBox.Size = new System.Drawing.Size(221, 124);
            this.shoppingCartListBox.TabIndex = 4;
            // 
            // btnMakePurchase
            // 
            this.btnMakePurchase.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMakePurchase.Location = new System.Drawing.Point(549, 255);
            this.btnMakePurchase.Name = "btnMakePurchase";
            this.btnMakePurchase.Size = new System.Drawing.Size(107, 29);
            this.btnMakePurchase.TabIndex = 6;
            this.btnMakePurchase.Text = "Purchase";
            this.btnMakePurchase.UseVisualStyleBackColor = true;
            this.btnMakePurchase.Click += new System.EventHandler(this.btnMakePurchase_Click);
            // 
            // lblVendorList
            // 
            this.lblVendorList.AutoSize = true;
            this.lblVendorList.Location = new System.Drawing.Point(53, 295);
            this.lblVendorList.Name = "lblVendorList";
            this.lblVendorList.Size = new System.Drawing.Size(90, 20);
            this.lblVendorList.TabIndex = 8;
            this.lblVendorList.Text = "Vendor List";
            // 
            // vendorListBox
            // 
            this.vendorListBox.FormattingEnabled = true;
            this.vendorListBox.ItemHeight = 20;
            this.vendorListBox.Location = new System.Drawing.Point(53, 328);
            this.vendorListBox.Name = "vendorListBox";
            this.vendorListBox.Size = new System.Drawing.Size(223, 124);
            this.vendorListBox.TabIndex = 7;
            // 
            // lblStoreProfit
            // 
            this.lblStoreProfit.AutoSize = true;
            this.lblStoreProfit.Location = new System.Drawing.Point(431, 328);
            this.lblStoreProfit.Name = "lblStoreProfit";
            this.lblStoreProfit.Size = new System.Drawing.Size(89, 20);
            this.lblStoreProfit.TabIndex = 9;
            this.lblStoreProfit.Text = "Store Profit";
            // 
            // lblStoreProfitValue
            // 
            this.lblStoreProfitValue.AutoSize = true;
            this.lblStoreProfitValue.Location = new System.Drawing.Point(545, 328);
            this.lblStoreProfitValue.Name = "lblStoreProfitValue";
            this.lblStoreProfitValue.Size = new System.Drawing.Size(49, 20);
            this.lblStoreProfitValue.TabIndex = 10;
            this.lblStoreProfitValue.Text = "$0.00";
            // 
            // ConsignmentShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 507);
            this.Controls.Add(this.lblStoreProfitValue);
            this.Controls.Add(this.lblStoreProfit);
            this.Controls.Add(this.lblVendorList);
            this.Controls.Add(this.vendorListBox);
            this.Controls.Add(this.btnMakePurchase);
            this.Controls.Add(this.lblShopingCartlistBoxlabe);
            this.Controls.Add(this.shoppingCartListBox);
            this.Controls.Add(this.btnAddToCart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.itemsListBox);
            this.Controls.Add(this.lblHeaderText);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ConsignmentShop";
            this.Text = "Consignment Shop Demo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeaderText;
        private System.Windows.Forms.ListBox itemsListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddToCart;
        private System.Windows.Forms.Label lblShopingCartlistBoxlabe;
        private System.Windows.Forms.ListBox shoppingCartListBox;
        private System.Windows.Forms.Button btnMakePurchase;
        private System.Windows.Forms.Label lblVendorList;
        private System.Windows.Forms.ListBox vendorListBox;
        private System.Windows.Forms.Label lblStoreProfit;
        private System.Windows.Forms.Label lblStoreProfitValue;
    }
}

