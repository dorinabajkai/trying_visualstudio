using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace hf2
{
    public class Jedi
    {
        private int midiChlorianCount;

        [XmlAttribute("Név")]
        public string Name { get; set; }

        [XmlAttribute("Midi-chlorian szám")]
        public int MidiChlorianCount
        {
            get { return midiChlorianCount; }
            set
            {
                if (value < 10)
                    throw new Exception("Helytelen midi-chlorian érték!");
                midiChlorianCount = value;
            }
        }
    }
}
