using UnityEngine;

public class testes2 : MonoBehaviour
{
    public int resposta;
    
    void Start()
    {
        resposta = 0;
    }
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            resposta = 1;
        }
      
        else if (Input.GetKeyDown(KeyCode.V))
        {
            resposta = 2;
        }
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("A resposta é:" + resposta + "!");
        }
    }
}
