using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class introToBoss : MonoBehaviour
{

    void Start()
    {
        Time.timeScale = 0f;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Boss");
            Time.timeScale = 1f;
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
            Destroy(gameObject);
        }
    }
}
