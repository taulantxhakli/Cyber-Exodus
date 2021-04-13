using UnityEngine;
using UnityEngine.AI;

public class Robot : MonoBehaviour
{
    [SerializeField] private GameObject _ragdoll;
    [SerializeField] private GameObject _animatedModel;
    [SerializeField] private NavMeshAgent _navmeshAgent;
    
    private bool _dead;

    private void Awake()
    {
        _ragdoll.gameObject.SetActive(false);
    }

    private void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            ToggleDead();
        }
    }

    [ContextMenu("ToggleDead")]
    private void ToggleDead()
    {
        _dead = !_dead;

        if (_dead)
        {
            CopyTransformData(_animatedModel.transform, _ragdoll.transform, _navmeshAgent.velocity);
            _ragdoll.gameObject.SetActive(true);
            _animatedModel.gameObject.SetActive(false);
            _navmeshAgent.enabled = false;
        }
        else
        {
            // Switch back to the model and disable the ragdoll
            _ragdoll.gameObject.SetActive(false);
            _animatedModel.gameObject.SetActive(true);
            _navmeshAgent.enabled = true;    
        }
        
    }

    private void CopyTransformData(Transform sourceTransform, Transform destinationTransform, Vector3 velocity)
    {
        if (sourceTransform.childCount != destinationTransform.childCount)
        {
            Debug.LogWarning("Invalid transform copy, they need to match transform hierarchies");
            return;
        }

        for (int i = 0; i < sourceTransform.childCount; i++)
        {
            var source = sourceTransform.GetChild(i);
            var destination = destinationTransform.GetChild(i);
            destination.position = source.position;
            destination.rotation = source.rotation;
            var rb = destination.GetComponent<Rigidbody>();
            if (rb != null)
                rb.velocity = velocity;
            
            CopyTransformData(source, destination, velocity);
        }
    }
}