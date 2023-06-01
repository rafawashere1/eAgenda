namespace eAgenda.WinApp.TaskModule
{
    partial class TaskForm
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
            label1 = new Label();
            txtId = new TextBox();
            txtTitle = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            dtpCreationDate = new DateTimePicker();
            cmbPriority = new ComboBox();
            btnCancel = new Button();
            btnRecord = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(70, 49);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 0;
            label1.Text = "ID";
            // 
            // txtId
            // 
            txtId.Location = new Point(94, 46);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(86, 23);
            txtId.TabIndex = 2;
            txtId.Text = "0";
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(94, 88);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(452, 23);
            txtTitle.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(51, 91);
            label2.Name = "label2";
            label2.Size = new Size(37, 15);
            label2.TabIndex = 3;
            label2.Text = "Título";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 135);
            label3.Name = "label3";
            label3.Size = new Size(61, 15);
            label3.TabIndex = 4;
            label3.Text = "Prioridade";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(286, 135);
            label4.Name = "label4";
            label4.Size = new Size(90, 15);
            label4.TabIndex = 6;
            label4.Text = "Data de Criação";
            // 
            // dtpCreationDate
            // 
            dtpCreationDate.Format = DateTimePickerFormat.Short;
            dtpCreationDate.Location = new Point(382, 132);
            dtpCreationDate.Name = "dtpCreationDate";
            dtpCreationDate.Size = new Size(164, 23);
            dtpCreationDate.TabIndex = 7;
            // 
            // cmbPriority
            // 
            cmbPriority.FormattingEnabled = true;
            cmbPriority.Location = new Point(94, 132);
            cmbPriority.Name = "cmbPriority";
            cmbPriority.Size = new Size(172, 23);
            cmbPriority.TabIndex = 8;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Location = new Point(480, 311);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(77, 46);
            btnCancel.TabIndex = 10;
            btnCancel.Text = "Cancelar";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnRecord
            // 
            btnRecord.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnRecord.DialogResult = DialogResult.OK;
            btnRecord.Location = new Point(396, 311);
            btnRecord.Name = "btnRecord";
            btnRecord.Size = new Size(78, 46);
            btnRecord.TabIndex = 9;
            btnRecord.Text = "Gravar";
            btnRecord.UseVisualStyleBackColor = true;
            // 
            // TaskForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(576, 379);
            Controls.Add(btnCancel);
            Controls.Add(btnRecord);
            Controls.Add(cmbPriority);
            Controls.Add(dtpCreationDate);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtTitle);
            Controls.Add(txtId);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TaskForm";
            ShowIcon = false;
            ShowInTaskbar = false;
            Text = "TaskForm";
            TopMost = true;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtId;
        private TextBox txtTitle;
        private Label label2;
        private Label label3;
        private Label label4;
        private DateTimePicker dtpCreationDate;
        private ComboBox cmbPriority;
        private Button btnCancel;
        private Button btnRecord;
    }
}