namespace WindowsFormsAppEmployeeSerilization
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
            this.labelId = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelSalary = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnBinaryWriter = new System.Windows.Forms.Button();
            this.btnBinaryRead = new System.Windows.Forms.Button();
            this.btnXMLWriter = new System.Windows.Forms.Button();
            this.btnXMLRead = new System.Windows.Forms.Button();
            this.btnSOAPWriter = new System.Windows.Forms.Button();
            this.btnSOAPRead = new System.Windows.Forms.Button();
            this.btnJSONWriter = new System.Windows.Forms.Button();
            this.btnJSONReader = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelId.Location = new System.Drawing.Point(121, 41);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(58, 18);
            this.labelId.TabIndex = 0;
            this.labelId.Text = "Enter Id";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(121, 85);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(87, 18);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Enter Name";
            // 
            // labelSalary
            // 
            this.labelSalary.AutoSize = true;
            this.labelSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSalary.Location = new System.Drawing.Point(119, 128);
            this.labelSalary.Name = "labelSalary";
            this.labelSalary.Size = new System.Drawing.Size(88, 18);
            this.labelSalary.TabIndex = 2;
            this.labelSalary.Text = "Enter Salary";
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(246, 41);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(174, 24);
            this.txtId.TabIndex = 3;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(246, 85);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(174, 24);
            this.txtName.TabIndex = 4;
            // 
            // txtSalary
            // 
            this.txtSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalary.Location = new System.Drawing.Point(246, 128);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(174, 24);
            this.txtSalary.TabIndex = 5;
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(476, 77);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(229, 46);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnBinaryWriter
            // 
            this.btnBinaryWriter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBinaryWriter.Location = new System.Drawing.Point(127, 203);
            this.btnBinaryWriter.Name = "btnBinaryWriter";
            this.btnBinaryWriter.Size = new System.Drawing.Size(192, 40);
            this.btnBinaryWriter.TabIndex = 7;
            this.btnBinaryWriter.Text = "Binary Write";
            this.btnBinaryWriter.UseVisualStyleBackColor = true;
            this.btnBinaryWriter.Click += new System.EventHandler(this.btnBinaryWriter_Click);
            // 
            // btnBinaryRead
            // 
            this.btnBinaryRead.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBinaryRead.Location = new System.Drawing.Point(333, 203);
            this.btnBinaryRead.Name = "btnBinaryRead";
            this.btnBinaryRead.Size = new System.Drawing.Size(192, 40);
            this.btnBinaryRead.TabIndex = 8;
            this.btnBinaryRead.Text = "Binary Read";
            this.btnBinaryRead.UseVisualStyleBackColor = true;
            this.btnBinaryRead.Click += new System.EventHandler(this.btnBinaryRead_Click);
            // 
            // btnXMLWriter
            // 
            this.btnXMLWriter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXMLWriter.Location = new System.Drawing.Point(127, 259);
            this.btnXMLWriter.Name = "btnXMLWriter";
            this.btnXMLWriter.Size = new System.Drawing.Size(192, 40);
            this.btnXMLWriter.TabIndex = 9;
            this.btnXMLWriter.Text = "XML Write";
            this.btnXMLWriter.UseVisualStyleBackColor = true;
            this.btnXMLWriter.Click += new System.EventHandler(this.btnXMLWriter_Click);
            // 
            // btnXMLRead
            // 
            this.btnXMLRead.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXMLRead.Location = new System.Drawing.Point(333, 258);
            this.btnXMLRead.Name = "btnXMLRead";
            this.btnXMLRead.Size = new System.Drawing.Size(192, 40);
            this.btnXMLRead.TabIndex = 10;
            this.btnXMLRead.Text = "XML Read";
            this.btnXMLRead.UseVisualStyleBackColor = true;
            this.btnXMLRead.Click += new System.EventHandler(this.btnXMLRead_Click);
            // 
            // btnSOAPWriter
            // 
            this.btnSOAPWriter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSOAPWriter.Location = new System.Drawing.Point(127, 326);
            this.btnSOAPWriter.Name = "btnSOAPWriter";
            this.btnSOAPWriter.Size = new System.Drawing.Size(192, 40);
            this.btnSOAPWriter.TabIndex = 11;
            this.btnSOAPWriter.Text = "SOAP Write";
            this.btnSOAPWriter.UseVisualStyleBackColor = true;
            this.btnSOAPWriter.Click += new System.EventHandler(this.btnSOAPWriter_Click);
            // 
            // btnSOAPRead
            // 
            this.btnSOAPRead.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSOAPRead.Location = new System.Drawing.Point(333, 325);
            this.btnSOAPRead.Name = "btnSOAPRead";
            this.btnSOAPRead.Size = new System.Drawing.Size(192, 40);
            this.btnSOAPRead.TabIndex = 12;
            this.btnSOAPRead.Text = "SOAP Read";
            this.btnSOAPRead.UseVisualStyleBackColor = true;
            this.btnSOAPRead.Click += new System.EventHandler(this.btnSOAPRead_Click);
            // 
            // btnJSONWriter
            // 
            this.btnJSONWriter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJSONWriter.Location = new System.Drawing.Point(124, 382);
            this.btnJSONWriter.Name = "btnJSONWriter";
            this.btnJSONWriter.Size = new System.Drawing.Size(192, 40);
            this.btnJSONWriter.TabIndex = 13;
            this.btnJSONWriter.Text = "JSON Write";
            this.btnJSONWriter.UseVisualStyleBackColor = true;
            this.btnJSONWriter.Click += new System.EventHandler(this.btnJSONWriter_Click);
            // 
            // btnJSONReader
            // 
            this.btnJSONReader.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJSONReader.Location = new System.Drawing.Point(333, 382);
            this.btnJSONReader.Name = "btnJSONReader";
            this.btnJSONReader.Size = new System.Drawing.Size(192, 40);
            this.btnJSONReader.TabIndex = 14;
            this.btnJSONReader.Text = "JSON Read";
            this.btnJSONReader.UseVisualStyleBackColor = true;
            this.btnJSONReader.Click += new System.EventHandler(this.btnJSONReader_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnJSONReader);
            this.Controls.Add(this.btnJSONWriter);
            this.Controls.Add(this.btnSOAPRead);
            this.Controls.Add(this.btnSOAPWriter);
            this.Controls.Add(this.btnXMLRead);
            this.Controls.Add(this.btnXMLWriter);
            this.Controls.Add(this.btnBinaryRead);
            this.Controls.Add(this.btnBinaryWriter);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.labelSalary);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelId);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelSalary;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnBinaryWriter;
        private System.Windows.Forms.Button btnBinaryRead;
        private System.Windows.Forms.Button btnXMLWriter;
        private System.Windows.Forms.Button btnXMLRead;
        private System.Windows.Forms.Button btnSOAPWriter;
        private System.Windows.Forms.Button btnSOAPRead;
        private System.Windows.Forms.Button btnJSONWriter;
        private System.Windows.Forms.Button btnJSONReader;
    }
}

