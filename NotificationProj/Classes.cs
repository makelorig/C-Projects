using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatchExample
{
    public class NotifationContent
    {
        private Reciver _reciver;
        private Sender _sender;
        private INotifyStrat _strat;

        public NotifationContent(Sender sender, Reciver reciver,INotifyStrat strat)
        {
            _reciver = reciver;
            _sender = sender;
            //_reciver.SetNotifiyStrat(strat);
            _strat = strat;
        }

        public void info(string message)
        {
            Console.WriteLine($"Отправитель: {_sender.Name}, отправил сообщение: {_reciver.Name},с таким текстом: {message} "+ /*_reciver.ReciveMessageFrom(message)*/_strat.ToString());
        }


    }
    public class Sender
    {
        public Sender(string name)
        {
            Name = name;
        }

        public string Name { get; set; }
    }
    public interface INotifyStrat
    {
        public void Notify(string message);
    }
    public class EmailNotify : INotifyStrat
    {
        public void Notify(string message)
        {
            Console.WriteLine($"Сообщение отправлено по email: {message}");
        }
    }
    public class SmsNotify : INotifyStrat
    {
        public void Notify(string message)
        {
            Console.WriteLine($"Сообщение отправлено по sms: {message}");
        }
    }
    public class PushNotify : INotifyStrat
    {
        public void Notify(string message)
        {
            Console.WriteLine($"Сообщение отправлено по пуш смс: {message}");
        }
    }
    public class Reciver
    {
        public string Name { get; set; }
        private INotifyStrat _strat;

        public Reciver(string name)
        {
            Name = name;
        }

        public void SetNotifiyStrat(INotifyStrat notifyStrat)
        {
            _strat = notifyStrat;
        }
        public void ReciveMessageFrom(string message)
        {
            _strat.Notify(message);
        }

    }
}