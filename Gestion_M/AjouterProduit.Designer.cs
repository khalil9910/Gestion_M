
namespace Gestion_M
{
    partial class AjouterProduit
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
            this.Cmd_Client = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cmd_categorie = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.text_marque = new Guna.UI2.WinForms.Guna2TextBox();
            this.text_prix = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.text_details = new System.Windows.Forms.RichTextBox();
            this.guna2HtmlLabel6 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.text_date = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.guna2HtmlLabel7 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.text_type = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.Enregistrer_produit = new Guna.UI2.WinForms.Guna2Button();
            this.modofierBtn = new Guna.UI2.WinForms.Guna2Button();
            this.Cmd_status = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.SuspendLayout();
            // 
            // Cmd_Client
            // 
            this.Cmd_Client.BackColor = System.Drawing.Color.Transparent;
            this.Cmd_Client.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.Cmd_Client.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmd_Client.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Cmd_Client.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Cmd_Client.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Cmd_Client.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.Cmd_Client.ItemHeight = 30;
            this.Cmd_Client.Location = new System.Drawing.Point(217, 23);
            this.Cmd_Client.Name = "Cmd_Client";
            this.Cmd_Client.Size = new System.Drawing.Size(302, 36);
            this.Cmd_Client.TabIndex = 0;
            this.Cmd_Client.SelectedIndexChanged += new System.EventHandler(this.guna2ComboBox1_SelectedIndexChanged);
            // 
            // cmd_categorie
            // 
            this.cmd_categorie.BackColor = System.Drawing.Color.Transparent;
            this.cmd_categorie.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmd_categorie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmd_categorie.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmd_categorie.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmd_categorie.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmd_categorie.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmd_categorie.ItemHeight = 30;
            this.cmd_categorie.Location = new System.Drawing.Point(217, 94);
            this.cmd_categorie.Name = "cmd_categorie";
            this.cmd_categorie.Size = new System.Drawing.Size(302, 36);
            this.cmd_categorie.TabIndex = 1;
            this.cmd_categorie.SelectedIndexChanged += new System.EventHandler(this.guna2ComboBox2_SelectedIndexChanged);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(85, 105);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(54, 15);
            this.guna2HtmlLabel1.TabIndex = 4;
            this.guna2HtmlLabel1.Text = "Categorie :";
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(90, 168);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(45, 15);
            this.guna2HtmlLabel2.TabIndex = 5;
            this.guna2HtmlLabel2.Text = "Marque :";
            // 
            // text_marque
            // 
            this.text_marque.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_marque.DefaultText = "";
            this.text_marque.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.text_marque.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.text_marque.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.text_marque.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.text_marque.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.text_marque.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.text_marque.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.text_marque.Location = new System.Drawing.Point(217, 157);
            this.text_marque.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.text_marque.Name = "text_marque";
            this.text_marque.PasswordChar = '\0';
            this.text_marque.PlaceholderText = "";
            this.text_marque.SelectedText = "";
            this.text_marque.Size = new System.Drawing.Size(302, 36);
            this.text_marque.TabIndex = 7;
            // 
            // text_prix
            // 
            this.text_prix.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_prix.DefaultText = "";
            this.text_prix.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.text_prix.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.text_prix.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.text_prix.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.text_prix.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.text_prix.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.text_prix.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.text_prix.Location = new System.Drawing.Point(217, 422);
            this.text_prix.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.text_prix.Name = "text_prix";
            this.text_prix.PasswordChar = '\0';
            this.text_prix.PlaceholderText = "";
            this.text_prix.SelectedText = "";
            this.text_prix.Size = new System.Drawing.Size(302, 36);
            this.text_prix.TabIndex = 8;
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(68, 357);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(88, 15);
            this.guna2HtmlLabel4.TabIndex = 9;
            this.guna2HtmlLabel4.Text = "Type de problem :";
            // 
            // guna2HtmlLabel5
            // 
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(92, 247);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(41, 15);
            this.guna2HtmlLabel5.TabIndex = 10;
            this.guna2HtmlLabel5.Text = "Details :";
            // 
            // text_details
            // 
            this.text_details.Location = new System.Drawing.Point(217, 214);
            this.text_details.Name = "text_details";
            this.text_details.Size = new System.Drawing.Size(302, 93);
            this.text_details.TabIndex = 11;
            this.text_details.Text = "";
            // 
            // guna2HtmlLabel6
            // 
            this.guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel6.Location = new System.Drawing.Point(99, 433);
            this.guna2HtmlLabel6.Name = "guna2HtmlLabel6";
            this.guna2HtmlLabel6.Size = new System.Drawing.Size(26, 15);
            this.guna2HtmlLabel6.TabIndex = 12;
            this.guna2HtmlLabel6.Text = "Prix :";
            // 
            // text_date
            // 
            this.text_date.Checked = true;
            this.text_date.FillColor = System.Drawing.Color.White;
            this.text_date.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.text_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.text_date.Location = new System.Drawing.Point(217, 489);
            this.text_date.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.text_date.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.text_date.Name = "text_date";
            this.text_date.Size = new System.Drawing.Size(302, 36);
            this.text_date.TabIndex = 13;
            this.text_date.Value = new System.DateTime(2024, 2, 4, 14, 53, 1, 470);
            // 
            // guna2HtmlLabel7
            // 
            this.guna2HtmlLabel7.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel7.Location = new System.Drawing.Point(88, 500);
            this.guna2HtmlLabel7.Name = "guna2HtmlLabel7";
            this.guna2HtmlLabel7.Size = new System.Drawing.Size(49, 15);
            this.guna2HtmlLabel7.TabIndex = 14;
            this.guna2HtmlLabel7.Text = "Date Fin :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Client :";
            // 
            // text_type
            // 
            this.text_type.BackColor = System.Drawing.Color.Transparent;
            this.text_type.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.text_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.text_type.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.text_type.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.text_type.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.text_type.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.text_type.ItemHeight = 30;
            this.text_type.Items.AddRange(new object[] {
            "Matirial",
            "Logiciel"});
            this.text_type.Location = new System.Drawing.Point(217, 347);
            this.text_type.Name = "text_type";
            this.text_type.Size = new System.Drawing.Size(302, 36);
            this.text_type.TabIndex = 18;
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
            this.guna2Button1.Location = new System.Drawing.Point(217, 602);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(130, 31);
            this.guna2Button1.TabIndex = 16;
            this.guna2Button1.Text = " Annuler";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // Enregistrer_produit
            // 
            this.Enregistrer_produit.BorderRadius = 2;
            this.Enregistrer_produit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Enregistrer_produit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Enregistrer_produit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Enregistrer_produit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Enregistrer_produit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Enregistrer_produit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(91)))), ((int)(((byte)(151)))));
            this.Enregistrer_produit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.Enregistrer_produit.ForeColor = System.Drawing.Color.White;
            this.Enregistrer_produit.Image = global::Gestion_M.Properties.Resources.telecharger;
            this.Enregistrer_produit.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Enregistrer_produit.Location = new System.Drawing.Point(389, 602);
            this.Enregistrer_produit.Name = "Enregistrer_produit";
            this.Enregistrer_produit.Size = new System.Drawing.Size(130, 31);
            this.Enregistrer_produit.TabIndex = 15;
            this.Enregistrer_produit.Text = "Enregistrer";
            this.Enregistrer_produit.Click += new System.EventHandler(this.Enregistrer_produit_Click);
            // 
            // modofierBtn
            // 
            this.modofierBtn.BorderRadius = 2;
            this.modofierBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.modofierBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.modofierBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.modofierBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.modofierBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.modofierBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(91)))), ((int)(((byte)(151)))));
            this.modofierBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.modofierBtn.ForeColor = System.Drawing.Color.White;
            this.modofierBtn.Image = global::Gestion_M.Properties.Resources.telecharger;
            this.modofierBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.modofierBtn.Location = new System.Drawing.Point(57, 602);
            this.modofierBtn.Name = "modofierBtn";
            this.modofierBtn.Size = new System.Drawing.Size(130, 31);
            this.modofierBtn.TabIndex = 19;
            this.modofierBtn.Text = "Enregistrer";
            this.modofierBtn.Click += new System.EventHandler(this.modofierBtn_Click);
            // 
            // Cmd_status
            // 
            this.Cmd_status.BackColor = System.Drawing.Color.Transparent;
            this.Cmd_status.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.Cmd_status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmd_status.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Cmd_status.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Cmd_status.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Cmd_status.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.Cmd_status.ItemHeight = 30;
            this.Cmd_status.Items.AddRange(new object[] {
            "Matirial",
            "Logiciel"});
            this.Cmd_status.Location = new System.Drawing.Point(217, 550);
            this.Cmd_status.Name = "Cmd_status";
            this.Cmd_status.Size = new System.Drawing.Size(302, 36);
            this.Cmd_status.TabIndex = 21;
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(68, 560);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(39, 15);
            this.guna2HtmlLabel3.TabIndex = 20;
            this.guna2HtmlLabel3.Text = "Status :";
            // 
            // AjouterProduit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(598, 634);
            this.Controls.Add(this.Cmd_status);
            this.Controls.Add(this.guna2HtmlLabel3);
            this.Controls.Add(this.modofierBtn);
            this.Controls.Add(this.text_type);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.Enregistrer_produit);
            this.Controls.Add(this.guna2HtmlLabel7);
            this.Controls.Add(this.text_date);
            this.Controls.Add(this.guna2HtmlLabel6);
            this.Controls.Add(this.text_details);
            this.Controls.Add(this.guna2HtmlLabel5);
            this.Controls.Add(this.guna2HtmlLabel4);
            this.Controls.Add(this.text_prix);
            this.Controls.Add(this.text_marque);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.cmd_categorie);
            this.Controls.Add(this.Cmd_Client);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AjouterProduit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AjouterProduit";
            this.Load += new System.EventHandler(this.AjouterProduit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ComboBox Cmd_Client;
        private Guna.UI2.WinForms.Guna2ComboBox cmd_categorie;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2TextBox text_marque;
        private Guna.UI2.WinForms.Guna2TextBox text_prix;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private System.Windows.Forms.RichTextBox text_details;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel6;
        private Guna.UI2.WinForms.Guna2DateTimePicker text_date;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel7;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button Enregistrer_produit;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ComboBox text_type;
        private Guna.UI2.WinForms.Guna2Button modofierBtn;
        private Guna.UI2.WinForms.Guna2ComboBox Cmd_status;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
    }
}