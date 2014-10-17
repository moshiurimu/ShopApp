namespace ShopApp
{
    partial class ShopUI
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
            this.showButton = new System.Windows.Forms.Button();
            this.addItemButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.itemIdTextBox = new System.Windows.Forms.TextBox();
            this.shopAddressTextBox = new System.Windows.Forms.TextBox();
            this.shopNameTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // showButton
            // 
            this.showButton.Location = new System.Drawing.Point(148, 303);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(75, 23);
            this.showButton.TabIndex = 2;
            this.showButton.Text = "Show";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // addItemButton
            // 
            this.addItemButton.Location = new System.Drawing.Point(229, 85);
            this.addItemButton.Name = "addItemButton";
            this.addItemButton.Size = new System.Drawing.Size(79, 22);
            this.addItemButton.TabIndex = 2;
            this.addItemButton.Text = "Add Item";
            this.addItemButton.UseVisualStyleBackColor = true;
            this.addItemButton.Click += new System.EventHandler(this.addItemButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(229, 114);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 2;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.Location = new System.Drawing.Point(98, 59);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(206, 20);
            this.quantityTextBox.TabIndex = 1;
            // 
            // itemIdTextBox
            // 
            this.itemIdTextBox.Location = new System.Drawing.Point(98, 31);
            this.itemIdTextBox.Name = "itemIdTextBox";
            this.itemIdTextBox.Size = new System.Drawing.Size(206, 20);
            this.itemIdTextBox.TabIndex = 0;
            // 
            // shopAddressTextBox
            // 
            this.shopAddressTextBox.Location = new System.Drawing.Point(98, 60);
            this.shopAddressTextBox.Multiline = true;
            this.shopAddressTextBox.Name = "shopAddressTextBox";
            this.shopAddressTextBox.Size = new System.Drawing.Size(206, 48);
            this.shopAddressTextBox.TabIndex = 1;
            // 
            // shopNameTextBox
            // 
            this.shopNameTextBox.Location = new System.Drawing.Point(98, 34);
            this.shopNameTextBox.Name = "shopNameTextBox";
            this.shopNameTextBox.Size = new System.Drawing.Size(206, 20);
            this.shopNameTextBox.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Quantity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Product/Item Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Address";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Shop Name";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.shopAddressTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.saveButton);
            this.groupBox1.Controls.Add(this.shopNameTextBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(347, 154);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Shop Entry";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.itemIdTextBox);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.addItemButton);
            this.groupBox2.Controls.Add(this.quantityTextBox);
            this.groupBox2.Location = new System.Drawing.Point(12, 172);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(347, 119);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Product Entry";
            // 
            // ShopUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 338);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.showButton);
            this.Name = "ShopUI";
            this.Text = "ShopUI";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button showButton;
        private System.Windows.Forms.Button addItemButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.TextBox itemIdTextBox;
        private System.Windows.Forms.TextBox shopAddressTextBox;
        private System.Windows.Forms.TextBox shopNameTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

