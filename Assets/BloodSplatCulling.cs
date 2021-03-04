using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BloodSplatCulling : MonoBehaviour
{
    [SerializeField] protected float maxTimeAlive;
    protected float currentTimer;
    protected ParticleSystem bloodParticles;

    protected void Awake()
    {
        bloodParticles = GetComponent<ParticleSystem>();
    }

    protected void Start()
    {
        currentTimer = maxTimeAlive;
    }

    protected void Update()
    {
        currentTimer -= Time.deltaTime;

        if (currentTimer <= 0f)
            Destroy(gameObject);
    }
}
