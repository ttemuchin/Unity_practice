using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zone2 : MonoBehaviour
{
    public GameObject spawn;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Enter zone2" + other.name);
        GameObject Obj = Instantiate(spawn);

        Obj.transform.position = (new Vector3(-68.74f, 4.54f, -141.7f));
        Destroy(gameObject);
    }
}
