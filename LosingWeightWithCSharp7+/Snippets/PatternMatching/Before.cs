using System;

namespace LosingWeightWithCSharp7Plus.Snippets.PatternMatching
{
    public class BeforeWithAs
    {
        public void Eject(object storage)
        {
            if (storage == null) return; // Hmmmm... but OK. Nulls are not the topic of this talk ;-)

            var usbKey = storage as UsbKey;
            if (usbKey != null && usbKey.IsPluggedIn)
            {
                usbKey.Unload();
            }

            // Hmmm, we should actually have an else here ;-)
            var dvd = storage as Dvd;
            if (dvd != null && dvd.IsInserted)
            {
                dvd.Eject();
            }

            var hardDisk = storage as HardDisk;
            if (hardDisk != null)
            {
                throw new ArgumentException("A hard disk cannot be ejected.");
            }

            // Do some additonal common processing here.
        }
    }

    public class BeforeWithIs
    {
        public void Eject(object storage)
        {
            if (storage == null) return; // Hmmmm... but OK. Nulls are not the topic of this talk ;-)

            if (storage is UsbKey)
            {
                var usbKey = (UsbKey)storage;
                if (usbKey.IsPluggedIn)
                {
                    usbKey.Unload();
                }
            }
            else if (storage is Dvd)
            {
                var dvd = (Dvd)storage;
                if (dvd.IsInserted)
                {
                    dvd.Eject();
                }
            }
            else if (storage is HardDisk)
            {
                throw new ArgumentException("A hard disk cannot be ejected.");
            }

            // Do some additonal common processing here.
        }
    }
}