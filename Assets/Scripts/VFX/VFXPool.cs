using CosmicCuration.Utilities;
using CosmicCuration.VFX;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CosmicCuration.VFX
{
    public class VFXPool : GenericObjectPool<VFXController>
    {
        private VFXView vfxView;
        public VFXPool(VFXView view) => this.vfxView = view;
        public VFXController GetVFX() => GetItem<VFXController>();
        protected override VFXController CreateItem<T>() => new VFXController(vfxView);
    }
}
