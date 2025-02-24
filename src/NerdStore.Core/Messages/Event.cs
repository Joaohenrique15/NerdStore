﻿using MediatR;
using System;

namespace NerdStore.Core.Messages
{
    public abstract class Event: Message, INotification
    {
        protected Event()
        {
            TimeStamp = DateTime.Now;
        }

        public DateTime TimeStamp { get; private set; }
    }
}
