using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using UnityEngine;

namespace NewtonVR.NVRPaletteUI
{
    class NVRPaletteMiniModel : MonoBehaviour
    {
        
        public NVRInteractable LinkedInteractable;

        public void OnTriggerStay(Collider collider)
        {
            
            NVRHand Hand = collider.GetComponentInParent<NVRHand>();
            if (Hand != null)
            {
                if (Hand.HoldButtonDown == true && Hand.CurrentlyInteracting == false)
                {
                    NVRInteractable Clone = GameObject.Instantiate<NVRInteractable>(LinkedInteractable);
                    Clone.transform.position = this.transform.position;
                    Hand.BeginInteraction(Clone);
                }

                if (Hand.UseButtonPressed)
                {
                    Debug.Log("Mini used");
                    this.GetComponent<Renderer>().material.color = Color.green;
                }
                else
                {
                    this.GetComponent<Renderer>().material.color = Color.red;
                }
            }

        }
        
    }
}
