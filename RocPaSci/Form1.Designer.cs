namespace RocPaSci
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
            label1 = new Label();
            pbx_user = new PictureBox();
            pbx_pc = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            lbl_user = new Label();
            lbl_pc = new Label();
            cbx_options = new ComboBox();
            button1 = new Button();
            btn_play = new Button();
            lbl_answer = new Label();
            ((System.ComponentModel.ISupportInitialize)pbx_user).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbx_pc).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(311, 9);
            label1.Name = "label1";
            label1.Size = new Size(375, 32);
            label1.TabIndex = 0;
            label1.Text = "Rock \U0001faa8, Paper 📄, Scissors ✂️";
            // 
            // pbx_user
            // 
            pbx_user.Image = Properties.Resources.none;
            pbx_user.Location = new Point(71, 93);
            pbx_user.Name = "pbx_user";
            pbx_user.Size = new Size(240, 299);
            pbx_user.SizeMode = PictureBoxSizeMode.StretchImage;
            pbx_user.TabIndex = 1;
            pbx_user.TabStop = false;
            // 
            // pbx_pc
            // 
            pbx_pc.Image = Properties.Resources.none;
            pbx_pc.Location = new Point(657, 93);
            pbx_pc.Name = "pbx_pc";
            pbx_pc.Size = new Size(240, 299);
            pbx_pc.SizeMode = PictureBoxSizeMode.StretchImage;
            pbx_pc.TabIndex = 2;
            pbx_pc.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Lime;
            label2.Location = new Point(71, 58);
            label2.Name = "label2";
            label2.Size = new Size(65, 32);
            label2.TabIndex = 3;
            label2.Text = "User";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(657, 58);
            label3.Name = "label3";
            label3.Size = new Size(44, 32);
            label3.TabIndex = 4;
            label3.Text = "PC";
            // 
            // lbl_user
            // 
            lbl_user.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_user.Location = new Point(117, 407);
            lbl_user.Name = "lbl_user";
            lbl_user.Size = new Size(119, 20);
            lbl_user.TabIndex = 5;
            lbl_user.Text = "Selected Option";
            lbl_user.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_pc
            // 
            lbl_pc.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_pc.Location = new Point(722, 407);
            lbl_pc.Name = "lbl_pc";
            lbl_pc.Size = new Size(119, 20);
            lbl_pc.TabIndex = 6;
            lbl_pc.Text = "Selected Option";
            lbl_pc.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cbx_options
            // 
            cbx_options.FormattingEnabled = true;
            cbx_options.Items.AddRange(new object[] { "Rock", "Paper", "Scissors" });
            cbx_options.Location = new Point(340, 213);
            cbx_options.Name = "cbx_options";
            cbx_options.Size = new Size(282, 23);
            cbx_options.TabIndex = 7;
            // 
            // button1
            // 
            button1.Location = new Point(0, 0);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            // 
            // btn_play
            // 
            btn_play.BackColor = Color.Chartreuse;
            btn_play.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_play.Location = new Point(410, 264);
            btn_play.Name = "btn_play";
            btn_play.Size = new Size(146, 50);
            btn_play.TabIndex = 8;
            btn_play.Text = "Play";
            btn_play.UseVisualStyleBackColor = false;
            btn_play.Click += btn_play_Click;
            // 
            // lbl_answer
            // 
            lbl_answer.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_answer.Location = new Point(340, 93);
            lbl_answer.Name = "lbl_answer";
            lbl_answer.Size = new Size(282, 50);
            lbl_answer.TabIndex = 9;
            lbl_answer.Text = "¿Who will win?";
            lbl_answer.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(994, 488);
            Controls.Add(lbl_answer);
            Controls.Add(btn_play);
            Controls.Add(cbx_options);
            Controls.Add(lbl_pc);
            Controls.Add(lbl_user);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pbx_pc);
            Controls.Add(pbx_user);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pbx_user).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbx_pc).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pbx_user;
        private PictureBox pbx_pc;
        private Label label2;
        private Label label3;
        private Label lbl_user;
        private Label lbl_pc;
        private ComboBox cbx_options;
        private Button button1;
        private Button btn_play;
        private Label lbl_answer;
    }
}
