using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRocky.Domain.Core.Events
{
    //core message object
    //this when we're gonna need our MediatR Nuget package
    //the idea is any request using MediateR is expecting a boolean back True or False that the command is sent or the request is processed and so on
    public abstract class Message: IRequest<bool>
    {
        //we can add any properties to the message like Name, I added here
        public string MessageType { get; protected set; }//since it's abstract so it has protected setter
        public Message()
        {
            MessageType = GetType().Name;//Get type of message by using Reflection.GetType
        }
    }
}
