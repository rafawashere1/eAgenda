namespace eAgenda.WinApp.AppointmentModule
{
    partial class FilterAppointmentForm
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
            rdbPasts = new RadioButton();
            rdbFutures = new RadioButton();
            dtpStartDate = new DateTimePicker();
            dtpEndDate = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // btnFilter
            // 
            btnFilter.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnFilter.DialogResult = DialogResult.OK;
            btnFilter.Location = new Point(173, 326);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(78, 46);
            btnFilter.TabIndex = 0;
            btnFilter.Text = "Filtrar";
            btnFilter.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Location = new Point(257, 326);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(78, 46);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "Cancelar";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // rdbAll
            // 
            rdbAll.AutoSize = true;
            rdbAll.Location = new Point(29, 38);
            rdbAll.Name = "rdbAll";
            rdbAll.Size = new Size(108, 19);
            rdbAll.TabIndex = 2;
            rdbAll.TabStop = true;
            rdbAll.Text = "Visualizar Todos";
            rdbAll.UseVisualStyleBackColor = true;
            // 
            // rdbPasts
            // 
            rdbPasts.AutoSize = true;
            rdbPasts.Location = new Point(29, 77);
            rdbPasts.Name = "rdbPasts";
            rdbPasts.Size = new Size(208, 19);
            rdbPasts.TabIndex = 3;
            rdbPasts.TabStop = true;
            rdbPasts.Text = "Visualizar Compromissos Passados";
            rdbPasts.UseVisualStyleBackColor = true;
            // 
            // rdbFutures
            // 
            rdbFutures.AutoSize = true;
            rdbFutures.Location = new Point(29, 116);
            rdbFutures.Name = "rdbFutures";
            rdbFutures.Size = new Size(200, 19);
            rdbFutures.TabIndex = 4;
            rdbFutures.TabStop = true;
            rdbFutures.Text = "Visualizar Compromissos Futuros";
            rdbFutures.UseVisualStyleBackColor = true;
            rdbFutures.CheckedChanged += rdbFutures_CheckedChanged;
            // 
            // dtpStartDate
            // 
            dtpStartDate.Enabled = false;
            dtpStartDate.Format = DateTimePickerFormat.Short;
            dtpStartDate.Location = new Point(100, 184);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new Size(142, 23);
            dtpStartDate.TabIndex = 5;
            // 
            // dtpEndDate
            // 
            dtpEndDate.Enabled = false;
            dtpEndDate.Format = DateTimePickerFormat.Short;
            dtpEndDate.Location = new Point(100, 219);
            dtpEndDate.Name = "dtpEndDate";
            dtpEndDate.Size = new Size(142, 23);
            dtpEndDate.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 190);
            label1.Name = "label1";
            label1.Size = new Size(65, 15);
            label1.TabIndex = 7;
            label1.Text = "Data Inicial";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 225);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 8;
            label2.Text = "Data Final";
            // 
            // FilterAppointmentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(347, 384);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dtpEndDate);
            Controls.Add(dtpStartDate);
            Controls.Add(rdbFutures);
            Controls.Add(rdbPasts);
            Controls.Add(rdbAll);
            Controls.Add(btnCancel);
            Controls.Add(btnFilter);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FilterAppointmentForm";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Filtro de Compromissos";
            TopMost = true;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnFilter;
        private Button btnCancel;
        private RadioButton rdbAll;
        private RadioButton rdbPasts;
        private RadioButton rdbFutures;
        private DateTimePicker dtpStartDate;
        private DateTimePicker dtpEndDate;
        private Label label1;
        private Label label2;
    }
}