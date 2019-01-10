﻿using System.Runtime.InteropServices;
using JetBrains.Annotations;
#if UNITY || UNITY_EDITOR
using UnityEngine;

#endif

// ReSharper disable once CheckNamespace
namespace MathGeoLib
{
    /// <summary>
    ///     Represents a 3D line.
    /// </summary>
    [PublicAPI]
    [StructLayout(LayoutKind.Sequential)]
    public struct Line
    {
        public readonly Vector3 Point1;

        public readonly Vector3 Point2;

        public Line(Vector3 point1, Vector3 point2)
        {
            Point1 = point1;
            Point2 = point2;
        }

        public override string ToString()
        {
            return $"{nameof(Point1)}: {Point1}, {nameof(Point2)}: {Point2}";
        }
    }
}