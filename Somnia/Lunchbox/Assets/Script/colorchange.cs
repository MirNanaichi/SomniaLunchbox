using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colorchange : MonoBehaviour
{
    //Reference to Scripte Renderer component
    private Renderer rend;

    //Color value that we can set in Inspector
    //It's write by Default
    [SerializeField]
    private Color colorToTurnTo = Color.white;

    //Use this for initialization
    private void Start()
    {
        //Assign Renderer component to rend variable
        rend = GetComponent<Renderer>();

        //change sprite color to selected color
        rend.material.color = colorToTurnTo;
    }
}
