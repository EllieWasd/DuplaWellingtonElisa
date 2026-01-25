using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public GameObject mensagem;
    void Start()
    {
        
    }


    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            mensagem.SetActive(true);
        }
    }
}
