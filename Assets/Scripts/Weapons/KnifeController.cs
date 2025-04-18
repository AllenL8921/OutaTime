using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnifeController : WeaponController
{
    AudioManager audioManager;

    // Start is called before the first frame update
    protected override void Start()
    {

        audioManager = FindObjectOfType<AudioManager>();   
        base.Start();
    }

    // Update is called once per frame
    protected override void Attack()
    {
        base.Attack();
        GameObject spawnedKnife = Instantiate(weaponData.Prefab);

        audioManager.PlaySFX(audioManager.knifeAttack);

        spawnedKnife.transform.position = transform.position; //Assign the position to be the same as this object which is parented to the player
        spawnedKnife.GetComponent<KnifeBehaviour>().DirectionChecker(pm.lastMovedVector);
    }
}
