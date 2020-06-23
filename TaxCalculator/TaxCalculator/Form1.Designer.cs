namespace TaxCalculator
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
            this.label1 = new System.Windows.Forms.Label();
            this.itemCostTextBox = new System.Windows.Forms.TextBox();
            this.calcBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.taxOutputBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.totalOutputBox = new System.Windows.Forms.TextBox();
            this.clearBtn = new System.Windows.Forms.Button();
            this.doneBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tipOutputBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter the cost (xx.xx in euros) of your items below:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // itemCostTextBox
            // 
            this.itemCostTextBox.Location = new System.Drawing.Point(170, 38);
            this.itemCostTextBox.Name = "itemCostTextBox";
            this.itemCostTextBox.Size = new System.Drawing.Size(55, 20);
            this.itemCostTextBox.TabIndex = 1;
            // 
            // calcBtn
            // 
            this.calcBtn.Location = new System.Drawing.Point(152, 82);
            this.calcBtn.Name = "calcBtn";
            this.calcBtn.Size = new System.Drawing.Size(88, 23);
            this.calcBtn.TabIndex = 2;
            this.calcBtn.Text = "Calculate Tax";
            this.calcBtn.UseVisualStyleBackColor = true;
            this.calcBtn.Click += new System.EventHandler(this.calcBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(167, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Total Cost:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(107, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "10% Sales Tax";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // taxOutputBox
            // 
            this.taxOutputBox.Location = new System.Drawing.Point(208, 169);
            this.taxOutputBox.Name = "taxOutputBox";
            this.taxOutputBox.Size = new System.Drawing.Size(56, 20);
            this.taxOutputBox.TabIndex = 5;
            this.taxOutputBox.TextChanged += new System.EventHandler(this.taxOutputBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(129, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Total Cost";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // totalOutputBox
            // 
            this.totalOutputBox.Location = new System.Drawing.Point(208, 223);
            this.totalOutputBox.Name = "totalOutputBox";
            this.totalOutputBox.Size = new System.Drawing.Size(56, 20);
            this.totalOutputBox.TabIndex = 7;
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(98, 278);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(75, 23);
            this.clearBtn.TabIndex = 8;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // doneBtn
            // 
            this.doneBtn.Location = new System.Drawing.Point(221, 278);
            this.doneBtn.Name = "doneBtn";
            this.doneBtn.Size = new System.Drawing.Size(75, 23);
            this.doneBtn.TabIndex = 9;
            this.doneBtn.Text = "Done";
            this.doneBtn.UseVisualStyleBackColor = true;
            this.doneBtn.Click += new System.EventHandler(this.doneBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(139, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "15% Tip";
            // 
            // tipOutputBox
            // 
            this.tipOutputBox.Location = new System.Drawing.Point(208, 195);
            this.tipOutputBox.Name = "tipOutputBox";
            this.tipOutputBox.Size = new System.Drawing.Size(56, 20);
            this.tipOutputBox.TabIndex = 11;
            this.tipOutputBox.TextChanged += new System.EventHandler(this.tipOutputBox_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 316);
            this.Controls.Add(this.tipOutputBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.doneBtn);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.totalOutputBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.taxOutputBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.calcBtn);
            this.Controls.Add(this.itemCostTextBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox itemCostTextBox;
        private System.Windows.Forms.Button calcBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox taxOutputBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox totalOutputBox;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button doneBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tipOutputBox;
    }
}

