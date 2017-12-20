using System;
using System.Linq.Expressions;
using Xperiments.DesignPatterns.Bridge.Models;

namespace Xperiments.DesignPatterns.Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            IMensagem email = new MensagemAdministrativa("Bruno", new EnviaPorEmail());
            email.Envia();

            IMensagem sms = new MensagemCliente("Lopes", new EnviaPorSms());
            sms.Envia();
        }
    }
}
