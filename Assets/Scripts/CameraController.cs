using UnityEngine;
using UnityEngine.UI;

public class CameraController : MonoBehaviour
{
    [SerializeField] private Button up;
    [SerializeField] private Button down;
    [SerializeField] private Button face;
    [SerializeField] private Button left;

    void Update()
    {
        up.onClick.AddListener(SwitchUp);
        down.onClick.AddListener(SwitchDown);
        face.onClick.AddListener(SwitchFace);
        left.onClick.AddListener(SwitchLeft);
    }

    void SwitchUp()
    {
        transform.eulerAngles = new Vector3(90, 0, 0);
    }

    void SwitchDown()
    {
        transform.eulerAngles = new Vector3(270, 180, 0);
    }

    void SwitchFace()
    {
        transform.eulerAngles = Vector3.zero;
    }

    void SwitchLeft()
    {
        transform.eulerAngles = new Vector3(0, 270, 0);
    }
}
