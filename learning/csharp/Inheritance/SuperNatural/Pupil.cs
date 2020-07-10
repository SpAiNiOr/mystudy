// Pupil.cs
using System;

namespace MagicalInheritance
{
    class Pupil
    {
        //this perporty "set" is private because we only set it during initial the object.
        public string Title { get; private set; }
        public string Origin { get; private set; }

        public Pupil(string title)
        {
            Title = title;
        }

        public Pupil(string title, string origin)
        {
            Title = title;
            Origin = origin;
        }

        public Storm CastWindStorm()
        {
            Storm storm = new Storm("wind", false, Title);
            return storm;
        }
    }
}
