using UnityEngine;
using UnityEngine.UI;

public class Progress : MonoBehaviour
{
    int progressAmount;
    public Slider progressSlider;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //progreso total
        progressAmount = 0; 
        progressSlider.value = 0;
        recogidaBasura.OnCollect += IncreaseProgressAmount;
    }
    void IncreaseProgressAmount(int amount)
    {
        progressAmount += amount;
        progressSlider.value = progressAmount; //actualizar barra de progreso

        if(progressAmount>= 50)
        {
            Debug.Log("Level Completed");
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
