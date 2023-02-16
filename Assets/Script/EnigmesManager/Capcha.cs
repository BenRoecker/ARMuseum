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

    /*public GameObject m_imageTargetBrainTwo;
    public GameObject m_modelBrainTwo;

    public GameObject m_imageTargetBrainThree;
    public GameObject m_modelBrainThree;

    public GameObject m_imageTargetLungOne;
    public GameObject m_modelLungOne;

    public GameObject m_imageTargetLungTwo;
    public GameObject m_modelLungTwo;

    public GameObject m_imageTargetLungThree;
    public GameObject m_modelLungThree;*/

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

        /*var trackableBrainTwo = m_imageTargetHeartOne.GetComponent<ObserverBehaviour>();
        var statusBrainTwo = trackableBrainTwo.TargetStatus.Status;

        var trackableBrainThree = m_imageTargetHeartOne.GetComponent<ObserverBehaviour>();
        var statusBrainThree = trackableBrainThree.TargetStatus.Status;

        var trackableLungOne = m_imageTargetHeartOne.GetComponent<ObserverBehaviour>();
        var statusLungOne = trackableLungOne.TargetStatus.Status;

        var trackableLungTwo = m_imageTargetHeartOne.GetComponent<ObserverBehaviour>();
        var statusLungTwo = trackableLungTwo.TargetStatus.Status;

        var trackableLungThree = m_imageTargetHeartOne.GetComponent<ObserverBehaviour>();
        var statusLungThree = trackableLungThree.TargetStatus.Status;*/

        if(m_allTrackedOnce == false && statusHeartOne == Status.TRACKED && statusHeartTwo == Status.TRACKED && statusHeartThree == Status.TRACKED && statusBrainOne == Status.TRACKED /*&& statusBrainTwo == Status.TRACKED && statusBrainThree == Status.TRACKED && statusLungOne == Status.TRACKED && statusLungTwo == Status.TRACKED && statusLungThree == Status.TRACKED*/)
        {
            m_allTrackedOnce = true;
        }
        else if(m_allTrackedOnce == true  && statusBrainOne == Status.TRACKED && (statusHeartOne == Status.TRACKED) == false && (statusHeartTwo == Status.TRACKED) == false && (statusHeartThree == Status.TRACKED) == false /*&& (statusBrainTwo == Status.TRACKED) == false && (statusBrainThree == Status.TRACKED) == false && (statusLungOne == Status.TRACKED) == false && (statusLungTwo == Status.TRACKED) == false && (statusLungThree == Status.TRACKED) == false && statusHeartOne == Status.TRACKED && statusHeartTwo == Status.TRACKED && statusHeartThree == Status.TRACKED*/)
        {

            m_solveCanvas.SetActive(true);
        }
    }
}
