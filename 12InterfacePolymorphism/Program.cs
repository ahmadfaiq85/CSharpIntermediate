﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacePolymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            var encoder = new VideoEncoder();
            encoder.RegisterNotificationChannel(new SMSNotificationChannel());
            encoder.RegisterNotificationChannel(new MailNotificationChannel());
            encoder.Encode(new Video());
             
        }
    }
}
