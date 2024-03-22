using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Feb152024.GameStuff.Statics
{
    public static class Globals
    {
        public static ContentManager ContentManager { get; set; }
        public static TimerFactory TimerSpawner {  get; set; }

        public static void CreateFactory()
        {
            if(TimerSpawner == null)
            {
                TimerSpawner = new TimerFactory();
            }
        }
    }
}
