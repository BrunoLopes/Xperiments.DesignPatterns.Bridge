using System;

namespace Xperiments.DesignPatterns.Bridge.Models
{
    public class MensagemCliente : IMensagem
    {
        private string nome;
        public IEnviador enviador { get; set; }

        public MensagemCliente(string nome, IEnviador enviador)
        {
            this.nome = nome;
            this.enviador = enviador;
        }

        public void Envia()
        {
            enviador.Envia(this);
        }

        public string Formata()
        {
            return $"Enviando a mensagem para o cliente { nome }";
        }
    }
}