public abstract class Goal
    {
        private string name;
        protected bool isComplete;
        private int points;
        private string description;

        public Goal(string name, string description, int points)
        {
            this.name = name;
            this.description =description;
            this.points = points;
            isComplete = false;
        }

        public string Name()
        {
            return name;
        }

        public bool IsComplete()
        {
            return isComplete;
        }

        public int Points()
        {
            return points;
        }
        public string Description()
        {
            return description;
        }

        public abstract int RecordEvent(int count);
    }