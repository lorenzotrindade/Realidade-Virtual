using UnityEngine;

public class Nurbspath : MonoBehaviour
{
    public float velocidade = 10;
    public float rotacao = 100;

    void Start()
    {
        Debug.Log("Olá Mundo!");
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            Debug.Log("W");
            transform.position += Vector3.forward * velocidade * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.S))
        {
            Debug.Log("S");
        }

        if (Input.GetKey(KeyCode.A))
        {
            Debug.Log("A");
        }

        if (Input.GetKey(KeyCode.D))
        {
            Debug.Log("D");
        }
    }
}