﻿using System;

namespace CustomerSubscriptionAPIClient.Models
{
    public class Customer
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
    }
}