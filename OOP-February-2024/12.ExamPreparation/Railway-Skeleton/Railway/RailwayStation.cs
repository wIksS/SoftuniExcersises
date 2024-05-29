namespace Railway
{
    public class RailwayStation
    {
        private string name;
        private Queue<string> arrivalTrains;
        private Queue<string> departureTrains;

        public RailwayStation(string name)
        {
            Name = name;
            arrivalTrains = new Queue<string>();
            departureTrains = new Queue<string>();
        }

        public string Name
        {
            get => name;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cannot be null or empty!");
                }
                name = value;
            }
        }

        public Queue<string> ArrivalTrains => arrivalTrains;

        public Queue<string> DepartureTrains => departureTrains;

        public void NewArrivalOnBoard(string trainInfo)
        {
            arrivalTrains.Enqueue(trainInfo);
        }

        public string TrainHasArrived(string trainInfo)
        {
            if(arrivalTrains.Peek() != trainInfo)
            {
                return $"There are other trains to arrive before {trainInfo}.";
            }
            departureTrains.Enqueue(arrivalTrains.Dequeue());

            return $"{trainInfo} is on the platform and will leave in 5 minutes.";
        }

        public bool TrainHasLeft(string trainInfo)
        {
            if(departureTrains.Peek() == trainInfo)
            {
                departureTrains.Dequeue();
                return true ;
            }
            return false ;
        }
    }
}
