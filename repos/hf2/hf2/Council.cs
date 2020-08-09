using System;
using System.Collections.Generic;
using System.Text;

namespace hf2
{
    public class Council
    {
        private List<Jedi> members = new List<Jedi>();
        public event CouncilChangedDelegate ChangedCouncil;

        public int Count
        {
            get { return members.Count; }
        }

        public int CountIf(Predicate<Jedi> match)
        {
            List<Jedi> ifMembers = members.FindAll(match);
            return ifMembers.Count;
        }
        public void Add(Jedi jedi)
        {
            members.Add(jedi);
            if(ChangedCouncil != null)
                ChangedCouncil("Member added");
        }

        public void Remove()
        {
            members.RemoveAt(members.Count - 1);
            if(ChangedCouncil != null)
                ChangedCouncil("Last member removed");
            if (members.Count == 0)
            {
                if (ChangedCouncil != null)
                    ChangedCouncil("All members removed");
            }
        }

        static bool BeginnerFilter(Jedi jedi)
        {
            return jedi.MidiChlorianCount < 300 ? true : false;
        }

        public List<Jedi> GetBeginners()
        {
            return members.FindAll(BeginnerFilter);
        }
    }
}
