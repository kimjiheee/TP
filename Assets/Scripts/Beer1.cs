using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Beer1 : MonoBehaviour
{

    private void OnMouseEnter()  //마우스가 오브젝트 위에 있을 때
    {
        Debug.Log("마우스 맥주1에 올라가있어요");
        transform.localScale = new Vector3(1.2f, 1.2f, 1.2f);
    }

    private void OnMouseExit()
    {
        Debug.Log("마우스가 맥주1 벗어남");
        transform.localScale = new Vector3(1, 1, 1);
    }


}
