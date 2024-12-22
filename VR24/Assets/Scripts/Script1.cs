using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class Script1 : MonoBehaviour
{
    public GameObject test;
    public void ClickButton()
    {
        test.SetActive(!(test.activeSelf));
    }
}