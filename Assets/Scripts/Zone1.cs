using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zone1 : MonoBehaviour
{
    //выбор между одним уникальным скриптом зоны для всех спавнеров(трансформ позишн ящика
    // либо в каждую зону можно добавить что-то ещё по типу изменения освещения или погоды..
    // баг на нахождение в зоне
    public GameObject spawn;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Enter zone1" + other.name);
        // spawn.isActive = true;
        GameObject Obj = Instantiate(spawn);

        Obj.transform.position = (new Vector3(-51f, 4.5f, -38.3f));
        Destroy(gameObject);
    }
}
