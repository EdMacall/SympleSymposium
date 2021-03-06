﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConferenceApp.Services.Models
{
    public class SpeakerDTO
    {
        public int Id { get; set; }
        public int ConferenceId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public int? AddressId { get; set; }
        public string Company { get; set; }
        public string CoStreet { get; set; }
        public string CoCity { get; set; }
        public string CoState { get; set; }
        public string CoZip { get; set; }
        public string Bio { get; set; }
        public string ImageUrl { get; set; }
        //public IList<SlotDTO> Slots { get; set; }
    }
}
