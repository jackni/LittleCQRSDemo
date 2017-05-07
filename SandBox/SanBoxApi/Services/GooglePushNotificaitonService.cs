using Newtonsoft.Json.Linq;
using PushSharp.Google;
using SanBoxApi.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace SanBoxApi.Services
{
    public class GooglePushNotificaitonService : INotificationService
    {
        #region Members

        private GcmConfiguration _gcmConfig;
        private GcmServiceBroker _gcmBroker;

        #endregion

        #region Constructors
        public GooglePushNotificaitonService()
        {
            string fcmSenderId = ConfigurationManager.AppSettings["FCMSenderId"];
            string fcmSenderPwd = ConfigurationManager.AppSettings["FCMSenderPwd"];
            string googleAndoridAppPkgName = ConfigurationManager.AppSettings["andoridAppPkgName"];

            _gcmConfig = new GcmConfiguration(fcmSenderId, fcmSenderPwd, googleAndoridAppPkgName);

            _gcmBroker = new GcmServiceBroker(_gcmConfig);
            _gcmBroker.OnNotificationFailed += _gcmBroker_OnNotificationFailed;
            _gcmBroker.OnNotificationSucceeded += _gcmBroker_OnNotificationSucceeded;
        }

        private void _gcmBroker_OnNotificationSucceeded(GcmNotification notification)
        {
            throw new NotImplementedException();
        }

        private void _gcmBroker_OnNotificationFailed(GcmNotification notification, AggregateException exception)
        {
            throw new NotImplementedException();
        }
        public void SendPushNotification(PushMessage pushMessage) //the message could be a json object.
        {
            _gcmBroker.Start();

            // Queue a notification to send
            _gcmBroker.QueueNotification(new GcmNotification
            {
                RegistrationIds = new List<string> { pushMessage.PushToken },
                Data = JObject.Parse(string.Format("{ \"Test\" : \"{0}\" }", pushMessage.Message))
            });

            // Stop the broker, wait for it to finish   
            // This isn't done after every message, but after you're
            // done with the broker
            _gcmBroker.Stop();
        }
        #endregion

        #region Methods

        #endregion
    }
}