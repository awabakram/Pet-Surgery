
namespace PetSurgery
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
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnInsertCustomer = new System.Windows.Forms.Button();
            this.txtbxForename = new System.Windows.Forms.TextBox();
            this.txtbxSurname = new System.Windows.Forms.TextBox();
            this.txtbxTelephoneNumber = new System.Windows.Forms.TextBox();
            this.lblForename = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblTelephoneNumber = new System.Windows.Forms.Label();
            this.btnImport = new System.Windows.Forms.Button();
            this.lblRecordsImported = new System.Windows.Forms.Label();
            this.btnDeleteData = new System.Windows.Forms.Button();
            this.txtbxForename2 = new System.Windows.Forms.TextBox();
            this.txtbxSurname2 = new System.Windows.Forms.TextBox();
            this.lblRecordsDeleted = new System.Windows.Forms.Label();
            this.lblForename2 = new System.Windows.Forms.Label();
            this.lblSurname2 = new System.Windows.Forms.Label();
            this.btnQuery = new System.Windows.Forms.Button();
            this.lblQuery = new System.Windows.Forms.Label();
            this.lblResultCount = new System.Windows.Forms.Label();
            this.txtbxSelect = new System.Windows.Forms.TextBox();
            this.lstboxQueryResults = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(8, 8);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(95, 46);
            this.btnConnect.TabIndex = 0;
            this.btnConnect.Text = "Test database connection";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnInsertCustomer
            // 
            this.btnInsertCustomer.Location = new System.Drawing.Point(8, 65);
            this.btnInsertCustomer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnInsertCustomer.Name = "btnInsertCustomer";
            this.btnInsertCustomer.Size = new System.Drawing.Size(95, 38);
            this.btnInsertCustomer.TabIndex = 1;
            this.btnInsertCustomer.Text = "Insert Customer";
            this.btnInsertCustomer.UseVisualStyleBackColor = true;
            this.btnInsertCustomer.Click += new System.EventHandler(this.btnInsertCustomer_Click);
            // 
            // txtbxForename
            // 
            this.txtbxForename.Location = new System.Drawing.Point(108, 83);
            this.txtbxForename.Name = "txtbxForename";
            this.txtbxForename.Size = new System.Drawing.Size(100, 20);
            this.txtbxForename.TabIndex = 2;
            // 
            // txtbxSurname
            // 
            this.txtbxSurname.Location = new System.Drawing.Point(214, 83);
            this.txtbxSurname.Name = "txtbxSurname";
            this.txtbxSurname.Size = new System.Drawing.Size(100, 20);
            this.txtbxSurname.TabIndex = 3;
            // 
            // txtbxTelephoneNumber
            // 
            this.txtbxTelephoneNumber.Location = new System.Drawing.Point(320, 83);
            this.txtbxTelephoneNumber.Name = "txtbxTelephoneNumber";
            this.txtbxTelephoneNumber.Size = new System.Drawing.Size(100, 20);
            this.txtbxTelephoneNumber.TabIndex = 4;
            // 
            // lblForename
            // 
            this.lblForename.AutoSize = true;
            this.lblForename.Location = new System.Drawing.Point(105, 65);
            this.lblForename.Name = "lblForename";
            this.lblForename.Size = new System.Drawing.Size(54, 13);
            this.lblForename.TabIndex = 5;
            this.lblForename.Text = "Forename";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(211, 65);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(49, 13);
            this.lblSurname.TabIndex = 6;
            this.lblSurname.Text = "Surname";
            // 
            // lblTelephoneNumber
            // 
            this.lblTelephoneNumber.AutoSize = true;
            this.lblTelephoneNumber.Location = new System.Drawing.Point(317, 65);
            this.lblTelephoneNumber.Name = "lblTelephoneNumber";
            this.lblTelephoneNumber.Size = new System.Drawing.Size(98, 13);
            this.lblTelephoneNumber.TabIndex = 7;
            this.lblTelephoneNumber.Text = "Telephone Number";
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(8, 108);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(95, 38);
            this.btnImport.TabIndex = 8;
            this.btnImport.Text = "Import Data";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // lblRecordsImported
            // 
            this.lblRecordsImported.AutoSize = true;
            this.lblRecordsImported.Location = new System.Drawing.Point(105, 121);
            this.lblRecordsImported.Name = "lblRecordsImported";
            this.lblRecordsImported.Size = new System.Drawing.Size(102, 13);
            this.lblRecordsImported.TabIndex = 9;
            this.lblRecordsImported.Text = "Records imported: 0";
            // 
            // btnDeleteData
            // 
            this.btnDeleteData.Location = new System.Drawing.Point(8, 160);
            this.btnDeleteData.Name = "btnDeleteData";
            this.btnDeleteData.Size = new System.Drawing.Size(95, 38);
            this.btnDeleteData.TabIndex = 10;
            this.btnDeleteData.Text = "Delete Data";
            this.btnDeleteData.UseVisualStyleBackColor = true;
            this.btnDeleteData.Click += new System.EventHandler(this.btnDeleteData_Click);
            // 
            // txtbxForename2
            // 
            this.txtbxForename2.Location = new System.Drawing.Point(109, 178);
            this.txtbxForename2.Name = "txtbxForename2";
            this.txtbxForename2.Size = new System.Drawing.Size(99, 20);
            this.txtbxForename2.TabIndex = 11;
            // 
            // txtbxSurname2
            // 
            this.txtbxSurname2.Location = new System.Drawing.Point(214, 178);
            this.txtbxSurname2.Name = "txtbxSurname2";
            this.txtbxSurname2.Size = new System.Drawing.Size(100, 20);
            this.txtbxSurname2.TabIndex = 12;
            // 
            // lblRecordsDeleted
            // 
            this.lblRecordsDeleted.AutoSize = true;
            this.lblRecordsDeleted.Location = new System.Drawing.Point(105, 149);
            this.lblRecordsDeleted.Name = "lblRecordsDeleted";
            this.lblRecordsDeleted.Size = new System.Drawing.Size(99, 13);
            this.lblRecordsDeleted.TabIndex = 13;
            this.lblRecordsDeleted.Text = "Records Deleted: 0";
            // 
            // lblForename2
            // 
            this.lblForename2.AutoSize = true;
            this.lblForename2.Location = new System.Drawing.Point(105, 162);
            this.lblForename2.Name = "lblForename2";
            this.lblForename2.Size = new System.Drawing.Size(54, 13);
            this.lblForename2.TabIndex = 14;
            this.lblForename2.Text = "Forename";
            // 
            // lblSurname2
            // 
            this.lblSurname2.AutoSize = true;
            this.lblSurname2.Location = new System.Drawing.Point(211, 162);
            this.lblSurname2.Name = "lblSurname2";
            this.lblSurname2.Size = new System.Drawing.Size(49, 13);
            this.lblSurname2.TabIndex = 15;
            this.lblSurname2.Text = "Surname";
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(8, 214);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(95, 53);
            this.btnQuery.TabIndex = 16;
            this.btnQuery.Text = "Query Database";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // lblQuery
            // 
            this.lblQuery.AutoSize = true;
            this.lblQuery.Location = new System.Drawing.Point(105, 214);
            this.lblQuery.Name = "lblQuery";
            this.lblQuery.Size = new System.Drawing.Size(88, 13);
            this.lblQuery.TabIndex = 17;
            this.lblQuery.Text = "Select Statement";
            // 
            // lblResultCount
            // 
            this.lblResultCount.AutoSize = true;
            this.lblResultCount.Location = new System.Drawing.Point(225, 214);
            this.lblResultCount.Name = "lblResultCount";
            this.lblResultCount.Size = new System.Drawing.Size(80, 13);
            this.lblResultCount.TabIndex = 18;
            this.lblResultCount.Text = "Result Count: 0";
            // 
            // txtbxSelect
            // 
            this.txtbxSelect.Location = new System.Drawing.Point(109, 230);
            this.txtbxSelect.Multiline = true;
            this.txtbxSelect.Name = "txtbxSelect";
            this.txtbxSelect.Size = new System.Drawing.Size(212, 37);
            this.txtbxSelect.TabIndex = 19;
            // 
            // lstboxQueryResults
            // 
            this.lstboxQueryResults.FormattingEnabled = true;
            this.lstboxQueryResults.Location = new System.Drawing.Point(327, 214);
            this.lstboxQueryResults.Name = "lstboxQueryResults";
            this.lstboxQueryResults.Size = new System.Drawing.Size(194, 56);
            this.lstboxQueryResults.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.Controls.Add(this.lstboxQueryResults);
            this.Controls.Add(this.txtbxSelect);
            this.Controls.Add(this.lblResultCount);
            this.Controls.Add(this.lblQuery);
            this.Controls.Add(this.btnQuery);
            this.Controls.Add(this.lblSurname2);
            this.Controls.Add(this.lblForename2);
            this.Controls.Add(this.lblRecordsDeleted);
            this.Controls.Add(this.txtbxSurname2);
            this.Controls.Add(this.txtbxForename2);
            this.Controls.Add(this.btnDeleteData);
            this.Controls.Add(this.lblRecordsImported);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.lblTelephoneNumber);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.lblForename);
            this.Controls.Add(this.txtbxTelephoneNumber);
            this.Controls.Add(this.txtbxSurname);
            this.Controls.Add(this.txtbxForename);
            this.Controls.Add(this.btnInsertCustomer);
            this.Controls.Add(this.btnConnect);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnInsertCustomer;
        private System.Windows.Forms.TextBox txtbxForename;
        private System.Windows.Forms.TextBox txtbxSurname;
        private System.Windows.Forms.TextBox txtbxTelephoneNumber;
        private System.Windows.Forms.Label lblForename;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblTelephoneNumber;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Label lblRecordsImported;
        private System.Windows.Forms.Button btnDeleteData;
        private System.Windows.Forms.TextBox txtbxForename2;
        private System.Windows.Forms.TextBox txtbxSurname2;
        private System.Windows.Forms.Label lblRecordsDeleted;
        private System.Windows.Forms.Label lblForename2;
        private System.Windows.Forms.Label lblSurname2;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.Label lblQuery;
        private System.Windows.Forms.Label lblResultCount;
        private System.Windows.Forms.TextBox txtbxSelect;
        private System.Windows.Forms.ListBox lstboxQueryResults;
    }
}

