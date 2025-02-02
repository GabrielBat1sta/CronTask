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
            btnZerar = new Button();
            btnNovo = new Button();
            btnSalvar = new Button();
            btnCarregar = new Button();
            lblTime = new Label();
            tbTarefa = new TextBox();
            ListTarefas = new ListBox();
            SuspendLayout();
            // 
            // btnIniciar
            // 
            btnIniciar.Location = new Point(24, 36);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(75, 23);
            btnIniciar.TabIndex = 0;
            btnIniciar.Text = "Iniciar";
            btnIniciar.UseVisualStyleBackColor = true;
            btnIniciar.Click += btnIniciar_Click;
            // 
            // btnZerar
            // 
            btnZerar.Location = new Point(24, 69);
            btnZerar.Name = "btnZerar";
            btnZerar.Size = new Size(75, 23);
            btnZerar.TabIndex = 2;
            btnZerar.Text = "Zerar";
            btnZerar.UseVisualStyleBackColor = true;
            btnZerar.Click += btnZerar_Click_1;
            // 
            // btnNovo
            // 
            btnNovo.Location = new Point(399, 12);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(75, 23);
            btnNovo.TabIndex = 3;
            btnNovo.Text = "Nova Tarefa";
            btnNovo.UseVisualStyleBackColor = true;
            btnNovo.Click += btnNovo_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(399, 56);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 23);
            btnSalvar.TabIndex = 4;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnCarregar
            // 
            btnCarregar.Location = new Point(399, 91);
            btnCarregar.Name = "btnCarregar";
            btnCarregar.Size = new Size(75, 23);
            btnCarregar.TabIndex = 5;
            btnCarregar.Text = "Carregar";
            btnCarregar.UseVisualStyleBackColor = true;
            btnCarregar.Click += btnCarregar_Click_1;
            // 
            // lblTime
            // 
            lblTime.AutoSize = true;
            lblTime.Location = new Point(124, 40);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(49, 15);
            lblTime.TabIndex = 6;
            lblTime.Text = "00:00:00";
            // 
            // tbTarefa
            // 
            tbTarefa.Location = new Point(480, 12);
            tbTarefa.Name = "tbTarefa";
            tbTarefa.Size = new Size(308, 23);
            tbTarefa.TabIndex = 7;
            // 
            // ListTarefas
            // 
            ListTarefas.FormattingEnabled = true;
            ListTarefas.ItemHeight = 15;
            ListTarefas.Location = new Point(480, 56);
            ListTarefas.Name = "ListTarefas";
            ListTarefas.Size = new Size(308, 379);
            ListTarefas.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ListTarefas);
            Controls.Add(tbTarefa);
            Controls.Add(lblTime);
            Controls.Add(btnCarregar);
            Controls.Add(btnSalvar);
            Controls.Add(btnNovo);
            Controls.Add(btnZerar);
            Controls.Add(btnIniciar);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnIniciar;
        private Button btnZerar;
        private Button btnNovo;
        private Button btnSalvar;
        private Button btnCarregar;
        private Label lblTime;
        private TextBox tbTarefa;
        private ListBox ListTarefas;
    }
}
