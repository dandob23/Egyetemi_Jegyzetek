namespace _1122
{
    partial class UserHandler
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
            this.SuspendLayout();
            // 
            // UserHandler
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Name = "UserHandler";
            this.Load += new System.EventHandler(this.UserHandler_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.TextBox idBox;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.TextBox usernameBox;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.Button userHandlerButton;
    }
}