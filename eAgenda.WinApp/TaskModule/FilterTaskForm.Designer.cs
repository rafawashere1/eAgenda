namespace eAgenda.WinApp.TaskModule
{
    partial class FilterTaskForm
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
            btnFilter = new Button();
            btnCancel = new Button();
            rdbAll = new RadioButton();
            rdbUnmarkeds = new RadioButton();
            rdbMarkeds = new RadioButton();
            SuspendLayout();
            // 
            // btnFilter
            // 
            btnFilter.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnFilter.DialogResult = DialogResult.OK;
            btnFilter.Location = new Point(173, 180);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(78, 46);
            btnFilter.TabIndex = 4;
            btnFilter.Text = "Filtrar";
            btnFilter.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Location = new Point(257, 180);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(78, 46);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "Cancelar";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // rdbAll
            // 
            rdbAll.AutoSize = true;
            rdbAll.Location = new Point(29, 38);
            rdbAll.Name = "rdbAll";
            rdbAll.Size = new Size(108, 19);
            rdbAll.TabIndex = 1;
            rdbAll.TabStop = true;
            rdbAll.Text = "Visualizar Todos";
            rdbAll.UseVisualStyleBackColor = true;
            // 
            // rdbUnmarkeds
            // 
            rdbUnmarkeds.AutoSize = true;
            rdbUnmarkeds.Location = new Point(29, 77);
            rdbUnmarkeds.Name = "rdbUnmarkeds";
            rdbUnmarkeds.Size = new Size(171, 19);
            rdbUnmarkeds.TabIndex = 2;
            rdbUnmarkeds.TabStop = true;
            rdbUnmarkeds.Text = "Visualizar Tarefas Pendentes";
            rdbUnmarkeds.UseVisualStyleBackColor = true;
            // 
            // rdbMarkeds
            // 
            rdbMarkeds.AutoSize = true;
            rdbMarkeds.Location = new Point(29, 116);
            rdbMarkeds.Name = "rdbMarkeds";
            rdbMarkeds.Size = new Size(175, 19);
            rdbMarkeds.TabIndex = 3;
            rdbMarkeds.TabStop = true;
            rdbMarkeds.Text = "Visualizar Tarefas Concluídas";
            rdbMarkeds.UseVisualStyleBackColor = true;
            // 
            // FilterTaskForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(347, 238);
            Controls.Add(rdbMarkeds);
            Controls.Add(rdbUnmarkeds);
            Controls.Add(rdbAll);
            Controls.Add(btnCancel);
            Controls.Add(btnFilter);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FilterTaskForm";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Filtro de Tarefas";
            TopMost = true;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnFilter;
        private Button btnCancel;
        private RadioButton rdbAll;
        private RadioButton rdbMarkeds;
        private RadioButton rdbUnmarkeds;
    }
}