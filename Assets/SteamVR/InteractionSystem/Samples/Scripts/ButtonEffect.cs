//======= Copyright (c) Valve Corporation, All rights reserved. ===============

using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using System;
using Valve.VR;

namespace Valve.VR.InteractionSystem.Sample
{
    public class ButtonEffect : MonoBehaviour
    {
        public SteamVR_Action_Vibration hapticAction;
        public void OnButtonDown(Hand fromHand)
        {
            ColorSelf(Color.yellow);
            fromHand.TriggerHapticPulse(1000);
            //hapticAction.Execute(0f, .008f, 150f, 1f, SteamVR_Input_Sources.RightHand);
            
        }

        public void OnButtonUp(Hand fromHand)
        {
            ColorSelf(Color.red);
        }

        private void ColorSelf(Color newColor)
        {
            Renderer[] renderers = this.GetComponentsInChildren<Renderer>();
            for (int rendererIndex = 0; rendererIndex < renderers.Length; rendererIndex++)
            {
                renderers[rendererIndex].material.color = newColor;
            }
        }
    }
}