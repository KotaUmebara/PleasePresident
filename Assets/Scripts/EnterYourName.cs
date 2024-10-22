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

    //���s�Ȃ�
    public void OnValueChanged()
    {
        value = inputField.GetComponent<InputField>().text;
        if (value.IndexOf("\n") != -1)
        {
            value = value.Replace("\r", "").Replace("\n", "");
            inputField.GetComponent<InputField>().text = value;
        }
    }

    //���͂��ꂽ���O����ǂݎ���ăR���\�[���ɏo�͂���֐�
    public void GetInputName()
    {
        //InputField����e�L�X�g�����擾����
        yourName = inputField.text;
        Debug.Log(yourName);
        GameManager.instance.name = yourName;
        //���̓t�H�[���̃e�L�X�g����ɂ���
        InitInputField();
    }

    /// ���͒l�����Z�b�g���āA�t�B�[���h�Ƀt�H�[�J�X����
    void InitInputField()
    {
        inputField.text = "";
        inputField.ActivateInputField();
    }
}
