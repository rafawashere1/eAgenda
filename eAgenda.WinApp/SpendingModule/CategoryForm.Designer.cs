namespace eAgenda.WinApp.SpendingModule
{
    partial class CategoryForm
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
            label2 = new Label();
            txtTitle = new TextBox();
            txtId = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Location = new Point(439, 205);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(77, 46);
            btnCancel.TabIndex = 15;
            btnCancel.Text = "Cancelar";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnRecord
            // 
            btnRecord.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnRecord.DialogResult = DialogResult.OK;
            btnRecord.Location = new Point(355, 205);
            btnRecord.Name = "btnRecord";
            btnRecord.Size = new Size(78, 46);
            btnRecord.TabIndex = 13;
            btnRecord.Text = "Gravar";
            btnRecord.UseVisualStyleBackColor = true;
            btnRecord.Click += btnRecord_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 84);
            label2.Name = "label2";
            label2.Size = new Size(37, 15);
            label2.TabIndex = 12;
            label2.Text = "Título";
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(65, 81);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(452, 23);
            txtTitle.TabIndex = 8;
            // 
            // txtId
            // 
            txtId.Location = new Point(65, 39);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(86, 23);
            txtId.TabIndex = 10;
            txtId.TabStop = false;
            txtId.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 42);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 7;
            label1.Text = "ID";
            // 
            // CategoryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(536, 263);
            Controls.Add(btnCancel);
            Controls.Add(btnRecord);
            Controls.Add(label2);
            Controls.Add(txtTitle);
            Controls.Add(txtId);
            Controls.Add(label1);
            Name = "CategoryForm";
            ShowIcon = false;
            Text = "Cadastro de Categorias";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancel;
        private Button btnRecord;
        private Label label2;
        private TextBox txtTitle;
        private TextBox txtId;
        private Label label1;
    }
}