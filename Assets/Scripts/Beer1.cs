using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Beer1 : MonoBehaviour
{

    private void OnMouseEnter()  //���콺�� ������Ʈ ���� ���� ��
    {
        Debug.Log("���콺 ����1�� �ö��־��");
        transform.localScale = new Vector3(1.2f, 1.2f, 1.2f);
    }

    private void OnMouseExit()
    {
        Debug.Log("���콺�� ����1 ���");
        transform.localScale = new Vector3(1, 1, 1);
    }


}
