using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoToLobby : MonoBehaviour
{

    public Button m_buttonToLobby;
    public ScenesManager m_sceneManager;

    // Start is called before the first frame update
    void Start()
    {
        m_buttonToLobby.onClick.AddListener(m_sceneManager.LancementApplication);
    }
}
