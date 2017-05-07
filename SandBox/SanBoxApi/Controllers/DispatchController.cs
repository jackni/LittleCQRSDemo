using SanBox.DomainModel;
using SanBox.MessageBus;
using SanBoxApi.Models;
using SanBoxApi.Services;
using SandBox.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;

namespace SanBoxApi.Controllers
{
    public class DispatchController : ApiController
    {
        private ICommandBus _cmdBus;
        private INotificationService _pushNotificationService;

        public DispatchController(ICommandBus cmdBus, INotificationService pushNotificationService)
        {
            //we will inject the command bus here.
            _cmdBus = cmdBus;
            _pushNotificationService = pushNotificationService;
        }

        [HttpPost]
        [Route("api/Dispatch/SendNotification")]
        [ResponseType(typeof(DispatchCommand))]
        public async Task<IHttpActionResult> SendNotification(DispatchCommand command)
        {

            //vaidate command and put on the bus.
            try
            {
                if (!IsCommandValidate(command))
                {
                    throw new InvalidOperationException("Command is not validate");
                }
                await _cmdBus.QueueCommand(command);
                
            }
            catch(AggregateException ex)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw;
            }
            return Ok();
        }

        [HttpPost]
        [Route("api/Dispatch/SendPushNotification")]
        [ResponseType(typeof(PushMessage))]
        public async Task<IHttpActionResult> SendPushNotification(PushMessage pushMessage)
        {
            try
            {
                await Task.Run(() => { _pushNotificationService.SendPushNotification(pushMessage); });
                //_pushNotificationService.SendPushNotification(pushMessage);
            }
            catch (AggregateException ex)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw;
            }
            return Ok();
        }

        private bool IsCommandValidate(DispatchCommand command)
        {

            return true;
        }
    }
}
