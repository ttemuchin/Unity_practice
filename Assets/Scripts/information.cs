using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class information : MonoBehaviour
{
    public menu pausePrefab;
     // Start is called before the first frame update
        void Start()
        {

        }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            if (SceneManager.GetActiveScene().buildIndex == 0)
            {
                Instantiate(pausePrefab);
            }
            Debug.Log("Pause");
            Time.timeScale = 0f;
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            Destroy(gameObject);
        }
    }
    public void close()
    {
        Instantiate(pausePrefab);
        Destroy(gameObject);
    }

}
