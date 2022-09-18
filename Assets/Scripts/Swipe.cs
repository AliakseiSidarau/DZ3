using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swipe : MonoBehaviour
{
    Vector3 PrevPosition = Vector3.zero;
    Vector3 PosDelta = Vector3.zero;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
            PrevPosition = Input.mousePosition;
        if (Input.GetMouseButton(0))
        {
            PosDelta = Input.mousePosition - PrevPosition;
            transform.rotation = Quaternion.Euler(0, PosDelta.x, 0);
        }
        if (Input.GetMouseButtonUp(0))
        {
            transform.rotation = Quaternion.identity;
        }
    }
}
