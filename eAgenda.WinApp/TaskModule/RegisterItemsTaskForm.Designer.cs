namespace eAgenda.WinApp.TaskModule
{
    partial class RegisterItemsTaskForm
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
            listItem = new ListBox();
            label3 = new Label();
            txtTitleItem = new TextBox();
            btnAdd = new Button();
            btnDeleteItem = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 79);
            label2.Name = "label2";
            label2.Size = new Size(37, 15);
            label2.TabIndex = 7;
            label2.Text = "Título";
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(83, 76);
            txtTitle.Name = "txtTitle";
            txtTitle.ReadOnly = true;
            txtTitle.Size = new Size(431, 23);
            txtTitle.TabIndex = 5;
            txtTitle.TabStop = false;
            // 
            // txtId
            // 
            txtId.Location = new Point(83, 31);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(86, 23);
            txtId.TabIndex = 6;
            txtId.TabStop = false;
            txtId.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(59, 34);
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
            // listItem
            // 
            listItem.FormattingEnabled = true;
            listItem.ItemHeight = 15;
            listItem.Location = new Point(19, 183);
            listItem.Name = "listItem";
            listItem.Size = new Size(495, 184);
            listItem.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 124);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 15;
            label3.Text = "Descrição";
            // 
            // txtTitleItem
            // 
            txtTitleItem.Location = new Point(83, 121);
            txtTitleItem.Name = "txtTitleItem";
            txtTitleItem.Size = new Size(323, 23);
            txtTitleItem.TabIndex = 1;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(412, 120);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(102, 24);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Adicionar";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDeleteItem
            // 
            btnDeleteItem.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnDeleteItem.Location = new Point(19, 403);
            btnDeleteItem.Name = "btnDeleteItem";
            btnDeleteItem.Size = new Size(78, 46);
            btnDeleteItem.TabIndex = 16;
            btnDeleteItem.Text = "Deletar";
            btnDeleteItem.UseVisualStyleBackColor = true;
            btnDeleteItem.Click += btnDelete_Click;
            // 
            // RegisterItemsTaskForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(534, 461);
            Controls.Add(btnDeleteItem);
            Controls.Add(btnAdd);
            Controls.Add(label3);
            Controls.Add(txtTitleItem);
            Controls.Add(listItem);
            Controls.Add(btnCancel);
            Controls.Add(btnRecord);
            Controls.Add(label2);
            Controls.Add(txtTitle);
            Controls.Add(txtId);
            Controls.Add(label1);
            Name = "RegisterItemsTaskForm";
            ShowIcon = false;
            Text = "Cadastro de Itens da Tarefa";
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
        private ListBox listItem;
        private Label label3;
        private TextBox txtTitleItem;
        private Button btnAdd;
        private Button btnDeleteItem;
    }
}