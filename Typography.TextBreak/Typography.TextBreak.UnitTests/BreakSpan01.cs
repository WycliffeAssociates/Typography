﻿//MIT, 2020, WinterDev
using Typography.TextBreak;


namespace PixelFarm.Drawing
{
    //FOR TEST ONLY

    interface ILineSegmentList : System.IDisposable
    {
        int Count { get; }
        ILineSegment this[int index] { get; }
    }
    interface ILineSegment
    {
        int Length { get; }
        int StartAt { get; }
        SpanBreakInfo SpanBreakInfo { get; }
    }

    struct BreakSpan
    {
        //TODO: review here again***
        public int startAt;
        public ushort len;
        public WordKind wordKind;
        public SpanBreakInfo SpanBreakInfo;
    }

    static class WordBreakExtensions
    {
        public static BreakSpan GetBreakSpan(this WordVisitor vis)
        {
            return new BreakSpan()
            {
                startAt = vis.LatestSpanStartAt,
                len = vis.LatestSpanLen,
                wordKind = vis.LatestWordKind,
                SpanBreakInfo = vis.SpanBreakInfo,
            };
        }
    }
}