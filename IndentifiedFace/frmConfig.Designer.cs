
namespace IndentifiedFace
{
    partial class frmConfig
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_exit = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtNumberWork = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnResetWork = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(26, 49);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(115, 1);
            this.panel3.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 22);
            this.label3.TabIndex = 15;
            this.label3.Text = "Config";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(120, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(179, 21);
            this.label4.TabIndex = 15;
            this.label4.Text = "Config Number Work :";
            // 
            // btn_exit
            // 
            this.btn_exit.FlatAppearance.BorderSize = 0;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.Image = global::IndentifiedFace.Properties.Resources.x_30px1;
            this.btn_exit.Location = new System.Drawing.Point(531, 1);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(68, 36);
            this.btn_exit.TabIndex = 14;
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Location = new System.Drawing.Point(-1, 198);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(600, 1);
            this.panel4.TabIndex = 16;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // txtNumberWork
            // 
            this.txtNumberWork.Location = new System.Drawing.Point(305, 72);
            this.txtNumberWork.Name = "txtNumberWork";
            this.txtNumberWork.Size = new System.Drawing.Size(141, 25);
            this.txtNumberWork.TabIndex = 20;
            // 
            // btnSubmit
            // 
            this.btnSubmit.FlatAppearance.BorderSize = 0;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Image = global::IndentifiedFace.Properties.Resources.find_user_male_25px;
            this.btnSubmit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubmit.Location = new System.Drawing.Point(63, 128);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(204, 36);
            this.btnSubmit.TabIndex = 21;
            this.btnSubmit.Text = "     Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnResetWork
            // 
            this.btnResetWork.FlatAppearance.BorderSize = 0;
            this.btnResetWork.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetWork.Image = global::IndentifiedFace.Properties.Resources.reset_40px;
            this.btnResetWork.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnResetWork.Location = new System.Drawing.Point(339, 128);
            this.btnResetWork.Name = "btnResetWork";
            this.btnResetWork.Size = new System.Drawing.Size(204, 36);
            this.btnResetWork.TabIndex = 22;
            this.btnResetWork.Text = "     Reset Work";
            this.btnResetWork.UseVisualStyleBackColor = true;
            this.btnResetWork.Click += new System.EventHandler(this.btnResetWork_Click);
            // 
            // frmConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 209);
            this.Controls.Add(this.btnResetWork);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtNumberWork);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_exit);
            this.Font = new System.Drawing.Font("Times New Roman", 11.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmConfig";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thống kê";
            this.Load += new System.EventHandler(this.frmConfig_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtNumberWork;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnResetWork;
    }
}