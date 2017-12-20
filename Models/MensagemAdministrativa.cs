using System;

namespace Xperiments.DesignPatterns.Bridge.Models
{
    public class MensagemAdministrativa : IMensagem
    {
        private string nome;
        public IEnviador enviador { get; set; }

        public MensagemAdministrativa(string nome, IEnviador enviador)
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
            return $"Enviando a mensagem para o administrador { nome }";
        }
    }
}