using UnityEngine;

public class PararCarro : MonoBehaviour
{
    public Carro Carro;
    
    
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("chao"))
        {
            Carro.capotado = true;
        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("chao"))
        {
            Carro.capotado = false;
        }
    }
}
