// Mage.cs
using System;

namespace MagicalInheritance
{
    class Mage : Pupil
    {
        public Mage(string title) : base(title)
        { }

        public Mage(string title, string origin) : base(title, origin)
        { }

        public virtual Storm CastRainStorm()
        {
            Storm storm = new Storm("rain", false, base.Title);
            return storm;
        }

    }

}
