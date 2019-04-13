﻿using System;
using System.Collections.Generic;
using System.Text;

namespace RentACar.Control
{
    public interface ICalendarConnector
    {
        void AddAppointment(DateTime startTime, DateTime endTime, string subject, string location, string details, bool isAllDay);
    }
}
