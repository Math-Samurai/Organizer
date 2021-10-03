using System;

namespace Organizer
{
    public class Objective
    {
        protected string name;
        protected string description;
        protected DateTime deadline;
        public Objective(string name, string description, DateTime deadline)
        {   
            this.name = name;
            this.description = description;
            this.deadline = deadline;
        }
        public string Name
        {
            get
            {
                return name;
            }
        }
        public string Description
        {
            get
            {
                return description;
            }
        }
        public DateTime DeadLine
        {
            get
            {
                return deadline;
            }
            set
            {
                deadline = value;
            }
        }
    }
}
