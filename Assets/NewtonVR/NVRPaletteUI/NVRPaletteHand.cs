using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using UnityEngine;

namespace NewtonVR.NVRPaletteUI
{
    public class NVRPaletteHand : NVRHand
    {

        public override void BeginInteraction(NVRInteractable interactable)
        {

            if (interactable.GetType() == typeof(NVRPaletteInteractable))
            {
                NVRInteractable Clone = GameObject.Instantiate<NVRInteractable>(((NVRPaletteInteractable)interactable).LinkedInteractable);
                Clone.transform.position = interactable.transform.position;
                interactable = Clone;

            }

            if (interactable.CanAttach == true)
            {
                if (interactable.AttachedHand != null)
                {
                    interactable.AttachedHand.EndInteraction(null);
                }

                CurrentlyInteracting = interactable;
                CurrentlyInteracting.BeginInteraction(this);
            }
        }
    }
}
