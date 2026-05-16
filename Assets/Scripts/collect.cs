using UnityEngine;

public class collect : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Items item = collision.GetComponent<Items>();
        if(item != null)
        {
            item.Collect();
        }
    }
}
