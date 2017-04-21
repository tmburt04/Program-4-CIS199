namespace Program_4
{
    partial class Program4
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
            this.origin = new System.Windows.Forms.Label();
            this.destination = new System.Windows.Forms.Label();
            this.length = new System.Windows.Forms.Label();
            this.width = new System.Windows.Forms.Label();
            this.height = new System.Windows.Forms.Label();
            this.weight = new System.Windows.Forms.Label();
            this.originTextBox = new System.Windows.Forms.TextBox();
            this.destinationTextBox = new System.Windows.Forms.TextBox();
            this.lengthTextBox = new System.Windows.Forms.TextBox();
            this.widthTextBox = new System.Windows.Forms.TextBox();
            this.heightTextBox = new System.Windows.Forms.TextBox();
            this.weightTextBox = new System.Windows.Forms.TextBox();
            this.packageListBox = new System.Windows.Forms.ListBox();
            this.addPackageButton = new System.Windows.Forms.Button();
            this.toButton = new System.Windows.Forms.Button();
            this.fromButton = new System.Windows.Forms.Button();
            this.detailsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // origin
            // 
            this.origin.AutoSize = true;
            this.origin.Location = new System.Drawing.Point(26, 7);
            this.origin.Name = "origin";
            this.origin.Size = new System.Drawing.Size(53, 13);
            this.origin.TabIndex = 0;
            this.origin.Text = "Origin zip:";
            // 
            // destination
            // 
            this.destination.AutoSize = true;
            this.destination.Location = new System.Drawing.Point(0, 33);
            this.destination.Name = "destination";
            this.destination.Size = new System.Drawing.Size(79, 13);
            this.destination.TabIndex = 1;
            this.destination.Text = "Destination zip:";
            // 
            // length
            // 
            this.length.AutoSize = true;
            this.length.Location = new System.Drawing.Point(19, 59);
            this.length.Name = "length";
            this.length.Size = new System.Drawing.Size(60, 13);
            this.length.TabIndex = 2;
            this.length.Text = "Length (in):";
            // 
            // width
            // 
            this.width.AutoSize = true;
            this.width.Location = new System.Drawing.Point(24, 85);
            this.width.Name = "width";
            this.width.Size = new System.Drawing.Size(55, 13);
            this.width.TabIndex = 3;
            this.width.Text = "Width (in):";
            // 
            // height
            // 
            this.height.AutoSize = true;
            this.height.Location = new System.Drawing.Point(21, 111);
            this.height.Name = "height";
            this.height.Size = new System.Drawing.Size(58, 13);
            this.height.TabIndex = 4;
            this.height.Text = "Height (in):";
            // 
            // weight
            // 
            this.weight.AutoSize = true;
            this.weight.Location = new System.Drawing.Point(13, 137);
            this.weight.Name = "weight";
            this.weight.Size = new System.Drawing.Size(66, 13);
            this.weight.TabIndex = 5;
            this.weight.Text = "Weight (lbs):";
            // 
            // originTextBox
            // 
            this.originTextBox.Location = new System.Drawing.Point(85, 4);
            this.originTextBox.Name = "originTextBox";
            this.originTextBox.Size = new System.Drawing.Size(100, 20);
            this.originTextBox.TabIndex = 6;
            // 
            // destinationTextBox
            // 
            this.destinationTextBox.Location = new System.Drawing.Point(85, 30);
            this.destinationTextBox.Name = "destinationTextBox";
            this.destinationTextBox.Size = new System.Drawing.Size(100, 20);
            this.destinationTextBox.TabIndex = 7;
            // 
            // lengthTextBox
            // 
            this.lengthTextBox.Location = new System.Drawing.Point(85, 56);
            this.lengthTextBox.Name = "lengthTextBox";
            this.lengthTextBox.Size = new System.Drawing.Size(100, 20);
            this.lengthTextBox.TabIndex = 8;
            // 
            // widthTextBox
            // 
            this.widthTextBox.Location = new System.Drawing.Point(85, 82);
            this.widthTextBox.Name = "widthTextBox";
            this.widthTextBox.Size = new System.Drawing.Size(100, 20);
            this.widthTextBox.TabIndex = 9;
            // 
            // heightTextBox
            // 
            this.heightTextBox.Location = new System.Drawing.Point(85, 108);
            this.heightTextBox.Name = "heightTextBox";
            this.heightTextBox.Size = new System.Drawing.Size(100, 20);
            this.heightTextBox.TabIndex = 10;
            // 
            // weightTextBox
            // 
            this.weightTextBox.Location = new System.Drawing.Point(85, 134);
            this.weightTextBox.Name = "weightTextBox";
            this.weightTextBox.Size = new System.Drawing.Size(100, 20);
            this.weightTextBox.TabIndex = 11;
            // 
            // packageListBox
            // 
            this.packageListBox.FormattingEnabled = true;
            this.packageListBox.Location = new System.Drawing.Point(208, 12);
            this.packageListBox.Name = "packageListBox";
            this.packageListBox.Size = new System.Drawing.Size(120, 134);
            this.packageListBox.TabIndex = 12;
            // 
            // addPackageButton
            // 
            this.addPackageButton.Location = new System.Drawing.Point(44, 161);
            this.addPackageButton.Name = "addPackageButton";
            this.addPackageButton.Size = new System.Drawing.Size(94, 23);
            this.addPackageButton.TabIndex = 13;
            this.addPackageButton.Text = "Add Package";
            this.addPackageButton.UseVisualStyleBackColor = true;
            this.addPackageButton.Click += new System.EventHandler(this.addPackageButton_Click);
            // 
            // toButton
            // 
            this.toButton.Location = new System.Drawing.Point(345, 23);
            this.toButton.Name = "toButton";
            this.toButton.Size = new System.Drawing.Size(75, 23);
            this.toButton.TabIndex = 14;
            this.toButton.Text = "To UofL";
            this.toButton.UseVisualStyleBackColor = true;
            this.toButton.Click += new System.EventHandler(this.toButton_Click);
            // 
            // fromButton
            // 
            this.fromButton.Location = new System.Drawing.Point(345, 52);
            this.fromButton.Name = "fromButton";
            this.fromButton.Size = new System.Drawing.Size(75, 23);
            this.fromButton.TabIndex = 15;
            this.fromButton.Text = "From UofL";
            this.fromButton.UseVisualStyleBackColor = true;
            this.fromButton.Click += new System.EventHandler(this.fromButton_Click);
            // 
            // detailsButton
            // 
            this.detailsButton.Location = new System.Drawing.Point(345, 111);
            this.detailsButton.Name = "detailsButton";
            this.detailsButton.Size = new System.Drawing.Size(75, 23);
            this.detailsButton.TabIndex = 16;
            this.detailsButton.Text = "Details";
            this.detailsButton.UseVisualStyleBackColor = true;
            this.detailsButton.Click += new System.EventHandler(this.detailsButton_Click);
            // 
            // Program4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 196);
            this.Controls.Add(this.detailsButton);
            this.Controls.Add(this.fromButton);
            this.Controls.Add(this.toButton);
            this.Controls.Add(this.addPackageButton);
            this.Controls.Add(this.packageListBox);
            this.Controls.Add(this.weightTextBox);
            this.Controls.Add(this.heightTextBox);
            this.Controls.Add(this.widthTextBox);
            this.Controls.Add(this.lengthTextBox);
            this.Controls.Add(this.destinationTextBox);
            this.Controls.Add(this.originTextBox);
            this.Controls.Add(this.weight);
            this.Controls.Add(this.height);
            this.Controls.Add(this.width);
            this.Controls.Add(this.length);
            this.Controls.Add(this.destination);
            this.Controls.Add(this.origin);
            this.Name = "Program4";
            this.Text = "Program 4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label origin;
        private System.Windows.Forms.Label destination;
        private System.Windows.Forms.Label length;
        private System.Windows.Forms.Label width;
        private System.Windows.Forms.Label height;
        private System.Windows.Forms.Label weight;
        private System.Windows.Forms.TextBox originTextBox;
        private System.Windows.Forms.TextBox destinationTextBox;
        private System.Windows.Forms.TextBox lengthTextBox;
        private System.Windows.Forms.TextBox widthTextBox;
        private System.Windows.Forms.TextBox heightTextBox;
        private System.Windows.Forms.TextBox weightTextBox;
        private System.Windows.Forms.ListBox packageListBox;
        private System.Windows.Forms.Button addPackageButton;
        private System.Windows.Forms.Button toButton;
        private System.Windows.Forms.Button fromButton;
        private System.Windows.Forms.Button detailsButton;
    }
}

