namespace BOT_V3
{
    partial class Form_Home
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
            tableLayoutPanel1 = new TableLayoutPanel();
            Button_CreateAndUpdate_Table = new Button();
            Button_ShowGraph = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(Button_ShowGraph, 1, 0);
            tableLayoutPanel1.Controls.Add(Button_CreateAndUpdate_Table, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 8;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.Size = new Size(754, 619);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // Button_CreateAndUpdate_Table
            // 
            Button_CreateAndUpdate_Table.Dock = DockStyle.Fill;
            Button_CreateAndUpdate_Table.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Button_CreateAndUpdate_Table.Location = new Point(3, 3);
            Button_CreateAndUpdate_Table.Name = "Button_CreateAndUpdate_Table";
            Button_CreateAndUpdate_Table.Size = new Size(371, 71);
            Button_CreateAndUpdate_Table.TabIndex = 0;
            Button_CreateAndUpdate_Table.Text = "CreateAndUpdate_Table";
            Button_CreateAndUpdate_Table.UseVisualStyleBackColor = true;
            Button_CreateAndUpdate_Table.Click += Button_CreateAndUpdate_Table_Click;
            // 
            // Button_ShowGraph
            // 
            Button_ShowGraph.Dock = DockStyle.Fill;
            Button_ShowGraph.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Button_ShowGraph.Location = new Point(380, 3);
            Button_ShowGraph.Name = "Button_ShowGraph";
            Button_ShowGraph.Size = new Size(371, 71);
            Button_ShowGraph.TabIndex = 1;
            Button_ShowGraph.Text = "ShowGraph";
            Button_ShowGraph.UseVisualStyleBackColor = true;
            Button_ShowGraph.Click += Button_ShowGraph_Click;
            // 
            // Form_Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(754, 619);
            Controls.Add(tableLayoutPanel1);
            Name = "Form_Home";
            Text = "Home";
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button Button_CreateAndUpdate_Table;
        private Button Button_ShowGraph;
    }
}
