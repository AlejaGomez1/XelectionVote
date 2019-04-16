﻿namespace XelectionVote.Web.Data
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Entities;
    public interface IRepository
    {
        void AddEvent(Event @event);

        bool EventExists(int id);

        Event GetEvent(int Id);

        IEnumerable<Event> GetEvents();

        void RemoveEvent(Event @event);

        Task<bool> SaveAllAsync();

        void UpdateEvent(Event @event);
    }
}