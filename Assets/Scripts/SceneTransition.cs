using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransition : MonoBehaviour
{
    public void OnClickStart()
    {
        SceneManager.LoadScene("NameScene");
    }

    public void OnClickNameDecision()
    {
        SceneManager.LoadScene("GameScene");
    }
}
