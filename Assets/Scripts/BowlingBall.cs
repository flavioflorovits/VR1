using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BowlingBall : MonoBehaviour
{
    [SerializeField] private Material defaultMaterial;
    [SerializeField] private Material selectedMaterial;
    public void HoverEnter()
    {
        gameObject.GetComponent<MeshRenderer>().material = selectedMaterial;
    }

    public void HoverExit()
    {
        gameObject.GetComponent<MeshRenderer>().material = defaultMaterial;
    }

}
