using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.VFX;
using Random = UnityEngine.Random;


namespace MikeNspired.UnityXRHandPoser
{
    public class kill : MonoBehaviour
    {

        public ParticleSystem particleSystemSplash;
        public GameObject Mesh;
        AudioSource m_AudioSource;
        public UnityEventFloat onHit;

        void OnEnable()
        {
            if (particleSystemSplash)
                particleSystemSplash.Stop();
        }

        public void TakeDamage(float damage, GameObject damager)
        {
            onHit.Invoke(damage);
            //GetComponent<AudioRandomize>().PlaySound();
            particleSystemSplash.transform.parent = null;
            particleSystemSplash.gameObject.SetActive(true);
            particleSystemSplash.Play();
            Mesh.SetActive(false);

            Transform camera = Camera.main.transform;
            var position = transform.position - camera.position;

            Destroy(gameObject, 3);
        }
    }

}