namespace TeamProject
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
            this.chk1 = new System.Windows.Forms.CheckBox();
            this.chk2 = new System.Windows.Forms.CheckBox();
            this.chk3 = new System.Windows.Forms.CheckBox();
            this.cboCoffee = new System.Windows.Forms.ComboBox();
            this.grpAddOn = new System.Windows.Forms.GroupBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.grpAddOn.SuspendLayout();
            this.SuspendLayout();
            // 
            // chk1
            // 
            this.chk1.AutoSize = true;
            this.chk1.Location = new System.Drawing.Point(9, 29);
            this.chk1.Name = "chk1";
            this.chk1.Size = new System.Drawing.Size(54, 17);
            this.chk1.TabIndex = 0;
            this.chk1.Text = "Sugar";
            this.chk1.UseVisualStyleBackColor = true;
            // 
            // chk2
            // 
            this.chk2.AutoSize = true;
            this.chk2.Location = new System.Drawing.Point(9, 68);
            this.chk2.Name = "chk2";
            this.chk2.Size = new System.Drawing.Size(57, 17);
            this.chk2.TabIndex = 1;
            this.chk2.Text = "Honey";
            this.chk2.UseVisualStyleBackColor = true;
            // 
            // chk3
            // 
            this.chk3.AutoSize = true;
            this.chk3.Location = new System.Drawing.Point(9, 107);
            this.chk3.Name = "chk3";
            this.chk3.Size = new System.Drawing.Size(85, 17);
            this.chk3.TabIndex = 2;
            this.chk3.Text = "Lemon/Lime";
            this.chk3.UseVisualStyleBackColor = true;
            // 
            // cboCoffee
            // 
            this.cboCoffee.FormattingEnabled = true;
            this.cboCoffee.Location = new System.Drawing.Point(41, 47);
            this.cboCoffee.Name = "cboCoffee";
            this.cboCoffee.Size = new System.Drawing.Size(121, 21);
            this.cboCoffee.TabIndex = 3;
            // 
            // grpAddOn
            // 
            this.grpAddOn.Controls.Add(this.chk1);
            this.grpAddOn.Controls.Add(this.chk2);
            this.grpAddOn.Controls.Add(this.chk3);
            this.grpAddOn.Location = new System.Drawing.Point(193, 47);
            this.grpAddOn.Name = "grpAddOn";
            this.grpAddOn.Size = new System.Drawing.Size(200, 153);
            this.grpAddOn.TabIndex = 4;
            this.grpAddOn.TabStop = false;
            this.grpAddOn.Text = "Add-On Items ($0.50 / each)";
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(258, 206);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 5;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // txtPrice
            // 
            this.txtPrice.Enabled = false;
            this.txtPrice.Location = new System.Drawing.Point(202, 244);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(191, 20);
            this.txtPrice.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 286);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.grpAddOn);
            this.Controls.Add(this.cboCoffee);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grpAddOn.ResumeLayout(false);
            this.grpAddOn.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chk1;
        private System.Windows.Forms.CheckBox chk2;
        private System.Windows.Forms.CheckBox chk3;
        private System.Windows.Forms.ComboBox cboCoffee;
        private System.Windows.Forms.GroupBox grpAddOn;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.TextBox txtPrice;
    }
}

