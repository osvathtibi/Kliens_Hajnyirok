namespace Kliens_Hajnyirok
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
            button1 = new Button();
            panel1 = new Panel();
            dataGridView1 = new DataGridView();
            hccProductTranslationBindingSource = new BindingSource(components);
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            comboBox1 = new ComboBox();
            label1 = new Label();
            hccProductXcategoryBindingSource = new BindingSource(components);
            label3 = new Label();
            label4 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)hccProductTranslationBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)hccProductXcategoryBindingSource).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(64, 48, 32);
            button1.ForeColor = Color.FromArgb(255, 248, 240);
            button1.Location = new Point(334, 517);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(221, 44);
            button1.TabIndex = 0;
            button1.Text = "Rendelés megerősítése";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(dataGridView1);
            panel1.Location = new Point(25, 95);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(810, 319);
            panel1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.BackgroundColor = Color.FromArgb(255, 240, 224);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(3, 7);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(805, 308);
            dataGridView1.TabIndex = 0;
            // 
            // hccProductTranslationBindingSource
            // 
            hccProductTranslationBindingSource.DataSource = typeof(Models.HccProductTranslation);
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(255, 240, 224);
            textBox1.ForeColor = Color.FromArgb(32, 24, 16);
            textBox1.Location = new Point(248, 37);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(585, 27);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            textBox2.BackColor = Color.FromArgb(255, 240, 224);
            textBox2.ForeColor = Color.FromArgb(32, 24, 16);
            textBox2.Location = new Point(736, 431);
            textBox2.Margin = new Padding(2, 3, 2, 3);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(66, 27);
            textBox2.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.FromArgb(32, 24, 16);
            label2.Location = new Point(598, 435);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(125, 20);
            label2.TabIndex = 5;
            label2.Text = "Termék rendelése";
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.FromArgb(255, 240, 224);
            comboBox1.ForeColor = Color.FromArgb(32, 24, 16);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(25, 37);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(193, 28);
            comboBox1.TabIndex = 6;
            comboBox1.Text = "    Kategóriák";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.ForeColor = Color.FromArgb(32, 24, 16);
            label1.Location = new Point(808, 435);
            label1.Name = "label1";
            label1.Size = new Size(27, 20);
            label1.TabIndex = 7;
            label1.Text = "db";
            // 
            // hccProductXcategoryBindingSource
            // 
            hccProductXcategoryBindingSource.DataSource = typeof(Models.HccProductXcategory);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 14);
            label3.Name = "label3";
            label3.Size = new Size(133, 20);
            label3.TabIndex = 8;
            label3.Text = "Kategóriák szűrése";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(248, 9);
            label4.Name = "label4";
            label4.Size = new Size(200, 20);
            label4.TabIndex = 9;
            label4.Text = "Keresés valamilyen termékre:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.FromArgb(255, 248, 240);
            ClientSize = new Size(875, 619);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(panel1);
            Controls.Add(button1);
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            ShowIcon = false;
            ShowInTaskbar = false;
            Text = "Termékrendelés";
            TopMost = true;
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)hccProductTranslationBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)hccProductXcategoryBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Panel panel1;
        private TextBox textBox1;
        private DataGridView dataGridView1;
        private TextBox textBox2;
        private Label label2;
        private ComboBox comboBox1;
        private Label label1;
        private BindingSource hccProductTranslationBindingSource;
        private BindingSource hccProductXcategoryBindingSource;
        private Label label3;
        private Label label4;
    }
}
