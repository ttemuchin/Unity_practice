using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Portal : MonoBehaviour
{
    public Transform positionA;
    public int level = 1;

    private void OnTriggerEnter(Collider other)
    {
        //        other.transform.position = positionA.position;
        SceneManager.LoadScene(level);
        Debug.Log("Enter "+ other.name);
    }
}
