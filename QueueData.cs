using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBDMatchmakingTracker {
    public class QueueData {
        int survivorPool { get;}
        int killerPool { get;}
        double estimatedWaitTime { get;}

        public QueueData(int _survivorPool, int _killerPool, double _estimatedWaitTime) {
            survivorPool = _survivorPool;
            killerPool = _killerPool;
            estimatedWaitTime = _estimatedWaitTime;
        }

        public int GetSurvPool() { return survivorPool; }
        public int GetKlrPool() { return killerPool;  }
        public double GetETA() { return estimatedWaitTime; }
    }
}
