using System.Collections;
using Vuforia;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Image = UnityEngine.UI.Image;

public class CheckCube : MonoBehaviour
{
    public GameObject CubeUpRight;
    public GameObject CubeUpLeft;
    public GameObject CubeBottomRight;
    public GameObject CubeBottomLeft;

    public Image URImage;
    public Image ULImage;
    public Image BRImage;
    public Image BLImage;

    public GameObject NotDetectAllCubeText;
    public GameObject Victory;

    public Sprite URColor;
    public Sprite ULColor;
    public Sprite BRColor;
    public Sprite BLColor;

    public bool m_riddleSolved = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        var trackableUpRight = CubeUpRight.GetComponent<ObserverBehaviour>();
        var statusUpRight = trackableUpRight.TargetStatus.Status;

        var trackableUpLeft = CubeUpLeft.GetComponent<ObserverBehaviour>();
        var statusUpLeft = trackableUpLeft.TargetStatus.Status;

        var trackableBottomRight = CubeBottomRight.GetComponent<ObserverBehaviour>();
        var statusBottomRight = trackableBottomRight.TargetStatus.Status;

        var trackableBottomLeft = CubeBottomLeft.GetComponent<ObserverBehaviour>();
        var statusBottomLeft = trackableBottomLeft.TargetStatus.Status;

        if (statusUpRight == Status.TRACKED && statusUpLeft == Status.TRACKED && statusBottomRight == Status.TRACKED && statusBottomLeft == Status.TRACKED)
        {
            NotDetectAllCubeText.SetActive(false);
            URImage.gameObject.SetActive(true);
            ULImage.gameObject.SetActive(true);
            BRImage.gameObject.SetActive(true);
            BLImage.gameObject.SetActive(true);
            CheckCubePosition();
        }
        else
        {
            URImage.gameObject.SetActive(false);
            ULImage.gameObject.SetActive(false);
            BRImage.gameObject.SetActive(false);
            BLImage.gameObject.SetActive(false);
            NotDetectAllCubeText.SetActive(true);
        }

    }

    public void CheckCubePosition()
    {
        if (CubeUpLeft.transform.position.x < CubeUpRight.transform.position.x && CubeUpLeft.transform.position.y > CubeBottomLeft.transform.position.y && CubeUpLeft.transform.position.x < CubeBottomRight.transform.position.x && CubeUpLeft.transform.position.y > CubeBottomRight.transform.position.y)
        {
            //1 2 3 4
            ULImage.sprite = ULColor;
            URImage.sprite = URColor;
            BLImage.sprite = BLColor;
            BRImage.sprite = BRColor;

            m_riddleSolved = true;

            URImage.gameObject.SetActive(false);
            ULImage.gameObject.SetActive(false);
            BRImage.gameObject.SetActive(false);
            BLImage.gameObject.SetActive(false);

            Victory.SetActive(true);
        }
        else if (CubeUpLeft.transform.position.x < CubeUpRight.transform.position.x && CubeUpLeft.transform.position.y > CubeBottomRight.transform.position.y && CubeUpLeft.transform.position.x < CubeBottomLeft.transform.position.x && CubeUpLeft.transform.position.y > CubeBottomLeft.transform.position.y)
        {
            //1 2 4 3
            ULImage.sprite = ULColor;
            URImage.sprite = URColor;
            BLImage.sprite = BRColor;
            BRImage.sprite = BLColor;
        }
        else if (CubeUpLeft.transform.position.x < CubeBottomRight.transform.position.x && CubeUpLeft.transform.position.y > CubeBottomLeft.transform.position.y && CubeUpLeft.transform.position.x < CubeUpRight.transform.position.x && CubeUpLeft.transform.position.y > CubeUpRight.transform.position.y)
        {
            //1 4 3 2
            ULImage.sprite = ULColor;
            URImage.sprite = BRColor;
            BLImage.sprite = BLColor;
            BRImage.sprite = URColor;
        }
        else if (CubeUpLeft.transform.position.x < CubeBottomRight.transform.position.x && CubeUpLeft.transform.position.y > CubeUpRight.transform.position.y && CubeUpLeft.transform.position.x < CubeBottomLeft.transform.position.x && CubeUpLeft.transform.position.y > CubeBottomLeft.transform.position.y)
        {
            //1 4 2 3
            ULImage.sprite = ULColor;
            URImage.sprite = BRColor;
            BLImage.sprite = URColor;
            BRImage.sprite = BLColor;
        }
        else if (CubeUpLeft.transform.position.x < CubeBottomLeft.transform.position.x && CubeUpLeft.transform.position.y > CubeUpRight.transform.position.y && CubeUpLeft.transform.position.x < CubeBottomRight.transform.position.x && CubeUpLeft.transform.position.y > CubeBottomRight.transform.position.y)
        {
            //1 3 2 4
            ULImage.sprite = ULColor;
            URImage.sprite = BLColor;
            BLImage.sprite = URColor;
            BRImage.sprite = BRColor;
        }
        else if (CubeUpLeft.transform.position.x < CubeBottomLeft.transform.position.x && CubeUpLeft.transform.position.y > CubeBottomRight.transform.position.y && CubeUpLeft.transform.position.x < CubeUpRight.transform.position.x && CubeUpLeft.transform.position.y > CubeUpRight.transform.position.y)
        {
            //1 3 4 2
            ULImage.sprite = ULColor;
            URImage.sprite = BLColor;
            BLImage.sprite = BRColor;
            BRImage.sprite = URColor;
        }
        else if (CubeUpLeft.transform.position.x > CubeUpRight.transform.position.x && CubeUpLeft.transform.position.y > CubeBottomRight.transform.position.y && CubeUpLeft.transform.position.x > CubeBottomLeft.transform.position.x && CubeUpLeft.transform.position.y > CubeBottomLeft.transform.position.y)
        {
            //2 1 3 4
            ULImage.sprite = URColor;
            URImage.sprite = ULColor;
            BLImage.sprite = BLColor;
            BRImage.sprite = BRColor;
        }
        else if (CubeUpLeft.transform.position.x > CubeUpRight.transform.position.x && CubeUpLeft.transform.position.y > CubeBottomLeft.transform.position.y && CubeUpLeft.transform.position.x > CubeBottomRight.transform.position.x && CubeUpLeft.transform.position.y > CubeBottomRight.transform.position.y)
        {
            //2 1 4 3
            ULImage.sprite = URColor;
            URImage.sprite = ULColor;
            BLImage.sprite = BRColor;
            BRImage.sprite = BLColor;
        }
        else if (CubeUpLeft.transform.position.x > CubeBottomRight.transform.position.x && CubeUpLeft.transform.position.y < CubeBottomLeft.transform.position.y && CubeUpLeft.transform.position.x > CubeUpRight.transform.position.x && CubeUpLeft.transform.position.y < CubeUpRight.transform.position.y)
        {
            //2 3 4 1
            ULImage.sprite = URColor;
            URImage.sprite = BLColor;
            BLImage.sprite = BRColor;
            BRImage.sprite = ULColor;
        }
        else if (CubeUpLeft.transform.position.x < CubeBottomRight.transform.position.x && CubeUpLeft.transform.position.y < CubeUpRight.transform.position.y && CubeUpLeft.transform.position.x < CubeBottomLeft.transform.position.x && CubeUpLeft.transform.position.y < CubeBottomLeft.transform.position.y)
        {
            //2 3 1 4
            ULImage.sprite = URColor;
            URImage.sprite = BLColor;
            BLImage.sprite = ULColor;
            BRImage.sprite = BRColor;
        }
        else if (CubeUpLeft.transform.position.x < CubeBottomLeft.transform.position.x && CubeUpLeft.transform.position.y < CubeUpRight.transform.position.y && CubeUpLeft.transform.position.x < CubeBottomRight.transform.position.x && CubeUpLeft.transform.position.y < CubeBottomRight.transform.position.y)
        {
            //2 4 1 3
            ULImage.sprite = URColor;
            URImage.sprite = BRColor;
            BLImage.sprite = ULColor;
            BRImage.sprite = BLColor;
        }
        else if (CubeUpLeft.transform.position.x > CubeBottomLeft.transform.position.x && CubeUpLeft.transform.position.y < CubeBottomRight.transform.position.y && CubeUpLeft.transform.position.x > CubeUpRight.transform.position.x && CubeUpLeft.transform.position.y < CubeUpRight.transform.position.y)
        {
            //2 4 3 1
            ULImage.sprite = URColor;
            URImage.sprite = BRColor;
            BLImage.sprite = BLColor;
            BRImage.sprite = ULColor;
        }
        else if (CubeUpLeft.transform.position.x > CubeBottomLeft.transform.position.x && CubeUpLeft.transform.position.y > CubeBottomRight.transform.position.y && CubeUpLeft.transform.position.x > CubeUpRight.transform.position.x && CubeUpLeft.transform.position.y > CubeUpRight.transform.position.y)
        {
            //3 1 2 4
            ULImage.sprite = BLColor;
            URImage.sprite = ULColor;
            BLImage.sprite = URColor;
            BRImage.sprite = BRColor;
        }
        else if (CubeUpLeft.transform.position.x > CubeBottomLeft.transform.position.x && CubeUpLeft.transform.position.y > CubeUpRight.transform.position.y && CubeUpLeft.transform.position.x > CubeBottomRight.transform.position.x && CubeUpLeft.transform.position.y > CubeBottomRight.transform.position.y)
        {
            //3 1 4 2
            ULImage.sprite = BLColor;
            URImage.sprite = ULColor;
            BLImage.sprite = BRColor;
            BRImage.sprite = URColor;
        }
        else if (CubeUpLeft.transform.position.x < CubeBottomRight.transform.position.x && CubeUpLeft.transform.position.y < CubeBottomLeft.transform.position.y && CubeUpLeft.transform.position.x < CubeUpRight.transform.position.x && CubeUpLeft.transform.position.y < CubeUpRight.transform.position.y)
        {
            //3 2 1 4
            ULImage.sprite = BLColor;
            URImage.sprite = URColor;
            BLImage.sprite = ULColor;
            BRImage.sprite = BRColor;
        }
        else if (CubeUpLeft.transform.position.x > CubeBottomRight.transform.position.x && CubeUpLeft.transform.position.y < CubeUpRight.transform.position.y && CubeUpLeft.transform.position.x > CubeUpRight.transform.position.x && CubeUpLeft.transform.position.y < CubeUpRight.transform.position.y)
        {
            //3 2 4 1
            ULImage.sprite = BLColor;
            URImage.sprite = URColor;
            BLImage.sprite = BRColor;
            BRImage.sprite = ULColor;
        }
        else if (CubeUpLeft.transform.position.x < CubeUpRight.transform.position.x && CubeUpLeft.transform.position.y < CubeBottomLeft.transform.position.y && CubeUpLeft.transform.position.x < CubeBottomRight.transform.position.x && CubeUpLeft.transform.position.y < CubeBottomRight.transform.position.y)
        {
            //3 4 1 2
            ULImage.sprite = BLColor;
            URImage.sprite = BRColor;
            BLImage.sprite = ULColor;
            BRImage.sprite = URColor;
        }
        else if (CubeUpLeft.transform.position.x > CubeUpRight.transform.position.x && CubeUpLeft.transform.position.y < CubeBottomRight.transform.position.y && CubeUpLeft.transform.position.x > CubeBottomLeft.transform.position.x && CubeUpLeft.transform.position.y < CubeBottomLeft.transform.position.y)
        {
            //3 4 2 1
            ULImage.sprite = BLColor;
            URImage.sprite = BRColor;
            BLImage.sprite = URColor;
            BRImage.sprite = ULColor;
        }
        else if (CubeUpLeft.transform.position.x > CubeBottomRight.transform.position.x && CubeUpLeft.transform.position.y > CubeUpRight.transform.position.y && CubeUpLeft.transform.position.x > CubeBottomLeft.transform.position.x && CubeUpLeft.transform.position.y > CubeBottomLeft.transform.position.y)
        {
            //4 1 3 2
            ULImage.sprite = BRColor;
            URImage.sprite = ULColor;
            BLImage.sprite = BLColor;
            BRImage.sprite = URColor;
        }
        else if (CubeUpLeft.transform.position.x > CubeBottomRight.transform.position.x && CubeUpLeft.transform.position.y > CubeBottomLeft.transform.position.y && CubeUpLeft.transform.position.x > CubeUpRight.transform.position.x && CubeUpLeft.transform.position.y > CubeUpRight.transform.position.y)
        {
            //4 1 2 3
            ULImage.sprite = BRColor;
            URImage.sprite = ULColor;
            BLImage.sprite = URColor;
            BRImage.sprite = BLColor;
        }
        else if (CubeUpLeft.transform.position.x < CubeBottomLeft.transform.position.x && CubeUpLeft.transform.position.y < CubeBottomRight.transform.position.y && CubeUpLeft.transform.position.x < CubeUpRight.transform.position.x && CubeUpLeft.transform.position.y < CubeUpRight.transform.position.y)
        {
            //4 2 1 3
            ULImage.sprite = BRColor;
            URImage.sprite = URColor;
            BLImage.sprite = ULColor;
            BRImage.sprite = BLColor;
        }
        else if (CubeUpLeft.transform.position.x > CubeBottomLeft.transform.position.x && CubeUpLeft.transform.position.y < CubeUpRight.transform.position.y && CubeUpLeft.transform.position.x > CubeBottomRight.transform.position.x && CubeUpLeft.transform.position.y < CubeBottomRight.transform.position.y)
        {
            //4 2 3 1
            ULImage.sprite = BRColor;
            URImage.sprite = URColor;
            BLImage.sprite = BLColor;
            BRImage.sprite = ULColor;
        }
        else if (CubeUpLeft.transform.position.x > CubeUpRight.transform.position.x && CubeUpLeft.transform.position.y < CubeBottomLeft.transform.position.y && CubeUpLeft.transform.position.x > CubeBottomRight.transform.position.x && CubeUpLeft.transform.position.y < CubeBottomRight.transform.position.y)
        {
            //4 3 2 1
            ULImage.sprite = BRColor;
            URImage.sprite = BLColor;
            BLImage.sprite = URColor;
            BRImage.sprite = ULColor;
        }
        else if (CubeUpLeft.transform.position.x < CubeUpRight.transform.position.x && CubeUpLeft.transform.position.y < CubeBottomRight.transform.position.y && CubeUpLeft.transform.position.x < CubeBottomLeft.transform.position.x && CubeUpLeft.transform.position.y < CubeBottomLeft.transform.position.y)
        {
            //4 3 1 2
            ULImage.sprite = BRColor;
            URImage.sprite = BLColor;
            BLImage.sprite = ULColor;
            BRImage.sprite = URColor;
        }
    }
}
