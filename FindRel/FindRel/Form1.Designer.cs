namespace FindRel
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
            this.productsList = new System.Windows.Forms.ListBox();
            this.categoriesList = new System.Windows.Forms.ListBox();
            this.input = new System.Windows.Forms.TextBox();
            this.resList = new System.Windows.Forms.ListBox();
            this.selectButton = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // productsList
            // 
            this.productsList.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.productsList.FormattingEnabled = true;
            this.productsList.ItemHeight = 23;
            this.productsList.Location = new System.Drawing.Point(35, 86);
            this.productsList.Name = "productsList";
            this.productsList.Size = new System.Drawing.Size(240, 119);
            this.productsList.TabIndex = 0;
            // 
            // categoriesList
            // 
            this.categoriesList.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.categoriesList.FormattingEnabled = true;
            this.categoriesList.ItemHeight = 23;
            this.categoriesList.Location = new System.Drawing.Point(35, 234);
            this.categoriesList.Name = "categoriesList";
            this.categoriesList.Size = new System.Drawing.Size(240, 119);
            this.categoriesList.TabIndex = 1;
            // 
            // input
            // 
            this.input.Location = new System.Drawing.Point(281, 35);
            this.input.Name = "input";
            this.input.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.input.Size = new System.Drawing.Size(405, 23);
            this.input.TabIndex = 2;
            // 
            // resList
            // 
            this.resList.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.resList.FormattingEnabled = true;
            this.resList.ItemHeight = 21;
            this.resList.Location = new System.Drawing.Point(281, 76);
            this.resList.Name = "resList";
            this.resList.Size = new System.Drawing.Size(486, 277);
            this.resList.TabIndex = 3;
            // 
            // selectButton
            // 
            this.selectButton.Location = new System.Drawing.Point(692, 35);
            this.selectButton.Name = "selectButton";
            this.selectButton.Size = new System.Drawing.Size(75, 23);
            this.selectButton.TabIndex = 4;
            this.selectButton.Text = "SELECT";
            this.selectButton.UseVisualStyleBackColor = true;
            this.selectButton.Click += new System.EventHandler(this.selectButton_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "select * from Relations",
            "select * from Relations where Product_id = 1",
            "select * from Relations where Category_id = 1"});
            this.comboBox1.Location = new System.Drawing.Point(35, 36);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(240, 23);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(35, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "Тест кейсы";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(37, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Продукты";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(38, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Категории";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 377);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.selectButton);
            this.Controls.Add(this.resList);
            this.Controls.Add(this.input);
            this.Controls.Add(this.categoriesList);
            this.Controls.Add(this.productsList);
            this.Name = "Form1";
            this.Text = "Data base reader";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox productsList;
        private ListBox categoriesList;
        private TextBox input;
        private ListBox resList;
        private Button selectButton;
        private ComboBox comboBox1;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}