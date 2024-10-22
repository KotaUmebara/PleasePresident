using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnterYourName : MonoBehaviour
{
    public InputField inputField;
    public string yourName;
    private string value;
    void Start()
    {
        inputField = inputField.GetComponent<InputField>();
        InitInputField();
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(yourName);
    }

    //改行なし
    public void OnValueChanged()
    {
        value = inputField.GetComponent<InputField>().text;
        if (value.IndexOf("\n") != -1)
        {
            value = value.Replace("\r", "").Replace("\n", "");
            inputField.GetComponent<InputField>().text = value;
        }
    }

    //入力された名前情報を読み取ってコンソールに出力する関数
    public void GetInputName()
    {
        //InputFieldからテキスト情報を取得する
        yourName = inputField.text;
        Debug.Log(yourName);
        GameManager.instance.name = yourName;
        //入力フォームのテキストを空にする
        InitInputField();
    }

    /// 入力値をリセットして、フィールドにフォーカスする
    void InitInputField()
    {
        inputField.text = "";
        inputField.ActivateInputField();
    }
}
