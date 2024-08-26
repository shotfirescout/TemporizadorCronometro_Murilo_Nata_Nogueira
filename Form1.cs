using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.Windows.Forms;

namespace TemporizadorCronomoetro
{
   
    public enum ModoTimer
    {
        CRONÔMETRO,
        TEMPORIZADOR
    }
    
    public partial class Form1 : Form
    {
        private ModoTimer tipo = ModoTimer.CRONÔMETRO;
        private readonly int ERROR_SEGUNDOS = 10, ERROR_MINUTOS = 20;
        private int h = 0, m = 0, s = 0;
        private SoundPlayer alarm = new SoundPlayer("Alarm Clock Sound.wav");

        public Form1()
        {
            InitializeComponent();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            switch (tipo)
            {
                case ModoTimer.CRONÔMETRO:
                    logicaCronometro();
                    break;
                case ModoTimer.TEMPORIZADOR:
                    logicaTemporizador();
                    break;
            }
        }

        private void visibilidadeRedefenir(ModoTimer visibilidade)
        {
            switch (visibilidade)
            {
                case ModoTimer.TEMPORIZADOR:
                    //Botões que vão aparecer
                    btn_redefenir.Visible = true;
                    btn_temporizador.Visible = false;
                    btn_cronometro.Visible = true;
                    //Campos de texto que vão aparecer
                    textHoras.Visible = true;
                    textSegundos.Visible = true;
                    textMinutos.Visible = true;
                    //Lables que vão aparecer
                    redefineSegundos.Visible = true;
                    redefineMinutos.Visible = true;
                    redefineHoras.Visible = true;
                    break;
                case ModoTimer.CRONÔMETRO:
                    btn_cronometro.Visible = false;
                    btn_redefenir.Visible = false;
                    btn_temporizador.Visible = true;

                    //Campos de texto que vão aparecer
                    textHoras.Visible = false;
                    textSegundos.Visible = false;
                    textMinutos.Visible = false;
                    //Lables que vão aparecer
                    redefineSegundos.Visible = false;
                    redefineMinutos.Visible = false;
                    redefineHoras.Visible = false;
                    break;
            }
        }

        private String formataTempo()
        {
            String textoAtual = "";
            if (h < 10)
            {
                textoAtual += "0" + h;
            }
            else
            {
                textoAtual += h;
            }

            if (m < 10)
            {
                textoAtual += ":0" + m;
            }
            else
            {
                textoAtual += ":" + m;
            }

            if (s < 10)
            {
                textoAtual += ":0" + s;
            }
            else
            {
                textoAtual += ":" + s;
            }

            return textoAtual;
        }

        private void alterarModo(ModoTimer modoSelecionado)
        {
            tipo = modoSelecionado;
            visibilidadeRedefenir(tipo);
        }

        private void pararTimer()
        {
            timer2.Dispose();
            h = 0;
            m = 0;
            s = 0;
            temporizador.Text = $"00:00:00";
        }

        private void logicaTemporizador()
        {
            String texto = formataTempo();

            temporizador.Text = texto;
            
            if (s == 0 && m != 0)
            {
                s = 60;
                m--;
            }
            else if (m == 0 && h != 0)
            {
                m = 59;
                s = 60;
                h--;
            }
            s--;


            if (s == -1 && m == 0 && h == 0)
            {
                timer2.Stop();
                timerPisca.Start();
                alarm.Play();
            }
        }

        private void piscaTempo()
        {
            if(temporizador.ForeColor == System.Drawing.Color.Red)
            {
                temporizador.ForeColor = System.Drawing.Color.Black;
            } else
            {
                temporizador.ForeColor = System.Drawing.Color.Red;
            }

        }

        private void logicaCronometro()
        {
            String texto = formataTempo();

            temporizador.Text = texto;

            s++;
            if (s == 60)
            {
                s = 0;
                m++;
            }
            else if (m == 60)
            {
                m = 0;
                h++;
            }
        }

        private void btn_iniciar_Click(object sender, EventArgs e)
        {
            if(tipo == ModoTimer.TEMPORIZADOR)
            {
                if (s != 0 || m != 0 || h != 0)
                {
                    timer2.Start();
                } else
                {
                    MessageBox.Show("Porfavor coloque os valores para começar o timer");
                }
            } else
            {
                timer2.Start();
            }
            
        }

        private void btn_pausar_Click(object sender, EventArgs e)
        {
            timer2.Stop();
        }

        private void btn_cronometro_Click(object sender, EventArgs e)
        {
            alterarModo(ModoTimer.CRONÔMETRO);
            modoTimerSelecionado.Text = tipo.ToString();
            pararTimer();
        }

        private void btn_temporizador_Click(object sender, EventArgs e)
        {
            alterarModo(ModoTimer.TEMPORIZADOR);
            modoTimerSelecionado.Text = tipo.ToString();
            pararTimer();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            alterarModo(ModoTimer.CRONÔMETRO);
        }

        private void timerPisca_Tick(object sender, EventArgs e)
        {
            piscaTempo();
        }

        private void btn_parar_Click(object sender, EventArgs e)
        {
            pararTimer();
            if(tipo == ModoTimer.TEMPORIZADOR)
            {
                alarm.Stop();
                timerPisca.Stop();
                temporizador.ForeColor = System.Drawing.Color.Black;
            }
        }


        private void btn_redefenir_Click(object sender, EventArgs e)
        {
            if(!textSegundos.Text.Equals(""))
            {
                s = Convert.ToInt32(textSegundos.Text);
            }
            if(!textMinutos.Text.Equals(""))
            {
                m = Convert.ToInt32(textMinutos.Text);
            }

            if(!textHoras.Text.Equals(""))
            {
                h = Convert.ToInt32(textHoras.Text);
            }
            if(s > 59 || s < 0 || m > 59 || m < 0){
                int erroDetectado = -1;
                if(s > 59 || s < 0)
                {
                    erroDetectado = ERROR_SEGUNDOS;
                }
                if(m > 59 || s < 0)
                {
                    erroDetectado = ERROR_MINUTOS;
                }
                exibirErro(erroDetectado);
            } else {
                labelERRO.Visible = false;
                string tempo = formataTempo();
                temporizador.Text = tempo;
            }


        }

        private void exibirErro(int error)
        {
            labelERRO.Visible = true;
            if (error == ERROR_SEGUNDOS)
            {
                labelERRO.Text = "VALOR INVALIDO: SEGUNDOS, LIMITE 59";
            }
            else if (error == ERROR_MINUTOS)
            {
                labelERRO.Text = "VALOR INVALIDO: MINUTOS, LIMITE 59";
            }
            else
            {
                labelERRO.Text = "VALORES INVLAIDOS: MINUTOS, SEGUNDOS (LIMITE 59)";
            }
        }
    }
}
