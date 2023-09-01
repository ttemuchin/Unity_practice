using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stone : MonoBehaviour
{
    public int StartHp = 11;
    public int NowHp;
    public ParticleSystem partsPrefab;
    public Camera cam;

    private void Start()
    {
        NowHp = StartHp;
    }

    public void SetDamage(int damage)
    {
        NowHp -= damage;

        if (NowHp <= 0)
        {
            if (Physics.Raycast(cam.transform.position, cam.transform.forward, out RaycastHit hitInfo, 5f))
            {
                if (hitInfo.collider.gameObject.TryGetComponent<Stone>(out var stone))
                {
                    var quat = Quaternion.LookRotation(cam.transform.up); ////??????????
                    var parts = Instantiate(partsPrefab, hitInfo.point, quat);
                }
            }
            Destroy(gameObject);
        }

    }
}
