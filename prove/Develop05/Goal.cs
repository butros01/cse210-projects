public abstract class Goal
    {
        protected string name;
        protected bool isComplete;
        protected int points;
        protected string description;

        public Goal(string name, string description, int points)
        {
            this.name = name;
            this.description =description;
            this.points = points;
            isComplete = false;
        }

        public string Name
        {
            get { return name; }
        }

        public bool IsComplete
        {
            get { return isComplete; }
        }

        public int Points
        {
            get { return points; }
        }
        public string Description
        {
            get {return description;}
        }

        public abstract int RecordEvent(int count);
    }