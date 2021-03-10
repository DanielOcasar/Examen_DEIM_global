using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrearHuevos : MonoBehaviour
{
    [SerializeField] GameObject Huevo;
    [SerializeField] Transform PosRef;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("HuevoCorrutina");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void GenerarHuevos()
    {
        float posRandomx = Random.Range(-20f, 20f);
        float posRandomz = Random.Range(-20f, 20f);
        float posRandomy = Random.Range(0f, 0f);

        Vector3 DestPos = new Vector3(posRandomx, posRandomy + 20, posRandomz);
        Vector3 NewPos = PosRef.position + DestPos;

        Instantiate(Huevo, NewPos, Quaternion.identity);
    }


    IEnumerator HuevoCorrutina()
    {
        for (int n = 0; n <= 4; n++)
            {
                GenerarHuevos();
                yield return new WaitForSeconds(4);
            }
        for (int n = 5; n <= 10; n++)
        {
            GenerarHuevos();
            yield return new WaitForSeconds(2);
        }
        for (int n = 11; ; n++)
        {

            GenerarHuevos();
            yield return new WaitForSeconds(0.5f);
        }
    }
}
