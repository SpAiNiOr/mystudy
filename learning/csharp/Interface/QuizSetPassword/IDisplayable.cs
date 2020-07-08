// Define IDisplayable in this file

using System;

namespace SavingInterface
{
    interface IDisplayable
    {
        char HeaderSymbol { get; }
        void Display();
    }
}