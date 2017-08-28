namespace VolumeControl
{
    partial class volumControlForm
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
            this.components = new System.ComponentModel.Container();
            this.cancelButton = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonFunction1 = new System.Windows.Forms.ComboBox();
            this.buttonFunction2 = new System.Windows.Forms.ComboBox();
            this.buttonFunction3 = new System.Windows.Forms.ComboBox();
            this.buttonLabel = new System.Windows.Forms.Label();
            this.buttonFunction4 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonBox = new System.Windows.Forms.GroupBox();
            this.knobLabel1 = new System.Windows.Forms.Label();
            this.knobLabel3 = new System.Windows.Forms.Label();
            this.knobLabel2 = new System.Windows.Forms.Label();
            this.knobLabel4 = new System.Windows.Forms.Label();
            this.knobBox = new System.Windows.Forms.GroupBox();
            this.knobFunction3 = new System.Windows.Forms.ComboBox();
            this.knobFunction2 = new System.Windows.Forms.ComboBox();
            this.knobFunction1 = new System.Windows.Forms.ComboBox();
            this.knobFunction = new System.Windows.Forms.ComboBox();
            this.COMPortSelect = new System.Windows.Forms.GroupBox();
            this.COMPortSelector = new System.Windows.Forms.ComboBox();
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.buttonBox.SuspendLayout();
            this.knobBox.SuspendLayout();
            this.COMPortSelect.SuspendLayout();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(721, 435);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(69, 25);
            this.cancelButton.TabIndex = 2;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(646, 435);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(69, 25);
            this.buttonSave.TabIndex = 2;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonFunction1
            // 
            this.buttonFunction1.FormattingEnabled = true;
            this.buttonFunction1.Items.AddRange(new object[] {
            "Mute System",
            "Mute Application",
            "Open Application"});
            this.buttonFunction1.Location = new System.Drawing.Point(15, 36);
            this.buttonFunction1.Name = "buttonFunction1";
            this.buttonFunction1.Size = new System.Drawing.Size(134, 21);
            this.buttonFunction1.TabIndex = 0;
            this.buttonFunction1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // buttonFunction2
            // 
            this.buttonFunction2.FormattingEnabled = true;
            this.buttonFunction2.Items.AddRange(new object[] {
            "Mute System",
            "Mute Application",
            "Open Application"});
            this.buttonFunction2.Location = new System.Drawing.Point(15, 86);
            this.buttonFunction2.Name = "buttonFunction2";
            this.buttonFunction2.Size = new System.Drawing.Size(134, 21);
            this.buttonFunction2.TabIndex = 0;
            this.buttonFunction2.SelectedIndexChanged += new System.EventHandler(this.comboBox6_SelectedIndexChanged);
            // 
            // buttonFunction3
            // 
            this.buttonFunction3.FormattingEnabled = true;
            this.buttonFunction3.Items.AddRange(new object[] {
            "Mute System",
            "Mute Application",
            "Open Application"});
            this.buttonFunction3.Location = new System.Drawing.Point(15, 141);
            this.buttonFunction3.Name = "buttonFunction3";
            this.buttonFunction3.Size = new System.Drawing.Size(134, 21);
            this.buttonFunction3.TabIndex = 0;
            this.buttonFunction3.SelectedIndexChanged += new System.EventHandler(this.comboBox7_SelectedIndexChanged);
            // 
            // buttonLabel
            // 
            this.buttonLabel.AutoSize = true;
            this.buttonLabel.Location = new System.Drawing.Point(15, 17);
            this.buttonLabel.Name = "buttonLabel";
            this.buttonLabel.Size = new System.Drawing.Size(47, 13);
            this.buttonLabel.TabIndex = 1;
            this.buttonLabel.Text = "Button 1";
            this.buttonLabel.Click += new System.EventHandler(this.Label1_Click);
            // 
            // buttonFunction4
            // 
            this.buttonFunction4.FormattingEnabled = true;
            this.buttonFunction4.Items.AddRange(new object[] {
            "Mute System",
            "Mute Application",
            "Open Application"});
            this.buttonFunction4.Location = new System.Drawing.Point(15, 191);
            this.buttonFunction4.Name = "buttonFunction4";
            this.buttonFunction4.Size = new System.Drawing.Size(134, 21);
            this.buttonFunction4.TabIndex = 0;
            this.buttonFunction4.SelectedIndexChanged += new System.EventHandler(this.comboBox8_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Button 3";
            this.label6.Click += new System.EventHandler(this.Label1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Button 2";
            this.label7.Click += new System.EventHandler(this.Label1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 172);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Button 4";
            this.label8.Click += new System.EventHandler(this.Label1_Click);
            // 
            // buttonBox
            // 
            this.buttonBox.Controls.Add(this.label8);
            this.buttonBox.Controls.Add(this.label7);
            this.buttonBox.Controls.Add(this.label6);
            this.buttonBox.Controls.Add(this.buttonFunction4);
            this.buttonBox.Controls.Add(this.buttonLabel);
            this.buttonBox.Controls.Add(this.buttonFunction3);
            this.buttonBox.Controls.Add(this.buttonFunction2);
            this.buttonBox.Controls.Add(this.buttonFunction1);
            this.buttonBox.Location = new System.Drawing.Point(219, 95);
            this.buttonBox.Name = "buttonBox";
            this.buttonBox.Size = new System.Drawing.Size(170, 231);
            this.buttonBox.TabIndex = 5;
            this.buttonBox.TabStop = false;
            this.buttonBox.Text = "Button Function";
            // 
            // knobLabel1
            // 
            this.knobLabel1.AutoSize = true;
            this.knobLabel1.Location = new System.Drawing.Point(12, 16);
            this.knobLabel1.Name = "knobLabel1";
            this.knobLabel1.Size = new System.Drawing.Size(41, 13);
            this.knobLabel1.TabIndex = 1;
            this.knobLabel1.Text = "Knob 1";
            this.knobLabel1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // knobLabel3
            // 
            this.knobLabel3.AutoSize = true;
            this.knobLabel3.Location = new System.Drawing.Point(12, 121);
            this.knobLabel3.Name = "knobLabel3";
            this.knobLabel3.Size = new System.Drawing.Size(41, 13);
            this.knobLabel3.TabIndex = 1;
            this.knobLabel3.Text = "Knob 3";
            this.knobLabel3.Click += new System.EventHandler(this.Label1_Click);
            // 
            // knobLabel2
            // 
            this.knobLabel2.AutoSize = true;
            this.knobLabel2.Location = new System.Drawing.Point(12, 66);
            this.knobLabel2.Name = "knobLabel2";
            this.knobLabel2.Size = new System.Drawing.Size(41, 13);
            this.knobLabel2.TabIndex = 1;
            this.knobLabel2.Text = "Knob 2";
            this.knobLabel2.Click += new System.EventHandler(this.Label1_Click);
            // 
            // knobLabel4
            // 
            this.knobLabel4.AutoSize = true;
            this.knobLabel4.Location = new System.Drawing.Point(12, 171);
            this.knobLabel4.Name = "knobLabel4";
            this.knobLabel4.Size = new System.Drawing.Size(41, 13);
            this.knobLabel4.TabIndex = 1;
            this.knobLabel4.Text = "Knob 4";
            this.knobLabel4.Click += new System.EventHandler(this.Label1_Click);
            // 
            // knobBox
            // 
            this.knobBox.Controls.Add(this.knobFunction3);
            this.knobBox.Controls.Add(this.knobFunction2);
            this.knobBox.Controls.Add(this.knobFunction1);
            this.knobBox.Controls.Add(this.knobFunction);
            this.knobBox.Controls.Add(this.knobLabel4);
            this.knobBox.Controls.Add(this.knobLabel2);
            this.knobBox.Controls.Add(this.knobLabel3);
            this.knobBox.Controls.Add(this.knobLabel1);
            this.knobBox.Location = new System.Drawing.Point(32, 95);
            this.knobBox.Name = "knobBox";
            this.knobBox.Size = new System.Drawing.Size(172, 231);
            this.knobBox.TabIndex = 6;
            this.knobBox.TabStop = false;
            this.knobBox.Text = "Knob Function";
            // 
            // knobFunction3
            // 
            this.knobFunction3.FormattingEnabled = true;
            this.knobFunction3.Items.AddRange(new object[] {
            "Select function for knobs...",
            "System volume",
            "Application volume"});
            this.knobFunction3.Location = new System.Drawing.Point(15, 191);
            this.knobFunction3.Name = "knobFunction3";
            this.knobFunction3.Size = new System.Drawing.Size(121, 21);
            this.knobFunction3.TabIndex = 2;
            this.knobFunction3.SelectedIndexChanged += new System.EventHandler(this.knobFunction_SelectedIndexChanged);
            // 
            // knobFunction2
            // 
            this.knobFunction2.FormattingEnabled = true;
            this.knobFunction2.Items.AddRange(new object[] {
            "Select function for knobs...",
            "System volume",
            "Application volume"});
            this.knobFunction2.Location = new System.Drawing.Point(15, 141);
            this.knobFunction2.Name = "knobFunction2";
            this.knobFunction2.Size = new System.Drawing.Size(121, 21);
            this.knobFunction2.TabIndex = 2;
            this.knobFunction2.SelectedIndexChanged += new System.EventHandler(this.knobFunction_SelectedIndexChanged);
            // 
            // knobFunction1
            // 
            this.knobFunction1.FormattingEnabled = true;
            this.knobFunction1.Items.AddRange(new object[] {
            "Select function for knobs...",
            "System volume",
            "Application volume"});
            this.knobFunction1.Location = new System.Drawing.Point(15, 86);
            this.knobFunction1.Name = "knobFunction1";
            this.knobFunction1.Size = new System.Drawing.Size(121, 21);
            this.knobFunction1.TabIndex = 2;
            this.knobFunction1.SelectedIndexChanged += new System.EventHandler(this.knobFunction_SelectedIndexChanged);
            // 
            // knobFunction
            // 
            this.knobFunction.FormattingEnabled = true;
            this.knobFunction.Items.AddRange(new object[] {
            "Select function for knobs...",
            "System volume",
            "Application volume"});
            this.knobFunction.Location = new System.Drawing.Point(15, 36);
            this.knobFunction.Name = "knobFunction";
            this.knobFunction.Size = new System.Drawing.Size(121, 21);
            this.knobFunction.TabIndex = 2;
            this.knobFunction.SelectedIndexChanged += new System.EventHandler(this.knobFunction_SelectedIndexChanged);
            // 
            // COMPortSelect
            // 
            this.COMPortSelect.Controls.Add(this.COMPortSelector);
            this.COMPortSelect.Location = new System.Drawing.Point(32, 12);
            this.COMPortSelect.Name = "COMPortSelect";
            this.COMPortSelect.Size = new System.Drawing.Size(172, 59);
            this.COMPortSelect.TabIndex = 7;
            this.COMPortSelect.TabStop = false;
            this.COMPortSelect.Text = "COM port";
            this.COMPortSelect.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // COMPortSelector
            // 
            this.COMPortSelector.FormattingEnabled = true;
            this.COMPortSelector.Location = new System.Drawing.Point(15, 20);
            this.COMPortSelector.Name = "COMPortSelector";
            this.COMPortSelector.Size = new System.Drawing.Size(121, 21);
            this.COMPortSelector.TabIndex = 0;
            this.COMPortSelector.SelectedIndexChanged += new System.EventHandler(this.COMPortSelector_SelectedIndexChanged);
            // 
            // volumControlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 472);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.knobBox);
            this.Controls.Add(this.buttonBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.COMPortSelect);
            this.Name = "volumControlForm";
            this.Text = "Volume Control";
            this.Load += new System.EventHandler(this.volumControlForm_Load);
            this.buttonBox.ResumeLayout(false);
            this.buttonBox.PerformLayout();
            this.knobBox.ResumeLayout(false);
            this.knobBox.PerformLayout();
            this.COMPortSelect.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.ComboBox buttonFunction1;
        private System.Windows.Forms.ComboBox buttonFunction2;
        private System.Windows.Forms.ComboBox buttonFunction3;
        private System.Windows.Forms.Label buttonLabel;
        private System.Windows.Forms.ComboBox buttonFunction4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox buttonBox;
        private System.Windows.Forms.Label knobLabel1;
        private System.Windows.Forms.Label knobLabel3;
        private System.Windows.Forms.Label knobLabel2;
        private System.Windows.Forms.Label knobLabel4;
        private System.Windows.Forms.GroupBox knobBox;
        private System.Windows.Forms.GroupBox COMPortSelect;
        private System.Windows.Forms.ComboBox COMPortSelector;
        private System.Windows.Forms.ComboBox knobFunction;
        private System.Windows.Forms.ComboBox knobFunction3;
        private System.Windows.Forms.ComboBox knobFunction2;
        private System.Windows.Forms.ComboBox knobFunction1;
        private System.IO.Ports.SerialPort serialPort;
    }
}

