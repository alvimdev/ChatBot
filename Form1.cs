using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AIMLbot;

namespace ChatBot
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bot AI = new Bot(); //Cria o objeto bot
            AI.loadSettings(); //Carrega as configurações do AIML
            AI.loadAIMLFromFiles(); //Carrega as funlções do AIML pelo arquivo
            AI.isAcceptingUserInput = false; //Bloqueia a leitura do user

            User Mine = new User("Your Name", AI); //Cria o objeto usuário
            AI.isAcceptingUserInput = true; //Libera a leitura do user
            Request rec = new Request(textBox1.Text, Mine, AI); //Cria o objeto input
            Result res = AI.Chat(rec); //Cria o objeto output
            textBox2.Text = res.Output; //Imprime o output na aba bot
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
