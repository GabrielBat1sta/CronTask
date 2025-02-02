namespace CronTask
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
            btnIniciar = new Button();
            btnParar = new Button();
            btnSalvar = new Button();
            btnCarregar = new Button();
            lblTime = new Label();
            tbTarefa = new TextBox();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            btnFecharCSV = new Button();
            BtnSair = new Button();
            btnSalvarCSV = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnIniciar
            // 
            btnIniciar.Location = new Point(12, 12);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(106, 47);
            btnIniciar.TabIndex = 0;
            btnIniciar.Text = "Iniciar";
            btnIniciar.UseVisualStyleBackColor = true;
            btnIniciar.Click += btnIniciar_Click;
            // 
            // btnParar
            // 
            btnParar.Enabled = false;
            btnParar.Location = new Point(12, 65);
            btnParar.Name = "btnParar";
            btnParar.Size = new Size(106, 47);
            btnParar.TabIndex = 2;
            btnParar.Text = "Parar";
            btnParar.UseVisualStyleBackColor = true;
            btnParar.Click += btnParar_Click_1;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(250, 48);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(106, 47);
            btnSalvar.TabIndex = 4;
            btnSalvar.Text = "Salvar Tarefa";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnCarregar
            // 
            btnCarregar.Location = new Point(124, 441);
            btnCarregar.Name = "btnCarregar";
            btnCarregar.Size = new Size(106, 47);
            btnCarregar.TabIndex = 5;
            btnCarregar.Text = "Carregar CSV";
            btnCarregar.UseVisualStyleBackColor = true;
            btnCarregar.Click += btnCarregar_Click_1;
            // 
            // lblTime
            // 
            lblTime.AutoSize = true;
            lblTime.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTime.Location = new Point(124, 40);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(97, 30);
            lblTime.TabIndex = 6;
            lblTime.Text = "00:00:00";
            // 
            // tbTarefa
            // 
            tbTarefa.Location = new Point(491, 22);
            tbTarefa.Name = "tbTarefa";
            tbTarefa.Size = new Size(308, 23);
            tbTarefa.TabIndex = 7;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 130);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(832, 305);
            dataGridView1.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(250, 20);
            label1.Name = "label1";
            label1.Size = new Size(246, 25);
            label1.TabIndex = 10;
            label1.Text = "Informe o nome da tarefa:";
            label1.TextAlign = ContentAlignment.BottomCenter;
            // 
            // btnFecharCSV
            // 
            btnFecharCSV.Location = new Point(236, 441);
            btnFecharCSV.Name = "btnFecharCSV";
            btnFecharCSV.Size = new Size(106, 47);
            btnFecharCSV.TabIndex = 11;
            btnFecharCSV.Text = "Fechar CSV";
            btnFecharCSV.UseVisualStyleBackColor = true;
            btnFecharCSV.Click += btnFecharCSV_Click;
            // 
            // BtnSair
            // 
            BtnSair.Location = new Point(738, 441);
            BtnSair.Name = "BtnSair";
            BtnSair.Size = new Size(106, 47);
            BtnSair.TabIndex = 12;
            BtnSair.Text = "Sair";
            BtnSair.UseVisualStyleBackColor = true;
            BtnSair.Click += BtnSair_Click;
            // 
            // btnSalvarCSV
            // 
            btnSalvarCSV.Location = new Point(12, 441);
            btnSalvarCSV.Name = "btnSalvarCSV";
            btnSalvarCSV.Size = new Size(106, 47);
            btnSalvarCSV.TabIndex = 13;
            btnSalvarCSV.Text = "Salvar CSV";
            btnSalvarCSV.UseVisualStyleBackColor = true;
            btnSalvarCSV.Click += btnSalvarCSV_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(856, 496);
            Controls.Add(btnSalvarCSV);
            Controls.Add(BtnSair);
            Controls.Add(btnFecharCSV);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(tbTarefa);
            Controls.Add(lblTime);
            Controls.Add(btnCarregar);
            Controls.Add(btnSalvar);
            Controls.Add(btnParar);
            Controls.Add(btnIniciar);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnIniciar;
        private Button btnParar;
        private Button btnSalvar;
        private Button btnCarregar;
        private Label lblTime;
        private TextBox tbTarefa;
        private DataGridView dataGridView1;
        private Label label1;
        private Button btnFecharCSV;
        private Button BtnSair;
        private Button btnSalvarCSV;
    }
}
