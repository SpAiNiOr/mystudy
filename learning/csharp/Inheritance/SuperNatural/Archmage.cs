// Archmage.cs
using System;

namespace MagicalInheritance
{
    class Archmage : Mage
    {
        //since it's using the base constructor, it doesn't require protected access.
        public Archmage(string title) : base(title)
        { }
        public Archmage(string title, string origin) : base(title, origin)
        { }

        public override Storm CastRainStorm()
        {
            Storm storm = new Storm("rain", false, base.Title);
            return storm;
        }
        public Storm CastLightningStorm()
        {
            Storm storm = new Storm("lightning", true, base.Title);
            return storm;
        }

    }

}
