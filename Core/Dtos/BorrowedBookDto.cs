﻿using LibraryManagementSystem.Core.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Entity
{
    public class BorrowedBookDto:BaseDto
    {

        public int UserId { get; set; }
        public int BookId { get; set; }
        public DateTime BorrowedDate {  get; set; }
        public DateTime Deadline {  get; set; }
        public bool GivingBack { get; set; }
    }
}