﻿// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

#nullable disable

using osu.Framework.iOS;
using UIKit;

namespace osu.Game.Rulesets.Mania.Tests.iOS
{
    public static class Application
    {
        public static void Main(string[] args)
        {
            UIApplication.Main(args, typeof(GameUIApplication), typeof(AppDelegate));
        }
    }
}
