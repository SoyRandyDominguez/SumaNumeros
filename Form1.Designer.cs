namespace SumaNumeros
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
            n1 = new TextBox();
            label1 = new Label();
            n2 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            res = new TextBox();
            btn1 = new Button();
            btn2 = new Button();
            SuspendLayout();
            // 
            // n1
            // 
            n1.Location = new Point(75, 196);
            n1.Name = "n1";
            n1.PlaceholderText = "Numero 1";
            n1.Size = new Size(160, 23);
            n1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 50F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(75, 9);
            label1.Name = "label1";
            label1.Size = new Size(481, 89);
            label1.TabIndex = 1;
            label1.Text = "Suma numeros";
            // 
            // n2
            // 
            n2.Location = new Point(357, 196);
            n2.Name = "n2";
            n2.PlaceholderText = "Numero 2";
            n2.Size = new Size(160, 23);
            n2.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 50F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(249, 154);
            label2.Name = "label2";
            label2.Size = new Size(84, 89);
            label2.TabIndex = 3;
            label2.Text = "+";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 50F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(23, 293);
            label3.Name = "label3";
            label3.Size = new Size(343, 89);
            label3.TabIndex = 5;
            label3.Text = "Resultado:";
            label3.Click += label3_Click;
            // 
            // res
            // 
            res.Location = new Point(385, 350);
            res.Name = "res";
            res.PlaceholderText = "Resultado";
            res.ReadOnly = true;
            res.Size = new Size(160, 23);
            res.TabIndex = 4;
            res.TextChanged += textBox3_TextChanged;
            // 
            // btn1
            // 
            btn1.Location = new Point(281, 433);
            btn1.Name = "btn1";
            btn1.Size = new Size(116, 51);
            btn1.TabIndex = 6;
            btn1.Text = "Sumar";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn1_Click;
            // 
            // btn2
            // 
            btn2.Location = new Point(413, 433);
            btn2.Name = "btn2";
            btn2.Size = new Size(125, 51);
            btn2.TabIndex = 7;
            btn2.Text = "Limpiar";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btn2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(615, 507);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(label3);
            Controls.Add(res);
            Controls.Add(label2);
            Controls.Add(n2);
            Controls.Add(label1);
            Controls.Add(n1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox n1;
        private Label label1;
        private TextBox n2;
        private Label label2;
        private Label label3;
        private TextBox res;
        private Button btn1;
        private Button btn2;
    }
}