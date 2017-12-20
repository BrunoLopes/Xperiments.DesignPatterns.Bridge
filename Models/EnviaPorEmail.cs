using System;

namespace Xperiments.DesignPatterns.Bridge.Models
{
    public class EnviaPorEmail : IEnviador
    {
        public void Envia(IMensagem mensagem)
        {
            Console.WriteLine("Enviando msg por e-mail");
            Console.WriteLine(mensagem.Formata());

        }
    }
}