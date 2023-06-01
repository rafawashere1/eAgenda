namespace e_Agenda.WinApp.ContactModule
{
    partial class ContactForm
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
            btnRecord = new Button();
            btnCancel = new Button();
            label1 = new Label();
            txtId = new TextBox();
            label2 = new Label();
            txtName = new TextBox();
            label3 = new Label();
            txtCompany = new TextBox();
            label4 = new Label();
            txtEmail = new TextBox();
            txtJobTitle = new TextBox();
            label5 = new Label();
            label6 = new Label();
            mtbPhone = new MaskedTextBox();
            SuspendLayout();
            // 
            // btnRecord
            // 
            btnRecord.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnRecord.DialogResult = DialogResult.OK;
            btnRecord.Location = new Point(443, 224);
            btnRecord.Name = "btnRecord";
            btnRecord.Size = new Size(78, 46);
            btnRecord.TabIndex = 1;
            btnRecord.Text = "Gravar";
            btnRecord.UseVisualStyleBackColor = true;
            btnRecord.Click += btnRecord_Click;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Location = new Point(527, 224);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(77, 46);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "Cancelar";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(53, 42);
            label1.Name = "label1";
            label1.Size = new Size(21, 15);
            label1.TabIndex = 3;
            label1.Text = "ID:";
            // 
            // txtId
            // 
            txtId.Location = new Point(80, 39);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(104, 23);
            txtId.TabIndex = 4;
            txtId.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 73);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 5;
            label2.Text = "Nome:";
            // 
            // txtName
            // 
            txtName.Location = new Point(80, 70);
            txtName.Name = "txtName";
            txtName.Size = new Size(520, 23);
            txtName.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 104);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 8;
            label3.Text = "Telefone:";
            // 
            // txtCompany
            // 
            txtCompany.Location = new Point(80, 132);
            txtCompany.Name = "txtCompany";
            txtCompany.Size = new Size(216, 23);
            txtCompany.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 135);
            label4.Name = "label4";
            label4.Size = new Size(55, 15);
            label4.TabIndex = 10;
            label4.Text = "Empresa:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(384, 101);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(216, 23);
            txtEmail.TabIndex = 11;
            // 
            // txtJobTitle
            // 
            txtJobTitle.Location = new Point(384, 132);
            txtJobTitle.Name = "txtJobTitle";
            txtJobTitle.Size = new Size(216, 23);
            txtJobTitle.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(335, 107);
            label5.Name = "label5";
            label5.Size = new Size(44, 15);
            label5.TabIndex = 13;
            label5.Text = "E-mail:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(337, 135);
            label6.Name = "label6";
            label6.Size = new Size(42, 15);
            label6.TabIndex = 14;
            label6.Text = "Cargo:";
            // 
            // mtbPhone
            // 
            mtbPhone.Location = new Point(80, 101);
            mtbPhone.Mask = "(99) 00000-0000";
            mtbPhone.Name = "mtbPhone";
            mtbPhone.Size = new Size(216, 23);
            mtbPhone.TabIndex = 15;
            // 
            // ContactForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(630, 293);
            Controls.Add(mtbPhone);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txtJobTitle);
            Controls.Add(txtEmail);
            Controls.Add(label4);
            Controls.Add(txtCompany);
            Controls.Add(label3);
            Controls.Add(txtName);
            Controls.Add(label2);
            Controls.Add(txtId);
            Controls.Add(label1);
            Controls.Add(btnCancel);
            Controls.Add(btnRecord);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ContactForm";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de Contatos";
            TopMost = true;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnRecord;
        private Button btnCancel;
        private Label label1;
        private TextBox txtId;
        private Label label2;
        private TextBox txtName;
        private Label label3;
        private TextBox txtCompany;
        private Label label4;
        private TextBox txtEmail;
        private TextBox txtJobTitle;
        private Label label5;
        private Label label6;
        private MaskedTextBox mtbPhone;
    }
}