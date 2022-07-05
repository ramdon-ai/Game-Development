using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MunculMusuh : MonoBehaviour
{
    public GameObject Enemy;
    public float posisiMinimal, posisiMaximal;
    public float waktuMinimal, waktuMaximal;

    void Start()
    {
        StartCoroutine(MunculinMusuh());
    }

    void Update()
    {
        
    }
    IEnumerator MunculinMusuh()
    {
        Instantiate(Enemy, transform.position + Vector3.right * Random.Range(posisiMinimal,posisiMaximal),
            Quaternion.identity);
        yield return new WaitForSeconds(
            Random.Range(waktuMinimal, waktuMaximal));
        StartCoroutine(MunculinMusuh());
    }
}
