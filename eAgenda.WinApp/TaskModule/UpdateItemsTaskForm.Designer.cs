namespace eAgenda.WinApp.TaskModule
{
    partial class UpdateItemsTaskForm
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
            label2 = new Label();
            txtTitle = new TextBox();
            txtId = new TextBox();
            label1 = new Label();
            btnCancel = new Button();
            btnRecord = new Button();
            checkedListItem = new CheckedListBox();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 79);
            label2.Name = "label2";
            label2.Size = new Size(37, 15);
            label2.TabIndex = 7;
            label2.Text = "Título";
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(62, 76);
            txtTitle.Name = "txtTitle";
            txtTitle.ReadOnly = true;
            txtTitle.Size = new Size(452, 23);
            txtTitle.TabIndex = 5;
            txtTitle.TabStop = false;
            // 
            // txtId
            // 
            txtId.Location = new Point(62, 31);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(107, 23);
            txtId.TabIndex = 6;
            txtId.TabStop = false;
            txtId.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 34);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 4;
            label1.Text = "ID";
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Location = new Point(439, 403);
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
            btnRecord.Location = new Point(355, 403);
            btnRecord.Name = "btnRecord";
            btnRecord.Size = new Size(78, 46);
            btnRecord.TabIndex = 3;
            btnRecord.Text = "Gravar";
            btnRecord.UseVisualStyleBackColor = true;
            // 
            // checkedListItem
            // 
            checkedListItem.CheckOnClick = true;
            checkedListItem.FormattingEnabled = true;
            checkedListItem.Location = new Point(19, 139);
            checkedListItem.Name = "checkedListItem";
            checkedListItem.Size = new Size(495, 238);
            checkedListItem.TabIndex = 8;
            // 
            // UpdateItemsTaskForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(534, 461);
            Controls.Add(checkedListItem);
            Controls.Add(btnCancel);
            Controls.Add(btnRecord);
            Controls.Add(label2);
            Controls.Add(txtTitle);
            Controls.Add(txtId);
            Controls.Add(label1);
            Name = "UpdateItemsTaskForm";
            ShowIcon = false;
            Text = "Atualização de Itens da Tarefa";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private TextBox txtTitle;
        private TextBox txtId;
        private Label label1;
        private Button btnCancel;
        private Button btnRecord;
        private CheckedListBox checkedListItem;
    }
}