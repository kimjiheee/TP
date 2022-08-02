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
                Debug.Log("치킨 클릭");
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

    private void OnMouseEnter()  //마우스가 오브젝트 위에 있을 때
    {
        Debug.Log("마우스 치킨에 올라가있어요");
        transform.localScale = new Vector3(1.2f, 1.2f, 1.2f);
    }

    private void OnMouseExit()
    {
        Debug.Log("마우스가 치킨 벗어남");
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


//미니 게임 ->바로 미니게임으로 연결
//전투 -> 전투로 연결


//요리 주기 누르면..
//테이블 위에 요리 다여섯가지 있고.. (
//클릭하면 증가 스탯 알려줌
//스탯 확인하면 닫기/먹이기 둘 중에 하나 선택
//테이블 위에 내가 선택한 요리 하나와 앉아잇는 캐릭터(?) . 몇 초 정도 우적우적 효과음이랑 캐릭터 움직이는 모션 후에 식사 끝나고 스탯 올라가ㅏㅁ


//mageHp = 10;
//int mageMp = 8;
//int mageAttack = 7;
//int mageMagic = 6;
//int mageDefence = 5;
//float mageSpeed 

//치킨은 먹으면 hp 랜덤값 오르고, 나머지 음료는 마시면 능력치 하나씩 오름