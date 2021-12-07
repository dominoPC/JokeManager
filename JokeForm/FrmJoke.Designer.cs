
namespace JokeForm
{
    partial class FrmJoke
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
            this.lblUCID = new System.Windows.Forms.Label();
            this.lblJoke = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.txtUCID = new System.Windows.Forms.TextBox();
            this.txtJoke = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblUCID
            // 
            this.lblUCID.AutoSize = true;
            this.lblUCID.Location = new System.Drawing.Point(12, 15);
            this.lblUCID.Name = "lblUCID";
            this.lblUCID.Size = new System.Drawing.Size(36, 13);
            this.lblUCID.TabIndex = 0;
            this.lblUCID.Text = "UCID:";
            // 
            // lblJoke
            // 
            this.lblJoke.AutoSize = true;
            this.lblJoke.Location = new System.Drawing.Point(15, 41);
            this.lblJoke.Name = "lblJoke";
            this.lblJoke.Size = new System.Drawing.Size(33, 13);
            this.lblJoke.TabIndex = 1;
            this.lblJoke.Text = "Joke:";
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.ForeColor = System.Drawing.Color.Red;
            this.lblMessage.Location = new System.Drawing.Point(27, 69);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 13);
            this.lblMessage.TabIndex = 2;
            // 
            // txtUCID
            // 
            this.txtUCID.Location = new System.Drawing.Point(54, 12);
            this.txtUCID.Name = "txtUCID";
            this.txtUCID.Size = new System.Drawing.Size(100, 20);
            this.txtUCID.TabIndex = 3;
            // 
            // txtJoke
            // 
            this.txtJoke.Location = new System.Drawing.Point(54, 38);
            this.txtJoke.Name = "txtJoke";
            this.txtJoke.Size = new System.Drawing.Size(300, 20);
            this.txtJoke.TabIndex = 4;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(198, 64);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(279, 64);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save Joke";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmJoke
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 124);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtJoke);
            this.Controls.Add(this.txtUCID);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.lblJoke);
            this.Controls.Add(this.lblUCID);
            this.Name = "frmJoke";
            this.Text = "Joke Input";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUCID;
        private System.Windows.Forms.Label lblJoke;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.TextBox txtUCID;
        private System.Windows.Forms.TextBox txtJoke;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
    }
}

