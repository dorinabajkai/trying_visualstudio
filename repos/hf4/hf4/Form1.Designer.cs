namespace hf4
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
            this.bBike1 = new System.Windows.Forms.Button();
            this.pTarget = new System.Windows.Forms.Panel();
            this.bStart = new System.Windows.Forms.Button();
            this.pStart = new System.Windows.Forms.Panel();
            this.bBike2 = new System.Windows.Forms.Button();
            this.bBike3 = new System.Windows.Forms.Button();
            this.bStep1 = new System.Windows.Forms.Button();
            this.pRest = new System.Windows.Forms.Panel();
            this.bStep2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bBike1
            // 
            this.bBike1.Font = new System.Drawing.Font("Webdings", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.bBike1.Location = new System.Drawing.Point(12, 124);
            this.bBike1.Name = "bBike1";
            this.bBike1.Size = new System.Drawing.Size(76, 54);
            this.bBike1.TabIndex = 0;
            this.bBike1.Text = "b";
            this.bBike1.UseVisualStyleBackColor = true;
            // 
            // pTarget
            // 
            this.pTarget.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.pTarget.Location = new System.Drawing.Point(504, 12);
            this.pTarget.Name = "pTarget";
            this.pTarget.Size = new System.Drawing.Size(68, 275);
            this.pTarget.TabIndex = 1;
            // 
            // bStart
            // 
            this.bStart.Location = new System.Drawing.Point(12, 294);
            this.bStart.Name = "bStart";
            this.bStart.Size = new System.Drawing.Size(76, 23);
            this.bStart.TabIndex = 2;
            this.bStart.Text = "Start";
            this.bStart.UseVisualStyleBackColor = true;
            this.bStart.Click += new System.EventHandler(this.bStart_Click);
            // 
            // pStart
            // 
            this.pStart.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pStart.Location = new System.Drawing.Point(135, 12);
            this.pStart.Name = "pStart";
            this.pStart.Size = new System.Drawing.Size(68, 275);
            this.pStart.TabIndex = 2;
            // 
            // bBike2
            // 
            this.bBike2.Font = new System.Drawing.Font("Webdings", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.bBike2.Location = new System.Drawing.Point(12, 38);
            this.bBike2.Name = "bBike2";
            this.bBike2.Size = new System.Drawing.Size(76, 54);
            this.bBike2.TabIndex = 3;
            this.bBike2.Text = "b";
            this.bBike2.UseVisualStyleBackColor = true;
            this.bBike2.Click += new System.EventHandler(this.bBike2_Click);
            // 
            // bBike3
            // 
            this.bBike3.Font = new System.Drawing.Font("Webdings", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.bBike3.Location = new System.Drawing.Point(12, 213);
            this.bBike3.Name = "bBike3";
            this.bBike3.Size = new System.Drawing.Size(76, 54);
            this.bBike3.TabIndex = 4;
            this.bBike3.Text = "b";
            this.bBike3.UseVisualStyleBackColor = true;
            // 
            // bStep1
            // 
            this.bStep1.Location = new System.Drawing.Point(135, 293);
            this.bStep1.Name = "bStep1";
            this.bStep1.Size = new System.Drawing.Size(68, 23);
            this.bStep1.TabIndex = 5;
            this.bStep1.Text = "Step1";
            this.bStep1.UseVisualStyleBackColor = true;
            this.bStep1.Click += new System.EventHandler(this.bStep1_Click);
            // 
            // pRest
            // 
            this.pRest.BackColor = System.Drawing.Color.Aqua;
            this.pRest.Location = new System.Drawing.Point(318, 12);
            this.pRest.Name = "pRest";
            this.pRest.Size = new System.Drawing.Size(68, 275);
            this.pRest.TabIndex = 3;
            // 
            // bStep2
            // 
            this.bStep2.Location = new System.Drawing.Point(318, 293);
            this.bStep2.Name = "bStep2";
            this.bStep2.Size = new System.Drawing.Size(68, 23);
            this.bStep2.TabIndex = 6;
            this.bStep2.Text = "Step2";
            this.bStep2.UseVisualStyleBackColor = true;
            this.bStep2.Click += new System.EventHandler(this.bStep2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 318);
            this.Controls.Add(this.bStep2);
            this.Controls.Add(this.bBike1);
            this.Controls.Add(this.bStep1);
            this.Controls.Add(this.bBike3);
            this.Controls.Add(this.bBike2);
            this.Controls.Add(this.pStart);
            this.Controls.Add(this.bStart);
            this.Controls.Add(this.pTarget);
            this.Controls.Add(this.pRest);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bBike1;
        private System.Windows.Forms.Panel pTarget;
        private System.Windows.Forms.Button bStart;
        private System.Windows.Forms.Panel pStart;
        private System.Windows.Forms.Button bBike2;
        private System.Windows.Forms.Button bBike3;
        private System.Windows.Forms.Button bStep1;
        private System.Windows.Forms.Panel pRest;
        private System.Windows.Forms.Button bStep2;
    }
}

