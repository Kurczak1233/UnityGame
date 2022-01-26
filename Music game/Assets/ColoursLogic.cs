using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColoursLogic : MonoBehaviour
{
    // Start is called before the first frame update

    // Start is called before the first frame update
    void Start()
    {
        Renderer render = GetComponent<Renderer>();
        var Plate13 = GameObject.Find("Plate13").GetComponent<Renderer>();
        if (getPlate("Plate13").material.color != Color.green)
        {
            Plate13.material.color = Color.blue;
        }
    }

    void Update()
    {
        if (getPlate("Plate13").material.color == Color.green)
        {
            setPaleteColor("Plate14", Color.blue);
        }
        if (getPlate("Plate14").material.color == Color.green)
        {
            setPaleteColor("Plate10", Color.blue);
        }
    }

    //private void OnTriggerEnter2D(Collider2D collision)
    //{
    //    setPaleteColor("Plate13", Color.green);
    //}
    Renderer getPlate(string name)
    {
       return GameObject.Find(name).GetComponent<Renderer>();
    }

    void setPaleteColor(string name, Color color)
    {
        var Plate14 = GameObject.Find(name).GetComponent<Renderer>();
        Plate14.material.color = color;
    }


}
