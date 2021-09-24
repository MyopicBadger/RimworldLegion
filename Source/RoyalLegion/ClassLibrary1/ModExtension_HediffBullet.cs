using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using RimWorld;
using Verse;

namespace RoyalLegion
{
    public class ModExtension_HediffBullet : DefModExtension
    {
        public float addHediffChance = 0.25f;
        public HediffDef hediffToAdd;
    }
}
