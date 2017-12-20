using System;

namespace Xperiments.DesignPatterns.Bridge.Models
{
    public interface IMensagem 
    {
        IEnviador enviador {get; set;}
        string Formata();
        void Envia();
        
    }
}