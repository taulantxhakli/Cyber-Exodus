using System;
using UnityEngine;

namespace MikeNspired.UnityXRHandPoser
{
    public class SimpleCollisionDamage : MonoBehaviour
    {
        [SerializeField] private float damage = 10;
        [SerializeField] private GameObject metalDecal = null;
        [SerializeField] private GameObject fleshDecal = null;
        [SerializeField] private GameObject woodDecal = null;
        [SerializeField] private bool destroyOnCollision = true, triggerDamage = false;

        private void OnCollisionEnter(Collision collision)
        {
            if (collision.rigidbody?.GetComponent<SimpleCollisionDamage>()) return;

            collision.transform.GetComponentInParent<IDamageable>()?.TakeDamage(damage, gameObject);

            CheckForImpacteDecalType(collision);

            if (destroyOnCollision)
                Destroy(this.gameObject);

            // Kill enemy when shot 
            if (collision.transform.tag == "enemy")
            {
                Debug.Log("shot was registered.");
                GetComponent<Animator>().enabled = false;
                Destroy(collision.gameObject, 3f);
            }

        }

        private void OnTriggerEnter(Collider other)
        {
            if (!triggerDamage) return;

            other.transform.GetComponentInParent<IDamageable>()?.TakeDamage(damage, gameObject);

            if (destroyOnCollision)
                Destroy(this.gameObject);
        }

        void CheckForImpacteDecalType(Collision collision)
        {
            var impact = collision.transform.GetComponentInParent<IImpactType>();

            if (impact != null)
            {
                var impactType = impact.GetImpactType();
                switch (impactType)
                {
                    case ImpactType.Flesh:
                        SpawnDecal(collision, fleshDecal);
                        break;
                    case ImpactType.Metal:
                        SpawnDecal(collision, metalDecal);
                        break;
                    case ImpactType.Wood:
                        SpawnDecal(collision, woodDecal);
                        break;
                    case ImpactType.Neutral:
                        SpawnDecal(collision, metalDecal);
                        break;
                    default:
                        SpawnDecal(collision, metalDecal);
                        break;
                }
            }
            else
                SpawnDecal(collision, metalDecal);
        }

        // Mike Addition
        //void KillEnemy(Collision hit, GameObject death)
        //{
         //   death.GetComponent<deathController>().OnCollisionEnter();
         //
        //    if (guy != null)
         //   {
         //       guy.OnCollisionEnter();
         //   }
        //}


    void SpawnDecal(Collision hit, GameObject decalPrefab)
        {
            if (!decalPrefab) return;
            ContactPoint contact = hit.contacts[0];
            GameObject spawnedDecal = Instantiate(decalPrefab, contact.point, Quaternion.LookRotation(contact.normal));
            spawnedDecal.transform.SetParent(hit.collider.transform);
        }
    }
}