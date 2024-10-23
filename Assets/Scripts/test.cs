using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class test : MonoBehaviour
{
    public Text a;
    // Start is called before the first frame update
    void Start()
    {
        Text score_text = a.GetComponent<Text>();
        // テキストの表示を入れ替える
        score_text.text = GameManager.instance.president;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnClickDamege()
    {
        GameManager.instance.happiness = -1;
    }
}
