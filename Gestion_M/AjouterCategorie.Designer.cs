﻿
namespace Gestion_M
{
    partial class AjouterCategorie
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
            this.Inp_Nom_Client = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.btn_enrejerstrer = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Nom :";
            // 
            // Inp_Nom_Client
            // 
            this.Inp_Nom_Client.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Inp_Nom_Client.DefaultText = "";
            this.Inp_Nom_Client.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Inp_Nom_Client.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Inp_Nom_Client.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Inp_Nom_Client.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Inp_Nom_Client.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Inp_Nom_Client.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Inp_Nom_Client.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Inp_Nom_Client.Location = new System.Drawing.Point(142, 69);
            this.Inp_Nom_Client.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Inp_Nom_Client.Name = "Inp_Nom_Client";
            this.Inp_Nom_Client.PasswordChar = '\0';
            this.Inp_Nom_Client.PlaceholderText = "";
            this.Inp_Nom_Client.SelectedText = "";
            this.Inp_Nom_Client.Size = new System.Drawing.Size(289, 36);
            this.Inp_Nom_Client.TabIndex = 11;
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderRadius = 2;
            this.guna2Button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(91)))), ((int)(((byte)(151)))));
            this.guna2Button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Image = global::Gestion_M.Properties.Resources.x_mark;
            this.guna2Button1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button1.Location = new System.Drawing.Point(142, 152);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(130, 31);
            this.guna2Button1.TabIndex = 14;
            this.guna2Button1.Text = " Annuler";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // btn_enrejerstrer
            // 
            this.btn_enrejerstrer.BorderRadius = 2;
            this.btn_enrejerstrer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_enrejerstrer.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_enrejerstrer.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_enrejerstrer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_enrejerstrer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_enrejerstrer.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(91)))), ((int)(((byte)(151)))));
            this.btn_enrejerstrer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btn_enrejerstrer.ForeColor = System.Drawing.Color.White;
            this.btn_enrejerstrer.Image = global::Gestion_M.Properties.Resources.telecharger;
            this.btn_enrejerstrer.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_enrejerstrer.Location = new System.Drawing.Point(301, 152);
            this.btn_enrejerstrer.Name = "btn_enrejerstrer";
            this.btn_enrejerstrer.Size = new System.Drawing.Size(130, 31);
            this.btn_enrejerstrer.TabIndex = 13;
            this.btn_enrejerstrer.Text = "Enregistrer";
            this.btn_enrejerstrer.Click += new System.EventHandler(this.guna2Button3_Click);
            // 
            // AjouterCategorie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(508, 240);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.btn_enrejerstrer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Inp_Nom_Client);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AjouterCategorie";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AjouterCategorie";
            this.Load += new System.EventHandler(this.AjouterCategorie_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox Inp_Nom_Client;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button btn_enrejerstrer;
    }
}