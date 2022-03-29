using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBDMatchmakingTracker {

    /// <summary>
    /// Range of integers from min (inclusive) to max (exclusive).
    /// </summary>
    public class IntRange {

        private int min;

        private int max;

        public int GetMin() {
            return min;
        }

        public void SetMin(int value) {
            min = value;
        }

        public int GetMax() {
            return max;
        }

        public void SetMax(int value) {
            max = value;
        }

        public IntRange(int _min, int _max) {
            SetMin(_min);
            SetMax(_max);
        }
    }
}
