﻿using System.Windows.Documents;

namespace Mathematica.Extensions
{
    public static class TextElementExtensions
    {
        public static TextPointer GetBoundary(this TextElement x, LogicalDirection direction)
        {
            var boundary = direction == LogicalDirection.Forward ? x.ElementStart : x.ElementEnd;

            var insertionPosition = direction == LogicalDirection.Forward
                ? boundary.GetNextInsertionPosition(direction)
                : boundary.GetInsertionPosition(direction);

            return insertionPosition;
        }
    }
}