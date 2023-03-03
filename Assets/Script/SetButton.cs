using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SetButton : MonoBehaviour
{
    public Button buttonUseds;
    public ScenesManager scenesManager;

    // Start is called before the first frame update
    void Start()
    {


        scenesManager = GameObject.Find("ScenesManager").GetComponent<ScenesManager>();
            buttonUseds.onClick.AddListener(scenesManager.LancementApplication);
        
    }

    public void ChangeScene (int sceneNumber)
    {
        SceneManager.LoadScene(sceneNumber);
    }

}

[System.Serializable]
public class ButtonUsed
{
    public Button m_button;
    public int m_sceneNumber;
}
