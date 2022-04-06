namespace SofDev_SAC_task_THREE
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
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.cbbxDisplay = new System.Windows.Forms.ComboBox();
            this.grdvwData = new System.Windows.Forms.DataGridView();
            this.lblFilter = new System.Windows.Forms.Label();
            this.lblSearch = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdvwData)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(595, 39);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(174, 26);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // cbbxDisplay
            // 
            this.cbbxDisplay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbxDisplay.FormattingEnabled = true;
            this.cbbxDisplay.Items.AddRange(new object[] {
            "Rating",
            "Subject",
            "Textbook"});
            this.cbbxDisplay.Location = new System.Drawing.Point(189, 37);
            this.cbbxDisplay.Name = "cbbxDisplay";
            this.cbbxDisplay.Size = new System.Drawing.Size(121, 28);
            this.cbbxDisplay.Sorted = true;
            this.cbbxDisplay.TabIndex = 1;
            this.cbbxDisplay.SelectedIndexChanged += new System.EventHandler(this.cbbxDisplay_SelectedIndexChanged);
            // 
            // grdvwData
            // 
            this.grdvwData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdvwData.Location = new System.Drawing.Point(12, 81);
            this.grdvwData.Name = "grdvwData";
            this.grdvwData.ReadOnly = true;
            this.grdvwData.RowHeadersWidth = 62;
            this.grdvwData.RowTemplate.Height = 28;
            this.grdvwData.Size = new System.Drawing.Size(776, 357);
            this.grdvwData.TabIndex = 2;
            // 
            // lblFilter
            // 
            this.lblFilter.AutoSize = true;
            this.lblFilter.Location = new System.Drawing.Point(86, 40);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(97, 20);
            this.lblFilter.TabIndex = 3;
            this.lblFilter.Text = "Select Filter:";
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(474, 42);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(115, 20);
            this.lblSearch.TabIndex = 4;
            this.lblSearch.Text = "Refine Search:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.lblFilter);
            this.Controls.Add(this.grdvwData);
            this.Controls.Add(this.cbbxDisplay);
            this.Controls.Add(this.txtSearch);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.grdvwData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ComboBox cbbxDisplay;
        private System.Windows.Forms.DataGridView grdvwData;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.Label lblSearch;
    }
}

