
namespace WindowsFormsApp1.Views
{
    partial class SpecialtiesForm
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
            this.secialtiesGridView = new System.Windows.Forms.DataGridView();
            this.idColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.secialtiesGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // secialtiesGridView
            // 
            this.secialtiesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.secialtiesGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idColumn,
            this.codeColumn,
            this.nameColumn});
            this.secialtiesGridView.Location = new System.Drawing.Point(12, 12);
            this.secialtiesGridView.Name = "secialtiesGridView";
            this.secialtiesGridView.Size = new System.Drawing.Size(776, 360);
            this.secialtiesGridView.TabIndex = 0;
            // 
            // idColumn
            // 
            this.idColumn.DataPropertyName = "Id";
            this.idColumn.HeaderText = "Id";
            this.idColumn.Name = "idColumn";
            this.idColumn.ReadOnly = true;
            this.idColumn.Visible = false;
            // 
            // codeColumn
            // 
            this.codeColumn.DataPropertyName = "Code";
            this.codeColumn.HeaderText = "Шифр";
            this.codeColumn.Name = "codeColumn";
            // 
            // nameColumn
            // 
            this.nameColumn.DataPropertyName = "Name";
            this.nameColumn.HeaderText = "Название";
            this.nameColumn.Name = "nameColumn";
            // 
            // SpecialtiesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.secialtiesGridView);
            this.Name = "SpecialtiesForm";
            this.Text = "SpecialtiesForm";
            ((System.ComponentModel.ISupportInitialize)(this.secialtiesGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView secialtiesGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn idColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameColumn;
    }
}