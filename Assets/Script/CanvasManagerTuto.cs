using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasManagerTuto : MonoBehaviour
{
    private ScenesManager ScenesManager;
    // Start is called before the first frame update
    void Start()
    {
        ScenesManager = GameObject.Find("ScenesManager").GetComponent<ScenesManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ShowResult()
    {
        ScenesManager.EndTutoriel();
    }
}
