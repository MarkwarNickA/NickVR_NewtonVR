using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using UnityEngine;

namespace NewtonVR.NVRPaletteUI
{

    class NVRPaletteInteractable : NVRInteractable
    {

        public NVRInteractable LinkedInteractable;

        public override void BeginInteraction(NVRHand hand)
        {
            base.BeginInteraction(hand);
        }
    }
}
