namespace eAgenda.WinApp.TaskModule
{
    partial class ListingTaskControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listTask = new ListBox();
            SuspendLayout();
            // 
            // listTask
            // 
            listTask.Dock = DockStyle.Fill;
            listTask.FormattingEnabled = true;
            listTask.ItemHeight = 15;
            listTask.Location = new Point(0, 0);
            listTask.Name = "listTask";
            listTask.Size = new Size(460, 149);
            listTask.TabIndex = 1;
            // 
            // ListingTaskControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(listTask);
            Name = "ListingTaskControl";
            Size = new Size(460, 149);
            ResumeLayout(false);
        }

        #endregion

        private ListBox listTask;
    }
}
