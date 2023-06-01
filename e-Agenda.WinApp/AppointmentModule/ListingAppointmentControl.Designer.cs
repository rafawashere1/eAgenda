namespace eAgenda.WinApp.AppointmentModule
{
    partial class ListingAppointmentControl
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
            listAppointments = new ListBox();
            SuspendLayout();
            // 
            // listAppointments
            // 
            listAppointments.Dock = DockStyle.Fill;
            listAppointments.FormattingEnabled = true;
            listAppointments.ItemHeight = 15;
            listAppointments.Location = new Point(0, 0);
            listAppointments.Name = "listAppointments";
            listAppointments.Size = new Size(606, 529);
            listAppointments.TabIndex = 0;
            // 
            // ListingAppointmentControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(listAppointments);
            Name = "ListingAppointmentControl";
            Size = new Size(606, 529);
            ResumeLayout(false);
        }

        #endregion

        private ListBox listAppointments;
    }
}
