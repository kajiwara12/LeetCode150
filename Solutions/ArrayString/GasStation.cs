using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayString
{
    public class GasStation
    {
        public int CanCompleteCircuit(int[] gas, int[] cost)
        {
            IEnumerable<int> candidates =
            Enumerable.Range(0, gas.Length - 1).Where(index =>
            gas[index] > cost[index]
            );

            foreach (int station in candidates)
            {
                int startingStation = station;
                int currentStation = station;
                int gasLevel = gas[currentStation];
                while (gasLevel - cost[currentStation] >= 0)
                {
                    currentStation++;
                    currentStation = currentStation % gas.Length;

                    gasLevel += gas[currentStation];
                    if (currentStation == startingStation) return startingStation;
                };
            }
            return -1;
        }

    }
}
