using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeziKatılım.Web.Model
{
    public class Repository
    {

        private static List<Participant> participants = new List<Participant>();

        public static List<Participant> Participants
        {
            get
            {
                return participants;
            }
        }

        public static void AddParticipant(Participant participant)
        {
            participants.Add(participant);
        }
    }
}
