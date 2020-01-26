namespace iskanje
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
            this.searchText = new System.Windows.Forms.TextBox();
            this.minButton = new System.Windows.Forms.Button();
            this.maxButton = new System.Windows.Forms.Button();
            this.dodajButton = new System.Windows.Forms.Button();
            this.vsotaButton = new System.Windows.Forms.Button();
            this.povprecjeButton = new System.Windows.Forms.Button();
            this.vsebujeButton = new System.Windows.Forms.Button();
            this.binarySearch = new System.Windows.Forms.Button();
            this.urediButton = new System.Windows.Forms.Button();
            this.insertionSortButton = new System.Windows.Forms.Button();
            this.bubbleSortButton = new System.Windows.Forms.Button();
            this.quickSortButton = new System.Windows.Forms.Button();
            this.textBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // searchText
            // 
            this.searchText.Location = new System.Drawing.Point(12, 12);
            this.searchText.Name = "searchText";
            this.searchText.Size = new System.Drawing.Size(82, 20);
            this.searchText.TabIndex = 0;
            // 
            // minButton
            // 
            this.minButton.Location = new System.Drawing.Point(12, 71);
            this.minButton.Name = "minButton";
            this.minButton.Size = new System.Drawing.Size(82, 27);
            this.minButton.TabIndex = 3;
            this.minButton.Text = "Min";
            this.minButton.UseVisualStyleBackColor = true;
            this.minButton.Click += new System.EventHandler(this.minButton_Click);
            // 
            // maxButton
            // 
            this.maxButton.Location = new System.Drawing.Point(100, 71);
            this.maxButton.Name = "maxButton";
            this.maxButton.Size = new System.Drawing.Size(82, 27);
            this.maxButton.TabIndex = 5;
            this.maxButton.Text = "Max";
            this.maxButton.UseVisualStyleBackColor = true;
            this.maxButton.Click += new System.EventHandler(this.maxButton_Click);
            // 
            // dodajButton
            // 
            this.dodajButton.Location = new System.Drawing.Point(100, 12);
            this.dodajButton.Name = "dodajButton";
            this.dodajButton.Size = new System.Drawing.Size(82, 47);
            this.dodajButton.TabIndex = 6;
            this.dodajButton.Text = "Dodaj";
            this.dodajButton.UseVisualStyleBackColor = true;
            this.dodajButton.Click += new System.EventHandler(this.dodajButton_Click);
            // 
            // vsotaButton
            // 
            this.vsotaButton.Location = new System.Drawing.Point(12, 104);
            this.vsotaButton.Name = "vsotaButton";
            this.vsotaButton.Size = new System.Drawing.Size(82, 27);
            this.vsotaButton.TabIndex = 7;
            this.vsotaButton.Text = "Vsota";
            this.vsotaButton.UseVisualStyleBackColor = true;
            this.vsotaButton.Click += new System.EventHandler(this.vsotaButton_Click);
            // 
            // povprecjeButton
            // 
            this.povprecjeButton.Location = new System.Drawing.Point(100, 104);
            this.povprecjeButton.Name = "povprecjeButton";
            this.povprecjeButton.Size = new System.Drawing.Size(82, 27);
            this.povprecjeButton.TabIndex = 8;
            this.povprecjeButton.Text = "Povprečje";
            this.povprecjeButton.UseVisualStyleBackColor = true;
            this.povprecjeButton.Click += new System.EventHandler(this.povprecjeButton_Click);
            // 
            // vsebujeButton
            // 
            this.vsebujeButton.Location = new System.Drawing.Point(188, 12);
            this.vsebujeButton.Name = "vsebujeButton";
            this.vsebujeButton.Size = new System.Drawing.Size(82, 47);
            this.vsebujeButton.TabIndex = 9;
            this.vsebujeButton.Text = "Vsebuje";
            this.vsebujeButton.UseVisualStyleBackColor = true;
            this.vsebujeButton.Click += new System.EventHandler(this.vsebujeButton_Click);
            // 
            // binarySearch
            // 
            this.binarySearch.Location = new System.Drawing.Point(296, 12);
            this.binarySearch.Name = "binarySearch";
            this.binarySearch.Size = new System.Drawing.Size(82, 47);
            this.binarySearch.TabIndex = 10;
            this.binarySearch.Text = "Vsebuje binarno";
            this.binarySearch.UseVisualStyleBackColor = true;
            this.binarySearch.Click += new System.EventHandler(this.binarySearch_Click);
            // 
            // urediButton
            // 
            this.urediButton.Location = new System.Drawing.Point(296, 65);
            this.urediButton.Name = "urediButton";
            this.urediButton.Size = new System.Drawing.Size(82, 47);
            this.urediButton.TabIndex = 11;
            this.urediButton.Text = "Uredi z izbiranjem";
            this.urediButton.UseVisualStyleBackColor = true;
            this.urediButton.Click += new System.EventHandler(this.urediButton_Click);
            // 
            // insertionSortButton
            // 
            this.insertionSortButton.Location = new System.Drawing.Point(296, 118);
            this.insertionSortButton.Name = "insertionSortButton";
            this.insertionSortButton.Size = new System.Drawing.Size(82, 47);
            this.insertionSortButton.TabIndex = 12;
            this.insertionSortButton.Text = "Uredi z vstavljanjem";
            this.insertionSortButton.UseVisualStyleBackColor = true;
            this.insertionSortButton.Click += new System.EventHandler(this.insertionSortButton_Click);
            // 
            // bubbleSortButton
            // 
            this.bubbleSortButton.Location = new System.Drawing.Point(296, 171);
            this.bubbleSortButton.Name = "bubbleSortButton";
            this.bubbleSortButton.Size = new System.Drawing.Size(82, 47);
            this.bubbleSortButton.TabIndex = 13;
            this.bubbleSortButton.Text = "Uredi z mehurčki";
            this.bubbleSortButton.UseVisualStyleBackColor = true;
            this.bubbleSortButton.Click += new System.EventHandler(this.bubbleSortButton_Click);
            // 
            // quickSortButton
            // 
            this.quickSortButton.Location = new System.Drawing.Point(296, 224);
            this.quickSortButton.Name = "quickSortButton";
            this.quickSortButton.Size = new System.Drawing.Size(82, 47);
            this.quickSortButton.TabIndex = 14;
            this.quickSortButton.Text = "Hitro Uredi";
            this.quickSortButton.UseVisualStyleBackColor = true;
            this.quickSortButton.Click += new System.EventHandler(this.quickSortButton_Click);
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(12, 137);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(258, 134);
            this.textBox.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 287);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.quickSortButton);
            this.Controls.Add(this.bubbleSortButton);
            this.Controls.Add(this.insertionSortButton);
            this.Controls.Add(this.urediButton);
            this.Controls.Add(this.binarySearch);
            this.Controls.Add(this.vsebujeButton);
            this.Controls.Add(this.povprecjeButton);
            this.Controls.Add(this.vsotaButton);
            this.Controls.Add(this.dodajButton);
            this.Controls.Add(this.maxButton);
            this.Controls.Add(this.minButton);
            this.Controls.Add(this.searchText);
            this.Name = "Form1";
            this.Text = "Vaja Iskanje";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox searchText;
        private System.Windows.Forms.Button minButton;
        private System.Windows.Forms.Button maxButton;
        private System.Windows.Forms.Button dodajButton;
        private System.Windows.Forms.Button vsotaButton;
        private System.Windows.Forms.Button povprecjeButton;
        private System.Windows.Forms.Button vsebujeButton;
        private System.Windows.Forms.Button binarySearch;
        private System.Windows.Forms.Button urediButton;
        private System.Windows.Forms.Button insertionSortButton;
        private System.Windows.Forms.Button bubbleSortButton;
        private System.Windows.Forms.Button quickSortButton;
        private System.Windows.Forms.TextBox textBox;
    }
}

