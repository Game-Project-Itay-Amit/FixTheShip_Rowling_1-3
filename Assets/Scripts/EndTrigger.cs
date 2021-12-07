
using UnityEngine;
using UnityEngine.SceneManagement;
public class EndTrigger : MonoBehaviour
{
    [SerializeField] string triggeringTag;
    [SerializeField] GameObject endName;

    void OnTriggerEnter(Collider other)
    {
        if(triggeringTag == other.tag){
            endName.SetActive(true);
        }
    }
}