using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.VFX;
using Random = UnityEngine.Random;

namespace MikeNspired.UnityXRHandPoser {

    public class deathController : MonoBehaviour
    {


        public GameObject Mesh;
        public GameObject bullet;
        public UnityEventFloat onHit;
        

        void Awake()
        {
            setRigidbodyState(true);
            setColliderState(true);
        }

        public void OnCollisionEnter(Collision collision) {
            if (bullet != null && bullet.gameObject.tag == "guy") {
                Debug.Log("shot was registered. " + bullet);
                GetComponent<Animator>().enabled = false;
                setRigidbodyState(false);
                setColliderState(false);

                Destroy(gameObject, 3f); // remove npc from scene after 3s
            }
        }

        void setRigidbodyState(bool state) {
            Rigidbody[] rigidbodies = GetComponentsInChildren<Rigidbody>();

            foreach(Rigidbody rigidbody in rigidbodies) {
                rigidbody.isKinematic = state;
            }

            //GetComponent<Rigidbody>().isKinematic = !state;
        }

        void setColliderState(bool state) {
            Collider[] colliders = GetComponentsInChildren<Collider>();

            foreach(Collider collider in colliders) {
                collider.enabled = state;
            }

            //GetComponent<Collider>().enabled = !state;

        }
    }
}