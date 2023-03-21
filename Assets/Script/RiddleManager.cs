using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class RiddleManager : MonoBehaviour
{
    public GameObject tracker1;
    public GameObject canvas1Ui;

    public GameObject tracker2;
    public GameObject canvas2Ui;

    public GameObject tracker3;
    public GameObject canvas3Ui;

    public GameObject tracker4;
    public GameObject tracker5;
    public GameObject tracker6;
    public GameObject tracker7;
    public GameObject tracker8;
    public GameObject tracker9;

    public GameObject canvasFalseUi;

    public bool trackedCardZero = true;
    public bool trackedCardOne = false;
    public bool trackedCardTwo = false;

    // Start is called before the first frame update
    void Start()
    {
        canvas1Ui.SetActive(false);
        canvas2Ui.SetActive(false);
        canvas3Ui.SetActive(false);
        canvasFalseUi.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (tracker1.GetComponent<ObserverBehaviour>().TargetStatus.Status == Status.TRACKED && (tracker2.GetComponent<ObserverBehaviour>().TargetStatus.Status == Status.TRACKED) == false && 
                (tracker3.GetComponent<ObserverBehaviour>().TargetStatus.Status == Status.TRACKED) == false && tracker4.GetComponent<ObserverBehaviour>().TargetStatus.Status != Status.TRACKED && 
                tracker5.GetComponent<ObserverBehaviour>().TargetStatus.Status != Status.TRACKED && tracker6.GetComponent<ObserverBehaviour>().TargetStatus.Status != Status.TRACKED && 
                tracker7.GetComponent<ObserverBehaviour>().TargetStatus.Status != Status.TRACKED && tracker8.GetComponent<ObserverBehaviour>().TargetStatus.Status != Status.TRACKED && 
                tracker9.GetComponent<ObserverBehaviour>().TargetStatus.Status != Status.TRACKED)
            {
                canvas1Ui.SetActive(true);
                trackedCardOne = true;
            }
        else
            {
                canvas1Ui.SetActive(false);
            }
            
        if (trackedCardOne == true && tracker2.GetComponent<ObserverBehaviour>().TargetStatus.Status == Status.TRACKED && (tracker1.GetComponent<ObserverBehaviour>().TargetStatus.Status == Status.TRACKED) == false &&
                (tracker3.GetComponent<ObserverBehaviour>().TargetStatus.Status == Status.TRACKED) == false && tracker4.GetComponent<ObserverBehaviour>().TargetStatus.Status != Status.TRACKED &&
                tracker5.GetComponent<ObserverBehaviour>().TargetStatus.Status != Status.TRACKED && tracker6.GetComponent<ObserverBehaviour>().TargetStatus.Status != Status.TRACKED &&
                tracker7.GetComponent<ObserverBehaviour>().TargetStatus.Status != Status.TRACKED && tracker8.GetComponent<ObserverBehaviour>().TargetStatus.Status != Status.TRACKED &&
                tracker9.GetComponent<ObserverBehaviour>().TargetStatus.Status != Status.TRACKED)
            {
                canvas2Ui.SetActive(true);
                trackedCardTwo = true;
                trackedCardZero = false;
            }
        else 
            {
                canvas2Ui.SetActive(false);
            }

        if(trackedCardTwo == true && tracker3.GetComponent<ObserverBehaviour>().TargetStatus.Status == Status.TRACKED && (tracker2.GetComponent<ObserverBehaviour>().TargetStatus.Status == Status.TRACKED) == false &&
                (tracker1.GetComponent<ObserverBehaviour>().TargetStatus.Status == Status.TRACKED) == false && tracker4.GetComponent<ObserverBehaviour>().TargetStatus.Status != Status.TRACKED &&
                tracker5.GetComponent<ObserverBehaviour>().TargetStatus.Status != Status.TRACKED && tracker6.GetComponent<ObserverBehaviour>().TargetStatus.Status != Status.TRACKED &&
                tracker7.GetComponent<ObserverBehaviour>().TargetStatus.Status != Status.TRACKED && tracker8.GetComponent<ObserverBehaviour>().TargetStatus.Status != Status.TRACKED &&
                tracker9.GetComponent<ObserverBehaviour>().TargetStatus.Status != Status.TRACKED)
            {
                canvas3Ui.SetActive(true);
            }

        if((tracker4.GetComponent<ObserverBehaviour>().TargetStatus.Status == Status.TRACKED ||
                tracker5.GetComponent<ObserverBehaviour>().TargetStatus.Status == Status.TRACKED || tracker6.GetComponent<ObserverBehaviour>().TargetStatus.Status == Status.TRACKED ||
                tracker7.GetComponent<ObserverBehaviour>().TargetStatus.Status == Status.TRACKED || tracker8.GetComponent<ObserverBehaviour>().TargetStatus.Status == Status.TRACKED ||
                tracker9.GetComponent<ObserverBehaviour>().TargetStatus.Status == Status.TRACKED) || 
                (tracker1.GetComponent<ObserverBehaviour>().TargetStatus.Status == Status.TRACKED && trackedCardTwo == true) || 
                (tracker2.GetComponent<ObserverBehaviour>().TargetStatus.Status == Status.TRACKED && trackedCardOne == false) || 
                (tracker3.GetComponent<ObserverBehaviour>().TargetStatus.Status == Status.TRACKED && (trackedCardTwo == false || trackedCardOne == false || trackedCardZero == true)))
        {
            trackedCardZero = true;
            trackedCardOne = false;
            trackedCardTwo = false;
            canvasFalseUi.SetActive(true);
        }
        else 
        {
            canvasFalseUi.SetActive(false);
        }
    }
}
