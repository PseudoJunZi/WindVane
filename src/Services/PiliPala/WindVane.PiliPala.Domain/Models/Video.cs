﻿using System;
using System.Collections.Generic;
using System.Text;
using WindVane.Domain.Entities;
using WindVane.Domain.Interfaces;

namespace WindVane.PiliPala.Domain.Models
{
    public class Video : Entity, IAggregateRoot
    {
        public Video()
        {
            Id = Guid.NewGuid();
            Created = DateTime.Now;
        }
        public Guid CategoryId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
