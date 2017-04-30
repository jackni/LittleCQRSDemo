﻿using SanBox.DomainModel;
using SanBoxApi.MessageBus;
using SandBox.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace SanBoxApi.Controllers
{
    public class DispatchController : ApiController
    {
        private ICommandBus<DispatchCommand> _cmdBus;

        public DispatchController(ICommandBus<DispatchCommand> cmdBus)
        {
            //we will inject the command bus here.
            _cmdBus = cmdBus;
        }

        [HttpPost]
        [Route("api/Dispatch/SendNotification")]
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
            catch(Exception ex)
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