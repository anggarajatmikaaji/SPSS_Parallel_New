using System.Diagnostics;
using System.Windows.Forms;
namespace ParallelSPSS
{
    partial class ResultSLR
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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.AutoScroll = true;
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.BackColor = System.Drawing.SystemColors.Control;
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.38462F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 59.61538F));
            this.tableLayoutPanel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(70, 72);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.07317F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(417, 235);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Location = new System.Drawing.Point(210, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(0, 0);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(95, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Parameter";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(365, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Value";
            // 
            // ResultSLR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 349);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Name = "ResultSLR";
            this.Text = "ResultForm";
            this.ResumeLayout(false);
            this.PerformLayout();
            this.Load += ResultForm_Load;
            this.Load += new System.EventHandler(this.ResultSLR_Load);
        }
        void ResultForm_Load(object sender, System.EventArgs e)
        {
                tableLayoutPanel2.RowCount = tableLayoutPanel2.RowCount + 1;
                tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
                tableLayoutPanel2.Controls.Add(new Label() { Text = "Y", Anchor = AnchorStyles.Left, AutoSize = true }, 0, tableLayoutPanel2.RowCount - 1);
                tableLayoutPanel2.Controls.Add(new Label() { Text = Form1.columnChoosen[0], Anchor = AnchorStyles.Left, AutoSize = true }, 1, tableLayoutPanel2.RowCount - 1);
                tableLayoutPanel2.RowCount = tableLayoutPanel2.RowCount + 1;
                tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
                tableLayoutPanel2.Controls.Add(new Label() { Text = "X", Anchor = AnchorStyles.Left, AutoSize = true }, 0, tableLayoutPanel2.RowCount - 1);
                tableLayoutPanel2.Controls.Add(new Label() { Text = Form1.columnChoosen[1], Anchor = AnchorStyles.Left, AutoSize = true }, 1, tableLayoutPanel2.RowCount - 1);
                tableLayoutPanel2.RowCount = tableLayoutPanel2.RowCount + 1;
                tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
                tableLayoutPanel2.Controls.Add(new Label() { Text = "Alpha", Anchor = AnchorStyles.Left, AutoSize = true }, 0, tableLayoutPanel2.RowCount - 1);
                tableLayoutPanel2.Controls.Add(new Label() { Text = Form1.ab[1], Anchor = AnchorStyles.Left, AutoSize = true }, 1, tableLayoutPanel2.RowCount - 1);
                tableLayoutPanel2.RowCount = tableLayoutPanel2.RowCount + 1;
                tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
                tableLayoutPanel2.Controls.Add(new Label() { Text = "Beta", Anchor = AnchorStyles.Left, AutoSize = true }, 0, tableLayoutPanel2.RowCount - 1);
                tableLayoutPanel2.Controls.Add(new Label() { Text = Form1.ab[0], Anchor = AnchorStyles.Left, AutoSize = true }, 1, tableLayoutPanel2.RowCount - 1);
                tableLayoutPanel2.RowCount = tableLayoutPanel2.RowCount + 1;
                tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
                tableLayoutPanel2.Controls.Add(new Label() { Text = "Formula", Anchor = AnchorStyles.Left, AutoSize = true }, 0, tableLayoutPanel2.RowCount - 1);
                tableLayoutPanel2.Controls.Add(new Label() { Text = "Y  =  " + Form1.ab[1] + "  +  " + Form1.ab[0]+" x", Anchor = AnchorStyles.Left, AutoSize = true }, 1, tableLayoutPanel2.RowCount - 1);
        }
        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
    }
}