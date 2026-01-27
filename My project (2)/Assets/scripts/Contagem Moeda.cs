
using UnityEngine;
using UnityEngine.UI;
public class ContagemMoeda : MonoBehaviour
{
   public int coinCount;
   public Text coinText;
    void Start()
    {
        
    }

    
    void Update()
    {
        coinText.text = "contagem moeda: " + coinCount.ToString();
    }
}
