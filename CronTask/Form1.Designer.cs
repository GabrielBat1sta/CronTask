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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnIniciar = new Button();
            btnParar = new Button();
            btnAdicionarTarefa = new Button();
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
            btnIniciar.Enabled = false;
            btnIniciar.Location = new Point(12, 12);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(106, 47);
            btnIniciar.TabIndex = 0;
            btnIniciar.Text = "Iniciar";
            btnIniciar.UseVisualStyleBackColor = true;
            btnIniciar.Click += btnIniciar_Click_1;
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
            // btnAdicionarTarefa
            // 
            btnAdicionarTarefa.Location = new Point(491, 51);
            btnAdicionarTarefa.Name = "btnAdicionarTarefa";
            btnAdicionarTarefa.Size = new Size(106, 47);
            btnAdicionarTarefa.TabIndex = 4;
            btnAdicionarTarefa.Text = "Adicionar Tarefa";
            btnAdicionarTarefa.UseVisualStyleBackColor = true;
            btnAdicionarTarefa.Click += btnAdicionarTarefa_Click_1;
            // 
            // btnCarregar
            // 
            btnCarregar.Location = new Point(124, 441);
            btnCarregar.Name = "btnCarregar";
            btnCarregar.Size = new Size(106, 43);
            btnCarregar.TabIndex = 11;
            btnCarregar.Text = "Carregar CSV";
            btnCarregar.Click += btnCarregar_Click;
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
            tbTarefa.Size = new Size(353, 23);
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
            label1.Location = new Point(239, 20);
            label1.Name = "label1";
            label1.Size = new Size(246, 25);
            label1.TabIndex = 10;
            label1.Text = "Informe o nome da tarefa:";
            label1.TextAlign = ContentAlignment.BottomCenter;
            // 
            // btnFecharCSV
            // 
            btnFecharCSV.Location = new Point(239, 441);
            btnFecharCSV.Name = "btnFecharCSV";
            btnFecharCSV.Size = new Size(106, 43);
            btnFecharCSV.TabIndex = 2;
            btnFecharCSV.Text = "Fechar CSV";
            btnFecharCSV.Click += btnFecharCSV_Click;
            // 
            // BtnSair
            // 
            BtnSair.Location = new Point(740, 441);
            BtnSair.Name = "BtnSair";
            BtnSair.Size = new Size(104, 43);
            BtnSair.TabIndex = 1;
            BtnSair.Text = "Sair";
            BtnSair.Click += BtnSair_Click;
            // 
            // btnSalvarCSV
            // 
            btnSalvarCSV.Location = new Point(12, 441);
            btnSalvarCSV.Name = "btnSalvarCSV";
            btnSalvarCSV.Size = new Size(106, 43);
            btnSalvarCSV.TabIndex = 0;
            btnSalvarCSV.Text = "Salvar CSV";
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
            Controls.Add(btnAdicionarTarefa);
            Controls.Add(btnParar);
            Controls.Add(btnIniciar);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "CronTask";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnIniciar;
        private Button btnParar;
        private Button btnAdicionarTarefa;
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
