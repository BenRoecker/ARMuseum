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
    public GameObject tracker10;

    public GameObject canvasFalseUi;

    public int count = 0;

    // Start is called before the first frame update
    void Start()
    {
        canvas1Ui.SetActive(false);
        canvas2Ui.SetActive(false);
        canvas3Ui.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (tracker1.GetComponent<ObserverBehaviour>().TargetStatus.Status == Status.TRACKED && (tracker2.GetComponent<ObserverBehaviour>().TargetStatus.Status == Status.TRACKED) == false && 
                (tracker3.GetComponent<ObserverBehaviour>().TargetStatus.Status == Status.TRACKED) == false && tracker4.GetComponent<ObserverBehaviour>().TargetStatus.Status != Status.TRACKED && 
                tracker5.GetComponent<ObserverBehaviour>().TargetStatus.Status != Status.TRACKED && tracker6.GetComponent<ObserverBehaviour>().TargetStatus.Status != Status.TRACKED && 
                tracker7.GetComponent<ObserverBehaviour>().TargetStatus.Status != Status.TRACKED && tracker8.GetComponent<ObserverBehaviour>().TargetStatus.Status != Status.TRACKED && 
                tracker9.GetComponent<ObserverBehaviour>().TargetStatus.Status != Status.TRACKED && tracker10.GetComponent<ObserverBehaviour>().TargetStatus.Status != Status.TRACKED)
            {
            while(tracker1.GetComponent<ObserverBehaviour>().TargetStatus.Status == Status.TRACKED)
            {
                canvas1Ui.SetActive(true);
            }
            count = 1;
            }
            
        if (count == 1 && tracker2.GetComponent<ObserverBehaviour>().TargetStatus.Status == Status.TRACKED && (tracker1.GetComponent<ObserverBehaviour>().TargetStatus.Status == Status.TRACKED) == false &&
                (tracker3.GetComponent<ObserverBehaviour>().TargetStatus.Status == Status.TRACKED) == false && tracker4.GetComponent<ObserverBehaviour>().TargetStatus.Status != Status.TRACKED &&
                tracker5.GetComponent<ObserverBehaviour>().TargetStatus.Status != Status.TRACKED && tracker6.GetComponent<ObserverBehaviour>().TargetStatus.Status != Status.TRACKED &&
                tracker7.GetComponent<ObserverBehaviour>().TargetStatus.Status != Status.TRACKED && tracker8.GetComponent<ObserverBehaviour>().TargetStatus.Status != Status.TRACKED &&
                tracker9.GetComponent<ObserverBehaviour>().TargetStatus.Status != Status.TRACKED && tracker10.GetComponent<ObserverBehaviour>().TargetStatus.Status != Status.TRACKED)
            {
            while(tracker2.GetComponent<ObserverBehaviour>().TargetStatus.Status == Status.TRACKED)
            {
                canvas2Ui.SetActive(true);
            }
            count = 2;
            }

        if(count == 2 && tracker3.GetComponent<ObserverBehaviour>().TargetStatus.Status == Status.TRACKED && (tracker2.GetComponent<ObserverBehaviour>().TargetStatus.Status == Status.TRACKED) == false &&
                (tracker1.GetComponent<ObserverBehaviour>().TargetStatus.Status == Status.TRACKED) == false && tracker4.GetComponent<ObserverBehaviour>().TargetStatus.Status != Status.TRACKED &&
                tracker5.GetComponent<ObserverBehaviour>().TargetStatus.Status != Status.TRACKED && tracker6.GetComponent<ObserverBehaviour>().TargetStatus.Status != Status.TRACKED &&
                tracker7.GetComponent<ObserverBehaviour>().TargetStatus.Status != Status.TRACKED && tracker8.GetComponent<ObserverBehaviour>().TargetStatus.Status != Status.TRACKED &&
                tracker9.GetComponent<ObserverBehaviour>().TargetStatus.Status != Status.TRACKED && tracker10.GetComponent<ObserverBehaviour>().TargetStatus.Status != Status.TRACKED)
            {
                while(tracker3.GetComponent<ObserverBehaviour>().TargetStatus.Status == Status.TRACKED)
            {
                canvas3Ui.SetActive(true);
            }
            count = 3;
        }

        if((tracker4.GetComponent<ObserverBehaviour>().TargetStatus.Status == Status.TRACKED ||
                tracker5.GetComponent<ObserverBehaviour>().TargetStatus.Status == Status.TRACKED || tracker6.GetComponent<ObserverBehaviour>().TargetStatus.Status == Status.TRACKED ||
                tracker7.GetComponent<ObserverBehaviour>().TargetStatus.Status == Status.TRACKED || tracker8.GetComponent<ObserverBehaviour>().TargetStatus.Status == Status.TRACKED ||
                tracker9.GetComponent<ObserverBehaviour>().TargetStatus.Status == Status.TRACKED || tracker10.GetComponent<ObserverBehaviour>().TargetStatus.Status == Status.TRACKED) || 
                (tracker1.GetComponent<ObserverBehaviour>().TargetStatus.Status == Status.TRACKED && count != 0) || (tracker2.GetComponent<ObserverBehaviour>().TargetStatus.Status == Status.TRACKED && count != 1)
                || (tracker3.GetComponent<ObserverBehaviour>().TargetStatus.Status == Status.TRACKED && count != 2))
        {
            count = 0;
            canvasFalseUi.SetActive(true);
        }
    }
}
