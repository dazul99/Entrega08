using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Exercise01 : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI count;

    private int sum = 0;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Cuenta());
        
    }

    private IEnumerator Cuenta()
    {
        for(int i=0; i<=10; i++)
        {
            sum += i;
            count.text = "Exercise 1\n" + sum;
            yield return new WaitForSeconds(1);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
