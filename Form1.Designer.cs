namespace TemporizadorCronomoetro
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.temporizador = new System.Windows.Forms.Label();
            this.btn_iniciar = new System.Windows.Forms.Button();
            this.btn_parar = new System.Windows.Forms.Button();
            this.btn_pausar = new System.Windows.Forms.Button();
            this.btn_redefenir = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.btn_cronometro = new System.Windows.Forms.Button();
            this.btn_temporizador = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.modoTimerSelecionado = new System.Windows.Forms.Label();
            this.textSegundos = new System.Windows.Forms.TextBox();
            this.textMinutos = new System.Windows.Forms.TextBox();
            this.textHoras = new System.Windows.Forms.TextBox();
            this.redefineSegundos = new System.Windows.Forms.Label();
            this.redefineMinutos = new System.Windows.Forms.Label();
            this.redefineHoras = new System.Windows.Forms.Label();
            this.labelERRO = new System.Windows.Forms.Label();
            this.timerPisca = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // temporizador
            // 
            this.temporizador.AutoSize = true;
            this.temporizador.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.temporizador.Location = new System.Drawing.Point(209, 115);
            this.temporizador.Name = "temporizador";
            this.temporizador.Size = new System.Drawing.Size(141, 36);
            this.temporizador.TabIndex = 0;
            this.temporizador.Text = "00:00:00";
            // 
            // btn_iniciar
            // 
            this.btn_iniciar.Location = new System.Drawing.Point(147, 195);
            this.btn_iniciar.Name = "btn_iniciar";
            this.btn_iniciar.Size = new System.Drawing.Size(75, 23);
            this.btn_iniciar.TabIndex = 1;
            this.btn_iniciar.Text = "Iniciar";
            this.btn_iniciar.UseVisualStyleBackColor = true;
            this.btn_iniciar.Click += new System.EventHandler(this.btn_iniciar_Click);
            // 
            // btn_parar
            // 
            this.btn_parar.Location = new System.Drawing.Point(340, 195);
            this.btn_parar.Name = "btn_parar";
            this.btn_parar.Size = new System.Drawing.Size(75, 23);
            this.btn_parar.TabIndex = 2;
            this.btn_parar.Text = "Parar";
            this.btn_parar.UseVisualStyleBackColor = true;
            this.btn_parar.Click += new System.EventHandler(this.btn_parar_Click);
            // 
            // btn_pausar
            // 
            this.btn_pausar.Location = new System.Drawing.Point(246, 195);
            this.btn_pausar.Name = "btn_pausar";
            this.btn_pausar.Size = new System.Drawing.Size(75, 23);
            this.btn_pausar.TabIndex = 3;
            this.btn_pausar.Text = "Pausar";
            this.btn_pausar.UseVisualStyleBackColor = true;
            this.btn_pausar.Click += new System.EventHandler(this.btn_pausar_Click);
            // 
            // btn_redefenir
            // 
            this.btn_redefenir.Location = new System.Drawing.Point(456, 138);
            this.btn_redefenir.Name = "btn_redefenir";
            this.btn_redefenir.Size = new System.Drawing.Size(86, 23);
            this.btn_redefenir.TabIndex = 4;
            this.btn_redefenir.Text = "Redefenir";
            this.btn_redefenir.UseVisualStyleBackColor = true;
            this.btn_redefenir.Click += new System.EventHandler(this.btn_redefenir_Click);
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // btn_cronometro
            // 
            this.btn_cronometro.Location = new System.Drawing.Point(4, 12);
            this.btn_cronometro.Name = "btn_cronometro";
            this.btn_cronometro.Size = new System.Drawing.Size(109, 54);
            this.btn_cronometro.TabIndex = 5;
            this.btn_cronometro.Text = "Cronomêtro";
            this.btn_cronometro.UseVisualStyleBackColor = true;
            this.btn_cronometro.Click += new System.EventHandler(this.btn_cronometro_Click);
            // 
            // btn_temporizador
            // 
            this.btn_temporizador.Location = new System.Drawing.Point(4, 86);
            this.btn_temporizador.Name = "btn_temporizador";
            this.btn_temporizador.Size = new System.Drawing.Size(109, 45);
            this.btn_temporizador.TabIndex = 6;
            this.btn_temporizador.Text = "Temporizador";
            this.btn_temporizador.UseVisualStyleBackColor = true;
            this.btn_temporizador.Click += new System.EventHandler(this.btn_temporizador_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1, 229);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Modo de timer:";
            // 
            // modoTimerSelecionado
            // 
            this.modoTimerSelecionado.AutoSize = true;
            this.modoTimerSelecionado.Location = new System.Drawing.Point(97, 229);
            this.modoTimerSelecionado.Name = "modoTimerSelecionado";
            this.modoTimerSelecionado.Size = new System.Drawing.Size(105, 16);
            this.modoTimerSelecionado.TabIndex = 8;
            this.modoTimerSelecionado.Text = "CRONÔMETRO";
            // 
            // textSegundos
            // 
            this.textSegundos.Location = new System.Drawing.Point(456, 9);
            this.textSegundos.Name = "textSegundos";
            this.textSegundos.Size = new System.Drawing.Size(100, 22);
            this.textSegundos.TabIndex = 9;
            // 
            // textMinutos
            // 
            this.textMinutos.Location = new System.Drawing.Point(456, 47);
            this.textMinutos.Name = "textMinutos";
            this.textMinutos.Size = new System.Drawing.Size(100, 22);
            this.textMinutos.TabIndex = 10;
            // 
            // textHoras
            // 
            this.textHoras.Location = new System.Drawing.Point(456, 83);
            this.textHoras.Name = "textHoras";
            this.textHoras.Size = new System.Drawing.Size(100, 22);
            this.textHoras.TabIndex = 11;
            // 
            // redefineSegundos
            // 
            this.redefineSegundos.AutoSize = true;
            this.redefineSegundos.Location = new System.Drawing.Point(378, 12);
            this.redefineSegundos.Name = "redefineSegundos";
            this.redefineSegundos.Size = new System.Drawing.Size(72, 16);
            this.redefineSegundos.TabIndex = 12;
            this.redefineSegundos.Text = "Segundos:";
            // 
            // redefineMinutos
            // 
            this.redefineMinutos.AutoSize = true;
            this.redefineMinutos.Location = new System.Drawing.Point(394, 50);
            this.redefineMinutos.Name = "redefineMinutos";
            this.redefineMinutos.Size = new System.Drawing.Size(56, 16);
            this.redefineMinutos.TabIndex = 13;
            this.redefineMinutos.Text = "Minutos:";
            // 
            // redefineHoras
            // 
            this.redefineHoras.AutoSize = true;
            this.redefineHoras.Location = new System.Drawing.Point(403, 86);
            this.redefineHoras.Name = "redefineHoras";
            this.redefineHoras.Size = new System.Drawing.Size(47, 16);
            this.redefineHoras.TabIndex = 14;
            this.redefineHoras.Text = "Horas:";
            // 
            // labelERRO
            // 
            this.labelERRO.AutoSize = true;
            this.labelERRO.ForeColor = System.Drawing.Color.Red;
            this.labelERRO.Location = new System.Drawing.Point(97, 282);
            this.labelERRO.Name = "labelERRO";
            this.labelERRO.Size = new System.Drawing.Size(364, 16);
            this.labelERRO.TabIndex = 15;
            this.labelERRO.Text = "VALORES INVLAIDOS: MINUTOS, SEGUNDOS (LIMITE 59)";
            this.labelERRO.Visible = false;
            // 
            // timerPisca
            // 
            this.timerPisca.Interval = 500;
            this.timerPisca.Tick += new System.EventHandler(this.timerPisca_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 323);
            this.Controls.Add(this.labelERRO);
            this.Controls.Add(this.redefineHoras);
            this.Controls.Add(this.redefineMinutos);
            this.Controls.Add(this.redefineSegundos);
            this.Controls.Add(this.textHoras);
            this.Controls.Add(this.textMinutos);
            this.Controls.Add(this.textSegundos);
            this.Controls.Add(this.modoTimerSelecionado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_temporizador);
            this.Controls.Add(this.btn_cronometro);
            this.Controls.Add(this.btn_redefenir);
            this.Controls.Add(this.btn_pausar);
            this.Controls.Add(this.btn_parar);
            this.Controls.Add(this.btn_iniciar);
            this.Controls.Add(this.temporizador);
            this.Name = "Form1";
            this.Text = "Temporizador/Cronômetro";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label temporizador;
        private System.Windows.Forms.Button btn_iniciar;
        private System.Windows.Forms.Button btn_parar;
        private System.Windows.Forms.Button btn_pausar;
        private System.Windows.Forms.Button btn_redefenir;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button btn_cronometro;
        private System.Windows.Forms.Button btn_temporizador;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label modoTimerSelecionado;
        private System.Windows.Forms.TextBox textSegundos;
        private System.Windows.Forms.TextBox textMinutos;
        private System.Windows.Forms.TextBox textHoras;
        private System.Windows.Forms.Label redefineSegundos;
        private System.Windows.Forms.Label redefineMinutos;
        private System.Windows.Forms.Label redefineHoras;
        private System.Windows.Forms.Label labelERRO;
        private System.Windows.Forms.Timer timerPisca;
    }
}

