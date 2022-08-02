using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeToGF : MonoBehaviour
{
   public void SceneChange()
    {
        SceneManager.LoadScene("FoodScene");
    }
}
