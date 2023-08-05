using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public Camera cam;
    public ParticleSystem partsPrefab;

    void Start()
    {
        
    }

    void Update()
    {
        Debug.DrawRay(cam.transform.position, cam.transform.forward * 100, Color.red);

        if (Input.GetMouseButtonDown(0))
        {
            if (Physics.Raycast(cam.transform.position, cam.transform.forward, out RaycastHit hitInfo, 100f))
            {
                if (hitInfo.transform.TryGetComponent<a>(out var enemy))
                {
                    var quat = Quaternion.LookRotation(-cam.transform.forward);
                    var parts = Instantiate(partsPrefab, hitInfo.point, quat);
                    enemy.SetDamage(3);
                }
            }
        }
    }
}
/*    void Update()
    {
        Debug.DrawRay(cam.transform.position, cam.transform.forward * 100, Color.red);

        if (Input.GetMouseButtonDown(0))
        {
            if(Physics.Raycast(cam.transform.position, cam.transform.forward, out RaycastHit hitInfo, 100f))
            {
                if(hitInfo.transform.TryGetComponent<ColorChange>(out var colorChange))
                {
                    colorChange.ChangeColor(colorChange.red);
                }

                Debug.Log(hitInfo.transform.name);
            }
        }    
    }
}*/
