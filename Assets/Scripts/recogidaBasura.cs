using UnityEngine;
using System;

public class recogidaBasura : MonoBehaviour, Items
{
    public static event Action<int> OnCollect;
    public int points = 5;
    public void Collect()
    {
        OnCollect.Invoke(points);
        Destroy(gameObject); 
    }
}
