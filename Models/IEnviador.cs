using System;

namespace Xperiments.DesignPatterns.Bridge.Models
{
    public interface IEnviador 
    {
        void Envia(IMensagem mensagem);
        
    }
}