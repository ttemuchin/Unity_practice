using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zone4 : MonoBehaviour
{
    public GameObject spawn;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Enter zone4" + other.name);
        GameObject Obj = Instantiate(spawn);

        Obj.transform.position = (new Vector3(60.67f, 4.5f, -86.12f));
        Destroy(gameObject);
    }
}
