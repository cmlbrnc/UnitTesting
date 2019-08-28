using System.Collections.Generic;
using System.Linq;

namespace Demo
{
    public class GroupBy
    {
        private int _numberGroup;

        public GroupBy(int numberGroup)
        {
            this._numberGroup = numberGroup;
        }

        public List<List<Measurement>> Group(List<Measurement> measurements)
        {
            var groups = new List<List<Measurement>>();

            for (int i = 0; i < measurements.Count; )
            {
                var group = measurements.Skip(i).Take(_numberGroup).ToList();
                groups.Add(measurements);
                i += _numberGroup;
            }
          
            return groups;
        }
    }
}