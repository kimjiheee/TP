using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Beer2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseEnter()  //���콺�� ������Ʈ ���� ���� ��
    {
        Debug.Log("���콺 ����2�� �ö��־��");
        transform.localScale = new Vector3(1.2f, 1.2f, 1.2f);
    }

    private void OnMouseExit()
    {
        Debug.Log("���콺�� ����2 ���");
        transform.localScale = new Vector3(1, 1, 1);
    }
}
