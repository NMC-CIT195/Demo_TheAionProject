namespace TheAionProject.Views
{
    partial class MainForm
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
            this.lbl_Title = new System.Windows.Forms.Label();
            this.pan_Boarder = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.grpBox_Message = new System.Windows.Forms.GroupBox();
            this.btn_QuitApplication = new System.Windows.Forms.Button();
            this.txt_GameMessage = new System.Windows.Forms.TextBox();
            this.pan_Boarder.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.grpBox_Message.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Title.Font = new System.Drawing.Font("Sitka Heading", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.Location = new System.Drawing.Point(377, 0);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Padding = new System.Windows.Forms.Padding(20, 5, 20, 5);
            this.lbl_Title.Size = new System.Drawing.Size(339, 68);
            this.lbl_Title.TabIndex = 0;
            this.lbl_Title.Text = "The Aion Project";
            // 
            // pan_Boarder
            // 
            this.pan_Boarder.BackColor = System.Drawing.Color.Transparent;
            this.pan_Boarder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pan_Boarder.Controls.Add(this.lbl_Title);
            this.pan_Boarder.Controls.Add(this.tableLayoutPanel1);
            this.pan_Boarder.Controls.Add(this.btn_QuitApplication);
            this.pan_Boarder.Location = new System.Drawing.Point(10, 10);
            this.pan_Boarder.Name = "pan_Boarder";
            this.pan_Boarder.Size = new System.Drawing.Size(1160, 731);
            this.pan_Boarder.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.grpBox_Message, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 71);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(10);
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1152, 465);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // grpBox_Message
            // 
            this.grpBox_Message.Controls.Add(this.txt_GameMessage);
            this.grpBox_Message.Location = new System.Drawing.Point(13, 13);
            this.grpBox_Message.Name = "grpBox_Message";
            this.grpBox_Message.Padding = new System.Windows.Forms.Padding(10);
            this.grpBox_Message.Size = new System.Drawing.Size(1126, 182);
            this.grpBox_Message.TabIndex = 3;
            this.grpBox_Message.TabStop = false;
            // 
            // btn_QuitApplication
            // 
            this.btn_QuitApplication.BackColor = System.Drawing.Color.PowderBlue;
            this.btn_QuitApplication.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_QuitApplication.ForeColor = System.Drawing.Color.MediumBlue;
            this.btn_QuitApplication.Location = new System.Drawing.Point(474, 671);
            this.btn_QuitApplication.Name = "btn_QuitApplication";
            this.btn_QuitApplication.Size = new System.Drawing.Size(189, 37);
            this.btn_QuitApplication.TabIndex = 1;
            this.btn_QuitApplication.Text = "Exit Mission";
            this.btn_QuitApplication.UseVisualStyleBackColor = false;
            this.btn_QuitApplication.Click += new System.EventHandler(this.btn_QuitApplication_Click);
            // 
            // txt_GameMessage
            // 
            this.txt_GameMessage.BackColor = System.Drawing.Color.MidnightBlue;
            this.txt_GameMessage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_GameMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_GameMessage.ForeColor = System.Drawing.Color.PowderBlue;
            this.txt_GameMessage.Location = new System.Drawing.Point(10, 25);
            this.txt_GameMessage.Multiline = true;
            this.txt_GameMessage.Name = "txt_GameMessage";
            this.txt_GameMessage.ReadOnly = true;
            this.txt_GameMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_GameMessage.Size = new System.Drawing.Size(1106, 147);
            this.txt_GameMessage.TabIndex = 0;
            this.txt_GameMessage.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(1182, 753);
            this.Controls.Add(this.pan_Boarder);
            this.ForeColor = System.Drawing.Color.PowderBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "MainForm";
            this.Text = "The Aion Project";
            this.pan_Boarder.ResumeLayout(false);
            this.pan_Boarder.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.grpBox_Message.ResumeLayout(false);
            this.grpBox_Message.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Panel pan_Boarder;
        private System.Windows.Forms.Button btn_QuitApplication;
        private System.Windows.Forms.GroupBox grpBox_Message;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txt_GameMessage;
    }
}

