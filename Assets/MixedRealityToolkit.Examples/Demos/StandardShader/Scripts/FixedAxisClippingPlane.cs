using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Microsoft.MixedReality.Toolkit.UI; 

public class FixedAxisClippingPlane : MonoBehaviour
{
    
    public Transform transformCutplane = null;
    public GameObject box = null;


    public void OnSliderUpdated(SliderEventData eventData)
    {
        if (transformCutplane != null && box != null)
        {
            // Rescale and reposition the target objects using Slider's eventData.NewValue
            transformCutplane.localPosition = new Vector3(eventData.NewValue*0.25f-0.15f, transformCutplane.localPosition.y, transformCutplane.localPosition.z);
            box.transform.localScale = new Vector3(1 - eventData.NewValue*0.835f, box.transform.localScale.y, box.transform.localScale.z);
        }
    }
}
