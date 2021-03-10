using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Caja : MonoBehaviour
{
    //variable velocidad de mov de la caja
    public float speed = 20f;
    //variable que contiene el gameobject de la cesta para acceder a sus componentes.
    [SerializeField] MeshRenderer cesta;
    //variable que me da el mesh renderer de la cesta
    bool cestaViva = false;
    [SerializeField] AudioSource audioSource;
    public AudioClip huevoRoto;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MoverCaja();



    }

    void MoverCaja()
    {
        //variables para crear movimiento de la nave
        float posX = transform.position.x;
        float despX = Input.GetAxis("Horizontal");
        float posZ = transform.position.z;
        float despZ = Input.GetAxis("Vertical");

        bool cKey = Input.GetButton("Fire1");

        if (Input.GetButton("Fire1"))
        {
           //no he conseguido hacer lo de la boleana para que oculte el renderer de la cesta
            print("hola");
        }



        //restriccion de movimiento en eje x
        if (posX < 20 && posX > -20 || posX < -20 && despX > 0 || posX > 20 && despX < 0)
        {
            transform.Translate(Vector3.right * Time.deltaTime * speed * despX, Space.World);
        }

        //restringir movimiento en el eje Z       
        if (posZ < 20 && posZ > -20 || posZ < -20 && despZ > 0 || posZ > 20 && despZ < 0)
        {
            transform.Translate(Vector3.forward * Time.deltaTime * speed * despZ, Space.World);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
          if (other.gameObject.tag == "Enemy")
            {
                audioSource.PlayOneShot(huevoRoto);
                print("Sonido");
                //Destroy(this.gameObject);
            }
    }



}
