using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Selectable : MonoBehaviour
{
    public void Select()
    {
        GetComponent<Transform>().localScale = Vector3.one * 1.4f;
    }

    public void Deselect()
    {
        GetComponent<Transform>().localScale = Vector3.one * 1f;
    }
}
