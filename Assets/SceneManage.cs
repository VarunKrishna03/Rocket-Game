using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneManage : MonoBehaviour
{
   public void NextScene(int sceneno)
    {
        SceneManager.LoadScene(sceneno);
    }
}
