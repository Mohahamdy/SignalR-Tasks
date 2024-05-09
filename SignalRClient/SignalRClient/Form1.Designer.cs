namespace SignalRClient
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txt_name = new TextBox();
            txt_group = new TextBox();
            txt_mess = new TextBox();
            lb_messages = new ListBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btn_join = new Button();
            btn_send = new Button();
            SuspendLayout();
            // 
            // txt_name
            // 
            txt_name.Location = new Point(156, 30);
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(151, 23);
            txt_name.TabIndex = 0;
            // 
            // txt_group
            // 
            txt_group.Location = new Point(156, 71);
            txt_group.Name = "txt_group";
            txt_group.Size = new Size(151, 23);
            txt_group.TabIndex = 1;
            // 
            // txt_mess
            // 
            txt_mess.Location = new Point(156, 117);
            txt_mess.Name = "txt_mess";
            txt_mess.Size = new Size(151, 23);
            txt_mess.TabIndex = 2;
            // 
            // lb_messages
            // 
            lb_messages.FormattingEnabled = true;
            lb_messages.ItemHeight = 15;
            lb_messages.Location = new Point(12, 269);
            lb_messages.Name = "lb_messages";
            lb_messages.Size = new Size(411, 169);
            lb_messages.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(48, 33);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 4;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(48, 74);
            label2.Name = "label2";
            label2.Size = new Size(75, 15);
            label2.TabIndex = 5;
            label2.Text = "Group Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(48, 120);
            label3.Name = "label3";
            label3.Size = new Size(53, 15);
            label3.TabIndex = 6;
            label3.Text = "Message";
            // 
            // btn_join
            // 
            btn_join.Location = new Point(90, 194);
            btn_join.Name = "btn_join";
            btn_join.Size = new Size(82, 31);
            btn_join.TabIndex = 7;
            btn_join.Text = "Join";
            btn_join.UseVisualStyleBackColor = true;
            btn_join.Click += btn_join_Click;
            // 
            // btn_send
            // 
            btn_send.Location = new Point(187, 194);
            btn_send.Name = "btn_send";
            btn_send.Size = new Size(109, 31);
            btn_send.TabIndex = 8;
            btn_send.Text = "Send to Group";
            btn_send.UseVisualStyleBackColor = true;
            btn_send.Click += btn_send_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_send);
            Controls.Add(btn_join);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lb_messages);
            Controls.Add(txt_mess);
            Controls.Add(txt_group);
            Controls.Add(txt_name);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_name;
        private TextBox txt_group;
        private TextBox txt_mess;
        private ListBox lb_messages;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btn_join;
        private Button btn_send;
    }
}
