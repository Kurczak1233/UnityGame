using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColorController : MonoBehaviour
{

    private Color m_oldColor = Color.white;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        Renderer render = GetComponent<Renderer>();
        if (render.material.color == Color.blue || render.material.color == Color.green)
        {
            render.material.color = Color.green;
        }
        else
        {
            render.material.color = Color.red;
        }
    }
}
