﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AntMe.Plugin.Xna
{
    internal sealed class DebugMessage
    {
        public const int ROUNDS_TO_LIFE = 15;

        public int CreateRound { get; set; }

        public string Message { get; set; }
    }
}
