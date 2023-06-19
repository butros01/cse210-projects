public abstract class Goal
    {
        protected string name;
        protected bool isComplete;
        protected int points;

        public Goal(string name, int points)
        {
            this.name = name;
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

        public abstract int RecordEvent(int count);
    }