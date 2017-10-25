using System;

namespace LosingWeightWithCSharp7Plus.Snippets.PatternMatching
{
    public class AfterWithIs
    {
        public void Eject(object storage)
        {
            if (storage is null) return; // Hmmmm... but OK. Nulls are not the topic of this talk ;-)

            if (storage is UsbKey usbKey && usbKey.IsPluggedIn)
            {
                usbKey.Unload();
            }
            else if (storage is Dvd dvd && dvd.IsInserted)
            {
                dvd.Eject();
            }
            else if (storage is HardDisk)
            {
                throw new ArgumentException("A hard disk cannot be ejected.");
            }

            // Do some additonal common processing here.
        }
    }

    public class AfterWithSwitchCase
    {
        public void Eject(object storage)
        {
            switch (storage)
            {
                case UsbKey usbKey when usbKey.IsPluggedIn:
                    usbKey.Unload();
                    break;
                case Dvd dvd when dvd.IsInserted:
                    dvd.Eject();
                    break;
                case HardDisk hardDisk:
                    throw new ArgumentException("A hard disk cannot be ejected.");
                case null:
                    return;
            }

            // Do some additonal common processing here.
        }
    }
}