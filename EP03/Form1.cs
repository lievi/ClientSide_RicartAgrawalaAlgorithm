using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibUDP;

namespace EP03
{
    public partial class Form1 : Form
    {
        private int seqLocal = 0;
        private int seqExt = 0;
        private byte id;
        private bool critic = false;
        private bool[] Aguardando = { false, false };
        private int[] repliesEspera = new int[2];
        int temp = 0;
        int temp2 = 0;
        UDPSocket socket;
        public Form1()
        {
            InitializeComponent();
            Controlar.Enabled = false;
            Pausar.Enabled = false;
            Reiniciar.Enabled = false;
            Liberar.Enabled = false;
        }

        private void MensagemRecebida(byte[] buffer, int size, string ip, int port)
        {
            if (buffer[0] == 0 && buffer[1] != id)
            {
                if (seqExt < buffer[2])
                    seqExt = buffer[2];

                if (critic == true)
                {
                    //Erro
                    if (repliesEspera[0] != port && repliesEspera[1] != port)
                    {
                        repliesEspera[temp2] = port;
                        temp2++;
                    }
                }
                else if (Aguardando[0] == false && Aguardando[1] == false)
                {
                    //Enviar
                    buffer[0] = 1;
                    socket.Send(buffer, ip, port);
                }
                else if (seqLocal < buffer[2])
                {
                    //Erro
                    if (repliesEspera[0] != port && repliesEspera[1] != port)
                    {
                        repliesEspera[temp2] = port;
                        temp2++;
                    }
                }
                else if (seqLocal > buffer[2])
                {
                    //Enviar
                    buffer[0] = 1;
                    socket.Send(buffer, ip, port);
                }
                else if (id < buffer[1])
                {
                    //Erro
                    if (repliesEspera[0] != port && repliesEspera[1] != port)
                    {
                        repliesEspera[temp2] = port;
                        temp2++;
                    }
                }
                else
                {
                    //Enviar
                    buffer[0] = 1;
                    socket.Send(buffer, ip, port);
                }
            }
            else if (buffer[0] == 1)
            {
                //Necessário verificar o reply de todos os processos que foram enviaram
                Aguardando[temp] = false;
                if (Aguardando[0] == false && Aguardando[1] == false)
                {
                    critic = true;
                    label3.Text = "Pode";
                    temp = 0;
                    Liberar.Enabled = true;
                    Pausar.Enabled = true;
                    Reiniciar.Enabled = true;
                }
                else
                    temp++;
            }
        }

        private void Iniciar_Click(object sender, EventArgs e)
        {
            //Atualizando relógio
            if (seqLocal <= seqExt)
                seqLocal = seqExt + 1;

            //Enviando request com minha sequencia(relógio) para TODOS os processos

            byte[] msg = { 0, id, Convert.ToByte(seqLocal) };

            //Temporário
            if(Aguardando[0] != true && Aguardando[1] != true)
            {
                Aguardando[0] = true;
                Aguardando[1] = true;
                socket.Send(msg, "127.0.0.1", 12001);
                socket.Send(msg, "127.0.0.1", 12002);
                socket.Send(msg, "127.0.0.1", 12003);
            }
        }

        private void InicProc_Click(object sender, EventArgs e)
        {           
            id = Convert.ToByte(txtID.Text);
            socket = new UDPSocket(MensagemRecebida, 12000 + Convert.ToInt16(txtID.Text));
            Controlar.Enabled = true;
            InicProc.Enabled = false;
        }

        private void Reiniciar_Click(object sender, EventArgs e)
        {
            if (critic)
            {
                byte[] batata = { 0 };
                socket.Send(batata, "127.0.0.1", 7200);
            }
        }

        private void Pausar_Click(object sender, EventArgs e)
        {
            if (critic)
            {
                byte[] batata = { 1 };
                socket.Send(batata, "127.0.0.1", 7200);
            }
        }

        private void Liberar_Click(object sender, EventArgs e)
        {
            critic = false;
            label3.Text = "Liberado";
            byte[] batata = { 1 };

            if (repliesEspera[0] != 0)
                socket.Send(batata, "127.0.0.1", repliesEspera[0]);
            if (repliesEspera[1] != 0)
                socket.Send(batata, "127.0.0.1", repliesEspera[1]);

            temp2 = 0;
            temp = 0;
            repliesEspera[0] = 0;
            repliesEspera[1] = 0;

            Liberar.Enabled = false;
            Pausar.Enabled = false;
            Reiniciar.Enabled = false;
        }
    }
}
