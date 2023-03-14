namespace Digital_Clock
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            label2 = new Label();
            button1 = new Button();
            update_time = new System.Windows.Forms.Timer(components);
            comboBox1 = new ComboBox();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 50F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(-11, 9);
            label2.Name = "label2";
            label2.Size = new Size(227, 112);
            label2.TabIndex = 1;
            label2.Text = "Time";
            label2.TextAlign = ContentAlignment.TopRight;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(12, 220);
            button1.Name = "button1";
            button1.Size = new Size(135, 59);
            button1.TabIndex = 2;
            button1.Text = "Get Time";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // update_time
            // 
            update_time.Interval = 10;
            update_time.Tick += button1_Click;
            // 
            // comboBox1
            // 
            comboBox1.DropDownWidth = 300;
            comboBox1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "United Kingdom", "Eastern Standard Time", "Central Standard Time", "Pacific Standard Time" });
            comboBox1.Location = new Point(12, 171);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(262, 43);
            comboBox1.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 303);
            Controls.Add(comboBox1);
            Controls.Add(button1);
            Controls.Add(label2);
            Name = "Form1";
            Text = "Digital Clock";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Button button1;
        private System.Windows.Forms.Timer update_time;
        private ComboBox comboBox1;
    }
}