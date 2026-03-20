namespace MurrendyConverter
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            pnlCard = new Panel();
            lblTitle = new Label();
            lblSubtitle = new Label();
            pnlDivider = new Panel();
            label1 = new Label();
            cbDe = new ComboBox();
            btnSwap = new Button();
            label2 = new Label();
            cbPara = new ComboBox();
            label3 = new Label();
            txtValor = new TextBox();
            btnConverter = new Button();
            pnlResult = new Panel();
            lblResultLabel = new Label();
            lblResultado = new Label();
            pnlCard.SuspendLayout();
            pnlResult.SuspendLayout();
            SuspendLayout();
            // 
            // pnlCard
            // 
            pnlCard.BackColor = Color.FromArgb(22, 27, 34);
            pnlCard.Controls.Add(lblTitle);
            pnlCard.Controls.Add(lblSubtitle);
            pnlCard.Controls.Add(pnlDivider);
            pnlCard.Controls.Add(label1);
            pnlCard.Controls.Add(cbDe);
            pnlCard.Controls.Add(btnSwap);
            pnlCard.Controls.Add(label2);
            pnlCard.Controls.Add(cbPara);
            pnlCard.Controls.Add(label3);
            pnlCard.Controls.Add(txtValor);
            pnlCard.Controls.Add(btnConverter);
            pnlCard.Controls.Add(pnlResult);
            pnlCard.Location = new Point(30, 30);
            pnlCard.Name = "pnlCard";
            pnlCard.Size = new Size(469, 418);
            pnlCard.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.Transparent;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(230, 237, 243);
            lblTitle.Location = new Point(28, 10);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(158, 41);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Converter";
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.BackColor = Color.Transparent;
            lblSubtitle.Font = new Font("Segoe UI", 9F);
            lblSubtitle.ForeColor = Color.FromArgb(125, 133, 144);
            lblSubtitle.Location = new Point(30, 62);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(266, 20);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Select the coins and report the amount";
            // 
            // pnlDivider
            // 
            pnlDivider.BackColor = Color.FromArgb(48, 54, 61);
            pnlDivider.Location = new Point(0, 90);
            pnlDivider.Name = "pnlDivider";
            pnlDivider.Size = new Size(460, 1);
            pnlDivider.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 9F);
            label1.ForeColor = Color.FromArgb(125, 133, 144);
            label1.Location = new Point(28, 110);
            label1.Name = "label1";
            label1.Size = new Size(28, 20);
            label1.TabIndex = 3;
            label1.Text = "DE";
            // 
            // cbDe
            // 
            cbDe.BackColor = Color.FromArgb(33, 38, 45);
            cbDe.DropDownStyle = ComboBoxStyle.DropDownList;
            cbDe.FlatStyle = FlatStyle.Flat;
            cbDe.Font = new Font("Segoe UI", 10F);
            cbDe.ForeColor = Color.FromArgb(230, 237, 243);
            cbDe.Location = new Point(28, 132);
            cbDe.Name = "cbDe";
            cbDe.Size = new Size(165, 31);
            cbDe.TabIndex = 4;
            // 
            // btnSwap
            // 
            btnSwap.BackColor = Color.FromArgb(33, 38, 45);
            btnSwap.Cursor = Cursors.Hand;
            btnSwap.FlatAppearance.BorderColor = Color.FromArgb(48, 54, 61);
            btnSwap.FlatAppearance.MouseOverBackColor = Color.FromArgb(40, 46, 54);
            btnSwap.FlatStyle = FlatStyle.Flat;
            btnSwap.Font = new Font("Segoe UI", 12F);
            btnSwap.ForeColor = Color.FromArgb(125, 133, 144);
            btnSwap.Location = new Point(208, 130);
            btnSwap.Name = "btnSwap";
            btnSwap.Size = new Size(44, 34);
            btnSwap.TabIndex = 5;
            btnSwap.Text = "⇄";
            btnSwap.UseVisualStyleBackColor = false;
            btnSwap.Click += btnSwap_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 9F);
            label2.ForeColor = Color.FromArgb(125, 133, 144);
            label2.Location = new Point(268, 110);
            label2.Name = "label2";
            label2.Size = new Size(45, 20);
            label2.TabIndex = 6;
            label2.Text = "PARA";
            // 
            // cbPara
            // 
            cbPara.BackColor = Color.FromArgb(33, 38, 45);
            cbPara.DropDownStyle = ComboBoxStyle.DropDownList;
            cbPara.FlatStyle = FlatStyle.Flat;
            cbPara.Font = new Font("Segoe UI", 10F);
            cbPara.ForeColor = Color.FromArgb(230, 237, 243);
            cbPara.Location = new Point(268, 132);
            cbPara.Name = "cbPara";
            cbPara.Size = new Size(165, 31);
            cbPara.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 9F);
            label3.ForeColor = Color.FromArgb(125, 133, 144);
            label3.Location = new Point(28, 194);
            label3.Name = "label3";
            label3.Size = new Size(53, 20);
            label3.TabIndex = 8;
            label3.Text = "VALOR";
            // 
            // txtValor
            // 
            txtValor.BackColor = Color.FromArgb(33, 38, 45);
            txtValor.BorderStyle = BorderStyle.FixedSingle;
            txtValor.Font = new Font("Segoe UI", 11F);
            txtValor.ForeColor = Color.FromArgb(230, 237, 243);
            txtValor.Location = new Point(28, 216);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(405, 32);
            txtValor.TabIndex = 9;
            // 
            // btnConverter
            // 
            btnConverter.BackColor = Color.FromArgb(88, 166, 255);
            btnConverter.Cursor = Cursors.Hand;
            btnConverter.FlatAppearance.BorderSize = 0;
            btnConverter.FlatAppearance.MouseOverBackColor = Color.FromArgb(66, 144, 233);
            btnConverter.FlatStyle = FlatStyle.Flat;
            btnConverter.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnConverter.ForeColor = Color.FromArgb(13, 17, 23);
            btnConverter.Location = new Point(28, 276);
            btnConverter.Name = "btnConverter";
            btnConverter.Size = new Size(405, 42);
            btnConverter.TabIndex = 10;
            btnConverter.Text = "Converter";
            btnConverter.UseVisualStyleBackColor = false;
            btnConverter.Click += btnConverter_Click;
            // 
            // pnlResult
            // 
            pnlResult.BackColor = Color.FromArgb(33, 38, 45);
            pnlResult.BorderStyle = BorderStyle.FixedSingle;
            pnlResult.Controls.Add(lblResultLabel);
            pnlResult.Controls.Add(lblResultado);
            pnlResult.Location = new Point(28, 342);
            pnlResult.Name = "pnlResult";
            pnlResult.Size = new Size(405, 54);
            pnlResult.TabIndex = 11;
            // 
            // lblResultLabel
            // 
            lblResultLabel.AutoSize = true;
            lblResultLabel.BackColor = Color.Transparent;
            lblResultLabel.Font = new Font("Segoe UI", 8F);
            lblResultLabel.ForeColor = Color.FromArgb(125, 133, 144);
            lblResultLabel.Location = new Point(12, 6);
            lblResultLabel.Name = "lblResultLabel";
            lblResultLabel.Size = new Size(83, 19);
            lblResultLabel.TabIndex = 0;
            lblResultLabel.Text = "RESULTADO";
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.BackColor = Color.Transparent;
            lblResultado.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblResultado.ForeColor = Color.FromArgb(88, 166, 255);
            lblResultado.Location = new Point(12, 24);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(38, 32);
            lblResultado.TabIndex = 1;
            lblResultado.Text = "—";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(13, 17, 23);
            ClientSize = new Size(524, 480);
            Controls.Add(pnlCard);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Murrendy Converter";
            Load += Form1_Load;
            pnlCard.ResumeLayout(false);
            pnlCard.PerformLayout();
            pnlResult.ResumeLayout(false);
            pnlResult.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        // ── Campos ──────────────────────────────────────────────────
        private Panel pnlCard;
        private Label lblTitle;
        private Label lblSubtitle;
        private Panel pnlDivider;
        private Label label1;
        private Label label2;
        private ComboBox cbDe;
        private Button btnSwap;
        private ComboBox cbPara;
        private Label label3;
        private TextBox txtValor;
        private Button btnConverter;
        private Panel pnlResult;
        private Label lblResultLabel;
        private Label lblResultado;
    }
}