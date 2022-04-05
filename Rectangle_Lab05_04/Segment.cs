﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project3_lab22._03_;

namespace Rectangle_Lab05_04
{
    public class Segment
    {
        public int Start {get; set;}
        public int End {get; set;}

        public Segment (int start , int end)
        {
            if(start > end)
            {
                (start, end) = (end, start);
            }
            Start = start;
            End = end; 
        }

        public Segment Intersect(Segment other)
        {
            if(End < other.Start) return null;
            if(Start > other.End) return null;
        
            int maxStart = Math.Max(Start, other.End);
            int minEnd = Math.Min(End, other.Start);

            return new Segment (maxStart, minEnd);
            //-------------------------max
            //      min--------------------------
        }

    }
}
