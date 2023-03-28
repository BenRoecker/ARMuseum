using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class Capcha : MonoBehaviour
{

    // Initialisation card to track
    [Header("Card & Model")]
    public GameObject m_imageTargetHeartOne;
    public GameObject m_modelHeartOne;

    public GameObject m_imageTargetHeartTwo;
    public GameObject m_modelHeartTwo;

    public GameObject m_imageTargetHeartThree;
    public GameObject m_modelHeartThree;

    public GameObject m_imageTargetBrainOne;
    public GameObject m_modelBrainOne;

    public GameObject m_imageTargetBrainTwo;
    public GameObject m_modelBrainTwo;

    public GameObject m_imageTargetBrainThree;
    public GameObject m_modelBrainThree;

    public GameObject m_imageTargetLungOne;
    public GameObject m_modelLungOne;

    public GameObject m_imageTargetLungTwo;
    public GameObject m_modelLungTwo;

    public GameObject m_imageTargetLungThree;
    public GameObject m_modelLungThree;

    [Header("Canvas")]
    public GameObject m_solveCanvas;

    // Other used variables
    [Header("Riddle Steps")]
    public bool m_allTrackedOnce = false;

    public bool m_riddleSolve = false;

    // Update is called once per frame
    void Update()
    {

        // Check if the card is tracked
        var trackableHeartOne = m_imageTargetHeartOne.GetComponent<ObserverBehaviour>();
        var statusHeartOne = trackableHeartOne.TargetStatus.Status;

        var trackableHeartTwo = m_imageTargetHeartTwo.GetComponent<ObserverBehaviour>();
        var statusHeartTwo = trackableHeartTwo.TargetStatus.Status;

        var trackableHeartThree = m_imageTargetHeartThree.GetComponent<ObserverBehaviour>();
        var statusHeartThree = trackableHeartThree.TargetStatus.Status;

        var trackableBrainOne = m_imageTargetBrainOne.GetComponent<ObserverBehaviour>();
        var statusBrainOne = trackableBrainOne.TargetStatus.Status;

        var trackableBrainTwo = m_imageTargetBrainTwo.GetComponent<ObserverBehaviour>();
        var statusBrainTwo = trackableBrainTwo.TargetStatus.Status;

        var trackableBrainThree = m_imageTargetBrainThree.GetComponent<ObserverBehaviour>();
        var statusBrainThree = trackableBrainThree.TargetStatus.Status;

        var trackableLungOne = m_imageTargetLungOne.GetComponent<ObserverBehaviour>();
        var statusLungOne = trackableLungOne.TargetStatus.Status;

        var trackableLungTwo = m_imageTargetLungTwo.GetComponent<ObserverBehaviour>();
        var statusLungTwo = trackableLungTwo.TargetStatus.Status;

        var trackableLungThree = m_imageTargetLungThree.GetComponent<ObserverBehaviour>();
        var statusLungThree = trackableLungThree.TargetStatus.Status;

        if(m_allTrackedOnce == false && statusHeartOne == Status.TRACKED && statusHeartTwo == Status.TRACKED && statusHeartThree == Status.TRACKED && statusBrainOne == Status.TRACKED && statusBrainTwo == Status.TRACKED && statusBrainThree == Status.TRACKED && statusLungOne == Status.TRACKED && statusLungTwo == Status.TRACKED && statusLungThree == Status.TRACKED)
        {
            m_allTrackedOnce = true;
        }
        
        if(m_allTrackedOnce == true && statusHeartOne == Status.TRACKED && statusHeartTwo == Status.TRACKED && statusHeartThree == Status.TRACKED && (statusBrainOne == Status.NO_POSE) && (statusBrainTwo == Status.NO_POSE) && (statusBrainThree == Status.NO_POSE) && (statusLungOne == Status.NO_POSE) && (statusLungTwo == Status.NO_POSE) && !(statusLungThree == Status.TRACKED)/*  && !(statusBrainOne == Status.TRACKED) && !(statusBrainTwo == Status.TRACKED) && !(statusBrainThree == Status.TRACKED) && !(statusLungOne == Status.TRACKED) && !(statusLungTwo == Status.TRACKED) && !(statusLungThree == Status.TRACKED)*/)
        {
            m_riddleSolve = true;
            m_solveCanvas.SetActive(true);
        }
        //Debug.LogError(statusHeartOne == Status.NO_POSE);
        Debug.Log(statusHeartOne == Status.TRACKED && statusHeartTwo == Status.TRACKED && statusHeartThree == Status.TRACKED && m_allTrackedOnce == true);
    }
}
