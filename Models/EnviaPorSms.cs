using System;

namespace Xperiments.DesignPatterns.Bridge.Models
{
    public class EnviaPorSms : IEnviador
    {
        public void Envia(IMensagem mensagem)
        {
            Console.WriteLine("Enviando msg por sms");
            Console.WriteLine(mensagem.Formata());

        }
    }
}