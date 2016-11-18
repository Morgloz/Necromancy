using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RimWorld;
using Verse;
using Verse.AI;

namespace Necromancy
{
    public class WorkGiver_Necromancer : WorkGiver_Scanner
    {
        private readonly JobDef jobDef = DefDatabase<JobDef>.GetNamed("RaiseDead");

        public override PathEndMode PathEndMode
        {
            get
            {
                return PathEndMode.OnCell;
            }
        }

        public override bool HasJobOnThing(Pawn pawn, Thing t)
        {
            var corpse = t as Corpse;
            return true;
        }

        public override Job JobOnThing(Pawn pawn, Thing t)
        {
            return new Job(jobDef, t);
        }
    }
}
