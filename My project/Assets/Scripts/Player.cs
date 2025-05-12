
using UnityEngine;

public class Player : MonoBehaviour
{
    private int numero;

    public float velocidade = 30;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        numero = 0;
    }

// update is called once per frame
    void Update()
    {
        // Debug.Log(numero);
        // numero = numero +1

        if (Input.GetKey(KeyCode.A))
        {
            gameObject.transform.position += new Vector3(-velocidade * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey(KeyCode.D))
        {
            gameObject.transform.position += new Vector3(+velocidade * Time.deltaTime, 0, 0);
        }
    }
}