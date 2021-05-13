
namespace ConsignmentShopUI
{
    partial class ConsignementShop
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
            this.headerText = new System.Windows.Forms.Label();
            this.itemsListBox = new System.Windows.Forms.ListBox();
            this.itemsListBoxLabel = new System.Windows.Forms.Label();
            this.AddItemToCart = new System.Windows.Forms.Button();
            this.itemsCartListBoxLabel = new System.Windows.Forms.Label();
            this.itemsCartListBox = new System.Windows.Forms.ListBox();
            this.RemoveFromItemsCart = new System.Windows.Forms.Button();
            this.PurchaseCart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // headerText
            // 
            this.headerText.AutoSize = true;
            this.headerText.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.headerText.Location = new System.Drawing.Point(36, 9);
            this.headerText.Name = "headerText";
            this.headerText.Size = new System.Drawing.Size(318, 32);
            this.headerText.TabIndex = 0;
            this.headerText.Text = "Consignement Shop Demo";
            // 
            // itemsListBox
            // 
            this.itemsListBox.FormattingEnabled = true;
            this.itemsListBox.ItemHeight = 28;
            this.itemsListBox.Location = new System.Drawing.Point(36, 88);
            this.itemsListBox.Name = "itemsListBox";
            this.itemsListBox.Size = new System.Drawing.Size(369, 284);
            this.itemsListBox.TabIndex = 1;
            // 
            // itemsListBoxLabel
            // 
            this.itemsListBoxLabel.AutoSize = true;
            this.itemsListBoxLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.itemsListBoxLabel.Location = new System.Drawing.Point(37, 57);
            this.itemsListBoxLabel.Name = "itemsListBoxLabel";
            this.itemsListBoxLabel.Size = new System.Drawing.Size(120, 28);
            this.itemsListBoxLabel.TabIndex = 2;
            this.itemsListBoxLabel.Text = "Store items";
            // 
            // AddItemToCart
            // 
            this.AddItemToCart.Location = new System.Drawing.Point(456, 164);
            this.AddItemToCart.Name = "AddItemToCart";
            this.AddItemToCart.Size = new System.Drawing.Size(181, 37);
            this.AddItemToCart.TabIndex = 3;
            this.AddItemToCart.Text = "Add to cart";
            this.AddItemToCart.UseVisualStyleBackColor = true;
            this.AddItemToCart.Click += new System.EventHandler(this.AddItemToCart_Click);
            // 
            // itemsCartListBoxLabel
            // 
            this.itemsCartListBoxLabel.AutoSize = true;
            this.itemsCartListBoxLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.itemsCartListBoxLabel.Location = new System.Drawing.Point(698, 57);
            this.itemsCartListBoxLabel.Name = "itemsCartListBoxLabel";
            this.itemsCartListBoxLabel.Size = new System.Drawing.Size(145, 28);
            this.itemsCartListBoxLabel.TabIndex = 5;
            this.itemsCartListBoxLabel.Text = "Shopping cart";
            // 
            // itemsCartListBox
            // 
            this.itemsCartListBox.FormattingEnabled = true;
            this.itemsCartListBox.ItemHeight = 28;
            this.itemsCartListBox.Location = new System.Drawing.Point(697, 88);
            this.itemsCartListBox.Name = "itemsCartListBox";
            this.itemsCartListBox.Size = new System.Drawing.Size(373, 284);
            this.itemsCartListBox.TabIndex = 4;
            // 
            // RemoveFromItemsCart
            // 
            this.RemoveFromItemsCart.Location = new System.Drawing.Point(456, 245);
            this.RemoveFromItemsCart.Name = "RemoveFromItemsCart";
            this.RemoveFromItemsCart.Size = new System.Drawing.Size(181, 42);
            this.RemoveFromItemsCart.TabIndex = 6;
            this.RemoveFromItemsCart.Text = "Remove from cart";
            this.RemoveFromItemsCart.UseVisualStyleBackColor = true;
            this.RemoveFromItemsCart.Click += new System.EventHandler(this.RemoveFromItemsCart_Click);
            // 
            // PurchaseCart
            // 
            this.PurchaseCart.Location = new System.Drawing.Point(961, 436);
            this.PurchaseCart.Name = "PurchaseCart";
            this.PurchaseCart.Size = new System.Drawing.Size(109, 41);
            this.PurchaseCart.TabIndex = 7;
            this.PurchaseCart.Text = "Purchase";
            this.PurchaseCart.UseVisualStyleBackColor = true;
            this.PurchaseCart.Click += new System.EventHandler(this.PurchaseCart_Click);
            // 
            // ConsignementShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1105, 628);
            this.Controls.Add(this.PurchaseCart);
            this.Controls.Add(this.RemoveFromItemsCart);
            this.Controls.Add(this.itemsCartListBoxLabel);
            this.Controls.Add(this.itemsCartListBox);
            this.Controls.Add(this.AddItemToCart);
            this.Controls.Add(this.itemsListBoxLabel);
            this.Controls.Add(this.itemsListBox);
            this.Controls.Add(this.headerText);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "ConsignementShop";
            this.Text = "ConsignementShopDemo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headerText;
        private System.Windows.Forms.ListBox itemsListBox;
        private System.Windows.Forms.Label itemsListBoxLabel;
        private System.Windows.Forms.Button AddItemToCart;
        private System.Windows.Forms.Label itemsCartListBoxLabel;
        private System.Windows.Forms.ListBox itemsCartListBox;
        private System.Windows.Forms.Button RemoveFromItemsCart;
        private System.Windows.Forms.Button PurchaseCart;
    }
}