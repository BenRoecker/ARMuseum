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
        for(int i = 0; i < 1; i++)
        {
            if (count == 0 && tracker1.GetComponent<ObserverBehaviour>().TargetStatus.Status == Status.TRACKED && (tracker2.GetComponent<ObserverBehaviour>().TargetStatus.Status == Status.TRACKED) == false && (tracker3.GetComponent<ObserverBehaviour>().TargetStatus.Status == Status.TRACKED) == false)
            {
                count = 1;
                canvas1Ui.SetActive(true);
            }
            else if (count == 1 && tracker1.GetComponent<ObserverBehaviour>().TargetStatus.Status != Status.TRACKED && tracker2.GetComponent<ObserverBehaviour>().TargetStatus.Status == Status.TRACKED && tracker3.GetComponent<ObserverBehaviour>().TargetStatus.Status != Status.TRACKED)
            {
                count = 2;
                canvas2Ui.SetActive(true);
            }
            else if(count == 2 && tracker1.GetComponent<ObserverBehaviour>().TargetStatus.Status != Status.TRACKED && tracker2.GetComponent<ObserverBehaviour>().TargetStatus.Status != Status.TRACKED && tracker3.GetComponent<ObserverBehaviour>().TargetStatus.Status == Status.TRACKED)
            {
                canvas3Ui.SetActive(true);
            }
            else
            {
                canvas1Ui.SetActive(false);
                canvas2Ui.SetActive(false);
                canvas3Ui.SetActive(false);
            }
        }
    }
}
