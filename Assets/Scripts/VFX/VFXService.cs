using System.Collections.Generic;
using UnityEngine;

namespace CosmicCuration.VFX
{
    public class VFXService
    {
        private VFXPool vfxPool;

        public VFXService(VFXView view) => vfxPool = new VFXPool(view);

        public void PlayVFXAtPosition(VFXType type, Vector2 spawnPosition)
        {
            VFXController vfxToPlay = vfxPool.GetVFX();
            vfxToPlay.Configure(spawnPosition);
        }
    } 
}