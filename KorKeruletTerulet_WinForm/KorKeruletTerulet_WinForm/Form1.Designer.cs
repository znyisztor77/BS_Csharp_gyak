namespace KorKeruletTerulet_WinForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_sugar = new System.Windows.Forms.TextBox();
            this.button_Szamol = new System.Windows.Forms.Button();
            this.label_kerulet = new System.Windows.Forms.Label();
            this.label_terulet = new System.Windows.Forms.Label();
            this.button_exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "A kör sugara";
            // 
            // textBox_sugar
            // 
            this.textBox_sugar.Location = new System.Drawing.Point(47, 74);
            this.textBox_sugar.Name = "textBox_sugar";
            this.textBox_sugar.Size = new System.Drawing.Size(146, 22);
            this.textBox_sugar.TabIndex = 1;
            // 
            // button_Szamol
            // 
            this.button_Szamol.Location = new System.Drawing.Point(47, 145);
            this.button_Szamol.Name = "button_Szamol";
            this.button_Szamol.Size = new System.Drawing.Size(75, 23);
            this.button_Szamol.TabIndex = 2;
            this.button_Szamol.Text = "Kiszámol";
            this.button_Szamol.UseVisualStyleBackColor = true;
            this.button_Szamol.Click += new System.EventHandler(this.button_Szamol_Click);
            // 
            // label_kerulet
            // 
            this.label_kerulet.AutoSize = true;
            this.label_kerulet.Location = new System.Drawing.Point(47, 193);
            this.label_kerulet.Name = "label_kerulet";
            this.label_kerulet.Size = new System.Drawing.Size(95, 16);
            this.label_kerulet.TabIndex = 3;
            this.label_kerulet.Text = "A kör kerülete: ";
            this.label_kerulet.Click += new System.EventHandler(this.label_kerulet_Click);
            // 
            // label_terulet
            // 
            this.label_terulet.AutoSize = true;
            this.label_terulet.Location = new System.Drawing.Point(47, 236);
            this.label_terulet.Name = "label_terulet";
            this.label_terulet.Size = new System.Drawing.Size(91, 16);
            this.label_terulet.TabIndex = 4;
            this.label_terulet.Text = "A kör területe: ";
            // 
            // button_exit
            // 
            this.button_exit.Location = new System.Drawing.Point(358, 291);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(75, 23);
            this.button_exit.TabIndex = 5;
            this.button_exit.Text = "Kilépés";
            this.button_exit.UseVisualStyleBackColor = true;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 450);
            this.Controls.Add(this.button_exit);
            this.Controls.Add(this.label_terulet);
            this.Controls.Add(this.label_kerulet);
            this.Controls.Add(this.button_Szamol);
            this.Controls.Add(this.textBox_sugar);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Kör kerület és terület számítás";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_sugar;
        private System.Windows.Forms.Button button_Szamol;
        private System.Windows.Forms.Label label_kerulet;
        private System.Windows.Forms.Label label_terulet;
        private System.Windows.Forms.Button button_exit;
    }
}

