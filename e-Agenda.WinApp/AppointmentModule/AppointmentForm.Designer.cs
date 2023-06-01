namespace e_Agenda.WinApp.AppointmentModule
{
    partial class AppointmentForm
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
            btnCancel = new Button();
            btnRecord = new Button();
            txtId = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtSubject = new TextBox();
            dtpDate = new DateTimePicker();
            label3 = new Label();
            dtpStart = new DateTimePicker();
            dtpEnd = new DateTimePicker();
            label4 = new Label();
            label5 = new Label();
            ckbSelectContact = new CheckBox();
            cmbContact = new ComboBox();
            groupBox1 = new GroupBox();
            txtOnline = new TextBox();
            txtInPerson = new TextBox();
            rdbOnline = new RadioButton();
            rdbInPerson = new RadioButton();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Location = new Point(442, 404);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(77, 46);
            btnCancel.TabIndex = 4;
            btnCancel.Text = "Cancelar";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnRecord
            // 
            btnRecord.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnRecord.DialogResult = DialogResult.OK;
            btnRecord.Location = new Point(358, 404);
            btnRecord.Name = "btnRecord";
            btnRecord.Size = new Size(78, 46);
            btnRecord.TabIndex = 3;
            btnRecord.Text = "Gravar";
            btnRecord.UseVisualStyleBackColor = true;
            btnRecord.Click += btnRecord_Click;
            // 
            // txtId
            // 
            txtId.Location = new Point(81, 24);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(100, 23);
            txtId.TabIndex = 6;
            txtId.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(54, 27);
            label1.Name = "label1";
            label1.Size = new Size(21, 15);
            label1.TabIndex = 7;
            label1.Text = "ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 66);
            label2.Name = "label2";
            label2.Size = new Size(53, 15);
            label2.TabIndex = 8;
            label2.Text = "Assunto:";
            // 
            // txtSubject
            // 
            txtSubject.Location = new Point(81, 62);
            txtSubject.Name = "txtSubject";
            txtSubject.Size = new Size(452, 23);
            txtSubject.TabIndex = 9;
            // 
            // dtpDate
            // 
            dtpDate.CustomFormat = "";
            dtpDate.Format = DateTimePickerFormat.Short;
            dtpDate.Location = new Point(81, 100);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(146, 23);
            dtpDate.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(41, 105);
            label3.Name = "label3";
            label3.Size = new Size(34, 15);
            label3.TabIndex = 11;
            label3.Text = "Data:";
            // 
            // dtpStart
            // 
            dtpStart.CustomFormat = "HH:mm";
            dtpStart.Format = DateTimePickerFormat.Custom;
            dtpStart.Location = new Point(81, 138);
            dtpStart.Name = "dtpStart";
            dtpStart.ShowUpDown = true;
            dtpStart.Size = new Size(146, 23);
            dtpStart.TabIndex = 12;
            // 
            // dtpEnd
            // 
            dtpEnd.CustomFormat = "HH:mm";
            dtpEnd.Format = DateTimePickerFormat.Custom;
            dtpEnd.Location = new Point(387, 139);
            dtpEnd.Name = "dtpEnd";
            dtpEnd.ShowUpDown = true;
            dtpEnd.Size = new Size(146, 23);
            dtpEnd.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(36, 144);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 14;
            label4.Text = "Início:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(328, 144);
            label5.Name = "label5";
            label5.Size = new Size(53, 15);
            label5.TabIndex = 15;
            label5.Text = "Término:";
            // 
            // ckbSelectContact
            // 
            ckbSelectContact.AutoSize = true;
            ckbSelectContact.Checked = true;
            ckbSelectContact.CheckState = CheckState.Checked;
            ckbSelectContact.Location = new Point(195, 199);
            ckbSelectContact.Name = "ckbSelectContact";
            ckbSelectContact.RightToLeft = RightToLeft.Yes;
            ckbSelectContact.Size = new Size(186, 19);
            ckbSelectContact.TabIndex = 16;
            ckbSelectContact.Text = "?Deseja selecionar um contato";
            ckbSelectContact.UseVisualStyleBackColor = true;
            ckbSelectContact.CheckedChanged += ckbSelectContact_CheckedChanged;
            // 
            // cmbContact
            // 
            cmbContact.BackColor = Color.White;
            cmbContact.DisplayMember = "Name";
            cmbContact.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbContact.FormattingEnabled = true;
            cmbContact.Location = new Point(145, 224);
            cmbContact.Name = "cmbContact";
            cmbContact.Size = new Size(291, 23);
            cmbContact.TabIndex = 17;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtOnline);
            groupBox1.Controls.Add(txtInPerson);
            groupBox1.Controls.Add(rdbOnline);
            groupBox1.Controls.Add(rdbInPerson);
            groupBox1.Location = new Point(81, 263);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(416, 122);
            groupBox1.TabIndex = 21;
            groupBox1.TabStop = false;
            groupBox1.Text = "Localização";
            // 
            // txtOnline
            // 
            txtOnline.Location = new Point(125, 61);
            txtOnline.Name = "txtOnline";
            txtOnline.Size = new Size(270, 23);
            txtOnline.TabIndex = 3;
            // 
            // txtInPerson
            // 
            txtInPerson.Location = new Point(125, 32);
            txtInPerson.Name = "txtInPerson";
            txtInPerson.Size = new Size(270, 23);
            txtInPerson.TabIndex = 2;
            // 
            // rdbOnline
            // 
            rdbOnline.AutoSize = true;
            rdbOnline.Location = new Point(25, 62);
            rdbOnline.Name = "rdbOnline";
            rdbOnline.Size = new Size(60, 19);
            rdbOnline.TabIndex = 1;
            rdbOnline.TabStop = true;
            rdbOnline.Text = "Online";
            rdbOnline.UseVisualStyleBackColor = true;
            rdbOnline.CheckedChanged += rdbOnline_CheckedChanged;
            // 
            // rdbInPerson
            // 
            rdbInPerson.AutoSize = true;
            rdbInPerson.Location = new Point(25, 33);
            rdbInPerson.Name = "rdbInPerson";
            rdbInPerson.Size = new Size(78, 19);
            rdbInPerson.TabIndex = 0;
            rdbInPerson.TabStop = true;
            rdbInPerson.Text = "Presencial";
            rdbInPerson.UseVisualStyleBackColor = true;
            rdbInPerson.CheckedChanged += rdbInPerson_CheckedChanged;
            // 
            // AppointmentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(549, 474);
            Controls.Add(groupBox1);
            Controls.Add(cmbContact);
            Controls.Add(ckbSelectContact);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(dtpEnd);
            Controls.Add(dtpStart);
            Controls.Add(label3);
            Controls.Add(dtpDate);
            Controls.Add(txtSubject);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtId);
            Controls.Add(btnCancel);
            Controls.Add(btnRecord);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AppointmentForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de Compromissos";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancel;
        private Button btnRecord;
        private TextBox txtId;
        private Label label1;
        private Label label2;
        private TextBox txtSubject;
        private DateTimePicker dtpDate;
        private Label label3;
        private DateTimePicker dtpStart;
        private DateTimePicker dtpEnd;
        private Label label4;
        private Label label5;
        private CheckBox ckbSelectContact;
        private ComboBox cmbContact;
        private GroupBox groupBox1;
        private TextBox txtOnline;
        private TextBox txtInPerson;
        private RadioButton rdbOnline;
        private RadioButton rdbInPerson;
    }
}