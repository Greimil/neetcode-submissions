public class TimeMap
    {

        public class TimeValue
        {
            public string value;
            public int timestamp;

            public TimeValue(string value, int timestamp)
            {
                this.value = value;
                this.timestamp = timestamp;

            }


        }


        Dictionary<string, List<TimeValue>> keyValuePairs;
        public TimeMap()
        {
            keyValuePairs = new Dictionary<string, List<TimeValue>>();
        }

        public void Set(string key, string value, int timestamp)
        {
            if (!keyValuePairs.ContainsKey(key))
            {
                keyValuePairs[key] = new List<TimeValue>();
            }

            keyValuePairs[key].Add(new TimeValue(value, timestamp));
        }


        public string Get(string key, int timestamp)
        {
             if (!keyValuePairs.ContainsKey(key)) return "";
            var sublist = keyValuePairs[key];
            int left = 0;
            int right = sublist.Count - 1;


            while (left <= right)
            {

                int mid = (left + right) / 2;

                if (sublist[mid].timestamp == timestamp)
                {
                    return  sublist[mid].value;

                }
                else if (sublist[mid].timestamp >= timestamp)
                {
                    right = mid - 1;
                }
                else
                {

                    left = mid + 1;

                }

            }

            if (right >= 0) return sublist[right].value;

            return "";
       
        }



    }