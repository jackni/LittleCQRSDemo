using SanBoxApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanBoxApi.Services
{
    public interface INotificationService
    {
        void SendPushNotification(PushMessage pushMessage);
    }
}
