﻿using System;
using System.Threading.Tasks;

namespace RtmpSharp.IO.AMF3.AMFWriters
{
    class Amf3DoubleWriter : IAmfItemWriter
    {
        public void WriteData(AmfWriter writer, object obj)
        {
            writer.WriteMarker(Amf3TypeMarkers.Double);
            writer.WriteAmf3Double(Convert.ToDouble(obj));
        }

        public void WriteDataAsync(AmfWriter writer, object obj)
        {
            writer.WriteMarkerAsync(Amf3TypeMarkers.Double);
            writer.WriteAmf3DoubleAsync(Convert.ToDouble(obj));
        }
    }
}