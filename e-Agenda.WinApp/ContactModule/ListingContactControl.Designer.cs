namespace e_Agenda.WinApp.ContactModule
{
    partial class ListingContactControl
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
            listContact = new ListBox();
            SuspendLayout();
            // 
            // listContact
            // 
            listContact.Dock = DockStyle.Fill;
            listContact.FormattingEnabled = true;
            listContact.ItemHeight = 15;
            listContact.Location = new Point(0, 0);
            listContact.Name = "listContact";
            listContact.Size = new Size(462, 134);
            listContact.TabIndex = 0;
            // 
            // ListingContactControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(listContact);
            Name = "ListingContactControl";
            Size = new Size(462, 134);
            ResumeLayout(false);
        }

        #endregion

        private ListBox listContact;
    }
}
