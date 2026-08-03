using UnityEngine;

public class NurbsPath1 : MonoBehaviour
{
    public float velocidade = 10;
    public float rotacao = 100;

    void Start()
    {
        Debug.Log("Olá Mundo!");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(Input.GetAxis("Vertical"));
        float Vertical = Input.GetAxis("Vertical");
        float Horizontal = Input.GetAxis("Horizontal");
        transform.Translate(0, 0, velocidade * Time.deltaTime * Vertical);
        transform.Translate(0, rotacao * Time.deltaTime * Horizontal, 0);

    }
}
