// Storm.cs
using System;

namespace MagicalInheritance
{
    class Storm : Spell
    {
        //although Storm Inherited from Spell. But the Constuctor using Properties' set method.  so we need to use the 'protected'
        public Storm(string essence, bool isStrong, string caster)
        {
            base.Essence = essence;
            base.IsStrong = isStrong;
            base.Caster = caster;
        }

        public override string Announce()
        {
            string level = (IsStrong) ? "strong" : "weak";
            return $"{Caster} cast a {level} {Essence} storm!";
        }

    }

}