using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SALTO : MonoBehaviour
{

    public int miEdad = 23;
    public float miAltura = 6.6f;
    public string miNombre = "Gogo";
    public bool tengoMelena = false;
    public Vector3 posInicial;
    public Color miColor;
    void Start()
    //miau
    {
       this.GetComponent<Transform>().position = posInicial;

       Vector3 positiconfuturs = new Vector3(100,10,1);

       this.GetComponent<SpriteRenderer>().flipX = true;
       

    }
   
    void Update()

    {transform.Translate(0,0.01f,0);
        float positionActual = this.GetComponent<Transform>().position.x; //x, y, z
        this.GetComponent<Transform>().position = new Vector3(positionActual+0.1f,0,0);
        Debug.Log ("Y tengo" +miEdad+ "años.");
    }
}
