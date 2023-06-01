﻿namespace e_Agenda.WinApp
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            cadastrosToolStripMenuItem = new ToolStripMenuItem();
            contactsMenuItem = new ToolStripMenuItem();
            appointmentMenuItem = new ToolStripMenuItem();
            tasksMenuItem = new ToolStripMenuItem();
            despesasToolStripMenuItem = new ToolStripMenuItem();
            spendingsMenuItem = new ToolStripMenuItem();
            categoriesMenuItem = new ToolStripMenuItem();
            toolStrip1 = new ToolStrip();
            btnAdd = new ToolStripButton();
            btnEdit = new ToolStripButton();
            btnDelete = new ToolStripButton();
            lblTypeRegistration = new ToolStripLabel();
            toolStripSeparator1 = new ToolStripSeparator();
            btnFilter = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            statusStrip1 = new StatusStrip();
            lblFooter = new ToolStripStatusLabel();
            panelRegisters = new Panel();
            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { cadastrosToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(934, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            cadastrosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { contactsMenuItem, appointmentMenuItem, tasksMenuItem, despesasToolStripMenuItem });
            cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            cadastrosToolStripMenuItem.Size = new Size(71, 20);
            cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // contactsMenuItem
            // 
            contactsMenuItem.Name = "contactsMenuItem";
            contactsMenuItem.Size = new Size(154, 22);
            contactsMenuItem.Text = "Contatos";
            contactsMenuItem.Click += contactsMenuItem_Click;
            // 
            // appointmentMenuItem
            // 
            appointmentMenuItem.Name = "appointmentMenuItem";
            appointmentMenuItem.Size = new Size(154, 22);
            appointmentMenuItem.Text = "Compromissos";
            appointmentMenuItem.Click += appointmentMenuItem_Click;
            // 
            // tasksMenuItem
            // 
            tasksMenuItem.Name = "tasksMenuItem";
            tasksMenuItem.Size = new Size(154, 22);
            tasksMenuItem.Text = "Tarefas";
            tasksMenuItem.Click += tasksMenuItem_Click;
            // 
            // despesasToolStripMenuItem
            // 
            despesasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { spendingsMenuItem, categoriesMenuItem });
            despesasToolStripMenuItem.Name = "despesasToolStripMenuItem";
            despesasToolStripMenuItem.Size = new Size(154, 22);
            despesasToolStripMenuItem.Text = "Despesas";
            // 
            // spendingsMenuItem
            // 
            spendingsMenuItem.Name = "spendingsMenuItem";
            spendingsMenuItem.Size = new Size(130, 22);
            spendingsMenuItem.Text = "Despesas";
            // 
            // categoriesMenuItem
            // 
            categoriesMenuItem.Name = "categoriesMenuItem";
            categoriesMenuItem.Size = new Size(130, 22);
            categoriesMenuItem.Text = "Categorias";
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnAdd, btnEdit, btnDelete, toolStripSeparator1, btnFilter, toolStripSeparator2, lblTypeRegistration });
            toolStrip1.Location = new Point(0, 24);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(934, 45);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnAdd
            // 
            btnAdd.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnAdd.Image = Properties.Resources.add_circle_FILL0_wght400_GRAD0_opsz24;
            btnAdd.ImageScaling = ToolStripItemImageScaling.None;
            btnAdd.ImageTransparentColor = Color.Magenta;
            btnAdd.Name = "btnAdd";
            btnAdd.Padding = new Padding(7);
            btnAdd.Size = new Size(42, 42);
            btnAdd.Text = "Inserir";
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnEdit.Image = Properties.Resources.edit_FILL0_wght400_GRAD0_opsz24;
            btnEdit.ImageScaling = ToolStripItemImageScaling.None;
            btnEdit.ImageTransparentColor = Color.Magenta;
            btnEdit.Name = "btnEdit";
            btnEdit.Padding = new Padding(7);
            btnEdit.Size = new Size(42, 42);
            btnEdit.Text = "Editar";
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnDelete.Image = Properties.Resources.delete_FILL0_wght400_GRAD0_opsz24;
            btnDelete.ImageScaling = ToolStripItemImageScaling.None;
            btnDelete.ImageTransparentColor = Color.Magenta;
            btnDelete.Name = "btnDelete";
            btnDelete.Padding = new Padding(7);
            btnDelete.Size = new Size(42, 42);
            btnDelete.Text = "Excluir";
            btnDelete.Click += btnDelete_Click;
            // 
            // lblTypeRegistration
            // 
            lblTypeRegistration.Name = "lblTypeRegistration";
            lblTypeRegistration.Size = new Size(107, 42);
            lblTypeRegistration.Text = "lblTypeRegistration";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 45);
            // 
            // btnFilter
            // 
            btnFilter.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnFilter.Image = Properties.Resources.filter_alt_FILL0_wght400_GRAD0_opsz24;
            btnFilter.ImageScaling = ToolStripItemImageScaling.None;
            btnFilter.ImageTransparentColor = Color.Magenta;
            btnFilter.Name = "btnFilter";
            btnFilter.Padding = new Padding(7);
            btnFilter.Size = new Size(42, 42);
            btnFilter.Text = "Filtrar";
            btnFilter.Click += btnFilter_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 45);
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblFooter });
            statusStrip1.Location = new Point(0, 530);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(934, 22);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            // 
            // lblFooter
            // 
            lblFooter.Name = "lblFooter";
            lblFooter.Size = new Size(49, 17);
            lblFooter.Text = "[Footer]";
            // 
            // panelRegisters
            // 
            panelRegisters.BorderStyle = BorderStyle.FixedSingle;
            panelRegisters.Dock = DockStyle.Fill;
            panelRegisters.Location = new Point(0, 69);
            panelRegisters.Name = "panelRegisters";
            panelRegisters.Size = new Size(934, 461);
            panelRegisters.TabIndex = 3;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(934, 552);
            Controls.Add(panelRegisters);
            Controls.Add(statusStrip1);
            Controls.Add(toolStrip1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            MinimumSize = new Size(816, 489);
            Name = "MainForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "e-Agenda 1.0";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem cadastrosToolStripMenuItem;
        private ToolStripMenuItem contactsMenuItem;
        private ToolStripMenuItem appointmentMenuItem;
        private ToolStripMenuItem tasksMenuItem;
        private ToolStripMenuItem despesasToolStripMenuItem;
        private ToolStripMenuItem spendingsMenuItem;
        private ToolStripMenuItem categoriesMenuItem;
        private ToolStrip toolStrip1;
        private ToolStripButton btnAdd;
        private ToolStripButton btnEdit;
        private ToolStripButton btnDelete;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lblFooter;
        private Panel panelRegisters;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripLabel lblTypeRegistration;
        private ToolStripButton btnFilter;
        private ToolStripSeparator toolStripSeparator2;
    }
}