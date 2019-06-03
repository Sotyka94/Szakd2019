namespace WindowsFormsApp
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.btn_search = new System.Windows.Forms.Button();
            this.NameSearch_txtb = new System.Windows.Forms.TextBox();
            this.movieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseDataSet = new WindowsFormsApp.DatabaseDataSet();
            this.movieTableAdapter = new WindowsFormsApp.DatabaseDataSetTableAdapters.movieTableAdapter();
            this.databaseDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableAdapterManager = new WindowsFormsApp.DatabaseDataSetTableAdapters.TableAdapterManager();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.AddOpen = new System.Windows.Forms.Button();
            this.btn_addationalsearc = new System.Windows.Forms.Button();
            this.exclude_checkBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.movieBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(407, 30);
            this.btn_search.Margin = new System.Windows.Forms.Padding(2);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(108, 31);
            this.btn_search.TabIndex = 0;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // NameSearch_txtb
            // 
            this.NameSearch_txtb.Location = new System.Drawing.Point(203, 36);
            this.NameSearch_txtb.Margin = new System.Windows.Forms.Padding(2);
            this.NameSearch_txtb.Name = "NameSearch_txtb";
            this.NameSearch_txtb.Size = new System.Drawing.Size(200, 20);
            this.NameSearch_txtb.TabIndex = 2;
            // 
            // movieBindingSource
            // 
            this.movieBindingSource.DataMember = "movie";
            this.movieBindingSource.DataSource = this.databaseDataSet;
            // 
            // databaseDataSet
            // 
            this.databaseDataSet.DataSetName = "DatabaseDataSet";
            this.databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // movieTableAdapter
            // 
            this.movieTableAdapter.ClearBeforeFill = true;
            // 
            // databaseDataSetBindingSource
            // 
            this.databaseDataSetBindingSource.DataSource = this.databaseDataSet;
            this.databaseDataSetBindingSource.Position = 0;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.movieTableAdapter = this.movieTableAdapter;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp.DatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView.Location = new System.Drawing.Point(0, 151);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.Size = new System.Drawing.Size(740, 267);
            this.dataGridView.TabIndex = 5;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Title",
            "Year",
            "File location",
            "IMDB link",
            "Description",
            "Genre",
            "Person",
            "Tag"});
            this.comboBox1.Location = new System.Drawing.Point(26, 35);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(172, 21);
            this.comboBox1.TabIndex = 6;
            // 
            // AddOpen
            // 
            this.AddOpen.Location = new System.Drawing.Point(621, 117);
            this.AddOpen.Name = "AddOpen";
            this.AddOpen.Size = new System.Drawing.Size(107, 28);
            this.AddOpen.TabIndex = 7;
            this.AddOpen.Text = "ADD";
            this.AddOpen.UseVisualStyleBackColor = true;
            this.AddOpen.Click += new System.EventHandler(this.AddOpen_Click);
            // 
            // btn_addationalsearc
            // 
            this.btn_addationalsearc.Location = new System.Drawing.Point(621, 30);
            this.btn_addationalsearc.Name = "btn_addationalsearc";
            this.btn_addationalsearc.Size = new System.Drawing.Size(107, 30);
            this.btn_addationalsearc.TabIndex = 9;
            this.btn_addationalsearc.Text = "Addational Search";
            this.btn_addationalsearc.UseVisualStyleBackColor = true;
            this.btn_addationalsearc.Visible = false;
            this.btn_addationalsearc.Click += new System.EventHandler(this.Btn_addationalsearc_Click);
            // 
            // exclude_checkBox
            // 
            this.exclude_checkBox.AutoSize = true;
            this.exclude_checkBox.Location = new System.Drawing.Point(203, 61);
            this.exclude_checkBox.Name = "exclude_checkBox";
            this.exclude_checkBox.Size = new System.Drawing.Size(155, 17);
            this.exclude_checkBox.TabIndex = 10;
            this.exclude_checkBox.Text = "Check for excluding search";
            this.exclude_checkBox.UseVisualStyleBackColor = true;
            this.exclude_checkBox.CheckedChanged += new System.EventHandler(this.Exclude_checkBox_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 418);
            this.Controls.Add(this.exclude_checkBox);
            this.Controls.Add(this.btn_addationalsearc);
            this.Controls.Add(this.AddOpen);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.NameSearch_txtb);
            this.Controls.Add(this.btn_search);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "MainForm";
            this.Text = "SEARCH";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.movieBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox NameSearch_txtb;
        private DatabaseDataSet databaseDataSet;
        private System.Windows.Forms.BindingSource movieBindingSource;
        private DatabaseDataSetTableAdapters.movieTableAdapter movieTableAdapter;
        private System.Windows.Forms.BindingSource databaseDataSetBindingSource;
        private DatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button AddOpen;
        private System.Windows.Forms.Button btn_addationalsearc;
        private System.Windows.Forms.CheckBox exclude_checkBox;
    }
}

