﻿namespace Booking.API.Services
{
    public interface IMessageProducer
    {
        public void PublishMessage<T>(T message);
    }
}