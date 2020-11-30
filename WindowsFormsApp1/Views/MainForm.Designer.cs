
namespace WindowsFormsApp1.Views
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
            this.showSpecialtiesButton = new System.Windows.Forms.Button();
            this.showGroupsButton = new System.Windows.Forms.Button();
            this.showStudentsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // showSpecialtiesButton
            // 
            this.showSpecialtiesButton.Location = new System.Drawing.Point(12, 30);
            this.showSpecialtiesButton.Name = "showSpecialtiesButton";
            this.showSpecialtiesButton.Size = new System.Drawing.Size(75, 23);
            this.showSpecialtiesButton.TabIndex = 0;
            this.showSpecialtiesButton.Text = "Специальности";
            this.showSpecialtiesButton.UseVisualStyleBackColor = true;
            // 
            // showGroupsButton
            // 
            this.showGroupsButton.Location = new System.Drawing.Point(104, 30);
            this.showGroupsButton.Name = "showGroupsButton";
            this.showGroupsButton.Size = new System.Drawing.Size(75, 23);
            this.showGroupsButton.TabIndex = 1;
            this.showGroupsButton.Text = "Группы";
            this.showGroupsButton.UseVisualStyleBackColor = true;
            // 
            // showStudentsButton
            // 
            this.showStudentsButton.Location = new System.Drawing.Point(196, 30);
            this.showStudentsButton.Name = "showStudentsButton";
            this.showStudentsButton.Size = new System.Drawing.Size(75, 23);
            this.showStudentsButton.TabIndex = 2;
            this.showStudentsButton.Text = "Студенты";
            this.showStudentsButton.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 377);
            this.Controls.Add(this.showStudentsButton);
            this.Controls.Add(this.showGroupsButton);
            this.Controls.Add(this.showSpecialtiesButton);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главное окно";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button showSpecialtiesButton;
        private System.Windows.Forms.Button showGroupsButton;
        private System.Windows.Forms.Button showStudentsButton;
    }
}

