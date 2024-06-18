namespace EspressifBacktraceDecoder
{
    partial class MainWindow
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
            labelFwPath = new Label();
            buttonSelectFw = new Button();
            richTextBoxOutput = new RichTextBox();
            tableLayoutPanel = new TableLayoutPanel();
            panel1 = new Panel();
            buttonDecode = new Button();
            labelAddr2LinePath = new Label();
            textBoxInput = new TextBox();
            tableLayoutPanel.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // labelFwPath
            // 
            labelFwPath.AutoSize = true;
            labelFwPath.Location = new Point(208, 15);
            labelFwPath.Name = "labelFwPath";
            labelFwPath.Size = new Size(34, 15);
            labelFwPath.TabIndex = 1;
            labelFwPath.Text = "Path:";
            // 
            // buttonSelectFw
            // 
            buttonSelectFw.Location = new Point(93, 11);
            buttonSelectFw.Name = "buttonSelectFw";
            buttonSelectFw.Size = new Size(109, 23);
            buttonSelectFw.TabIndex = 0;
            buttonSelectFw.Text = "Select Firmware";
            buttonSelectFw.UseVisualStyleBackColor = true;
            buttonSelectFw.Click += buttonSelectFw_Click;
            // 
            // richTextBoxOutput
            // 
            richTextBoxOutput.BackColor = Color.Gainsboro;
            richTextBoxOutput.BorderStyle = BorderStyle.None;
            richTextBoxOutput.Dock = DockStyle.Fill;
            richTextBoxOutput.Font = new Font("Segoe UI Variable Display", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            richTextBoxOutput.Location = new Point(8, 237);
            richTextBoxOutput.Name = "richTextBoxOutput";
            richTextBoxOutput.ReadOnly = true;
            richTextBoxOutput.Size = new Size(784, 173);
            richTextBoxOutput.TabIndex = 0;
            richTextBoxOutput.Text = "";
            // 
            // tableLayoutPanel
            // 
            tableLayoutPanel.ColumnCount = 1;
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel.Controls.Add(richTextBoxOutput, 0, 2);
            tableLayoutPanel.Controls.Add(panel1, 0, 0);
            tableLayoutPanel.Controls.Add(labelAddr2LinePath, 0, 3);
            tableLayoutPanel.Controls.Add(textBoxInput, 0, 1);
            tableLayoutPanel.Dock = DockStyle.Fill;
            tableLayoutPanel.Location = new Point(0, 0);
            tableLayoutPanel.Name = "tableLayoutPanel";
            tableLayoutPanel.Padding = new Padding(5);
            tableLayoutPanel.RowCount = 4;
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
            tableLayoutPanel.Size = new Size(800, 450);
            tableLayoutPanel.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gainsboro;
            panel1.Controls.Add(buttonDecode);
            panel1.Controls.Add(labelFwPath);
            panel1.Controls.Add(buttonSelectFw);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(8, 8);
            panel1.Name = "panel1";
            panel1.Size = new Size(784, 44);
            panel1.TabIndex = 1;
            // 
            // buttonDecode
            // 
            buttonDecode.Location = new Point(7, 11);
            buttonDecode.Name = "buttonDecode";
            buttonDecode.Size = new Size(80, 23);
            buttonDecode.TabIndex = 2;
            buttonDecode.Text = "Decode";
            buttonDecode.UseVisualStyleBackColor = true;
            buttonDecode.Click += buttonDecode_Click;
            // 
            // labelAddr2LinePath
            // 
            labelAddr2LinePath.Anchor = AnchorStyles.Left;
            labelAddr2LinePath.AutoSize = true;
            labelAddr2LinePath.Location = new Point(15, 423);
            labelAddr2LinePath.Margin = new Padding(10);
            labelAddr2LinePath.Name = "labelAddr2LinePath";
            labelAddr2LinePath.Size = new Size(38, 12);
            labelAddr2LinePath.TabIndex = 2;
            labelAddr2LinePath.Text = "label1";
            // 
            // textBoxInput
            // 
            textBoxInput.BorderStyle = BorderStyle.None;
            textBoxInput.Dock = DockStyle.Fill;
            textBoxInput.Font = new Font("Segoe UI Variable Display", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxInput.Location = new Point(8, 58);
            textBoxInput.Multiline = true;
            textBoxInput.Name = "textBoxInput";
            textBoxInput.Size = new Size(784, 173);
            textBoxInput.TabIndex = 3;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel);
            Name = "MainWindow";
            Text = "Backtrace Decoder";
            tableLayoutPanel.ResumeLayout(false);
            tableLayoutPanel.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private RichTextBox richTextBoxOutput;
        private Button buttonSelectFw;
        private Label labelFwPath;
        private TableLayoutPanel tableLayoutPanel;
        private Panel panel1;
        private Label labelAddr2LinePath;
        private TextBox textBoxInput;
        private Button buttonDecode;
    }
}
