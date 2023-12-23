namespace Czigleczki_LogikaiMuveletek
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
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.button_Alapotvaltas = new System.Windows.Forms.Button();
            this.button_ES = new System.Windows.Forms.Button();
            this.button_Vagy = new System.Windows.Forms.Button();
            this.button_exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(26, 25);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(95, 20);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(26, 52);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(95, 20);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "checkBox2";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // button_Alapotvaltas
            // 
            this.button_Alapotvaltas.Location = new System.Drawing.Point(168, 25);
            this.button_Alapotvaltas.Name = "button_Alapotvaltas";
            this.button_Alapotvaltas.Size = new System.Drawing.Size(75, 47);
            this.button_Alapotvaltas.TabIndex = 2;
            this.button_Alapotvaltas.Text = "Állapot váltás";
            this.button_Alapotvaltas.UseVisualStyleBackColor = true;
            this.button_Alapotvaltas.Click += new System.EventHandler(this.button_Alapotvaltas_Click);
            // 
            // button_ES
            // 
            this.button_ES.Location = new System.Drawing.Point(26, 95);
            this.button_ES.Name = "button_ES";
            this.button_ES.Size = new System.Drawing.Size(217, 23);
            this.button_ES.TabIndex = 3;
            this.button_ES.Text = "Logikai ÉS művelet";
            this.button_ES.UseVisualStyleBackColor = true;
            this.button_ES.Click += new System.EventHandler(this.button_ES_Click);
            // 
            // button_Vagy
            // 
            this.button_Vagy.Location = new System.Drawing.Point(26, 147);
            this.button_Vagy.Name = "button_Vagy";
            this.button_Vagy.Size = new System.Drawing.Size(217, 23);
            this.button_Vagy.TabIndex = 4;
            this.button_Vagy.Text = "Logikai VAGY művelet";
            this.button_Vagy.UseVisualStyleBackColor = true;
            this.button_Vagy.Click += new System.EventHandler(this.button_Vagy_Click);
            // 
            // button_exit
            // 
            this.button_exit.Location = new System.Drawing.Point(97, 191);
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
            this.ClientSize = new System.Drawing.Size(262, 239);
            this.Controls.Add(this.button_exit);
            this.Controls.Add(this.button_Vagy);
            this.Controls.Add(this.button_ES);
            this.Controls.Add(this.button_Alapotvaltas);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Logikai műveletek";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Button button_Alapotvaltas;
        private System.Windows.Forms.Button button_ES;
        private System.Windows.Forms.Button button_Vagy;
        private System.Windows.Forms.Button button_exit;
    }
}

