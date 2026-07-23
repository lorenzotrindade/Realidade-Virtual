using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class baseTorno : MonoBehaviour
{
    //varavel de controle de velocidade
    public float speed;
    public float velocidade = 10;
    public float rotacao = 100;    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // // Update is called once per frame
    // void Update()
    // {
    //     transform.Translate(0, 0, speed * Time.deltaTime);
    //     // horizontal,vertical,profundidade
    //     // 1 signigica unidade
    //     // * delta.Time.. multiplciando pelo tempo, fazendoe ele ir 1m por segundo  

    // }
 
  void Update() {
    float vertical =input.GetAxis("Vertical");
    float horizontal = input.GetAxis("Horizontal");
    transform.Translate(0, velocidade * Time.deltaTime * vertical,0);
  }

}
