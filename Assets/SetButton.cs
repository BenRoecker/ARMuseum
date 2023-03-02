using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SetButton : MonoBehaviour
{
    public List<ButtonUsed> buttonUseds;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < buttonUseds.Count; i++)
        {
            buttonUseds[i].m_button.onClick.AddListener(delegate { ChangeScene(buttonUseds[i].m_sceneNumber); });
        }
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
