using UnityEngine;
// ReSharper disable All

public class ControlaTiro : MonoBehaviour
{
    public GameObject Municao;
    public GameObject Disparo;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            //Instantiate serve para criar novos objetos
            Instantiate(Municao, Disparo.transform.position, Disparo.transform.rotation);
        }
    }
}
