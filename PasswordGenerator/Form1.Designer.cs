namespace PasswordGenerator
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txt_ResultPassword = new System.Windows.Forms.RichTextBox();
            this.checkBox_Capital = new System.Windows.Forms.CheckBox();
            this.checkBox_Symbols = new System.Windows.Forms.CheckBox();
            this.txt_Length = new System.Windows.Forms.TextBox();
            this.UpDown = new System.Windows.Forms.NumericUpDown();
            this.btn_Create = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.UpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_ResultPassword
            // 
            this.txt_ResultPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_ResultPassword.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txt_ResultPassword.Location = new System.Drawing.Point(12, 12);
            this.txt_ResultPassword.Name = "txt_ResultPassword";
            this.txt_ResultPassword.ReadOnly = true;
            this.txt_ResultPassword.Size = new System.Drawing.Size(320, 40);
            this.txt_ResultPassword.TabIndex = 0;
            this.txt_ResultPassword.Text = "";
            // 
            // checkBox_Capital
            // 
            this.checkBox_Capital.BackColor = System.Drawing.Color.Transparent;
            this.checkBox_Capital.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.checkBox_Capital.ForeColor = System.Drawing.Color.White;
            this.checkBox_Capital.Location = new System.Drawing.Point(12, 138);
            this.checkBox_Capital.Name = "checkBox_Capital";
            this.checkBox_Capital.Size = new System.Drawing.Size(200, 50);
            this.checkBox_Capital.TabIndex = 1;
            this.checkBox_Capital.Text = "Capital Letters";
            this.checkBox_Capital.UseVisualStyleBackColor = false;
            this.checkBox_Capital.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox_Symbols
            // 
            this.checkBox_Symbols.BackColor = System.Drawing.Color.Transparent;
            this.checkBox_Symbols.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.checkBox_Symbols.ForeColor = System.Drawing.Color.White;
            this.checkBox_Symbols.Location = new System.Drawing.Point(12, 203);
            this.checkBox_Symbols.Name = "checkBox_Symbols";
            this.checkBox_Symbols.Size = new System.Drawing.Size(200, 50);
            this.checkBox_Symbols.TabIndex = 2;
            this.checkBox_Symbols.Text = "Symbols";
            this.checkBox_Symbols.UseVisualStyleBackColor = false;
            // 
            // txt_Length
            // 
            this.txt_Length.BackColor = System.Drawing.Color.Black;
            this.txt_Length.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Length.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txt_Length.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txt_Length.ForeColor = System.Drawing.Color.White;
            this.txt_Length.Location = new System.Drawing.Point(12, 87);
            this.txt_Length.Name = "txt_Length";
            this.txt_Length.ReadOnly = true;
            this.txt_Length.Size = new System.Drawing.Size(80, 25);
            this.txt_Length.TabIndex = 3;
            this.txt_Length.Text = "Length:";
            this.txt_Length.TextChanged += new System.EventHandler(this.txt_Length_TextChanged);
            // 
            // UpDown
            // 
            this.UpDown.BackColor = System.Drawing.Color.Black;
            this.UpDown.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UpDown.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.UpDown.ForeColor = System.Drawing.Color.White;
            this.UpDown.Location = new System.Drawing.Point(282, 85);
            this.UpDown.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.UpDown.Minimum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.UpDown.Name = "UpDown";
            this.UpDown.Size = new System.Drawing.Size(50, 28);
            this.UpDown.TabIndex = 4;
            this.UpDown.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // btn_Create
            // 
            this.btn_Create.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btn_Create.Location = new System.Drawing.Point(12, 299);
            this.btn_Create.Name = "btn_Create";
            this.btn_Create.Size = new System.Drawing.Size(320, 50);
            this.btn_Create.TabIndex = 5;
            this.btn_Create.Text = "Create Password!";
            this.btn_Create.UseVisualStyleBackColor = true;
            this.btn_Create.Click += new System.EventHandler(this.btn_Create_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(684, 361);
            this.Controls.Add(this.btn_Create);
            this.Controls.Add(this.UpDown);
            this.Controls.Add(this.txt_Length);
            this.Controls.Add(this.checkBox_Symbols);
            this.Controls.Add(this.checkBox_Capital);
            this.Controls.Add(this.txt_ResultPassword);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Password Generator";
            ((System.ComponentModel.ISupportInitialize)(this.UpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txt_ResultPassword;
        private System.Windows.Forms.CheckBox checkBox_Capital;
        private System.Windows.Forms.CheckBox checkBox_Symbols;
        private System.Windows.Forms.TextBox txt_Length;
        private System.Windows.Forms.NumericUpDown UpDown;
        private System.Windows.Forms.Button btn_Create;
    }
}

