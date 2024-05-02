using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))]
public class Deadblock : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.CompareTag("Player"))
            {
                GameManager.Instance.RemoveLife();
            }
    }
}
