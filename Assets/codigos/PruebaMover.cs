using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PruebaMover : MonoBehaviour
{
    public float movimiento = 0;
    Vector3 PosicionInicial = new Vector3(0, 2.66f, 6.25f);


    // Start is called before the first frame update
    void Start()
    {
        //transform.position = PosicionInicial;
    }

    // Update is called once per frame
    void Update()
    {
        movimiento= movimiento + 0.1f;
        transform.position = new Vector3(movimiento + 0.1f * Time.deltaTime, 2.66f, 6.25f);
        //transform.position = new Vector3(movimiento * Time.deltaTime, 2.6631f, -37.0f);
    }
}
