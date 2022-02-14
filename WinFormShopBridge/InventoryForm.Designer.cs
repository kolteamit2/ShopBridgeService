namespace WinFormShopBridge
{
    partial class FormInventory
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
            this.GridViewInventory = new System.Windows.Forms.DataGridView();
            this.LabelInventoryName = new System.Windows.Forms.Label();
            this.LabelPrice = new System.Windows.Forms.Label();
            this.LabelDescription = new System.Windows.Forms.Label();
            this.TextBoxInventoryName = new System.Windows.Forms.TextBox();
            this.TextBoxDescription = new System.Windows.Forms.TextBox();
            this.TextBoxPrice = new System.Windows.Forms.TextBox();
            this.ButtonSave = new System.Windows.Forms.Button();
            this.ButtonClose = new System.Windows.Forms.Button();
            this.ButtonClear = new System.Windows.Forms.Button();
            this.ButtonUpdate = new System.Windows.Forms.Button();
            this.ButtonDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewInventory)).BeginInit();
            this.SuspendLayout();
            // 
            // GridViewInventory
            // 
            this.GridViewInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewInventory.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.GridViewInventory.Location = new System.Drawing.Point(12, 142);
            this.GridViewInventory.MultiSelect = false;
            this.GridViewInventory.Name = "GridViewInventory";
            this.GridViewInventory.ReadOnly = true;
            this.GridViewInventory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridViewInventory.ShowRowErrors = false;
            this.GridViewInventory.Size = new System.Drawing.Size(506, 296);
            this.GridViewInventory.TabIndex = 0;
            this.GridViewInventory.TabStop = false;
            this.GridViewInventory.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.GridViewInventory_DataBindingComplete);
            this.GridViewInventory.SelectionChanged += new System.EventHandler(this.GridViewInventory_SelectionChanged);
            // 
            // LabelInventoryName
            // 
            this.LabelInventoryName.AutoSize = true;
            this.LabelInventoryName.Location = new System.Drawing.Point(12, 9);
            this.LabelInventoryName.Name = "LabelInventoryName";
            this.LabelInventoryName.Size = new System.Drawing.Size(82, 13);
            this.LabelInventoryName.TabIndex = 1;
            this.LabelInventoryName.Text = "Inventory Name";
            // 
            // LabelPrice
            // 
            this.LabelPrice.AutoSize = true;
            this.LabelPrice.Location = new System.Drawing.Point(12, 89);
            this.LabelPrice.Name = "LabelPrice";
            this.LabelPrice.Size = new System.Drawing.Size(31, 13);
            this.LabelPrice.TabIndex = 2;
            this.LabelPrice.Text = "Price";
            // 
            // LabelDescription
            // 
            this.LabelDescription.AutoSize = true;
            this.LabelDescription.Location = new System.Drawing.Point(12, 34);
            this.LabelDescription.Name = "LabelDescription";
            this.LabelDescription.Size = new System.Drawing.Size(60, 13);
            this.LabelDescription.TabIndex = 3;
            this.LabelDescription.Text = "Description";
            // 
            // TextBoxInventoryName
            // 
            this.TextBoxInventoryName.Location = new System.Drawing.Point(100, 6);
            this.TextBoxInventoryName.MaxLength = 50;
            this.TextBoxInventoryName.Name = "TextBoxInventoryName";
            this.TextBoxInventoryName.Size = new System.Drawing.Size(187, 20);
            this.TextBoxInventoryName.TabIndex = 1;
            // 
            // TextBoxDescription
            // 
            this.TextBoxDescription.Location = new System.Drawing.Point(100, 32);
            this.TextBoxDescription.MaxLength = 100;
            this.TextBoxDescription.Multiline = true;
            this.TextBoxDescription.Name = "TextBoxDescription";
            this.TextBoxDescription.Size = new System.Drawing.Size(187, 46);
            this.TextBoxDescription.TabIndex = 2;
            // 
            // TextBoxPrice
            // 
            this.TextBoxPrice.Location = new System.Drawing.Point(100, 84);
            this.TextBoxPrice.MaxLength = 8;
            this.TextBoxPrice.Name = "TextBoxPrice";
            this.TextBoxPrice.Size = new System.Drawing.Size(187, 20);
            this.TextBoxPrice.TabIndex = 3;
            this.TextBoxPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxPrice_KeyPress);
            // 
            // ButtonSave
            // 
            this.ButtonSave.Location = new System.Drawing.Point(280, 113);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(75, 23);
            this.ButtonSave.TabIndex = 4;
            this.ButtonSave.Text = "Save";
            this.ButtonSave.UseVisualStyleBackColor = true;
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // ButtonClose
            // 
            this.ButtonClose.Location = new System.Drawing.Point(442, 113);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new System.Drawing.Size(75, 23);
            this.ButtonClose.TabIndex = 7;
            this.ButtonClose.Text = "Close";
            this.ButtonClose.UseVisualStyleBackColor = true;
            this.ButtonClose.Click += new System.EventHandler(this.ButtonClose_Click);
            // 
            // ButtonClear
            // 
            this.ButtonClear.Location = new System.Drawing.Point(361, 113);
            this.ButtonClear.Name = "ButtonClear";
            this.ButtonClear.Size = new System.Drawing.Size(75, 23);
            this.ButtonClear.TabIndex = 6;
            this.ButtonClear.Text = "Clear";
            this.ButtonClear.UseVisualStyleBackColor = true;
            this.ButtonClear.Click += new System.EventHandler(this.ButtonClear_Click);
            // 
            // ButtonUpdate
            // 
            this.ButtonUpdate.Location = new System.Drawing.Point(280, 113);
            this.ButtonUpdate.Name = "ButtonUpdate";
            this.ButtonUpdate.Size = new System.Drawing.Size(75, 23);
            this.ButtonUpdate.TabIndex = 4;
            this.ButtonUpdate.Text = "Update";
            this.ButtonUpdate.UseVisualStyleBackColor = true;
            this.ButtonUpdate.Visible = false;
            this.ButtonUpdate.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // ButtonDelete
            // 
            this.ButtonDelete.Location = new System.Drawing.Point(199, 113);
            this.ButtonDelete.Name = "ButtonDelete";
            this.ButtonDelete.Size = new System.Drawing.Size(75, 23);
            this.ButtonDelete.TabIndex = 5;
            this.ButtonDelete.Text = "Delete";
            this.ButtonDelete.UseVisualStyleBackColor = true;
            this.ButtonDelete.Visible = false;
            this.ButtonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
            // 
            // FormInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 450);
            this.Controls.Add(this.ButtonDelete);
            this.Controls.Add(this.ButtonUpdate);
            this.Controls.Add(this.ButtonClear);
            this.Controls.Add(this.ButtonClose);
            this.Controls.Add(this.ButtonSave);
            this.Controls.Add(this.TextBoxPrice);
            this.Controls.Add(this.TextBoxDescription);
            this.Controls.Add(this.TextBoxInventoryName);
            this.Controls.Add(this.LabelDescription);
            this.Controls.Add(this.LabelPrice);
            this.Controls.Add(this.LabelInventoryName);
            this.Controls.Add(this.GridViewInventory);
            this.Name = "FormInventory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventory";
            this.Load += new System.EventHandler(this.FormInventory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewInventory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GridViewInventory;
        private System.Windows.Forms.Label LabelInventoryName;
        private System.Windows.Forms.Label LabelPrice;
        private System.Windows.Forms.Label LabelDescription;
        private System.Windows.Forms.TextBox TextBoxInventoryName;
        private System.Windows.Forms.TextBox TextBoxDescription;
        private System.Windows.Forms.TextBox TextBoxPrice;
        private System.Windows.Forms.Button ButtonSave;
        private System.Windows.Forms.Button ButtonClose;
        private System.Windows.Forms.Button ButtonClear;
        private System.Windows.Forms.Button ButtonUpdate;
        private System.Windows.Forms.Button ButtonDelete;
    }
}

