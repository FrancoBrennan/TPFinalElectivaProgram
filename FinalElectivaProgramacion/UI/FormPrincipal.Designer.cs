﻿namespace UI
{
    partial class FormPrincipal
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.buttonMostrarInfraccion = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonElimInfraccion = new System.Windows.Forms.Button();
            this.listBoxInfraccion = new System.Windows.Forms.ListBox();
            this.buttonModifInfraccion = new System.Windows.Forms.Button();
            this.buttonCrearInfraccion = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonPagoIncidente = new System.Windows.Forms.Button();
            this.textBoxBuscarInc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxMulta = new System.Windows.Forms.ListBox();
            this.buttonMostrarIncidente = new System.Windows.Forms.Button();
            this.buttonElimIncidente = new System.Windows.Forms.Button();
            this.buttonCrearIncidente = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataGridViewPagos = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPagos)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(686, 390);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.buttonMostrarInfraccion);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.listBoxInfraccion);
            this.tabPage1.Controls.Add(this.buttonModifInfraccion);
            this.tabPage1.Controls.Add(this.buttonCrearInfraccion);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Size = new System.Drawing.Size(678, 364);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Infracción";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // buttonMostrarInfraccion
            // 
            this.buttonMostrarInfraccion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMostrarInfraccion.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.buttonMostrarInfraccion.Location = new System.Drawing.Point(48, 190);
            this.buttonMostrarInfraccion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonMostrarInfraccion.Name = "buttonMostrarInfraccion";
            this.buttonMostrarInfraccion.Size = new System.Drawing.Size(158, 50);
            this.buttonMostrarInfraccion.TabIndex = 3;
            this.buttonMostrarInfraccion.Text = "Mostrar infracción";
            this.buttonMostrarInfraccion.UseVisualStyleBackColor = true;
            this.buttonMostrarInfraccion.Click += new System.EventHandler(this.buttonMostrarInfraccion_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonElimInfraccion);
            this.panel1.Location = new System.Drawing.Point(48, 253);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(158, 50);
            this.panel1.TabIndex = 5;
            this.panel1.MouseHover += new System.EventHandler(this.panel1_MouseHover);
            // 
            // buttonElimInfraccion
            // 
            this.buttonElimInfraccion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonElimInfraccion.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.buttonElimInfraccion.Location = new System.Drawing.Point(0, 0);
            this.buttonElimInfraccion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonElimInfraccion.Name = "buttonElimInfraccion";
            this.buttonElimInfraccion.Size = new System.Drawing.Size(158, 50);
            this.buttonElimInfraccion.TabIndex = 2;
            this.buttonElimInfraccion.Text = "Eliminar infracción";
            this.buttonElimInfraccion.UseVisualStyleBackColor = true;
            this.buttonElimInfraccion.Click += new System.EventHandler(this.buttonElimInfraccion_Click);
            // 
            // listBoxInfraccion
            // 
            this.listBoxInfraccion.FormattingEnabled = true;
            this.listBoxInfraccion.Location = new System.Drawing.Point(370, 32);
            this.listBoxInfraccion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBoxInfraccion.Name = "listBoxInfraccion";
            this.listBoxInfraccion.Size = new System.Drawing.Size(305, 329);
            this.listBoxInfraccion.TabIndex = 4;
            this.listBoxInfraccion.SelectedIndexChanged += new System.EventHandler(this.listBoxInfraccion_SelectedIndexChanged);
            this.listBoxInfraccion.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.listBoxInfraccion_Format);
            // 
            // buttonModifInfraccion
            // 
            this.buttonModifInfraccion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonModifInfraccion.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.buttonModifInfraccion.Location = new System.Drawing.Point(48, 127);
            this.buttonModifInfraccion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonModifInfraccion.Name = "buttonModifInfraccion";
            this.buttonModifInfraccion.Size = new System.Drawing.Size(158, 50);
            this.buttonModifInfraccion.TabIndex = 1;
            this.buttonModifInfraccion.Text = "Modificar infracción";
            this.buttonModifInfraccion.UseVisualStyleBackColor = true;
            this.buttonModifInfraccion.Click += new System.EventHandler(this.buttonModifInfraccion_Click);
            // 
            // buttonCrearInfraccion
            // 
            this.buttonCrearInfraccion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCrearInfraccion.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.buttonCrearInfraccion.Location = new System.Drawing.Point(48, 63);
            this.buttonCrearInfraccion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonCrearInfraccion.Name = "buttonCrearInfraccion";
            this.buttonCrearInfraccion.Size = new System.Drawing.Size(158, 50);
            this.buttonCrearInfraccion.TabIndex = 0;
            this.buttonCrearInfraccion.Text = "Crear infracción";
            this.buttonCrearInfraccion.UseVisualStyleBackColor = true;
            this.buttonCrearInfraccion.Click += new System.EventHandler(this.buttonCrearInfraccion_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Controls.Add(this.textBoxBuscarInc);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.listBoxMulta);
            this.tabPage2.Controls.Add(this.buttonMostrarIncidente);
            this.tabPage2.Controls.Add(this.buttonElimIncidente);
            this.tabPage2.Controls.Add(this.buttonCrearIncidente);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2.Size = new System.Drawing.Size(678, 364);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Multa";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buttonPagoIncidente);
            this.panel2.Location = new System.Drawing.Point(48, 253);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(158, 50);
            this.panel2.TabIndex = 12;
            this.panel2.MouseHover += new System.EventHandler(this.panel2_MouseHover);
            // 
            // buttonPagoIncidente
            // 
            this.buttonPagoIncidente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPagoIncidente.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.buttonPagoIncidente.Location = new System.Drawing.Point(0, 0);
            this.buttonPagoIncidente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonPagoIncidente.Name = "buttonPagoIncidente";
            this.buttonPagoIncidente.Size = new System.Drawing.Size(158, 50);
            this.buttonPagoIncidente.TabIndex = 9;
            this.buttonPagoIncidente.Text = "Registrar pago";
            this.buttonPagoIncidente.UseVisualStyleBackColor = true;
            this.buttonPagoIncidente.Click += new System.EventHandler(this.buttonPagoIncidente_Click);
            // 
            // textBoxBuscarInc
            // 
            this.textBoxBuscarInc.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.textBoxBuscarInc.Location = new System.Drawing.Point(474, 3);
            this.textBoxBuscarInc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxBuscarInc.Name = "textBoxBuscarInc";
            this.textBoxBuscarInc.Size = new System.Drawing.Size(200, 27);
            this.textBoxBuscarInc.TabIndex = 11;
            this.textBoxBuscarInc.TextChanged += new System.EventHandler(this.textBoxBuscarInc_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label1.Location = new System.Drawing.Point(367, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Buscar patente";
            // 
            // listBoxMulta
            // 
            this.listBoxMulta.FormattingEnabled = true;
            this.listBoxMulta.Location = new System.Drawing.Point(370, 32);
            this.listBoxMulta.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBoxMulta.Name = "listBoxMulta";
            this.listBoxMulta.Size = new System.Drawing.Size(305, 329);
            this.listBoxMulta.TabIndex = 8;
            this.listBoxMulta.SelectedIndexChanged += new System.EventHandler(this.listBoxIncidente_SelectedIndexChanged);
            this.listBoxMulta.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.listBoxIncidente_Format);
            // 
            // buttonMostrarIncidente
            // 
            this.buttonMostrarIncidente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMostrarIncidente.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.buttonMostrarIncidente.Location = new System.Drawing.Point(48, 127);
            this.buttonMostrarIncidente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonMostrarIncidente.Name = "buttonMostrarIncidente";
            this.buttonMostrarIncidente.Size = new System.Drawing.Size(158, 50);
            this.buttonMostrarIncidente.TabIndex = 7;
            this.buttonMostrarIncidente.Text = "Mostrar multa";
            this.buttonMostrarIncidente.UseVisualStyleBackColor = true;
            this.buttonMostrarIncidente.Click += new System.EventHandler(this.buttonMostrarIncidente_Click);
            // 
            // buttonElimIncidente
            // 
            this.buttonElimIncidente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonElimIncidente.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.buttonElimIncidente.Location = new System.Drawing.Point(48, 190);
            this.buttonElimIncidente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonElimIncidente.Name = "buttonElimIncidente";
            this.buttonElimIncidente.Size = new System.Drawing.Size(158, 50);
            this.buttonElimIncidente.TabIndex = 6;
            this.buttonElimIncidente.Text = "Eliminar multa";
            this.buttonElimIncidente.UseVisualStyleBackColor = true;
            this.buttonElimIncidente.Click += new System.EventHandler(this.buttonElimIncidente_Click);
            // 
            // buttonCrearIncidente
            // 
            this.buttonCrearIncidente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCrearIncidente.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.buttonCrearIncidente.Location = new System.Drawing.Point(48, 63);
            this.buttonCrearIncidente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonCrearIncidente.Name = "buttonCrearIncidente";
            this.buttonCrearIncidente.Size = new System.Drawing.Size(158, 50);
            this.buttonCrearIncidente.TabIndex = 4;
            this.buttonCrearIncidente.Text = "Crear multa";
            this.buttonCrearIncidente.UseVisualStyleBackColor = true;
            this.buttonCrearIncidente.Click += new System.EventHandler(this.buttonCrearIncidente_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dataGridViewPagos);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(678, 364);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Pago";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridViewPagos
            // 
            this.dataGridViewPagos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPagos.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewPagos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewPagos.Name = "dataGridViewPagos";
            this.dataGridViewPagos.RowHeadersWidth = 51;
            this.dataGridViewPagos.RowTemplate.Height = 25;
            this.dataGridViewPagos.Size = new System.Drawing.Size(679, 366);
            this.dataGridViewPagos.TabIndex = 0;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 390);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dirección de Tránsito";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPagos)).EndInit();
            this.ResumeLayout(false);

        }


        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button buttonMostrarInfraccion;
        private System.Windows.Forms.Button buttonElimInfraccion;
        private System.Windows.Forms.Button buttonModifInfraccion;
        private System.Windows.Forms.Button buttonCrearInfraccion;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button buttonMostrarIncidente;
        private System.Windows.Forms.Button buttonElimIncidente;
        private System.Windows.Forms.Button buttonCrearIncidente;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ListBox listBoxInfraccion;
        private System.Windows.Forms.ListBox listBoxMulta;
        private System.Windows.Forms.TextBox textBoxBuscarInc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonPagoIncidente;
        private System.Windows.Forms.DataGridView dataGridViewPagos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}