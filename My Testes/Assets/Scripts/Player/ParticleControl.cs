using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleControl : MonoBehaviour
{
    [SerializeField] private ParticleSystem particleSys;

    private Player player;

    private void Awake()
    {
        player = FindObjectOfType<Player>();
    }

    void Update()
    {
        if (!player.IsPaused)
        {
            if (particleSys != null)
            {
                ParticleActive();
            }
        }
    }

    private void ParticleActive()
    {
        if (Input.GetMouseButtonDown(0))
        {
            particleSys.Play();
        }
        else if (Input.GetMouseButton(0))
        {
            particleSys.Play();
        }
    }
}
