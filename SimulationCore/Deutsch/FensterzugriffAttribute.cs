﻿using System;

namespace AntMe.Deutsch {
    /// <summary>
    /// Attribut zur Anfrage von Zugriff auf Fensterelemente.
    /// </summary>
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    public sealed class FensterzugriffAttribute : ZugriffAttribute {}
}