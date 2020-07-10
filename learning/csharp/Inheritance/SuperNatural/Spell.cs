// Spell.cs
using System;

namespace MagicalInheritance
{
    abstract class Spell
    {
        //this perporty method "set" is protected because we need to set it in Storm class.
        public string Essence { get; protected set; }
        public bool IsStrong { get; protected set; }
        public string Caster { get; protected set; }

        public Spell();

        public abstract string Announce();

    }

}
