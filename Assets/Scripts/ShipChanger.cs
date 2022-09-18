using UnityEngine;
using UnityEngine.UI;

public class ShipChanger : MonoBehaviour
{
    private GameObject starship;

    [SerializeField] private Button redButton;
    [SerializeField] private Button blueButton;
    [SerializeField] private Button yellowButton;
    [SerializeField] private Button greenButton;

    [SerializeField] private Material red;
    [SerializeField] private Material blue;
    [SerializeField] private Material yellow;
    [SerializeField] private Material green;

    [SerializeField] private GameObject[] arr = new GameObject[3];

    [SerializeField] private Button left;
    [SerializeField] private Button right;

    //private int i = 0;

    private void Start()
    {
        starship = arr[0];
    }

    void Update()
    {
        redButton.onClick.AddListener(RedChange);

        blueButton.onClick.AddListener(BlueChange);

        yellowButton.onClick.AddListener(YellowChange);

        greenButton.onClick.AddListener(GreenChange);

        right.onClick.AddListener(RightButton);

        left.onClick.AddListener(LeftButton);
    }

    void RedChange()
    {
        starship.GetComponent<Renderer>().material = red;
    }

    void BlueChange()
    {
        starship.GetComponent<Renderer>().material = blue;
    }

    void YellowChange()
    {
        starship.GetComponent<Renderer>().material = yellow;
    }

    void GreenChange()
    {
        starship.GetComponent<Renderer>().material = green;
    }

    public void RightButton()
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i].activeInHierarchy == true)
            {
                if (i == arr.Length - 1)
                {
                    arr[i].SetActive(false);
                    i = 0;
                    arr[i].SetActive(true);
                    starship = arr[i];
                    break;
                }
                arr[i].SetActive(false);
                arr[i + 1].SetActive(true);
                starship = arr[i + 1];
                break;
            }
        }
    }

    public void LeftButton()
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i].activeInHierarchy == true)
            {
                if (i == 0)
                {
                    arr[i].SetActive(false);
                    i = arr.Length - 1; ;
                    arr[i].SetActive(true);
                    starship = arr[i];
                    break;
                }
                arr[i].SetActive(false);
                arr[i - 1].SetActive(true);
                starship = arr[i - 1];
                break;
            }
        }
    }
}