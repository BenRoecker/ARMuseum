using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetButtonEnigmeToPause : MonoBehaviour
{
    public List<Button> buttontoPause;
    private ScenesManager scenesManager;
    // Start is called before the first frame update
    void Start()
    {
        scenesManager = GameObject.Find("ScenesManager").GetComponent<ScenesManager>();
        foreach(Button button in buttontoPause)
        {
            button.onClick.AddListener(scenesManager.EndTutoriel);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
