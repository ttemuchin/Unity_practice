using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zone1 : MonoBehaviour
{
    //����� ����� ����� ���������� �������� ���� ��� ���� ���������(��������� ������ �����
    // ���� � ������ ���� ����� �������� ���-�� ��� �� ���� ��������� ��������� ��� ������..
    // ��� �� ���������� � ����
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
