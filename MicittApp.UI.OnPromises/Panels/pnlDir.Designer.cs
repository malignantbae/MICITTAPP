﻿namespace MicittApp.UI.OnPromises.Panels
{
    partial class pnlDir
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.btnDelete = new MetroFramework.Controls.MetroTile();
            this.btnCreate = new MetroFramework.Controls.MetroTile();
            this.btnRefresh = new MetroFramework.Controls.MetroTile();
            this.btnUpdate = new MetroFramework.Controls.MetroTile();
            this.metroTabControl = new MetroFramework.Controls.MetroTabControl();
            this.TabDir = new MetroFramework.Controls.MetroTabPage();
            this.dgvDir = new MetroFramework.Controls.MetroGrid();
            this.ID_DIR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRIP_DIR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtDescripDir = new MetroFramework.Controls.MetroTextBox();
            this.lblDescrip = new MetroFramework.Controls.MetroLabel();
            this.metroPanel1.SuspendLayout();
            this.metroTabControl.SuspendLayout();
            this.TabDir.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDir)).BeginInit();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.btnDelete);
            this.metroPanel1.Controls.Add(this.btnCreate);
            this.metroPanel1.Controls.Add(this.btnRefresh);
            this.metroPanel1.Controls.Add(this.btnUpdate);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(0, 0);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(626, 71);
            this.metroPanel1.TabIndex = 12;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // btnDelete
            // 
            this.btnDelete.ActiveControl = null;
            this.btnDelete.Location = new System.Drawing.Point(181, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(83, 60);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Eliminar";
            this.btnDelete.UseSelectable = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.ActiveControl = null;
            this.btnCreate.Location = new System.Drawing.Point(3, 3);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(83, 60);
            this.btnCreate.TabIndex = 5;
            this.btnCreate.Text = "Agregar";
            this.btnCreate.UseSelectable = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.ActiveControl = null;
            this.btnRefresh.Location = new System.Drawing.Point(270, 3);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(83, 60);
            this.btnRefresh.TabIndex = 8;
            this.btnRefresh.Text = "Refrescar";
            this.btnRefresh.UseSelectable = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.ActiveControl = null;
            this.btnUpdate.Location = new System.Drawing.Point(92, 3);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(83, 60);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "Actualizar";
            this.btnUpdate.UseSelectable = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // metroTabControl
            // 
            this.metroTabControl.Controls.Add(this.TabDir);
            this.metroTabControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.metroTabControl.Location = new System.Drawing.Point(0, 72);
            this.metroTabControl.Name = "metroTabControl";
            this.metroTabControl.SelectedIndex = 0;
            this.metroTabControl.Size = new System.Drawing.Size(626, 397);
            this.metroTabControl.TabIndex = 13;
            this.metroTabControl.UseSelectable = true;
            // 
            // TabDir
            // 
            this.TabDir.Controls.Add(this.dgvDir);
            this.TabDir.Controls.Add(this.txtDescripDir);
            this.TabDir.Controls.Add(this.lblDescrip);
            this.TabDir.HorizontalScrollbarBarColor = true;
            this.TabDir.HorizontalScrollbarHighlightOnWheel = false;
            this.TabDir.HorizontalScrollbarSize = 10;
            this.TabDir.Location = new System.Drawing.Point(4, 38);
            this.TabDir.Name = "TabDir";
            this.TabDir.Size = new System.Drawing.Size(618, 355);
            this.TabDir.TabIndex = 0;
            this.TabDir.Text = "Direcciones";
            this.TabDir.VerticalScrollbarBarColor = true;
            this.TabDir.VerticalScrollbarHighlightOnWheel = false;
            this.TabDir.VerticalScrollbarSize = 10;
            // 
            // dgvDir
            // 
            this.dgvDir.AllowUserToResizeRows = false;
            this.dgvDir.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvDir.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDir.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvDir.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDir.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDir.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDir.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_DIR,
            this.DESCRIP_DIR});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDir.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvDir.EnableHeadersVisualStyles = false;
            this.dgvDir.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvDir.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvDir.Location = new System.Drawing.Point(-4, 135);
            this.dgvDir.Name = "dgvDir";
            this.dgvDir.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDir.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvDir.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvDir.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDir.Size = new System.Drawing.Size(626, 224);
            this.dgvDir.TabIndex = 17;
            // 
            // ID_DIR
            // 
            this.ID_DIR.HeaderText = "ID_DIR";
            this.ID_DIR.Name = "ID_DIR";
            this.ID_DIR.Visible = false;
            // 
            // DESCRIP_DIR
            // 
            this.DESCRIP_DIR.HeaderText = "Descripción";
            this.DESCRIP_DIR.Name = "DESCRIP_DIR";
            // 
            // txtDescripDir
            // 
            // 
            // 
            // 
            this.txtDescripDir.CustomButton.Image = null;
            this.txtDescripDir.CustomButton.Location = new System.Drawing.Point(121, 1);
            this.txtDescripDir.CustomButton.Name = "";
            this.txtDescripDir.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtDescripDir.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDescripDir.CustomButton.TabIndex = 1;
            this.txtDescripDir.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDescripDir.CustomButton.UseSelectable = true;
            this.txtDescripDir.CustomButton.Visible = false;
            this.txtDescripDir.Lines = new string[0];
            this.txtDescripDir.Location = new System.Drawing.Point(100, 13);
            this.txtDescripDir.MaxLength = 32767;
            this.txtDescripDir.Name = "txtDescripDir";
            this.txtDescripDir.PasswordChar = '\0';
            this.txtDescripDir.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDescripDir.SelectedText = "";
            this.txtDescripDir.SelectionLength = 0;
            this.txtDescripDir.SelectionStart = 0;
            this.txtDescripDir.ShortcutsEnabled = true;
            this.txtDescripDir.Size = new System.Drawing.Size(143, 23);
            this.txtDescripDir.TabIndex = 3;
            this.txtDescripDir.UseSelectable = true;
            this.txtDescripDir.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDescripDir.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblDescrip
            // 
            this.lblDescrip.AutoSize = true;
            this.lblDescrip.Location = new System.Drawing.Point(5, 17);
            this.lblDescrip.Name = "lblDescrip";
            this.lblDescrip.Size = new System.Drawing.Size(76, 19);
            this.lblDescrip.TabIndex = 2;
            this.lblDescrip.Text = "Descripción";
            // 
            // pnlDir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.metroTabControl);
            this.Controls.Add(this.metroPanel1);
            this.Name = "pnlDir";
            this.Size = new System.Drawing.Size(626, 469);
            this.metroPanel1.ResumeLayout(false);
            this.metroTabControl.ResumeLayout(false);
            this.TabDir.ResumeLayout(false);
            this.TabDir.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDir)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroTile btnDelete;
        private MetroFramework.Controls.MetroTile btnCreate;
        private MetroFramework.Controls.MetroTile btnRefresh;
        private MetroFramework.Controls.MetroTile btnUpdate;
        private MetroFramework.Controls.MetroTabControl metroTabControl;
        private MetroFramework.Controls.MetroTabPage TabDir;
        private MetroFramework.Controls.MetroGrid dgvDir;
        private MetroFramework.Controls.MetroTextBox txtDescripDir;
        private MetroFramework.Controls.MetroLabel lblDescrip;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_DIR;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRIP_DIR;
    }
}