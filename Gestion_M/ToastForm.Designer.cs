
namespace Gestion_M
{
    partial class ToastForm
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbType = new System.Windows.Forms.Label();
            this.lbMessage = new System.Windows.Forms.Label();
            this.picicon = new System.Windows.Forms.PictureBox();
            this.Toastimer = new System.Windows.Forms.Timer(this.components);
            this.TostHide = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picicon)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(155)))), ((int)(((byte)(53)))));
            this.panel1.Location = new System.Drawing.Point(-3, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(11, 80);
            this.panel1.TabIndex = 0;
            // 
            // lbType
            // 
            this.lbType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbType.Location = new System.Drawing.Point(96, 13);
            this.lbType.Name = "lbType";
            this.lbType.Size = new System.Drawing.Size(100, 23);
            this.lbType.TabIndex = 4;
            this.lbType.Text = "Type";
            this.lbType.Click += new System.EventHandler(this.lbType_Click);
            // 
            // lbMessage
            // 
            this.lbMessage.AutoSize = true;
            this.lbMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMessage.Location = new System.Drawing.Point(97, 44);
            this.lbMessage.Name = "lbMessage";
            this.lbMessage.Size = new System.Drawing.Size(82, 22);
            this.lbMessage.TabIndex = 3;
            this.lbMessage.Text = "Message";
            // 
            // picicon
            // 
            this.picicon.Image = global::Gestion_M.Properties.Resources.checked__1_;
            this.picicon.Location = new System.Drawing.Point(15, 13);
            this.picicon.Name = "picicon";
            this.picicon.Size = new System.Drawing.Size(51, 53);
            this.picicon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picicon.TabIndex = 1;
            this.picicon.TabStop = false;
            // 
            // Toastimer
            // 
            this.Toastimer.Interval = 10;
            this.Toastimer.Tick += new System.EventHandler(this.Toastimer_Tick);
            // 
            // TostHide
            // 
            this.TostHide.Interval = 10;
            this.TostHide.Tick += new System.EventHandler(this.TostHide_Tick);
            // 
            // ToastForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 78);
            this.Controls.Add(this.picicon);
            this.Controls.Add(this.lbMessage);
            this.Controls.Add(this.lbType);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ToastForm";
            this.Text = "ToastForm";
            this.Load += new System.EventHandler(this.ToastForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picicon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picicon;
        private System.Windows.Forms.Label lbType;
        private System.Windows.Forms.Label lbMessage;
    }
}