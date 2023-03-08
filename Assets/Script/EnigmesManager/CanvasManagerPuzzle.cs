using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CanvasManagerPuzzle : MonoBehaviour
{

    [Header("UI Element")]
    public Button m_infoButton;
    public Button m_cardQuitButton;
    public Button m_cardButton;


    public GameObject m_textInfo;
    public GameObject m_textCard;

    public bool m_infoOn = false;
    public bool m_cardOn = true;

    // Start is called before the first frame update
    void Start()
    {
        m_infoButton.onClick.AddListener(InfoCanvasManager);
        m_cardButton.onClick.AddListener(CardCanvasManager);
        m_cardQuitButton.onClick.AddListener(CardCanvasManager);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void InfoCanvasManager()
    {
        if(m_infoOn == false)
        {
            m_textInfo.SetActive(true);
            m_infoOn = true;
        }
        else if(m_infoOn == true)
        {
            m_textInfo.SetActive(false);
            m_infoOn = false;
        }
    }

    public void CardCanvasManager()
    {
        if(m_cardOn == false)
        {
            m_textCard.SetActive(true);
            m_cardOn = true;
        }
        else if(m_cardOn == true)
        {
            m_textCard.SetActive(false);
            m_cardOn = false;
        }
    }
}
