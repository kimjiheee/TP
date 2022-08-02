using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Chicken : MonoBehaviour
{
    public GameObject yesbutton;
    public GameObject nobutton;
    public GameObject eatbutton;

    //public int hp;
    //public int mp;

    //public int atk;
    //public int wis;
    //public int def;
    //public int dex;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Physics.Raycast(ray, out hit);

            if (hit.transform.gameObject.tag == "Chicken")
            {
                Debug.Log("ġŲ Ŭ��");
                //mouseClick = false;
                //transform.localScale = new Vector3(1.2f, 1.2f, 1.2f);

                yesbutton.SetActive(true);
                nobutton.SetActive(true);
                eatbutton.SetActive(true);

            }

            //if (hit.transform.gameObject.tag == "no")
            //{
            //    yesbutton.SetActive(false);
            //    nobutton.SetActive(false);
            //    eatbutton.SetActive(false);
            //}
        }
    }

    private void OnMouseEnter()  //���콺�� ������Ʈ ���� ���� ��
    {
        Debug.Log("���콺 ġŲ�� �ö��־��");
        transform.localScale = new Vector3(1.2f, 1.2f, 1.2f);
    }

    private void OnMouseExit()
    {
        Debug.Log("���콺�� ġŲ ���");
        transform.localScale = new Vector3(1, 1, 1);
    }

    public void EraseAllButton()
    {
        yesbutton.SetActive(false);
        nobutton.SetActive(false);
        eatbutton.SetActive(false);
        //transform.localScale = new Vector3(1, 1, 1);
    }

    public void ChickenYes()
    {
        eatbutton.SetActive(false);

        TextMeshProUGUI btnText = eatbutton.GetComponentInChildren<TextMeshProUGUI>();
        btnText.text = "hp up";
        eatbutton.SetActive(true);
    }


}


//�̴� ���� ->�ٷ� �̴ϰ������� ����
//���� -> ������ ����


//�丮 �ֱ� ������..
//���̺� ���� �丮 �ٿ������� �ְ�.. (
//Ŭ���ϸ� ���� ���� �˷���
//���� Ȯ���ϸ� �ݱ�/���̱� �� �߿� �ϳ� ����
//���̺� ���� ���� ������ �丮 �ϳ��� �ɾ��մ� ĳ����(?) . �� �� ���� �������� ȿ�����̶� ĳ���� �����̴� ��� �Ŀ� �Ļ� ������ ���� �ö󰡤���


//mageHp = 10;
//int mageMp = 8;
//int mageAttack = 7;
//int mageMagic = 6;
//int mageDefence = 5;
//float mageSpeed 

//ġŲ�� ������ hp ������ ������, ������ ����� ���ø� �ɷ�ġ �ϳ��� ����