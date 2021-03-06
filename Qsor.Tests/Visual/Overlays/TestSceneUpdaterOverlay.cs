﻿using System;
using System.Collections.Generic;
using osu.Framework.Allocation;
using osu.Framework.Testing;
using Qsor.Game.Overlays;

namespace Qsor.Tests.Visual.Overlays
{
    public class TestSceneUpdaterOverlay : TestScene
    {
        public override IReadOnlyList<Type> RequiredTypes =>
            new[] { typeof(UpdaterOverlay) };
        
        [BackgroundDependencyLoader]
        private void Load()
        {
            Console.WriteLine("Test");
            
            var updaterOverlay = new UpdaterOverlay();

            Add(updaterOverlay);

            AddStep("Show", updaterOverlay.Show);
            AddStep("Hide", updaterOverlay.Hide);
        }
        
    }
}