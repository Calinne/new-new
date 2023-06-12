namespace transfer
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
            components = new System.ComponentModel.Container();
            transferbutton = new Button();
            senderr = new TextBox();
            reciever = new TextBox();
            amountmm = new TextBox();
            senderuser = new Label();
            recieveruser = new Label();
            amount = new Label();
            timer = new System.Windows.Forms.Timer(components);
            transferHistoryDataGridView = new DataGridView();
            historybutton = new Button();
            button1 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            datelbl = new Label();
            ((System.ComponentModel.ISupportInitialize)transferHistoryDataGridView).BeginInit();
            SuspendLayout();
            // 
            // transferbutton
            // 
            transferbutton.Location = new Point(363, 538);
            transferbutton.Margin = new Padding(5);
            transferbutton.Name = "transferbutton";
            transferbutton.Size = new Size(129, 92);
            transferbutton.TabIndex = 0;
            transferbutton.Text = "transfer";
            transferbutton.UseVisualStyleBackColor = true;
            transferbutton.Click += button1_Click;
            // 
            // senderr
            // 
            senderr.Location = new Point(363, 253);
            senderr.Margin = new Padding(5);
            senderr.Name = "senderr";
            senderr.Size = new Size(201, 39);
            senderr.TabIndex = 1;
            // 
            // reciever
            // 
            reciever.Location = new Point(363, 345);
            reciever.Margin = new Padding(5);
            reciever.Name = "reciever";
            reciever.Size = new Size(201, 39);
            reciever.TabIndex = 4;
            // 
            // amountmm
            // 
            amountmm.Location = new Point(363, 444);
            amountmm.Margin = new Padding(5);
            amountmm.Name = "amountmm";
            amountmm.Size = new Size(201, 39);
            amountmm.TabIndex = 5;
            // 
            // senderuser
            // 
            senderuser.AutoSize = true;
            senderuser.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            senderuser.Location = new Point(55, 253);
            senderuser.Margin = new Padding(5, 0, 5, 0);
            senderuser.Name = "senderuser";
            senderuser.Size = new Size(272, 32);
            senderuser.TabIndex = 6;
            senderuser.Text = "From Account number";
            senderuser.Click += label1_Click;
            // 
            // recieveruser
            // 
            recieveruser.AutoSize = true;
            recieveruser.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            recieveruser.Location = new Point(55, 345);
            recieveruser.Margin = new Padding(5, 0, 5, 0);
            recieveruser.Name = "recieveruser";
            recieveruser.Size = new Size(248, 32);
            recieveruser.TabIndex = 7;
            recieveruser.Text = "Destination Account";
            // 
            // amount
            // 
            amount.AutoSize = true;
            amount.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            amount.Location = new Point(127, 451);
            amount.Margin = new Padding(5, 0, 5, 0);
            amount.Name = "amount";
            amount.Size = new Size(107, 32);
            amount.TabIndex = 10;
            amount.Text = "Amount";
            // 
            // timer
            // 
            timer.Tick += timer1_Tick;
            // 
            // transferHistoryDataGridView
            // 
            transferHistoryDataGridView.BackgroundColor = SystemColors.ControlLight;
            transferHistoryDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            transferHistoryDataGridView.Location = new Point(793, 40);
            transferHistoryDataGridView.Margin = new Padding(5);
            transferHistoryDataGridView.Name = "transferHistoryDataGridView";
            transferHistoryDataGridView.RowHeadersWidth = 51;
            transferHistoryDataGridView.RowTemplate.Height = 29;
            transferHistoryDataGridView.Size = new Size(493, 212);
            transferHistoryDataGridView.TabIndex = 11;
            // 
            // historybutton
            // 
            historybutton.Location = new Point(849, 280);
            historybutton.Margin = new Padding(5);
            historybutton.Name = "historybutton";
            historybutton.Size = new Size(403, 46);
            historybutton.TabIndex = 12;
            historybutton.Text = "see transaction history";
            historybutton.UseVisualStyleBackColor = true;
            historybutton.Click += historybutton_Click;
            // 
            // button1
            // 
            button1.Location = new Point(1089, 613);
            button1.Margin = new Padding(5);
            button1.Name = "button1";
            button1.Size = new Size(153, 46);
            button1.TabIndex = 13;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.BackColor = Color.Azure;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.ForeColor = Color.LightSeaGreen;
            textBox1.Location = new Point(71, 26);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(256, 39);
            textBox1.TabIndex = 14;
            textBox1.Text = "TRANSFERS";
            textBox1.TextAlign = HorizontalAlignment.Center;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(127, 150);
            label1.Name = "label1";
            label1.Size = new Size(72, 32);
            label1.TabIndex = 15;
            label1.Text = "Date:";
            // 
            // datelbl
            // 
            datelbl.AutoSize = true;
            datelbl.Location = new Point(212, 153);
            datelbl.Name = "datelbl";
            datelbl.Size = new Size(0, 32);
            datelbl.TabIndex = 16;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(1300, 720);
            Controls.Add(datelbl);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(historybutton);
            Controls.Add(transferHistoryDataGridView);
            Controls.Add(amount);
            Controls.Add(recieveruser);
            Controls.Add(senderuser);
            Controls.Add(amountmm);
            Controls.Add(reciever);
            Controls.Add(senderr);
            Controls.Add(transferbutton);
            Margin = new Padding(5);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)transferHistoryDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button transferbutton;
        private TextBox senderr;
        private TextBox reciever;
        private TextBox amountmm;
        private Label senderuser;
        private Label recieveruser;
        private Label amount;
        private System.Windows.Forms.Timer timer;
        private DataGridView transferHistoryDataGridView;
        private Button historybutton;
        private Button button1;
        private TextBox textBox1;
        private Label label1;
        private Label datelbl;
    }
}