using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextManager : MonoBehaviour
{
    public Button m_next;
    public Button m_return;
    public Button m_close;

    public GameObject m_canvas;

    public GameObject m_text;

    public GameObject m_imageOne;
    public GameObject m_imageTwo;
    public GameObject m_imageThree;

    public int m_indice = 0;

    // Start is called before the first frame update
    void Start()
    {
        m_next.onClick.AddListener(Next);
        m_return.onClick.AddListener(Return);
        m_close.onClick.AddListener(Close);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Next()
    {
        if(m_indice == 0)
        {
            m_text.SetActive(false);
            m_imageOne.SetActive(true);
            m_indice = 1;
        }
        else if(m_indice == 1)
        {
            m_imageOne.SetActive(false);
            m_imageTwo.SetActive(true);
            m_indice = 2;
        }
        else if(m_indice == 2)
        {
            m_imageTwo.SetActive(false);
            m_imageThree.SetActive(true);
            m_indice = 3;
        }
    }

    public void Return()
    {
        if (m_indice == 3)
        {
            m_imageThree.SetActive(false);
            m_imageTwo.SetActive(true);
            m_indice = 2;
        }
        else if (m_indice == 2)
        {
            m_imageTwo.SetActive(false);
            m_imageOne.SetActive(true);
            m_indice = 1;
        }
        else if (m_indice == 1)
        {
            m_imageOne.SetActive(false);
            m_text.SetActive(true);
            m_indice = 0;
        }
    }

    public void Close() 
    {
        m_indice = 0;
        m_text.SetActive(true);
        m_imageOne.SetActive(false);
        m_imageTwo.SetActive(false);
        m_imageThree.SetActive(false);

        m_canvas.SetActive(false);
    }
    
}
