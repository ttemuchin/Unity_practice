using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Weapon : MonoBehaviour
{
    public Camera cam;
    public ParticleSystem partsPrefab;
    public PickUpAxe hasWeapon;
    public float DamageTimeOut = 4;
    private float _damageTime;

    void Update()
    {
        Debug.DrawRay(cam.transform.position, cam.transform.forward * 100, Color.red);

        if (Input.GetMouseButtonDown(0))
        {
            if (Physics.Raycast(cam.transform.position, cam.transform.forward, out RaycastHit hitInfo, 3.8f))
            {
                if (hitInfo.transform.TryGetComponent<a>(out var enemy))
                {
                    var quat = Quaternion.LookRotation(-cam.transform.forward);
                    
                    if (hasWeapon.canPickUp == true)
                    {
                        var c = Random.Range(2, 5);
                        if (c == 4) { var parts = Instantiate(partsPrefab, hitInfo.point, quat); }
                        enemy.SetDamage(c);
                       // Debug.Log("increased");
                    }
                    if (SceneManager.GetActiveScene().buildIndex == 3)
                    {
                        if (Time.time - _damageTime >= DamageTimeOut)
                        {
                            var b = Random.Range(3, 6);
                            if (b == 5) { var bossparts = Instantiate(partsPrefab, hitInfo.point, quat); }
                            enemy.SetDamage(b);
                            _damageTime = Time.time;                          
                        }
                    }
                    else { enemy.SetDamage(1); }
                    
                }

                /*if (hitInfo.transform.TryGetComponent<Boss>(out var BarBoss))
                {
                    Debug.Log("hit him");*/
                   /* var quat = Quaternion.LookRotation(-cam.transform.forward);
                    var parts = Instantiate(partsPrefab, hitInfo.point, quat);
                    BarBoss.SetDamage(3);*/
               // }
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
