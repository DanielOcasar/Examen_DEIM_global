using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camara : MonoBehaviour

{   
    //variable para pedir la posicion de la caja. 
    [SerializeField] Transform posCaja;
    //variable para tener musica constante
    [SerializeField] AudioSource BGMusic;

    // Start is called before the first frame update
    void Start()
    {
        //acceder al componente de audiosource
        BGMusic = GetComponent<AudioSource>();
    }


    // Update is called once per frame
    void Update()
    {
        //transfrom de la camara para que mire a la caja
        transform.LookAt(posCaja);
    }
}

