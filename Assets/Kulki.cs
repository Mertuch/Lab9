using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kulki : MonoBehaviour
{

    public GameObject[] kulka;

    // Start is called before the first frame update

    void Start()
    {
        //Instantiate(kulka, transform.position, Quaternion.identity);
        //Invoke("GenerujKulki", 3f);
        InvokeRepeating("GenerujKulki", 3f, 3f);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            CancelInvoke("GenerujKulki");
        }
        if(Input.GetKeyDown(KeyCode.Space))
        {
            GenerujKulki();
        }
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            GenerujKulke(0);
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            GenerujKulke(1);
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            GenerujKulke(2);
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            GenerujKulke(3);
        }
        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            GenerujKulke(4);
        }

    }

    void GenerujKulki()
    {
        int los = Random.Range(0, kulka.Length);
        Instantiate(kulka[los], transform.position, Quaternion.identity);
    }
    void GenerujKulke(int los)
    {
        Instantiate(kulka[los], transform.position, Quaternion.identity);
    }
}
