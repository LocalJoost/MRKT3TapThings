using Microsoft.MixedReality.Toolkit;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class ColorToggler : MRTKBaseInteractable
{
    protected override void OnSelectEntered(SelectEnterEventArgs args)
    {
        gameObject.GetComponent<Renderer>().material.color = Color.green;
    }

    protected override void OnSelectExited(SelectExitEventArgs args)
    {
        gameObject.GetComponent<Renderer>().material.color = Color.red;
    }
}
