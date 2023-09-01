using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaysForHero : MonoBehaviour
{
    public Selectable CurrentObj;
    public Camera cam;

    void LateUpdate()
    {
            if (Physics.Raycast(cam.transform.position, cam.transform.forward, out RaycastHit hitInfo, 5f))
            {
                //firstBook = hitInfo.collider.gameObject.GetComponent<Book1>(out var Book1);
                if (Input.GetMouseButtonDown(0) && (hitInfo.collider.gameObject.TryGetComponent<Book1>(out var Book)))
                {
                    Book.spawn();                
                }
            
                //Book2 secondBook = hitInfo.collider.gameObject.GetComponent<Book2>();
                if (Input.GetMouseButtonDown(0) && (hitInfo.collider.gameObject.TryGetComponent<Book2>(out var Book2)))
                {
                    Book2.spawn();
                }

                if (Input.GetMouseButtonDown(0) && (hitInfo.collider.gameObject.TryGetComponent<Stone>(out var stone)))
                {
                    var a = Random.Range(3, 5);
                    Debug.Log(a);
                    stone.SetDamage(a);
                }

            Selectable selectable = hitInfo.collider.gameObject.GetComponent<Selectable>();
                if (selectable)
                {
                    if (CurrentObj && CurrentObj != selectable)
                    {
                        CurrentObj.Deselect();
                    }
                    CurrentObj = selectable;
                    selectable.Select();
                }
                else
                {
                    if (CurrentObj)
                    {
                        CurrentObj.Deselect();
                        CurrentObj = null;
                    }
                }
            }
            else
            {
                if (CurrentObj)
                {
                    CurrentObj.Deselect();
                    CurrentObj = null;
                }
            }
    }
}

