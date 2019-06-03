namespace WindowsFormsApp
{
    partial class AddForm
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
            this.AddButton = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.AddLabel1 = new System.Windows.Forms.Label();
            this.AddLabel2 = new System.Windows.Forms.Label();
            this.AddLabel3 = new System.Windows.Forms.Label();
            this.AddtextBox1 = new System.Windows.Forms.TextBox();
            this.AddtextBox2 = new System.Windows.Forms.TextBox();
            this.AddtextBox3 = new System.Windows.Forms.TextBox();
            this.AddtextBox4 = new System.Windows.Forms.TextBox();
            this.AddLabel4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(641, 38);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(134, 41);
            this.AddButton.TabIndex = 0;
            this.AddButton.Text = "ADD NEW";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Add new Movie",
            "Add new Genre",
            "Add new Person"});
            this.comboBox1.Location = new System.Drawing.Point(103, 35);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(252, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.DropDownClosed += new System.EventHandler(this.ComboBox1_DropDownClosed);
            // 
            // AddLabel1
            // 
            this.AddLabel1.AutoSize = true;
            this.AddLabel1.Location = new System.Drawing.Point(26, 90);
            this.AddLabel1.Name = "AddLabel1";
            this.AddLabel1.Size = new System.Drawing.Size(35, 13);
            this.AddLabel1.TabIndex = 2;
            this.AddLabel1.Text = "label1";
            // 
            // AddLabel2
            // 
            this.AddLabel2.AutoSize = true;
            this.AddLabel2.Location = new System.Drawing.Point(26, 140);
            this.AddLabel2.Name = "AddLabel2";
            this.AddLabel2.Size = new System.Drawing.Size(35, 13);
            this.AddLabel2.TabIndex = 3;
            this.AddLabel2.Text = "label2";
            // 
            // AddLabel3
            // 
            this.AddLabel3.AutoSize = true;
            this.AddLabel3.Location = new System.Drawing.Point(26, 190);
            this.AddLabel3.Name = "AddLabel3";
            this.AddLabel3.Size = new System.Drawing.Size(35, 13);
            this.AddLabel3.TabIndex = 4;
            this.AddLabel3.Text = "label3";
            // 
            // AddtextBox1
            // 
            this.AddtextBox1.Location = new System.Drawing.Point(103, 89);
            this.AddtextBox1.Name = "AddtextBox1";
            this.AddtextBox1.Size = new System.Drawing.Size(100, 20);
            this.AddtextBox1.TabIndex = 5;
            // 
            // AddtextBox2
            // 
            this.AddtextBox2.Location = new System.Drawing.Point(103, 140);
            this.AddtextBox2.Name = "AddtextBox2";
            this.AddtextBox2.Size = new System.Drawing.Size(100, 20);
            this.AddtextBox2.TabIndex = 6;
            // 
            // AddtextBox3
            // 
            this.AddtextBox3.Location = new System.Drawing.Point(103, 190);
            this.AddtextBox3.Name = "AddtextBox3";
            this.AddtextBox3.Size = new System.Drawing.Size(100, 20);
            this.AddtextBox3.TabIndex = 7;
            // 
            // AddtextBox4
            // 
            this.AddtextBox4.Location = new System.Drawing.Point(103, 240);
            this.AddtextBox4.Name = "AddtextBox4";
            this.AddtextBox4.Size = new System.Drawing.Size(100, 20);
            this.AddtextBox4.TabIndex = 8;
            // 
            // AddLabel4
            // 
            this.AddLabel4.AutoSize = true;
            this.AddLabel4.Location = new System.Drawing.Point(26, 240);
            this.AddLabel4.Name = "AddLabel4";
            this.AddLabel4.Size = new System.Drawing.Size(35, 13);
            this.AddLabel4.TabIndex = 10;
            this.AddLabel4.Text = "label4";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Select one:";
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddLabel4);
            this.Controls.Add(this.AddtextBox4);
            this.Controls.Add(this.AddtextBox3);
            this.Controls.Add(this.AddtextBox2);
            this.Controls.Add(this.AddtextBox1);
            this.Controls.Add(this.AddLabel3);
            this.Controls.Add(this.AddLabel2);
            this.Controls.Add(this.AddLabel1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.AddButton);
            this.Name = "AddForm";
            this.Text = "AddForm";
            this.Load += new System.EventHandler(this.AddForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label AddLabel1;
        private System.Windows.Forms.Label AddLabel2;
        private System.Windows.Forms.Label AddLabel3;
        private System.Windows.Forms.TextBox AddtextBox1;
        private System.Windows.Forms.TextBox AddtextBox2;
        private System.Windows.Forms.TextBox AddtextBox3;
        private System.Windows.Forms.TextBox AddtextBox4;
        private System.Windows.Forms.Label AddLabel4;
        private System.Windows.Forms.Label label1;
    }
}