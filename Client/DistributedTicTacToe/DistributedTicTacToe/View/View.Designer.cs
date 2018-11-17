namespace DistributedTicTacToe
{
    partial class View
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
            this.ServerBrowserPanel = new System.Windows.Forms.Panel();
            this.GameAreaPanel = new System.Windows.Forms.Panel();
            this.PlayerTurnLabel = new System.Windows.Forms.Label();
            this.bottomRightButton = new System.Windows.Forms.Button();
            this.bottomMiddleButton = new System.Windows.Forms.Button();
            this.bottomLeftButton = new System.Windows.Forms.Button();
            this.middleRightButton = new System.Windows.Forms.Button();
            this.middleButton = new System.Windows.Forms.Button();
            this.middleLeftButton = new System.Windows.Forms.Button();
            this.upperRightButton = new System.Windows.Forms.Button();
            this.upperMiddleButton = new System.Windows.Forms.Button();
            this.upperLeftButton = new System.Windows.Forms.Button();
            this.serverLabel = new System.Windows.Forms.Label();
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.connectButton = new System.Windows.Forms.Button();
            this.ServerBrowserPanel.SuspendLayout();
            this.GameAreaPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ServerBrowserPanel
            // 
            this.ServerBrowserPanel.Controls.Add(this.connectButton);
            this.ServerBrowserPanel.Controls.Add(this.userNameTextBox);
            this.ServerBrowserPanel.Controls.Add(this.serverLabel);
            this.ServerBrowserPanel.Location = new System.Drawing.Point(42, 29);
            this.ServerBrowserPanel.Name = "ServerBrowserPanel";
            this.ServerBrowserPanel.Size = new System.Drawing.Size(227, 332);
            this.ServerBrowserPanel.TabIndex = 0;
            // 
            // GameAreaPanel
            // 
            this.GameAreaPanel.Controls.Add(this.PlayerTurnLabel);
            this.GameAreaPanel.Controls.Add(this.bottomRightButton);
            this.GameAreaPanel.Controls.Add(this.bottomMiddleButton);
            this.GameAreaPanel.Controls.Add(this.bottomLeftButton);
            this.GameAreaPanel.Controls.Add(this.middleRightButton);
            this.GameAreaPanel.Controls.Add(this.middleButton);
            this.GameAreaPanel.Controls.Add(this.middleLeftButton);
            this.GameAreaPanel.Controls.Add(this.upperRightButton);
            this.GameAreaPanel.Controls.Add(this.upperMiddleButton);
            this.GameAreaPanel.Controls.Add(this.upperLeftButton);
            this.GameAreaPanel.Location = new System.Drawing.Point(408, 39);
            this.GameAreaPanel.Name = "GameAreaPanel";
            this.GameAreaPanel.Size = new System.Drawing.Size(287, 332);
            this.GameAreaPanel.TabIndex = 1;
            this.GameAreaPanel.Visible = false;
            // 
            // PlayerTurnLabel
            // 
            this.PlayerTurnLabel.AutoSize = true;
            this.PlayerTurnLabel.Location = new System.Drawing.Point(58, 30);
            this.PlayerTurnLabel.Name = "PlayerTurnLabel";
            this.PlayerTurnLabel.Size = new System.Drawing.Size(60, 13);
            this.PlayerTurnLabel.TabIndex = 9;
            this.PlayerTurnLabel.Text = "Player turn:";
            // 
            // bottomRightButton
            // 
            this.bottomRightButton.Location = new System.Drawing.Point(150, 157);
            this.bottomRightButton.Name = "bottomRightButton";
            this.bottomRightButton.Size = new System.Drawing.Size(40, 40);
            this.bottomRightButton.TabIndex = 8;
            this.bottomRightButton.UseVisualStyleBackColor = true;
            // 
            // bottomMiddleButton
            // 
            this.bottomMiddleButton.Location = new System.Drawing.Point(104, 157);
            this.bottomMiddleButton.Name = "bottomMiddleButton";
            this.bottomMiddleButton.Size = new System.Drawing.Size(40, 40);
            this.bottomMiddleButton.TabIndex = 7;
            this.bottomMiddleButton.UseVisualStyleBackColor = true;
            // 
            // bottomLeftButton
            // 
            this.bottomLeftButton.Location = new System.Drawing.Point(58, 157);
            this.bottomLeftButton.Name = "bottomLeftButton";
            this.bottomLeftButton.Size = new System.Drawing.Size(40, 40);
            this.bottomLeftButton.TabIndex = 6;
            this.bottomLeftButton.UseVisualStyleBackColor = true;
            // 
            // middleRightButton
            // 
            this.middleRightButton.Location = new System.Drawing.Point(150, 111);
            this.middleRightButton.Name = "middleRightButton";
            this.middleRightButton.Size = new System.Drawing.Size(40, 40);
            this.middleRightButton.TabIndex = 5;
            this.middleRightButton.UseVisualStyleBackColor = true;
            // 
            // middleButton
            // 
            this.middleButton.Location = new System.Drawing.Point(104, 111);
            this.middleButton.Name = "middleButton";
            this.middleButton.Size = new System.Drawing.Size(40, 40);
            this.middleButton.TabIndex = 4;
            this.middleButton.UseVisualStyleBackColor = true;
            // 
            // middleLeftButton
            // 
            this.middleLeftButton.Location = new System.Drawing.Point(58, 111);
            this.middleLeftButton.Name = "middleLeftButton";
            this.middleLeftButton.Size = new System.Drawing.Size(40, 40);
            this.middleLeftButton.TabIndex = 3;
            this.middleLeftButton.UseVisualStyleBackColor = true;
            // 
            // upperRightButton
            // 
            this.upperRightButton.Location = new System.Drawing.Point(150, 65);
            this.upperRightButton.Name = "upperRightButton";
            this.upperRightButton.Size = new System.Drawing.Size(40, 40);
            this.upperRightButton.TabIndex = 2;
            this.upperRightButton.UseVisualStyleBackColor = true;
            // 
            // upperMiddleButton
            // 
            this.upperMiddleButton.Location = new System.Drawing.Point(104, 65);
            this.upperMiddleButton.Name = "upperMiddleButton";
            this.upperMiddleButton.Size = new System.Drawing.Size(40, 40);
            this.upperMiddleButton.TabIndex = 1;
            this.upperMiddleButton.UseVisualStyleBackColor = true;
            // 
            // upperLeftButton
            // 
            this.upperLeftButton.Location = new System.Drawing.Point(58, 65);
            this.upperLeftButton.Name = "upperLeftButton";
            this.upperLeftButton.Size = new System.Drawing.Size(40, 40);
            this.upperLeftButton.TabIndex = 0;
            this.upperLeftButton.UseVisualStyleBackColor = true;
            // 
            // serverLabel
            // 
            this.serverLabel.AutoSize = true;
            this.serverLabel.Location = new System.Drawing.Point(28, 40);
            this.serverLabel.Name = "serverLabel";
            this.serverLabel.Size = new System.Drawing.Size(63, 13);
            this.serverLabel.TabIndex = 0;
            this.serverLabel.Text = "Server label";
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.Location = new System.Drawing.Point(31, 57);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.Size = new System.Drawing.Size(94, 20);
            this.userNameTextBox.TabIndex = 1;
            this.userNameTextBox.Text = "User name";
            // 
            // connectButton
            // 
            this.connectButton.Location = new System.Drawing.Point(132, 57);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(75, 23);
            this.connectButton.TabIndex = 2;
            this.connectButton.Text = "connect";
            this.connectButton.UseVisualStyleBackColor = true;
            // 
            // View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GameAreaPanel);
            this.Controls.Add(this.ServerBrowserPanel);
            this.Name = "View";
            this.Text = "TicTacToe";
            this.ServerBrowserPanel.ResumeLayout(false);
            this.ServerBrowserPanel.PerformLayout();
            this.GameAreaPanel.ResumeLayout(false);
            this.GameAreaPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ServerBrowserPanel;
        private System.Windows.Forms.Panel GameAreaPanel;
        private System.Windows.Forms.Label PlayerTurnLabel;
        private System.Windows.Forms.Button bottomRightButton;
        private System.Windows.Forms.Button bottomMiddleButton;
        private System.Windows.Forms.Button bottomLeftButton;
        private System.Windows.Forms.Button middleRightButton;
        private System.Windows.Forms.Button middleButton;
        private System.Windows.Forms.Button middleLeftButton;
        private System.Windows.Forms.Button upperRightButton;
        private System.Windows.Forms.Button upperMiddleButton;
        private System.Windows.Forms.Button upperLeftButton;
        private System.Windows.Forms.Label serverLabel;
        private System.Windows.Forms.TextBox userNameTextBox;
        private System.Windows.Forms.Button connectButton;
    }
}

