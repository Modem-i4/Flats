using System;

namespace Flats
{
    partial class MainForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.dataGridViewDefault = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.buttonExport = new System.Windows.Forms.Button();
            this.listBoxStats = new System.Windows.Forms.ListBox();
            this.dataGridViewParams = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxGeneralizedType = new System.Windows.Forms.ComboBox();
            this.comboBoxModels = new System.Windows.Forms.ComboBox();
            this.buttonAnalyze = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonCalculatePrice = new System.Windows.Forms.Button();
            this.buttonViewChart = new System.Windows.Forms.Button();
            this.dataGridViewModels = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBoxShowParams = new System.Windows.Forms.CheckBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDefault)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewParams)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewModels)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 426);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.toolStrip1);
            this.tabPage1.Controls.Add(this.dataGridViewDefault);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 397);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Import";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(3, 3);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(762, 27);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::Flats.Properties.Resources.open;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton1.Text = "Open";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButtonOpen_Click);
            // 
            // dataGridViewDefault
            // 
            this.dataGridViewDefault.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDefault.Location = new System.Drawing.Point(6, 33);
            this.dataGridViewDefault.Name = "dataGridViewDefault";
            this.dataGridViewDefault.RowHeadersWidth = 51;
            this.dataGridViewDefault.RowTemplate.Height = 24;
            this.dataGridViewDefault.Size = new System.Drawing.Size(756, 358);
            this.dataGridViewDefault.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.buttonExport);
            this.tabPage2.Controls.Add(this.listBoxStats);
            this.tabPage2.Controls.Add(this.dataGridViewParams);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.comboBoxGeneralizedType);
            this.tabPage2.Controls.Add(this.comboBoxModels);
            this.tabPage2.Controls.Add(this.buttonAnalyze);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 397);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Analyze";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // buttonExport
            // 
            this.buttonExport.Location = new System.Drawing.Point(552, 368);
            this.buttonExport.Name = "buttonExport";
            this.buttonExport.Size = new System.Drawing.Size(210, 23);
            this.buttonExport.TabIndex = 5;
            this.buttonExport.Text = "Export to docx";
            this.buttonExport.UseVisualStyleBackColor = true;
            this.buttonExport.Click += new System.EventHandler(this.buttonExport_Click);
            // 
            // listBoxStats
            // 
            this.listBoxStats.FormattingEnabled = true;
            this.listBoxStats.ItemHeight = 16;
            this.listBoxStats.Location = new System.Drawing.Point(552, 87);
            this.listBoxStats.Name = "listBoxStats";
            this.listBoxStats.Size = new System.Drawing.Size(213, 276);
            this.listBoxStats.TabIndex = 4;
            // 
            // dataGridViewParams
            // 
            this.dataGridViewParams.AllowUserToAddRows = false;
            this.dataGridViewParams.AllowUserToDeleteRows = false;
            this.dataGridViewParams.AllowUserToOrderColumns = true;
            this.dataGridViewParams.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewParams.Location = new System.Drawing.Point(10, 87);
            this.dataGridViewParams.Name = "dataGridViewParams";
            this.dataGridViewParams.ReadOnly = true;
            this.dataGridViewParams.RowHeadersVisible = false;
            this.dataGridViewParams.RowHeadersWidth = 51;
            this.dataGridViewParams.RowTemplate.Height = 24;
            this.dataGridViewParams.Size = new System.Drawing.Size(532, 307);
            this.dataGridViewParams.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(548, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(217, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Model stats";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(6, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(536, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Parameters";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(3, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Choose a model type";
            // 
            // comboBoxGeneralizedType
            // 
            this.comboBoxGeneralizedType.Enabled = false;
            this.comboBoxGeneralizedType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxGeneralizedType.FormattingEnabled = true;
            this.comboBoxGeneralizedType.Items.AddRange(new object[] {
            "Binomial",
            "InverseGaussian",
            "Normal",
            "Poisson"});
            this.comboBoxGeneralizedType.Location = new System.Drawing.Point(475, 19);
            this.comboBoxGeneralizedType.Name = "comboBoxGeneralizedType";
            this.comboBoxGeneralizedType.Size = new System.Drawing.Size(150, 28);
            this.comboBoxGeneralizedType.TabIndex = 1;
            this.comboBoxGeneralizedType.Text = "Binomial";
            this.comboBoxGeneralizedType.SelectedIndexChanged += new System.EventHandler(this.comboBoxModels_SelectedIndexChanged);
            // 
            // comboBoxModels
            // 
            this.comboBoxModels.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxModels.FormattingEnabled = true;
            this.comboBoxModels.Items.AddRange(new object[] {
            "Linear regression",
            "Generalized linear regression"});
            this.comboBoxModels.Location = new System.Drawing.Point(175, 19);
            this.comboBoxModels.Name = "comboBoxModels";
            this.comboBoxModels.Size = new System.Drawing.Size(294, 28);
            this.comboBoxModels.TabIndex = 1;
            this.comboBoxModels.SelectedIndexChanged += new System.EventHandler(this.comboBoxModels_SelectedIndexChanged);
            // 
            // buttonAnalyze
            // 
            this.buttonAnalyze.Enabled = false;
            this.buttonAnalyze.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAnalyze.Location = new System.Drawing.Point(631, 15);
            this.buttonAnalyze.Name = "buttonAnalyze";
            this.buttonAnalyze.Size = new System.Drawing.Size(131, 34);
            this.buttonAnalyze.TabIndex = 0;
            this.buttonAnalyze.Text = "Analyze!";
            this.buttonAnalyze.UseVisualStyleBackColor = true;
            this.buttonAnalyze.Click += new System.EventHandler(this.buttonAnalyze_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox2);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.groupBox1);
            this.tabPage3.Controls.Add(this.dataGridViewModels);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(768, 397);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Choose a model";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonCalculatePrice);
            this.groupBox1.Controls.Add(this.buttonViewChart);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(310, 49);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selected row actions";
            // 
            // buttonCalculatePrice
            // 
            this.buttonCalculatePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCalculatePrice.Location = new System.Drawing.Point(156, 20);
            this.buttonCalculatePrice.Name = "buttonCalculatePrice";
            this.buttonCalculatePrice.Size = new System.Drawing.Size(144, 23);
            this.buttonCalculatePrice.TabIndex = 0;
            this.buttonCalculatePrice.Text = "Calculate price";
            this.buttonCalculatePrice.UseVisualStyleBackColor = true;
            this.buttonCalculatePrice.Click += new System.EventHandler(this.buttonCalculatePrice_Click);
            // 
            // buttonViewChart
            // 
            this.buttonViewChart.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonViewChart.Location = new System.Drawing.Point(6, 20);
            this.buttonViewChart.Name = "buttonViewChart";
            this.buttonViewChart.Size = new System.Drawing.Size(144, 23);
            this.buttonViewChart.TabIndex = 0;
            this.buttonViewChart.Text = "View chart";
            this.buttonViewChart.UseVisualStyleBackColor = true;
            this.buttonViewChart.Click += new System.EventHandler(this.buttonViewChart_Click);
            // 
            // dataGridViewModels
            // 
            this.dataGridViewModels.AllowUserToAddRows = false;
            this.dataGridViewModels.AllowUserToDeleteRows = false;
            this.dataGridViewModels.AllowUserToOrderColumns = true;
            this.dataGridViewModels.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridViewModels.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewModels.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewModels.Location = new System.Drawing.Point(3, 58);
            this.dataGridViewModels.MultiSelect = false;
            this.dataGridViewModels.Name = "dataGridViewModels";
            this.dataGridViewModels.ReadOnly = true;
            this.dataGridViewModels.RowHeadersWidth = 51;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewModels.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewModels.RowTemplate.Height = 24;
            this.dataGridViewModels.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewModels.Size = new System.Drawing.Size(762, 336);
            this.dataGridViewModels.TabIndex = 0;
            this.dataGridViewModels.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewModels_ColumnHeaderMouseClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(478, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(202, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Click on a header to order by it";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(478, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(232, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Try ordering by a regression stat ->";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBoxShowParams);
            this.groupBox2.Location = new System.Drawing.Point(319, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(153, 48);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Display";
            // 
            // checkBoxShowParams
            // 
            this.checkBoxShowParams.AutoSize = true;
            this.checkBoxShowParams.Location = new System.Drawing.Point(6, 21);
            this.checkBoxShowParams.Name = "checkBoxShowParams";
            this.checkBoxShowParams.Size = new System.Drawing.Size(140, 21);
            this.checkBoxShowParams.TabIndex = 0;
            this.checkBoxShowParams.Text = "Show parameters";
            this.checkBoxShowParams.UseVisualStyleBackColor = true;
            this.checkBoxShowParams.CheckedChanged += new System.EventHandler(this.checkBoxShowParams_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDefault)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewParams)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewModels)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dataGridViewDefault;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.Button buttonAnalyze;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxModels;
        private System.Windows.Forms.DataGridView dataGridViewParams;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBoxStats;
        private System.Windows.Forms.ComboBox comboBoxGeneralizedType;
        private System.Windows.Forms.DataGridView dataGridViewModels;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonCalculatePrice;
        private System.Windows.Forms.Button buttonViewChart;
        private System.Windows.Forms.Button buttonExport;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkBoxShowParams;
    }
}

