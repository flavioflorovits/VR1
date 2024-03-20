using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomInput : MonoBehaviour
{
    [SerializeField] private GameObject menuCanvas;
    public void OnMenu()
    {
        menuCanvas.SetActive(!menuCanvas.activeInHierarchy);
    }

}
