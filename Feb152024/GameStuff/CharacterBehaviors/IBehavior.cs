using Feb152024.GameStuff.Entities;
using Microsoft.Xna.Framework;
using SharpDX.XAudio2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feb152024.GameStuff.CharacterBehaviors
{
    public interface IBehavior
    {
        public bool CheckCondition();
        public void Act(Character character);

    }
}
