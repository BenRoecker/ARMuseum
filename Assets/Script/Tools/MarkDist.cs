
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class MarkDist : MonoBehaviour
{
    public GameObject imageTracker;
    public Vector3 delta;
    public bool goIn = false;

    void Update()
    {
        var trackableImage = imageTracker.GetComponent<ObserverBehaviour>();
        var statusImage = trackableImage.TargetStatus.Status;
        if (statusImage == Status.TRACKED)
        {
            goIn = true;
            delta = Camera.main.transform.position - transform.position;
        }
        else
        {
            goIn = false;
        }
    }
}