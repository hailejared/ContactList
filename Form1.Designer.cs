namespace ContactList
{
    partial class fromContactList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fromContactList));
            this.labelFirstName = new System.Windows.Forms.Label();
            this.labelLastName = new System.Windows.Forms.Label();
            this.labelPhone = new System.Windows.Forms.Label();
            this.textboxFirstName = new System.Windows.Forms.TextBox();
            this.textboxLastName = new System.Windows.Forms.TextBox();
            this.textboxPhone = new System.Windows.Forms.TextBox();
            this.buttonAddContact = new System.Windows.Forms.Button();
            this.listboxContacts = new System.Windows.Forms.ListBox();
            this.buttonSortList = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFirstName.Location = new System.Drawing.Point(41, 61);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(76, 16);
            this.labelFirstName.TabIndex = 0;
            this.labelFirstName.Text = "First Name:";
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLastName.Location = new System.Drawing.Point(41, 116);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(76, 16);
            this.labelLastName.TabIndex = 1;
            this.labelLastName.Text = "Last Name:";
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPhone.Location = new System.Drawing.Point(41, 171);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(50, 16);
            this.labelPhone.TabIndex = 2;
            this.labelPhone.Text = "Phone:";
            // 
            // textboxFirstName
            // 
            this.textboxFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxFirstName.Location = new System.Drawing.Point(156, 58);
            this.textboxFirstName.Name = "textboxFirstName";
            this.textboxFirstName.Size = new System.Drawing.Size(100, 22);
            this.textboxFirstName.TabIndex = 3;
            // 
            // textboxLastName
            // 
            this.textboxLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxLastName.Location = new System.Drawing.Point(156, 113);
            this.textboxLastName.Name = "textboxLastName";
            this.textboxLastName.Size = new System.Drawing.Size(100, 22);
            this.textboxLastName.TabIndex = 4;
            // 
            // textboxPhone
            // 
            this.textboxPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxPhone.Location = new System.Drawing.Point(156, 168);
            this.textboxPhone.Name = "textboxPhone";
            this.textboxPhone.Size = new System.Drawing.Size(100, 22);
            this.textboxPhone.TabIndex = 5;
            // 
            // buttonAddContact
            // 
            this.buttonAddContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddContact.Location = new System.Drawing.Point(156, 229);
            this.buttonAddContact.Name = "buttonAddContact";
            this.buttonAddContact.Size = new System.Drawing.Size(100, 35);
            this.buttonAddContact.TabIndex = 6;
            this.buttonAddContact.Text = "Add Contact";
            this.buttonAddContact.UseVisualStyleBackColor = true;
            this.buttonAddContact.Click += new System.EventHandler(this.buttonAddContact_Click);
            // 
            // listboxContacts
            // 
            this.listboxContacts.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listboxContacts.FormattingEnabled = true;
            this.listboxContacts.ItemHeight = 16;
            this.listboxContacts.Location = new System.Drawing.Point(343, 61);
            this.listboxContacts.Name = "listboxContacts";
            this.listboxContacts.Size = new System.Drawing.Size(253, 196);
            this.listboxContacts.TabIndex = 7;
            // 
            // buttonSortList
            // 
            this.buttonSortList.Location = new System.Drawing.Point(496, 287);
            this.buttonSortList.Name = "buttonSortList";
            this.buttonSortList.Size = new System.Drawing.Size(100, 35);
            this.buttonSortList.TabIndex = 8;
            this.buttonSortList.Text = "Sort List";
            this.buttonSortList.UseVisualStyleBackColor = true;
            this.buttonSortList.Click += new System.EventHandler(this.buttonSortList_Click);
            // 
            // fromContactList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 350);
            this.Controls.Add(this.buttonSortList);
            this.Controls.Add(this.listboxContacts);
            this.Controls.Add(this.buttonAddContact);
            this.Controls.Add(this.textboxPhone);
            this.Controls.Add(this.textboxLastName);
            this.Controls.Add(this.textboxFirstName);
            this.Controls.Add(this.labelPhone);
            this.Controls.Add(this.labelLastName);
            this.Controls.Add(this.labelFirstName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fromContactList";
            this.Text = "Contact List";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.TextBox textboxFirstName;
        private System.Windows.Forms.TextBox textboxLastName;
        private System.Windows.Forms.TextBox textboxPhone;
        private System.Windows.Forms.Button buttonAddContact;
        private System.Windows.Forms.ListBox listboxContacts;
        private System.Windows.Forms.Button buttonSortList;
    }
}

