using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zone3 : MonoBehaviour
{
    public GameObject spawn;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Enter zone3" + other.name);
        GameObject Obj = Instantiate(spawn);

        Obj.transform.position = (new Vector3(-88.35f, 4.5f, -144.4f));
        Destroy(gameObject);
    }
}
