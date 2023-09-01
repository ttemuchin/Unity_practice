using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Book2 : MonoBehaviour
{
    public introToBoss book1Prefab;

    public void spawn()
    {
        Instantiate(book1Prefab);
        Debug.Log("spawn book2");
    }
}
