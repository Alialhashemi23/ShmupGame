using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feb152024.GameStuff.GameLevels
{
    public class LevelConfiguration
    {
        public int Level { get; set; }
        public List<EnemyTimings> Enemies { get; set; }
    }

    public class EnemyTimings
    {
        public string Name { get; set; }
        public int SpawnTime { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public bool Spawned = false;
    }
}
