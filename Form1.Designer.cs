namespace ListAppProof
{
    partial class Form1
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
            this.txtNewItem = new System.Windows.Forms.TextBox();
            this.lstItems = new System.Windows.Forms.ListBox();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.txtItem = new System.Windows.Forms.TextBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.chkComplete = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCompleteCount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNewItem
            // 
            this.txtNewItem.Location = new System.Drawing.Point(15, 47);
            this.txtNewItem.Name = "txtNewItem";
            this.txtNewItem.Size = new System.Drawing.Size(288, 31);
            this.txtNewItem.TabIndex = 0;
            // 
            // lstItems
            // 
            this.lstItems.FormattingEnabled = true;
            this.lstItems.ItemHeight = 25;
            this.lstItems.Location = new System.Drawing.Point(15, 147);
            this.lstItems.Name = "lstItems";
            this.lstItems.Size = new System.Drawing.Size(288, 254);
            this.lstItems.TabIndex = 1;
            this.lstItems.SelectedIndexChanged += new System.EventHandler(this.lstItems_SelectedIndexChanged);
            // 
            // btnAddItem
            // 
            this.btnAddItem.Location = new System.Drawing.Point(15, 85);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(288, 56);
            this.btnAddItem.TabIndex = 2;
            this.btnAddItem.Text = "Add Item";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // txtItem
            // 
            this.txtItem.Location = new System.Drawing.Point(318, 47);
            this.txtItem.Multiline = true;
            this.txtItem.Name = "txtItem";
            this.txtItem.Size = new System.Drawing.Size(310, 284);
            this.txtItem.TabIndex = 3;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(12, 407);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(288, 41);
            this.btnRemove.TabIndex = 4;
            this.btnRemove.Text = "Remove Item";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // chkComplete
            // 
            this.chkComplete.AutoSize = true;
            this.chkComplete.Location = new System.Drawing.Point(318, 349);
            this.chkComplete.Name = "chkComplete";
            this.chkComplete.Size = new System.Drawing.Size(135, 29);
            this.chkComplete.TabIndex = 5;
            this.chkComplete.Text = "Complete";
            this.chkComplete.UseVisualStyleBackColor = true;
            this.chkComplete.CheckedChanged += new System.EventHandler(this.chkComplete_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(318, 407);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Complete:";
            // 
            // lblCompleteCount
            // 
            this.lblCompleteCount.AutoSize = true;
            this.lblCompleteCount.Location = new System.Drawing.Point(434, 407);
            this.lblCompleteCount.Name = "lblCompleteCount";
            this.lblCompleteCount.Size = new System.Drawing.Size(54, 25);
            this.lblCompleteCount.TabIndex = 7;
            this.lblCompleteCount.Text = "0 / 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 469);
            this.Controls.Add(this.lblCompleteCount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chkComplete);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.txtItem);
            this.Controls.Add(this.btnAddItem);
            this.Controls.Add(this.lstItems);
            this.Controls.Add(this.txtNewItem);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNewItem;
        private System.Windows.Forms.ListBox lstItems;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.TextBox txtItem;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.CheckBox chkComplete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCompleteCount;
    }
}

