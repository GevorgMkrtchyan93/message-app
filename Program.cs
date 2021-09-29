using System;
using System.Collections.Generic;

namespace MessageApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Notification notificationEmail = new Notification(new Email());
            Notification notificationSMS = new Notification(new SMS());
            Notification notificationEnvelop = new Notification((IMessage)new Envelop());
            Notification notificationMMS = new Notification(new MMS());
            Notification notificationDrone = new Notification((IMessage)new Drone());

            List<Notification> notifications = new List<Notification>();

            notifications.Add(notificationEmail);
            notifications.Add(notificationSMS);
            notifications.Add(notificationEnvelop);
            notifications.Add(notificationMMS);
            notifications.Add(notificationDrone);

            for (int i = 0; i < notifications.Count; i++)
            {
                notifications[i].DoNotify();
            }

            List<Notification> notifications1 = new List<Notification>();
            Notification notificationEnvelop1 = new Notification((IPhysicalMessage)new Envelop());
            Notification notificationDrone1 = new Notification((IPhysicalMessage)new Drone());
            notifications1.Add(notificationEnvelop1);
            notifications1.Add(notificationDrone1);

            for (int i = 0; i < notifications1.Count; i++)
            {
                notifications1[i].DoNotifyPhysical();
            }
        }
    }
}
