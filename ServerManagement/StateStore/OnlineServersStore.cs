namespace ServerManagement.StateStore
{
    public class OnlineServersStore : Observer
    {
        private Dictionary<string, int> _serversOnline = new Dictionary<string, int>();

        public int GetNumberServersOnline(string city)
        {
            if (_serversOnline.ContainsKey(city))
            {
                return _serversOnline[city];
            }
            else
            {
                return 0;
            }

        }

        public void SetNumbersServersOnline(string city, int number)
        {
            if (_serversOnline.ContainsKey(city))
            {
                _serversOnline[city] = number;
            }
            else
            {
                _serversOnline.Add(city, number);
            }

            base.BroadcastStateChange();
        }

    }
}
