using System;
using UnityEngine;

public class Dano : MonoBehaviour
{
    public string tagDoObjeto;
    public int dano = 1;
    public void OnCollisionEnter2D(Collision2D colisao)
    {
        if (colisao.gameObject.tag == tagDoObjeto)
        {
            int vida = colisao.gameObject.GetComponent<Personagem>().getVida();
            colisao.gameObject.GetComponent<Personagem>().setVida(vida-dano);
        }
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}