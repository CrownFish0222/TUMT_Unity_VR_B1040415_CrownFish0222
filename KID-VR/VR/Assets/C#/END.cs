using UnityEngine;

public class END : MonoBehaviour
{
    public GameObject obj;
    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "HeadCollider" && GameManager.havekey == true)
        {
            obj.SetActive(true);
        }
    }
}
