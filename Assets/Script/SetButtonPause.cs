using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetButtonPause : MonoBehaviour
{
    public Button button1942;
    public Button button1955;

    public ScenesManager scenesManager;
    // Start is called before the first frame update
    void Start()
    {
        scenesManager = GameObject.Find("ScenesManager").GetComponent<ScenesManager>();
        button1942.onClick.AddListener(scenesManager.GoTo1942);
        button1955.onClick.AddListener(scenesManager.GoTo1955);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
